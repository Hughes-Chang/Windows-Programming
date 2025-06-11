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
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.lblInfo.Location = new System.Drawing.Point(20, 20);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(380, 260);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "骰子與剪刀石頭布遊戲系統說明：\r\n\r\n- 會員可註冊、登入\r\n- 登入後即可進行骰子與剪刀石頭布遊戲\r\n- 遊戲結果會儲存於本機與會員資料中\r\n- 可查看本機分數紀錄、單機排行榜\r\n- 可上傳至世界排行榜 (需有網路連結)\r\n\r\n作者：張旭鋒、吳怡萱\r\n版本：1.0";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnBack.Location = new System.Drawing.Point(300, 300);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 35);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "返回主選單";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AboutForm
            // 
            this.ClientSize = new System.Drawing.Size(420, 360);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.Text = "說明";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnBack;
    }
}
