namespace INNOexample
{
    partial class Form_15_Time
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_15_Time));
            this.sc = new System.Windows.Forms.SplitContainer();
            this.lbLog = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
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
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sc.Panel2.Controls.Add(this.lbLog);
            this.sc.Size = new System.Drawing.Size(776, 576);
            this.sc.SplitterDistance = 407;
            this.sc.TabIndex = 19;
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
            // Form_15_Time
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.sc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_15_Time";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.ListBox lbLog;
    }
}