using System; // 引入基本系統功能，例如日期與時間操作
using System.Collections.Generic; // 用於操作 List 等集合
using System.Net.Http; // 用於發送 HTTP 請求
using System.Text; // 提供字串編碼功能
using System.Threading.Tasks; // 用於處理異步作業
using Newtonsoft.Json; // 用於 JSON 序列化與反序列化

namespace GameSystem // 定義命名空間，包含相關類別
{
    public static class ApiClient // 定義靜態類別，負責與 MockAPI.io 交互
    {
        // 請把 YOUR_SUBDOMAIN 換成你在 MockAPI.io 設定的子域名稱
        // 例如：https://gamesystem123.mockapi.io/api/v1/scores
        private static readonly string BaseUrl = "https://684023c55b39a8039a56f11d.mockapi.io/scores";

        // 建立 HttpClient 實例，共用可提升效能
        private static readonly HttpClient client = new HttpClient();

        /// <summary>
        /// 提交本局分數：
        /// 如果該 username 已存在，就用 PUT 更新該筆紀錄；
        /// 如果不存在則用 POST 新增新紀錄。
        /// </summary>
        public static async Task<bool> SubmitScoreAsync(string username, int score)
        {
            try
            {
                // 1. 先 GET 取得所有紀錄，避免依賴 API 查詢參數過濾的不確定性
                HttpResponseMessage getResp = await client.GetAsync(BaseUrl);
                getResp.EnsureSuccessStatusCode(); // 確保 GET 請求成功
                string jsonList = await getResp.Content.ReadAsStringAsync(); // 讀取回傳的 JSON 資料

                // 2. 將 JSON 反序列化為 List<WorldScore>
                var allRecords = JsonConvert.DeserializeObject<List<WorldScore>>(jsonList)
                                 ?? new List<WorldScore>();

                // 3. 在本地檢查是否有符合 username 的紀錄（採用不區分大小寫比對，可依需求調整）
                var existingRecord = allRecords.Find(r =>
                    string.Equals(r.username, username, StringComparison.OrdinalIgnoreCase)
                );

                // 4. 建立要送出的 JSON payload（不論是 PUT 或 POST 的資料內容相同）
                var payload = new
                {
                    username = username,
                    score = score,
                    timestamp = DateTime.UtcNow.ToString("o") // ISO 8601 格式時間字串
                };
                string jsonPayload = JsonConvert.SerializeObject(payload);
                var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                // 5. 根據是否找到紀錄來決定走 PUT 還是 POST
                if (existingRecord != null)
                {
                    // 如果找到該使用者，則更新該筆紀錄（PUT /scores/{id}）
                    HttpResponseMessage putResp = await client.PutAsync($"{BaseUrl}/{existingRecord.id}", content);
                    return putResp.IsSuccessStatusCode;
                }
                else
                {
                    // 如果不存在紀錄，則使用 POST 新增一筆
                    HttpResponseMessage postResp = await client.PostAsync(BaseUrl, content);
                    return postResp.IsSuccessStatusCode;
                }
            }
            catch
            {
                // 任何錯誤（例如網路或解析錯誤）皆回傳 false
                return false;
            }
        }

        /// <summary>
        /// 取得目前 MockAPI 上的所有分數，並依分數由高到低排序後傳回
        /// </summary>
        public static async Task<List<WorldScore>> GetAllScoresAsync()
        {
            try
            {
                // 發送 GET 請求取得全部紀錄
                HttpResponseMessage resp = await client.GetAsync(BaseUrl);
                resp.EnsureSuccessStatusCode();
                string json = await resp.Content.ReadAsStringAsync();

                // 將回傳的 JSON 轉換為 List<WorldScore>
                var allScores = JsonConvert.DeserializeObject<List<WorldScore>>(json)
                                ?? new List<WorldScore>();

                // 根據分數對列表進行排序，分數越高者排越前
                allScores.Sort((a, b) => b.score.CompareTo(a.score));
                return allScores;
            }
            catch
            {
                // 若有例外則回傳空列表
                return new List<WorldScore>();
            }
        }
    }

    /// <summary>
    /// 定義 WorldScore 類別，以對應 MockAPI.io 回傳的 JSON 結構
    /// </summary>
    public class WorldScore
    {
        public string id { get; set; }         // 紀錄的唯一 ID
        public string username { get; set; }   // 使用者名稱
        public int score { get; set; }         // 使用者分數
        public string timestamp { get; set; }  // 提交時間（ISO 8601 格式）
    }
}



