namespace INNOexample
{
    partial class Form_14_Thread
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_14_Thread));
            this.sc = new System.Windows.Forms.SplitContainer();
            this.innoGroupBoxBorder3 = new _INNO._UI.InnoGroupBoxBorder();
            this.btn_InnoThread_Stop = new _INNO._UI.InnoButton();
            this.btn_InnoThread_Start = new _INNO._UI.InnoButton();
            this.innoGroupBoxBorder4 = new _INNO._UI.InnoGroupBoxBorder();
            this.btnInnoThreadCallback_Stop = new _INNO._UI.InnoButton();
            this.btnInnoThreadCallback_Start = new _INNO._UI.InnoButton();
            this.innoGroupBoxBorder2 = new _INNO._UI.InnoGroupBoxBorder();
            this.btnInnoBackgroundWorker_Resume = new _INNO._UI.InnoButton();
            this.btnInnoBackgroundWorker_Stop = new _INNO._UI.InnoButton();
            this.btnInnoBackgroundWorker_Pause = new _INNO._UI.InnoButton();
            this.btnInnoBackgroundWorker_Start = new _INNO._UI.InnoButton();
            this.innoGroupBoxBorder1 = new _INNO._UI.InnoGroupBoxBorder();
            this.btnInnoNameThread_Stop = new _INNO._UI.InnoButton();
            this.btnInnoNameThread_Start = new _INNO._UI.InnoButton();
            this.groupInnoNameThread_static = new _INNO._UI.InnoGroupBoxBorder();
            this.btn_InnoNameThread_Stop = new _INNO._UI.InnoButton();
            this.btn_InnoNameThread_Start = new _INNO._UI.InnoButton();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.btnInnoThreadCallback_Pause = new _INNO._UI.InnoButton();
            this.btnInnoThreadCallback_Resume = new _INNO._UI.InnoButton();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            this.innoGroupBoxBorder3.SuspendLayout();
            this.innoGroupBoxBorder4.SuspendLayout();
            this.innoGroupBoxBorder2.SuspendLayout();
            this.innoGroupBoxBorder1.SuspendLayout();
            this.groupInnoNameThread_static.SuspendLayout();
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
            this.sc.Panel1.Controls.Add(this.innoGroupBoxBorder3);
            this.sc.Panel1.Controls.Add(this.innoGroupBoxBorder4);
            this.sc.Panel1.Controls.Add(this.innoGroupBoxBorder2);
            this.sc.Panel1.Controls.Add(this.innoGroupBoxBorder1);
            this.sc.Panel1.Controls.Add(this.groupInnoNameThread_static);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sc.Panel2.Controls.Add(this.lbLog);
            this.sc.Size = new System.Drawing.Size(776, 576);
            this.sc.SplitterDistance = 407;
            this.sc.TabIndex = 19;
            // 
            // innoGroupBoxBorder3
            // 
            this.innoGroupBoxBorder3.BorderColor = System.Drawing.Color.Black;
            this.innoGroupBoxBorder3.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.innoGroupBoxBorder3.BorderWidth = 2;
            this.innoGroupBoxBorder3.Controls.Add(this.btn_InnoThread_Stop);
            this.innoGroupBoxBorder3.Controls.Add(this.btn_InnoThread_Start);
            this.innoGroupBoxBorder3.ForeColor = System.Drawing.Color.IndianRed;
            this.innoGroupBoxBorder3.Location = new System.Drawing.Point(3, 3);
            this.innoGroupBoxBorder3.Name = "innoGroupBoxBorder3";
            this.innoGroupBoxBorder3.Size = new System.Drawing.Size(124, 117);
            this.innoGroupBoxBorder3.TabIndex = 1;
            this.innoGroupBoxBorder3.TabStop = false;
            this.innoGroupBoxBorder3.Text = "_InnoThread";
            // 
            // btn_InnoThread_Stop
            // 
            this.btn_InnoThread_Stop.BackColor = System.Drawing.Color.White;
            this.btn_InnoThread_Stop.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btn_InnoThread_Stop.Checked = false;
            this.btn_InnoThread_Stop.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_InnoThread_Stop.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_InnoThread_Stop.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_InnoThread_Stop.Location = new System.Drawing.Point(6, 66);
            this.btn_InnoThread_Stop.Name = "btn_InnoThread_Stop";
            this.btn_InnoThread_Stop.NormalBackColor = System.Drawing.Color.White;
            this.btn_InnoThread_Stop.NormalForeColor = System.Drawing.Color.IndianRed;
            this.btn_InnoThread_Stop.Size = new System.Drawing.Size(110, 40);
            this.btn_InnoThread_Stop.TabIndex = 4;
            this.btn_InnoThread_Stop.Text = "Stop (자체)";
            this.btn_InnoThread_Stop.UseVisualStyleBackColor = false;
            this.btn_InnoThread_Stop.Click += new System.EventHandler(this.btn_InnoThread_Stop_Click);
            // 
            // btn_InnoThread_Start
            // 
            this.btn_InnoThread_Start.BackColor = System.Drawing.Color.White;
            this.btn_InnoThread_Start.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btn_InnoThread_Start.Checked = false;
            this.btn_InnoThread_Start.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_InnoThread_Start.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_InnoThread_Start.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_InnoThread_Start.Location = new System.Drawing.Point(6, 20);
            this.btn_InnoThread_Start.Name = "btn_InnoThread_Start";
            this.btn_InnoThread_Start.NormalBackColor = System.Drawing.Color.White;
            this.btn_InnoThread_Start.NormalForeColor = System.Drawing.Color.IndianRed;
            this.btn_InnoThread_Start.Size = new System.Drawing.Size(110, 40);
            this.btn_InnoThread_Start.TabIndex = 0;
            this.btn_InnoThread_Start.Text = "_Start";
            this.btn_InnoThread_Start.UseVisualStyleBackColor = false;
            this.btn_InnoThread_Start.Click += new System.EventHandler(this.btn_InnoThread_Start_Click);
            // 
            // innoGroupBoxBorder4
            // 
            this.innoGroupBoxBorder4.BorderColor = System.Drawing.Color.Black;
            this.innoGroupBoxBorder4.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.innoGroupBoxBorder4.BorderWidth = 2;
            this.innoGroupBoxBorder4.Controls.Add(this.btnInnoThreadCallback_Resume);
            this.innoGroupBoxBorder4.Controls.Add(this.btnInnoThreadCallback_Stop);
            this.innoGroupBoxBorder4.Controls.Add(this.btnInnoThreadCallback_Pause);
            this.innoGroupBoxBorder4.Controls.Add(this.btnInnoThreadCallback_Start);
            this.innoGroupBoxBorder4.Location = new System.Drawing.Point(3, 249);
            this.innoGroupBoxBorder4.Name = "innoGroupBoxBorder4";
            this.innoGroupBoxBorder4.Size = new System.Drawing.Size(241, 117);
            this.innoGroupBoxBorder4.TabIndex = 1;
            this.innoGroupBoxBorder4.TabStop = false;
            this.innoGroupBoxBorder4.Text = "InnoThreadCallback";
            // 
            // btnInnoThreadCallback_Stop
            // 
            this.btnInnoThreadCallback_Stop.BackColor = System.Drawing.Color.White;
            this.btnInnoThreadCallback_Stop.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnInnoThreadCallback_Stop.Checked = false;
            this.btnInnoThreadCallback_Stop.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInnoThreadCallback_Stop.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInnoThreadCallback_Stop.ForeColor = System.Drawing.Color.Black;
            this.btnInnoThreadCallback_Stop.Location = new System.Drawing.Point(6, 66);
            this.btnInnoThreadCallback_Stop.Name = "btnInnoThreadCallback_Stop";
            this.btnInnoThreadCallback_Stop.NormalBackColor = System.Drawing.Color.White;
            this.btnInnoThreadCallback_Stop.NormalForeColor = System.Drawing.Color.Black;
            this.btnInnoThreadCallback_Stop.Size = new System.Drawing.Size(110, 40);
            this.btnInnoThreadCallback_Stop.TabIndex = 4;
            this.btnInnoThreadCallback_Stop.Text = "Stop";
            this.btnInnoThreadCallback_Stop.UseVisualStyleBackColor = false;
            this.btnInnoThreadCallback_Stop.Click += new System.EventHandler(this.btnInnoThreadCallback_Stop_Click);
            // 
            // btnInnoThreadCallback_Start
            // 
            this.btnInnoThreadCallback_Start.BackColor = System.Drawing.Color.White;
            this.btnInnoThreadCallback_Start.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnInnoThreadCallback_Start.Checked = false;
            this.btnInnoThreadCallback_Start.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInnoThreadCallback_Start.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInnoThreadCallback_Start.ForeColor = System.Drawing.Color.Black;
            this.btnInnoThreadCallback_Start.Location = new System.Drawing.Point(6, 20);
            this.btnInnoThreadCallback_Start.Name = "btnInnoThreadCallback_Start";
            this.btnInnoThreadCallback_Start.NormalBackColor = System.Drawing.Color.White;
            this.btnInnoThreadCallback_Start.NormalForeColor = System.Drawing.Color.Black;
            this.btnInnoThreadCallback_Start.Size = new System.Drawing.Size(110, 40);
            this.btnInnoThreadCallback_Start.TabIndex = 0;
            this.btnInnoThreadCallback_Start.Text = "Start";
            this.btnInnoThreadCallback_Start.UseVisualStyleBackColor = false;
            this.btnInnoThreadCallback_Start.Click += new System.EventHandler(this.btnInnoThreadCallback_Start_Click);
            // 
            // innoGroupBoxBorder2
            // 
            this.innoGroupBoxBorder2.BorderColor = System.Drawing.Color.Black;
            this.innoGroupBoxBorder2.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.innoGroupBoxBorder2.BorderWidth = 2;
            this.innoGroupBoxBorder2.Controls.Add(this.btnInnoBackgroundWorker_Resume);
            this.innoGroupBoxBorder2.Controls.Add(this.btnInnoBackgroundWorker_Stop);
            this.innoGroupBoxBorder2.Controls.Add(this.btnInnoBackgroundWorker_Pause);
            this.innoGroupBoxBorder2.Controls.Add(this.btnInnoBackgroundWorker_Start);
            this.innoGroupBoxBorder2.Location = new System.Drawing.Point(3, 126);
            this.innoGroupBoxBorder2.Name = "innoGroupBoxBorder2";
            this.innoGroupBoxBorder2.Size = new System.Drawing.Size(241, 117);
            this.innoGroupBoxBorder2.TabIndex = 1;
            this.innoGroupBoxBorder2.TabStop = false;
            this.innoGroupBoxBorder2.Text = "InnoBackgroundWorker";
            // 
            // btnInnoBackgroundWorker_Resume
            // 
            this.btnInnoBackgroundWorker_Resume.BackColor = System.Drawing.Color.White;
            this.btnInnoBackgroundWorker_Resume.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnInnoBackgroundWorker_Resume.Checked = false;
            this.btnInnoBackgroundWorker_Resume.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInnoBackgroundWorker_Resume.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInnoBackgroundWorker_Resume.ForeColor = System.Drawing.Color.Black;
            this.btnInnoBackgroundWorker_Resume.Location = new System.Drawing.Point(122, 66);
            this.btnInnoBackgroundWorker_Resume.Name = "btnInnoBackgroundWorker_Resume";
            this.btnInnoBackgroundWorker_Resume.NormalBackColor = System.Drawing.Color.White;
            this.btnInnoBackgroundWorker_Resume.NormalForeColor = System.Drawing.Color.Black;
            this.btnInnoBackgroundWorker_Resume.Size = new System.Drawing.Size(110, 40);
            this.btnInnoBackgroundWorker_Resume.TabIndex = 4;
            this.btnInnoBackgroundWorker_Resume.Text = "Resume";
            this.btnInnoBackgroundWorker_Resume.UseVisualStyleBackColor = false;
            this.btnInnoBackgroundWorker_Resume.Click += new System.EventHandler(this.btnInnoBackgroundWorker_Resume_Click);
            // 
            // btnInnoBackgroundWorker_Stop
            // 
            this.btnInnoBackgroundWorker_Stop.BackColor = System.Drawing.Color.White;
            this.btnInnoBackgroundWorker_Stop.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnInnoBackgroundWorker_Stop.Checked = false;
            this.btnInnoBackgroundWorker_Stop.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInnoBackgroundWorker_Stop.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInnoBackgroundWorker_Stop.ForeColor = System.Drawing.Color.Black;
            this.btnInnoBackgroundWorker_Stop.Location = new System.Drawing.Point(6, 66);
            this.btnInnoBackgroundWorker_Stop.Name = "btnInnoBackgroundWorker_Stop";
            this.btnInnoBackgroundWorker_Stop.NormalBackColor = System.Drawing.Color.White;
            this.btnInnoBackgroundWorker_Stop.NormalForeColor = System.Drawing.Color.Black;
            this.btnInnoBackgroundWorker_Stop.Size = new System.Drawing.Size(110, 40);
            this.btnInnoBackgroundWorker_Stop.TabIndex = 4;
            this.btnInnoBackgroundWorker_Stop.Text = "Stop";
            this.btnInnoBackgroundWorker_Stop.UseVisualStyleBackColor = false;
            this.btnInnoBackgroundWorker_Stop.Click += new System.EventHandler(this.btnInnoBackgroundWorker_Stop_Click);
            // 
            // btnInnoBackgroundWorker_Pause
            // 
            this.btnInnoBackgroundWorker_Pause.BackColor = System.Drawing.Color.White;
            this.btnInnoBackgroundWorker_Pause.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnInnoBackgroundWorker_Pause.Checked = false;
            this.btnInnoBackgroundWorker_Pause.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInnoBackgroundWorker_Pause.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInnoBackgroundWorker_Pause.ForeColor = System.Drawing.Color.Black;
            this.btnInnoBackgroundWorker_Pause.Location = new System.Drawing.Point(122, 20);
            this.btnInnoBackgroundWorker_Pause.Name = "btnInnoBackgroundWorker_Pause";
            this.btnInnoBackgroundWorker_Pause.NormalBackColor = System.Drawing.Color.White;
            this.btnInnoBackgroundWorker_Pause.NormalForeColor = System.Drawing.Color.Black;
            this.btnInnoBackgroundWorker_Pause.Size = new System.Drawing.Size(110, 40);
            this.btnInnoBackgroundWorker_Pause.TabIndex = 0;
            this.btnInnoBackgroundWorker_Pause.Text = "Pause";
            this.btnInnoBackgroundWorker_Pause.UseVisualStyleBackColor = false;
            this.btnInnoBackgroundWorker_Pause.Click += new System.EventHandler(this.btnInnoBackgroundWorker_Pause_Click);
            // 
            // btnInnoBackgroundWorker_Start
            // 
            this.btnInnoBackgroundWorker_Start.BackColor = System.Drawing.Color.White;
            this.btnInnoBackgroundWorker_Start.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnInnoBackgroundWorker_Start.Checked = false;
            this.btnInnoBackgroundWorker_Start.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInnoBackgroundWorker_Start.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInnoBackgroundWorker_Start.ForeColor = System.Drawing.Color.Black;
            this.btnInnoBackgroundWorker_Start.Location = new System.Drawing.Point(6, 20);
            this.btnInnoBackgroundWorker_Start.Name = "btnInnoBackgroundWorker_Start";
            this.btnInnoBackgroundWorker_Start.NormalBackColor = System.Drawing.Color.White;
            this.btnInnoBackgroundWorker_Start.NormalForeColor = System.Drawing.Color.Black;
            this.btnInnoBackgroundWorker_Start.Size = new System.Drawing.Size(110, 40);
            this.btnInnoBackgroundWorker_Start.TabIndex = 0;
            this.btnInnoBackgroundWorker_Start.Text = "Start";
            this.btnInnoBackgroundWorker_Start.UseVisualStyleBackColor = false;
            this.btnInnoBackgroundWorker_Start.Click += new System.EventHandler(this.btnInnoBackgroundWorker_Start_Click);
            // 
            // innoGroupBoxBorder1
            // 
            this.innoGroupBoxBorder1.BorderColor = System.Drawing.Color.Black;
            this.innoGroupBoxBorder1.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.innoGroupBoxBorder1.BorderWidth = 2;
            this.innoGroupBoxBorder1.Controls.Add(this.btnInnoNameThread_Stop);
            this.innoGroupBoxBorder1.Controls.Add(this.btnInnoNameThread_Start);
            this.innoGroupBoxBorder1.Location = new System.Drawing.Point(327, 126);
            this.innoGroupBoxBorder1.Name = "innoGroupBoxBorder1";
            this.innoGroupBoxBorder1.Size = new System.Drawing.Size(125, 117);
            this.innoGroupBoxBorder1.TabIndex = 1;
            this.innoGroupBoxBorder1.TabStop = false;
            this.innoGroupBoxBorder1.Text = "InnoNameThread";
            // 
            // btnInnoNameThread_Stop
            // 
            this.btnInnoNameThread_Stop.BackColor = System.Drawing.Color.White;
            this.btnInnoNameThread_Stop.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnInnoNameThread_Stop.Checked = false;
            this.btnInnoNameThread_Stop.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInnoNameThread_Stop.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInnoNameThread_Stop.ForeColor = System.Drawing.Color.Black;
            this.btnInnoNameThread_Stop.Location = new System.Drawing.Point(6, 66);
            this.btnInnoNameThread_Stop.Name = "btnInnoNameThread_Stop";
            this.btnInnoNameThread_Stop.NormalBackColor = System.Drawing.Color.White;
            this.btnInnoNameThread_Stop.NormalForeColor = System.Drawing.Color.Black;
            this.btnInnoNameThread_Stop.Size = new System.Drawing.Size(110, 40);
            this.btnInnoNameThread_Stop.TabIndex = 4;
            this.btnInnoNameThread_Stop.Text = "Stop";
            this.btnInnoNameThread_Stop.UseVisualStyleBackColor = false;
            this.btnInnoNameThread_Stop.Click += new System.EventHandler(this.btnInnoNameThread_Stop_Click);
            // 
            // btnInnoNameThread_Start
            // 
            this.btnInnoNameThread_Start.BackColor = System.Drawing.Color.White;
            this.btnInnoNameThread_Start.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnInnoNameThread_Start.Checked = false;
            this.btnInnoNameThread_Start.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInnoNameThread_Start.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInnoNameThread_Start.ForeColor = System.Drawing.Color.Black;
            this.btnInnoNameThread_Start.Location = new System.Drawing.Point(6, 20);
            this.btnInnoNameThread_Start.Name = "btnInnoNameThread_Start";
            this.btnInnoNameThread_Start.NormalBackColor = System.Drawing.Color.White;
            this.btnInnoNameThread_Start.NormalForeColor = System.Drawing.Color.Black;
            this.btnInnoNameThread_Start.Size = new System.Drawing.Size(110, 40);
            this.btnInnoNameThread_Start.TabIndex = 0;
            this.btnInnoNameThread_Start.Text = "Start";
            this.btnInnoNameThread_Start.UseVisualStyleBackColor = false;
            this.btnInnoNameThread_Start.Click += new System.EventHandler(this.btnInnoNameThread_Start_Click);
            // 
            // groupInnoNameThread_static
            // 
            this.groupInnoNameThread_static.BorderColor = System.Drawing.Color.IndianRed;
            this.groupInnoNameThread_static.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.groupInnoNameThread_static.BorderWidth = 2;
            this.groupInnoNameThread_static.Controls.Add(this.btn_InnoNameThread_Stop);
            this.groupInnoNameThread_static.Controls.Add(this.btn_InnoNameThread_Start);
            this.groupInnoNameThread_static.ForeColor = System.Drawing.Color.IndianRed;
            this.groupInnoNameThread_static.Location = new System.Drawing.Point(327, 3);
            this.groupInnoNameThread_static.Name = "groupInnoNameThread_static";
            this.groupInnoNameThread_static.Size = new System.Drawing.Size(125, 117);
            this.groupInnoNameThread_static.TabIndex = 1;
            this.groupInnoNameThread_static.TabStop = false;
            this.groupInnoNameThread_static.Text = "InnoNameThread static";
            // 
            // btn_InnoNameThread_Stop
            // 
            this.btn_InnoNameThread_Stop.BackColor = System.Drawing.Color.White;
            this.btn_InnoNameThread_Stop.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btn_InnoNameThread_Stop.Checked = false;
            this.btn_InnoNameThread_Stop.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_InnoNameThread_Stop.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_InnoNameThread_Stop.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_InnoNameThread_Stop.Location = new System.Drawing.Point(6, 66);
            this.btn_InnoNameThread_Stop.Name = "btn_InnoNameThread_Stop";
            this.btn_InnoNameThread_Stop.NormalBackColor = System.Drawing.Color.White;
            this.btn_InnoNameThread_Stop.NormalForeColor = System.Drawing.Color.IndianRed;
            this.btn_InnoNameThread_Stop.Size = new System.Drawing.Size(110, 40);
            this.btn_InnoNameThread_Stop.TabIndex = 4;
            this.btn_InnoNameThread_Stop.Text = "_Stop";
            this.btn_InnoNameThread_Stop.UseVisualStyleBackColor = false;
            this.btn_InnoNameThread_Stop.Click += new System.EventHandler(this.btn_InnoNameThread_Stop_Click);
            // 
            // btn_InnoNameThread_Start
            // 
            this.btn_InnoNameThread_Start.BackColor = System.Drawing.Color.White;
            this.btn_InnoNameThread_Start.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btn_InnoNameThread_Start.Checked = false;
            this.btn_InnoNameThread_Start.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_InnoNameThread_Start.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_InnoNameThread_Start.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_InnoNameThread_Start.Location = new System.Drawing.Point(6, 20);
            this.btn_InnoNameThread_Start.Name = "btn_InnoNameThread_Start";
            this.btn_InnoNameThread_Start.NormalBackColor = System.Drawing.Color.White;
            this.btn_InnoNameThread_Start.NormalForeColor = System.Drawing.Color.IndianRed;
            this.btn_InnoNameThread_Start.Size = new System.Drawing.Size(110, 40);
            this.btn_InnoNameThread_Start.TabIndex = 0;
            this.btn_InnoNameThread_Start.Text = "_Start";
            this.btn_InnoNameThread_Start.UseVisualStyleBackColor = false;
            this.btn_InnoNameThread_Start.Click += new System.EventHandler(this.btn_InnoNameThread_Start_Click);
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
            // btnInnoThreadCallback_Pause
            // 
            this.btnInnoThreadCallback_Pause.BackColor = System.Drawing.Color.White;
            this.btnInnoThreadCallback_Pause.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnInnoThreadCallback_Pause.Checked = false;
            this.btnInnoThreadCallback_Pause.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInnoThreadCallback_Pause.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInnoThreadCallback_Pause.ForeColor = System.Drawing.Color.Black;
            this.btnInnoThreadCallback_Pause.Location = new System.Drawing.Point(122, 20);
            this.btnInnoThreadCallback_Pause.Name = "btnInnoThreadCallback_Pause";
            this.btnInnoThreadCallback_Pause.NormalBackColor = System.Drawing.Color.White;
            this.btnInnoThreadCallback_Pause.NormalForeColor = System.Drawing.Color.Black;
            this.btnInnoThreadCallback_Pause.Size = new System.Drawing.Size(110, 40);
            this.btnInnoThreadCallback_Pause.TabIndex = 0;
            this.btnInnoThreadCallback_Pause.Text = "Pause";
            this.btnInnoThreadCallback_Pause.UseVisualStyleBackColor = false;
            this.btnInnoThreadCallback_Pause.Click += new System.EventHandler(this.btnInnoThreadCallback_Pause_Click);
            // 
            // btnInnoThreadCallback_Resume
            // 
            this.btnInnoThreadCallback_Resume.BackColor = System.Drawing.Color.White;
            this.btnInnoThreadCallback_Resume.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnInnoThreadCallback_Resume.Checked = false;
            this.btnInnoThreadCallback_Resume.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInnoThreadCallback_Resume.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInnoThreadCallback_Resume.ForeColor = System.Drawing.Color.Black;
            this.btnInnoThreadCallback_Resume.Location = new System.Drawing.Point(122, 66);
            this.btnInnoThreadCallback_Resume.Name = "btnInnoThreadCallback_Resume";
            this.btnInnoThreadCallback_Resume.NormalBackColor = System.Drawing.Color.White;
            this.btnInnoThreadCallback_Resume.NormalForeColor = System.Drawing.Color.Black;
            this.btnInnoThreadCallback_Resume.Size = new System.Drawing.Size(110, 40);
            this.btnInnoThreadCallback_Resume.TabIndex = 4;
            this.btnInnoThreadCallback_Resume.Text = "Resume";
            this.btnInnoThreadCallback_Resume.UseVisualStyleBackColor = false;
            this.btnInnoThreadCallback_Resume.Click += new System.EventHandler(this.btnInnoThreadCallback_Resume_Click);
            // 
            // Form_14_Thread
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.sc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_14_Thread";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            this.innoGroupBoxBorder3.ResumeLayout(false);
            this.innoGroupBoxBorder4.ResumeLayout(false);
            this.innoGroupBoxBorder2.ResumeLayout(false);
            this.innoGroupBoxBorder1.ResumeLayout(false);
            this.groupInnoNameThread_static.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.ListBox lbLog;
        private _INNO._UI.InnoGroupBoxBorder groupInnoNameThread_static;
        private _INNO._UI.InnoButton btn_InnoNameThread_Start;
        private _INNO._UI.InnoButton btn_InnoNameThread_Stop;
        private _INNO._UI.InnoGroupBoxBorder innoGroupBoxBorder2;
        private _INNO._UI.InnoButton btnInnoBackgroundWorker_Stop;
        private _INNO._UI.InnoButton btnInnoBackgroundWorker_Start;
        private _INNO._UI.InnoGroupBoxBorder innoGroupBoxBorder1;
        private _INNO._UI.InnoButton btnInnoNameThread_Stop;
        private _INNO._UI.InnoButton btnInnoNameThread_Start;
        private _INNO._UI.InnoGroupBoxBorder innoGroupBoxBorder3;
        private _INNO._UI.InnoButton btn_InnoThread_Stop;
        private _INNO._UI.InnoButton btn_InnoThread_Start;
        private _INNO._UI.InnoGroupBoxBorder innoGroupBoxBorder4;
        private _INNO._UI.InnoButton btnInnoThreadCallback_Stop;
        private _INNO._UI.InnoButton btnInnoThreadCallback_Start;
        private _INNO._UI.InnoButton btnInnoBackgroundWorker_Resume;
        private _INNO._UI.InnoButton btnInnoBackgroundWorker_Pause;
        private _INNO._UI.InnoButton btnInnoThreadCallback_Resume;
        private _INNO._UI.InnoButton btnInnoThreadCallback_Pause;
    }
}