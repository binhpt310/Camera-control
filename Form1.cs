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

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        string serialDataIn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] portList = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(portList);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void errortxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            data_receive_txt.Clear();
            errortxt.Text = "";
            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }

        private void getdata_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                /*while (pictureBox1.Image == null && pictureBox2.Image == null)
                {
                        string a = _serialPort.ReadLine();
                        a = a.Replace("\r", "");

                        if (a.Length == 92)
                        {
                            SaveImage(a, errortxt);
                            //Thread.Sleep(3000);
                            pictureBox1.Image = Image.FromFile(@"C:/Users/7490/Documents/VisualStudioProjects/WindowsFormsApp1/Image/Image.jpg");
                            pictureBox2.Image = Image.FromFile(@"C:/Users/7490/Documents/VisualStudioProjects/WindowsFormsApp1/Image/Image.png");
                        }
                }*/
              
            }

            catch (IOException err)
            {
                    errortxt.Text = err.ToString();
            }

        }

        static void SaveImage(string imageString, System.Windows.Forms.TextBox errortxt)
        {
            try
            {
                byte[] bytes = Convert.FromBase64String(imageString);
                string imagePath = "C:/Users/7490/Documents/VisualStudioProjects/WindowsFormsApp1/Image/";
                string imageJPG = "Image.jpg";
                File.WriteAllBytes(imagePath + imageJPG, bytes);


                string imagePNG = "Image.png";
                File.WriteAllBytes(imagePath + imagePNG, bytes);
            }

            catch (IOException e)
            {
                errortxt.Text = e.ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void senddata_btn_Click(object sender, EventArgs e)
        {
            
            try {
                byte[] bytes = Encoding.UTF8.GetBytes(command_txt.Text.Replace(" ", ""));
                var hexString = BitConverter.ToString(bytes);
                hexString = hexString.Replace("-", "");
                serialPort1.Write(hexString);
                //serialPort1.Write("U" + command_txt.Text + '#');

                /*BackgroundWorker bw = new BackgroundWorker();

                // this allows our worker to report progress during work
                bw.WorkerReportsProgress = true;

                // what to do in the background thread
                bw.DoWork += new DoWorkEventHandler(
                delegate (object o, DoWorkEventArgs args)
                {
                    BackgroundWorker b = o as BackgroundWorker;
                    while (true)
                    {
                        string a = serialPort1.ReadExisting();
                        a = a.Replace("\r", "");
                        if (a.Length >0)
                            data_receive_txt.Text += a+"\n";
                    }
                });
                bw.RunWorkerAsync();*/
            }

            catch (IOException er )
            {
                errortxt.Text = er.ToString();
            }
        }

        private void data_receive_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openport_btn_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.BaudRate = Convert.ToInt32("9600");
            serialPort1.Open();
        }

        private void closeport_btn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialDataIn = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            data_receive_txt.Text += serialDataIn;
        }
    }
}
