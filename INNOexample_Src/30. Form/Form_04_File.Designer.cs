namespace INNOexample
{
    partial class Form_04_File
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_04_File));
            this.btnInnoCsv = new _INNO._UI.InnoButton();
            this.btnCustomIni = new _INNO._UI.InnoButton();
            this.btnInnoIni_Pro = new _INNO._UI.InnoButton();
            this.btnInnoIni = new _INNO._UI.InnoButton();
            this.sc = new System.Windows.Forms.SplitContainer();
            this.btnInnoLogThread = new _INNO._UI.InnoButton();
            this.btnInnoLogManager = new _INNO._UI.InnoButton();
            this.btnInnoZip = new _INNO._UI.InnoButton();
            this.btnInnoXml = new _INNO._UI.InnoButton();
            this.btnInnoLog = new _INNO._UI.InnoButton();
            this.btn_InnoFile = new _INNO._UI.InnoButton();
            this.lbLog = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInnoCsv
            // 
            this.btnInnoCsv.BackColor = System.Drawing.Color.White;
            this.btnInnoCsv.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnInnoCsv.Checked = false;
            this.btnInnoCsv.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInnoCsv.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInnoCsv.ForeColor = System.Drawing.Color.Black;
            this.btnInnoCsv.Location = new System.Drawing.Point(3, 95);
            this.btnInnoCsv.Name = "btnInnoCsv";
            this.btnInnoCsv.NormalBackColor = System.Drawing.Color.White;
            this.btnInnoCsv.NormalForeColor = System.Drawing.Color.Black;
            this.btnInnoCsv.Size = new System.Drawing.Size(110, 40);
            this.btnInnoCsv.TabIndex = 0;
            this.btnInnoCsv.Text = "InnoCsv";
            this.btnInnoCsv.UseVisualStyleBackColor = false;
            this.btnInnoCsv.Click += new System.EventHandler(this.btnInnoCsv_Click);
            // 
            // btnCustomIni
            // 
            this.btnCustomIni.BackColor = System.Drawing.Color.White;
            this.btnCustomIni.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnCustomIni.Checked = false;
            this.btnCustomIni.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCustomIni.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCustomIni.ForeColor = System.Drawing.Color.Black;
            this.btnCustomIni.Location = new System.Drawing.Point(119, 49);
            this.btnCustomIni.Name = "btnCustomIni";
            this.btnCustomIni.NormalBackColor = System.Drawing.Color.White;
            this.btnCustomIni.NormalForeColor = System.Drawing.Color.Black;
            this.btnCustomIni.Size = new System.Drawing.Size(110, 40);
            this.btnCustomIni.TabIndex = 0;
            this.btnCustomIni.Text = "CustomIni";
            this.btnCustomIni.UseVisualStyleBackColor = false;
            this.btnCustomIni.Click += new System.EventHandler(this.btnCustomIni_Click);
            // 
            // btnInnoIni_Pro
            // 
            this.btnInnoIni_Pro.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInnoIni_Pro.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnInnoIni_Pro.Checked = false;
            this.btnInnoIni_Pro.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInnoIni_Pro.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInnoIni_Pro.ForeColor = System.Drawing.Color.Yellow;
            this.btnInnoIni_Pro.Location = new System.Drawing.Point(329, 49);
            this.btnInnoIni_Pro.Name = "btnInnoIni_Pro";
            this.btnInnoIni_Pro.NormalBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInnoIni_Pro.NormalForeColor = System.Drawing.Color.Yellow;
            this.btnInnoIni_Pro.Size = new System.Drawing.Size(110, 40);
            this.btnInnoIni_Pro.TabIndex = 0;
            this.btnInnoIni_Pro.Text = "InnoIni";
            this.btnInnoIni_Pro.UseVisualStyleBackColor = false;
            this.btnInnoIni_Pro.Click += new System.EventHandler(this.btnInnoIni_Pro_Click);
            // 
            // btnInnoIni
            // 
            this.btnInnoIni.BackColor = System.Drawing.Color.White;
            this.btnInnoIni.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnInnoIni.Checked = false;
            this.btnInnoIni.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInnoIni.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInnoIni.ForeColor = System.Drawing.Color.Black;
            this.btnInnoIni.Location = new System.Drawing.Point(3, 49);
            this.btnInnoIni.Name = "btnInnoIni";
            this.btnInnoIni.NormalBackColor = System.Drawing.Color.White;
            this.btnInnoIni.NormalForeColor = System.Drawing.Color.Black;
            this.btnInnoIni.Size = new System.Drawing.Size(110, 40);
            this.btnInnoIni.TabIndex = 0;
            this.btnInnoIni.Text = "InnoIni";
            this.btnInnoIni.UseVisualStyleBackColor = false;
            this.btnInnoIni.Click += new System.EventHandler(this.btnInnoIni_Click);
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
            this.sc.Panel1.Controls.Add(this.btnInnoLogThread);
            this.sc.Panel1.Controls.Add(this.btnInnoLogManager);
            this.sc.Panel1.Controls.Add(this.btnInnoZip);
            this.sc.Panel1.Controls.Add(this.btnInnoXml);
            this.sc.Panel1.Controls.Add(this.btnInnoLog);
            this.sc.Panel1.Controls.Add(this.btnInnoCsv);
            this.sc.Panel1.Controls.Add(this.btnCustomIni);
            this.sc.Panel1.Controls.Add(this.btnInnoIni_Pro);
            this.sc.Panel1.Controls.Add(this.btn_InnoFile);
            this.sc.Panel1.Controls.Add(this.btnInnoIni);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sc.Panel2.Controls.Add(this.lbLog);
            this.sc.Size = new System.Drawing.Size(776, 576);
            this.sc.SplitterDistance = 407;
            this.sc.TabIndex = 18;
            // 
            // btnInnoLogThread
            // 
            this.btnInnoLogThread.BackColor = System.Drawing.Color.Tomato;
            this.btnInnoLogThread.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnInnoLogThread.Checked = false;
            this.btnInnoLogThread.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInnoLogThread.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInnoLogThread.ForeColor = System.Drawing.Color.Yellow;
            this.btnInnoLogThread.Location = new System.Drawing.Point(329, 141);
            this.btnInnoLogThread.Name = "btnInnoLogThread";
            this.btnInnoLogThread.NormalBackColor = System.Drawing.Color.Tomato;
            this.btnInnoLogThread.NormalForeColor = System.Drawing.Color.Yellow;
            this.btnInnoLogThread.Size = new System.Drawing.Size(110, 40);
            this.btnInnoLogThread.TabIndex = 0;
            this.btnInnoLogThread.Text = "InnoLogThread (Pro)";
            this.btnInnoLogThread.UseVisualStyleBackColor = false;
            this.btnInnoLogThread.Click += new System.EventHandler(this.btnInnoLogThread_Click);
            // 
            // btnInnoLogManager
            // 
            this.btnInnoLogManager.BackColor = System.Drawing.Color.White;
            this.btnInnoLogManager.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnInnoLogManager.Checked = false;
            this.btnInnoLogManager.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInnoLogManager.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInnoLogManager.ForeColor = System.Drawing.Color.Black;
            this.btnInnoLogManager.Location = new System.Drawing.Point(119, 141);
            this.btnInnoLogManager.Name = "btnInnoLogManager";
            this.btnInnoLogManager.NormalBackColor = System.Drawing.Color.White;
            this.btnInnoLogManager.NormalForeColor = System.Drawing.Color.Black;
            this.btnInnoLogManager.Size = new System.Drawing.Size(110, 40);
            this.btnInnoLogManager.TabIndex = 0;
            this.btnInnoLogManager.Text = "InnoLogManager";
            this.btnInnoLogManager.UseVisualStyleBackColor = false;
            this.btnInnoLogManager.Click += new System.EventHandler(this.btnInnoLogManager_Click);
            // 
            // btnInnoZip
            // 
            this.btnInnoZip.BackColor = System.Drawing.Color.White;
            this.btnInnoZip.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnInnoZip.Checked = false;
            this.btnInnoZip.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInnoZip.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInnoZip.ForeColor = System.Drawing.Color.Black;
            this.btnInnoZip.Location = new System.Drawing.Point(3, 233);
            this.btnInnoZip.Name = "btnInnoZip";
            this.btnInnoZip.NormalBackColor = System.Drawing.Color.White;
            this.btnInnoZip.NormalForeColor = System.Drawing.Color.Black;
            this.btnInnoZip.Size = new System.Drawing.Size(110, 40);
            this.btnInnoZip.TabIndex = 0;
            this.btnInnoZip.Text = "InnoZip";
            this.btnInnoZip.UseVisualStyleBackColor = false;
            this.btnInnoZip.Click += new System.EventHandler(this.btnInnoZip_Click);
            // 
            // btnInnoXml
            // 
            this.btnInnoXml.BackColor = System.Drawing.Color.White;
            this.btnInnoXml.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnInnoXml.Checked = false;
            this.btnInnoXml.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInnoXml.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInnoXml.ForeColor = System.Drawing.Color.Black;
            this.btnInnoXml.Location = new System.Drawing.Point(3, 187);
            this.btnInnoXml.Name = "btnInnoXml";
            this.btnInnoXml.NormalBackColor = System.Drawing.Color.White;
            this.btnInnoXml.NormalForeColor = System.Drawing.Color.Black;
            this.btnInnoXml.Size = new System.Drawing.Size(110, 40);
            this.btnInnoXml.TabIndex = 0;
            this.btnInnoXml.Text = "InnoXml";
            this.btnInnoXml.UseVisualStyleBackColor = false;
            this.btnInnoXml.Click += new System.EventHandler(this.btnInnoXml_Click);
            // 
            // btnInnoLog
            // 
            this.btnInnoLog.BackColor = System.Drawing.Color.White;
            this.btnInnoLog.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnInnoLog.Checked = false;
            this.btnInnoLog.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInnoLog.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInnoLog.ForeColor = System.Drawing.Color.Black;
            this.btnInnoLog.Location = new System.Drawing.Point(3, 141);
            this.btnInnoLog.Name = "btnInnoLog";
            this.btnInnoLog.NormalBackColor = System.Drawing.Color.White;
            this.btnInnoLog.NormalForeColor = System.Drawing.Color.Black;
            this.btnInnoLog.Size = new System.Drawing.Size(110, 40);
            this.btnInnoLog.TabIndex = 0;
            this.btnInnoLog.Text = "InnoLog";
            this.btnInnoLog.UseVisualStyleBackColor = false;
            this.btnInnoLog.Click += new System.EventHandler(this.btnInnoLog_Click);
            // 
            // btn_InnoFile
            // 
            this.btn_InnoFile.BackColor = System.Drawing.Color.White;
            this.btn_InnoFile.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btn_InnoFile.Checked = false;
            this.btn_InnoFile.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_InnoFile.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_InnoFile.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_InnoFile.Location = new System.Drawing.Point(3, 3);
            this.btn_InnoFile.Name = "btn_InnoFile";
            this.btn_InnoFile.NormalBackColor = System.Drawing.Color.White;
            this.btn_InnoFile.NormalForeColor = System.Drawing.Color.IndianRed;
            this.btn_InnoFile.Size = new System.Drawing.Size(110, 40);
            this.btn_InnoFile.TabIndex = 0;
            this.btn_InnoFile.Text = "_InnoFile";
            this.btn_InnoFile.UseVisualStyleBackColor = false;
            this.btn_InnoFile.Click += new System.EventHandler(this.btn_InnoFile_Click);
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
            // Form_04_File
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.sc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_04_File";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private _INNO._UI.InnoButton btnInnoCsv;
        private _INNO._UI.InnoButton btnCustomIni;
        private _INNO._UI.InnoButton btnInnoIni_Pro;
        private _INNO._UI.InnoButton btnInnoIni;
        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.ListBox lbLog;
        private _INNO._UI.InnoButton btnInnoLogManager;
        private _INNO._UI.InnoButton btnInnoLog;
        private _INNO._UI.InnoButton btnInnoLogThread;
        private _INNO._UI.InnoButton btnInnoZip;
        private _INNO._UI.InnoButton btnInnoXml;
        private _INNO._UI.InnoButton btn_InnoFile;
    }
}