namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F)); // top spacer
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F)); // label username (increased)
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F)); // textbox username
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F)); // spacer between username and password (increased)
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F)); // label password (increased)
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F)); // textbox password
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F)); // remaining space (button area)
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 360);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.Text = "Email sinh viên";
            this.labelUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; // center vertically to avoid clipping
            this.labelUsername.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            // put label in center column (column index1)
            this.tableLayoutPanel1.Controls.Add(this.labelUsername, 1, 1);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.PlaceholderText = "Nhập email sinh viên";
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Margin = new System.Windows.Forms.Padding(0, 34, 0, 12); // increase top margin for more gap
            this.txtUsername.Padding = new System.Windows.Forms.Padding(8);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.MinimumSize = new System.Drawing.Size(0, 48);
            this.tableLayoutPanel1.Controls.Add(this.txtUsername, 1, 2);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Text = "MSSV";
            this.labelPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; // center vertically as well
            this.labelPassword.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPassword, 1, 4);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.PlaceholderText = "Nhập MSSV";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0, 34, 0, 12); // match username spacing
            this.txtPassword.Padding = new System.Windows.Forms.Padding(8);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.MinimumSize = new System.Drawing.Size(0, 48);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 5);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // make button snug to font
            this.btnLogin.AutoSize = true;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.btnLogin.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            // center the button by placing it inside a panel in the center column
            var buttonPanel = new System.Windows.Forms.Panel();
            buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            // add button to panel and center it
            buttonPanel.Controls.Add(this.btnLogin);
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.Controls.Add(buttonPanel, 1, 6);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 420);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
