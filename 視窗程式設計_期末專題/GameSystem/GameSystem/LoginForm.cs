using System;
using System.Windows.Forms;

namespace GameSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // 登入按鈕
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("請輸入帳號與密碼", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 載入使用者清單 (已於 GameData static constructor 初始化)
            User user = GameData.FindUser(username);
            if (user == null)
            {
                MessageBox.Show("帳號不存在，請先註冊", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!user.VerifyPassword(password))
            {
                MessageBox.Show("密碼錯誤，請重新輸入", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                return;
            }

            // 登入成功
            GameData.CurrentUser = user;
            this.Hide(); // 隱藏登入表單
            MainForm main = new MainForm();
            main.ShowDialog();
            this.Close(); // 關閉登入窗體
        }

        // 前往註冊表單
        private void btnGoRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm reg = new RegisterForm();
            reg.ShowDialog();
            this.Show(); // 回到登入表單
        }
    }
}

