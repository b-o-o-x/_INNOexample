namespace INNOexample
{
    partial class Form_03_Dev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_03_Dev));
            this.sc = new System.Windows.Forms.SplitContainer();
            this.innoGroupBoxBorder1 = new _INNO._UI.InnoGroupBoxBorder();
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.picCam = new System.Windows.Forms.PictureBox();
            this.btnCamDeinit = new _INNO._UI.InnoButton();
            this.btnCamStop = new _INNO._UI.InnoButton();
            this.btnCamStart = new _INNO._UI.InnoButton();
            this.btnCamInit = new _INNO._UI.InnoButton();
            this.innoGroupBoxBorder2 = new _INNO._UI.InnoGroupBoxBorder();
            this.groupCrypt = new _INNO._UI.InnoGroupBoxBorder();
            this.btnDevRadianQBioIndicator = new _INNO._UI.InnoButton();
            this.btnDevIFLightController = new _INNO._UI.InnoButton();
            this.lbLog = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            this.innoGroupBoxBorder1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).BeginInit();
            this.groupCrypt.SuspendLayout();
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
            this.sc.Panel1.Controls.Add(this.innoGroupBoxBorder1);
            this.sc.Panel1.Controls.Add(this.innoGroupBoxBorder2);
            this.sc.Panel1.Controls.Add(this.groupCrypt);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sc.Panel2.Controls.Add(this.lbLog);
            this.sc.Size = new System.Drawing.Size(776, 576);
            this.sc.SplitterDistance = 407;
            this.sc.TabIndex = 19;
            // 
            // innoGroupBoxBorder1
            // 
            this.innoGroupBoxBorder1.BorderColor = System.Drawing.Color.Black;
            this.innoGroupBoxBorder1.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.innoGroupBoxBorder1.BorderWidth = 2;
            this.innoGroupBoxBorder1.Controls.Add(this.picCapture);
            this.innoGroupBoxBorder1.Controls.Add(this.picCam);
            this.innoGroupBoxBorder1.Controls.Add(this.btnCamDeinit);
            this.innoGroupBoxBorder1.Controls.Add(this.btnCamStop);
            this.innoGroupBoxBorder1.Controls.Add(this.btnCamStart);
            this.innoGroupBoxBorder1.Controls.Add(this.btnCamInit);
            this.innoGroupBoxBorder1.Location = new System.Drawing.Point(296, 3);
            this.innoGroupBoxBorder1.Name = "innoGroupBoxBorder1";
            this.innoGroupBoxBorder1.Size = new System.Drawing.Size(477, 308);
            this.innoGroupBoxBorder1.TabIndex = 16;
            this.innoGroupBoxBorder1.TabStop = false;
            this.innoGroupBoxBorder1.Text = "InnoUsbCam";
            // 
            // picCapture
            // 
            this.picCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCapture.Location = new System.Drawing.Point(361, 203);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(110, 98);
            this.picCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCapture.TabIndex = 5;
            this.picCapture.TabStop = false;
            // 
            // picCam
            // 
            this.picCam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCam.Location = new System.Drawing.Point(6, 20);
            this.picCam.Name = "picCam";
            this.picCam.Size = new System.Drawing.Size(349, 281);
            this.picCam.TabIndex = 1;
            this.picCam.TabStop = false;
            // 
            // btnCamDeinit
            // 
            this.btnCamDeinit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCamDeinit.BackColor = System.Drawing.Color.White;
            this.btnCamDeinit.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnCamDeinit.Checked = false;
            this.btnCamDeinit.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCamDeinit.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCamDeinit.ForeColor = System.Drawing.Color.Black;
            this.btnCamDeinit.Location = new System.Drawing.Point(361, 157);
            this.btnCamDeinit.Name = "btnCamDeinit";
            this.btnCamDeinit.NormalBackColor = System.Drawing.Color.White;
            this.btnCamDeinit.NormalForeColor = System.Drawing.Color.Black;
            this.btnCamDeinit.Size = new System.Drawing.Size(110, 40);
            this.btnCamDeinit.TabIndex = 4;
            this.btnCamDeinit.Text = "Deinit";
            this.btnCamDeinit.UseVisualStyleBackColor = false;
            this.btnCamDeinit.Click += new System.EventHandler(this.btnCam_Click);
            // 
            // btnCamStop
            // 
            this.btnCamStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCamStop.BackColor = System.Drawing.Color.White;
            this.btnCamStop.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnCamStop.Checked = false;
            this.btnCamStop.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCamStop.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCamStop.ForeColor = System.Drawing.Color.Black;
            this.btnCamStop.Location = new System.Drawing.Point(361, 111);
            this.btnCamStop.Name = "btnCamStop";
            this.btnCamStop.NormalBackColor = System.Drawing.Color.White;
            this.btnCamStop.NormalForeColor = System.Drawing.Color.Black;
            this.btnCamStop.Size = new System.Drawing.Size(110, 40);
            this.btnCamStop.TabIndex = 4;
            this.btnCamStop.Text = "Stop";
            this.btnCamStop.UseVisualStyleBackColor = false;
            this.btnCamStop.Click += new System.EventHandler(this.btnCam_Click);
            // 
            // btnCamStart
            // 
            this.btnCamStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCamStart.BackColor = System.Drawing.Color.White;
            this.btnCamStart.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnCamStart.Checked = false;
            this.btnCamStart.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCamStart.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCamStart.ForeColor = System.Drawing.Color.Black;
            this.btnCamStart.Location = new System.Drawing.Point(361, 66);
            this.btnCamStart.Name = "btnCamStart";
            this.btnCamStart.NormalBackColor = System.Drawing.Color.White;
            this.btnCamStart.NormalForeColor = System.Drawing.Color.Black;
            this.btnCamStart.Size = new System.Drawing.Size(110, 40);
            this.btnCamStart.TabIndex = 4;
            this.btnCamStart.Text = "Start";
            this.btnCamStart.UseVisualStyleBackColor = false;
            this.btnCamStart.Click += new System.EventHandler(this.btnCam_Click);
            // 
            // btnCamInit
            // 
            this.btnCamInit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCamInit.BackColor = System.Drawing.Color.White;
            this.btnCamInit.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnCamInit.Checked = false;
            this.btnCamInit.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCamInit.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCamInit.ForeColor = System.Drawing.Color.Black;
            this.btnCamInit.Location = new System.Drawing.Point(361, 20);
            this.btnCamInit.Name = "btnCamInit";
            this.btnCamInit.NormalBackColor = System.Drawing.Color.White;
            this.btnCamInit.NormalForeColor = System.Drawing.Color.Black;
            this.btnCamInit.Size = new System.Drawing.Size(110, 40);
            this.btnCamInit.TabIndex = 4;
            this.btnCamInit.Text = "Init";
            this.btnCamInit.UseVisualStyleBackColor = false;
            this.btnCamInit.Click += new System.EventHandler(this.btnCam_Click);
            // 
            // innoGroupBoxBorder2
            // 
            this.innoGroupBoxBorder2.BorderColor = System.Drawing.Color.Black;
            this.innoGroupBoxBorder2.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.innoGroupBoxBorder2.BorderWidth = 2;
            this.innoGroupBoxBorder2.Location = new System.Drawing.Point(3, 160);
            this.innoGroupBoxBorder2.Name = "innoGroupBoxBorder2";
            this.innoGroupBoxBorder2.Size = new System.Drawing.Size(287, 151);
            this.innoGroupBoxBorder2.TabIndex = 16;
            this.innoGroupBoxBorder2.TabStop = false;
            this.innoGroupBoxBorder2.Text = "InnoMotion";
            // 
            // groupCrypt
            // 
            this.groupCrypt.BorderColor = System.Drawing.Color.Black;
            this.groupCrypt.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.groupCrypt.BorderWidth = 2;
            this.groupCrypt.Controls.Add(this.btnDevRadianQBioIndicator);
            this.groupCrypt.Controls.Add(this.btnDevIFLightController);
            this.groupCrypt.Location = new System.Drawing.Point(3, 3);
            this.groupCrypt.Name = "groupCrypt";
            this.groupCrypt.Size = new System.Drawing.Size(287, 151);
            this.groupCrypt.TabIndex = 16;
            this.groupCrypt.TabStop = false;
            this.groupCrypt.Text = "InnoSerialComm";
            // 
            // btnDevRadianQBioIndicator
            // 
            this.btnDevRadianQBioIndicator.BackColor = System.Drawing.Color.White;
            this.btnDevRadianQBioIndicator.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnDevRadianQBioIndicator.Checked = false;
            this.btnDevRadianQBioIndicator.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnDevRadianQBioIndicator.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDevRadianQBioIndicator.ForeColor = System.Drawing.Color.Black;
            this.btnDevRadianQBioIndicator.Location = new System.Drawing.Point(6, 66);
            this.btnDevRadianQBioIndicator.Name = "btnDevRadianQBioIndicator";
            this.btnDevRadianQBioIndicator.NormalBackColor = System.Drawing.Color.White;
            this.btnDevRadianQBioIndicator.NormalForeColor = System.Drawing.Color.Black;
            this.btnDevRadianQBioIndicator.Size = new System.Drawing.Size(110, 40);
            this.btnDevRadianQBioIndicator.TabIndex = 4;
            this.btnDevRadianQBioIndicator.Text = "RadianQBio Indicator";
            this.btnDevRadianQBioIndicator.UseVisualStyleBackColor = false;
            this.btnDevRadianQBioIndicator.Click += new System.EventHandler(this.btnDevRadianQBioIndicator_Click);
            // 
            // btnDevIFLightController
            // 
            this.btnDevIFLightController.BackColor = System.Drawing.Color.White;
            this.btnDevIFLightController.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnDevIFLightController.Checked = false;
            this.btnDevIFLightController.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnDevIFLightController.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDevIFLightController.ForeColor = System.Drawing.Color.Black;
            this.btnDevIFLightController.Location = new System.Drawing.Point(6, 20);
            this.btnDevIFLightController.Name = "btnDevIFLightController";
            this.btnDevIFLightController.NormalBackColor = System.Drawing.Color.White;
            this.btnDevIFLightController.NormalForeColor = System.Drawing.Color.Black;
            this.btnDevIFLightController.Size = new System.Drawing.Size(110, 40);
            this.btnDevIFLightController.TabIndex = 4;
            this.btnDevIFLightController.Text = "IF LightController";
            this.btnDevIFLightController.UseVisualStyleBackColor = false;
            this.btnDevIFLightController.Click += new System.EventHandler(this.btnDevIFLightController_Click);
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
            // Form_03_Dev
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.sc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_03_Dev";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            this.innoGroupBoxBorder1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).EndInit();
            this.groupCrypt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.ListBox lbLog;
        private _INNO._UI.InnoGroupBoxBorder innoGroupBoxBorder1;
        private _INNO._UI.InnoGroupBoxBorder groupCrypt;
        private _INNO._UI.InnoGroupBoxBorder innoGroupBoxBorder2;
        private _INNO._UI.InnoButton btnDevIFLightController;
        private _INNO._UI.InnoButton btnDevRadianQBioIndicator;
        private System.Windows.Forms.PictureBox picCam;
        private _INNO._UI.InnoButton btnCamDeinit;
        private _INNO._UI.InnoButton btnCamStop;
        private _INNO._UI.InnoButton btnCamStart;
        private _INNO._UI.InnoButton btnCamInit;
        private System.Windows.Forms.PictureBox picCapture;
    }
}