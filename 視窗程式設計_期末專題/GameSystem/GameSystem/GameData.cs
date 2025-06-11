using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GameSystem
{
    public static class GameData
    {
        // JSON 檔路徑（預設放在可執行檔同目錄的 "users.json"）
        public static readonly string UsersFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.json");

        // 所有會員資料
        public static List<User> Users { get; private set; } = new List<User>();

        // 當前已登入的會員
        public static User CurrentUser { get; set; } = null;

        // 本地遊戲歷史紀錄（每局顯示時間、遊戲、對戰結果）
        public static List<string> ScoreHistory { get; private set; } = new List<string>();

        static GameData()
        {
            // 啟動時自動載入 JSON
            LoadUsers();
        }

        /// <summary>
        /// 載入 users.json，如果不存在就建立空檔案
        /// </summary>
        public static void LoadUsers()
        {
            try
            {
                if (!File.Exists(UsersFile))
                {
                    // 建立空清單並寫入
                    Users = new List<User>();
                    File.WriteAllText(UsersFile, JsonConvert.SerializeObject(Users, Formatting.Indented));
                }
                else
                {
                    string json = File.ReadAllText(UsersFile);
                    Users = JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
                }
            }
            catch
            {
                Users = new List<User>();
            }
        }

        /// <summary>
        /// 儲存 Users 到 users.json
        /// </summary>
        public static void SaveUsers()
        {
            string json = JsonConvert.SerializeObject(Users, Formatting.Indented);
            File.WriteAllText(UsersFile, json);
        }

        /// <summary>
        /// 根據 Username 找到 User，如果不存在回傳 null
        /// </summary>
        public static User FindUser(string username)
        {
            return Users.FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// 新增一筆會員（假設已確定帳號不存在）
        /// </summary>
        public static void AddUser(User newUser)
        {
            Users.Add(newUser);
            SaveUsers();
        }
    }
}
