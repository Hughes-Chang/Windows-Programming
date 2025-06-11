using System;
using System.Windows.Forms;

namespace GameSystem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        // 註冊按鈕
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string pwd = txtPassword.Text;
            string confirm = txtConfirm.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("請輸入帳號", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(pwd) || string.IsNullOrEmpty(confirm))
            {
                MessageBox.Show("請輸入密碼與確認密碼", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (pwd != confirm)
            {
                MessageBox.Show("兩次密碼不一致，請重新輸入", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtConfirm.Clear();
                return;
            }

            // 檢查帳號是否已存在
            if (GameData.FindUser(username) != null)
            {
                MessageBox.Show("此帳號已被註冊", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 新增會員
            User newUser = new User(username, pwd);
            GameData.AddUser(newUser);

            MessageBox.Show("註冊成功，請使用新帳號登入", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // 關閉註冊表單，回到登入
        }

        // 返回登入
        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
