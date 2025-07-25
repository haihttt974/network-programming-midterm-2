using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using test_2_mmt.Data_;

namespace test_2_mmt
{
    public partial class frmPhanQuyenUser : Form
    {
        private Model1 dbContext;
        private NHAN_VIEN currentUser;

        public frmPhanQuyenUser(NHAN_VIEN user)
        {
            InitializeComponent();
            dbContext = new Model1();
            currentUser = user;
            dgvQLNhanVienQL.AllowUserToAddRows = false;
            dgvQLNhanVienBH.AllowUserToAddRows = false;
            LoadEmployeeData();
            this.Width = 1363;
            this.Height = 600;
            TestRadioButtons();
        }

        private void TestRadioButtons()
        {
            rdoNam.Checked = true;
            rdoNu.Checked = false;
            rdoKhac.Checked = false;
        }

        private string GetMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        private void LoadEmployeeData()
        {
            try
            {
                var managers = dbContext.NHAN_VIEN
                    .Where(nv => nv.LAQUANLY == true)
                    .ToList();

                dgvQLNhanVienQL.Rows.Clear();
                foreach (var nv in managers)
                {
                    int rowIndex = dgvQLNhanVienQL.Rows.Add();
                    dgvQLNhanVienQL.Rows[rowIndex].Cells[0].Value = nv.TENDANGNHAP;
                    dgvQLNhanVienQL.Rows[rowIndex].Cells[1].Value = nv.TENNHANVIEN;
                    dgvQLNhanVienQL.Rows[rowIndex].Cells[2].Value = nv.SDT;
                    dgvQLNhanVienQL.Rows[rowIndex].Cells[3].Value = nv.GIOITINH;
                    dgvQLNhanVienQL.Rows[rowIndex].Cells[4].Value = nv.NGAYSINH?.ToString("dd/MM/yyyy");
                }

                var salesStaff = dbContext.NHAN_VIEN
                    .Where(nv => nv.LAQUANLY == false)
                    .ToList();

                dgvQLNhanVienBH.Rows.Clear();
                foreach (var nv in salesStaff)
                {
                    int rowIndex = dgvQLNhanVienBH.Rows.Add();
                    dgvQLNhanVienBH.Rows[rowIndex].Cells[0].Value = nv.TENDANGNHAP;
                    dgvQLNhanVienBH.Rows[rowIndex].Cells[1].Value = nv.TENNHANVIEN;
                    dgvQLNhanVienBH.Rows[rowIndex].Cells[2].Value = nv.SDT;
                    dgvQLNhanVienBH.Rows[rowIndex].Cells[3].Value = nv.GIOITINH;
                    dgvQLNhanVienBH.Rows[rowIndex].Cells[4].Value = nv.NGAYSINH?.ToString("dd/MM/yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void dgvQLNhanVienQL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvQLNhanVienQL.Rows.Count) return;
            if (dgvQLNhanVienQL.AllowUserToAddRows && e.RowIndex == dgvQLNhanVienQL.Rows.Count - 1) return;

            var row = dgvQLNhanVienQL.Rows[e.RowIndex];

            string username = row.Cells[0].Value?.ToString(); // Cell 0 là TENDANGNHAP
            if (string.IsNullOrEmpty(username)) return;

            var nv = dbContext.NHAN_VIEN.FirstOrDefault(n => n.TENDANGNHAP == username);
            if (nv == null) return;

            // Điền dữ liệu vào các textbox, radiobutton
            txtTenDangNhap.Text = nv.TENDANGNHAP;
            txtTenNhanVien.Text = nv.TENNHANVIEN;
            txtSdt.Text = nv.SDT;
            txtDiaChi.Text = nv.DIACHI;

            // Reset radio button giới tính
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            rdoKhac.Checked = false;

            // Gán giới tính
            if (!string.IsNullOrWhiteSpace(nv.GIOITINH))
            {
                string gt = nv.GIOITINH.Trim().ToLowerInvariant();

                if (gt == "nam")
                    rdoNam.Checked = true;
                else if (gt == "nữ" || gt == "nu")
                    rdoNu.Checked = true;
                else
                    rdoKhac.Checked = true;
            }
            else
            {
                rdoKhac.Checked = true;
            }

            if (nv.NGAYSINH.HasValue)
                dtpNgaySinh.Value = nv.NGAYSINH.Value;

            cmbQuyen.SelectedItem = (nv.LAQUANLY ?? false) ? "Quản lý" : "Bán hàng";
            rdoYesHoatDong.Checked = !(nv.VOHIEUHOA ?? false);
            rdoNoHoatDong.Checked = (nv.VOHIEUHOA ?? false);
        }

        private void dgvQLNhanVienBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvQLNhanVienBH.Rows.Count) return;
            if (dgvQLNhanVienBH.AllowUserToAddRows && e.RowIndex == dgvQLNhanVienBH.Rows.Count - 1) return;

            try
            {
                var row = dgvQLNhanVienBH.Rows[e.RowIndex];
                string username = row.Cells[0].Value?.ToString()?.Trim(); // Đảm bảo Cell 0 là TENDANGNHAP

                if (string.IsNullOrEmpty(username)) return;

                var nv = dbContext.NHAN_VIEN.FirstOrDefault(n => n.TENDANGNHAP == username);
                if (nv == null) return;

                // Gán thông tin cơ bản
                txtTenDangNhap.Text = nv.TENDANGNHAP;
                txtTenNhanVien.Text = nv.TENNHANVIEN;
                txtSdt.Text = nv.SDT;
                txtDiaChi.Text = nv.DIACHI;

                // Reset radio button giới tính
                rdoNam.Checked = false;
                rdoNu.Checked = false;
                rdoKhac.Checked = false;

                // Gán giới tính
                if (!string.IsNullOrWhiteSpace(nv.GIOITINH))
                {
                    string gt = nv.GIOITINH.Trim().ToLowerInvariant();

                    if (gt == "nam")
                        rdoNam.Checked = true;
                    else if (gt == "nữ" || gt == "nu")
                        rdoNu.Checked = true;
                    else
                        rdoKhac.Checked = true;
                }
                else
                {
                    rdoKhac.Checked = true;
                }

                // Ngày sinh
                dtpNgaySinh.Value = nv.NGAYSINH ?? DateTime.Today;

                // Quyền
                cmbQuyen.SelectedItem = (nv.LAQUANLY ?? false) ? "Quản lý" : "Bán hàng";

                // Trạng thái hoạt động
                bool isDisabled = nv.VOHIEUHOA ?? false;
                rdoNoHoatDong.Checked = isDisabled;
                rdoYesHoatDong.Checked = !isDisabled;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị thông tin nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool XacNhanMatKhau()
        {
            string nhapMK = Microsoft.VisualBasic.Interaction.InputBox("Nhập mật khẩu xác nhận:", "Xác nhận mật khẩu", "", -1, -1);
            string hashedInput = GetMD5Hash(nhapMK);
            if (hashedInput != currentUser.MATKHAU)
            {
                MessageBox.Show("Mật khẩu không đúng!");
                return false;
            }
            return true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                new frmLogin().Show();
                this.Close();
            }
        }

        private void txtSearchQL_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchQL.Text.Trim().ToLower();
            dgvQLNhanVienQL.Rows.Clear();

            var filtered = dbContext.NHAN_VIEN
                .Where(nv => nv.LAQUANLY == true && nv.VOHIEUHOA == false &&
                    (nv.TENDANGNHAP.ToLower().Contains(keyword) ||
                     nv.TENNHANVIEN.ToLower().Contains(keyword)))
                .ToList();

            foreach (var nv in filtered)
            {
                int rowIndex = dgvQLNhanVienQL.Rows.Add();
                dgvQLNhanVienQL.Rows[rowIndex].Cells[0].Value = nv.TENDANGNHAP;
                dgvQLNhanVienQL.Rows[rowIndex].Cells[1].Value = nv.TENNHANVIEN;
                dgvQLNhanVienQL.Rows[rowIndex].Cells[2].Value = nv.SDT;
                dgvQLNhanVienQL.Rows[rowIndex].Cells[3].Value = nv.GIOITINH;
                dgvQLNhanVienQL.Rows[rowIndex].Cells[4].Value = nv.NGAYSINH?.ToString("dd/MM/yyyy");
            }
        }

        private void txtSearchBH_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchBH.Text.Trim().ToLower();
            dgvQLNhanVienBH.Rows.Clear();

            var filtered = dbContext.NHAN_VIEN
                .Where(nv => nv.LAQUANLY == false && nv.VOHIEUHOA == false &&
                    (nv.TENDANGNHAP.ToLower().Contains(keyword) ||
                     nv.TENNHANVIEN.ToLower().Contains(keyword)))
                .ToList();

            foreach (var nv in filtered)
            {
                int rowIndex = dgvQLNhanVienBH.Rows.Add();
                dgvQLNhanVienBH.Rows[rowIndex].Cells[0].Value = nv.TENDANGNHAP;
                dgvQLNhanVienBH.Rows[rowIndex].Cells[1].Value = nv.TENNHANVIEN;
                dgvQLNhanVienBH.Rows[rowIndex].Cells[2].Value = nv.SDT;
                dgvQLNhanVienBH.Rows[rowIndex].Cells[3].Value = nv.GIOITINH;
                dgvQLNhanVienBH.Rows[rowIndex].Cells[4].Value = nv.NGAYSINH?.ToString("dd/MM/yyyy");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để chỉnh sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nv = dbContext.NHAN_VIEN.FirstOrDefault(n => n.TENDANGNHAP == username);
            if (nv == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool dangChinhSuaQuyenCuaChinhMinh = (username == currentUser.TENDANGNHAP);
            bool quyenMoi = cmbQuyen.SelectedItem?.ToString() == "Quản lý";
            bool voHieuHoaMoi = rdoNoHoatDong.Checked; // true nếu muốn vô hiệu hóa

            // Không được chỉnh quyền của chính mình
            if (dangChinhSuaQuyenCuaChinhMinh && quyenMoi != (nv.LAQUANLY ?? false))
            {
                MessageBox.Show("Bạn không thể thay đổi quyền của chính mình!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbQuyen.SelectedItem = (nv.LAQUANLY ?? false) ? "Quản lý" : "Bán hàng";
                return;
            }

            // Không được vô hiệu hóa chính mình
            if (dangChinhSuaQuyenCuaChinhMinh && voHieuHoaMoi)
            {
                MessageBox.Show("Bạn không thể thay đổi trạng thái hoạt động của chính mình!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rdoYesHoatDong.Checked = !(nv.VOHIEUHOA ?? false);
                rdoNoHoatDong.Checked = (nv.VOHIEUHOA ?? false);
                return;
            }

            // Xác nhận mật khẩu
            if (!XacNhanMatKhau())
            {
                return;
            }

            // Cập nhật thông tin cơ bản
            nv.TENNHANVIEN = txtTenNhanVien.Text.Trim();
            nv.SDT = txtSdt.Text.Trim();
            nv.DIACHI = txtDiaChi.Text.Trim();
            nv.NGAYSINH = dtpNgaySinh.Value.Date;
            nv.VOHIEUHOA = rdoNoHoatDong.Checked;

            // ✅ Cập nhật giới tính
            if (rdoNam.Checked)
                nv.GIOITINH = "Nam";
            else if (rdoNu.Checked)
                nv.GIOITINH = "Nữ";
            else if (rdoKhac.Checked)
                nv.GIOITINH = "Khác";
            else
                nv.GIOITINH = null; // Không chọn gì

            // ✅ Cập nhật quyền nếu không chỉnh bản thân
            if (!dangChinhSuaQuyenCuaChinhMinh)
            {
                nv.LAQUANLY = quyenMoi;
            }

            // Lưu vào DB
            try
            {
                dbContext.SaveChanges();
                MessageBox.Show("Cập nhật nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployeeData(); // Refresh lại dữ liệu trên grid
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var error in ex.EntityValidationErrors)
                {
                    foreach (var ve in error.ValidationErrors)
                    {
                        sb.AppendLine($"{ve.PropertyName}: {ve.ErrorMessage}");
                    }
                }
                MessageBox.Show("Lỗi xác thực dữ liệu:\n" + sb.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPhanQuyenUser_Load(object sender, EventArgs e)
        {
            txtSearchQL.Text = "Tìm kiếm nhân viên quản lý...";
            txtSearchQL.ForeColor = Color.Gray;
            txtSearchBH.Text = "Tìm kiếm nhân viên bán hàng...";
            txtSearchBH.ForeColor = Color.Gray;
            LoadEmployeeData();
            txtSearchQL.Enter += txtSearchQL_Enter;
            txtSearchQL.Leave += txtSearchQL_Leave;
            txtSearchBH.Enter += txtSearchBH_Enter;
            txtSearchBH.Leave += txtSearchBH_Leave;
        }

        private void txtSearchBH_Enter(object sender, EventArgs e)
        {
            if (txtSearchBH.Text == "Tìm kiếm nhân viên bán hàng...")
            {
                txtSearchBH.Text = "";
                txtSearchBH.ForeColor = Color.Black;
            }
        }

        private void txtSearchBH_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchBH.Text))
            {
                txtSearchBH.Text = "Tìm kiếm nhân viên bán hàng...";
                txtSearchBH.ForeColor = Color.Gray;

                // Load lại toàn bộ danh sách nhân viên bán hàng
                LoadEmployeeData();
            }
        }

        private void txtSearchQL_Enter(object sender, EventArgs e)
        {
            if (txtSearchQL.Text == "Tìm kiếm nhân viên quản lý...")
            {
                txtSearchQL.Text = "";
                txtSearchQL.ForeColor = Color.Black;
            }
        }

        private void txtSearchQL_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchQL.Text))
            {
                txtSearchQL.Text = "Tìm kiếm nhân viên quản lý...";
                txtSearchQL.ForeColor = Color.Gray;

                // Load lại toàn bộ danh sách nhân viên quản lý
                LoadEmployeeData(); // hoặc tên hàm load dữ liệu QL mà bạn đã có
            }
        }
    }
}