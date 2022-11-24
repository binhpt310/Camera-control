using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {

        static String filename = "";

        String folderpath = "";

        int packageAmount;

        int length = 0;
        public string path()
        {
            //String filename = "";
            //String folderpath = "C:/Users/7490/Documents/VisualStudioProjects/WindowsFormsApp1/textfile/";
            return folderpath + filename;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] portList = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(portList);

            openport_btn.Enabled = true;
            senddata_btn.Enabled = false;

            filename = saved_file_name_txt.Text;

        }

        private void Form1_Close(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }

        private void openport_btn_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(baudrate_txt.Text))
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt32(baudrate_txt.Text);
                serialPort1.Open();
                openport_btn.Enabled = false;
                //closeport_btn.Enabled = true;
                serialPort1.ReadTimeout = 1000;
                //serialPort1.WriteTimeout = 600;
            }

            else
                MessageBox.Show("Please check Port name and Baudrate");

        }

        private void senddata_btn_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
                serialPort1.Open();

            if (String.IsNullOrEmpty(command_txt.Text) == false)
            {
                try
                {
                    String originalCommand = command_txt.Text.Replace(" ", ""); //Full command as String
                    char[] ch = originalCommand.ToCharArray(); //Command split as char array

                    char[] packageSizeArray = ch.Skip(10).Take(2).ToArray();
                    var str = string.Join(" ", packageSizeArray).Replace(" ", "");

                    string packageSizeHex = "0x" + str;
                    int packageSizeNumber1 = Int32.Parse(packageSizeHex.Substring(2), NumberStyles.HexNumber);
                    length = packageSizeNumber1 * 256 + 8;

                    //Need a for loop here

                    Thread workerThread = new Thread(new ThreadStart(() =>
                    {
                        for (int i = 0; i <= 5; i++)
                        {
                            if (ch != null)
                            {
                                serialPort1.Write(HexString2Bytes(originalCommand), 0, HexString2Bytes(originalCommand).Length);
                                Thread.Sleep(200);

                                get_package_txt.Text = ShowPackageAmount(sender, e).ToString();

                                //Thread workerThread = new Thread(() => this.ReadAndWriteData(sender, e));

                                senddata_btn.BeginInvoke(new MethodInvoker(() => { senddata_btn.Enabled = false; }));
                                ReadAndWriteData(sender, e);
                                serialPort1.BaseStream.Flush();
                                serialPort1.DiscardOutBuffer();
                                senddata_btn.BeginInvoke(new MethodInvoker(() => { senddata_btn.Enabled = true; }));
                            }
                            else
                                errortxt.Text = "Your command is incorrect !";
                        }
                    }
                    ));
                    workerThread.Start();
                    //workerThread.Join();
                }

                catch (IOException er)
                {
                    errortxt.Text = er.ToString();
                }

            }
            else
                errortxt.Text = ("No command provided !");

        }

        //--------------------------------------------------- Sel-defined functions -----------------------------------------------------//

        // Convert hex string in to byte array
        private static byte[] HexString2Bytes(string hexString)
        {
            int bytesCount = (hexString.Length) / 2;
            byte[] bytes = new byte[bytesCount];
            for (int x = 0; x < bytesCount; ++x)
            {
                bytes[x] = Convert.ToByte(hexString.Substring(x * 2, 2), 16);
            }
            return bytes;
        }

        // Extract the number of the packages from camera command
        private int ShowPackageAmount(object sender, EventArgs e)
        {
            int length = serialPort1.BytesToRead;
            if (length > 0)
            {
                byte[] bufferDataIn = new byte[length];
                serialPort1.Read(bufferDataIn, 0, bufferDataIn.Length);

                byte[] fromBuffer = bufferDataIn.Skip(11).Take(1).ToArray();

                packageAmount = fromBuffer[0];

                return packageAmount;
            }
            else
                return packageAmount;

        }

        // Calculate checksum of the package
        public int crc16Calc(byte[] bytes, int len)
        {
            int init_crc = 0x00;
            int loop;
            for (loop = 0; loop < len; loop++)
            {
                for (int i = 0; i < 8; i++)
                {
                    bool bit = ((bytes[loop] >> (7 - i) & 1) == 1);
                    bool c15 = ((init_crc >> 15 & 1) == 1);
                    init_crc <<= 1;
                    if (c15 ^ bit)
                    {
                        init_crc ^= 0x1021;
                    }
                }
            }
            init_crc &= 0xFFFF;

            return init_crc;
        }

        // Receive raw data from packages and write raw data as byte array to file
        private void ShowData(object sender, EventArgs e, String showDataPath, int length, byte[] bufferDataIn2)
        {
            try
            {
                //int length = serialPort1.BytesToRead;

                //if (length == 3848)
                //{
                int checksum = 0;
                checksum = crc16Calc(bufferDataIn2, length - 2);    //Without checksum
                byte[] bufferDataChecksum = bufferDataIn2[^2..];    //Get the last 2 byte of the buffer (Ex: a1 86)
                int value = BitConverter.ToUInt16(bufferDataChecksum, 0);

                if (checksum == value)
                {
                    //FileStream fileStream = File.Open(path, File.Exists(path) ? FileMode.Append : FileMode.OpenOrCreate);
                    using (FileStream stream = new FileStream(showDataPath, FileMode.Append))
                    {
                        for (int i = 6; i < bufferDataIn2.Length - 2; i++)  // Only the image data, without the command header and checksum
                        {
                            stream.WriteByte(bufferDataIn2[i]);
                        }
                        stream.Close();
                    }
                }
                //}
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }

        }

        private void ReadAndWriteData(object sender, EventArgs e)
        {
            // Increase file path by 1 if the file is existed
            string originPath = path();
            string readwritePath = updatePathName(originPath);
            //int j = 1;

            if (String.IsNullOrEmpty(get_package_txt.Text) == false)
            {
                try
                {
                    Stopwatch stopwatch = new Stopwatch();  // Create new stopwatch

                    String cam_packages = get_package_txt.Text.Replace(" ", "");   // Camera packages amount as string
                    int cam_packages_amount = int.Parse(get_package_txt.Text.Replace(" ", ""));      //Camera pakages amount as int

                    stopwatch.Start();

                    if (cam_packages_amount < 100 && cam_packages_amount > 1)
                    {
                        for (int i = 0; i < cam_packages_amount; i++)
                        {
                            string hex = String.Format("{0:X2}", i);
                            String originalCommand = "554501" + hex + "0023"; //Full command as String
                            serialPort1.Write(HexString2Bytes(originalCommand), 0, HexString2Bytes(originalCommand).Length);      //Write command to serial port device

                            progressBar1.BeginInvoke(new MethodInvoker(() =>
                            {
                                progressBar1.Value = i * progressBar1.Maximum / (cam_packages_amount - 1);
                            }
                            ));

                            byte[] bufferDataIn2 = new byte[length];
                            int k = 0;
                            try
                            {
                                while (k < length)
                                {
                                    bufferDataIn2[k] = (byte)serialPort1.ReadByte();
                                    k++;
                                }
                            }

                            catch (TimeoutException error)
                            {
                                errortxt.BeginInvoke(new MethodInvoker(() => { errortxt.Text += "The read operation has reached timeout!\r\n"; }));
                            }

                            /*double elapsedsec1 = elapsedsec/j;
                            j++;
                            string elapsed = "Time elapsed for packet number" + j + "(seconds): " + elapsedsec1.ToString() + "\r\n";*/
                            //serialPort1.Read(bufferDataIn2, 0, bufferDataIn2.Length);
                            ShowData(sender, e, readwritePath, length, bufferDataIn2);
                        }
                        stopwatch.Stop();

                        try
                        {
                            pictureBox1.Image = Image.FromFile(readwritePath);
                        }

                        catch
                        {
                            MessageBox.Show("Image is corrupted or not found");
                        }

                    }

                    double elapsedsec = stopwatch.Elapsed.TotalSeconds;
                    double elapsedsec1 = Truncate(elapsedsec, 4);
                    string elapsed = "Time elapsed for 1 image (seconds): " + elapsedsec1 + "\r\n";
                    errortxt.BeginInvoke(new MethodInvoker(() => { errortxt.Text += elapsed; }));
                }

                catch (IOException er)
                {
                    MessageBox.Show(er.Message);
                }

            }
            else
                MessageBox.Show("No command");
        }

        private string updatePathName(String upPath)
        {

            String filename_initial = folderpath + filename;
            String filename_current = filename_initial;
            int count = 1;
            while (File.Exists(filename_current))
            {
                count++;
                filename_current = Path.GetDirectoryName(filename_initial)
                                 + Path.DirectorySeparatorChar
                                 + Path.GetFileNameWithoutExtension(filename_initial)
                                 + count.ToString()
                                 + Path.GetExtension(filename_initial);
            }

            upPath = filename_current;
            return upPath;
        }

        private void choose_folder_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = folderBrowserDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                choose_folder_path_txt.Text = folderBrowserDialog1.SelectedPath;
                folderpath = folderBrowserDialog1.SelectedPath + "\\";
                senddata_btn.Enabled = true;
            }
        }

        double Truncate(double number, int doublePlaces)
        {
            return (int)(number * (double)Math.Pow(10, doublePlaces)) / (double)Math.Pow(10, doublePlaces);
        }

        private void change_baudrate_btn_Click(object sender, EventArgs e)
        {
            int baudrateIndex = 0;
            switch (baudrate_txt.Text)
            {
                case ("115200"):
                    baudrateIndex = 1;
                    break;
                case ("230400"):
                    baudrateIndex = 2;
                    break;
                case ("460800"):
                    baudrateIndex = 3;
                    break;
                case ("921600"):
                    baudrateIndex = 4;
                    break;
                default:
                    baudrateIndex = 3;
                    break;
            }

            String originalCommand = "5549010" + baudrateIndex.ToString() + "23"; //Full command as String
            char[] ch = originalCommand.ToCharArray(); //Command split as char array
            serialPort1.Write(HexString2Bytes(originalCommand), 0, HexString2Bytes(originalCommand).Length);

            if (serialPort1.IsOpen)
                serialPort1.Close();
            openport_btn.Enabled = true;
            senddata_btn.Enabled = false;


        }
    }
}


