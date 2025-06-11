namespace GameSystem
{
    partial class ScoreForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lstScores = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstScores
            // 
            this.lstScores.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lstScores.FormattingEnabled = true;
            this.lstScores.ItemHeight = 20;
            this.lstScores.Location = new System.Drawing.Point(20, 20);
            this.lstScores.Name = "lstScores";
            this.lstScores.Size = new System.Drawing.Size(380, 260);
            this.lstScores.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnClear.Location = new System.Drawing.Point(20, 300);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "清除紀錄";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnBack.Location = new System.Drawing.Point(280, 300);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 35);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "返回主選單";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ScoreForm
            // 
            this.ClientSize = new System.Drawing.Size(420, 360);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstScores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ScoreForm";
            this.Text = "本地分數紀錄";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lstScores;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
    }
}
