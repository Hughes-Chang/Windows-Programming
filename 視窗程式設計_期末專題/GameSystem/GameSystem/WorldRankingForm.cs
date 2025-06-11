using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSystem
{
    public partial class WorldRankingForm : Form
    {
        public WorldRankingForm()
        {
            InitializeComponent();
            // 開啟視窗時就載入一次排名
            _ = LoadWorldRankingAsync();
        }

        // 點擊「重新整理」按鈕
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            _ = LoadWorldRankingAsync();
        }

        // 非同步從 REST API 取得世界排行並顯示
        private async Task LoadWorldRankingAsync()
        {
            try
            {
                var list = await ApiClient.GetAllScoresAsync();

                // 轉成 DataGridView 可顯示的結構
                var displayList = list.Select((ws, idx) => new
                {
                    Rank = idx + 1,
                    帳號 = ws.username,
                    積分 = ws.score,
                    時間 = ws.timestamp
                }).ToList();

                dgvWorld.DataSource = displayList;
                dgvWorld.Columns[0].HeaderText = "排名";
                dgvWorld.Columns[1].HeaderText = "帳號";
                dgvWorld.Columns[2].HeaderText = "積分";
                dgvWorld.Columns[3].HeaderText = "時間";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"無法取得世界排行榜：\r\n{ex.Message}",
                                "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnRefresh.Enabled = true;
            }
        }

        // 點擊「返回主選單」按鈕
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

