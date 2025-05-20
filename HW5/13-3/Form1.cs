namespace _13_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblLight_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblLight.BackColor = Color.Yellow;
                lblLight.Text = "¶À¿O";
            }
            else if (e.Button == MouseButtons.Right)
            {
                lblLight.BackColor = Color.Green;
                lblLight.Text = "ºñ¿O";
            }
        }
    }
}
