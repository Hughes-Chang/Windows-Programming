namespace GameSystem
{
    partial class MainForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnDice = new System.Windows.Forms.Button();
            this.btnRPS = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnRanking = new System.Windows.Forms.Button();
            this.btnWorld = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(400, 30);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "歡迎, User";
            // 
            // btnDice
            // 
            this.btnDice.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnDice.Location = new System.Drawing.Point(30, 70);
            this.btnDice.Name = "btnDice";
            this.btnDice.Size = new System.Drawing.Size(180, 40);
            this.btnDice.TabIndex = 1;
            this.btnDice.Text = "骰子比大小";
            this.btnDice.UseVisualStyleBackColor = true;
            this.btnDice.Click += new System.EventHandler(this.btnDice_Click);
            // 
            // btnRPS
            // 
            this.btnRPS.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnRPS.Location = new System.Drawing.Point(240, 70);
            this.btnRPS.Name = "btnRPS";
            this.btnRPS.Size = new System.Drawing.Size(180, 40);
            this.btnRPS.TabIndex = 2;
            this.btnRPS.Text = "剪刀石頭布";
            this.btnRPS.UseVisualStyleBackColor = true;
            this.btnRPS.Click += new System.EventHandler(this.btnRPS_Click);
            // 
            // btnScore
            // 
            this.btnScore.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnScore.Location = new System.Drawing.Point(30, 130);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(180, 40);
            this.btnScore.TabIndex = 3;
            this.btnScore.Text = "本機分數紀錄";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnRanking
            // 
            this.btnRanking.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnRanking.Location = new System.Drawing.Point(240, 130);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(180, 40);
            this.btnRanking.TabIndex = 4;
            this.btnRanking.Text = "單機排行榜";
            this.btnRanking.UseVisualStyleBackColor = true;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // btnWorld
            // 
            this.btnWorld.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnWorld.Location = new System.Drawing.Point(30, 190);
            this.btnWorld.Name = "btnWorld";
            this.btnWorld.Size = new System.Drawing.Size(180, 40);
            this.btnWorld.TabIndex = 5;
            this.btnWorld.Text = "世界排行榜";
            this.btnWorld.UseVisualStyleBackColor = true;
            this.btnWorld.Click += new System.EventHandler(this.btnWorld_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnAbout.Location = new System.Drawing.Point(240, 190);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(180, 40);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "說明";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnLogout.Location = new System.Drawing.Point(140, 250);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 40);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "登出";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnWorld);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnRPS);
            this.Controls.Add(this.btnDice);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "主選單";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnDice;
        private System.Windows.Forms.Button btnRPS;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Button btnWorld;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnLogout;
    }
}
