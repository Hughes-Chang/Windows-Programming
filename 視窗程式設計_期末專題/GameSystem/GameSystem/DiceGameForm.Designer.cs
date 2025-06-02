namespace GameSystem
{
    partial class DiceGameForm
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
            this.lblDicePlayer = new System.Windows.Forms.Label();
            this.lblDiceComputer = new System.Windows.Forms.Label();
            this.btnDiceRoll = new System.Windows.Forms.Button();
            this.lblDiceResult = new System.Windows.Forms.Label();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDicePlayer
            // 
            this.lblDicePlayer.AutoSize = true;
            this.lblDicePlayer.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblDicePlayer.Location = new System.Drawing.Point(30, 30);
            this.lblDicePlayer.Name = "lblDicePlayer";
            this.lblDicePlayer.Size = new System.Drawing.Size(112, 25);
            this.lblDicePlayer.TabIndex = 0;
            this.lblDicePlayer.Text = "玩家點數：";
            // 
            // lblDiceComputer
            // 
            this.lblDiceComputer.AutoSize = true;
            this.lblDiceComputer.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblDiceComputer.Location = new System.Drawing.Point(30, 70);
            this.lblDiceComputer.Name = "lblDiceComputer";
            this.lblDiceComputer.Size = new System.Drawing.Size(112, 25);
            this.lblDiceComputer.TabIndex = 1;
            this.lblDiceComputer.Text = "電腦點數：";
            // 
            // btnDiceRoll
            // 
            this.btnDiceRoll.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnDiceRoll.Location = new System.Drawing.Point(30, 120);
            this.btnDiceRoll.Name = "btnDiceRoll";
            this.btnDiceRoll.Size = new System.Drawing.Size(240, 40);
            this.btnDiceRoll.TabIndex = 2;
            this.btnDiceRoll.Text = "擲骰子";
            this.btnDiceRoll.UseVisualStyleBackColor = true;
            this.btnDiceRoll.Click += new System.EventHandler(this.btnDiceRoll_Click);
            // 
            // lblDiceResult
            // 
            this.lblDiceResult.AutoSize = true;
            this.lblDiceResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.lblDiceResult.Location = new System.Drawing.Point(30, 180);
            this.lblDiceResult.Name = "lblDiceResult";
            this.lblDiceResult.Size = new System.Drawing.Size(58, 25);
            this.lblDiceResult.TabIndex = 3;
            this.lblDiceResult.Text = "結果";
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnBackToMenu.Location = new System.Drawing.Point(200, 260);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(100, 30);
            this.btnBackToMenu.TabIndex = 4;
            this.btnBackToMenu.Text = "返回主選單";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // DiceGameForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 320);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.lblDiceResult);
            this.Controls.Add(this.btnDiceRoll);
            this.Controls.Add(this.lblDiceComputer);
            this.Controls.Add(this.lblDicePlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DiceGameForm";
            this.Text = "骰子比大小";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDicePlayer;
        private System.Windows.Forms.Label lblDiceComputer;
        private System.Windows.Forms.Button btnDiceRoll;
        private System.Windows.Forms.Label lblDiceResult;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}
