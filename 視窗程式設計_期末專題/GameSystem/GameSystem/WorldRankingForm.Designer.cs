namespace GameSystem
{
    partial class WorldRankingForm
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
            this.dgvWorld = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorld)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWorld
            // 
            this.dgvWorld.AllowUserToAddRows = false;
            this.dgvWorld.AllowUserToDeleteRows = false;
            this.dgvWorld.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorld.Location = new System.Drawing.Point(20, 20);
            this.dgvWorld.Name = "dgvWorld";
            this.dgvWorld.ReadOnly = true;
            this.dgvWorld.RowTemplate.Height = 27;
            this.dgvWorld.Size = new System.Drawing.Size(500, 300);
            this.dgvWorld.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnRefresh.Location = new System.Drawing.Point(150, 340);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "重新整理";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnBack.Location = new System.Drawing.Point(300, 340);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 35);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "返回主選單";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // WorldRankingForm
            // 
            this.ClientSize = new System.Drawing.Size(540, 390);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvWorld);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "WorldRankingForm";
            this.Text = "世界排行榜";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorld)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWorld;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;
    }
}
