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
            // 1. �ŧi�}�C
            int[] numbers = new int[5];

            // 2. �ϥζüƲ��� 1~200 �����
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 201); // �W����201�A�]�� Next ���W���O���]�t��
            }

            // 3. �}�C�Ƨ�
            Array.Sort(numbers);

            // 4. ��ܦb���ҤW
            label1.Text = "�Ƨǫ᪺�}�C���e�G\n" + string.Join(", ", numbers);
        }
    }
}
