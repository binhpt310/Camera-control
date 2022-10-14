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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.baudrate_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.command_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.senddata_btn = new System.Windows.Forms.Button();
            this.data_receive_txt = new System.Windows.Forms.TextBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.getdata_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errortxt = new System.Windows.Forms.TextBox();
            this.openport_btn = new System.Windows.Forms.Button();
            this.closeport_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Location = new System.Drawing.Point(441, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(134, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "JPG Image";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(569, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "PNG Image";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(843, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Port number";
            // 
            // baudrate_txt
            // 
            this.baudrate_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baudrate_txt.Location = new System.Drawing.Point(848, 205);
            this.baudrate_txt.Name = "baudrate_txt";
            this.baudrate_txt.Size = new System.Drawing.Size(188, 26);
            this.baudrate_txt.TabIndex = 11;
            this.baudrate_txt.Text = "9600";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(843, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Baud rate";
            // 
            // command_txt
            // 
            this.command_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.command_txt.Location = new System.Drawing.Point(848, 298);
            this.command_txt.Multiline = true;
            this.command_txt.Name = "command_txt";
            this.command_txt.Size = new System.Drawing.Size(221, 75);
            this.command_txt.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(843, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Command";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // senddata_btn
            // 
            this.senddata_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.senddata_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senddata_btn.Location = new System.Drawing.Point(848, 387);
            this.senddata_btn.Name = "senddata_btn";
            this.senddata_btn.Size = new System.Drawing.Size(221, 50);
            this.senddata_btn.TabIndex = 14;
            this.senddata_btn.Text = "Send data";
            this.senddata_btn.UseVisualStyleBackColor = true;
            this.senddata_btn.Click += new System.EventHandler(this.senddata_btn_Click);
            // 
            // data_receive_txt
            // 
            this.data_receive_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.data_receive_txt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data_receive_txt.Location = new System.Drawing.Point(12, 326);
            this.data_receive_txt.Multiline = true;
            this.data_receive_txt.Name = "data_receive_txt";
            this.data_receive_txt.ReadOnly = true;
            this.data_receive_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_receive_txt.Size = new System.Drawing.Size(779, 111);
            this.data_receive_txt.TabIndex = 15;
            this.data_receive_txt.TextChanged += new System.EventHandler(this.data_receive_txt_TextChanged);
            // 
            // clear_btn
            // 
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.Location = new System.Drawing.Point(13, 225);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(130, 88);
            this.clear_btn.TabIndex = 19;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // getdata_btn
            // 
            this.getdata_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getdata_btn.Location = new System.Drawing.Point(149, 225);
            this.getdata_btn.Name = "getdata_btn";
            this.getdata_btn.Size = new System.Drawing.Size(119, 88);
            this.getdata_btn.TabIndex = 18;
            this.getdata_btn.Text = "Get data";
            this.getdata_btn.UseVisualStyleBackColor = true;
            this.getdata_btn.Click += new System.EventHandler(this.getdata_btn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(437, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Error checking";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errortxt
            // 
            this.errortxt.Location = new System.Drawing.Point(441, 264);
            this.errortxt.Multiline = true;
            this.errortxt.Name = "errortxt";
            this.errortxt.ReadOnly = true;
            this.errortxt.Size = new System.Drawing.Size(350, 50);
            this.errortxt.TabIndex = 16;
            // 
            // openport_btn
            // 
            this.openport_btn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.openport_btn.Location = new System.Drawing.Point(274, 225);
            this.openport_btn.Name = "openport_btn";
            this.openport_btn.Size = new System.Drawing.Size(88, 41);
            this.openport_btn.TabIndex = 20;
            this.openport_btn.Text = "Open";
            this.openport_btn.UseVisualStyleBackColor = false;
            this.openport_btn.Click += new System.EventHandler(this.openport_btn_Click);
            // 
            // closeport_btn
            // 
            this.closeport_btn.BackColor = System.Drawing.Color.LightCoral;
            this.closeport_btn.Location = new System.Drawing.Point(274, 272);
            this.closeport_btn.Name = "closeport_btn";
            this.closeport_btn.Size = new System.Drawing.Size(88, 41);
            this.closeport_btn.TabIndex = 21;
            this.closeport_btn.Text = "Close";
            this.closeport_btn.UseVisualStyleBackColor = false;
            this.closeport_btn.Click += new System.EventHandler(this.closeport_btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(848, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Text = "COM22";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.closeport_btn);
            this.Controls.Add(this.openport_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.getdata_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errortxt);
            this.Controls.Add(this.data_receive_txt);
            this.Controls.Add(this.senddata_btn);
            this.Controls.Add(this.command_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.baudrate_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Image Display";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox baudrate_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox command_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button senddata_btn;
        private System.Windows.Forms.TextBox data_receive_txt;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button getdata_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox errortxt;
        private System.Windows.Forms.Button openport_btn;
        private System.Windows.Forms.Button closeport_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

