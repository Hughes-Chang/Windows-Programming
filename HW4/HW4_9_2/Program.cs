namespace HW4_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 提示使用者輸入
            Console.Write("請輸入寬度 (Width): ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("請輸入高度 (Height): ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("請輸入長度 (Length): ");
            double length = Convert.ToDouble(Console.ReadLine());

            // 建立 Box 物件
            Box myBox = new Box(width, height, length);

            // 輸出體積與面積
            Console.WriteLine($"盒子的體積是: {myBox.Volume()}");
            Console.WriteLine($"盒子的表面積是: {myBox.Area()}");

            Console.ReadLine(); // 暫停畫面
        }
    }
}
