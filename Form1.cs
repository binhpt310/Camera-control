﻿using System;
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
                //byte[] bytes = Convert.FromBase64String(imageString);
                byte[] bytes = Encoding.UTF8.GetBytes(imageString);
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
                String originalCommand = command_txt.Text.Replace(" ", ""); //Full command as String
                char[] ch = originalCommand.ToCharArray(); //Command split as char array
                int imageDataLength = 5;
                if (ch[1] == 'I')
                    serialPort1.Write(I_command(ch));
                else if (ch[1] == 'H')
                    serialPort1.Write(H_command(ch));
                else if (ch[1] == 'R')
                    serialPort1.Write(R_command(ch));
                else if (ch[1] == 'E')
                    serialPort1.Write(E_command(ch));
                else if (ch[1] == 'F')
                    serialPort1.Write(F_command(ch, imageDataLength));
                else if (ch[1] == 'D')
                    serialPort1.Write(D_command(ch));
                else if (ch[1] == 'Q')
                    serialPort1.Write(Q_command(ch));
            }

            catch (IOException er )
            {
                errortxt.Text = er.ToString();
            }
        }

        static String generateHexString(String command)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(command); //bytes[] = [85, 73, 48, 49, 51, 35]
            var hexString = BitConverter.ToString(bytes); //hexString = "55-49-30-31-33-23"
            hexString = hexString.Replace("-", "");
            return hexString;
        }

        static String I_command(char[] ch)
        {
            String part1 = new string(new char[] { ch[0], ch[1] }); //UI
            String part2 = new string(new char[] { ch[2], ch[3] }); //Cam ID
            String part3 = new string(new char[] { ch[4], ch[5] }); //Command content and #
            var finalHexString = generateHexString(part1) + part2 + generateHexString(part3);
            return finalHexString;
        }

        static String H_command(char[] ch)
        {
            String part1 = new string(new char[] { ch[0], ch[1] }); //UH
            String part2 = new string(new char[] { ch[2], ch[3] }); //Cam ID
            String part3 = new string(new char[] { ch[4] }); //Pic size (1-4)
            String part4 = new string(new char[] { ch[5], ch[6], ch[7], ch[8] }); //The number that the snapshot will divided into
            String part5 = new string(new char[] { ch[9] }); //#
            var finalHexString = generateHexString(part1) + part2 + generateHexString(part3) + part4 + generateHexString(part5);
            return finalHexString;
        }

        static String R_command(char[] ch)
        {
            String part1 = new string(new char[] { ch[0], ch[1] }); //UR
            String part2 = new string(new char[] { ch[2], ch[3] }); //Cam ID
            String part3 = new string(ch[4..16]); //Command content
            String part4 = new string(new char[] { ch[16] }); //#
            var finalHexString = generateHexString(part1) + part2 + part3 + generateHexString(part4);
            return finalHexString;
        }

        static String E_command(char[] ch)
        {
            String part1 = new string(new char[] { ch[0], ch[1] }); //UE
            String part2 = new string(new char[] { ch[2], ch[3] }); //Cam ID
            String part3 = new string(ch[4..8]); //Package ID
            String part4 = new string(new char[] { ch[8] }); //#
            var finalHexString = generateHexString(part1) + part2 + part3 + generateHexString(part4);
            return finalHexString;
        }

        static String F_command(char[] ch, int n)
        {
            String part1 = new string(new char[] { ch[0], ch[1] }); //UF
            String part2 = new string(new char[] { ch[2], ch[3] }); //Cam ID
            String part3 = new string(ch[4..8]); //Package ID
            String part4 = new string(ch[8..12]); //Package Size
            String part5 = new string(ch[12..(12+n)]); //Image data
            String part6 = new string(ch[(12+n)..(12+n+4)]); //Check sum
            var finalHexString = generateHexString(part1) + part2 + part3 + part4 + part5 + part6;
            return finalHexString;
        }

        static String D_command(char[] ch)
        {
            String part1 = new string(new char[] { ch[0], ch[1] }); //UD
            String part2 = new string(new char[] { ch[2], ch[3] }); //Old cam ID
            String part3 = new string(new char[] { ch[4], ch[5] }); //New cam ID
            String part4 = new string(new char[] { ch[6] }); //#
            var finalHexString = generateHexString(part1) + part2 + part3 + generateHexString(part4);
            return finalHexString;
        }

        static String Q_command(char[] ch)
        {
            String part1 = new string(new char[] { ch[0], ch[1] }); //UD
            String part2 = new string(new char[] { ch[2], ch[3] }); //Cam ID
            String part3 = new string(new char[] { ch[4], ch[5] }); //Compression rate
            String part4 = new string(new char[] { ch[6] }); //#
            var finalHexString = generateHexString(part1) + part2 + part3 + generateHexString(part4);
            return finalHexString;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
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
}
