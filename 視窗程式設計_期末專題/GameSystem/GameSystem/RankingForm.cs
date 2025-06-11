using System;
using System.Linq;
using System.Windows.Forms;

namespace GameSystem
{
    public partial class RankingForm : Form
    {
        public RankingForm()
        {
            InitializeComponent();
            LoadRanking();
        }

        private void LoadRanking()
        {
            // 以 Score (勝-敗) 排序，從大到小
            var sorted = GameData.Users
                .OrderByDescending(u => u.Score)
                .Select((u, idx) => new
                {
                    Rank = idx + 1,
                    u.Username,
                    u.Wins,
                    u.Losses,
                    Score = u.Score
                })
                .ToList();

            dgvRanking.DataSource = sorted;
            dgvRanking.Columns["Rank"].HeaderText = "排名";
            dgvRanking.Columns["Username"].HeaderText = "帳號";
            dgvRanking.Columns["Wins"].HeaderText = "勝";
            dgvRanking.Columns["Losses"].HeaderText = "敗";
            dgvRanking.Columns["Score"].HeaderText = "積分";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

