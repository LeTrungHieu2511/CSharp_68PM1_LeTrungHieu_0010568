using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlysinhvien
{
    public partial class UCQLSV : UserControl
    {
        // Context DB và trạng thái
        private databaseDataContext _dbContext = new databaseDataContext();
        private string _selectedStudentIdStr;
        private List<tbl_sinhvien> _studentsCache;
        private int _pageIndex = 1;
        private int _rowsPerPage = 2;
        private int _maxPage = 1;
        private ToolTip _toolTip = new ToolTip();

        public UCQLSV()
        {
            InitializeComponent();
            // Thiết lập nhỏ ngay khi khởi tạo để khác so với mặc định designer
            this.Font = new Font("Segoe UI", 9F);
        }

        private void UCQLSV_Load(object sender, EventArgs e)
        {
            // Tweak giao diện nhẹ ở runtime (không sửa Designer)
            TryTweakUiControls();

            ReloadStudents();
            PopulateClassComboBox();
        }

        private void TryTweakUiControls()
        {
            try
            {
                // DataGridView: header màu, alternate row color, line color
                dgvSinhVien.EnableHeadersVisualStyles = false;
                dgvSinhVien.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 120, 220);
                dgvSinhVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvSinhVien.RowHeadersVisible = false;
                dgvSinhVien.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 250, 255);
                dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvSinhVien.AllowUserToResizeRows = false;
                dgvSinhVien.GridColor = Color.FromArgb(220, 230, 240);
                dgvSinhVien.BorderStyle = BorderStyle.FixedSingle;

                // Bật DoubleBuffered để giảm flicker (private property via reflection)
                typeof(DataGridView).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
                    ?.SetValue(dgvSinhVien, true, null);

                // Buttons: flat style, màu nhẹ để khác biệt
                foreach (Control c in this.Controls)
                {
                    if (c is Button btn)
                    {
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.BackColor = Color.FromArgb(230, 240, 250);
                        btn.ForeColor = Color.FromArgb(30, 30, 30);
                        _toolTip.SetToolTip(btn, btn.Text);
                    }
                }

                // Offset nhẹ vị trí các nút page (offset 4px xuống) để khác biệt nhưng vẫn gần giống
                btn_trangDau.Location = new Point(btn_trangDau.Location.X, btn_trangDau.Location.Y + 4);
                btn_trangTruoc.Location = new Point(btn_trangTruoc.Location.X, btn_trangTruoc.Location.Y + 4);
                btn_trangSau.Location = new Point(btn_trangSau.Location.X, btn_trangSau.Location.Y + 4);
                btn_trangCuoi.Location = new Point(btn_trangCuoi.Location.X, btn_trangCuoi.Location.Y + 4);

                // Label hiển thị trang: font đậm hơn một chút
                lb_trang.Font = new Font(lb_trang.Font, FontStyle.Bold);

                // Một vài padding cho textbox để nhìn khác
                txtTimKiem.Padding = new Padding(6, 2, 6, 2);
            }
            catch
            {
                // Nếu có control không tồn tại hoặc lỗi, bỏ qua — an toàn
            }
        }

        // Add new student
        private void btnThem_Click(object sender, EventArgs e)
        {
            var sv = new tbl_sinhvien();
            if (!int.TryParse(txtMaSV.Text, out int parsedId))
            {
                MessageBox.Show("Mã SV phải là số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sv.id = parsedId;
            sv.hoten = txtHoTen.Text;
            sv.gioitinh = cbGioiTinh.Text;
            sv.ngaysinh = DateTime.Parse(dtNgaySinh.Text);
            sv.malop = cbMaLop.SelectedValue?.ToString();

            try
            {
                _dbContext.tbl_sinhviens.InsertOnSubmit(sv);
                _dbContext.SubmitChanges();
                MessageBox.Show("Thêm mới sinh viên thành công");
                ReloadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Tải lại danh sách sinh viên (cache) và hiển thị trang đầu
        public void ReloadStudents()
        {
            try
            {
                _studentsCache = _dbContext.tbl_sinhviens
                                   .OrderBy(x => x.id)
                                   .ToList();
                _pageIndex = 1;
                RenderPage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phân trang và bind DataGridView
        private void RenderPage()
        {
            _maxPage = Math.Max(1, (int)Math.Ceiling(_studentsCache.Count / (double)_rowsPerPage));
            if (_pageIndex < 1) _pageIndex = 1;
            if (_pageIndex > _maxPage) _pageIndex = _maxPage;

            dgvSinhVien.DataSource = _studentsCache
                .Skip((_pageIndex - 1) * _rowsPerPage)
                .Take(_rowsPerPage)
                .Select(sv => new
                {
                    sv.id,
                    sv.hoten,
                    sv.gioitinh,
                    sv.ngaysinh,
                    sv.malop
                })
                .ToList();

            lb_trang.Text = _pageIndex + " / " + _maxPage;
            lb_soBanGhi.Text = _studentsCache.Count + " bản ghi";
        }

        // Tìm kiếm theo từ khóa
        private void FilterStudentsByKeyword(string tuKhoa)
        {
            string tk = (tuKhoa ?? string.Empty).Trim();
            _studentsCache = _dbContext.tbl_sinhviens
                              .Where(sv =>
                                  sv.id.ToString().Contains(tk) ||
                                  sv.hoten.Contains(tk) ||
                                  sv.malop.Contains(tk))
                              .OrderBy(sv => sv.id)
                              .ToList();
            _pageIndex = 1;
            RenderPage();
        }

        // Load danh sách lớp cho combobox
        public void PopulateClassComboBox()
        {
            var dsLop = _dbContext.tbl_lophocs.ToList();
            cbMaLop.DataSource = dsLop;
            cbMaLop.DisplayMember = "tenlop";
            cbMaLop.ValueMember = "malop";
        }

        // Reset form nhập liệu
        private void ResetInputs()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            dtNgaySinh.Value = DateTime.Now;
            cbGioiTinh.SelectedIndex = -1;
            cbMaLop.SelectedIndex = -1;

            _selectedStudentIdStr = string.Empty;
            txtHoTen.Focus();
            txtMaSV.Enabled = true;
        }

        // Xử lý click trên DataGridView (giữ handler)
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvSinhVien.Rows[e.RowIndex];

            _selectedStudentIdStr = row.Cells["id"].Value?.ToString();
            txtMaSV.Text = _selectedStudentIdStr;
            txtHoTen.Text = row.Cells["hoten"].Value?.ToString();
            cbGioiTinh.Text = row.Cells["gioitinh"].Value?.ToString();

            txtMaSV.Enabled = false;

            string malop = row.Cells["malop"].Value?.ToString()?.Trim();
            if (!string.IsNullOrEmpty(malop))
                cbMaLop.SelectedValue = malop;
            else if (cbMaLop.Items.Count > 0)
                cbMaLop.SelectedIndex = 0;

            if (row.Cells["ngaysinh"].Value is DateTime dt)
                dtNgaySinh.Value = dt;
        }

        // Update student
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedStudentIdStr))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(_selectedStudentIdStr);
            var entity = _dbContext.tbl_sinhviens.FirstOrDefault(x => x.id == id);
            if (entity == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên!");
                return;
            }

            entity.hoten = txtHoTen.Text.Trim();
            entity.ngaysinh = dtNgaySinh.Value.Date;
            entity.gioitinh = cbGioiTinh.Text;
            entity.malop = cbMaLop.SelectedValue?.ToString()?.Trim();

            try
            {
                _dbContext.SubmitChanges();
                MessageBox.Show("Cập nhật thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadStudents();
                ResetInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetInputs();
        }

        // Delete student
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedStudentIdStr))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên '" + txtHoTen.Text + "'?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            int id = Convert.ToInt32(_selectedStudentIdStr);
            var entity = _dbContext.tbl_sinhviens.FirstOrDefault(x => x.id == id);
            if (entity == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên!");
                return;
            }

            try
            {
                _dbContext.tbl_sinhviens.DeleteOnSubmit(entity);
                _dbContext.SubmitChanges();
                MessageBox.Show("Xóa thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadStudents();
                ResetInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Paging controls
        private void btn_trangDau_Click(object sender, EventArgs e)
        {
            _pageIndex = 1;
            RenderPage();
        }

        private void btn_trangTruoc_Click(object sender, EventArgs e)
        {
            _pageIndex = Math.Max(1, _pageIndex - 1);
            RenderPage();
        }

        private void btn_trangSau_Click(object sender, EventArgs e)
        {
            _pageIndex = Math.Min(_maxPage, _pageIndex + 1);
            RenderPage();
        }

        private void btn_trangCuoi_Click(object sender, EventArgs e)
        {
            _pageIndex = _maxPage;
            RenderPage();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            FilterStudentsByKeyword(txtTimKiem.Text);
        }
    }
}

