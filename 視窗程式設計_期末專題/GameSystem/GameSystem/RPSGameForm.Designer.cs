namespace GameSystem
{
    partial class RPSGameForm
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
            this.btnRPSRock = new System.Windows.Forms.Button();
            this.btnRPSScissors = new System.Windows.Forms.Button();
            this.btnRPSPaper = new System.Windows.Forms.Button();
            this.lblRPSPlayerChoice = new System.Windows.Forms.Label();
            this.lblRPSComputerChoice = new System.Windows.Forms.Label();
            this.lblRPSResult = new System.Windows.Forms.Label();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRPSRock
            // 
            this.btnRPSRock.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnRPSRock.Location = new System.Drawing.Point(30, 30);
            this.btnRPSRock.Name = "btnRPSRock";
            this.btnRPSRock.Size = new System.Drawing.Size(100, 40);
            this.btnRPSRock.TabIndex = 0;
            this.btnRPSRock.Text = "石頭";
            this.btnRPSRock.UseVisualStyleBackColor = true;
            this.btnRPSRock.Click += new System.EventHandler(this.btnRPSRock_Click);
            // 
            // btnRPSScissors
            // 
            this.btnRPSScissors.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnRPSScissors.Location = new System.Drawing.Point(150, 30);
            this.btnRPSScissors.Name = "btnRPSScissors";
            this.btnRPSScissors.Size = new System.Drawing.Size(100, 40);
            this.btnRPSScissors.TabIndex = 1;
            this.btnRPSScissors.Text = "剪刀";
            this.btnRPSScissors.UseVisualStyleBackColor = true;
            this.btnRPSScissors.Click += new System.EventHandler(this.btnRPSScissors_Click);
            // 
            // btnRPSPaper
            // 
            this.btnRPSPaper.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnRPSPaper.Location = new System.Drawing.Point(270, 30);
            this.btnRPSPaper.Name = "btnRPSPaper";
            this.btnRPSPaper.Size = new System.Drawing.Size(100, 40);
            this.btnRPSPaper.TabIndex = 2;
            this.btnRPSPaper.Text = "布";
            this.btnRPSPaper.UseVisualStyleBackColor = true;
            this.btnRPSPaper.Click += new System.EventHandler(this.btnRPSPaper_Click);
            // 
            // lblRPSPlayerChoice
            // 
            this.lblRPSPlayerChoice.AutoSize = true;
            this.lblRPSPlayerChoice.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblRPSPlayerChoice.Location = new System.Drawing.Point(30, 100);
            this.lblRPSPlayerChoice.Name = "lblRPSPlayerChoice";
            this.lblRPSPlayerChoice.Size = new System.Drawing.Size(112, 25);
            this.lblRPSPlayerChoice.TabIndex = 3;
            this.lblRPSPlayerChoice.Text = "玩家出：－";
            // 
            // lblRPSComputerChoice
            // 
            this.lblRPSComputerChoice.AutoSize = true;
            this.lblRPSComputerChoice.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblRPSComputerChoice.Location = new System.Drawing.Point(30, 140);
            this.lblRPSComputerChoice.Name = "lblRPSComputerChoice";
            this.lblRPSComputerChoice.Size = new System.Drawing.Size(112, 25);
            this.lblRPSComputerChoice.TabIndex = 4;
            this.lblRPSComputerChoice.Text = "電腦出：－";
            // 
            // lblRPSResult
            // 
            this.lblRPSResult.AutoSize = true;
            this.lblRPSResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.lblRPSResult.Location = new System.Drawing.Point(30, 190);
            this.lblRPSResult.Name = "lblRPSResult";
            this.lblRPSResult.Size = new System.Drawing.Size(58, 25);
            this.lblRPSResult.TabIndex = 5;
            this.lblRPSResult.Text = "結果";
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnBackToMenu.Location = new System.Drawing.Point(300, 260);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(100, 30);
            this.btnBackToMenu.TabIndex = 6;
            this.btnBackToMenu.Text = "返回主選單";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // RPSGameForm
            // 
            this.ClientSize = new System.Drawing.Size(420, 320);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.lblRPSResult);
            this.Controls.Add(this.lblRPSComputerChoice);
            this.Controls.Add(this.lblRPSPlayerChoice);
            this.Controls.Add(this.btnRPSPaper);
            this.Controls.Add(this.btnRPSScissors);
            this.Controls.Add(this.btnRPSRock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RPSGameForm";
            this.Text = "剪刀石頭布";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnRPSRock;
        private System.Windows.Forms.Button btnRPSScissors;
        private System.Windows.Forms.Button btnRPSPaper;
        private System.Windows.Forms.Label lblRPSPlayerChoice;
        private System.Windows.Forms.Label lblRPSComputerChoice;
        private System.Windows.Forms.Label lblRPSResult;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}
