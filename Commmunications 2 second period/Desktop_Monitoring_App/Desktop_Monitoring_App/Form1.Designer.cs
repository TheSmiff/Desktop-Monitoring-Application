namespace Desktop_Monitoring_App
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
            this.label_Author = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Options = new System.Windows.Forms.GroupBox();
            this.label_Data = new System.Windows.Forms.Label();
            this.label_Stop = new System.Windows.Forms.Label();
            this.label_Parity = new System.Windows.Forms.Label();
            this.label_Flow = new System.Windows.Forms.Label();
            this.label_Baud = new System.Windows.Forms.Label();
            this.label_Port = new System.Windows.Forms.Label();
            this.comboBox_Stop = new System.Windows.Forms.ComboBox();
            this.comboBox_Parity = new System.Windows.Forms.ComboBox();
            this.comboBox_Flow = new System.Windows.Forms.ComboBox();
            this.comboBox_Data = new System.Windows.Forms.ComboBox();
            this.comboBox_Baud = new System.Windows.Forms.ComboBox();
            this.comboBox_Port = new System.Windows.Forms.ComboBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.tabControl_Interface = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_Send = new System.Windows.Forms.Button();
            this.checkBox_Hex = new System.Windows.Forms.CheckBox();
            this.groupBox_Hex = new System.Windows.Forms.GroupBox();
            this.textBox_SendHex = new System.Windows.Forms.TextBox();
            this.groupBox_String = new System.Windows.Forms.GroupBox();
            this.textBox_Send = new System.Windows.Forms.TextBox();
            this.label_Send = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Query = new System.Windows.Forms.Button();
            this.richTextBox_RawComms = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox_Robot3 = new System.Windows.Forms.GroupBox();
            this.groupBox_Robot2 = new System.Windows.Forms.GroupBox();
            this.groupBox_Robot1 = new System.Windows.Forms.GroupBox();
            this.label_RawRecieved = new System.Windows.Forms.Label();
            this.button_Log = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label_Status = new System.Windows.Forms.Label();
            this.pictureBox_Status = new System.Windows.Forms.PictureBox();
            this.label_R1Tag = new System.Windows.Forms.Label();
            this.label_R1XPos = new System.Windows.Forms.Label();
            this.label_R1YPos = new System.Windows.Forms.Label();
            this.label_R1LR = new System.Windows.Forms.Label();
            this.label_R1SR = new System.Windows.Forms.Label();
            this.label_R2SR = new System.Windows.Forms.Label();
            this.label_R2LR = new System.Windows.Forms.Label();
            this.label_R2YPos = new System.Windows.Forms.Label();
            this.label_R2XPos = new System.Windows.Forms.Label();
            this.label_R2Tag = new System.Windows.Forms.Label();
            this.label_R3SR = new System.Windows.Forms.Label();
            this.label_R3LR = new System.Windows.Forms.Label();
            this.label_R3Ypos = new System.Windows.Forms.Label();
            this.label_R3XPos = new System.Windows.Forms.Label();
            this.label_R3Tag = new System.Windows.Forms.Label();
            this.label_R1TagData = new System.Windows.Forms.Label();
            this.label_R1XPosData = new System.Windows.Forms.Label();
            this.label_R1YPosData = new System.Windows.Forms.Label();
            this.label_R1LRData = new System.Windows.Forms.Label();
            this.label_R1SRData = new System.Windows.Forms.Label();
            this.label_R2SRData = new System.Windows.Forms.Label();
            this.label_R2LRData = new System.Windows.Forms.Label();
            this.label_R2YPosData = new System.Windows.Forms.Label();
            this.label_R2XPosData = new System.Windows.Forms.Label();
            this.label_R2TagData = new System.Windows.Forms.Label();
            this.label_R3SRData = new System.Windows.Forms.Label();
            this.label_R3LRData = new System.Windows.Forms.Label();
            this.label_R3YPosData = new System.Windows.Forms.Label();
            this.label_R3XPosData = new System.Windows.Forms.Label();
            this.label_R3TagData = new System.Windows.Forms.Label();
            this.groupBox_Options.SuspendLayout();
            this.tabControl_Interface.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_Hex.SuspendLayout();
            this.groupBox_String.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox_Robot3.SuspendLayout();
            this.groupBox_Robot2.SuspendLayout();
            this.groupBox_Robot1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Status)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Author
            // 
            this.label_Author.AutoSize = true;
            this.label_Author.Location = new System.Drawing.Point(87, 431);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(633, 13);
            this.label_Author.TabIndex = 1;
            this.label_Author.Text = "Thomas Smith - tjs1g10@ecs.soton.ac.uk - Part III Individual Project - Electronic" +
    "s and Computer Science - University of Southampton";
            this.label_Author.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "PC Control and Monitoring Application";
            // 
            // groupBox_Options
            // 
            this.groupBox_Options.Controls.Add(this.label_Data);
            this.groupBox_Options.Controls.Add(this.label_Stop);
            this.groupBox_Options.Controls.Add(this.label_Parity);
            this.groupBox_Options.Controls.Add(this.label_Flow);
            this.groupBox_Options.Controls.Add(this.label_Baud);
            this.groupBox_Options.Controls.Add(this.label_Port);
            this.groupBox_Options.Controls.Add(this.comboBox_Stop);
            this.groupBox_Options.Controls.Add(this.comboBox_Parity);
            this.groupBox_Options.Controls.Add(this.comboBox_Flow);
            this.groupBox_Options.Controls.Add(this.comboBox_Data);
            this.groupBox_Options.Controls.Add(this.comboBox_Baud);
            this.groupBox_Options.Controls.Add(this.comboBox_Port);
            this.groupBox_Options.Location = new System.Drawing.Point(648, 11);
            this.groupBox_Options.Name = "groupBox_Options";
            this.groupBox_Options.Size = new System.Drawing.Size(134, 327);
            this.groupBox_Options.TabIndex = 4;
            this.groupBox_Options.TabStop = false;
            this.groupBox_Options.Text = "Port Options";
            // 
            // label_Data
            // 
            this.label_Data.AutoSize = true;
            this.label_Data.Location = new System.Drawing.Point(7, 280);
            this.label_Data.Name = "label_Data";
            this.label_Data.Size = new System.Drawing.Size(50, 13);
            this.label_Data.TabIndex = 11;
            this.label_Data.Text = "Data Bits";
            // 
            // label_Stop
            // 
            this.label_Stop.AutoSize = true;
            this.label_Stop.Location = new System.Drawing.Point(7, 225);
            this.label_Stop.Name = "label_Stop";
            this.label_Stop.Size = new System.Drawing.Size(49, 13);
            this.label_Stop.TabIndex = 10;
            this.label_Stop.Text = "Stop Bits";
            // 
            // label_Parity
            // 
            this.label_Parity.AutoSize = true;
            this.label_Parity.Location = new System.Drawing.Point(7, 175);
            this.label_Parity.Name = "label_Parity";
            this.label_Parity.Size = new System.Drawing.Size(53, 13);
            this.label_Parity.TabIndex = 9;
            this.label_Parity.Text = "Parity Bits";
            // 
            // label_Flow
            // 
            this.label_Flow.AutoSize = true;
            this.label_Flow.Location = new System.Drawing.Point(7, 126);
            this.label_Flow.Name = "label_Flow";
            this.label_Flow.Size = new System.Drawing.Size(65, 13);
            this.label_Flow.TabIndex = 8;
            this.label_Flow.Text = "Flow Control";
            // 
            // label_Baud
            // 
            this.label_Baud.AutoSize = true;
            this.label_Baud.Location = new System.Drawing.Point(7, 76);
            this.label_Baud.Name = "label_Baud";
            this.label_Baud.Size = new System.Drawing.Size(58, 13);
            this.label_Baud.TabIndex = 7;
            this.label_Baud.Text = "Baud Rate";
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Location = new System.Drawing.Point(7, 22);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(26, 13);
            this.label_Port.TabIndex = 6;
            this.label_Port.Text = "Port";
            // 
            // comboBox_Stop
            // 
            this.comboBox_Stop.FormattingEnabled = true;
            this.comboBox_Stop.Location = new System.Drawing.Point(6, 241);
            this.comboBox_Stop.Name = "comboBox_Stop";
            this.comboBox_Stop.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Stop.TabIndex = 5;
            // 
            // comboBox_Parity
            // 
            this.comboBox_Parity.FormattingEnabled = true;
            this.comboBox_Parity.Location = new System.Drawing.Point(6, 191);
            this.comboBox_Parity.Name = "comboBox_Parity";
            this.comboBox_Parity.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Parity.TabIndex = 4;
            // 
            // comboBox_Flow
            // 
            this.comboBox_Flow.FormattingEnabled = true;
            this.comboBox_Flow.Location = new System.Drawing.Point(6, 142);
            this.comboBox_Flow.Name = "comboBox_Flow";
            this.comboBox_Flow.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Flow.TabIndex = 3;
            // 
            // comboBox_Data
            // 
            this.comboBox_Data.FormattingEnabled = true;
            this.comboBox_Data.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox_Data.Location = new System.Drawing.Point(6, 296);
            this.comboBox_Data.Name = "comboBox_Data";
            this.comboBox_Data.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Data.TabIndex = 2;
            // 
            // comboBox_Baud
            // 
            this.comboBox_Baud.FormattingEnabled = true;
            this.comboBox_Baud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.comboBox_Baud.Location = new System.Drawing.Point(6, 92);
            this.comboBox_Baud.Name = "comboBox_Baud";
            this.comboBox_Baud.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Baud.TabIndex = 1;
            // 
            // comboBox_Port
            // 
            this.comboBox_Port.FormattingEnabled = true;
            this.comboBox_Port.Location = new System.Drawing.Point(6, 41);
            this.comboBox_Port.Name = "comboBox_Port";
            this.comboBox_Port.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Port.TabIndex = 0;
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(648, 376);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(134, 23);
            this.button_Connect.TabIndex = 0;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Enabled = false;
            this.button_Disconnect.Location = new System.Drawing.Point(648, 405);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(134, 23);
            this.button_Disconnect.TabIndex = 5;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // tabControl_Interface
            // 
            this.tabControl_Interface.Controls.Add(this.tabPage1);
            this.tabControl_Interface.Controls.Add(this.tabPage3);
            this.tabControl_Interface.Controls.Add(this.tabPage2);
            this.tabControl_Interface.Location = new System.Drawing.Point(13, 40);
            this.tabControl_Interface.Name = "tabControl_Interface";
            this.tabControl_Interface.SelectedIndex = 0;
            this.tabControl_Interface.Size = new System.Drawing.Size(629, 388);
            this.tabControl_Interface.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_Send);
            this.tabPage1.Controls.Add(this.checkBox_Hex);
            this.tabPage1.Controls.Add(this.groupBox_Hex);
            this.tabPage1.Controls.Add(this.groupBox_String);
            this.tabPage1.Controls.Add(this.label_Send);
            this.tabPage1.Controls.Add(this.button_Clear);
            this.tabPage1.Controls.Add(this.button_Query);
            this.tabPage1.Controls.Add(this.richTextBox_RawComms);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(621, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Terminal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(466, 336);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 23);
            this.button_Send.TabIndex = 8;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // checkBox_Hex
            // 
            this.checkBox_Hex.AutoSize = true;
            this.checkBox_Hex.Location = new System.Drawing.Point(468, 320);
            this.checkBox_Hex.Name = "checkBox_Hex";
            this.checkBox_Hex.Size = new System.Drawing.Size(45, 17);
            this.checkBox_Hex.TabIndex = 7;
            this.checkBox_Hex.Text = "Hex";
            this.checkBox_Hex.UseVisualStyleBackColor = true;
            this.checkBox_Hex.CheckedChanged += new System.EventHandler(this.checkBox_Hex_CheckedChanged);
            // 
            // groupBox_Hex
            // 
            this.groupBox_Hex.Controls.Add(this.textBox_SendHex);
            this.groupBox_Hex.Location = new System.Drawing.Point(239, 314);
            this.groupBox_Hex.Name = "groupBox_Hex";
            this.groupBox_Hex.Size = new System.Drawing.Size(223, 45);
            this.groupBox_Hex.TabIndex = 6;
            this.groupBox_Hex.TabStop = false;
            this.groupBox_Hex.Text = "Send Hex";
            // 
            // textBox_SendHex
            // 
            this.textBox_SendHex.Location = new System.Drawing.Point(6, 17);
            this.textBox_SendHex.Name = "textBox_SendHex";
            this.textBox_SendHex.Size = new System.Drawing.Size(211, 20);
            this.textBox_SendHex.TabIndex = 5;
            // 
            // groupBox_String
            // 
            this.groupBox_String.Controls.Add(this.textBox_Send);
            this.groupBox_String.Location = new System.Drawing.Point(10, 314);
            this.groupBox_String.Name = "groupBox_String";
            this.groupBox_String.Size = new System.Drawing.Size(223, 43);
            this.groupBox_String.TabIndex = 5;
            this.groupBox_String.TabStop = false;
            this.groupBox_String.Text = "Send String";
            // 
            // textBox_Send
            // 
            this.textBox_Send.Location = new System.Drawing.Point(4, 17);
            this.textBox_Send.Name = "textBox_Send";
            this.textBox_Send.Size = new System.Drawing.Size(211, 20);
            this.textBox_Send.TabIndex = 3;
            // 
            // label_Send
            // 
            this.label_Send.AutoSize = true;
            this.label_Send.Location = new System.Drawing.Point(7, 314);
            this.label_Send.Name = "label_Send";
            this.label_Send.Size = new System.Drawing.Size(0, 13);
            this.label_Send.TabIndex = 4;
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(540, 336);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 2;
            this.button_Clear.Text = "Clear Page";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Query
            // 
            this.button_Query.Location = new System.Drawing.Point(540, 314);
            this.button_Query.Name = "button_Query";
            this.button_Query.Size = new System.Drawing.Size(75, 23);
            this.button_Query.TabIndex = 1;
            this.button_Query.Text = "Query Xbee";
            this.button_Query.UseVisualStyleBackColor = true;
            this.button_Query.Click += new System.EventHandler(this.button_Query_Click);
            // 
            // richTextBox_RawComms
            // 
            this.richTextBox_RawComms.Location = new System.Drawing.Point(7, 7);
            this.richTextBox_RawComms.Name = "richTextBox_RawComms";
            this.richTextBox_RawComms.Size = new System.Drawing.Size(608, 305);
            this.richTextBox_RawComms.TabIndex = 0;
            this.richTextBox_RawComms.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox_Robot3);
            this.tabPage3.Controls.Add(this.groupBox_Robot2);
            this.tabPage3.Controls.Add(this.groupBox_Robot1);
            this.tabPage3.Controls.Add(this.label_RawRecieved);
            this.tabPage3.Controls.Add(this.button_Log);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(621, 362);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Raw Data";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox_Robot3
            // 
            this.groupBox_Robot3.Controls.Add(this.label_R3SRData);
            this.groupBox_Robot3.Controls.Add(this.label_R3LRData);
            this.groupBox_Robot3.Controls.Add(this.label_R3YPosData);
            this.groupBox_Robot3.Controls.Add(this.label_R3XPosData);
            this.groupBox_Robot3.Controls.Add(this.label_R3TagData);
            this.groupBox_Robot3.Controls.Add(this.label_R3SR);
            this.groupBox_Robot3.Controls.Add(this.label_R3LR);
            this.groupBox_Robot3.Controls.Add(this.label_R3Ypos);
            this.groupBox_Robot3.Controls.Add(this.label_R3XPos);
            this.groupBox_Robot3.Controls.Add(this.label_R3Tag);
            this.groupBox_Robot3.Location = new System.Drawing.Point(383, 41);
            this.groupBox_Robot3.Name = "groupBox_Robot3";
            this.groupBox_Robot3.Size = new System.Drawing.Size(180, 120);
            this.groupBox_Robot3.TabIndex = 4;
            this.groupBox_Robot3.TabStop = false;
            this.groupBox_Robot3.Text = "Robot 3";
            // 
            // groupBox_Robot2
            // 
            this.groupBox_Robot2.Controls.Add(this.label_R2SRData);
            this.groupBox_Robot2.Controls.Add(this.label_R2LRData);
            this.groupBox_Robot2.Controls.Add(this.label_R2YPosData);
            this.groupBox_Robot2.Controls.Add(this.label_R2XPosData);
            this.groupBox_Robot2.Controls.Add(this.label_R2TagData);
            this.groupBox_Robot2.Controls.Add(this.label_R2SR);
            this.groupBox_Robot2.Controls.Add(this.label_R2LR);
            this.groupBox_Robot2.Controls.Add(this.label_R2YPos);
            this.groupBox_Robot2.Controls.Add(this.label_R2XPos);
            this.groupBox_Robot2.Controls.Add(this.label_R2Tag);
            this.groupBox_Robot2.Location = new System.Drawing.Point(197, 41);
            this.groupBox_Robot2.Name = "groupBox_Robot2";
            this.groupBox_Robot2.Size = new System.Drawing.Size(180, 120);
            this.groupBox_Robot2.TabIndex = 3;
            this.groupBox_Robot2.TabStop = false;
            this.groupBox_Robot2.Text = "Robot 2";
            // 
            // groupBox_Robot1
            // 
            this.groupBox_Robot1.Controls.Add(this.label_R1SRData);
            this.groupBox_Robot1.Controls.Add(this.label_R1LRData);
            this.groupBox_Robot1.Controls.Add(this.label_R1YPosData);
            this.groupBox_Robot1.Controls.Add(this.label_R1XPosData);
            this.groupBox_Robot1.Controls.Add(this.label_R1TagData);
            this.groupBox_Robot1.Controls.Add(this.label_R1SR);
            this.groupBox_Robot1.Controls.Add(this.label_R1LR);
            this.groupBox_Robot1.Controls.Add(this.label_R1YPos);
            this.groupBox_Robot1.Controls.Add(this.label_R1XPos);
            this.groupBox_Robot1.Controls.Add(this.label_R1Tag);
            this.groupBox_Robot1.Location = new System.Drawing.Point(11, 41);
            this.groupBox_Robot1.Name = "groupBox_Robot1";
            this.groupBox_Robot1.Size = new System.Drawing.Size(180, 120);
            this.groupBox_Robot1.TabIndex = 2;
            this.groupBox_Robot1.TabStop = false;
            this.groupBox_Robot1.Text = "Robot 1";
            // 
            // label_RawRecieved
            // 
            this.label_RawRecieved.AutoSize = true;
            this.label_RawRecieved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RawRecieved.Location = new System.Drawing.Point(7, 7);
            this.label_RawRecieved.Name = "label_RawRecieved";
            this.label_RawRecieved.Size = new System.Drawing.Size(128, 20);
            this.label_RawRecieved.TabIndex = 1;
            this.label_RawRecieved.Text = "Raw Robot Data";
            // 
            // button_Log
            // 
            this.button_Log.Location = new System.Drawing.Point(519, 6);
            this.button_Log.Name = "button_Log";
            this.button_Log.Size = new System.Drawing.Size(96, 23);
            this.button_Log.TabIndex = 0;
            this.button_Log.Text = "Start Logging";
            this.button_Log.UseVisualStyleBackColor = true;
            this.button_Log.Click += new System.EventHandler(this.button_Log_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(621, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Battery Status";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(650, 351);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(94, 13);
            this.label_Status.TabIndex = 7;
            this.label_Status.Text = "Connection Status";
            // 
            // pictureBox_Status
            // 
            this.pictureBox_Status.Location = new System.Drawing.Point(750, 344);
            this.pictureBox_Status.Name = "pictureBox_Status";
            this.pictureBox_Status.Size = new System.Drawing.Size(32, 29);
            this.pictureBox_Status.TabIndex = 8;
            this.pictureBox_Status.TabStop = false;
            // 
            // label_R1Tag
            // 
            this.label_R1Tag.AutoSize = true;
            this.label_R1Tag.Location = new System.Drawing.Point(7, 20);
            this.label_R1Tag.Name = "label_R1Tag";
            this.label_R1Tag.Size = new System.Drawing.Size(26, 13);
            this.label_R1Tag.TabIndex = 0;
            this.label_R1Tag.Text = "Tag";
            // 
            // label_R1XPos
            // 
            this.label_R1XPos.AutoSize = true;
            this.label_R1XPos.Location = new System.Drawing.Point(7, 37);
            this.label_R1XPos.Name = "label_R1XPos";
            this.label_R1XPos.Size = new System.Drawing.Size(54, 13);
            this.label_R1XPos.TabIndex = 1;
            this.label_R1XPos.Text = "X Position";
            // 
            // label_R1YPos
            // 
            this.label_R1YPos.AutoSize = true;
            this.label_R1YPos.Location = new System.Drawing.Point(7, 57);
            this.label_R1YPos.Name = "label_R1YPos";
            this.label_R1YPos.Size = new System.Drawing.Size(54, 13);
            this.label_R1YPos.TabIndex = 2;
            this.label_R1YPos.Text = "Y Position";
            // 
            // label_R1LR
            // 
            this.label_R1LR.AutoSize = true;
            this.label_R1LR.Location = new System.Drawing.Point(7, 74);
            this.label_R1LR.Name = "label_R1LR";
            this.label_R1LR.Size = new System.Drawing.Size(73, 13);
            this.label_R1LR.TabIndex = 3;
            this.label_R1LR.Text = "Light Reading";
            // 
            // label_R1SR
            // 
            this.label_R1SR.AutoSize = true;
            this.label_R1SR.Location = new System.Drawing.Point(7, 91);
            this.label_R1SR.Name = "label_R1SR";
            this.label_R1SR.Size = new System.Drawing.Size(81, 13);
            this.label_R1SR.TabIndex = 4;
            this.label_R1SR.Text = "Sound Reading";
            // 
            // label_R2SR
            // 
            this.label_R2SR.AutoSize = true;
            this.label_R2SR.Location = new System.Drawing.Point(6, 91);
            this.label_R2SR.Name = "label_R2SR";
            this.label_R2SR.Size = new System.Drawing.Size(81, 13);
            this.label_R2SR.TabIndex = 9;
            this.label_R2SR.Text = "Sound Reading";
            // 
            // label_R2LR
            // 
            this.label_R2LR.AutoSize = true;
            this.label_R2LR.Location = new System.Drawing.Point(6, 74);
            this.label_R2LR.Name = "label_R2LR";
            this.label_R2LR.Size = new System.Drawing.Size(73, 13);
            this.label_R2LR.TabIndex = 8;
            this.label_R2LR.Text = "Light Reading";
            // 
            // label_R2YPos
            // 
            this.label_R2YPos.AutoSize = true;
            this.label_R2YPos.Location = new System.Drawing.Point(6, 57);
            this.label_R2YPos.Name = "label_R2YPos";
            this.label_R2YPos.Size = new System.Drawing.Size(54, 13);
            this.label_R2YPos.TabIndex = 7;
            this.label_R2YPos.Text = "Y Position";
            // 
            // label_R2XPos
            // 
            this.label_R2XPos.AutoSize = true;
            this.label_R2XPos.Location = new System.Drawing.Point(6, 37);
            this.label_R2XPos.Name = "label_R2XPos";
            this.label_R2XPos.Size = new System.Drawing.Size(54, 13);
            this.label_R2XPos.TabIndex = 6;
            this.label_R2XPos.Text = "X Position";
            // 
            // label_R2Tag
            // 
            this.label_R2Tag.AutoSize = true;
            this.label_R2Tag.Location = new System.Drawing.Point(6, 20);
            this.label_R2Tag.Name = "label_R2Tag";
            this.label_R2Tag.Size = new System.Drawing.Size(26, 13);
            this.label_R2Tag.TabIndex = 5;
            this.label_R2Tag.Text = "Tag";
            // 
            // label_R3SR
            // 
            this.label_R3SR.AutoSize = true;
            this.label_R3SR.Location = new System.Drawing.Point(6, 91);
            this.label_R3SR.Name = "label_R3SR";
            this.label_R3SR.Size = new System.Drawing.Size(81, 13);
            this.label_R3SR.TabIndex = 9;
            this.label_R3SR.Text = "Sound Reading";
            // 
            // label_R3LR
            // 
            this.label_R3LR.AutoSize = true;
            this.label_R3LR.Location = new System.Drawing.Point(6, 74);
            this.label_R3LR.Name = "label_R3LR";
            this.label_R3LR.Size = new System.Drawing.Size(73, 13);
            this.label_R3LR.TabIndex = 8;
            this.label_R3LR.Text = "Light Reading";
            // 
            // label_R3Ypos
            // 
            this.label_R3Ypos.AutoSize = true;
            this.label_R3Ypos.Location = new System.Drawing.Point(6, 57);
            this.label_R3Ypos.Name = "label_R3Ypos";
            this.label_R3Ypos.Size = new System.Drawing.Size(54, 13);
            this.label_R3Ypos.TabIndex = 7;
            this.label_R3Ypos.Text = "Y Position";
            // 
            // label_R3XPos
            // 
            this.label_R3XPos.AutoSize = true;
            this.label_R3XPos.Location = new System.Drawing.Point(6, 37);
            this.label_R3XPos.Name = "label_R3XPos";
            this.label_R3XPos.Size = new System.Drawing.Size(54, 13);
            this.label_R3XPos.TabIndex = 6;
            this.label_R3XPos.Text = "X Position";
            // 
            // label_R3Tag
            // 
            this.label_R3Tag.AutoSize = true;
            this.label_R3Tag.Location = new System.Drawing.Point(6, 20);
            this.label_R3Tag.Name = "label_R3Tag";
            this.label_R3Tag.Size = new System.Drawing.Size(26, 13);
            this.label_R3Tag.TabIndex = 5;
            this.label_R3Tag.Text = "Tag";
            // 
            // label_R1TagData
            // 
            this.label_R1TagData.AutoSize = true;
            this.label_R1TagData.Location = new System.Drawing.Point(97, 20);
            this.label_R1TagData.Name = "label_R1TagData";
            this.label_R1TagData.Size = new System.Drawing.Size(13, 13);
            this.label_R1TagData.TabIndex = 6;
            this.label_R1TagData.Text = "0";
            // 
            // label_R1XPosData
            // 
            this.label_R1XPosData.AutoSize = true;
            this.label_R1XPosData.Location = new System.Drawing.Point(97, 37);
            this.label_R1XPosData.Name = "label_R1XPosData";
            this.label_R1XPosData.Size = new System.Drawing.Size(13, 13);
            this.label_R1XPosData.TabIndex = 7;
            this.label_R1XPosData.Text = "0";
            // 
            // label_R1YPosData
            // 
            this.label_R1YPosData.AutoSize = true;
            this.label_R1YPosData.Location = new System.Drawing.Point(97, 57);
            this.label_R1YPosData.Name = "label_R1YPosData";
            this.label_R1YPosData.Size = new System.Drawing.Size(13, 13);
            this.label_R1YPosData.TabIndex = 8;
            this.label_R1YPosData.Text = "0";
            // 
            // label_R1LRData
            // 
            this.label_R1LRData.AutoSize = true;
            this.label_R1LRData.Location = new System.Drawing.Point(97, 74);
            this.label_R1LRData.Name = "label_R1LRData";
            this.label_R1LRData.Size = new System.Drawing.Size(13, 13);
            this.label_R1LRData.TabIndex = 9;
            this.label_R1LRData.Text = "0";
            // 
            // label_R1SRData
            // 
            this.label_R1SRData.AutoSize = true;
            this.label_R1SRData.Location = new System.Drawing.Point(97, 91);
            this.label_R1SRData.Name = "label_R1SRData";
            this.label_R1SRData.Size = new System.Drawing.Size(13, 13);
            this.label_R1SRData.TabIndex = 10;
            this.label_R1SRData.Text = "0";
            // 
            // label_R2SRData
            // 
            this.label_R2SRData.AutoSize = true;
            this.label_R2SRData.Location = new System.Drawing.Point(97, 91);
            this.label_R2SRData.Name = "label_R2SRData";
            this.label_R2SRData.Size = new System.Drawing.Size(13, 13);
            this.label_R2SRData.TabIndex = 15;
            this.label_R2SRData.Text = "0";
            // 
            // label_R2LRData
            // 
            this.label_R2LRData.AutoSize = true;
            this.label_R2LRData.Location = new System.Drawing.Point(97, 74);
            this.label_R2LRData.Name = "label_R2LRData";
            this.label_R2LRData.Size = new System.Drawing.Size(13, 13);
            this.label_R2LRData.TabIndex = 14;
            this.label_R2LRData.Text = "0";
            // 
            // label_R2YPosData
            // 
            this.label_R2YPosData.AutoSize = true;
            this.label_R2YPosData.Location = new System.Drawing.Point(97, 57);
            this.label_R2YPosData.Name = "label_R2YPosData";
            this.label_R2YPosData.Size = new System.Drawing.Size(13, 13);
            this.label_R2YPosData.TabIndex = 13;
            this.label_R2YPosData.Text = "0";
            // 
            // label_R2XPosData
            // 
            this.label_R2XPosData.AutoSize = true;
            this.label_R2XPosData.Location = new System.Drawing.Point(97, 37);
            this.label_R2XPosData.Name = "label_R2XPosData";
            this.label_R2XPosData.Size = new System.Drawing.Size(13, 13);
            this.label_R2XPosData.TabIndex = 12;
            this.label_R2XPosData.Text = "0";
            // 
            // label_R2TagData
            // 
            this.label_R2TagData.AutoSize = true;
            this.label_R2TagData.Location = new System.Drawing.Point(97, 20);
            this.label_R2TagData.Name = "label_R2TagData";
            this.label_R2TagData.Size = new System.Drawing.Size(13, 13);
            this.label_R2TagData.TabIndex = 11;
            this.label_R2TagData.Text = "0";
            // 
            // label_R3SRData
            // 
            this.label_R3SRData.AutoSize = true;
            this.label_R3SRData.Location = new System.Drawing.Point(94, 91);
            this.label_R3SRData.Name = "label_R3SRData";
            this.label_R3SRData.Size = new System.Drawing.Size(13, 13);
            this.label_R3SRData.TabIndex = 15;
            this.label_R3SRData.Text = "0";
            // 
            // label_R3LRData
            // 
            this.label_R3LRData.AutoSize = true;
            this.label_R3LRData.Location = new System.Drawing.Point(94, 74);
            this.label_R3LRData.Name = "label_R3LRData";
            this.label_R3LRData.Size = new System.Drawing.Size(13, 13);
            this.label_R3LRData.TabIndex = 14;
            this.label_R3LRData.Text = "0";
            // 
            // label_R3YPosData
            // 
            this.label_R3YPosData.AutoSize = true;
            this.label_R3YPosData.Location = new System.Drawing.Point(94, 57);
            this.label_R3YPosData.Name = "label_R3YPosData";
            this.label_R3YPosData.Size = new System.Drawing.Size(13, 13);
            this.label_R3YPosData.TabIndex = 13;
            this.label_R3YPosData.Text = "0";
            // 
            // label_R3XPosData
            // 
            this.label_R3XPosData.AutoSize = true;
            this.label_R3XPosData.Location = new System.Drawing.Point(94, 37);
            this.label_R3XPosData.Name = "label_R3XPosData";
            this.label_R3XPosData.Size = new System.Drawing.Size(13, 13);
            this.label_R3XPosData.TabIndex = 12;
            this.label_R3XPosData.Text = "0";
            // 
            // label_R3TagData
            // 
            this.label_R3TagData.AutoSize = true;
            this.label_R3TagData.Location = new System.Drawing.Point(94, 20);
            this.label_R3TagData.Name = "label_R3TagData";
            this.label_R3TagData.Size = new System.Drawing.Size(13, 13);
            this.label_R3TagData.TabIndex = 11;
            this.label_R3TagData.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 452);
            this.Controls.Add(this.pictureBox_Status);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.tabControl_Interface);
            this.Controls.Add(this.button_Disconnect);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.groupBox_Options);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Author);
            this.Name = "Form1";
            this.Text = "PC Control and Monitoring Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Options.ResumeLayout(false);
            this.groupBox_Options.PerformLayout();
            this.tabControl_Interface.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox_Hex.ResumeLayout(false);
            this.groupBox_Hex.PerformLayout();
            this.groupBox_String.ResumeLayout(false);
            this.groupBox_String.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox_Robot3.ResumeLayout(false);
            this.groupBox_Robot3.PerformLayout();
            this.groupBox_Robot2.ResumeLayout(false);
            this.groupBox_Robot2.PerformLayout();
            this.groupBox_Robot1.ResumeLayout(false);
            this.groupBox_Robot1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Status)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Options;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.ComboBox comboBox_Stop;
        private System.Windows.Forms.ComboBox comboBox_Parity;
        private System.Windows.Forms.ComboBox comboBox_Flow;
        private System.Windows.Forms.ComboBox comboBox_Data;
        private System.Windows.Forms.ComboBox comboBox_Baud;
        private System.Windows.Forms.ComboBox comboBox_Port;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.Label label_Data;
        private System.Windows.Forms.Label label_Stop;
        private System.Windows.Forms.Label label_Parity;
        private System.Windows.Forms.Label label_Flow;
        private System.Windows.Forms.Label label_Baud;
        private System.Windows.Forms.TabControl tabControl_Interface;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox_RawComms;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.PictureBox pictureBox_Status;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Query;
        private System.Windows.Forms.TextBox textBox_Send;
        private System.Windows.Forms.Label label_Send;
        private System.Windows.Forms.GroupBox groupBox_Hex;
        private System.Windows.Forms.TextBox textBox_SendHex;
        private System.Windows.Forms.GroupBox groupBox_String;
        private System.Windows.Forms.CheckBox checkBox_Hex;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button_Log;
        private System.Windows.Forms.GroupBox groupBox_Robot3;
        private System.Windows.Forms.GroupBox groupBox_Robot2;
        private System.Windows.Forms.GroupBox groupBox_Robot1;
        private System.Windows.Forms.Label label_RawRecieved;
        private System.Windows.Forms.Label label_R3SRData;
        private System.Windows.Forms.Label label_R3LRData;
        private System.Windows.Forms.Label label_R3YPosData;
        private System.Windows.Forms.Label label_R3XPosData;
        private System.Windows.Forms.Label label_R3TagData;
        private System.Windows.Forms.Label label_R3SR;
        private System.Windows.Forms.Label label_R3LR;
        private System.Windows.Forms.Label label_R3Ypos;
        private System.Windows.Forms.Label label_R3XPos;
        private System.Windows.Forms.Label label_R3Tag;
        private System.Windows.Forms.Label label_R2SRData;
        private System.Windows.Forms.Label label_R2LRData;
        private System.Windows.Forms.Label label_R2YPosData;
        private System.Windows.Forms.Label label_R2XPosData;
        private System.Windows.Forms.Label label_R2TagData;
        private System.Windows.Forms.Label label_R2SR;
        private System.Windows.Forms.Label label_R2LR;
        private System.Windows.Forms.Label label_R2YPos;
        private System.Windows.Forms.Label label_R2XPos;
        private System.Windows.Forms.Label label_R2Tag;
        private System.Windows.Forms.Label label_R1SRData;
        private System.Windows.Forms.Label label_R1LRData;
        private System.Windows.Forms.Label label_R1YPosData;
        private System.Windows.Forms.Label label_R1XPosData;
        private System.Windows.Forms.Label label_R1TagData;
        private System.Windows.Forms.Label label_R1SR;
        private System.Windows.Forms.Label label_R1LR;
        private System.Windows.Forms.Label label_R1YPos;
        private System.Windows.Forms.Label label_R1XPos;
        private System.Windows.Forms.Label label_R1Tag;
    }
}

