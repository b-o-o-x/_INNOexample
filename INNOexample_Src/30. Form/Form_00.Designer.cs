namespace INNOexample
{
    partial class Form_00
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_00));
            this.txtREADME = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtREADME
            // 
            this.txtREADME.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtREADME.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtREADME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtREADME.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtREADME.Location = new System.Drawing.Point(12, 12);
            this.txtREADME.Multiline = true;
            this.txtREADME.Name = "txtREADME";
            this.txtREADME.ReadOnly = true;
            this.txtREADME.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtREADME.Size = new System.Drawing.Size(776, 576);
            this.txtREADME.TabIndex = 5;
            this.txtREADME.Text = resources.GetString("txtREADME.Text");
            // 
            // Form_00
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txtREADME);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_00";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtREADME;
    }
}