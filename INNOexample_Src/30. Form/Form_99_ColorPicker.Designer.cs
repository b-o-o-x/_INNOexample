namespace INNOexample
{
    partial class Form_99_ColorPicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_99_ColorPicker));
            this.innoGroupBoxBorder2 = new _INNO._UI.InnoGroupBoxBorder();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColorRGB = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.innoGroupBoxBorder1 = new _INNO._UI.InnoGroupBoxBorder();
            this.label1 = new System.Windows.Forms.Label();
            this.txtB = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.lblCapturedColor = new System.Windows.Forms.Label();
            this.txtG = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.label2 = new System.Windows.Forms.Label();
            this.txtR = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtA = new _INNO._UI.InnoTextBoxColoredPlaceholder();
            this.colorPicker = new _INNO._UI.InnoPictureBoxColorPicker();
            this.innoGroupBoxBorder2.SuspendLayout();
            this.innoGroupBoxBorder1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // innoGroupBoxBorder2
            // 
            this.innoGroupBoxBorder2.BorderColor = System.Drawing.Color.Black;
            this.innoGroupBoxBorder2.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.innoGroupBoxBorder2.BorderWidth = 2;
            this.innoGroupBoxBorder2.Controls.Add(this.label5);
            this.innoGroupBoxBorder2.Controls.Add(this.txtColorRGB);
            this.innoGroupBoxBorder2.Location = new System.Drawing.Point(188, 188);
            this.innoGroupBoxBorder2.Name = "innoGroupBoxBorder2";
            this.innoGroupBoxBorder2.Size = new System.Drawing.Size(266, 170);
            this.innoGroupBoxBorder2.TabIndex = 15;
            this.innoGroupBoxBorder2.TabStop = false;
            this.innoGroupBoxBorder2.Text = "Captured Color";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Color(R,G,B)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtColorRGB
            // 
            this.txtColorRGB.BackColor = System.Drawing.SystemColors.Window;
            this.txtColorRGB.BorderColor = System.Drawing.Color.Lime;
            this.txtColorRGB.BorderFocusColor = System.Drawing.Color.Black;
            this.txtColorRGB.BorderRadius = 7;
            this.txtColorRGB.BorderSize = 2;
            this.txtColorRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorRGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtColorRGB.Location = new System.Drawing.Point(119, 17);
            this.txtColorRGB.Margin = new System.Windows.Forms.Padding(4);
            this.txtColorRGB.Multiline = false;
            this.txtColorRGB.Name = "txtColorRGB";
            this.txtColorRGB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtColorRGB.PasswordChar = false;
            this.txtColorRGB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtColorRGB.PlaceholderText = "";
            this.txtColorRGB.ReadOnly = false;
            this.txtColorRGB.Size = new System.Drawing.Size(139, 31);
            this.txtColorRGB.TabIndex = 14;
            this.txtColorRGB.Text = "255, 255, 255";
            this.txtColorRGB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtColorRGB.UnderlinedStyle = false;
            // 
            // innoGroupBoxBorder1
            // 
            this.innoGroupBoxBorder1.BorderColor = System.Drawing.Color.Black;
            this.innoGroupBoxBorder1.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.innoGroupBoxBorder1.BorderWidth = 2;
            this.innoGroupBoxBorder1.Controls.Add(this.label1);
            this.innoGroupBoxBorder1.Controls.Add(this.txtB);
            this.innoGroupBoxBorder1.Controls.Add(this.lblCapturedColor);
            this.innoGroupBoxBorder1.Controls.Add(this.txtG);
            this.innoGroupBoxBorder1.Controls.Add(this.label2);
            this.innoGroupBoxBorder1.Controls.Add(this.txtR);
            this.innoGroupBoxBorder1.Controls.Add(this.label3);
            this.innoGroupBoxBorder1.Controls.Add(this.label4);
            this.innoGroupBoxBorder1.Controls.Add(this.txtA);
            this.innoGroupBoxBorder1.Location = new System.Drawing.Point(188, 12);
            this.innoGroupBoxBorder1.Name = "innoGroupBoxBorder1";
            this.innoGroupBoxBorder1.Size = new System.Drawing.Size(266, 170);
            this.innoGroupBoxBorder1.TabIndex = 15;
            this.innoGroupBoxBorder1.TabStop = false;
            this.innoGroupBoxBorder1.Text = "Captured Color";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.SystemColors.Window;
            this.txtB.BorderColor = System.Drawing.Color.Blue;
            this.txtB.BorderFocusColor = System.Drawing.Color.Black;
            this.txtB.BorderRadius = 7;
            this.txtB.BorderSize = 2;
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtB.Location = new System.Drawing.Point(62, 131);
            this.txtB.Margin = new System.Windows.Forms.Padding(4);
            this.txtB.Multiline = false;
            this.txtB.Name = "txtB";
            this.txtB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtB.PasswordChar = false;
            this.txtB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtB.PlaceholderText = "";
            this.txtB.ReadOnly = false;
            this.txtB.Size = new System.Drawing.Size(80, 31);
            this.txtB.TabIndex = 14;
            this.txtB.Text = "255";
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtB.UnderlinedStyle = false;
            // 
            // lblCapturedColor
            // 
            this.lblCapturedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCapturedColor.Location = new System.Drawing.Point(149, 53);
            this.lblCapturedColor.Name = "lblCapturedColor";
            this.lblCapturedColor.Size = new System.Drawing.Size(109, 109);
            this.lblCapturedColor.TabIndex = 4;
            this.lblCapturedColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtG
            // 
            this.txtG.BackColor = System.Drawing.SystemColors.Window;
            this.txtG.BorderColor = System.Drawing.Color.Green;
            this.txtG.BorderFocusColor = System.Drawing.Color.Black;
            this.txtG.BorderRadius = 7;
            this.txtG.BorderSize = 2;
            this.txtG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtG.Location = new System.Drawing.Point(62, 92);
            this.txtG.Margin = new System.Windows.Forms.Padding(4);
            this.txtG.Multiline = false;
            this.txtG.Name = "txtG";
            this.txtG.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtG.PasswordChar = false;
            this.txtG.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtG.PlaceholderText = "";
            this.txtG.ReadOnly = false;
            this.txtG.Size = new System.Drawing.Size(80, 31);
            this.txtG.TabIndex = 14;
            this.txtG.Text = "255";
            this.txtG.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtG.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "R";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtR
            // 
            this.txtR.BackColor = System.Drawing.SystemColors.Window;
            this.txtR.BorderColor = System.Drawing.Color.Red;
            this.txtR.BorderFocusColor = System.Drawing.Color.Black;
            this.txtR.BorderRadius = 7;
            this.txtR.BorderSize = 2;
            this.txtR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtR.Location = new System.Drawing.Point(62, 53);
            this.txtR.Margin = new System.Windows.Forms.Padding(4);
            this.txtR.Multiline = false;
            this.txtR.Name = "txtR";
            this.txtR.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtR.PasswordChar = false;
            this.txtR.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtR.PlaceholderText = "";
            this.txtR.ReadOnly = false;
            this.txtR.Size = new System.Drawing.Size(80, 31);
            this.txtR.TabIndex = 14;
            this.txtR.Text = "255";
            this.txtR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtR.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "G";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(6, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "B";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.SystemColors.Window;
            this.txtA.BorderColor = System.Drawing.Color.Transparent;
            this.txtA.BorderFocusColor = System.Drawing.Color.Yellow;
            this.txtA.BorderRadius = 7;
            this.txtA.BorderSize = 2;
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtA.Location = new System.Drawing.Point(62, 17);
            this.txtA.Margin = new System.Windows.Forms.Padding(4);
            this.txtA.Multiline = false;
            this.txtA.Name = "txtA";
            this.txtA.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtA.PasswordChar = false;
            this.txtA.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtA.PlaceholderText = "";
            this.txtA.ReadOnly = false;
            this.txtA.Size = new System.Drawing.Size(80, 31);
            this.txtA.TabIndex = 14;
            this.txtA.Text = "255";
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtA.UnderlinedStyle = false;
            // 
            // colorPicker
            // 
            this.colorPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPicker.CaptureInterval = 100;
            this.colorPicker.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker.Image")));
            this.colorPicker.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            this.colorPicker.Location = new System.Drawing.Point(12, 12);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(170, 170);
            this.colorPicker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorPicker.StartCapture = false;
            this.colorPicker.TabIndex = 7;
            this.colorPicker.TabStop = false;
            this.colorPicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.colorPicker_MouseDown);
            this.colorPicker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.colorPicker_MouseUp);
            // 
            // Form_99_ColorPicker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.innoGroupBoxBorder2);
            this.Controls.Add(this.innoGroupBoxBorder1);
            this.Controls.Add(this.colorPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_99_ColorPicker";
            this.innoGroupBoxBorder2.ResumeLayout(false);
            this.innoGroupBoxBorder1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCapturedColor;
        private _INNO._UI.InnoPictureBoxColorPicker colorPicker;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtR;
        private System.Windows.Forms.Label label3;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtG;
        private System.Windows.Forms.Label label4;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtB;
        private _INNO._UI.InnoGroupBoxBorder innoGroupBoxBorder1;
        private _INNO._UI.InnoGroupBoxBorder innoGroupBoxBorder2;
        private System.Windows.Forms.Label label5;
        private _INNO._UI.InnoTextBoxColoredPlaceholder txtColorRGB;
    }
}