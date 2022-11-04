using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {

        String filename = "";

        String folderpath = "";

        int packageAmount ;
        
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
            get_package_btn.Enabled = false;

            filename = saved_file_name_txt.Text;

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

                    if (ch != null)
                    {
                        serialPort1.Write(HexString2Bytes(originalCommand), 0, HexString2Bytes(originalCommand).Length);
                        Thread.Sleep(1000);
                        get_package_txt.Text = ShowPackageAmount(sender, e).ToString();
                    }
                    else
                        errortxt.Text = "Your command is incorrect !";
                }

                catch (IOException er)
                {
                    errortxt.Text = er.ToString();
                }
            }
            else
                errortxt.Text = ("No command provided !");


            //-------------------------------- Close port after done ---------------------------------------------//
            //serialPort1.DiscardInBuffer();
            //serialPort1.DiscardOutBuffer();
            serialPort1.Close();
        }

        private void openport_btn_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.BaudRate = Convert.ToInt32(baudrate_txt.Text);
            serialPort1.Open();
            openport_btn.Enabled = false;
            //closeport_btn.Enabled = true;
            senddata_btn.Enabled = true;
            get_package_btn.Enabled = true;

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(1);
            //serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            //this.Invoke(new EventHandler(ShowData));
            //serialPort1.ReceivedBytesThreshold = 1032 ;

        }

        private void get_package_btn_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
                serialPort1.Open();

            Thread workerThread = new Thread(unused => this.readAndWriteData(sender, e));
            workerThread.Start(readAndWriteData);
        }

        //-------------------------------------------- Sel-defined functions -----------------------------------------------------//

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

        // Receive raw data from packages and write raw data as byte array to file
        private void ShowData(object sender, EventArgs e, String showDataPath)
        {
            try
            {
                int length = serialPort1.BytesToRead;

                if (length == 1032)
                {
                    byte[] bufferDataIn2 = new byte[length];
                    serialPort1.Read(bufferDataIn2, 0, bufferDataIn2.Length);

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
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }

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

        // 
        private void readAndWriteData(object sender, EventArgs e)
        {
            // Increase file path by 1 if the file is existed

            string originPath = path();
            string readwritePath = updatePathName(originPath);

            if (String.IsNullOrEmpty(get_package_txt.Text) == false)
            {
                try
                {
                    String cam_packages = get_package_txt.Text.Replace(" ", "");   // Camera packages amount as string
                    int cam_packages_amount = int.Parse(get_package_txt.Text.Replace(" ", ""));      //Camera pakages amount as int

                    for (int i = 0; i <= cam_packages_amount; i++)
                    {
                        string hex = String.Format("{0:X2}", i);
                        String originalCommand = "554501" + hex + "0023"; //Full command as String
                        serialPort1.Write(HexString2Bytes(originalCommand), 0, HexString2Bytes(originalCommand).Length);

                        //MethodInvoker m = new MethodInvoker( () => progressBar1.Value = i * progressBar1.Maximum / cam_packages_amount);
                        //progressBar1.Invoke(m);

                        /*Invoke((MethodInvoker)delegate
                        {
                            progressBar1.Value = i * progressBar1.Maximum / cam_packages_amount;
                        });*/
                        
                        ShowData(sender, e, readwritePath);

                        Thread.Sleep(220);
                    }

                    pictureBox1.Image = Image.FromFile(readwritePath);

                    //-------------------------------- Close port after done ---------------------------------------------//
                   // serialPort1.DiscardInBuffer();
                   // serialPort1.DiscardOutBuffer();
                    serialPort1.Close();
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
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    /*
    BackgroundWorker bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.DoWork += new DoWorkEventHandler(delegate (object o, DoWorkEventArgs args)
            {
                BackgroundWorker b = o as BackgroundWorker;
                int length = serialPort1.BytesToRead;
                bool correct = false;
                byte[] bufferDataIn2 = new byte[length];

                if (length == 1032)
                    correct = true;

                if (correct)
                {
                    //BlockingRead(serialPort1, bufferDataIn2, 0, length);
                    serialPort1.Read(bufferDataIn2, 0, length);
                    int checksum = 0;
                    checksum = crc16Calc(bufferDataIn2, length - 2);


                    for (int i = 6; i < bufferDataIn2.Length - 2; i++)
                    {
                        using (var stream = new FileStream(path, FileMode.Append))
                        {
                            stream.WriteByte(bufferDataIn2[i]);
                            stream.Flush();
                            stream.Close();
                        }
                    }
                }
            });
            bw.RunWorkerAsync();
     */
}


