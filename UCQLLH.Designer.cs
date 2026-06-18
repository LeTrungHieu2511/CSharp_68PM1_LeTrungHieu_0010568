namespace Quanlysinhvien
{
    partial class UCQLLH
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_xemDanhSach = new System.Windows.Forms.Button();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_soBanGhi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_trangCuoi = new System.Windows.Forms.Button();
            this.lb_trang = new System.Windows.Forms.Label();
            this.btn_trangTruoc = new System.Windows.Forms.Button();
            this.btn_trangSau = new System.Windows.Forms.Button();
            this.btn_trangDau = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLopHoc = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbllophocsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlsv1DataSet = new Quanlysinhvien.qlsv1DataSet();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbl_lophocsTableAdapter = new Quanlysinhvien.qlsv1DataSetTableAdapters.tbl_lophocsTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllophocsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsv1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_xemDanhSach
            // 
            this.btn_xemDanhSach.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_xemDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xemDanhSach.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemDanhSach.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_xemDanhSach.Location = new System.Drawing.Point(5, 570);
            this.btn_xemDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xemDanhSach.Name = "btn_xemDanhSach";
            this.btn_xemDanhSach.Size = new System.Drawing.Size(491, 58);
            this.btn_xemDanhSach.TabIndex = 36;
            this.btn_xemDanhSach.Text = "Xem danh sách sinh viên";
            this.btn_xemDanhSach.UseVisualStyleBackColor = false;
            this.btn_xemDanhSach.Click += new System.EventHandler(this.btn_xemDanhSach_Click);
            // 
            // txtGhichu
            // 
            this.txtGhichu.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhichu.Location = new System.Drawing.Point(25, 284);
            this.txtGhichu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(440, 25);
            this.txtGhichu.TabIndex = 13;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Navy;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTim.Location = new System.Drawing.Point(860, 37);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(125, 44);
            this.btnTim.TabIndex = 33;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(531, 37);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(305, 22);
            this.txtTimKiem.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(527, 4);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "Tìm kiếm (Mã ID / Mã Lớp / Tên Lớp):";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLamMoi.Location = new System.Drawing.Point(258, 504);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(237, 58);
            this.btnLamMoi.TabIndex = 30;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Window;
            this.btnXoa.Location = new System.Drawing.Point(5, 504);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(237, 58);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSua.Location = new System.Drawing.Point(258, 426);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(237, 58);
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lb_soBanGhi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_trangCuoi);
            this.panel1.Controls.Add(this.lb_trang);
            this.panel1.Controls.Add(this.btn_trangTruoc);
            this.panel1.Controls.Add(this.btn_trangSau);
            this.panel1.Controls.Add(this.btn_trangDau);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(531, 634);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 62);
            this.panel1.TabIndex = 35;
            // 
            // lb_soBanGhi
            // 
            this.lb_soBanGhi.AutoSize = true;
            this.lb_soBanGhi.Location = new System.Drawing.Point(357, 23);
            this.lb_soBanGhi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_soBanGhi.Name = "lb_soBanGhi";
            this.lb_soBanGhi.Size = new System.Drawing.Size(61, 16);
            this.lb_soBanGhi.TabIndex = 13;
            this.lb_soBanGhi.Text = "2 bản ghi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "|";
            // 
            // btn_trangCuoi
            // 
            this.btn_trangCuoi.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_trangCuoi.Location = new System.Drawing.Point(567, 0);
            this.btn_trangCuoi.Margin = new System.Windows.Forms.Padding(0);
            this.btn_trangCuoi.Name = "btn_trangCuoi";
            this.btn_trangCuoi.Size = new System.Drawing.Size(100, 62);
            this.btn_trangCuoi.TabIndex = 1;
            this.btn_trangCuoi.Text = ">>";
            this.btn_trangCuoi.UseVisualStyleBackColor = true;
            this.btn_trangCuoi.Click += new System.EventHandler(this.btn_trangCuoi_Click);
            // 
            // lb_trang
            // 
            this.lb_trang.AutoSize = true;
            this.lb_trang.Location = new System.Drawing.Point(279, 23);
            this.lb_trang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_trang.Name = "lb_trang";
            this.lb_trang.Size = new System.Drawing.Size(64, 16);
            this.lb_trang.TabIndex = 11;
            this.lb_trang.Text = "Trang 1/1";
            // 
            // btn_trangTruoc
            // 
            this.btn_trangTruoc.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_trangTruoc.Location = new System.Drawing.Point(127, 0);
            this.btn_trangTruoc.Margin = new System.Windows.Forms.Padding(0);
            this.btn_trangTruoc.Name = "btn_trangTruoc";
            this.btn_trangTruoc.Size = new System.Drawing.Size(100, 62);
            this.btn_trangTruoc.TabIndex = 1;
            this.btn_trangTruoc.Text = "<";
            this.btn_trangTruoc.UseVisualStyleBackColor = true;
            this.btn_trangTruoc.Click += new System.EventHandler(this.btn_trangTruoc_Click);
            // 
            // btn_trangSau
            // 
            this.btn_trangSau.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_trangSau.Location = new System.Drawing.Point(467, 0);
            this.btn_trangSau.Margin = new System.Windows.Forms.Padding(0);
            this.btn_trangSau.Name = "btn_trangSau";
            this.btn_trangSau.Size = new System.Drawing.Size(100, 62);
            this.btn_trangSau.TabIndex = 1;
            this.btn_trangSau.Text = ">";
            this.btn_trangSau.UseVisualStyleBackColor = true;
            this.btn_trangSau.Click += new System.EventHandler(this.btn_trangSau_Click);
            // 
            // btn_trangDau
            // 
            this.btn_trangDau.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_trangDau.Location = new System.Drawing.Point(27, 0);
            this.btn_trangDau.Margin = new System.Windows.Forms.Padding(0);
            this.btn_trangDau.Name = "btn_trangDau";
            this.btn_trangDau.Size = new System.Drawing.Size(100, 62);
            this.btn_trangDau.TabIndex = 0;
            this.btn_trangDau.Text = "<<";
            this.btn_trangDau.UseVisualStyleBackColor = true;
            this.btn_trangDau.Click += new System.EventHandler(this.btn_trangDau_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenLop);
            this.groupBox1.Controls.Add(this.txtGhichu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(491, 400);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp học";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.Location = new System.Drawing.Point(24, 205);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(440, 25);
            this.txtTenLop.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ghi chú:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên lớp:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(25, 127);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(440, 25);
            this.txtMaLop.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã lớp:";
            // 
            // txtMaID
            // 
            this.txtMaID.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaID.Location = new System.Drawing.Point(25, 53);
            this.txtMaID.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaID.Name = "txtMaID";
            this.txtMaID.Size = new System.Drawing.Size(440, 25);
            this.txtMaID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã ID:";
            // 
            // dgvLopHoc
            // 
            this.dgvLopHoc.AllowUserToDeleteRows = false;
            this.dgvLopHoc.AutoGenerateColumns = false;
            this.dgvLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLopHoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.malopDataGridViewTextBoxColumn,
            this.tenlopDataGridViewTextBoxColumn,
            this.ghichuDataGridViewTextBoxColumn});
            this.dgvLopHoc.DataSource = this.tbllophocsBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLopHoc.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLopHoc.EnableHeadersVisualStyles = false;
            this.dgvLopHoc.Location = new System.Drawing.Point(531, 87);
            this.dgvLopHoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLopHoc.Name = "dgvLopHoc";
            this.dgvLopHoc.ReadOnly = true;
            this.dgvLopHoc.RowHeadersWidth = 51;
            this.dgvLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLopHoc.Size = new System.Drawing.Size(689, 539);
            this.dgvLopHoc.TabIndex = 34;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Mã ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // malopDataGridViewTextBoxColumn
            // 
            this.malopDataGridViewTextBoxColumn.DataPropertyName = "malop";
            this.malopDataGridViewTextBoxColumn.HeaderText = "Mã Lớp";
            this.malopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.malopDataGridViewTextBoxColumn.Name = "malopDataGridViewTextBoxColumn";
            this.malopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenlopDataGridViewTextBoxColumn
            // 
            this.tenlopDataGridViewTextBoxColumn.DataPropertyName = "tenlop";
            this.tenlopDataGridViewTextBoxColumn.HeaderText = "Tên Lớp";
            this.tenlopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenlopDataGridViewTextBoxColumn.Name = "tenlopDataGridViewTextBoxColumn";
            this.tenlopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ghichuDataGridViewTextBoxColumn
            // 
            this.ghichuDataGridViewTextBoxColumn.DataPropertyName = "ghichu";
            this.ghichuDataGridViewTextBoxColumn.HeaderText = "Ghi Chú";
            this.ghichuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghichuDataGridViewTextBoxColumn.Name = "ghichuDataGridViewTextBoxColumn";
            this.ghichuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbllophocsBindingSource
            // 
            this.tbllophocsBindingSource.DataMember = "tbl_lophocs";
            this.tbllophocsBindingSource.DataSource = this.qlsv1DataSet;
            // 
            // qlsv1DataSet
            // 
            this.qlsv1DataSet.DataSetName = "qlsv1DataSet";
            this.qlsv1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.Window;
            this.btnThem.Location = new System.Drawing.Point(5, 426);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(237, 58);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tbl_lophocsTableAdapter
            // 
            this.tbl_lophocsTableAdapter.ClearBeforeFill = true;
            // 
            // UCQLLH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_xemDanhSach);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvLopHoc);
            this.Controls.Add(this.btnThem);
            this.Name = "UCQLLH";
            this.Size = new System.Drawing.Size(1252, 793);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllophocsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlsv1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_xemDanhSach;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_trangCuoi;
        private System.Windows.Forms.Label lb_trang;
        private System.Windows.Forms.Button btn_trangTruoc;
        private System.Windows.Forms.Button btn_trangSau;
        private System.Windows.Forms.Button btn_trangDau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLopHoc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichuDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tbllophocsBindingSource;
        private qlsv1DataSet qlsv1DataSet;
        private qlsv1DataSetTableAdapters.tbl_lophocsTableAdapter tbl_lophocsTableAdapter;
        private System.Windows.Forms.Label lb_soBanGhi;
        private System.Windows.Forms.Label label3;
    }
}
