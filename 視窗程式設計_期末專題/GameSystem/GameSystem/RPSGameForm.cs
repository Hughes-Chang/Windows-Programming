using System;
using System.Windows.Forms;

namespace GameSystem
{
    public partial class RPSGameForm : Form
    {
        private Random rng = new Random();

        public RPSGameForm()
        {
            InitializeComponent();
        }

        private int GetComputerRPS()
        {
            return rng.Next(1, 4); // 1=石頭,2=剪刀,3=布
        }

        private string RPSValueToString(int v)
        {
            switch (v)
            {
                case 1: return "石頭";
                case 2: return "剪刀";
                case 3: return "布";
                default: return "？";
            }
        }

        private string DetermineRPSWinner(int player, int computer)
        {
            if (player == computer)
                return "平手";
            if ((player == 1 && computer == 2) ||
                (player == 2 && computer == 3) ||
                (player == 3 && computer == 1))
                return "玩家勝利！";
            else
                return "電腦勝利！";
        }

        private void btnRPSRock_Click(object sender, EventArgs e)
        {
            PlayRPS(1);
        }

        private void btnRPSScissors_Click(object sender, EventArgs e)
        {
            PlayRPS(2);
        }

        private void btnRPSPaper_Click(object sender, EventArgs e)
        {
            PlayRPS(3);
        }

        private void PlayRPS(int playerChoice)
        {
            int computerChoice = GetComputerRPS();

            lblRPSPlayerChoice.Text = $"玩家出：{RPSValueToString(playerChoice)}";
            lblRPSComputerChoice.Text = $"電腦出：{RPSValueToString(computerChoice)}";

            string result = DetermineRPSWinner(playerChoice, computerChoice);
            lblRPSResult.Text = $"結果：{result}";

            // 紀錄分數
            string record = $"{DateTime.Now:MM/dd HH:mm}  RPS遊戲：玩家 {RPSValueToString(playerChoice)} vs 電腦 {RPSValueToString(computerChoice)} → {result}";
            GameData.ScoreHistory.Add(record);
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

