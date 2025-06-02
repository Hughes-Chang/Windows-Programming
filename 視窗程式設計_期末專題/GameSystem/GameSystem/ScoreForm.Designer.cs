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
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstScores
            // 
            this.lstScores.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lstScores.FormattingEnabled = true;
            this.lstScores.ItemHeight = 20;
            this.lstScores.Location = new System.Drawing.Point(20, 20);
            this.lstScores.Name = "lstScores";
            this.lstScores.Size = new System.Drawing.Size(360, 240);
            this.lstScores.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnClear.Location = new System.Drawing.Point(20, 280);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "清除紀錄";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnBackToMenu.Location = new System.Drawing.Point(260, 280);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(120, 35);
            this.btnBackToMenu.TabIndex = 2;
            this.btnBackToMenu.Text = "返回主選單";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // ScoreForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 340);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstScores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ScoreForm";
            this.Text = "分數紀錄";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lstScores;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}
