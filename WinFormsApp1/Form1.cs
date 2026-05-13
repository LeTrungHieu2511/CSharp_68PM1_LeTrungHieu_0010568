using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Student information provided by the user
        private const string ExpectedEmail = "trunghieule25112005@gmail.com";
        private const string ExpectedMSSV = "0010568";
        private const string StudentFullName = "Lê Trung Hiếu";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.Equals(username, ExpectedEmail, StringComparison.OrdinalIgnoreCase)
                && password == ExpectedMSSV)
            {
                MessageBox.Show("Đăng nhập thành công - " + StudentFullName, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
