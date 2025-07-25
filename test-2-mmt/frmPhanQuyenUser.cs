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
            SetupDataGridViewColumns();
            LoadEmployeeData();
            dgvQLNhanVienQL.Invalidate();
            dgvQLNhanVienBH.Invalidate();
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

        private void SetupDataGridViewColumns()
        {
            if (!dgvQLNhanVienQL.Columns.Contains("colThayDoi"))
            {
                DataGridViewImageColumn imgColumnQL = new DataGridViewImageColumn
                {
                    Name = "colThayDoi",
                    HeaderText = "THAY ĐỔI",
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 60,
                    DefaultCellStyle = { NullValue = null }
                };
                dgvQLNhanVienQL.Columns.Insert(0, imgColumnQL);
            }

            if (!dgvQLNhanVienBH.Columns.Contains("colThayDoi2"))
            {
                DataGridViewImageColumn imgColumnBH = new DataGridViewImageColumn
                {
                    Name = "colThayDoi2",
                    HeaderText = "THAY ĐỔI",
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 60,
                    DefaultCellStyle = { NullValue = null }
                };
                dgvQLNhanVienBH.Columns.Insert(0, imgColumnBH);
            }
        }

        private void LoadEmployeeData()
        {
            try
            {
                Image upIcon = new Bitmap(Properties.Resources.up, new Size(40, 40));
                Image downIcon = new Bitmap(Properties.Resources.down, new Size(40, 40));

                var managers = dbContext.NHAN_VIEN
                    .Where(nv => nv.LAQUANLY == true && nv.VOHIEUHOA == false)
                    .ToList();

                dgvQLNhanVienQL.Rows.Clear();
                foreach (var nv in managers)
                {
                    int rowIndex = dgvQLNhanVienQL.Rows.Add();
                    dgvQLNhanVienQL.Rows[rowIndex].Cells[0].Value = downIcon;
                    dgvQLNhanVienQL.Rows[rowIndex].Cells[1].Value = nv.TENDANGNHAP;
                    dgvQLNhanVienQL.Rows[rowIndex].Cells[2].Value = nv.TENNHANVIEN;
                    dgvQLNhanVienQL.Rows[rowIndex].Cells[3].Value = nv.SDT;
                    dgvQLNhanVienQL.Rows[rowIndex].Cells[4].Value = nv.GIOITINH;
                    dgvQLNhanVienQL.Rows[rowIndex].Cells[5].Value = nv.NGAYSINH?.ToString("dd/MM/yyyy");
                }

                var salesStaff = dbContext.NHAN_VIEN
                    .Where(nv => nv.LAQUANLY == false && nv.VOHIEUHOA == false)
                    .ToList();

                dgvQLNhanVienBH.Rows.Clear();
                foreach (var nv in salesStaff)
                {
                    int rowIndex = dgvQLNhanVienBH.Rows.Add();
                    dgvQLNhanVienBH.Rows[rowIndex].Cells[0].Value = upIcon;
                    dgvQLNhanVienBH.Rows[rowIndex].Cells[1].Value = nv.TENDANGNHAP;
                    dgvQLNhanVienBH.Rows[rowIndex].Cells[2].Value = nv.TENNHANVIEN;
                    dgvQLNhanVienBH.Rows[rowIndex].Cells[3].Value = nv.SDT;
                    dgvQLNhanVienBH.Rows[rowIndex].Cells[4].Value = nv.GIOITINH;
                    dgvQLNhanVienBH.Rows[rowIndex].Cells[5].Value = nv.NGAYSINH?.ToString("dd/MM/yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void dgvQLNhanVienQL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click đúng dòng dữ liệu và đúng cột thay đổi quyền
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) // Giả sử cột 0 là "Thay Đổi"
            {
                // Lấy tên đăng nhập từ dòng được chọn
                var cellValue = dgvQLNhanVienQL.Rows[e.RowIndex].Cells[1].Value;

                if (cellValue == null)
                {
                    MessageBox.Show("Không thể lấy tên đăng nhập từ dòng này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string username = cellValue.ToString();

                // Không cho tự thay đổi quyền của chính mình
                if (username == currentUser.TENDANGNHAP)
                {
                    MessageBox.Show("Bạn không thể thay đổi quyền của chính mình.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận mật khẩu quản lý
                if (!XacNhanMatKhau())
                {
                    return;
                }

                try
                {
                    // Tìm nhân viên trong DB
                    var nv = dbContext.NHAN_VIEN.FirstOrDefault(n => n.TENDANGNHAP == username);
                    if (nv == null)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên cần cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Đảo quyền quản lý
                    nv.LAQUANLY = !(nv.LAQUANLY ?? false);

                    // Lưu thay đổi
                    dbContext.SaveChanges();

                    MessageBox.Show("Cập nhật quyền thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload lại dữ liệu
                    LoadEmployeeData();
                }
                catch (DbEntityValidationException ex)
                {
                    var errors = new StringBuilder();
                    foreach (var eve in ex.EntityValidationErrors)
                    {
                        foreach (var ve in eve.ValidationErrors)
                        {
                            errors.AppendLine($"Thuộc tính: {ve.PropertyName}, Lỗi: {ve.ErrorMessage}");
                        }
                    }
                    MessageBox.Show(errors.ToString(), "Lỗi xác thực dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu thay đổi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void dgvQLNhanVienBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                string username = dgvQLNhanVienBH.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (XacNhanMatKhau())
                {
                    var nv = dbContext.NHAN_VIEN.FirstOrDefault(n => n.TENDANGNHAP == username);
                    if (nv != null)
                    {
                        nv.LAQUANLY = true;
                        dbContext.SaveChanges();
                        LoadEmployeeData();
                    }
                }
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

        private void pcbSearchQL_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchQL.Text.Trim().ToLower();
            dgvQLNhanVienQL.Rows.Clear();
            Image downIcon = new Bitmap(Properties.Resources.down, new Size(40, 40));
            var filtered = dbContext.NHAN_VIEN.Where(nv => nv.LAQUANLY == true && nv.VOHIEUHOA == false &&
                (nv.TENDANGNHAP.ToLower().Contains(keyword) || nv.TENNHANVIEN.ToLower().Contains(keyword))).ToList();
            foreach (var nv in filtered)
            {
                int rowIndex = dgvQLNhanVienQL.Rows.Add();
                dgvQLNhanVienQL.Rows[rowIndex].Cells[0].Value = downIcon;
                dgvQLNhanVienQL.Rows[rowIndex].Cells[1].Value = nv.TENDANGNHAP;
                dgvQLNhanVienQL.Rows[rowIndex].Cells[2].Value = nv.TENNHANVIEN;
                dgvQLNhanVienQL.Rows[rowIndex].Cells[3].Value = nv.SDT;
                dgvQLNhanVienQL.Rows[rowIndex].Cells[4].Value = nv.GIOITINH;
                dgvQLNhanVienQL.Rows[rowIndex].Cells[5].Value = nv.NGAYSINH?.ToString("dd/MM/yyyy");
            }
        }

        private void pcbSearchBH_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchBH.Text.Trim().ToLower();
            dgvQLNhanVienBH.Rows.Clear();
            Image upIcon = new Bitmap(Properties.Resources.up, new Size(40, 40));
            var filtered = dbContext.NHAN_VIEN.Where(nv => nv.LAQUANLY == false && nv.VOHIEUHOA == false &&
                (nv.TENDANGNHAP.ToLower().Contains(keyword) || nv.TENNHANVIEN.ToLower().Contains(keyword))).ToList();
            foreach (var nv in filtered)
            {
                int rowIndex = dgvQLNhanVienBH.Rows.Add();
                dgvQLNhanVienBH.Rows[rowIndex].Cells[0].Value = upIcon;
                dgvQLNhanVienBH.Rows[rowIndex].Cells[1].Value = nv.TENDANGNHAP;
                dgvQLNhanVienBH.Rows[rowIndex].Cells[2].Value = nv.TENNHANVIEN;
                dgvQLNhanVienBH.Rows[rowIndex].Cells[3].Value = nv.SDT;
                dgvQLNhanVienBH.Rows[rowIndex].Cells[4].Value = nv.GIOITINH;
                dgvQLNhanVienBH.Rows[rowIndex].Cells[5].Value = nv.NGAYSINH?.ToString("dd/MM/yyyy");
            }
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
    }
}