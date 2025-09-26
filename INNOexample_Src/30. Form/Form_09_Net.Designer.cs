namespace INNOexample
{
    partial class Form_09_Net
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_09_Net));
            this.sc = new System.Windows.Forms.SplitContainer();
            this.btn_InnoNet = new _INNO._UI.InnoButton();
            this.btnInnoTcpTester = new _INNO._UI.InnoButton();
            this.lbLog = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            this.SuspendLayout();
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
            this.sc.Panel1.Controls.Add(this.btn_InnoNet);
            this.sc.Panel1.Controls.Add(this.btnInnoTcpTester);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sc.Panel2.Controls.Add(this.lbLog);
            this.sc.Size = new System.Drawing.Size(776, 576);
            this.sc.SplitterDistance = 407;
            this.sc.TabIndex = 19;
            // 
            // btn_InnoNet
            // 
            this.btn_InnoNet.BackColor = System.Drawing.Color.White;
            this.btn_InnoNet.BackColor_Checked = System.Drawing.Color.DodgerBlue;
            this.btn_InnoNet.BackColor_Normal = System.Drawing.Color.White;
            this.btn_InnoNet.BorderColor_Checked = System.Drawing.Color.PowderBlue;
            this.btn_InnoNet.BorderColor_Normal = System.Drawing.Color.IndianRed;
            this.btn_InnoNet.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btn_InnoNet.Checked = false;
            this.btn_InnoNet.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_InnoNet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InnoNet.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_InnoNet.ForeColor_Checked = System.Drawing.Color.WhiteSmoke;
            this.btn_InnoNet.ForeColor_Normal = System.Drawing.Color.IndianRed;
            this.btn_InnoNet.Location = new System.Drawing.Point(3, 3);
            this.btn_InnoNet.Name = "btn_InnoNet";
            this.btn_InnoNet.Size = new System.Drawing.Size(110, 40);
            this.btn_InnoNet.TabIndex = 5;
            this.btn_InnoNet.Text = "_InnoNet";
            this.btn_InnoNet.UseVisualStyleBackColor = false;
            this.btn_InnoNet.Click += new System.EventHandler(this.btn_InnoNet_Click);
            // 
            // btnInnoTcpTester
            // 
            this.btnInnoTcpTester.BackColor = System.Drawing.Color.White;
            this.btnInnoTcpTester.BackColor_Checked = System.Drawing.Color.DodgerBlue;
            this.btnInnoTcpTester.BackColor_Normal = System.Drawing.Color.White;
            this.btnInnoTcpTester.BorderColor_Checked = System.Drawing.Color.PowderBlue;
            this.btnInnoTcpTester.BorderColor_Normal = System.Drawing.Color.Silver;
            this.btnInnoTcpTester.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnInnoTcpTester.Checked = false;
            this.btnInnoTcpTester.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnInnoTcpTester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInnoTcpTester.ForeColor = System.Drawing.Color.Black;
            this.btnInnoTcpTester.ForeColor_Checked = System.Drawing.Color.WhiteSmoke;
            this.btnInnoTcpTester.ForeColor_Normal = System.Drawing.Color.Black;
            this.btnInnoTcpTester.Location = new System.Drawing.Point(3, 76);
            this.btnInnoTcpTester.Name = "btnInnoTcpTester";
            this.btnInnoTcpTester.Size = new System.Drawing.Size(110, 40);
            this.btnInnoTcpTester.TabIndex = 4;
            this.btnInnoTcpTester.Text = "InnoTcpTester";
            this.btnInnoTcpTester.UseVisualStyleBackColor = false;
            this.btnInnoTcpTester.Click += new System.EventHandler(this.btnInnoTcpTester_Click);
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
            // Form_09_Net
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.sc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_09_Net";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.ListBox lbLog;
        private _INNO._UI.InnoButton btnInnoTcpTester;
        private _INNO._UI.InnoButton btn_InnoNet;
    }
}