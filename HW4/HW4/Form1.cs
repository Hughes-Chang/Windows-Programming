namespace HW4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // 1. 宣告陣列
            int[] numbers = new int[5];

            // 2. 使用亂數產生 1~200 的整數
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 201); // 上限為201，因為 Next 的上限是不包含的
            }

            // 3. 陣列排序
            Array.Sort(numbers);

            // 4. 顯示在標籤上
            label1.Text = "排序後的陣列內容：\n" + string.Join(", ", numbers);
        }
    }
}
