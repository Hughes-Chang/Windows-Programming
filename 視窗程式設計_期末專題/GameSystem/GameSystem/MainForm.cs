using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GameSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // 顯示歡迎字串
            lblWelcome.Text = $"歡迎，{GameData.CurrentUser.Username}！當前分數：{GameData.CurrentUser.Score}";
        }

        private void btnDice_Click(object sender, EventArgs e)
        {
            this.Hide();
            DiceGameForm diceForm = new DiceGameForm();
            diceForm.ShowDialog();
            // 回到主選單時更新歡迎與分數
            lblWelcome.Text = $"歡迎，{GameData.CurrentUser.Username}！當前分數：{GameData.CurrentUser.Score}";
            this.Show();
        }

        private void btnRPS_Click(object sender, EventArgs e)
        {
            this.Hide();
            RPSGameForm rpsForm = new RPSGameForm();
            rpsForm.ShowDialog();
            lblWelcome.Text = $"歡迎，{GameData.CurrentUser.Username}！當前分數：{GameData.CurrentUser.Score}";
            this.Show();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScoreForm scoreForm = new ScoreForm();
            scoreForm.ShowDialog();
            this.Show();
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            this.Hide();
            RankingForm rankingForm = new RankingForm();
            rankingForm.ShowDialog();
            this.Show();
        }

        private void btnWorld_Click(object sender, EventArgs e)
        {
            this.Hide();
            new WorldRankingForm().ShowDialog();
            this.Show();

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // 清除 CurrentUser，回到登入畫面
            GameData.CurrentUser = null;
            this.Close();
        }
    }
}

