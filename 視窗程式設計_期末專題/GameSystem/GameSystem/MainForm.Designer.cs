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
            this.btnToDice = new System.Windows.Forms.Button();
            this.btnToRPS = new System.Windows.Forms.Button();
            this.btnToScore = new System.Windows.Forms.Button();
            this.btnToAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToDice
            // 
            this.btnToDice.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnToDice.Location = new System.Drawing.Point(40, 30);
            this.btnToDice.Name = "btnToDice";
            this.btnToDice.Size = new System.Drawing.Size(200, 40);
            this.btnToDice.TabIndex = 0;
            this.btnToDice.Text = "骰子比大小";
            this.btnToDice.UseVisualStyleBackColor = true;
            this.btnToDice.Click += new System.EventHandler(this.btnToDice_Click);
            // 
            // btnToRPS
            // 
            this.btnToRPS.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnToRPS.Location = new System.Drawing.Point(40, 90);
            this.btnToRPS.Name = "btnToRPS";
            this.btnToRPS.Size = new System.Drawing.Size(200, 40);
            this.btnToRPS.TabIndex = 1;
            this.btnToRPS.Text = "剪刀石頭布";
            this.btnToRPS.UseVisualStyleBackColor = true;
            this.btnToRPS.Click += new System.EventHandler(this.btnToRPS_Click);
            // 
            // btnToScore
            // 
            this.btnToScore.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnToScore.Location = new System.Drawing.Point(40, 150);
            this.btnToScore.Name = "btnToScore";
            this.btnToScore.Size = new System.Drawing.Size(200, 40);
            this.btnToScore.TabIndex = 2;
            this.btnToScore.Text = "分數紀錄";
            this.btnToScore.UseVisualStyleBackColor = true;
            this.btnToScore.Click += new System.EventHandler(this.btnToScore_Click);
            // 
            // btnToAbout
            // 
            this.btnToAbout.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnToAbout.Location = new System.Drawing.Point(40, 210);
            this.btnToAbout.Name = "btnToAbout";
            this.btnToAbout.Size = new System.Drawing.Size(200, 40);
            this.btnToAbout.TabIndex = 3;
            this.btnToAbout.Text = "說　　明";
            this.btnToAbout.UseVisualStyleBackColor = true;
            this.btnToAbout.Click += new System.EventHandler(this.btnToAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnExit.Location = new System.Drawing.Point(40, 270);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "離　　開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(280, 350);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnToAbout);
            this.Controls.Add(this.btnToScore);
            this.Controls.Add(this.btnToRPS);
            this.Controls.Add(this.btnToDice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "遊戲主選單";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnToDice;
        private System.Windows.Forms.Button btnToRPS;
        private System.Windows.Forms.Button btnToScore;
        private System.Windows.Forms.Button btnToAbout;
        private System.Windows.Forms.Button btnExit;
    }
}

