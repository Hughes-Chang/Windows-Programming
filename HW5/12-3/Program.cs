//為符合題目要求，新增InchesToInches()方法，使輸入英吋可輸出英吋

using System;

namespace UnitConverter
{
    class Program
    {
        // 定義委派型別
        delegate double ConvertToInches(double value);

        // 方法：英尺轉英吋
        static double FeetToInches(double feet)
        {
            return feet * 12;
        }

        // 方法：英碼轉英吋
        static double YardsToInches(double yards)
        {
            return yards * 3 * 12;
        }

        // 方法：英吋轉英吋（保持不變）
        static double InchesToInches(double inches)
        {
            return inches;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("請輸入英吋數值：");
            double inputInches;
            if (!double.TryParse(Console.ReadLine(), out inputInches))
            {
                Console.WriteLine("輸入無效，請輸入數字。");
                return;
            }

            Console.WriteLine("\n請選擇要轉換的單位：");
            Console.WriteLine("1. 轉換為英吋（保持原樣）");
            Console.WriteLine("2. 轉換為英尺");
            Console.WriteLine("3. 轉換為英碼");
            Console.Write("請輸入選項 (1~3)：");

            string option = Console.ReadLine();
            ConvertToInches converter;

            switch (option)
            {
                case "1":
                    converter = InchesToInches;
                    break;
                case "2":
                    converter = inches => inches / 12; // 反向轉換
                    break;
                case "3":
                    converter = inches => inches / (3 * 12); // 反向轉換
                    break;
                default:
                    Console.WriteLine("無效的選項");
                    return;
            }

            double result = converter(inputInches);
            string unit = option == "1" ? "英吋" : (option == "2" ? "英尺" : "英碼");

            Console.WriteLine($"\n轉換結果：{result} {unit}");
        }
    }
}
