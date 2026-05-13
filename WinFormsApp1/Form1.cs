using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Student information provided by the user
        private const string ExpectedEmail = "trunghieule25112005@gmail.com";
        private const string ExpectedMSSV = "0010568";
        private const string StudentFullName = "Lê Trung Hi?u";

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
                MessageBox.Show($"??ng nh?p thành công - {StudentFullName}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("??ng nh?p th?t b?i", "L?i", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
