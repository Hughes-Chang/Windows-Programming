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

        // �Ǧ^�̤p��
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

        // �Ǧ^�̤j��
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
                // �q TextBox ���o 6 �Ӿ��
                int[] numbers = new int[6];
                numbers[0] = int.Parse(textBox1.Text);
                numbers[1] = int.Parse(textBox2.Text);
                numbers[2] = int.Parse(textBox3.Text);
                numbers[3] = int.Parse(textBox4.Text);
                numbers[4] = int.Parse(textBox5.Text);
                numbers[5] = int.Parse(textBox6.Text);

                // �p��̤j�̤p��
                int min = arrMin(numbers);
                int max = arrMax(numbers);

                // ��ܵ��G
                lblMin.Text = $"�̤p�ȡG{min}";
                lblMax.Text = $"�̤j�ȡG{max}";
            }
            catch
            {
                MessageBox.Show("�п�J���Ī���ơI");
            }
        }
    }
}
