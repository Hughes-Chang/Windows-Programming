namespace HW4_9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 建立 PhoneList 物件
            PhoneList phoneList = new PhoneList("02-12345678", "03-87654321", "0912-345678");

            // 建立 Cards 物件
            Cards myCard = new Cards("林小旭", "軟體工程師", 25, phoneList, "xiao.xu@example.com");

            // 印出名片資料
            Console.WriteLine(myCard.GetCard());

            Console.ReadLine(); // 暫停畫面
        }
    }
}
