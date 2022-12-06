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
            System.Text.DecoderReplacementFallback decoderReplacementFallback2 = new System.Text.DecoderReplacementFallback();
            System.Text.EncoderReplacementFallback encoderReplacementFallback2 = new System.Text.EncoderReplacementFallback();
            this.change_baudrate_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.command_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errortxt = new System.Windows.Forms.TextBox();
            this.openport_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.saved_file_name_txt = new System.Windows.Forms.TextBox();
            this.choose_folder_path_txt = new System.Windows.Forms.RichTextBox();
            this.choose_folder_btn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.senddata_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.baudrate_txt = new System.Windows.Forms.ComboBox();
            this.img_num_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.io1_checkbox = new System.Windows.Forms.CheckBox();
            this.io2_checkbox = new System.Windows.Forms.CheckBox();
            this.io3_checkbox = new System.Windows.Forms.CheckBox();
            this.io4_checkbox = new System.Windows.Forms.CheckBox();
            this.io5_checkbox = new System.Windows.Forms.CheckBox();
            this.triger_io_btn = new System.Windows.Forms.Button();
            this.change_camid_btn = new System.Windows.Forms.Button();
            this.new_id_txt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.current_id_txt = new System.Windows.Forms.ComboBox();
            this.true_checkbox = new System.Windows.Forms.CheckBox();
            this.false_checkbox = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.offline_enable_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // change_baudrate_btn
            // 
            this.change_baudrate_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.change_baudrate_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.change_baudrate_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.change_baudrate_btn.Location = new System.Drawing.Point(10, 195);
            this.change_baudrate_btn.Name = "change_baudrate_btn";
            this.change_baudrate_btn.Size = new System.Drawing.Size(133, 65);
            this.change_baudrate_btn.TabIndex = 41;
            this.change_baudrate_btn.Text = "CHANGE";
            this.change_baudrate_btn.UseVisualStyleBackColor = false;
            this.change_baudrate_btn.Click += new System.EventHandler(this.change_baudrate_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(11, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(702, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Port number";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(10, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Baud rate";
            // 
            // command_txt
            // 
            this.command_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.command_txt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.command_txt.Location = new System.Drawing.Point(233, 127);
            this.command_txt.Multiline = true;
            this.command_txt.Name = "command_txt";
            this.command_txt.Size = new System.Drawing.Size(165, 46);
            this.command_txt.TabIndex = 13;
            this.command_txt.Text = "25";
            this.command_txt.TextChanged += new System.EventHandler(this.command_txt_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(10, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 75);
            this.label6.TabIndex = 12;
            this.label6.Text = "Package size = Input\r\n(hex) convert to dec \r\nthen * 256 and + 8";
            // 
            // errortxt
            // 
            this.errortxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.errortxt.Location = new System.Drawing.Point(11, 462);
            this.errortxt.Multiline = true;
            this.errortxt.Name = "errortxt";
            this.errortxt.ReadOnly = true;
            this.errortxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.errortxt.Size = new System.Drawing.Size(395, 267);
            this.errortxt.TabIndex = 16;
            this.errortxt.TabStop = false;
            // 
            // openport_btn
            // 
            this.openport_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openport_btn.BackColor = System.Drawing.Color.Chartreuse;
            this.openport_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openport_btn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.openport_btn.Location = new System.Drawing.Point(11, 380);
            this.openport_btn.Name = "openport_btn";
            this.openport_btn.Size = new System.Drawing.Size(187, 67);
            this.openport_btn.TabIndex = 20;
            this.openport_btn.Text = "OPEN PORT";
            this.openport_btn.UseVisualStyleBackColor = false;
            this.openport_btn.Click += new System.EventHandler(this.openport_btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 36);
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
            // 
            // saved_file_name_txt
            // 
            this.saved_file_name_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saved_file_name_txt.Location = new System.Drawing.Point(16, 50);
            this.saved_file_name_txt.Name = "saved_file_name_txt";
            this.saved_file_name_txt.Size = new System.Drawing.Size(200, 31);
            this.saved_file_name_txt.TabIndex = 31;
            this.saved_file_name_txt.Text = "new_file.jpg";
            // 
            // choose_folder_path_txt
            // 
            this.choose_folder_path_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.choose_folder_path_txt.Location = new System.Drawing.Point(16, 134);
            this.choose_folder_path_txt.Name = "choose_folder_path_txt";
            this.choose_folder_path_txt.Size = new System.Drawing.Size(388, 76);
            this.choose_folder_path_txt.TabIndex = 33;
            this.choose_folder_path_txt.Text = "";
            // 
            // choose_folder_btn
            // 
            this.choose_folder_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.choose_folder_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.choose_folder_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.choose_folder_btn.Location = new System.Drawing.Point(223, 50);
            this.choose_folder_btn.Name = "choose_folder_btn";
            this.choose_folder_btn.Size = new System.Drawing.Size(181, 79);
            this.choose_folder_btn.TabIndex = 34;
            this.choose_folder_btn.Text = "CHOOSE FOLDER PATH";
            this.choose_folder_btn.UseVisualStyleBackColor = false;
            this.choose_folder_btn.Click += new System.EventHandler(this.choose_folder_btn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.ForeColor = System.Drawing.Color.LawnGreen;
            this.progressBar1.Location = new System.Drawing.Point(362, 380);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(351, 67);
            this.progressBar1.TabIndex = 37;
            // 
            // senddata_btn
            // 
            this.senddata_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.senddata_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.senddata_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.senddata_btn.Location = new System.Drawing.Point(233, 30);
            this.senddata_btn.Name = "senddata_btn";
            this.senddata_btn.Size = new System.Drawing.Size(171, 66);
            this.senddata_btn.TabIndex = 14;
            this.senddata_btn.Text = "SEND DATA";
            this.senddata_btn.UseVisualStyleBackColor = false;
            this.senddata_btn.Click += new System.EventHandler(this.senddata_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Folder path";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(16, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "File name";
            // 
            // baudrate_txt
            // 
            this.baudrate_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.baudrate_txt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.baudrate_txt.FormattingEnabled = true;
            this.baudrate_txt.Items.AddRange(new object[] {
            "115200",
            "230400",
            "460800",
            "921600"});
            this.baudrate_txt.Location = new System.Drawing.Point(10, 147);
            this.baudrate_txt.Name = "baudrate_txt";
            this.baudrate_txt.Size = new System.Drawing.Size(131, 36);
            this.baudrate_txt.TabIndex = 40;
            this.baudrate_txt.Text = "460800";
            // 
            // img_num_txt
            // 
            this.img_num_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.img_num_txt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.img_num_txt.Location = new System.Drawing.Point(13, 52);
            this.img_num_txt.Multiline = true;
            this.img_num_txt.Name = "img_num_txt";
            this.img_num_txt.Size = new System.Drawing.Size(203, 41);
            this.img_num_txt.TabIndex = 43;
            this.img_num_txt.Text = "10";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(13, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 25);
            this.label7.TabIndex = 42;
            this.label7.Text = "Number of images";
            // 
            // io1_checkbox
            // 
            this.io1_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.io1_checkbox.AutoSize = true;
            this.io1_checkbox.Location = new System.Drawing.Point(33, 22);
            this.io1_checkbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.io1_checkbox.Name = "io1_checkbox";
            this.io1_checkbox.Size = new System.Drawing.Size(67, 29);
            this.io1_checkbox.TabIndex = 44;
            this.io1_checkbox.Text = "IO1";
            this.io1_checkbox.UseVisualStyleBackColor = true;
            // 
            // io2_checkbox
            // 
            this.io2_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.io2_checkbox.AutoSize = true;
            this.io2_checkbox.Location = new System.Drawing.Point(105, 22);
            this.io2_checkbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.io2_checkbox.Name = "io2_checkbox";
            this.io2_checkbox.Size = new System.Drawing.Size(67, 29);
            this.io2_checkbox.TabIndex = 45;
            this.io2_checkbox.Text = "IO2";
            this.io2_checkbox.UseVisualStyleBackColor = true;
            // 
            // io3_checkbox
            // 
            this.io3_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.io3_checkbox.AutoSize = true;
            this.io3_checkbox.Location = new System.Drawing.Point(176, 22);
            this.io3_checkbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.io3_checkbox.Name = "io3_checkbox";
            this.io3_checkbox.Size = new System.Drawing.Size(67, 29);
            this.io3_checkbox.TabIndex = 46;
            this.io3_checkbox.Text = "IO3";
            this.io3_checkbox.UseVisualStyleBackColor = true;
            // 
            // io4_checkbox
            // 
            this.io4_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.io4_checkbox.AutoSize = true;
            this.io4_checkbox.Location = new System.Drawing.Point(248, 22);
            this.io4_checkbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.io4_checkbox.Name = "io4_checkbox";
            this.io4_checkbox.Size = new System.Drawing.Size(67, 29);
            this.io4_checkbox.TabIndex = 47;
            this.io4_checkbox.Text = "IO4";
            this.io4_checkbox.UseVisualStyleBackColor = true;
            // 
            // io5_checkbox
            // 
            this.io5_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.io5_checkbox.AutoSize = true;
            this.io5_checkbox.Location = new System.Drawing.Point(319, 22);
            this.io5_checkbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.io5_checkbox.Name = "io5_checkbox";
            this.io5_checkbox.Size = new System.Drawing.Size(67, 29);
            this.io5_checkbox.TabIndex = 48;
            this.io5_checkbox.Text = "IO5";
            this.io5_checkbox.UseVisualStyleBackColor = true;
            // 
            // triger_io_btn
            // 
            this.triger_io_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.triger_io_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.triger_io_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.triger_io_btn.Location = new System.Drawing.Point(15, 62);
            this.triger_io_btn.Name = "triger_io_btn";
            this.triger_io_btn.Size = new System.Drawing.Size(389, 52);
            this.triger_io_btn.TabIndex = 49;
            this.triger_io_btn.Text = "TRIGGER IO";
            this.triger_io_btn.UseVisualStyleBackColor = false;
            this.triger_io_btn.Click += new System.EventHandler(this.triger_io_btn_Click);
            // 
            // change_camid_btn
            // 
            this.change_camid_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.change_camid_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.change_camid_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.change_camid_btn.Location = new System.Drawing.Point(170, 195);
            this.change_camid_btn.Name = "change_camid_btn";
            this.change_camid_btn.Size = new System.Drawing.Size(111, 65);
            this.change_camid_btn.TabIndex = 54;
            this.change_camid_btn.Text = "CHANGE";
            this.change_camid_btn.UseVisualStyleBackColor = false;
            this.change_camid_btn.Click += new System.EventHandler(this.change_camid_btn_Click);
            // 
            // new_id_txt
            // 
            this.new_id_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.new_id_txt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.new_id_txt.FormattingEnabled = true;
            this.new_id_txt.Items.AddRange(new object[] {
            "01",
            "02",
            "03"});
            this.new_id_txt.Location = new System.Drawing.Point(170, 147);
            this.new_id_txt.Name = "new_id_txt";
            this.new_id_txt.Size = new System.Drawing.Size(111, 36);
            this.new_id_txt.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(170, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "New ID";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(170, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 25);
            this.label8.TabIndex = 50;
            this.label8.Text = "Current ID";
            // 
            // current_id_txt
            // 
            this.current_id_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.current_id_txt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.current_id_txt.FormattingEnabled = true;
            this.current_id_txt.Items.AddRange(new object[] {
            "01",
            "02",
            "03"});
            this.current_id_txt.Location = new System.Drawing.Point(170, 45);
            this.current_id_txt.Name = "current_id_txt";
            this.current_id_txt.Size = new System.Drawing.Size(111, 36);
            this.current_id_txt.TabIndex = 52;
            this.current_id_txt.Text = "01";
            // 
            // true_checkbox
            // 
            this.true_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.true_checkbox.AutoSize = true;
            this.true_checkbox.Location = new System.Drawing.Point(12, 79);
            this.true_checkbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.true_checkbox.Name = "true_checkbox";
            this.true_checkbox.Size = new System.Drawing.Size(79, 29);
            this.true_checkbox.TabIndex = 55;
            this.true_checkbox.Text = "TRUE";
            this.true_checkbox.UseVisualStyleBackColor = true;
            // 
            // false_checkbox
            // 
            this.false_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.false_checkbox.AutoSize = true;
            this.false_checkbox.Location = new System.Drawing.Point(12, 20);
            this.false_checkbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.false_checkbox.Name = "false_checkbox";
            this.false_checkbox.Size = new System.Drawing.Size(85, 29);
            this.false_checkbox.TabIndex = 56;
            this.false_checkbox.Text = "FALSE";
            this.false_checkbox.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(106, 20);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(141, 87);
            this.richTextBox1.TabIndex = 57;
            this.richTextBox1.Text = "";
            // 
            // offline_enable_btn
            // 
            this.offline_enable_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.offline_enable_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.offline_enable_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.offline_enable_btn.Location = new System.Drawing.Point(276, 20);
            this.offline_enable_btn.Name = "offline_enable_btn";
            this.offline_enable_btn.Size = new System.Drawing.Size(124, 87);
            this.offline_enable_btn.TabIndex = 58;
            this.offline_enable_btn.Text = "CHECK";
            this.offline_enable_btn.UseVisualStyleBackColor = false;
            this.offline_enable_btn.Click += new System.EventHandler(this.offline_enable_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clear_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear_btn.Location = new System.Drawing.Point(219, 380);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(119, 67);
            this.clear_btn.TabIndex = 59;
            this.clear_btn.Text = "CLEAR";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.choose_folder_btn);
            this.groupBox1.Controls.Add(this.choose_folder_path_txt);
            this.groupBox1.Controls.Add(this.saved_file_name_txt);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(736, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 227);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.offline_enable_btn);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.false_checkbox);
            this.groupBox2.Controls.Add(this.true_checkbox);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(736, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 121);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.triger_io_btn);
            this.groupBox3.Controls.Add(this.io5_checkbox);
            this.groupBox3.Controls.Add(this.io4_checkbox);
            this.groupBox3.Controls.Add(this.io3_checkbox);
            this.groupBox3.Controls.Add(this.io2_checkbox);
            this.groupBox3.Controls.Add(this.io1_checkbox);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(740, 394);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 133);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.img_num_txt);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.senddata_btn);
            this.groupBox4.Controls.Add(this.command_txt);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Location = new System.Drawing.Point(736, 549);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(416, 192);
            this.groupBox4.TabIndex = 63;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.change_camid_btn);
            this.groupBox5.Controls.Add(this.new_id_txt);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.current_id_txt);
            this.groupBox5.Controls.Add(this.change_baudrate_btn);
            this.groupBox5.Controls.Add(this.baudrate_txt);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox5.Location = new System.Drawing.Point(417, 462);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(296, 270);
            this.groupBox5.TabIndex = 64;
            this.groupBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 750);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.openport_btn);
            this.Controls.Add(this.errortxt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Image Display";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_Close);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox command_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox errortxt;
        private System.Windows.Forms.Button openport_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox saved_file_name_txt;
        private System.Windows.Forms.RichTextBox choose_folder_path_txt;
        private System.Windows.Forms.Button choose_folder_btn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button senddata_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox baudrate_txt;
        private System.Windows.Forms.Button change_baudrate_btn;
        private System.Windows.Forms.TextBox img_num_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox io1_checkbox;
        private System.Windows.Forms.CheckBox io2_checkbox;
        private System.Windows.Forms.CheckBox io3_checkbox;
        private System.Windows.Forms.CheckBox io4_checkbox;
        private System.Windows.Forms.CheckBox io5_checkbox;
        private System.Windows.Forms.Button triger_io_btn;
        private System.Windows.Forms.Button change_camid_btn;
        private System.Windows.Forms.ComboBox new_id_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox current_id_txt;
        private System.Windows.Forms.CheckBox true_checkbox;
        private System.Windows.Forms.CheckBox false_checkbox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button offline_enable_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

