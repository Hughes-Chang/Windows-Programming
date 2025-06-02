namespace GameSystem
{
    partial class AboutForm
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblInfo.Location = new System.Drawing.Point(20, 20);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(360, 200);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "骰子比大小與剪刀石頭布遊戲系統\r\n\r\n版本：1.0\r\n作者：張旭鋒、吳怡萱\r\n\r\n說明：\r\n1. 選擇骰子遊戲可以進行擲骰子比大小。\r\n2. 選擇剪刀石頭布可以與電腦對戰。\r\n3. 每局結果都會記錄在「分數紀錄」裡。\r\n4. 可隨時清除紀錄或返回主選單。";
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnBackToMenu.Location = new System.Drawing.Point(280, 260);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(100, 30);
            this.btnBackToMenu.TabIndex = 1;
            this.btnBackToMenu.Text = "返回主選單";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // AboutForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.Text = "說明";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}
