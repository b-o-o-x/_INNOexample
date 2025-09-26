namespace INNOexample
{
    partial class Form_INNO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_INNO));
            this.btnInnoStaticMethod = new _INNO._UI.InnoButton();
            this.sc = new System.Windows.Forms.SplitContainer();
            this.btnInnoExtensions = new _INNO._UI.InnoButton();
            this.lbLog = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInnoStaticMethod
            // 
            this.btnInnoStaticMethod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnInnoStaticMethod.BackColor_Checked = System.Drawing.Color.DodgerBlue;
            this.btnInnoStaticMethod.BackColor_Normal = System.Drawing.Color.WhiteSmoke;
            this.btnInnoStaticMethod.BorderColor_Checked = System.Drawing.Color.PowderBlue;
            this.btnInnoStaticMethod.BorderColor_Normal = System.Drawing.Color.Silver;
            this.btnInnoStaticMethod.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnInnoStaticMethod.Checked = false;
            this.btnInnoStaticMethod.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnInnoStaticMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInnoStaticMethod.ForeColor = System.Drawing.Color.Black;
            this.btnInnoStaticMethod.ForeColor_Checked = System.Drawing.Color.WhiteSmoke;
            this.btnInnoStaticMethod.ForeColor_Normal = System.Drawing.Color.Black;
            this.btnInnoStaticMethod.Location = new System.Drawing.Point(15, 18);
            this.btnInnoStaticMethod.Name = "btnInnoStaticMethod";
            this.btnInnoStaticMethod.Size = new System.Drawing.Size(158, 44);
            this.btnInnoStaticMethod.TabIndex = 0;
            this.btnInnoStaticMethod.Text = "_INNO.Inno 정적 메소드";
            this.btnInnoStaticMethod.UseVisualStyleBackColor = false;
            this.btnInnoStaticMethod.Click += new System.EventHandler(this.btnInnoStaticMethod_Click);
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
            this.sc.Panel1.Controls.Add(this.btnInnoExtensions);
            this.sc.Panel1.Controls.Add(this.btnInnoStaticMethod);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sc.Panel2.Controls.Add(this.lbLog);
            this.sc.Size = new System.Drawing.Size(776, 576);
            this.sc.SplitterDistance = 407;
            this.sc.TabIndex = 20;
            // 
            // btnInnoExtensions
            // 
            this.btnInnoExtensions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnInnoExtensions.BackColor_Checked = System.Drawing.Color.DodgerBlue;
            this.btnInnoExtensions.BackColor_Normal = System.Drawing.Color.WhiteSmoke;
            this.btnInnoExtensions.BorderColor_Checked = System.Drawing.Color.PowderBlue;
            this.btnInnoExtensions.BorderColor_Normal = System.Drawing.Color.Silver;
            this.btnInnoExtensions.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnInnoExtensions.Checked = false;
            this.btnInnoExtensions.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnInnoExtensions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInnoExtensions.ForeColor = System.Drawing.Color.Black;
            this.btnInnoExtensions.ForeColor_Checked = System.Drawing.Color.WhiteSmoke;
            this.btnInnoExtensions.ForeColor_Normal = System.Drawing.Color.Black;
            this.btnInnoExtensions.Location = new System.Drawing.Point(179, 18);
            this.btnInnoExtensions.Name = "btnInnoExtensions";
            this.btnInnoExtensions.Size = new System.Drawing.Size(158, 44);
            this.btnInnoExtensions.TabIndex = 0;
            this.btnInnoExtensions.Text = "_INNO.Inno 확장 메소드";
            this.btnInnoExtensions.UseVisualStyleBackColor = false;
            this.btnInnoExtensions.Click += new System.EventHandler(this.btnInnoExtensions_Click);
            // 
            // lbLog
            // 
            this.lbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 12;
            this.lbLog.Location = new System.Drawing.Point(0, 0);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(776, 160);
            this.lbLog.TabIndex = 16;
            // 
            // Form_INNO
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.sc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_INNO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private _INNO._UI.InnoButton btnInnoStaticMethod;
        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.ListBox lbLog;
        private _INNO._UI.InnoButton btnInnoExtensions;
    }
}