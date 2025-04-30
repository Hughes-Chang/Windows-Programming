using System;
using System.Windows.Forms;
namespace HW4_8_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 傳回最小值
        int arrMin(int[] arr)
        {
            int min = arr[0];
            foreach (int n in arr)
            {
                if (n < min)
                    min = n;
            }
            return min;
        }

        // 傳回最大值
        int arrMax(int[] arr)
        {
            int max = arr[0];
            foreach (int n in arr)
            {
                if (n > max)
                    max = n;
            }
            return max;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // 從 TextBox 取得 6 個整數
                int[] numbers = new int[6];
                numbers[0] = int.Parse(textBox1.Text);
                numbers[1] = int.Parse(textBox2.Text);
                numbers[2] = int.Parse(textBox3.Text);
                numbers[3] = int.Parse(textBox4.Text);
                numbers[4] = int.Parse(textBox5.Text);
                numbers[5] = int.Parse(textBox6.Text);

                // 計算最大最小值
                int min = arrMin(numbers);
                int max = arrMax(numbers);

                // 顯示結果
                lblMin.Text = $"最小值：{min}";
                lblMax.Text = $"最大值：{max}";
            }
            catch
            {
                MessageBox.Show("請輸入有效的整數！");
            }
        }
    }
}
