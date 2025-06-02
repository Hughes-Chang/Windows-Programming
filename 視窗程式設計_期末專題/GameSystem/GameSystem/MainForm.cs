using System;
using System.Windows.Forms;

namespace GameSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnToDice_Click(object sender, EventArgs e)
        {
            // 開啟骰子遊戲視窗
            using (var diceForm = new DiceGameForm())
            {
                diceForm.ShowDialog();
            }
        }

        private void btnToRPS_Click(object sender, EventArgs e)
        {
            // 開啟剪刀石頭布視窗
            using (var rpsForm = new RPSGameForm())
            {
                rpsForm.ShowDialog();
            }
        }

        private void btnToScore_Click(object sender, EventArgs e)
        {
            // 開啟分數紀錄視窗
            using (var scoreForm = new ScoreForm())
            {
                scoreForm.ShowDialog();
            }
        }

        private void btnToAbout_Click(object sender, EventArgs e)
        {
            // 開啟說明視窗
            using (var aboutForm = new AboutForm())
            {
                aboutForm.ShowDialog();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // 關閉整個應用程式
            Application.Exit();
        }
    }
}
