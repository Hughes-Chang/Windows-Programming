using System;
using System.Windows.Forms;

namespace GameSystem
{
    public partial class DiceGameForm : Form
    {
        private Random rng = new Random();

        public DiceGameForm()
        {
            InitializeComponent();
        }

        private void btnDiceRoll_Click(object sender, EventArgs e)
        {
            int playerValue = rng.Next(1, 7);
            int computerValue = rng.Next(1, 7);

            lblDicePlayer.Text = $"玩家點數：{playerValue}";
            lblDiceComputer.Text = $"電腦點數：{computerValue}";

            string result;
            if (playerValue > computerValue)
                result = "玩家勝利！";
            else if (playerValue < computerValue)
                result = "電腦勝利！";
            else
                result = "平手";

            lblDiceResult.Text = $"結果：{result}";

            // 加入分數紀錄（格式：時間 + 遊戲名稱 + 結果）
            string record = $"{DateTime.Now:MM/dd HH:mm}  骰子遊戲：玩家 {playerValue} vs 電腦 {computerValue} → {result}";
            GameData.ScoreHistory.Add(record);
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

