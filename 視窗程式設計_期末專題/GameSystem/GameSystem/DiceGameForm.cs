using System;                   // Random, DateTime
using System.Drawing;           // Image
using System.Windows.Forms;     // Form, Timer, MessageBox
using GameSystem.Properties;    // 讓 Resources.xxx 能被正確找出

namespace GameSystem
{
    public partial class DiceGameForm : Form
    {
        private Random rng = new Random();
        private int playerValue, computerValue;
        private int tickCount;
        private const int MaxTicks = 10;

        public DiceGameForm()
        {
            InitializeComponent();

            // 一開始先顯示 dice1 圖
            picPlayerDice.Image = Resources.dice1;
            picComputerDice.Image = Resources.dice1;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            btnRoll.Enabled = false;     // 按下後先鎖住按鈕
            lblResult.Text = "結果：";
            tickCount = 0;
            timer.Start();               // 啟動動畫 Timer
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tickCount++;

            // 動畫階段：隨機閃爍 1~6 點
            int pTemp = rng.Next(1, 7);
            int cTemp = rng.Next(1, 7);

            picPlayerDice.Image = (Image)
                Resources.ResourceManager.GetObject($"dice{pTemp}");
            picComputerDice.Image = (Image)
                Resources.ResourceManager.GetObject($"dice{cTemp}");

            if (tickCount >= MaxTicks)
            {
                timer.Stop();

                // 真正遊戲結果
                playerValue = rng.Next(1, 7);
                computerValue = rng.Next(1, 7);

                // 顯示玩家最終點數圖片
                picPlayerDice.Image = (Image)
                    Resources.ResourceManager.GetObject($"dice{playerValue}");
                // 顯示電腦最終點數圖片
                picComputerDice.Image = (Image)
                    Resources.ResourceManager.GetObject($"dice{computerValue}");

                string result;
                if (playerValue > computerValue)
                {
                    result = "玩家勝利！";
                    GameData.CurrentUser.Wins++;
                }
                else if (playerValue < computerValue)
                {
                    result = "電腦勝利！";
                    GameData.CurrentUser.Losses++;
                }
                else
                {
                    result = "平手";
                }

                lblResult.Text = $"結果：{result}";

                // 紀錄本地遊戲歷史
                string record = $"{DateTime.Now:MM/dd HH:mm} 骰子：玩家 {playerValue} vs 電腦 {computerValue} → {result}";
                GameData.ScoreHistory.Add(record);

                // 更新會員資料到 JSON
                GameData.SaveUsers();

                // (在現有判定勝負、GameData.CurrentUser.Wins++/Losses++、SaveUsers() 之後，新增以下)
                // 非同步上傳最新分數到世界排行 (不要等回傳，Fire‐and‐forget)
                _ = ApiClient.SubmitScoreAsync(GameData.CurrentUser.Username, GameData.CurrentUser.Score);


                btnRoll.Enabled = true;  // 解鎖按鈕
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // 返回主選單
        }
    }
}



