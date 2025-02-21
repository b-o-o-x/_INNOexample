namespace INNOexample
{
    partial class Form_99_VATCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_99_VATCalculator));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.innoGroupBoxBorder2 = new _INNO._UI.InnoGroupBoxBorder();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTaxAmount = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.btnVAT_Calc1 = new _INNO._UI.InnoButtonColored();
            this.txtValueOfSupply = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.txtTotalAmount = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.btnClear = new _INNO._UI.InnoButtonColored();
            this.innoGroupBoxBorder1 = new _INNO._UI.InnoGroupBoxBorder();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTaxAmount2 = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.btnVAT_Calc2 = new _INNO._UI.InnoButtonColored();
            this.txtValueOfSupply2 = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.txtTotalAmount2 = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.innoGroupBoxBorder3 = new _INNO._UI.InnoGroupBoxBorder();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtResidentTax = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.btnBusinessIncome_Calc1 = new _INNO._UI.InnoButtonColored();
            this.txtPayment = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.txtIncomeTax = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.txtBusinessIncome = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.innoGroupBoxBorder4 = new _INNO._UI.InnoGroupBoxBorder();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtResidentTax2 = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.btnBusinessIncome_Calc2 = new _INNO._UI.InnoButtonColored();
            this.txtPayment2 = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.txtIncomeTax2 = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.txtBusinessIncome2 = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.innoGroupBoxBorder2.SuspendLayout();
            this.innoGroupBoxBorder1.SuspendLayout();
            this.innoGroupBoxBorder3.SuspendLayout();
            this.innoGroupBoxBorder4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(10, 450);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(639, 132);
            this.listBox1.TabIndex = 13;
            // 
            // innoGroupBoxBorder2
            // 
            this.innoGroupBoxBorder2.BorderColor = System.Drawing.Color.Black;
            this.innoGroupBoxBorder2.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.innoGroupBoxBorder2.BorderWidth = 2;
            this.innoGroupBoxBorder2.Controls.Add(this.label2);
            this.innoGroupBoxBorder2.Controls.Add(this.label1);
            this.innoGroupBoxBorder2.Controls.Add(this.label5);
            this.innoGroupBoxBorder2.Controls.Add(this.txtTaxAmount);
            this.innoGroupBoxBorder2.Controls.Add(this.btnVAT_Calc1);
            this.innoGroupBoxBorder2.Controls.Add(this.txtValueOfSupply);
            this.innoGroupBoxBorder2.Controls.Add(this.txtTotalAmount);
            this.innoGroupBoxBorder2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.innoGroupBoxBorder2.Location = new System.Drawing.Point(12, 12);
            this.innoGroupBoxBorder2.Name = "innoGroupBoxBorder2";
            this.innoGroupBoxBorder2.Size = new System.Drawing.Size(355, 162);
            this.innoGroupBoxBorder2.TabIndex = 16;
            this.innoGroupBoxBorder2.TabStop = false;
            this.innoGroupBoxBorder2.Text = "부가세 (합계금액으로 계산)";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "세액(Tax amount)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "공급가액(Value of supply)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "합계금액(Total amount)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTaxAmount
            // 
            this.txtTaxAmount.BackColor = System.Drawing.SystemColors.Window;
            this.txtTaxAmount.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.txtTaxAmount.BorderFocusColor = System.Drawing.Color.Black;
            this.txtTaxAmount.BorderRadius = 7;
            this.txtTaxAmount.BorderSize = 2;
            this.txtTaxAmount.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTaxAmount.Location = new System.Drawing.Point(183, 108);
            this.txtTaxAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaxAmount.Multiline = false;
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTaxAmount.PasswordChar = false;
            this.txtTaxAmount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTaxAmount.PlaceholderText = "";
            this.txtTaxAmount.ReadOnly = true;
            this.txtTaxAmount.Size = new System.Drawing.Size(153, 34);
            this.txtTaxAmount.TabIndex = 14;
            this.txtTaxAmount.Text = "90,909";
            this.txtTaxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTaxAmount.UnderlinedStyle = false;
            // 
            // btnVAT_Calc1
            // 
            this.btnVAT_Calc1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnVAT_Calc1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnVAT_Calc1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVAT_Calc1.BorderRadius = 0;
            this.btnVAT_Calc1.BorderSize = 0;
            this.btnVAT_Calc1.CheckBoxType = false;
            this.btnVAT_Calc1.Checked = false;
            this.btnVAT_Calc1.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnVAT_Calc1.CheckedBorderColor = System.Drawing.Color.Turquoise;
            this.btnVAT_Calc1.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVAT_Calc1.FlatAppearance.BorderSize = 0;
            this.btnVAT_Calc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVAT_Calc1.ForeColor = System.Drawing.Color.White;
            this.btnVAT_Calc1.Location = new System.Drawing.Point(183, 42);
            this.btnVAT_Calc1.Name = "btnVAT_Calc1";
            this.btnVAT_Calc1.Size = new System.Drawing.Size(153, 31);
            this.btnVAT_Calc1.TabIndex = 14;
            this.btnVAT_Calc1.Text = "계산하기";
            this.btnVAT_Calc1.TextColor = System.Drawing.Color.White;
            this.btnVAT_Calc1.UseVisualStyleBackColor = false;
            this.btnVAT_Calc1.Click += new System.EventHandler(this.btnVAT_Calc1_Click);
            // 
            // txtValueOfSupply
            // 
            this.txtValueOfSupply.BackColor = System.Drawing.SystemColors.Window;
            this.txtValueOfSupply.BorderColor = System.Drawing.Color.Red;
            this.txtValueOfSupply.BorderFocusColor = System.Drawing.Color.Black;
            this.txtValueOfSupply.BorderRadius = 7;
            this.txtValueOfSupply.BorderSize = 2;
            this.txtValueOfSupply.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValueOfSupply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValueOfSupply.Location = new System.Drawing.Point(19, 108);
            this.txtValueOfSupply.Margin = new System.Windows.Forms.Padding(4);
            this.txtValueOfSupply.Multiline = false;
            this.txtValueOfSupply.Name = "txtValueOfSupply";
            this.txtValueOfSupply.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtValueOfSupply.PasswordChar = false;
            this.txtValueOfSupply.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtValueOfSupply.PlaceholderText = "";
            this.txtValueOfSupply.ReadOnly = true;
            this.txtValueOfSupply.Size = new System.Drawing.Size(153, 34);
            this.txtValueOfSupply.TabIndex = 14;
            this.txtValueOfSupply.Text = "909,091";
            this.txtValueOfSupply.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValueOfSupply.UnderlinedStyle = false;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalAmount.BorderColor = System.Drawing.Color.Lime;
            this.txtTotalAmount.BorderFocusColor = System.Drawing.Color.Black;
            this.txtTotalAmount.BorderRadius = 7;
            this.txtTotalAmount.BorderSize = 2;
            this.txtTotalAmount.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalAmount.Location = new System.Drawing.Point(19, 42);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalAmount.Multiline = false;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTotalAmount.PasswordChar = false;
            this.txtTotalAmount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTotalAmount.PlaceholderText = "";
            this.txtTotalAmount.ReadOnly = false;
            this.txtTotalAmount.Size = new System.Drawing.Size(153, 34);
            this.txtTotalAmount.TabIndex = 14;
            this.txtTotalAmount.Text = "1,000,000";
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalAmount.UnderlinedStyle = false;
            this.txtTotalAmount._TextChanged += new System.EventHandler(this.txt__TextChanged);
            this.txtTotalAmount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTotalAmount_MouseDown);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClear.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClear.BorderRadius = 0;
            this.btnClear.BorderSize = 0;
            this.btnClear.CheckBoxType = false;
            this.btnClear.Checked = false;
            this.btnClear.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.CheckedBorderColor = System.Drawing.Color.Turquoise;
            this.btnClear.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(655, 542);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 40);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "CLEAR";
            this.btnClear.TextColor = System.Drawing.Color.White;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // innoGroupBoxBorder1
            // 
            this.innoGroupBoxBorder1.BorderColor = System.Drawing.Color.Black;
            this.innoGroupBoxBorder1.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.innoGroupBoxBorder1.BorderWidth = 2;
            this.innoGroupBoxBorder1.Controls.Add(this.label3);
            this.innoGroupBoxBorder1.Controls.Add(this.label4);
            this.innoGroupBoxBorder1.Controls.Add(this.label6);
            this.innoGroupBoxBorder1.Controls.Add(this.txtTaxAmount2);
            this.innoGroupBoxBorder1.Controls.Add(this.btnVAT_Calc2);
            this.innoGroupBoxBorder1.Controls.Add(this.txtValueOfSupply2);
            this.innoGroupBoxBorder1.Controls.Add(this.txtTotalAmount2);
            this.innoGroupBoxBorder1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.innoGroupBoxBorder1.Location = new System.Drawing.Point(385, 12);
            this.innoGroupBoxBorder1.Name = "innoGroupBoxBorder1";
            this.innoGroupBoxBorder1.Size = new System.Drawing.Size(355, 162);
            this.innoGroupBoxBorder1.TabIndex = 16;
            this.innoGroupBoxBorder1.TabStop = false;
            this.innoGroupBoxBorder1.Text = "부가세 (공급가액으로 계산)";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "세액(Tax amount)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "공급가액(Value of supply)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "합계금액(Total amount)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTaxAmount2
            // 
            this.txtTaxAmount2.BackColor = System.Drawing.SystemColors.Window;
            this.txtTaxAmount2.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.txtTaxAmount2.BorderFocusColor = System.Drawing.Color.Black;
            this.txtTaxAmount2.BorderRadius = 7;
            this.txtTaxAmount2.BorderSize = 2;
            this.txtTaxAmount2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxAmount2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTaxAmount2.Location = new System.Drawing.Point(183, 108);
            this.txtTaxAmount2.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaxAmount2.Multiline = false;
            this.txtTaxAmount2.Name = "txtTaxAmount2";
            this.txtTaxAmount2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTaxAmount2.PasswordChar = false;
            this.txtTaxAmount2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTaxAmount2.PlaceholderText = "";
            this.txtTaxAmount2.ReadOnly = true;
            this.txtTaxAmount2.Size = new System.Drawing.Size(153, 34);
            this.txtTaxAmount2.TabIndex = 14;
            this.txtTaxAmount2.Text = "90,909";
            this.txtTaxAmount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTaxAmount2.UnderlinedStyle = false;
            // 
            // btnVAT_Calc2
            // 
            this.btnVAT_Calc2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnVAT_Calc2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnVAT_Calc2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVAT_Calc2.BorderRadius = 0;
            this.btnVAT_Calc2.BorderSize = 0;
            this.btnVAT_Calc2.CheckBoxType = false;
            this.btnVAT_Calc2.Checked = false;
            this.btnVAT_Calc2.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnVAT_Calc2.CheckedBorderColor = System.Drawing.Color.Turquoise;
            this.btnVAT_Calc2.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVAT_Calc2.FlatAppearance.BorderSize = 0;
            this.btnVAT_Calc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVAT_Calc2.ForeColor = System.Drawing.Color.White;
            this.btnVAT_Calc2.Location = new System.Drawing.Point(183, 42);
            this.btnVAT_Calc2.Name = "btnVAT_Calc2";
            this.btnVAT_Calc2.Size = new System.Drawing.Size(153, 31);
            this.btnVAT_Calc2.TabIndex = 14;
            this.btnVAT_Calc2.Text = "계산하기";
            this.btnVAT_Calc2.TextColor = System.Drawing.Color.White;
            this.btnVAT_Calc2.UseVisualStyleBackColor = false;
            this.btnVAT_Calc2.Click += new System.EventHandler(this.btnVAT_Calc2_Click);
            // 
            // txtValueOfSupply2
            // 
            this.txtValueOfSupply2.BackColor = System.Drawing.SystemColors.Window;
            this.txtValueOfSupply2.BorderColor = System.Drawing.Color.Lime;
            this.txtValueOfSupply2.BorderFocusColor = System.Drawing.Color.Black;
            this.txtValueOfSupply2.BorderRadius = 7;
            this.txtValueOfSupply2.BorderSize = 2;
            this.txtValueOfSupply2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValueOfSupply2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValueOfSupply2.Location = new System.Drawing.Point(21, 42);
            this.txtValueOfSupply2.Margin = new System.Windows.Forms.Padding(4);
            this.txtValueOfSupply2.Multiline = false;
            this.txtValueOfSupply2.Name = "txtValueOfSupply2";
            this.txtValueOfSupply2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtValueOfSupply2.PasswordChar = false;
            this.txtValueOfSupply2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtValueOfSupply2.PlaceholderText = "";
            this.txtValueOfSupply2.ReadOnly = false;
            this.txtValueOfSupply2.Size = new System.Drawing.Size(153, 34);
            this.txtValueOfSupply2.TabIndex = 14;
            this.txtValueOfSupply2.Text = "909,091";
            this.txtValueOfSupply2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValueOfSupply2.UnderlinedStyle = false;
            this.txtValueOfSupply2._TextChanged += new System.EventHandler(this.txt__TextChanged);
            // 
            // txtTotalAmount2
            // 
            this.txtTotalAmount2.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalAmount2.BorderColor = System.Drawing.Color.Red;
            this.txtTotalAmount2.BorderFocusColor = System.Drawing.Color.Black;
            this.txtTotalAmount2.BorderRadius = 7;
            this.txtTotalAmount2.BorderSize = 2;
            this.txtTotalAmount2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalAmount2.Location = new System.Drawing.Point(21, 108);
            this.txtTotalAmount2.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalAmount2.Multiline = false;
            this.txtTotalAmount2.Name = "txtTotalAmount2";
            this.txtTotalAmount2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTotalAmount2.PasswordChar = false;
            this.txtTotalAmount2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTotalAmount2.PlaceholderText = "";
            this.txtTotalAmount2.ReadOnly = true;
            this.txtTotalAmount2.Size = new System.Drawing.Size(153, 34);
            this.txtTotalAmount2.TabIndex = 14;
            this.txtTotalAmount2.Text = "1,000,000";
            this.txtTotalAmount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalAmount2.UnderlinedStyle = false;
            this.txtTotalAmount2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTotalAmount_MouseDown);
            // 
            // innoGroupBoxBorder3
            // 
            this.innoGroupBoxBorder3.BorderColor = System.Drawing.Color.Black;
            this.innoGroupBoxBorder3.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.innoGroupBoxBorder3.BorderWidth = 2;
            this.innoGroupBoxBorder3.Controls.Add(this.label7);
            this.innoGroupBoxBorder3.Controls.Add(this.label8);
            this.innoGroupBoxBorder3.Controls.Add(this.label10);
            this.innoGroupBoxBorder3.Controls.Add(this.label9);
            this.innoGroupBoxBorder3.Controls.Add(this.txtResidentTax);
            this.innoGroupBoxBorder3.Controls.Add(this.btnBusinessIncome_Calc1);
            this.innoGroupBoxBorder3.Controls.Add(this.txtPayment);
            this.innoGroupBoxBorder3.Controls.Add(this.txtIncomeTax);
            this.innoGroupBoxBorder3.Controls.Add(this.txtBusinessIncome);
            this.innoGroupBoxBorder3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.innoGroupBoxBorder3.Location = new System.Drawing.Point(12, 193);
            this.innoGroupBoxBorder3.Name = "innoGroupBoxBorder3";
            this.innoGroupBoxBorder3.Size = new System.Drawing.Size(355, 226);
            this.innoGroupBoxBorder3.TabIndex = 16;
            this.innoGroupBoxBorder3.TabStop = false;
            this.innoGroupBoxBorder3.Text = "사업소득에서 3.3% 공제";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(180, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "주민세 (Resident tax 0.3%)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "사업소득세 (Income tax 3.0%)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "지급액 (Payment)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "사업소득(Business income)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtResidentTax
            // 
            this.txtResidentTax.BackColor = System.Drawing.SystemColors.Window;
            this.txtResidentTax.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.txtResidentTax.BorderFocusColor = System.Drawing.Color.Black;
            this.txtResidentTax.BorderRadius = 7;
            this.txtResidentTax.BorderSize = 2;
            this.txtResidentTax.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResidentTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtResidentTax.Location = new System.Drawing.Point(183, 108);
            this.txtResidentTax.Margin = new System.Windows.Forms.Padding(4);
            this.txtResidentTax.Multiline = false;
            this.txtResidentTax.Name = "txtResidentTax";
            this.txtResidentTax.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtResidentTax.PasswordChar = false;
            this.txtResidentTax.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtResidentTax.PlaceholderText = "";
            this.txtResidentTax.ReadOnly = true;
            this.txtResidentTax.Size = new System.Drawing.Size(153, 34);
            this.txtResidentTax.TabIndex = 14;
            this.txtResidentTax.Text = "3,000";
            this.txtResidentTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResidentTax.UnderlinedStyle = false;
            // 
            // btnBusinessIncome_Calc1
            // 
            this.btnBusinessIncome_Calc1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBusinessIncome_Calc1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBusinessIncome_Calc1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBusinessIncome_Calc1.BorderRadius = 0;
            this.btnBusinessIncome_Calc1.BorderSize = 0;
            this.btnBusinessIncome_Calc1.CheckBoxType = false;
            this.btnBusinessIncome_Calc1.Checked = false;
            this.btnBusinessIncome_Calc1.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBusinessIncome_Calc1.CheckedBorderColor = System.Drawing.Color.Turquoise;
            this.btnBusinessIncome_Calc1.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBusinessIncome_Calc1.FlatAppearance.BorderSize = 0;
            this.btnBusinessIncome_Calc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusinessIncome_Calc1.ForeColor = System.Drawing.Color.White;
            this.btnBusinessIncome_Calc1.Location = new System.Drawing.Point(183, 42);
            this.btnBusinessIncome_Calc1.Name = "btnBusinessIncome_Calc1";
            this.btnBusinessIncome_Calc1.Size = new System.Drawing.Size(153, 31);
            this.btnBusinessIncome_Calc1.TabIndex = 14;
            this.btnBusinessIncome_Calc1.Text = "계산하기";
            this.btnBusinessIncome_Calc1.TextColor = System.Drawing.Color.White;
            this.btnBusinessIncome_Calc1.UseVisualStyleBackColor = false;
            this.btnBusinessIncome_Calc1.Click += new System.EventHandler(this.btnBusinessIncome_Calc1_Click);
            // 
            // txtPayment
            // 
            this.txtPayment.BackColor = System.Drawing.SystemColors.Window;
            this.txtPayment.BorderColor = System.Drawing.Color.Red;
            this.txtPayment.BorderFocusColor = System.Drawing.Color.Black;
            this.txtPayment.BorderRadius = 7;
            this.txtPayment.BorderSize = 2;
            this.txtPayment.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPayment.Location = new System.Drawing.Point(19, 178);
            this.txtPayment.Margin = new System.Windows.Forms.Padding(4);
            this.txtPayment.Multiline = false;
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPayment.PasswordChar = false;
            this.txtPayment.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPayment.PlaceholderText = "";
            this.txtPayment.ReadOnly = true;
            this.txtPayment.Size = new System.Drawing.Size(153, 34);
            this.txtPayment.TabIndex = 14;
            this.txtPayment.Text = "967,000";
            this.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPayment.UnderlinedStyle = false;
            this.txtPayment.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTotalAmount_MouseDown);
            // 
            // txtIncomeTax
            // 
            this.txtIncomeTax.BackColor = System.Drawing.SystemColors.Window;
            this.txtIncomeTax.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.txtIncomeTax.BorderFocusColor = System.Drawing.Color.Black;
            this.txtIncomeTax.BorderRadius = 7;
            this.txtIncomeTax.BorderSize = 2;
            this.txtIncomeTax.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncomeTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIncomeTax.Location = new System.Drawing.Point(19, 108);
            this.txtIncomeTax.Margin = new System.Windows.Forms.Padding(4);
            this.txtIncomeTax.Multiline = false;
            this.txtIncomeTax.Name = "txtIncomeTax";
            this.txtIncomeTax.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtIncomeTax.PasswordChar = false;
            this.txtIncomeTax.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIncomeTax.PlaceholderText = "";
            this.txtIncomeTax.ReadOnly = true;
            this.txtIncomeTax.Size = new System.Drawing.Size(153, 34);
            this.txtIncomeTax.TabIndex = 14;
            this.txtIncomeTax.Text = "30,000";
            this.txtIncomeTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIncomeTax.UnderlinedStyle = false;
            // 
            // txtBusinessIncome
            // 
            this.txtBusinessIncome.BackColor = System.Drawing.SystemColors.Window;
            this.txtBusinessIncome.BorderColor = System.Drawing.Color.Lime;
            this.txtBusinessIncome.BorderFocusColor = System.Drawing.Color.Black;
            this.txtBusinessIncome.BorderRadius = 7;
            this.txtBusinessIncome.BorderSize = 2;
            this.txtBusinessIncome.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusinessIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBusinessIncome.Location = new System.Drawing.Point(19, 42);
            this.txtBusinessIncome.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusinessIncome.Multiline = false;
            this.txtBusinessIncome.Name = "txtBusinessIncome";
            this.txtBusinessIncome.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBusinessIncome.PasswordChar = false;
            this.txtBusinessIncome.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBusinessIncome.PlaceholderText = "";
            this.txtBusinessIncome.ReadOnly = false;
            this.txtBusinessIncome.Size = new System.Drawing.Size(153, 34);
            this.txtBusinessIncome.TabIndex = 14;
            this.txtBusinessIncome.Text = "1,000,000";
            this.txtBusinessIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBusinessIncome.UnderlinedStyle = false;
            this.txtBusinessIncome._TextChanged += new System.EventHandler(this.txt__TextChanged);
            this.txtBusinessIncome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTotalAmount_MouseDown);
            // 
            // innoGroupBoxBorder4
            // 
            this.innoGroupBoxBorder4.BorderColor = System.Drawing.Color.Black;
            this.innoGroupBoxBorder4.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.innoGroupBoxBorder4.BorderWidth = 2;
            this.innoGroupBoxBorder4.Controls.Add(this.label11);
            this.innoGroupBoxBorder4.Controls.Add(this.label12);
            this.innoGroupBoxBorder4.Controls.Add(this.label13);
            this.innoGroupBoxBorder4.Controls.Add(this.label14);
            this.innoGroupBoxBorder4.Controls.Add(this.txtResidentTax2);
            this.innoGroupBoxBorder4.Controls.Add(this.btnBusinessIncome_Calc2);
            this.innoGroupBoxBorder4.Controls.Add(this.txtPayment2);
            this.innoGroupBoxBorder4.Controls.Add(this.txtIncomeTax2);
            this.innoGroupBoxBorder4.Controls.Add(this.txtBusinessIncome2);
            this.innoGroupBoxBorder4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.innoGroupBoxBorder4.Location = new System.Drawing.Point(385, 193);
            this.innoGroupBoxBorder4.Name = "innoGroupBoxBorder4";
            this.innoGroupBoxBorder4.Size = new System.Drawing.Size(355, 226);
            this.innoGroupBoxBorder4.TabIndex = 16;
            this.innoGroupBoxBorder4.TabStop = false;
            this.innoGroupBoxBorder4.Text = "지급액으로 3.3% 세금 계산";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(180, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 19);
            this.label11.TabIndex = 5;
            this.label11.Text = "주민세 (Resident tax 0.3%)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 19);
            this.label12.TabIndex = 5;
            this.label12.Text = "사업소득세 (Income tax 3.0%)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 19);
            this.label13.TabIndex = 5;
            this.label13.Text = "지급액 (Payment)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 19);
            this.label14.TabIndex = 5;
            this.label14.Text = "사업소득(Business income)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtResidentTax2
            // 
            this.txtResidentTax2.BackColor = System.Drawing.SystemColors.Window;
            this.txtResidentTax2.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.txtResidentTax2.BorderFocusColor = System.Drawing.Color.Black;
            this.txtResidentTax2.BorderRadius = 7;
            this.txtResidentTax2.BorderSize = 2;
            this.txtResidentTax2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResidentTax2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtResidentTax2.Location = new System.Drawing.Point(183, 108);
            this.txtResidentTax2.Margin = new System.Windows.Forms.Padding(4);
            this.txtResidentTax2.Multiline = false;
            this.txtResidentTax2.Name = "txtResidentTax2";
            this.txtResidentTax2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtResidentTax2.PasswordChar = false;
            this.txtResidentTax2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtResidentTax2.PlaceholderText = "";
            this.txtResidentTax2.ReadOnly = true;
            this.txtResidentTax2.Size = new System.Drawing.Size(153, 34);
            this.txtResidentTax2.TabIndex = 14;
            this.txtResidentTax2.Text = "3,102";
            this.txtResidentTax2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResidentTax2.UnderlinedStyle = false;
            // 
            // btnBusinessIncome_Calc2
            // 
            this.btnBusinessIncome_Calc2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBusinessIncome_Calc2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBusinessIncome_Calc2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBusinessIncome_Calc2.BorderRadius = 0;
            this.btnBusinessIncome_Calc2.BorderSize = 0;
            this.btnBusinessIncome_Calc2.CheckBoxType = false;
            this.btnBusinessIncome_Calc2.Checked = false;
            this.btnBusinessIncome_Calc2.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBusinessIncome_Calc2.CheckedBorderColor = System.Drawing.Color.Turquoise;
            this.btnBusinessIncome_Calc2.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBusinessIncome_Calc2.FlatAppearance.BorderSize = 0;
            this.btnBusinessIncome_Calc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusinessIncome_Calc2.ForeColor = System.Drawing.Color.White;
            this.btnBusinessIncome_Calc2.Location = new System.Drawing.Point(183, 42);
            this.btnBusinessIncome_Calc2.Name = "btnBusinessIncome_Calc2";
            this.btnBusinessIncome_Calc2.Size = new System.Drawing.Size(153, 31);
            this.btnBusinessIncome_Calc2.TabIndex = 14;
            this.btnBusinessIncome_Calc2.Text = "계산하기";
            this.btnBusinessIncome_Calc2.TextColor = System.Drawing.Color.White;
            this.btnBusinessIncome_Calc2.UseVisualStyleBackColor = false;
            this.btnBusinessIncome_Calc2.Click += new System.EventHandler(this.btnBusinessIncome_Calc2_Click);
            // 
            // txtPayment2
            // 
            this.txtPayment2.BackColor = System.Drawing.SystemColors.Window;
            this.txtPayment2.BorderColor = System.Drawing.Color.Lime;
            this.txtPayment2.BorderFocusColor = System.Drawing.Color.Black;
            this.txtPayment2.BorderRadius = 7;
            this.txtPayment2.BorderSize = 2;
            this.txtPayment2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPayment2.Location = new System.Drawing.Point(21, 42);
            this.txtPayment2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPayment2.Multiline = false;
            this.txtPayment2.Name = "txtPayment2";
            this.txtPayment2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPayment2.PasswordChar = false;
            this.txtPayment2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPayment2.PlaceholderText = "";
            this.txtPayment2.ReadOnly = false;
            this.txtPayment2.Size = new System.Drawing.Size(153, 34);
            this.txtPayment2.TabIndex = 14;
            this.txtPayment2.Text = "1,000,000";
            this.txtPayment2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPayment2.UnderlinedStyle = false;
            this.txtPayment2._TextChanged += new System.EventHandler(this.txt__TextChanged);
            this.txtPayment2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTotalAmount_MouseDown);
            // 
            // txtIncomeTax2
            // 
            this.txtIncomeTax2.BackColor = System.Drawing.SystemColors.Window;
            this.txtIncomeTax2.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.txtIncomeTax2.BorderFocusColor = System.Drawing.Color.Black;
            this.txtIncomeTax2.BorderRadius = 7;
            this.txtIncomeTax2.BorderSize = 2;
            this.txtIncomeTax2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncomeTax2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIncomeTax2.Location = new System.Drawing.Point(19, 108);
            this.txtIncomeTax2.Margin = new System.Windows.Forms.Padding(4);
            this.txtIncomeTax2.Multiline = false;
            this.txtIncomeTax2.Name = "txtIncomeTax2";
            this.txtIncomeTax2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtIncomeTax2.PasswordChar = false;
            this.txtIncomeTax2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIncomeTax2.PlaceholderText = "";
            this.txtIncomeTax2.ReadOnly = true;
            this.txtIncomeTax2.Size = new System.Drawing.Size(153, 34);
            this.txtIncomeTax2.TabIndex = 14;
            this.txtIncomeTax2.Text = "31,024";
            this.txtIncomeTax2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIncomeTax2.UnderlinedStyle = false;
            // 
            // txtBusinessIncome2
            // 
            this.txtBusinessIncome2.BackColor = System.Drawing.SystemColors.Window;
            this.txtBusinessIncome2.BorderColor = System.Drawing.Color.Red;
            this.txtBusinessIncome2.BorderFocusColor = System.Drawing.Color.Black;
            this.txtBusinessIncome2.BorderRadius = 7;
            this.txtBusinessIncome2.BorderSize = 2;
            this.txtBusinessIncome2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusinessIncome2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBusinessIncome2.Location = new System.Drawing.Point(21, 178);
            this.txtBusinessIncome2.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusinessIncome2.Multiline = false;
            this.txtBusinessIncome2.Name = "txtBusinessIncome2";
            this.txtBusinessIncome2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBusinessIncome2.PasswordChar = false;
            this.txtBusinessIncome2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBusinessIncome2.PlaceholderText = "";
            this.txtBusinessIncome2.ReadOnly = true;
            this.txtBusinessIncome2.Size = new System.Drawing.Size(153, 34);
            this.txtBusinessIncome2.TabIndex = 14;
            this.txtBusinessIncome2.Text = "1,034,126";
            this.txtBusinessIncome2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBusinessIncome2.UnderlinedStyle = false;
            this.txtBusinessIncome2._TextChanged += new System.EventHandler(this.txt__TextChanged);
            this.txtBusinessIncome2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTotalAmount_MouseDown);
            // 
            // Form_99_VATCalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.innoGroupBoxBorder1);
            this.Controls.Add(this.innoGroupBoxBorder4);
            this.Controls.Add(this.innoGroupBoxBorder3);
            this.Controls.Add(this.innoGroupBoxBorder2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_99_VATCalculator";
            this.innoGroupBoxBorder2.ResumeLayout(false);
            this.innoGroupBoxBorder1.ResumeLayout(false);
            this.innoGroupBoxBorder3.ResumeLayout(false);
            this.innoGroupBoxBorder4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private _INNO._UI.InnoButtonColored btnClear;
        private System.Windows.Forms.ListBox listBox1;
        private _INNO._UI.InnoButtonColored btnVAT_Calc1;
        private _INNO._UI.InnoGroupBoxBorder innoGroupBoxBorder2;
        private System.Windows.Forms.Label label5;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtTotalAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtTaxAmount;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtValueOfSupply;
        private _INNO._UI.InnoGroupBoxBorder innoGroupBoxBorder1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtTaxAmount2;
        private _INNO._UI.InnoButtonColored btnVAT_Calc2;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtValueOfSupply2;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtTotalAmount2;
        private _INNO._UI.InnoGroupBoxBorder innoGroupBoxBorder3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtResidentTax;
        private _INNO._UI.InnoButtonColored btnBusinessIncome_Calc1;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtPayment;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtIncomeTax;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtBusinessIncome;
        private _INNO._UI.InnoGroupBoxBorder innoGroupBoxBorder4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtResidentTax2;
        private _INNO._UI.InnoButtonColored btnBusinessIncome_Calc2;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtPayment2;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtIncomeTax2;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtBusinessIncome2;
    }
}