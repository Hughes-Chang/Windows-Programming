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
            this.lblTitle = new System.Windows.Forms.Label();
            this.picPlayerDice = new System.Windows.Forms.PictureBox();
            this.picComputerDice = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputerDice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(130, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "骰子比大小遊戲";
            // 
            // picPlayerDice
            // 
            this.picPlayerDice.Location = new System.Drawing.Point(40, 60);
            this.picPlayerDice.Name = "picPlayerDice";
            this.picPlayerDice.Size = new System.Drawing.Size(120, 120);
            this.picPlayerDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerDice.TabIndex = 1;
            this.picPlayerDice.TabStop = false;
            // 
            // picComputerDice
            // 
            this.picComputerDice.Location = new System.Drawing.Point(260, 60);
            this.picComputerDice.Name = "picComputerDice";
            this.picComputerDice.Size = new System.Drawing.Size(120, 120);
            this.picComputerDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComputerDice.TabIndex = 2;
            this.picComputerDice.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnRoll.Location = new System.Drawing.Point(140, 200);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(120, 40);
            this.btnRoll.TabIndex = 3;
            this.btnRoll.Text = "擲骰子";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(30, 260);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(350, 30);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "結果：";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnBack.Location = new System.Drawing.Point(300, 310);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "返回主選單";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // timer
            // 
            this.timer.Interval = 100; // 100ms 更新一次
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // DiceGameForm
            // 
            this.ClientSize = new System.Drawing.Size(420, 360);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.picComputerDice);
            this.Controls.Add(this.picPlayerDice);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DiceGameForm";
            this.Text = "骰子遊戲";
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputerDice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picPlayerDice;
        private System.Windows.Forms.PictureBox picComputerDice;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Timer timer;
    }
}
