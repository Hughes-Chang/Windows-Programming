using System.Collections.Generic;

namespace GameSystem
{
    public static class GameData
    {
        /// <summary>
        /// 用來存放所有局的結果字串，供 ScoreForm 顯示。
        /// </summary>
        public static List<string> ScoreHistory { get; } = new List<string>();
    }
}
