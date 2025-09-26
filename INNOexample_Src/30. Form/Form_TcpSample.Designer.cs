namespace INNOexample
{
    partial class Form_TcpSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TcpSample));
            this.txtClientMessage = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.txtServerMessage = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.btnClear = new _INNO._UI.InnoModernButtonRound();
            this.btnClientStart = new _INNO._UI.InnoModernButtonRound();
            this.btnClientSend = new _INNO._UI.InnoModernButtonRound();
            this.btnServerSend = new _INNO._UI.InnoModernButtonRound();
            this.btnServerStart = new _INNO._UI.InnoModernButtonRound();
            this.txtLog = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.innoUIGroupBoxBorder1 = new _INNO._UI.InnoGroupBoxBorder();
            this.btnServerSendAuto = new _INNO._UI.InnoModernButtonRound();
            this.innoUIGroupBoxBorder2 = new _INNO._UI.InnoGroupBoxBorder();
            this.btnClientSendAuto = new _INNO._UI.InnoModernButtonRound();
            this.innoUIGroupBoxBorder3 = new _INNO._UI.InnoGroupBoxBorder();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.innoUIGroupBoxBorder1.SuspendLayout();
            this.innoUIGroupBoxBorder2.SuspendLayout();
            this.innoUIGroupBoxBorder3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtClientMessage
            // 
            this.txtClientMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientMessage.BackColor = System.Drawing.SystemColors.Window;
            this.txtClientMessage.BorderColor_Normal = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtClientMessage.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtClientMessage.BorderRadius = 7;
            this.txtClientMessage.BorderSize = 2;
            this.txtClientMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientMessage.Location = new System.Drawing.Point(94, 20);
            this.txtClientMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientMessage.Multiline = false;
            this.txtClientMessage.Name = "txtClientMessage";
            this.txtClientMessage.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtClientMessage.PasswordChar = false;
            this.txtClientMessage.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtClientMessage.PlaceholderText = "";
            this.txtClientMessage.ReadOnly = false;
            this.txtClientMessage.Size = new System.Drawing.Size(525, 31);
            this.txtClientMessage.TabIndex = 25;
            this.txtClientMessage.Text = "Hi~ Server. I am a Client. Very good today.";
            this.txtClientMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClientMessage.UnderlinedStyle = false;
            this.txtClientMessage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtClientMessage_KeyUp);
            // 
            // txtServerMessage
            // 
            this.txtServerMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerMessage.BackColor = System.Drawing.SystemColors.Window;
            this.txtServerMessage.BorderColor_Normal = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtServerMessage.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtServerMessage.BorderRadius = 7;
            this.txtServerMessage.BorderSize = 2;
            this.txtServerMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtServerMessage.Location = new System.Drawing.Point(94, 20);
            this.txtServerMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtServerMessage.Multiline = false;
            this.txtServerMessage.Name = "txtServerMessage";
            this.txtServerMessage.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtServerMessage.PasswordChar = false;
            this.txtServerMessage.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtServerMessage.PlaceholderText = "";
            this.txtServerMessage.ReadOnly = false;
            this.txtServerMessage.Size = new System.Drawing.Size(525, 31);
            this.txtServerMessage.TabIndex = 26;
            this.txtServerMessage.Text = "Hi, Client. I\'m Server. How are you today?";
            this.txtServerMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtServerMessage.UnderlinedStyle = false;
            this.txtServerMessage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtServerMessage_KeyUp);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClear.BackColor_Checked = System.Drawing.Color.DodgerBlue;
            this.btnClear.BackColor_Normal = System.Drawing.Color.Gainsboro;
            this.btnClear.BorderColor_Checked = System.Drawing.Color.Turquoise;
            this.btnClear.BorderColor_Normal = System.Drawing.Color.PaleVioletRed;
            this.btnClear.BorderRadius = 0;
            this.btnClear.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnClear.Checked = false;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.ForeColor_Checked = System.Drawing.Color.WhiteSmoke;
            this.btnClear.ForeColor_Normal = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(620, 459);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 40);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClientStart
            // 
            this.btnClientStart.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClientStart.BackColor_Checked = System.Drawing.Color.DodgerBlue;
            this.btnClientStart.BackColor_Normal = System.Drawing.Color.Gainsboro;
            this.btnClientStart.BorderColor_Checked = System.Drawing.Color.Turquoise;
            this.btnClientStart.BorderColor_Normal = System.Drawing.Color.PaleVioletRed;
            this.btnClientStart.BorderRadius = 0;
            this.btnClientStart.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnClientStart.Checked = false;
            this.btnClientStart.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClientStart.FlatAppearance.BorderSize = 0;
            this.btnClientStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientStart.ForeColor = System.Drawing.Color.Black;
            this.btnClientStart.ForeColor_Checked = System.Drawing.Color.WhiteSmoke;
            this.btnClientStart.ForeColor_Normal = System.Drawing.Color.Black;
            this.btnClientStart.Location = new System.Drawing.Point(16, 20);
            this.btnClientStart.Name = "btnClientStart";
            this.btnClientStart.Size = new System.Drawing.Size(71, 30);
            this.btnClientStart.TabIndex = 17;
            this.btnClientStart.Text = "Start";
            this.btnClientStart.UseVisualStyleBackColor = false;
            this.btnClientStart.Click += new System.EventHandler(this.btnClientStart_Click);
            // 
            // btnClientSend
            // 
            this.btnClientSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientSend.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClientSend.BackColor_Checked = System.Drawing.Color.DodgerBlue;
            this.btnClientSend.BackColor_Normal = System.Drawing.Color.Gainsboro;
            this.btnClientSend.BorderColor_Checked = System.Drawing.Color.Turquoise;
            this.btnClientSend.BorderColor_Normal = System.Drawing.Color.PaleVioletRed;
            this.btnClientSend.BorderRadius = 0;
            this.btnClientSend.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnClientSend.Checked = false;
            this.btnClientSend.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClientSend.FlatAppearance.BorderSize = 0;
            this.btnClientSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientSend.ForeColor = System.Drawing.Color.Black;
            this.btnClientSend.ForeColor_Checked = System.Drawing.Color.WhiteSmoke;
            this.btnClientSend.ForeColor_Normal = System.Drawing.Color.Black;
            this.btnClientSend.Location = new System.Drawing.Point(626, 20);
            this.btnClientSend.Name = "btnClientSend";
            this.btnClientSend.Size = new System.Drawing.Size(50, 30);
            this.btnClientSend.TabIndex = 21;
            this.btnClientSend.Text = "Send";
            this.btnClientSend.UseVisualStyleBackColor = false;
            this.btnClientSend.Click += new System.EventHandler(this.btnClientSend_Click);
            // 
            // btnServerSend
            // 
            this.btnServerSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServerSend.BackColor = System.Drawing.Color.Gainsboro;
            this.btnServerSend.BackColor_Checked = System.Drawing.Color.DodgerBlue;
            this.btnServerSend.BackColor_Normal = System.Drawing.Color.Gainsboro;
            this.btnServerSend.BorderColor_Checked = System.Drawing.Color.Turquoise;
            this.btnServerSend.BorderColor_Normal = System.Drawing.Color.PaleVioletRed;
            this.btnServerSend.BorderRadius = 0;
            this.btnServerSend.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnServerSend.Checked = false;
            this.btnServerSend.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnServerSend.FlatAppearance.BorderSize = 0;
            this.btnServerSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServerSend.ForeColor = System.Drawing.Color.Black;
            this.btnServerSend.ForeColor_Checked = System.Drawing.Color.WhiteSmoke;
            this.btnServerSend.ForeColor_Normal = System.Drawing.Color.Black;
            this.btnServerSend.Location = new System.Drawing.Point(626, 20);
            this.btnServerSend.Name = "btnServerSend";
            this.btnServerSend.Size = new System.Drawing.Size(50, 30);
            this.btnServerSend.TabIndex = 22;
            this.btnServerSend.Text = "Send";
            this.btnServerSend.UseVisualStyleBackColor = false;
            this.btnServerSend.Click += new System.EventHandler(this.btnServerSend_Click);
            // 
            // btnServerStart
            // 
            this.btnServerStart.BackColor = System.Drawing.Color.Gainsboro;
            this.btnServerStart.BackColor_Checked = System.Drawing.Color.DodgerBlue;
            this.btnServerStart.BackColor_Normal = System.Drawing.Color.Gainsboro;
            this.btnServerStart.BorderColor_Checked = System.Drawing.Color.Turquoise;
            this.btnServerStart.BorderColor_Normal = System.Drawing.Color.PaleVioletRed;
            this.btnServerStart.BorderRadius = 0;
            this.btnServerStart.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnServerStart.Checked = false;
            this.btnServerStart.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnServerStart.FlatAppearance.BorderSize = 0;
            this.btnServerStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServerStart.ForeColor = System.Drawing.Color.Black;
            this.btnServerStart.ForeColor_Checked = System.Drawing.Color.WhiteSmoke;
            this.btnServerStart.ForeColor_Normal = System.Drawing.Color.Black;
            this.btnServerStart.Location = new System.Drawing.Point(15, 20);
            this.btnServerStart.Name = "btnServerStart";
            this.btnServerStart.Size = new System.Drawing.Size(72, 30);
            this.btnServerStart.TabIndex = 24;
            this.btnServerStart.Text = "Start";
            this.btnServerStart.UseVisualStyleBackColor = false;
            this.btnServerStart.Click += new System.EventHandler(this.btnServerStart_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.AutoScroll = true;
            this.txtLog.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtLog.BorderColor_Normal = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(11)))));
            this.txtLog.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtLog.BorderRadius = 7;
            this.txtLog.BorderSize = 2;
            this.txtLog.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.Color.White;
            this.txtLog.Location = new System.Drawing.Point(8, 209);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLog.PasswordChar = false;
            this.txtLog.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLog.PlaceholderText = "";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(748, 243);
            this.txtLog.TabIndex = 27;
            this.txtLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLog.UnderlinedStyle = false;
            // 
            // innoUIGroupBoxBorder1
            // 
            this.innoUIGroupBoxBorder1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.innoUIGroupBoxBorder1.BorderColor_Normal = System.Drawing.Color.White;
            this.innoUIGroupBoxBorder1.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.innoUIGroupBoxBorder1.BorderWidth = 2;
            this.innoUIGroupBoxBorder1.Controls.Add(this.btnServerStart);
            this.innoUIGroupBoxBorder1.Controls.Add(this.txtServerMessage);
            this.innoUIGroupBoxBorder1.Controls.Add(this.btnServerSendAuto);
            this.innoUIGroupBoxBorder1.Controls.Add(this.btnServerSend);
            this.innoUIGroupBoxBorder1.ForeColor = System.Drawing.Color.White;
            this.innoUIGroupBoxBorder1.Location = new System.Drawing.Point(8, 63);
            this.innoUIGroupBoxBorder1.Name = "innoUIGroupBoxBorder1";
            this.innoUIGroupBoxBorder1.Size = new System.Drawing.Size(748, 65);
            this.innoUIGroupBoxBorder1.TabIndex = 28;
            this.innoUIGroupBoxBorder1.TabStop = false;
            this.innoUIGroupBoxBorder1.Text = "TCP Server";
            // 
            // btnServerSendAuto
            // 
            this.btnServerSendAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServerSendAuto.BackColor = System.Drawing.Color.Gainsboro;
            this.btnServerSendAuto.BackColor_Checked = System.Drawing.Color.DodgerBlue;
            this.btnServerSendAuto.BackColor_Normal = System.Drawing.Color.Gainsboro;
            this.btnServerSendAuto.BorderColor_Checked = System.Drawing.Color.Turquoise;
            this.btnServerSendAuto.BorderColor_Normal = System.Drawing.Color.PaleVioletRed;
            this.btnServerSendAuto.BorderRadius = 0;
            this.btnServerSendAuto.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnServerSendAuto.Checked = false;
            this.btnServerSendAuto.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnServerSendAuto.FlatAppearance.BorderSize = 0;
            this.btnServerSendAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServerSendAuto.ForeColor = System.Drawing.Color.Black;
            this.btnServerSendAuto.ForeColor_Checked = System.Drawing.Color.WhiteSmoke;
            this.btnServerSendAuto.ForeColor_Normal = System.Drawing.Color.Black;
            this.btnServerSendAuto.Location = new System.Drawing.Point(682, 20);
            this.btnServerSendAuto.Name = "btnServerSendAuto";
            this.btnServerSendAuto.Size = new System.Drawing.Size(50, 30);
            this.btnServerSendAuto.TabIndex = 22;
            this.btnServerSendAuto.Text = "Auto";
            this.btnServerSendAuto.UseVisualStyleBackColor = false;
            this.btnServerSendAuto.Click += new System.EventHandler(this.btnServerSendAuto_Click);
            // 
            // innoUIGroupBoxBorder2
            // 
            this.innoUIGroupBoxBorder2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.innoUIGroupBoxBorder2.BorderColor_Normal = System.Drawing.Color.White;
            this.innoUIGroupBoxBorder2.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.innoUIGroupBoxBorder2.BorderWidth = 2;
            this.innoUIGroupBoxBorder2.Controls.Add(this.btnClientStart);
            this.innoUIGroupBoxBorder2.Controls.Add(this.txtClientMessage);
            this.innoUIGroupBoxBorder2.Controls.Add(this.btnClientSendAuto);
            this.innoUIGroupBoxBorder2.Controls.Add(this.btnClientSend);
            this.innoUIGroupBoxBorder2.ForeColor = System.Drawing.Color.White;
            this.innoUIGroupBoxBorder2.Location = new System.Drawing.Point(8, 134);
            this.innoUIGroupBoxBorder2.Name = "innoUIGroupBoxBorder2";
            this.innoUIGroupBoxBorder2.Size = new System.Drawing.Size(748, 65);
            this.innoUIGroupBoxBorder2.TabIndex = 28;
            this.innoUIGroupBoxBorder2.TabStop = false;
            this.innoUIGroupBoxBorder2.Text = "TCP Client";
            // 
            // btnClientSendAuto
            // 
            this.btnClientSendAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientSendAuto.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClientSendAuto.BackColor_Checked = System.Drawing.Color.DodgerBlue;
            this.btnClientSendAuto.BackColor_Normal = System.Drawing.Color.Gainsboro;
            this.btnClientSendAuto.BorderColor_Checked = System.Drawing.Color.Turquoise;
            this.btnClientSendAuto.BorderColor_Normal = System.Drawing.Color.PaleVioletRed;
            this.btnClientSendAuto.BorderRadius = 0;
            this.btnClientSendAuto.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnClientSendAuto.Checked = false;
            this.btnClientSendAuto.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClientSendAuto.FlatAppearance.BorderSize = 0;
            this.btnClientSendAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientSendAuto.ForeColor = System.Drawing.Color.Black;
            this.btnClientSendAuto.ForeColor_Checked = System.Drawing.Color.WhiteSmoke;
            this.btnClientSendAuto.ForeColor_Normal = System.Drawing.Color.Black;
            this.btnClientSendAuto.Location = new System.Drawing.Point(682, 20);
            this.btnClientSendAuto.Name = "btnClientSendAuto";
            this.btnClientSendAuto.Size = new System.Drawing.Size(50, 30);
            this.btnClientSendAuto.TabIndex = 21;
            this.btnClientSendAuto.Text = "Auto";
            this.btnClientSendAuto.UseVisualStyleBackColor = false;
            this.btnClientSendAuto.Click += new System.EventHandler(this.btnClientSendAuto_Click);
            // 
            // innoUIGroupBoxBorder3
            // 
            this.innoUIGroupBoxBorder3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.innoUIGroupBoxBorder3.BorderColor_Normal = System.Drawing.Color.White;
            this.innoUIGroupBoxBorder3.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.innoUIGroupBoxBorder3.BorderWidth = 2;
            this.innoUIGroupBoxBorder3.Controls.Add(this.label2);
            this.innoUIGroupBoxBorder3.Controls.Add(this.txtPort);
            this.innoUIGroupBoxBorder3.Controls.Add(this.label1);
            this.innoUIGroupBoxBorder3.Controls.Add(this.txtIP);
            this.innoUIGroupBoxBorder3.ForeColor = System.Drawing.Color.White;
            this.innoUIGroupBoxBorder3.Location = new System.Drawing.Point(8, 3);
            this.innoUIGroupBoxBorder3.Name = "innoUIGroupBoxBorder3";
            this.innoUIGroupBoxBorder3.Size = new System.Drawing.Size(748, 54);
            this.innoUIGroupBoxBorder3.TabIndex = 28;
            this.innoUIGroupBoxBorder3.TabStop = false;
            this.innoUIGroupBoxBorder3.Text = "TCP Config";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(204, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 30);
            this.label2.TabIndex = 27;
            this.label2.Text = "Port";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.SystemColors.Window;
            this.txtPort.BorderColor_Normal = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtPort.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPort.BorderRadius = 7;
            this.txtPort.BorderSize = 2;
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPort.Location = new System.Drawing.Point(262, 16);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Multiline = false;
            this.txtPort.Name = "txtPort";
            this.txtPort.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPort.PasswordChar = false;
            this.txtPort.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPort.PlaceholderText = "";
            this.txtPort.ReadOnly = false;
            this.txtPort.Size = new System.Drawing.Size(64, 31);
            this.txtPort.TabIndex = 26;
            this.txtPort.Text = "3030";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPort.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 30);
            this.label1.TabIndex = 27;
            this.label1.Text = "IP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.SystemColors.Window;
            this.txtIP.BorderColor_Normal = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtIP.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIP.BorderRadius = 7;
            this.txtIP.BorderSize = 2;
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIP.Location = new System.Drawing.Point(71, 16);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtIP.Multiline = false;
            this.txtIP.Name = "txtIP";
            this.txtIP.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtIP.PasswordChar = false;
            this.txtIP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIP.PlaceholderText = "";
            this.txtIP.ReadOnly = false;
            this.txtIP.Size = new System.Drawing.Size(126, 31);
            this.txtIP.TabIndex = 26;
            this.txtIP.Text = "127.0.0.1";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIP.UnderlinedStyle = false;
            // 
            // Form_TcpSample
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(768, 511);
            this.Controls.Add(this.innoUIGroupBoxBorder2);
            this.Controls.Add(this.innoUIGroupBoxBorder3);
            this.Controls.Add(this.innoUIGroupBoxBorder1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_TcpSample";
            this.Text = "TcpTester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_TcpTester_FormClosing);
            this.Load += new System.EventHandler(this.Form_3_Load);
            this.innoUIGroupBoxBorder1.ResumeLayout(false);
            this.innoUIGroupBoxBorder2.ResumeLayout(false);
            this.innoUIGroupBoxBorder3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private _INNO._UI.InnoTextBoxColoredPlaceholder txtClientMessage;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtServerMessage;
        private _INNO._UI.InnoModernButtonRound btnClear;
        private _INNO._UI.InnoModernButtonRound btnClientStart;
        private _INNO._UI.InnoModernButtonRound btnClientSend;
        private _INNO._UI.InnoModernButtonRound btnServerSend;
        private _INNO._UI.InnoModernButtonRound btnServerStart;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtLog;
        private _INNO._UI.InnoGroupBoxBorder innoUIGroupBoxBorder1;
        private _INNO._UI.InnoGroupBoxBorder innoUIGroupBoxBorder2;
        private _INNO._UI.InnoGroupBoxBorder innoUIGroupBoxBorder3;
        private System.Windows.Forms.Label label2;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtPort;
        private System.Windows.Forms.Label label1;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtIP;
        private _INNO._UI.InnoModernButtonRound btnServerSendAuto;
        private _INNO._UI.InnoModernButtonRound btnClientSendAuto;
    }
}