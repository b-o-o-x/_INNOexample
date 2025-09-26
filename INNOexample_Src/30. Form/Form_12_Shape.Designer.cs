namespace INNOexample
{
    partial class Form_12_Shape
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_12_Shape));
            this.sc = new System.Windows.Forms.SplitContainer();
            this.btnMapTest = new _INNO._UI.InnoButton();
            this.btnCreateMap = new _INNO._UI.InnoButton();
            this.map = new _Custom.CustomShapeMap();
            this.innoUIPictureBoxBounceBall1 = new _INNO._UI.InnoPictureBoxBounceBall();
            this.innoUIPictureBoxCircularTimer1 = new _INNO._UI.InnoPictureBoxCircularTimer();
            this.lbLog = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.innoUIPictureBoxBounceBall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.innoUIPictureBoxCircularTimer1)).BeginInit();
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
            this.sc.Panel1.Controls.Add(this.btnMapTest);
            this.sc.Panel1.Controls.Add(this.btnCreateMap);
            this.sc.Panel1.Controls.Add(this.map);
            this.sc.Panel1.Controls.Add(this.innoUIPictureBoxBounceBall1);
            this.sc.Panel1.Controls.Add(this.innoUIPictureBoxCircularTimer1);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sc.Panel2.Controls.Add(this.lbLog);
            this.sc.Size = new System.Drawing.Size(776, 576);
            this.sc.SplitterDistance = 407;
            this.sc.TabIndex = 21;
            // 
            // btnMapTest
            // 
            this.btnMapTest.BackColor = System.Drawing.Color.White;
            this.btnMapTest.BackColor_Checked = System.Drawing.Color.DodgerBlue;
            this.btnMapTest.BackColor_Normal = System.Drawing.Color.White;
            this.btnMapTest.BorderColor_Checked = System.Drawing.Color.PowderBlue;
            this.btnMapTest.BorderColor_Normal = System.Drawing.Color.Silver;
            this.btnMapTest.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnMapTest.Checked = false;
            this.btnMapTest.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnMapTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMapTest.ForeColor = System.Drawing.Color.Black;
            this.btnMapTest.ForeColor_Checked = System.Drawing.Color.WhiteSmoke;
            this.btnMapTest.ForeColor_Normal = System.Drawing.Color.Black;
            this.btnMapTest.Location = new System.Drawing.Point(473, 49);
            this.btnMapTest.Name = "btnMapTest";
            this.btnMapTest.Size = new System.Drawing.Size(110, 40);
            this.btnMapTest.TabIndex = 22;
            this.btnMapTest.Text = "Test Map";
            this.btnMapTest.UseVisualStyleBackColor = false;
            this.btnMapTest.Click += new System.EventHandler(this.btnMapTest_Click);
            // 
            // btnCreateMap
            // 
            this.btnCreateMap.BackColor = System.Drawing.Color.White;
            this.btnCreateMap.BackColor_Checked = System.Drawing.Color.DodgerBlue;
            this.btnCreateMap.BackColor_Normal = System.Drawing.Color.White;
            this.btnCreateMap.BorderColor_Checked = System.Drawing.Color.PowderBlue;
            this.btnCreateMap.BorderColor_Normal = System.Drawing.Color.Silver;
            this.btnCreateMap.ButtonType = _INNO._UI.InnoButton.ButtonTypes.Button;
            this.btnCreateMap.Checked = false;
            this.btnCreateMap.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateMap.ForeColor = System.Drawing.Color.Black;
            this.btnCreateMap.ForeColor_Checked = System.Drawing.Color.WhiteSmoke;
            this.btnCreateMap.ForeColor_Normal = System.Drawing.Color.Black;
            this.btnCreateMap.Location = new System.Drawing.Point(473, 3);
            this.btnCreateMap.Name = "btnCreateMap";
            this.btnCreateMap.Size = new System.Drawing.Size(110, 40);
            this.btnCreateMap.TabIndex = 22;
            this.btnCreateMap.Text = "Create Map";
            this.btnCreateMap.UseVisualStyleBackColor = false;
            this.btnCreateMap.Click += new System.EventHandler(this.btnCreateMap_Click);
            // 
            // map
            // 
            this.map.BackColor = System.Drawing.Color.Silver;
            this.map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.map.Location = new System.Drawing.Point(3, 3);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(464, 324);
            this.map.TabIndex = 21;
            // 
            // innoUIPictureBoxBounceBall1
            // 
            this.innoUIPictureBoxBounceBall1.Location = new System.Drawing.Point(622, 152);
            this.innoUIPictureBoxBounceBall1.Name = "innoUIPictureBoxBounceBall1";
            this.innoUIPictureBoxBounceBall1.Size = new System.Drawing.Size(151, 106);
            this.innoUIPictureBoxBounceBall1.TabIndex = 20;
            this.innoUIPictureBoxBounceBall1.TabStop = false;
            // 
            // innoUIPictureBoxCircularTimer1
            // 
            this.innoUIPictureBoxCircularTimer1.Location = new System.Drawing.Point(622, 3);
            this.innoUIPictureBoxCircularTimer1.Name = "innoUIPictureBoxCircularTimer1";
            this.innoUIPictureBoxCircularTimer1.Size = new System.Drawing.Size(151, 143);
            this.innoUIPictureBoxCircularTimer1.TabIndex = 19;
            this.innoUIPictureBoxCircularTimer1.TabStop = false;
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
            // Form_12_Shape
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.sc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_12_Shape";
            this.Load += new System.EventHandler(this.Form_Load);
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.innoUIPictureBoxBounceBall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.innoUIPictureBoxCircularTimer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private _INNO._UI.InnoPictureBoxCircularTimer innoUIPictureBoxCircularTimer1;
        private _INNO._UI.InnoPictureBoxBounceBall innoUIPictureBoxBounceBall1;
        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.ListBox lbLog;
        private _Custom.CustomShapeMap map;
        private _INNO._UI.InnoButton btnCreateMap;
        private _INNO._UI.InnoButton btnMapTest;
    }
}