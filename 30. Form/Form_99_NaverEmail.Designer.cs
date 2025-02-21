namespace INNOexample
{
    partial class Form_99_NaverEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_99_NaverEmail));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTo = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.btnSend = new _INNO._UI.InnoButtonColored();
            this.lbAttachments = new System.Windows.Forms.ListBox();
            this.txtCc = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBcc = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubject = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBody = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.innoUIButtonColored1 = new _INNO._UI.InnoButtonColored();
            this.txtFromName = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFrom = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNaverPassword = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.label7 = new System.Windows.Forms.Label();
            this.txtToName = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "받는사람";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTo
            // 
            this.txtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTo.BackColor = System.Drawing.SystemColors.Window;
            this.txtTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTo.BorderRadius = 7;
            this.txtTo.BorderSize = 2;
            this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTo.Location = new System.Drawing.Point(110, 9);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTo.Multiline = false;
            this.txtTo.Name = "txtTo";
            this.txtTo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTo.PasswordChar = false;
            this.txtTo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTo.PlaceholderText = "";
            this.txtTo.ReadOnly = false;
            this.txtTo.Size = new System.Drawing.Size(393, 31);
            this.txtTo.TabIndex = 16;
            this.txtTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTo.UnderlinedStyle = false;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSend.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSend.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSend.BorderRadius = 0;
            this.btnSend.BorderSize = 0;
            this.btnSend.CheckBoxType = false;
            this.btnSend.Checked = false;
            this.btnSend.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSend.CheckedBorderColor = System.Drawing.Color.Turquoise;
            this.btnSend.CheckedForeColor = System.Drawing.Color.White;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(651, 557);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(136, 31);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "SEND";
            this.btnSend.TextColor = System.Drawing.Color.White;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbAttachments
            // 
            this.lbAttachments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAttachments.FormattingEnabled = true;
            this.lbAttachments.ItemHeight = 12;
            this.lbAttachments.Location = new System.Drawing.Point(12, 142);
            this.lbAttachments.Name = "lbAttachments";
            this.lbAttachments.Size = new System.Drawing.Size(633, 112);
            this.lbAttachments.TabIndex = 18;
            // 
            // txtCc
            // 
            this.txtCc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCc.BackColor = System.Drawing.SystemColors.Window;
            this.txtCc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtCc.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCc.BorderRadius = 7;
            this.txtCc.BorderSize = 2;
            this.txtCc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCc.Location = new System.Drawing.Point(110, 42);
            this.txtCc.Margin = new System.Windows.Forms.Padding(4);
            this.txtCc.Multiline = false;
            this.txtCc.Name = "txtCc";
            this.txtCc.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCc.PasswordChar = false;
            this.txtCc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCc.PlaceholderText = "";
            this.txtCc.ReadOnly = false;
            this.txtCc.Size = new System.Drawing.Size(677, 31);
            this.txtCc.TabIndex = 16;
            this.txtCc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCc.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "참조";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBcc
            // 
            this.txtBcc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBcc.BackColor = System.Drawing.SystemColors.Window;
            this.txtBcc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtBcc.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBcc.BorderRadius = 7;
            this.txtBcc.BorderSize = 2;
            this.txtBcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBcc.Location = new System.Drawing.Point(110, 75);
            this.txtBcc.Margin = new System.Windows.Forms.Padding(4);
            this.txtBcc.Multiline = false;
            this.txtBcc.Name = "txtBcc";
            this.txtBcc.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBcc.PasswordChar = false;
            this.txtBcc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBcc.PlaceholderText = "";
            this.txtBcc.ReadOnly = false;
            this.txtBcc.Size = new System.Drawing.Size(677, 31);
            this.txtBcc.TabIndex = 16;
            this.txtBcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBcc.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "숨은참조";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubject.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubject.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtSubject.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSubject.BorderRadius = 7;
            this.txtSubject.BorderSize = 2;
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubject.Location = new System.Drawing.Point(110, 108);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubject.Multiline = false;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSubject.PasswordChar = false;
            this.txtSubject.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSubject.PlaceholderText = "";
            this.txtSubject.ReadOnly = false;
            this.txtSubject.Size = new System.Drawing.Size(677, 31);
            this.txtSubject.TabIndex = 16;
            this.txtSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSubject.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "제목";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBody
            // 
            this.txtBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBody.BackColor = System.Drawing.SystemColors.Window;
            this.txtBody.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtBody.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBody.BorderRadius = 7;
            this.txtBody.BorderSize = 2;
            this.txtBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBody.Location = new System.Drawing.Point(13, 296);
            this.txtBody.Margin = new System.Windows.Forms.Padding(4);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBody.PasswordChar = false;
            this.txtBody.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBody.PlaceholderText = "";
            this.txtBody.ReadOnly = false;
            this.txtBody.Size = new System.Drawing.Size(775, 253);
            this.txtBody.TabIndex = 16;
            this.txtBody.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBody.UnderlinedStyle = false;
            // 
            // innoUIButtonColored1
            // 
            this.innoUIButtonColored1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.innoUIButtonColored1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.innoUIButtonColored1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.innoUIButtonColored1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.innoUIButtonColored1.BorderRadius = 0;
            this.innoUIButtonColored1.BorderSize = 0;
            this.innoUIButtonColored1.CheckBoxType = false;
            this.innoUIButtonColored1.Checked = false;
            this.innoUIButtonColored1.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.innoUIButtonColored1.CheckedBorderColor = System.Drawing.Color.Turquoise;
            this.innoUIButtonColored1.CheckedForeColor = System.Drawing.Color.White;
            this.innoUIButtonColored1.FlatAppearance.BorderSize = 0;
            this.innoUIButtonColored1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.innoUIButtonColored1.ForeColor = System.Drawing.Color.White;
            this.innoUIButtonColored1.Location = new System.Drawing.Point(651, 142);
            this.innoUIButtonColored1.Name = "innoUIButtonColored1";
            this.innoUIButtonColored1.Size = new System.Drawing.Size(136, 32);
            this.innoUIButtonColored1.TabIndex = 15;
            this.innoUIButtonColored1.Text = "파일 첨부 ...";
            this.innoUIButtonColored1.TextColor = System.Drawing.Color.White;
            this.innoUIButtonColored1.UseVisualStyleBackColor = false;
            this.innoUIButtonColored1.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtFromName
            // 
            this.txtFromName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFromName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFromName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtFromName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtFromName.BorderRadius = 7;
            this.txtFromName.BorderSize = 2;
            this.txtFromName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFromName.Location = new System.Drawing.Point(608, 261);
            this.txtFromName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFromName.Multiline = false;
            this.txtFromName.Name = "txtFromName";
            this.txtFromName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFromName.PasswordChar = false;
            this.txtFromName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFromName.PlaceholderText = "";
            this.txtFromName.ReadOnly = false;
            this.txtFromName.Size = new System.Drawing.Size(179, 31);
            this.txtFromName.TabIndex = 16;
            this.txtFromName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFromName.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(510, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 31);
            this.label5.TabIndex = 17;
            this.label5.Text = "보내는 이름";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFrom
            // 
            this.txtFrom.BackColor = System.Drawing.SystemColors.Window;
            this.txtFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtFrom.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtFrom.BorderRadius = 7;
            this.txtFrom.BorderSize = 2;
            this.txtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFrom.Location = new System.Drawing.Point(110, 261);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrom.Multiline = false;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFrom.PasswordChar = false;
            this.txtFrom.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFrom.PlaceholderText = "";
            this.txtFrom.ReadOnly = false;
            this.txtFrom.Size = new System.Drawing.Size(229, 31);
            this.txtFrom.TabIndex = 16;
            this.txtFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFrom.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "보내는 이메일";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNaverPassword
            // 
            this.txtNaverPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNaverPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtNaverPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtNaverPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNaverPassword.BorderRadius = 7;
            this.txtNaverPassword.BorderSize = 2;
            this.txtNaverPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaverPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNaverPassword.Location = new System.Drawing.Point(110, 557);
            this.txtNaverPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtNaverPassword.Multiline = false;
            this.txtNaverPassword.Name = "txtNaverPassword";
            this.txtNaverPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNaverPassword.PasswordChar = true;
            this.txtNaverPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNaverPassword.PlaceholderText = "";
            this.txtNaverPassword.ReadOnly = false;
            this.txtNaverPassword.Size = new System.Drawing.Size(199, 31);
            this.txtNaverPassword.TabIndex = 16;
            this.txtNaverPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNaverPassword.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 557);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 31);
            this.label7.TabIndex = 17;
            this.label7.Text = "네이버 암호";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtToName
            // 
            this.txtToName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToName.BackColor = System.Drawing.SystemColors.Window;
            this.txtToName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtToName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtToName.BorderRadius = 7;
            this.txtToName.BorderSize = 2;
            this.txtToName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtToName.Location = new System.Drawing.Point(608, 9);
            this.txtToName.Margin = new System.Windows.Forms.Padding(4);
            this.txtToName.Multiline = false;
            this.txtToName.Name = "txtToName";
            this.txtToName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtToName.PasswordChar = false;
            this.txtToName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtToName.PlaceholderText = "";
            this.txtToName.ReadOnly = false;
            this.txtToName.Size = new System.Drawing.Size(179, 31);
            this.txtToName.TabIndex = 16;
            this.txtToName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtToName.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(510, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 31);
            this.label8.TabIndex = 17;
            this.label8.Text = "받는사람 이름";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_99_NaverEmail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lbAttachments);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBcc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNaverPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtToName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFromName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.innoUIButtonColored1);
            this.Controls.Add(this.btnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_99_NaverEmail";
            this.Load += new System.EventHandler(this.Form_02_NaverEmail_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtTo;
        private _INNO._UI.InnoButtonColored btnSend;
        private System.Windows.Forms.ListBox lbAttachments;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtCc;
        private System.Windows.Forms.Label label2;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtBcc;
        private System.Windows.Forms.Label label3;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtSubject;
        private System.Windows.Forms.Label label4;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtBody;
        private _INNO._UI.InnoButtonColored innoUIButtonColored1;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtFromName;
        private System.Windows.Forms.Label label5;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtFrom;
        private System.Windows.Forms.Label label6;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtNaverPassword;
        private System.Windows.Forms.Label label7;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtToName;
        private System.Windows.Forms.Label label8;
    }
}