using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;
using System.Diagnostics;
using System.Web.Services.Description;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        int serialDataIn;
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
        }


        private void clear_btn_Click(object sender, EventArgs e)
        {
            data_receive_txt.Clear();
            errortxt.Text = "";
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            serialPort1.DiscardInBuffer();
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

        private static string Bytes2HexString(byte[] buffer)
        {
            var hex = new StringBuilder(buffer.Length * 2);
            foreach (byte b in buffer)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
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

        static string generateHexString(String command)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(command); //bytes[] = [85, 73, 48, 49, 51, 35]
            var hexString = BitConverter.ToString(bytes); //hexString = "55-49-30-31-33-23"
            hexString = hexString.Replace("-", "");
            return hexString;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }

        private void openport_btn_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.BaudRate = Convert.ToInt32(baudrate_txt.Text);
            serialPort1.Open();
            openport_btn.Enabled = false;
            closeport_btn.Enabled = true;
            senddata_btn.Enabled = true;

        }
        private void closeport_btn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.DiscardOutBuffer();
                serialPort1.Close();
                openport_btn.Enabled = true;
                closeport_btn.Enabled = false;
                senddata_btn.Enabled = false;


                //serialPort1.DiscardInBuffer();
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //serialDataIn += serialPort1.ReadByte();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            this.Invoke(new EventHandler(ShowData));
            Thread.Sleep(200);
        }

        public void BlockingRead(SerialPort port, byte[] buffer, int offset, int count)
        {
            while (count > 0)
            {
                int bytesRead = port.Read(buffer, offset, count);
                offset += bytesRead;
                count -= bytesRead;
            }
        }
        private void ShowData(object sender, EventArgs e)
        {
            String path = @"C:\Users\7490\Documents\VisualStudioProjects\WindowsFormsApp1\textfile\newfile_trim.jpeg";
            int length = serialPort1.BytesToRead;

                byte[] bufferDataIn2 = new byte[length];
                BlockingRead(serialPort1, bufferDataIn2, 0, length);
            
            if (length == 748)
            {
                for (int i = 6; i < bufferDataIn2.Length - 2; i++)
                    AppendAllBytes(path, bufferDataIn2[i]);
            }
        }

        /*StringBuilder sb = new StringBuilder();

        for (int i = 5; i < bufferDataIn2.Length-2; i++)
            //sb.AppendFormat("{0:X2} ", bufferDataIn2[i]);
            sb.Append(bufferDataIn2[i]);*/
        //using StreamWriter file = new(@"C:\Users\7490\Documents\VisualStudioProjects\WindowsFormsApp1\textfile\newfile_trim.jpeg", append: true);
        //file.Write(sb);


        //for (int i = 5; i < bufferDataIn2.Length; i++)
        //AppendAllBytes(path, bufferDataIn2[i]);


        private void get_package_btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(get_package_txt.Text) == false)
            {
                try
                {
                    String originalCommand = get_package_txt.Text.Replace(" ", ""); //Full command as String
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

        public static void AppendAllBytes(string path, byte bytes)
        {
            using (var stream = new FileStream(path, FileMode.Append))
            {
                stream.WriteByte(bytes);
            }
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

    
}
    
       
