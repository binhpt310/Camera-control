namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Text.DecoderReplacementFallback decoderReplacementFallback1 = new System.Text.DecoderReplacementFallback();
            System.Text.EncoderReplacementFallback encoderReplacementFallback1 = new System.Text.EncoderReplacementFallback();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.baudrate_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.command_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.senddata_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errortxt = new System.Windows.Forms.TextBox();
            this.openport_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.get_package_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.get_package_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.saved_file_name_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(148, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "JPG Image";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(261, 302);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Port number";
            // 
            // baudrate_txt
            // 
            this.baudrate_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.baudrate_txt.Location = new System.Drawing.Point(261, 390);
            this.baudrate_txt.Margin = new System.Windows.Forms.Padding(2);
            this.baudrate_txt.Name = "baudrate_txt";
            this.baudrate_txt.Size = new System.Drawing.Size(110, 23);
            this.baudrate_txt.TabIndex = 11;
            this.baudrate_txt.Text = "115200";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(261, 362);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Baud rate";
            // 
            // command_txt
            // 
            this.command_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.command_txt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.command_txt.Location = new System.Drawing.Point(407, 184);
            this.command_txt.Margin = new System.Windows.Forms.Padding(2);
            this.command_txt.Multiline = true;
            this.command_txt.Name = "command_txt";
            this.command_txt.Size = new System.Drawing.Size(274, 29);
            this.command_txt.TabIndex = 13;
            this.command_txt.Text = "55 48 01 32 00 04 23";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(462, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Command snapshot";
            // 
            // senddata_btn
            // 
            this.senddata_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.senddata_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.senddata_btn.Location = new System.Drawing.Point(407, 221);
            this.senddata_btn.Margin = new System.Windows.Forms.Padding(2);
            this.senddata_btn.Name = "senddata_btn";
            this.senddata_btn.Size = new System.Drawing.Size(273, 41);
            this.senddata_btn.TabIndex = 14;
            this.senddata_btn.Text = "Send data";
            this.senddata_btn.UseVisualStyleBackColor = true;
            this.senddata_btn.Click += new System.EventHandler(this.senddata_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(83, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Error checking";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errortxt
            // 
            this.errortxt.Location = new System.Drawing.Point(10, 329);
            this.errortxt.Margin = new System.Windows.Forms.Padding(2);
            this.errortxt.Multiline = true;
            this.errortxt.Name = "errortxt";
            this.errortxt.ReadOnly = true;
            this.errortxt.Size = new System.Drawing.Size(228, 84);
            this.errortxt.TabIndex = 16;
            // 
            // openport_btn
            // 
            this.openport_btn.BackColor = System.Drawing.Color.SpringGreen;
            this.openport_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openport_btn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.openport_btn.Location = new System.Drawing.Point(127, 219);
            this.openport_btn.Margin = new System.Windows.Forms.Padding(2);
            this.openport_btn.Name = "openport_btn";
            this.openport_btn.Size = new System.Drawing.Size(111, 66);
            this.openport_btn.TabIndex = 20;
            this.openport_btn.Text = "Open";
            this.openport_btn.UseVisualStyleBackColor = false;
            this.openport_btn.Click += new System.EventHandler(this.openport_btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(261, 329);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 23);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Text = "COM16";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 9600;
            this.serialPort1.DataBits = 8;
            this.serialPort1.DiscardNull = false;
            this.serialPort1.DtrEnable = false;
            this.serialPort1.Handshake = System.IO.Ports.Handshake.None;
            this.serialPort1.NewLine = "\n";
            this.serialPort1.Parity = System.IO.Ports.Parity.None;
            this.serialPort1.ParityReplace = ((byte)(63));
            this.serialPort1.PortName = "COM1";
            this.serialPort1.ReadBufferSize = 4096;
            this.serialPort1.ReadTimeout = -1;
            this.serialPort1.ReceivedBytesThreshold = 1;
            this.serialPort1.RtsEnable = false;
            this.serialPort1.StopBits = System.IO.Ports.StopBits.One;
            this.serialPort1.WriteBufferSize = 2048;
            this.serialPort1.WriteTimeout = -1;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // get_package_txt
            // 
            this.get_package_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.get_package_txt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.get_package_txt.Location = new System.Drawing.Point(407, 341);
            this.get_package_txt.Margin = new System.Windows.Forms.Padding(2);
            this.get_package_txt.Multiline = true;
            this.get_package_txt.Name = "get_package_txt";
            this.get_package_txt.Size = new System.Drawing.Size(274, 29);
            this.get_package_txt.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(462, 303);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Package amounts";
            // 
            // get_package_btn
            // 
            this.get_package_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.get_package_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.get_package_btn.Location = new System.Drawing.Point(407, 374);
            this.get_package_btn.Margin = new System.Windows.Forms.Padding(2);
            this.get_package_btn.Name = "get_package_btn";
            this.get_package_btn.Size = new System.Drawing.Size(273, 41);
            this.get_package_btn.TabIndex = 29;
            this.get_package_btn.Text = "Get package data";
            this.get_package_btn.UseVisualStyleBackColor = true;
            this.get_package_btn.Click += new System.EventHandler(this.get_package_btn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(507, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "File name";
            // 
            // saved_file_name_txt
            // 
            this.saved_file_name_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.saved_file_name_txt.Location = new System.Drawing.Point(407, 38);
            this.saved_file_name_txt.Margin = new System.Windows.Forms.Padding(2);
            this.saved_file_name_txt.Name = "saved_file_name_txt";
            this.saved_file_name_txt.Size = new System.Drawing.Size(274, 23);
            this.saved_file_name_txt.TabIndex = 31;
            this.saved_file_name_txt.Text = "new_file.jpg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 423);
            this.Controls.Add(this.saved_file_name_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.get_package_btn);
            this.Controls.Add(this.get_package_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.openport_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errortxt);
            this.Controls.Add(this.senddata_btn);
            this.Controls.Add(this.command_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.baudrate_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Image Display";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox baudrate_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox command_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button senddata_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox errortxt;
        private System.Windows.Forms.Button openport_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox get_package_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button get_package_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox saved_file_name_txt;
    }
}

