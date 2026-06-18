using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlysinhvien
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
            // thay đổi style nhẹ để khác bản gốc
            this.Font = new Font("Segoe UI", 9F);
            TryTweakLoginUi();

            // Thiết lập runtime giúp UX: Enter để login
            this.AcceptButton = btnLogin;

            // Mask password nếu designer chưa bật
            try { txtPassword.UseSystemPasswordChar = true; } catch { }
        }

        private void TryTweakLoginUi()
        {
            try
            {
                // đổi màu nền nút, border, và placeholder text cho textbox (nếu có)
                foreach (Control c in this.Controls)
                {
                    if (c is Button btn)
                    {
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.BackColor = Color.FromArgb(235, 245, 255);
                    }
                }

                // dời nhẹ vị trí nút login xuống +3 để khác biệt
                btnLogin.Location = new Point(btnLogin.Location.X, btnLogin.Location.Y + 3);

                // thay text label hoặc FormText hiển thị khác chút
                this.Text = "Đăng nhập hệ thống - Quanlysinhvien";
            }
            catch { }
        }

        private class Student
        {
            public string Email { get; set; }
            public string MSSV { get; set; }
        }

        // Small in-memory list of students for demo purposes
        private readonly List<Student> students = new List<Student>
        {
            new Student { Email = "0010568@st.huce.edu.vn", MSSV = "0010568" }
        };

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text; // password equals MSSV in this simple example

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var found = students.FirstOrDefault(s => string.Equals(s.Email, username, System.StringComparison.OrdinalIgnoreCase)
                                                     && s.MSSV == password);

            if (found != null)
            {
                MessageBox.Show("Đăng nhập thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
