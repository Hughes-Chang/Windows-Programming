using System;
using System.Drawing;
using System.Windows.Forms;
using GameSystem.Properties; // ← 這行告訴編譯器去 GameSystem.Properties 找 Resources

namespace GameSystem
{
    public partial class RPSGameForm : Form
    {
        private Random rng = new Random();
        private int playerChoice, computerChoice;
        private int tickCount;
        private const int MaxTicks = 10;

        public RPSGameForm()
        {
            InitializeComponent();
            // 初始先顯示預設圖：rock.png
            picPlayer.Image = Resources.rock;
            picComputer.Image = Resources.rock;
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            StartGame(1); // 1 代表石頭
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            StartGame(2); // 2 代表剪刀
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            StartGame(3); // 3 代表布
        }

        private void StartGame(int choice)
        {
            playerChoice = choice;
            btnRock.Enabled = false;
            btnScissors.Enabled = false;
            btnPaper.Enabled = false;
            lblResult.Text = "結果：";
            tickCount = 0;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tickCount++;

            // 動畫：隨機閃爍 rock/scissors/paper
            int cTemp = rng.Next(1, 4);
            picComputer.Image = (Image)Resources.ResourceManager.GetObject(
                cTemp == 1 ? "rock" :
                cTemp == 2 ? "scissors" : "paper");

            if (tickCount >= MaxTicks)
            {
                timer.Stop();
                computerChoice = rng.Next(1, 4);

                // 顯示玩家的圖
                picPlayer.Image = (Image)Resources.ResourceManager.GetObject(
                    playerChoice == 1 ? "rock" :
                    playerChoice == 2 ? "scissors" : "paper");

                // 顯示電腦的圖
                picComputer.Image = (Image)Resources.ResourceManager.GetObject(
                    computerChoice == 1 ? "rock" :
                    computerChoice == 2 ? "scissors" : "paper");

                // 判定勝負
                string result;
                if (playerChoice == computerChoice)
                {
                    result = "平手";
                }
                else if ((playerChoice == 1 && computerChoice == 2) ||
                         (playerChoice == 2 && computerChoice == 3) ||
                         (playerChoice == 3 && computerChoice == 1))
                {
                    result = "玩家勝利！";
                    GameData.CurrentUser.Wins++;
                }
                else
                {
                    result = "電腦勝利！";
                    GameData.CurrentUser.Losses++;
                }

                lblResult.Text = $"結果：{result}";

                // 記錄本地歷史
                string record = $"{DateTime.Now:MM/dd HH:mm} RPS：玩家 " +
                    (playerChoice == 1 ? "石頭" :
                     playerChoice == 2 ? "剪刀" : "布") +
                    $" vs 電腦 " +
                    (computerChoice == 1 ? "石頭" :
                     computerChoice == 2 ? "剪刀" : "布") +
                    $" → {result}";
                GameData.ScoreHistory.Add(record);

                // 更新會員 JSON
                GameData.SaveUsers();

                _ = ApiClient.SubmitScoreAsync(GameData.CurrentUser.Username, GameData.CurrentUser.Score);


                btnRock.Enabled = true;
                btnScissors.Enabled = true;
                btnPaper.Enabled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


