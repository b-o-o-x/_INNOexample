namespace INNOexample
{
    partial class Form_01_Crypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_01_Crypt));
            this.groupMorse = new _INNO._UI.InnoGroupBoxBorder();
            this.txtMorse_DecryptedText = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.txtMorse_PlainText = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.txtMorse_EncryptedText = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.btnMorse_BeepStop = new _INNO._UI.InnoModernButtonRound();
            this.btnMorse_BeepPlay = new _INNO._UI.InnoModernButtonRound();
            this.btnMorse_Encrypt = new _INNO._UI.InnoModernButtonRound();
            this.btnMorse_Decrypt = new _INNO._UI.InnoModernButtonRound();
            this.groupCrypt = new _INNO._UI.InnoGroupBoxBorder();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboCrypt_Type = new System.Windows.Forms.ComboBox();
            this.txtCrypt_DecryptedText = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.txtCrypt_Password = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.txtCrypt_PlainText = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.txtCrypt_EncryptedText = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.btnCrypt_Encrypt = new _INNO._UI.InnoModernButtonRound();
            this.btnCrypt_Decrypt = new _INNO._UI.InnoModernButtonRound();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.sc = new System.Windows.Forms.SplitContainer();
            this.innoGroupBoxBorder1 = new _INNO._UI.InnoGroupBoxBorder();
            this.label3 = new System.Windows.Forms.Label();
            this.comboHash_Type = new System.Windows.Forms.ComboBox();
            this.txtHash_HashText = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.txtHash_PlainText = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.btnHash_Hash = new _INNO._UI.InnoModernButtonRound();
            this.groupMorse.SuspendLayout();
            this.groupCrypt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            this.innoGroupBoxBorder1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMorse
            // 
            this.groupMorse.BorderColor_Normal = System.Drawing.Color.IndianRed;
            this.groupMorse.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.groupMorse.BorderWidth = 2;
            this.groupMorse.Controls.Add(this.txtMorse_DecryptedText);
            this.groupMorse.Controls.Add(this.txtMorse_PlainText);
            this.groupMorse.Controls.Add(this.txtMorse_EncryptedText);
            this.groupMorse.Controls.Add(this.btnMorse_BeepStop);
            this.groupMorse.Controls.Add(this.btnMorse_BeepPlay);
            this.groupMorse.Controls.Add(this.btnMorse_Encrypt);
            this.groupMorse.Controls.Add(this.btnMorse_Decrypt);
            this.groupMorse.ForeColor = System.Drawing.Color.IndianRed;
            this.groupMorse.Location = new System.Drawing.Point(383, 3);
            this.groupMorse.Name = "groupMorse";
            this.groupMorse.Size = new System.Drawing.Size(336, 142);
            this.groupMorse.TabIndex = 15;
            this.groupMorse.TabStop = false;
            this.groupMorse.Text = "모스부호";
            // 
            // txtMorse_DecryptedText
            // 
            this.txtMorse_DecryptedText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMorse_DecryptedText.BackColor = System.Drawing.SystemColors.Window;
            this.txtMorse_DecryptedText.BorderColor_Normal = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtMorse_DecryptedText.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMorse_DecryptedText.BorderRadius = 7;
            this.txtMorse_DecryptedText.BorderSize = 2;
            this.txtMorse_DecryptedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMorse_DecryptedText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMorse_DecryptedText.Location = new System.Drawing.Point(105, 99);
            this.txtMorse_DecryptedText.Margin = new System.Windows.Forms.Padding(4);
            this.txtMorse_DecryptedText.Multiline = false;
            this.txtMorse_DecryptedText.Name = "txtMorse_DecryptedText";
            this.txtMorse_DecryptedText.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMorse_DecryptedText.PasswordChar = false;
            this.txtMorse_DecryptedText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMorse_DecryptedText.PlaceholderText = "복호화된 문자열 표시";
            this.txtMorse_DecryptedText.ReadOnly = false;
            this.txtMorse_DecryptedText.Size = new System.Drawing.Size(221, 31);
            this.txtMorse_DecryptedText.TabIndex = 15;
            this.txtMorse_DecryptedText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMorse_DecryptedText.UnderlinedStyle = false;
            // 
            // txtMorse_PlainText
            // 
            this.txtMorse_PlainText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMorse_PlainText.BackColor = System.Drawing.SystemColors.Window;
            this.txtMorse_PlainText.BorderColor_Normal = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtMorse_PlainText.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMorse_PlainText.BorderRadius = 7;
            this.txtMorse_PlainText.BorderSize = 2;
            this.txtMorse_PlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMorse_PlainText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMorse_PlainText.Location = new System.Drawing.Point(8, 21);
            this.txtMorse_PlainText.Margin = new System.Windows.Forms.Padding(4);
            this.txtMorse_PlainText.Multiline = false;
            this.txtMorse_PlainText.Name = "txtMorse_PlainText";
            this.txtMorse_PlainText.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMorse_PlainText.PasswordChar = false;
            this.txtMorse_PlainText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMorse_PlainText.PlaceholderText = "";
            this.txtMorse_PlainText.ReadOnly = false;
            this.txtMorse_PlainText.Size = new System.Drawing.Size(221, 31);
            this.txtMorse_PlainText.TabIndex = 15;
            this.txtMorse_PlainText.Text = "SOS HELP ME";
            this.txtMorse_PlainText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMorse_PlainText.UnderlinedStyle = false;
            // 
            // txtMorse_EncryptedText
            // 
            this.txtMorse_EncryptedText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMorse_EncryptedText.BackColor = System.Drawing.SystemColors.Window;
            this.txtMorse_EncryptedText.BorderColor_Normal = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtMorse_EncryptedText.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMorse_EncryptedText.BorderRadius = 7;
            this.txtMorse_EncryptedText.BorderSize = 2;
            this.txtMorse_EncryptedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMorse_EncryptedText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMorse_EncryptedText.Location = new System.Drawing.Point(8, 60);
            this.txtMorse_EncryptedText.Margin = new System.Windows.Forms.Padding(4);
            this.txtMorse_EncryptedText.Multiline = false;
            this.txtMorse_EncryptedText.Name = "txtMorse_EncryptedText";
            this.txtMorse_EncryptedText.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMorse_EncryptedText.PasswordChar = false;
            this.txtMorse_EncryptedText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMorse_EncryptedText.PlaceholderText = "모스 문자열";
            this.txtMorse_EncryptedText.ReadOnly = false;
            this.txtMorse_EncryptedText.Size = new System.Drawing.Size(221, 31);
            this.txtMorse_EncryptedText.TabIndex = 15;
            this.txtMorse_EncryptedText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMorse_EncryptedText.UnderlinedStyle = false;
            // 
            // btnMorse_BeepStop
            // 
            this.btnMorse_BeepStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMorse_BeepStop.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMorse_BeepStop.BackColor_Checked = System.Drawing.Color.DodgerBlue;
            this.btnMorse_BeepStop.BackColor_Normal = System.Drawing.Color.DeepSkyBlue;
            this.btnMorse_BeepStop.BorderColor_Checked = System.Drawing.Color.Turquoise;
            this.btnMorse_BeepStop.BorderColor_Normal = System.Drawing.Color.PaleVioletRed;
            this.btnMorse_BeepStop.BorderRadius = 5;
            this.btnMorse_BeepStop.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnMorse_BeepStop.Checked = false;
            this.btnMorse_BeepStop.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMorse_BeepStop.FlatAppearance.BorderSize = 0;
            this.btnMorse_BeepStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMorse_BeepStop.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMorse_BeepStop.ForeColor = System.Drawing.Color.Black;
            this.btnMorse_BeepStop.ForeColor_Checked = System.Drawing.Color.WhiteSmoke;
            this.btnMorse_BeepStop.ForeColor_Normal = System.Drawing.Color.Black;
            this.btnMorse_BeepStop.Location = new System.Drawing.Point(290, 60);
            this.btnMorse_BeepStop.Name = "btnMorse_BeepStop";
            this.btnMorse_BeepStop.Size = new System.Drawing.Size(36, 31);
            this.btnMorse_BeepStop.TabIndex = 14;
            this.btnMorse_BeepStop.Text = "정지";
            this.btnMorse_BeepStop.UseVisualStyleBackColor = false;
            this.btnMorse_BeepStop.Click += new System.EventHandler(this.btnMorse_BeepStop_Click);
            // 
            // btnMorse_BeepPlay
            // 
            this.btnMorse_BeepPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMorse_BeepPlay.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMorse_BeepPlay.BackColor_Checked = System.Drawing.Color.DodgerBlue;
            this.btnMorse_BeepPlay.BackColor_Normal = System.Drawing.Color.DeepSkyBlue;
            this.btnMorse_BeepPlay.BorderColor_Checked = System.Drawing.Color.Turquoise;
            this.btnMorse_BeepPlay.BorderColor_Normal = System.Drawing.Color.PaleVioletRed;
            this.btnMorse_BeepPlay.BorderRadius = 5;
            this.btnMorse_BeepPlay.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnMorse_BeepPlay.Checked = false;
            this.btnMorse_BeepPlay.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMorse_BeepPlay.FlatAppearance.BorderSize = 0;
            this.btnMorse_BeepPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMorse_BeepPlay.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMorse_BeepPlay.ForeColor = System.Drawing.Color.Black;
            this.btnMorse_BeepPlay.ForeColor_Checked = System.Drawing.Color.WhiteSmoke;
            this.btnMorse_BeepPlay.ForeColor_Normal = System.Drawing.Color.Black;
            this.btnMorse_BeepPlay.Location = new System.Drawing.Point(236, 60);
            this.btnMorse_BeepPlay.Name = "btnMorse_BeepPlay";
            this.btnMorse_BeepPlay.Size = new System.Drawing.Size(48, 31);
            this.btnMorse_BeepPlay.TabIndex = 14;
            this.btnMorse_BeepPlay.Text = "비프음 재생";
            this.btnMorse_BeepPlay.UseVisualStyleBackColor = false;
            this.btnMorse_BeepPlay.Click += new System.EventHandler(this.btnMorse_BeepPlay_Click);
            // 
            // btnMorse_Encrypt
            // 
            this.btnMorse_Encrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMorse_Encrypt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMorse_Encrypt.BackColor_Checked = System.Drawing.Color.DodgerBlue;
            this.btnMorse_Encrypt.BackColor_Normal = System.Drawing.Color.DeepSkyBlue;
            this.btnMorse_Encrypt.BorderColor_Checked = System.Drawing.Color.Turquoise;
            this.btnMorse_Encrypt.BorderColor_Normal = System.Drawing.Color.PaleVioletRed;
            this.btnMorse_Encrypt.BorderRadius = 5;
            this.btnMorse_Encrypt.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnMorse_Encrypt.Checked = false;
            this.btnMorse_Encrypt.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMorse_Encrypt.FlatAppearance.BorderSize = 0;
            this.btnMorse_Encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMorse_Encrypt.ForeColor = System.Drawing.Color.Black;
            this.btnMorse_Encrypt.ForeColor_Checked = System.Drawing.Color.WhiteSmoke;
            this.btnMorse_Encrypt.ForeColor_Normal = System.Drawing.Color.Black;
            this.btnMorse_Encrypt.Location = new System.Drawing.Point(236, 20);
            this.btnMorse_Encrypt.Name = "btnMorse_Encrypt";
            this.btnMorse_Encrypt.Size = new System.Drawing.Size(90, 31);
            this.btnMorse_Encrypt.TabIndex = 14;
            this.btnMorse_Encrypt.Text = "암호화 ▼";
            this.btnMorse_Encrypt.UseVisualStyleBackColor = false;
            this.btnMorse_Encrypt.Click += new System.EventHandler(this.btnMorse_Encrypt_Click);
            // 
            // btnMorse_Decrypt
            // 
            this.btnMorse_Decrypt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMorse_Decrypt.BackColor_Checked = System.Drawing.Color.DodgerBlue;
            this.btnMorse_Decrypt.BackColor_Normal = System.Drawing.Color.DeepSkyBlue;
            this.btnMorse_Decrypt.BorderColor_Checked = System.Drawing.Color.Turquoise;
            this.btnMorse_Decrypt.BorderColor_Normal = System.Drawing.Color.PaleVioletRed;
            this.btnMorse_Decrypt.BorderRadius = 5;
            this.btnMorse_Decrypt.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnMorse_Decrypt.Checked = false;
            this.btnMorse_Decrypt.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMorse_Decrypt.FlatAppearance.BorderSize = 0;
            this.btnMorse_Decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMorse_Decrypt.ForeColor = System.Drawing.Color.Black;
            this.btnMorse_Decrypt.ForeColor_Checked = System.Drawing.Color.WhiteSmoke;
            this.btnMorse_Decrypt.ForeColor_Normal = System.Drawing.Color.Black;
            this.btnMorse_Decrypt.Location = new System.Drawing.Point(8, 99);
            this.btnMorse_Decrypt.Name = "btnMorse_Decrypt";
            this.btnMorse_Decrypt.Size = new System.Drawing.Size(90, 31);
            this.btnMorse_Decrypt.TabIndex = 14;
            this.btnMorse_Decrypt.Text = "복호화 ▶";
            this.btnMorse_Decrypt.UseVisualStyleBackColor = false;
            this.btnMorse_Decrypt.Click += new System.EventHandler(this.btnMorse_Decrypt_Click);
            // 
            // groupCrypt
            // 
            this.groupCrypt.BorderColor_Normal = System.Drawing.Color.IndianRed;
            this.groupCrypt.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.groupCrypt.BorderWidth = 2;
            this.groupCrypt.Controls.Add(this.label2);
            this.groupCrypt.Controls.Add(this.label1);
            this.groupCrypt.Controls.Add(this.comboCrypt_Type);
            this.groupCrypt.Controls.Add(this.txtCrypt_DecryptedText);
            this.groupCrypt.Controls.Add(this.txtCrypt_Password);
            this.groupCrypt.Controls.Add(this.txtCrypt_PlainText);
            this.groupCrypt.Controls.Add(this.txtCrypt_EncryptedText);
            this.groupCrypt.Controls.Add(this.btnCrypt_Encrypt);
            this.groupCrypt.Controls.Add(this.btnCrypt_Decrypt);
            this.groupCrypt.ForeColor = System.Drawing.Color.IndianRed;
            this.groupCrypt.Location = new System.Drawing.Point(3, 3);
            this.groupCrypt.Name = "groupCrypt";
            this.groupCrypt.Size = new System.Drawing.Size(374, 210);
            this.groupCrypt.TabIndex = 15;
            this.groupCrypt.TabStop = false;
            this.groupCrypt.Text = "암호화/복호화";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "암호키";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "타입";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboCrypt_Type
            // 
            this.comboCrypt_Type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboCrypt_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCrypt_Type.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboCrypt_Type.FormattingEnabled = true;
            this.comboCrypt_Type.Items.AddRange(new object[] {
            "DES",
            "AES128",
            "AES128(Salt)"});
            this.comboCrypt_Type.Location = new System.Drawing.Point(93, 20);
            this.comboCrypt_Type.Name = "comboCrypt_Type";
            this.comboCrypt_Type.Size = new System.Drawing.Size(270, 27);
            this.comboCrypt_Type.TabIndex = 16;
            // 
            // txtCrypt_DecryptedText
            // 
            this.txtCrypt_DecryptedText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCrypt_DecryptedText.BackColor = System.Drawing.SystemColors.Window;
            this.txtCrypt_DecryptedText.BorderColor_Normal = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtCrypt_DecryptedText.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCrypt_DecryptedText.BorderRadius = 7;
            this.txtCrypt_DecryptedText.BorderSize = 2;
            this.txtCrypt_DecryptedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypt_DecryptedText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCrypt_DecryptedText.Location = new System.Drawing.Point(104, 168);
            this.txtCrypt_DecryptedText.Margin = new System.Windows.Forms.Padding(4);
            this.txtCrypt_DecryptedText.Multiline = false;
            this.txtCrypt_DecryptedText.Name = "txtCrypt_DecryptedText";
            this.txtCrypt_DecryptedText.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCrypt_DecryptedText.PasswordChar = false;
            this.txtCrypt_DecryptedText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCrypt_DecryptedText.PlaceholderText = "복호화된 문자열 표시";
            this.txtCrypt_DecryptedText.ReadOnly = false;
            this.txtCrypt_DecryptedText.Size = new System.Drawing.Size(259, 31);
            this.txtCrypt_DecryptedText.TabIndex = 15;
            this.txtCrypt_DecryptedText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCrypt_DecryptedText.UnderlinedStyle = false;
            // 
            // txtCrypt_Password
            // 
            this.txtCrypt_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCrypt_Password.BackColor = System.Drawing.SystemColors.Window;
            this.txtCrypt_Password.BorderColor_Normal = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtCrypt_Password.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCrypt_Password.BorderRadius = 7;
            this.txtCrypt_Password.BorderSize = 2;
            this.txtCrypt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCrypt_Password.Location = new System.Drawing.Point(93, 54);
            this.txtCrypt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txtCrypt_Password.Multiline = false;
            this.txtCrypt_Password.Name = "txtCrypt_Password";
            this.txtCrypt_Password.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCrypt_Password.PasswordChar = false;
            this.txtCrypt_Password.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCrypt_Password.PlaceholderText = "";
            this.txtCrypt_Password.ReadOnly = false;
            this.txtCrypt_Password.Size = new System.Drawing.Size(270, 31);
            this.txtCrypt_Password.TabIndex = 15;
            this.txtCrypt_Password.Text = "PASS123";
            this.txtCrypt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCrypt_Password.UnderlinedStyle = false;
            // 
            // txtCrypt_PlainText
            // 
            this.txtCrypt_PlainText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCrypt_PlainText.BackColor = System.Drawing.SystemColors.Window;
            this.txtCrypt_PlainText.BorderColor_Normal = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtCrypt_PlainText.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCrypt_PlainText.BorderRadius = 7;
            this.txtCrypt_PlainText.BorderSize = 2;
            this.txtCrypt_PlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypt_PlainText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCrypt_PlainText.Location = new System.Drawing.Point(7, 90);
            this.txtCrypt_PlainText.Margin = new System.Windows.Forms.Padding(4);
            this.txtCrypt_PlainText.Multiline = false;
            this.txtCrypt_PlainText.Name = "txtCrypt_PlainText";
            this.txtCrypt_PlainText.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCrypt_PlainText.PasswordChar = false;
            this.txtCrypt_PlainText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCrypt_PlainText.PlaceholderText = "";
            this.txtCrypt_PlainText.ReadOnly = false;
            this.txtCrypt_PlainText.Size = new System.Drawing.Size(259, 31);
            this.txtCrypt_PlainText.TabIndex = 15;
            this.txtCrypt_PlainText.Text = "Hello, 이노소프트입니다.";
            this.txtCrypt_PlainText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCrypt_PlainText.UnderlinedStyle = false;
            // 
            // txtCrypt_EncryptedText
            // 
            this.txtCrypt_EncryptedText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCrypt_EncryptedText.BackColor = System.Drawing.SystemColors.Window;
            this.txtCrypt_EncryptedText.BorderColor_Normal = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtCrypt_EncryptedText.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCrypt_EncryptedText.BorderRadius = 7;
            this.txtCrypt_EncryptedText.BorderSize = 2;
            this.txtCrypt_EncryptedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrypt_EncryptedText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCrypt_EncryptedText.Location = new System.Drawing.Point(7, 129);
            this.txtCrypt_EncryptedText.Margin = new System.Windows.Forms.Padding(4);
            this.txtCrypt_EncryptedText.Multiline = false;
            this.txtCrypt_EncryptedText.Name = "txtCrypt_EncryptedText";
            this.txtCrypt_EncryptedText.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCrypt_EncryptedText.PasswordChar = false;
            this.txtCrypt_EncryptedText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCrypt_EncryptedText.PlaceholderText = "암호화된 문자열 표시";
            this.txtCrypt_EncryptedText.ReadOnly = false;
            this.txtCrypt_EncryptedText.Size = new System.Drawing.Size(356, 31);
            this.txtCrypt_EncryptedText.TabIndex = 15;
            this.txtCrypt_EncryptedText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCrypt_EncryptedText.UnderlinedStyle = false;
            // 
            // btnCrypt_Encrypt
            // 
            this.btnCrypt_Encrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrypt_Encrypt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCrypt_Encrypt.BackColor_Checked = System.Drawing.Color.DodgerBlue;
            this.btnCrypt_Encrypt.BackColor_Normal = System.Drawing.Color.DeepSkyBlue;
            this.btnCrypt_Encrypt.BorderColor_Checked = System.Drawing.Color.Turquoise;
            this.btnCrypt_Encrypt.BorderColor_Normal = System.Drawing.Color.PaleVioletRed;
            this.btnCrypt_Encrypt.BorderRadius = 5;
            this.btnCrypt_Encrypt.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnCrypt_Encrypt.Checked = false;
            this.btnCrypt_Encrypt.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCrypt_Encrypt.FlatAppearance.BorderSize = 0;
            this.btnCrypt_Encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrypt_Encrypt.ForeColor = System.Drawing.Color.Black;
            this.btnCrypt_Encrypt.ForeColor_Checked = System.Drawing.Color.WhiteSmoke;
            this.btnCrypt_Encrypt.ForeColor_Normal = System.Drawing.Color.Black;
            this.btnCrypt_Encrypt.Location = new System.Drawing.Point(273, 89);
            this.btnCrypt_Encrypt.Name = "btnCrypt_Encrypt";
            this.btnCrypt_Encrypt.Size = new System.Drawing.Size(90, 31);
            this.btnCrypt_Encrypt.TabIndex = 14;
            this.btnCrypt_Encrypt.Text = "암호화 ▼";
            this.btnCrypt_Encrypt.UseVisualStyleBackColor = false;
            this.btnCrypt_Encrypt.Click += new System.EventHandler(this.btnCrypt_Encrypt_Click);
            // 
            // btnCrypt_Decrypt
            // 
            this.btnCrypt_Decrypt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCrypt_Decrypt.BackColor_Checked = System.Drawing.Color.DodgerBlue;
            this.btnCrypt_Decrypt.BackColor_Normal = System.Drawing.Color.DeepSkyBlue;
            this.btnCrypt_Decrypt.BorderColor_Checked = System.Drawing.Color.Turquoise;
            this.btnCrypt_Decrypt.BorderColor_Normal = System.Drawing.Color.PaleVioletRed;
            this.btnCrypt_Decrypt.BorderRadius = 5;
            this.btnCrypt_Decrypt.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnCrypt_Decrypt.Checked = false;
            this.btnCrypt_Decrypt.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCrypt_Decrypt.FlatAppearance.BorderSize = 0;
            this.btnCrypt_Decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrypt_Decrypt.ForeColor = System.Drawing.Color.Black;
            this.btnCrypt_Decrypt.ForeColor_Checked = System.Drawing.Color.WhiteSmoke;
            this.btnCrypt_Decrypt.ForeColor_Normal = System.Drawing.Color.Black;
            this.btnCrypt_Decrypt.Location = new System.Drawing.Point(7, 168);
            this.btnCrypt_Decrypt.Name = "btnCrypt_Decrypt";
            this.btnCrypt_Decrypt.Size = new System.Drawing.Size(90, 31);
            this.btnCrypt_Decrypt.TabIndex = 14;
            this.btnCrypt_Decrypt.Text = "복호화 ▶";
            this.btnCrypt_Decrypt.UseVisualStyleBackColor = false;
            this.btnCrypt_Decrypt.Click += new System.EventHandler(this.btnCrypt_Decrypt_Click);
            // 
            // lbLog
            // 
            this.lbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLog.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 15;
            this.lbLog.Location = new System.Drawing.Point(0, 0);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(776, 154);
            this.lbLog.TabIndex = 16;
            // 
            // sc
            // 
            this.sc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sc.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.sc.Location = new System.Drawing.Point(12, 12);
            this.sc.Name = "sc";
            this.sc.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sc.Panel1.Controls.Add(this.groupCrypt);
            this.sc.Panel1.Controls.Add(this.innoGroupBoxBorder1);
            this.sc.Panel1.Controls.Add(this.groupMorse);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sc.Panel2.Controls.Add(this.lbLog);
            this.sc.Size = new System.Drawing.Size(776, 576);
            this.sc.SplitterDistance = 407;
            this.sc.TabIndex = 17;
            // 
            // innoGroupBoxBorder1
            // 
            this.innoGroupBoxBorder1.BorderColor_Normal = System.Drawing.Color.IndianRed;
            this.innoGroupBoxBorder1.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.innoGroupBoxBorder1.BorderWidth = 2;
            this.innoGroupBoxBorder1.Controls.Add(this.label3);
            this.innoGroupBoxBorder1.Controls.Add(this.comboHash_Type);
            this.innoGroupBoxBorder1.Controls.Add(this.txtHash_HashText);
            this.innoGroupBoxBorder1.Controls.Add(this.txtHash_PlainText);
            this.innoGroupBoxBorder1.Controls.Add(this.btnHash_Hash);
            this.innoGroupBoxBorder1.ForeColor = System.Drawing.Color.IndianRed;
            this.innoGroupBoxBorder1.Location = new System.Drawing.Point(3, 219);
            this.innoGroupBoxBorder1.Name = "innoGroupBoxBorder1";
            this.innoGroupBoxBorder1.Size = new System.Drawing.Size(374, 147);
            this.innoGroupBoxBorder1.TabIndex = 15;
            this.innoGroupBoxBorder1.TabStop = false;
            this.innoGroupBoxBorder1.Text = "해시";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(8, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 27);
            this.label3.TabIndex = 19;
            this.label3.Text = "타입";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboHash_Type
            // 
            this.comboHash_Type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboHash_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHash_Type.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboHash_Type.FormattingEnabled = true;
            this.comboHash_Type.Items.AddRange(new object[] {
            "MD5",
            "SHA256"});
            this.comboHash_Type.Location = new System.Drawing.Point(94, 26);
            this.comboHash_Type.Name = "comboHash_Type";
            this.comboHash_Type.Size = new System.Drawing.Size(270, 27);
            this.comboHash_Type.TabIndex = 18;
            // 
            // txtHash_HashText
            // 
            this.txtHash_HashText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHash_HashText.BackColor = System.Drawing.SystemColors.Window;
            this.txtHash_HashText.BorderColor_Normal = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtHash_HashText.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtHash_HashText.BorderRadius = 7;
            this.txtHash_HashText.BorderSize = 2;
            this.txtHash_HashText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHash_HashText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHash_HashText.Location = new System.Drawing.Point(8, 98);
            this.txtHash_HashText.Margin = new System.Windows.Forms.Padding(4);
            this.txtHash_HashText.Multiline = false;
            this.txtHash_HashText.Name = "txtHash_HashText";
            this.txtHash_HashText.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtHash_HashText.PasswordChar = false;
            this.txtHash_HashText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHash_HashText.PlaceholderText = "해시 문자열";
            this.txtHash_HashText.ReadOnly = false;
            this.txtHash_HashText.Size = new System.Drawing.Size(356, 31);
            this.txtHash_HashText.TabIndex = 15;
            this.txtHash_HashText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHash_HashText.UnderlinedStyle = false;
            // 
            // txtHash_PlainText
            // 
            this.txtHash_PlainText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHash_PlainText.BackColor = System.Drawing.SystemColors.Window;
            this.txtHash_PlainText.BorderColor_Normal = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtHash_PlainText.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtHash_PlainText.BorderRadius = 7;
            this.txtHash_PlainText.BorderSize = 2;
            this.txtHash_PlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHash_PlainText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHash_PlainText.Location = new System.Drawing.Point(8, 60);
            this.txtHash_PlainText.Margin = new System.Windows.Forms.Padding(4);
            this.txtHash_PlainText.Multiline = false;
            this.txtHash_PlainText.Name = "txtHash_PlainText";
            this.txtHash_PlainText.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtHash_PlainText.PasswordChar = false;
            this.txtHash_PlainText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHash_PlainText.PlaceholderText = "";
            this.txtHash_PlainText.ReadOnly = false;
            this.txtHash_PlainText.Size = new System.Drawing.Size(259, 31);
            this.txtHash_PlainText.TabIndex = 15;
            this.txtHash_PlainText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHash_PlainText.UnderlinedStyle = false;
            // 
            // btnHash_Hash
            // 
            this.btnHash_Hash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHash_Hash.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHash_Hash.BackColor_Checked = System.Drawing.Color.DodgerBlue;
            this.btnHash_Hash.BackColor_Normal = System.Drawing.Color.DeepSkyBlue;
            this.btnHash_Hash.BorderColor_Checked = System.Drawing.Color.Turquoise;
            this.btnHash_Hash.BorderColor_Normal = System.Drawing.Color.PaleVioletRed;
            this.btnHash_Hash.BorderRadius = 5;
            this.btnHash_Hash.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnHash_Hash.Checked = false;
            this.btnHash_Hash.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHash_Hash.FlatAppearance.BorderSize = 0;
            this.btnHash_Hash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHash_Hash.ForeColor = System.Drawing.Color.Black;
            this.btnHash_Hash.ForeColor_Checked = System.Drawing.Color.WhiteSmoke;
            this.btnHash_Hash.ForeColor_Normal = System.Drawing.Color.Black;
            this.btnHash_Hash.Location = new System.Drawing.Point(273, 60);
            this.btnHash_Hash.Name = "btnHash_Hash";
            this.btnHash_Hash.Size = new System.Drawing.Size(90, 31);
            this.btnHash_Hash.TabIndex = 14;
            this.btnHash_Hash.Text = "해시 ▼";
            this.btnHash_Hash.UseVisualStyleBackColor = false;
            this.btnHash_Hash.Click += new System.EventHandler(this.btnHash_Hash_Click);
            // 
            // Form_01_Crypt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.sc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_01_Crypt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupMorse.ResumeLayout(false);
            this.groupCrypt.ResumeLayout(false);
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            this.innoGroupBoxBorder1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtCrypt_PlainText;
        private _INNO._UI.InnoModernButtonRound btnCrypt_Encrypt;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtCrypt_EncryptedText;
        private _INNO._UI.InnoModernButtonRound btnCrypt_Decrypt;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtCrypt_DecryptedText;
        private _INNO._UI.InnoGroupBoxBorder groupCrypt;
        private System.Windows.Forms.ComboBox comboCrypt_Type;
        private System.Windows.Forms.Label label1;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtCrypt_Password;
        private System.Windows.Forms.Label label2;
        private _INNO._UI.InnoGroupBoxBorder groupMorse;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtMorse_DecryptedText;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtMorse_PlainText;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtMorse_EncryptedText;
        private _INNO._UI.InnoModernButtonRound btnMorse_BeepPlay;
        private _INNO._UI.InnoModernButtonRound btnMorse_Encrypt;
        private _INNO._UI.InnoModernButtonRound btnMorse_Decrypt;
        private _INNO._UI.InnoModernButtonRound btnMorse_BeepStop;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.SplitContainer sc;
        private _INNO._UI.InnoGroupBoxBorder innoGroupBoxBorder1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboHash_Type;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtHash_HashText;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtHash_PlainText;
        private _INNO._UI.InnoModernButtonRound btnHash_Hash;
    }
}