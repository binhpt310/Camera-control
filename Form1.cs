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
using System.ComponentModel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static String filename = "";

        String folderpath = "";

        string camID = "01";

        int packageAmount;

        int length = 0;

        int imgSize = 0;

        int lastPckgSize = 0;

        bool isFull = true;

        public string path()
        {
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
            offline_enable_btn.Enabled = false;
            triger_io_btn.Enabled = false;
            change_camid_btn.Enabled = false;
            change_baudrate_btn.Enabled = false;
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
                offline_enable_btn.Enabled = true;
                triger_io_btn.Enabled = true;
                change_camid_btn.Enabled = true;
                change_baudrate_btn.Enabled = true;
                serialPort1.ReadTimeout = 2000;
            }

            else
                MessageBox.Show("Please check Port name and Baudrate");

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

        private void senddata_btn_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
                serialPort1.Open();

            if (String.IsNullOrEmpty(command_txt.Text) == false)
            {
                try
                {
                    String originalCommand = command_txt.Text.Replace(" ", ""); //Full command as String
                    String fullCommand = "5548" + camID + "3200" + originalCommand + "23";
                        
                    string packageSizeHex = "0x" + originalCommand;
                    int packageSizeNumber1 = Int32.Parse(packageSizeHex.Substring(2), NumberStyles.HexNumber);
                    length = packageSizeNumber1 * 256 + 8;

                    int img_number = Int32.Parse(img_num_txt.Text);

                    Thread workerThread = new Thread(new ThreadStart(() =>
                    {
                        for (int i = 0; i < img_number ; i++)
                        {
                            if (originalCommand != null)
                            {
                                serialPort1.Write(HexString2Bytes(fullCommand), 0, HexString2Bytes(fullCommand).Length);
                                Thread.Sleep(200);
                                String cam_packages = ShowPackageAmount(sender, e).ToString().Replace(" ", "");
                                senddata_btn.BeginInvoke(new MethodInvoker(() => { senddata_btn.Enabled = false; }));
                                choose_folder_btn.BeginInvoke(new MethodInvoker(() => { choose_folder_btn.Enabled = false; }));
                                triger_io_btn.BeginInvoke(new MethodInvoker(() => { triger_io_btn.Enabled = false; }));
                                change_camid_btn.BeginInvoke(new MethodInvoker(() => { change_camid_btn.Enabled = false; }));
                                change_baudrate_btn.BeginInvoke(new MethodInvoker(() => { change_baudrate_btn.Enabled = false; }));
                                offline_enable_btn.BeginInvoke(new MethodInvoker(() => { offline_enable_btn.Enabled = false; }));
                                ReadAndWriteData(sender, e, cam_packages);
                             
                                serialPort1.DiscardOutBuffer();
                                serialPort1.DiscardInBuffer();
                                serialPort1.BaseStream.Flush();
                                senddata_btn.BeginInvoke(new MethodInvoker(() => { senddata_btn.Enabled = true; }));
                                choose_folder_btn.BeginInvoke(new MethodInvoker(() => { choose_folder_btn.Enabled = true; }));
                                triger_io_btn.BeginInvoke(new MethodInvoker(() => { triger_io_btn.Enabled = true; }));
                                change_camid_btn.BeginInvoke(new MethodInvoker(() => { change_camid_btn.Enabled = true; }));
                                change_baudrate_btn.BeginInvoke(new MethodInvoker(() => { change_baudrate_btn.Enabled = true; }));
                                offline_enable_btn.BeginInvoke(new MethodInvoker(() => { offline_enable_btn.Enabled = true; }));
                            }
                            else
                                errortxt.Text = "Your command is incorrect !";
                        }
                    }
                    ));
                    workerThread.Start();
                  
                }

                catch (IOException er)
                {
                    errortxt.Text = er.ToString();
                }

            }
            else
                errortxt.Text = ("No command provided !");

        }
        private void clear_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(errortxt.Text))
                errortxt.Text = null;
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

            String originalCommand = "5549"+camID+ "0" + baudrateIndex.ToString() + "23"; //Full command as String
            char[] ch = originalCommand.ToCharArray(); //Command split as char array
            serialPort1.Write(HexString2Bytes(originalCommand), 0, HexString2Bytes(originalCommand).Length);

            if (serialPort1.IsOpen)
                serialPort1.Close();
            openport_btn.Enabled = true;
            offline_enable_btn.Enabled = false;
            triger_io_btn.Enabled = false;
            change_camid_btn.Enabled = false;
            senddata_btn.Enabled = false;
        }
        private void triger_io_btn_Click(object sender, EventArgs e)
        {
            int[] io = { 0, 0, 0, 0, 0 };
            CheckBox[] cb = { io1_checkbox, io2_checkbox, io3_checkbox, io4_checkbox, io5_checkbox };

            for (int i = 0; i < 5; i++)
            {
                if (cb[i].Checked)
                    io[i] = 1;
                else
                    io[i] = 0;
            }

            string str = string.Join("", io).Replace(" ", "");
            string hex = Convert.ToInt32(str, 2).ToString("X");

            String originalCommand = "";
            if (hex.Length == 1)
                originalCommand = "5554" + camID + "0" + hex + "23";
            else
                originalCommand = "5554" + camID + hex + "23";

            serialPort1.Write(HexString2Bytes(originalCommand), 0, HexString2Bytes(originalCommand).Length);
            serialPort1.DiscardInBuffer();
            serialPort1.DiscardOutBuffer();
            serialPort1.BaseStream.Flush();

        }
        private void offline_enable_btn_Click(object sender, EventArgs e)
        {
            String originalCommand = "5547" + camID + "23"; //Full command as String
            serialPort1.Write(HexString2Bytes(originalCommand), 0, HexString2Bytes(originalCommand).Length);

            int Length = serialPort1.BytesToRead;
            byte[] buffer = new byte[Length];
            serialPort1.Read(buffer, 0, buffer.Length);

            if (buffer.Length > 0)
            {
                richTextBox1.Text = buffer[4].ToString();
                if (buffer[3] == 1)
                    true_checkbox.Checked = true;
                else
                    false_checkbox.Checked = true;
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
                serialPort1.BaseStream.Flush();
            }
        }
        private void change_camid_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(new_id_txt.Text) && !string.IsNullOrEmpty(current_id_txt.Text))
            {
                String originalCommand = "5544" + current_id_txt.Text.ToString() + new_id_txt.Text.ToString() + "23";
                camID = new_id_txt.Text.ToString();
                serialPort1.Write(HexString2Bytes(originalCommand), 0, HexString2Bytes(originalCommand).Length);        
            }
            else
                MessageBox.Show("Please check the current ID and new ID!");
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
            int len = serialPort1.BytesToRead;
            if (len > 0)
            {
                byte[] bufferDataIn = new byte[len];
                serialPort1.Read(bufferDataIn, 0, bufferDataIn.Length);

                byte[] fromBuffer1 = new byte[3];
                fromBuffer1[0] = bufferDataIn[9];
                fromBuffer1[1] = bufferDataIn[8];
                fromBuffer1[2] = bufferDataIn[7];

                string[] fromBufferHex = new string[3];
                for (int i = 0; i < 3; i++)
                {
                    fromBufferHex[i] = fromBuffer1[i].ToString("X");
                }
                string lastpkHexString = string.Join("", fromBufferHex);
                imgSize = Convert.ToInt32(lastpkHexString, 16);

                byte[] fromBuffer = bufferDataIn.Skip(11).Take(1).ToArray();
                packageAmount = fromBuffer[0];

                lastPckgSize = imgSize - (packageAmount - 1) * (length - 8);
                lastPckgSize += 8;
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
                    isFull = true;
                }

                else 
                    isFull = false;
                //}
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }

        }

            // Manage 2 functions ProcessingData and Showdata
        private void ReadAndWriteData(object sender, EventArgs e, String cam_packages)
        {
            // Increase file path by 1 if the file is existed
            string originPath = path();
            string readwritePath = updatePathName(originPath);
            int cam_packages_amount = int.Parse(cam_packages);      //Camera pakages amount as int
            try
            {
                Stopwatch stopwatch = new Stopwatch();  // Create new stopwatch
                stopwatch.Start();

                if (cam_packages_amount < 100 && cam_packages_amount > 1)
                {
                    byte[] bufferDataIn2 = new byte[length];
                    for (int i = 0; i < cam_packages_amount; i++)
                    {
                        ProcessingData(i, bufferDataIn2);
                        progressBar1.BeginInvoke(new MethodInvoker(() =>{progressBar1.Value = i * progressBar1.Maximum / (cam_packages_amount - 1);}));
                        ShowData(sender, e, readwritePath, length, bufferDataIn2);
                        
                        while (!isFull)
                        {
                            ProcessingData(i, bufferDataIn2);
                            ShowData(sender, e, readwritePath, length, bufferDataIn2);
                        }
                    }
                    //----Last package
                    if (lastPckgSize > 0)
                    {
                        byte[] lastbuffer = new byte[lastPckgSize];
                        LastPackageProcessingData(cam_packages_amount, lastbuffer);
                        ShowData(sender, e, readwritePath, lastPckgSize, lastbuffer);
                    }
                    //----Last package
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
                errortxt.BeginInvoke(new MethodInvoker(() => { errortxt.AppendText(elapsed); }));
            }

            catch (IOException er)
            {
                MessageBox.Show(er.Message);
            }
        }

            //Append the package data to buffer array
        private void ProcessingData(int i, byte[] bufferDataIn2) 
        {
            string hex = String.Format("{0:X2}", i);
            String originalCommand = "5545" + camID + hex + "0023"; //Full command as String
            serialPort1.Write(HexString2Bytes(originalCommand), 0, HexString2Bytes(originalCommand).Length);      //Write command to serial port device
       
            int k = 0;
            try
            {
                while (k < length)
                {
                    bufferDataIn2[k] = (byte)serialPort1.ReadByte();
                    k++;
                }

                while (bufferDataIn2.Length < length)
                    ProcessingData(i, bufferDataIn2);
            }

            catch (TimeoutException)
            {
                errortxt.BeginInvoke(new MethodInvoker(() => { errortxt.Text += "The read operation has reached timeout!\r\n"; }));
            }
        }

            // Update the image name if the name is already exist
        private string updatePathName(String upPath)
        {
            filename = saved_file_name_txt.Text;
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

            // Reduce the length of a double number 
        double Truncate(double number, int doublePlaces)
        {
            return (int)(number * (double)Math.Pow(10, doublePlaces)) / (double)Math.Pow(10, doublePlaces);
        }

        // Get bytes from the Last packet 
        private void LastPackageProcessingData(int i, byte[] bufferDataIn2)
        {
            string hex = String.Format("{0:X2}", i);
            String originalCommand = "5545" + camID + hex + "0023"; //Full command as String
            serialPort1.Write(HexString2Bytes(originalCommand), 0, HexString2Bytes(originalCommand).Length);      //Write command to serial port device

            int k = 0;
            try
            {
                while (k < lastPckgSize)
                {
                    bufferDataIn2[k] = (byte)serialPort1.ReadByte();
                    k++;
                }

                while (bufferDataIn2.Length < lastPckgSize)
                    LastPackageProcessingData(i, bufferDataIn2);
            }

            catch (TimeoutException)
            {
                errortxt.BeginInvoke(new MethodInvoker(() => { errortxt.Text += "The read operation has reached timeout!\r\n"; }));
            }
        }
    }
}


