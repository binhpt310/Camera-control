using System;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {

        static String filename = "";
        String path = "C:/Users/7490/Documents/VisualStudioProjects/WindowsFormsApp1/textfile/";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] portList = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(portList);

            openport_btn.Enabled = true;
            closeport_btn.Enabled = false;
            senddata_btn.Enabled = false;
            get_package_btn.Enabled = false;
        }


        private void clear_btn_Click(object sender, EventArgs e)
        {
            errortxt.Text = "";
            pictureBox1.Image = null;
            serialPort1.DiscardInBuffer();
            serialPort1.DiscardOutBuffer();
        }

        private void getdata_btn_Click_1(object sender, EventArgs e)
        {
            try
            {

                string rawData = System.IO.File.ReadAllText(@"C:\Users\7490\Documents\VisualStudioProjects\WindowsFormsApp1\textfile\newfile.txt");
                byte[] image = HexString2Bytes(rawData);

                File.WriteAllBytes(@"C:\Users\7490\Documents\VisualStudioProjects\WindowsFormsApp1\Image\Snapshot.jpg", image);

                /*if (pictureBox1.Image == null && pictureBox2.Image == null)
                {
                    //pictureBox1.Image = Image.FromFile(@"C:\Users\7490\Documents\VisualStudioProjects\WindowsFormsApp1\Image\Snapshot.png");
                    pictureBox2.Image = Image.FromFile(@"C:\Users\7490\Documents\VisualStudioProjects\WindowsFormsApp1\Image\Snapshot.jpg");
                }*/
            }

            catch (IOException err)
            {
                errortxt.Text = err.ToString();
            }


        }

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

        private void senddata_btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(command_txt.Text) == false)
            {
                try
                {
                    String originalCommand = command_txt.Text.Replace(" ", ""); //Full command as String
                    char[] ch = originalCommand.ToCharArray(); //Command split as char array

                    if (ch[2] == '4' && ch[3] == '9')
                        serialPort1.Write(HexString2Bytes(originalCommand), 0, HexString2Bytes(originalCommand).Length);
                    else if (ch[2] == '4' && ch[3] == '8')
                    { //Command with H header
                        serialPort1.Write(HexString2Bytes(originalCommand), 0, HexString2Bytes(originalCommand).Length);

                    }
                    else if (ch[2] == '4' && ch[3] == '5')
                        serialPort1.Write(HexString2Bytes(originalCommand), 0, HexString2Bytes(originalCommand).Length);
                    else if (ch[2] == '4' && ch[3] == '4')
                        serialPort1.Write(HexString2Bytes(originalCommand), 0, HexString2Bytes(originalCommand).Length);
                    else if (ch[2] == '5' && ch[3] == '1')
                        serialPort1.Write(HexString2Bytes(originalCommand), 0, HexString2Bytes(originalCommand).Length);
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
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void openport_btn_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.BaudRate = Convert.ToInt32(baudrate_txt.Text);
            serialPort1.Open();
            openport_btn.Enabled = false;
            closeport_btn.Enabled = true;
            senddata_btn.Enabled = true;
            get_package_btn.Enabled = true;
            filename = saved_file_name_txt.Text;
            path += filename;
        }
        private void closeport_btn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.DiscardOutBuffer();
                serialPort1.DiscardInBuffer();
                serialPort1.Close();
                openport_btn.Enabled = true;
                closeport_btn.Enabled = false;
                senddata_btn.Enabled = false;
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(1);
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            this.Invoke(new EventHandler(ShowData));     
        }

        private void ShowData(object sender, EventArgs e)
        {
            try
            {
                int length = serialPort1.BytesToRead;


                if (length == 1032)
                {
                    byte[] bufferDataIn2 = new byte[length];
                    serialPort1.Read(bufferDataIn2, 0, bufferDataIn2.Length);


                    int checksum = 0;
                    checksum = crc16Calc(bufferDataIn2, length - 2);
                    byte[] bufferDataChecksum = bufferDataIn2[^2..];

                    int value = BitConverter.ToUInt16(bufferDataChecksum, 0);

                    if (checksum == value)
                    {
                        using (var stream = new FileStream(path, FileMode.Append))
                        {
                            for (int i = 6; i < bufferDataIn2.Length - 2; i++)
                            {
                                stream.WriteByte(bufferDataIn2[i]);
                            }
                        }
                    }
                }
            }


            //---------------------------------------------------------------------


            catch (Exception err)
            {
                errortxt.Text = err.Message.ToString();
            }
                

        }

        private void get_package_btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(get_package_txt.Text) == false)
            {
                try
                {
                    String cam_packages = get_package_txt.Text.Replace(" ", "");   // Camera packages amount as string
                    int cam_packages_amount = int.Parse(get_package_txt.Text.Replace(" ", ""));      //Camera pakages amount as int

                    for (int i =0; i <= cam_packages_amount; i++)
                    {
                        string hex = String.Format("{0:X2}", i);
                        String originalCommand = "554501" + hex + "0023"; //Full command as String
                        serialPort1.Write(HexString2Bytes(originalCommand), 0, HexString2Bytes(originalCommand).Length);
                        Thread.Sleep(100);
                        
                    }
                }

                catch (IOException er)
                {
                    errortxt.Text = er.ToString();
                }
            }
            else
                errortxt.Text = ("No command provided !");
        }


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


