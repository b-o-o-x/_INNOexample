namespace INNOexample
{
    partial class CustomFormVirtual
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomFormVirtual));
            this.uiLblMemo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uiLblMemo
            // 
            this.uiLblMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLblMemo.BackColor = System.Drawing.Color.Black;
            this.uiLblMemo.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLblMemo.ForeColor = System.Drawing.Color.Gold;
            this.uiLblMemo.Location = new System.Drawing.Point(12, 9);
            this.uiLblMemo.Name = "uiLblMemo";
            this.uiLblMemo.Padding = new System.Windows.Forms.Padding(5);
            this.uiLblMemo.Size = new System.Drawing.Size(276, 282);
            this.uiLblMemo.TabIndex = 1;
            this.uiLblMemo.Text = resources.GetString("uiLblMemo.Text");
            // 
            // CustomFormVirtual
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.uiLblMemo);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomFormVirtual";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label uiLblMemo;
    }
}
