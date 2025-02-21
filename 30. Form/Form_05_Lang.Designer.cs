namespace INNOexample
{
    partial class Form_05_Lang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_05_Lang));
            this.groupLang = new _INNO._UI.InnoGroupBoxBorder();
            this.btnLangEn = new _INNO._UI.InnoButton();
            this.btnLangDefault = new _INNO._UI.InnoButton();
            this.sc = new System.Windows.Forms.SplitContainer();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.groupLang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupLang
            // 
            this.groupLang.BorderColor = System.Drawing.Color.Black;
            this.groupLang.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.groupLang.BorderWidth = 2;
            this.groupLang.Controls.Add(this.btnLangEn);
            this.groupLang.Controls.Add(this.btnLangDefault);
            this.groupLang.Location = new System.Drawing.Point(3, 3);
            this.groupLang.Name = "groupLang";
            this.groupLang.Size = new System.Drawing.Size(164, 137);
            this.groupLang.TabIndex = 0;
            this.groupLang.TabStop = false;
            this.groupLang.Text = "Multi-Language Setting";
            // 
            // btnLangEn
            // 
            this.btnLangEn.BackColor = System.Drawing.Color.White;
            this.btnLangEn.ButtonType = _INNO._UI.InnoButton.ButtonTypes.RadioButton;
            this.btnLangEn.Checked = false;
            this.btnLangEn.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnLangEn.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLangEn.ForeColor = System.Drawing.Color.Black;
            this.btnLangEn.Location = new System.Drawing.Point(25, 76);
            this.btnLangEn.Name = "btnLangEn";
            this.btnLangEn.NormalBackColor = System.Drawing.Color.White;
            this.btnLangEn.NormalForeColor = System.Drawing.Color.Black;
            this.btnLangEn.Size = new System.Drawing.Size(110, 40);
            this.btnLangEn.TabIndex = 0;
            this.btnLangEn.Text = "en (English)";
            this.btnLangEn.UseVisualStyleBackColor = false;
            this.btnLangEn.Click += new System.EventHandler(this.btnLangEn_Click);
            // 
            // btnLangDefault
            // 
            this.btnLangDefault.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLangDefault.ButtonType = _INNO._UI.InnoButton.ButtonTypes.RadioButton;
            this.btnLangDefault.Checked = true;
            this.btnLangDefault.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnLangDefault.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLangDefault.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLangDefault.Location = new System.Drawing.Point(25, 30);
            this.btnLangDefault.Name = "btnLangDefault";
            this.btnLangDefault.NormalBackColor = System.Drawing.Color.White;
            this.btnLangDefault.NormalForeColor = System.Drawing.Color.Black;
            this.btnLangDefault.Size = new System.Drawing.Size(110, 40);
            this.btnLangDefault.TabIndex = 0;
            this.btnLangDefault.Text = "default (Korean)";
            this.btnLangDefault.UseVisualStyleBackColor = false;
            this.btnLangDefault.Click += new System.EventHandler(this.btnLangDefault_Click);
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
            this.sc.Panel1.Controls.Add(this.groupLang);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sc.Panel2.Controls.Add(this.lbLog);
            this.sc.Size = new System.Drawing.Size(776, 576);
            this.sc.SplitterDistance = 407;
            this.sc.TabIndex = 18;
            // 
            // lbLog
            // 
            this.lbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLog.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 15;
            this.lbLog.Location = new System.Drawing.Point(0, 0);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(776, 154);
            this.lbLog.TabIndex = 16;
            // 
            // Form_05_Lang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.sc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_05_Lang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupLang.ResumeLayout(false);
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private _INNO._UI.InnoGroupBoxBorder groupLang;
        private _INNO._UI.InnoButton btnLangEn;
        private _INNO._UI.InnoButton btnLangDefault;
        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.ListBox lbLog;
    }
}