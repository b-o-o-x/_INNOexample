namespace INNOexample
{
    partial class Form_Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Information));
            this.innoUIGradientPanel1 = new _INNO._UI.InnoPanelGradiented();
            this.innoUITransparentPanel3 = new _INNO._UI.InnoPanelTransparented();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkBoox = new System.Windows.Forms.LinkLabel();
            this.linkInnosoft = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.PICClose = new _INNO._UI.InnoPictureBoxButton();
            this.innoUIGradientPanel1.SuspendLayout();
            this.innoUITransparentPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICClose)).BeginInit();
            this.SuspendLayout();
            // 
            // innoUIGradientPanel1
            // 
            this.innoUIGradientPanel1.ColorDirection = _INNO._UI.InnoPanelGradiented.Direction.LeftTopToRightBottom;
            this.innoUIGradientPanel1.ColorEnd = System.Drawing.Color.RoyalBlue;
            this.innoUIGradientPanel1.ColorStart = System.Drawing.Color.IndianRed;
            this.innoUIGradientPanel1.Controls.Add(this.innoUITransparentPanel3);
            this.innoUIGradientPanel1.Controls.Add(this.PICClose);
            this.innoUIGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innoUIGradientPanel1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.innoUIGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.innoUIGradientPanel1.Name = "innoUIGradientPanel1";
            this.innoUIGradientPanel1.Size = new System.Drawing.Size(800, 600);
            this.innoUIGradientPanel1.TabIndex = 8;
            // 
            // innoUITransparentPanel3
            // 
            this.innoUITransparentPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.innoUITransparentPanel3.BackColor = System.Drawing.Color.Transparent;
            this.innoUITransparentPanel3.Controls.Add(this.label2);
            this.innoUITransparentPanel3.Controls.Add(this.label5);
            this.innoUITransparentPanel3.Controls.Add(this.label6);
            this.innoUITransparentPanel3.Controls.Add(this.linkBoox);
            this.innoUITransparentPanel3.Controls.Add(this.linkInnosoft);
            this.innoUITransparentPanel3.Controls.Add(this.label7);
            this.innoUITransparentPanel3.Location = new System.Drawing.Point(97, 170);
            this.innoUITransparentPanel3.Name = "innoUITransparentPanel3";
            this.innoUITransparentPanel3.Opacity = 10;
            this.innoUITransparentPanel3.Size = new System.Drawing.Size(600, 190);
            this.innoUITransparentPanel3.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(276, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 58);
            this.label2.TabIndex = 20;
            this.label2.Text = "Copyright © (주)북스 BOOX, Inc. Innosoft, Co. since 2019\r\nhttp://www.boox.co.kr | ht" +
    "tp://innosoft.kr";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F);
            this.label5.Location = new System.Drawing.Point(7, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "Information Page";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(8, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(477, 43);
            this.label6.TabIndex = 15;
            this.label6.Text = "This is only for maintaining this Machine Project easily.\r\nDo not use this for an" +
    "other purpose.";
            // 
            // linkBoox
            // 
            this.linkBoox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkBoox.AutoSize = true;
            this.linkBoox.BackColor = System.Drawing.Color.Transparent;
            this.linkBoox.LinkColor = System.Drawing.Color.White;
            this.linkBoox.Location = new System.Drawing.Point(104, 158);
            this.linkBoox.Name = "linkBoox";
            this.linkBoox.Size = new System.Drawing.Size(70, 17);
            this.linkBoox.TabIndex = 16;
            this.linkBoox.TabStop = true;
            this.linkBoox.Text = "boox.co.kr";
            this.linkBoox.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBoox_LinkClicked);
            // 
            // linkInnosoft
            // 
            this.linkInnosoft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkInnosoft.AutoSize = true;
            this.linkInnosoft.BackColor = System.Drawing.Color.Transparent;
            this.linkInnosoft.LinkColor = System.Drawing.Color.White;
            this.linkInnosoft.Location = new System.Drawing.Point(178, 158);
            this.linkInnosoft.Name = "linkInnosoft";
            this.linkInnosoft.Size = new System.Drawing.Size(68, 17);
            this.linkInnosoft.TabIndex = 16;
            this.linkInnosoft.TabStop = true;
            this.linkInnosoft.Text = "Innosoft.kr";
            this.linkInnosoft.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkInnosoft_LinkClicked);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(8, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Developed by";
            // 
            // PICClose
            // 
            this.PICClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PICClose.BackColor = System.Drawing.Color.Transparent;
            this.PICClose.Image = ((System.Drawing.Image)(resources.GetObject("PICClose.Image")));
            this.PICClose.ImageHover = ((System.Drawing.Image)(resources.GetObject("PICClose.ImageHover")));
            this.PICClose.ImageNormal = ((System.Drawing.Image)(resources.GetObject("PICClose.ImageNormal")));
            this.PICClose.Location = new System.Drawing.Point(763, 9);
            this.PICClose.Name = "PICClose";
            this.PICClose.Size = new System.Drawing.Size(25, 25);
            this.PICClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICClose.TabIndex = 15;
            this.PICClose.TabStop = false;
            this.PICClose.Click += new System.EventHandler(this.PICClose_Click);
            // 
            // Form_Information
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.innoUIGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Information";
            this.innoUIGradientPanel1.ResumeLayout(false);
            this.innoUITransparentPanel3.ResumeLayout(false);
            this.innoUITransparentPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private _INNO._UI.InnoPanelGradiented innoUIGradientPanel1;
        private _INNO._UI.InnoPanelTransparented innoUITransparentPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkBoox;
        private System.Windows.Forms.LinkLabel linkInnosoft;
        private System.Windows.Forms.Label label7;
        private _INNO._UI.InnoPictureBoxButton PICClose;
    }
}