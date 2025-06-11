using System;
using System.Security.Cryptography;
using System.Text;

namespace GameSystem
{
    public class User2
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }  // 存放雜湊後的密碼
        public int Wins { get; set; }             // 總勝場數
        public int Losses { get; set; }           // 總敗場數

        /// <summary>
        /// 計算並取得積分：勝數 - 敗數
        /// </summary>
        public int Score
        {
            get { return Wins - Losses; }
        }

        public User2() { }

        public User2(string username, string password)
        {
            Username = username;
            PasswordHash = HashPassword(password);
            Wins = 0;
            Losses = 0;
        }

        /// <summary>
        /// 使用 SHA256 進行密碼雜湊
        /// </summary>
        public static string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha.ComputeHash(inputBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        /// <summary>
        /// 驗證輸入的明文密碼是否符合雜湊值
        /// </summary>
        public bool VerifyPassword(string password)
        {
            string hashed = HashPassword(password);
            return hashed == PasswordHash;
        }
    }
}