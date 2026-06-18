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
    public partial class UCQLLH : UserControl
    {
        private databaseDataContext _db = new databaseDataContext();
        private int _selectedId = 0;
        private List<tbl_lophoc> _classesCache;
        private int _pageIndex = 1;
        private int _rowsPerPage = 3;
        private int _maxPage = 1;

        public UCQLLH()
        {
            InitializeComponent();
        }

        private void UCQLLH_Load(object sender, EventArgs e)
        {
            ReloadClasses();
        }

        // Tải lại danh sách lớp
        public void ReloadClasses()
        {
            try
            {
                _classesCache = _db.tbl_lophocs
                                   .OrderBy(x => x.malop)
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

        // bind trang hiện tại lên dgv
        private void RenderPage()
        {
            _maxPage = Math.Max(1, (int)Math.Ceiling(_classesCache.Count / (double)_rowsPerPage));
            if (_pageIndex < 1) _pageIndex = 1;
            if (_pageIndex > _maxPage) _pageIndex = _maxPage;

            dgvLopHoc.DataSource = _classesCache
                .Skip((_pageIndex - 1) * _rowsPerPage)
                .Take(_rowsPerPage)
                .Select(lh => new
                {
                    lh.id,
                    lh.malop,
                    lh.tenlop,
                    lh.ghichu
                })
                .ToList();

            lb_trang.Text = _pageIndex + "/" + _maxPage;
            lb_soBanGhi.Text = _classesCache.Count + " bản ghi";
        }

        // Lọc theo từ khóa
        private void FilterClassesByKeyword(string tuKhoa)
        {
            string tk = (tuKhoa ?? string.Empty).Trim();
            _classesCache = _db.tbl_lophocs
                          .Where(lh =>
                              lh.id.ToString().Contains(tk) ||
                              lh.malop.Contains(tk) ||
                              lh.tenlop.Contains(tk))
                          .OrderBy(lh => lh.malop)
                          .ToList();
            _pageIndex = 1;
            RenderPage();
        }

        // Reset form lớp học
        private void ResetClassForm()
        {
            txtMaID.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtGhichu.Clear();

            _selectedId = 0;
            txtMaLop.Focus();
        }

        // xử lý click trên DataGridView lớp
        private void dgv_DSLH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvLopHoc.Rows[e.RowIndex];

            _selectedId = Convert.ToInt32(row.Cells["id"].Value);
            txtMaID.Text = _selectedId.ToString();
            txtMaLop.Text = row.Cells["malop"].Value?.ToString();
            txtTenLop.Text = row.Cells["tenlop"].Value?.ToString();
            txtGhichu.Text = row.Cells["ghichu"].Value?.ToString();

            txtMaID.Enabled = false;
        }

        // Thêm lớp
        private void btnThem_Click(object sender, EventArgs e)
        {
            var lop = new tbl_lophoc
            {
                malop = txtMaLop.Text.Trim(),
                tenlop = txtTenLop.Text.Trim(),
                ghichu = txtGhichu.Text.Trim()
            };

            try
            {
                _db.tbl_lophocs.InsertOnSubmit(lop);
                _db.SubmitChanges();
                MessageBox.Show("Thêm mới lớp học thành công");
                ReloadClasses();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Sửa lớp
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Vui lòng chọn lớp học cần sửa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var entity = _db.tbl_lophocs.FirstOrDefault(x => x.id == _selectedId);
            if (entity == null)
            {
                MessageBox.Show("Không tìm thấy lớp học!");
                return;
            }

            entity.malop = txtMaLop.Text.Trim();
            entity.tenlop = txtTenLop.Text.Trim();
            entity.ghichu = txtGhichu.Text.Trim();

            try
            {
                _db.SubmitChanges();
                MessageBox.Show("Cập nhật thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadClasses();
                ResetClassForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xóa lớp
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Vui lòng chọn lớp học cần xóa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show(
                "Bạn có chắc muốn xóa lớp học '" + txtTenLop.Text + "'?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            var entity = _db.tbl_lophocs.FirstOrDefault(x => x.id == _selectedId);
            if (entity == null)
            {
                MessageBox.Show("Không tìm thấy lớp học!");
                return;
            }

            try
            {
                _db.tbl_lophocs.DeleteOnSubmit(entity);
                _db.SubmitChanges();
                MessageBox.Show("Xóa thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadClasses();
                ResetClassForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetClassForm();
        }

        // Hiển thị danh sách sinh viên của lớp; lấy dữ liệu từ DB và hiển thị trong form phụ.
        private void ShowStudentList(System.Collections.Generic.List<object> danhSachObj)
        {
            using (Form formDanhSach = new Form())
            {
                // Chuyển về danh sách đúng kiểu bên trong hàm
                var danhSachSinhVien = danhSachObj?.Cast<tbl_sinhvien>().ToList() ?? new System.Collections.Generic.List<tbl_sinhvien>();
                // Nếu không có biến global `maLopDangChon`, lấy mã lớp từ phần tử đầu
                string maLopDangChon = danhSachSinhVien?.FirstOrDefault()?.malop ?? string.Empty;

                Label lblTieuDe = new Label
                {
                    Dock = DockStyle.Top,
                    Height = 36,
                    Padding = new Padding(10, 0, 0, 0),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Text = $"Lớp {maLopDangChon} — {danhSachSinhVien?.Count ?? 0} SV"
                };

                DataGridView dgvSinhVien = new DataGridView
                {
                    AllowUserToAddRows = false,
                    AllowUserToDeleteRows = false,
                    AutoGenerateColumns = false,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                    Dock = DockStyle.Fill,
                    MultiSelect = false,
                    ReadOnly = true,
                    SelectionMode = DataGridViewSelectionMode.FullRowSelect
                };

                dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "MaSV",
                    HeaderText = "Mã SV",
                    Name = "colMaSV"
                });
                dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "HoTen",
                    HeaderText = "Họ và tên",
                    Name = "colHoTen"
                });
                dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "GioiTinh",
                    HeaderText = "Giới tính",
                    Name = "colGioiTinh"
                });
                dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "NgaySinh",
                    HeaderText = "Ngày sinh",
                    Name = "colNgaySinh",
                    DefaultCellStyle = { Format = "dd/MM/yyyy" }
                });
                dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Lop",
                    HeaderText = "Lớp",
                    Name = "colLop"
                });
                dgvSinhVien.DataSource = danhSachSinhVien;

                formDanhSach.Text = "Danh sách sinh viên";
                formDanhSach.StartPosition = FormStartPosition.CenterParent;
                formDanhSach.Size = new Size(760, 420);
                formDanhSach.MinimizeBox = false;
                formDanhSach.Controls.Add(dgvSinhVien);
                formDanhSach.Controls.Add(lblTieuDe);
                formDanhSach.ShowDialog(this);
            }
        }

        // Event handler wired by Designer: query students of the selected class and show them
        private void btn_xemDanhSach_Click(object sender, EventArgs e)
        {
            string malop = _classesCache?.FirstOrDefault(x => x.id == _selectedId)?.malop;
            if (string.IsNullOrEmpty(malop))
            {
                MessageBox.Show("Vui lòng chọn lớp để xem danh sách sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var danhSach = _db.tbl_sinhviens
                .Where(sv => sv.malop == malop)
                .OrderBy(sv => sv.id)
                .ToList();

            ShowStudentList(danhSach.Cast<object>().ToList());
        }

        // paging controls (giữ tên handler)
        private void btn_trangDau_Click(object sender, EventArgs e)
        {
            _pageIndex = 1;
            RenderPage();
        }

        private void btn_trangTruoc_Click(object sender, EventArgs e)
        {
            _pageIndex--;
            RenderPage();
        }

        private void btn_trangSau_Click(object sender, EventArgs e)
        {
            _pageIndex++;
            RenderPage();
        }

        private void btn_trangCuoi_Click(object sender, EventArgs e)
        {
            _pageIndex = _maxPage;
            RenderPage();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            FilterClassesByKeyword(txtTimKiem.Text);
        }
    }
}
