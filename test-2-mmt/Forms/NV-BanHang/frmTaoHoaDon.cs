using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using test_2_mmt.Forms.NV_KhachHang;
using test_2_mmt.Globals;
using test_2_mmt.Models;

namespace test_2_mmt.Forms.NV_BanHang
{
    public partial class frmTaoHoaDon : Form
    {
        public frmTaoHoaDon()
        {
            InitializeComponent();
        }

        private void frmTaoHoaDon_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            LoadMatHang();
            dtpNgayLap.Value = DateTime.Now;

            txtNhanVien.Text = LoggedInUser.TenNhanVien ?? "(Không xác định)";
            txtNhanVien.ReadOnly = true;
            txtNhanVien.BackColor = SystemColors.Control;
            txtNhanVien.TabStop = false;

            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.MultiSelect = false; // Chỉ cho chọn 1 dòng
            dgvChiTiet.ReadOnly = true;               // Toàn bộ dgv không cho sửa
            dgvChiTiet.AllowUserToAddRows = false;    // Không cho thêm dòng trống cuối
            dgvChiTiet.AllowUserToDeleteRows = false; // Không cho xóa dòng bằng phím Delete

        }

        private void LoadKhachHang()
        {
            using (var db = new Model1())
            {
                var dsKH = db.KHACH_HANG
                             .Where(k => k.VOHIEUHOA == false)
                             .Select(k => new { k.MAKH, k.TENKH })
                             .ToList();

                cboKhachHang.DataSource = dsKH;
                cboKhachHang.DisplayMember = "TENKH";
                cboKhachHang.ValueMember = "MAKH";
            }
        }

        private void LoadMatHang()
        {
            using (var db = new Model1())
            {
                var dsMH = db.MAT_HANG
                             .Where(m => m.VOHIEUHOA == false)
                             .Select(m => new { m.MAMH, m.TENMH })
                             .ToList();

                cboMatHang.DataSource = dsMH;
                cboMatHang.DisplayMember = "TENMH";
                cboMatHang.ValueMember = "MAMH";
            }
        }

        private void btnThemMatHang_Click(object sender, EventArgs e)
        {
            if (cboMatHang.SelectedValue == null || string.IsNullOrWhiteSpace(txtSoLuong.Text))
                return;

            string mamh = cboMatHang.SelectedValue.ToString();
            string tenmh = cboMatHang.Text;
            int soluongMoi = int.Parse(txtSoLuong.Text);

            using (var db = new Model1())
            {
                var matHang = db.MAT_HANG.FirstOrDefault(m => m.MAMH == mamh);
                if (matHang == null) return;

                decimal giaban = matHang.GIABAN ?? 0;

                // 🔍 Kiểm tra xem hàng này đã có trong dgv chưa
                bool daCo = false;

                foreach (DataGridViewRow row in dgvChiTiet.Rows)
                {
                    if (row.Cells["MAMH"].Value?.ToString() == mamh)
                    {
                        // ➕ Cộng thêm số lượng và cập nhật thành tiền
                        int slCu = Convert.ToInt32(row.Cells["SOLUONG"].Value);
                        int slMoi = slCu + soluongMoi;

                        row.Cells["SOLUONG"].Value = slMoi;
                        row.Cells["THANHTIEN"].Value = giaban * slMoi;

                        daCo = true;
                        break;
                    }
                }

                // ❌ Nếu chưa có thì thêm mới
                if (!daCo)
                {
                    decimal thanhtien = giaban * soluongMoi;
                    dgvChiTiet.Rows.Add(mamh, tenmh, giaban, soluongMoi, thanhtien);
                }

                TinhTongTien();
            }
        }

        private void TinhTongTien()
        {
            decimal tong = 0;
            foreach (DataGridViewRow row in dgvChiTiet.Rows)
            {
                if (row.Cells["THANHTIEN"].Value != null)
                    tong += Convert.ToDecimal(row.Cells["THANHTIEN"].Value);
            }
            lblTongTien.Text = "Tổng: " + tong.ToString("N0") + " đ";
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            frmThemKhachHang frm = new frmThemKhachHang();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadKhachHang();
                cboKhachHang.SelectedValue = frm.MaKHMoi;
            }
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (cboKhachHang.SelectedValue == null || dgvChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng và thêm ít nhất 1 mặt hàng.");
                return;
            }

            int makh = Convert.ToInt32(cboKhachHang.SelectedValue);
            string manv = LoggedInUser.MaNhanVien ?? "UNKNOWN";
            DateTime ngaylap = dtpNgayLap.Value;

            using (var db = new Model1())
            {
                int nextMaHD = 1;
                if (db.HOA_DON.Any())
                    nextMaHD = db.HOA_DON.Max(h => h.MAHOADON) + 1;

                var hd = new HOA_DON
                {
                    MAHOADON = nextMaHD,
                    NGAYLAP = ngaylap,
                    MANHANVIEN = manv,
                    MAKH = makh
                };

                db.HOA_DON.Add(hd);
                db.SaveChanges();

                foreach (DataGridViewRow row in dgvChiTiet.Rows)
                {
                    try
                    {
                        if (row.Cells["MAMH"]?.Value == null) continue;

                        string mamh = row.Cells["MAMH"].Value.ToString();
                        int soluong = Convert.ToInt32(row.Cells["SOLUONG"].Value);
                        double thanhtien = Convert.ToDouble(row.Cells["THANHTIEN"].Value);

                        var ct = new HOADON_MATHANG
                        {
                            MAHD = nextMaHD,
                            MAMH = mamh,
                            SOLUONGMUA = soluong,
                            THANHTIEN = thanhtien
                        };

                        db.HOADON_MATHANG.Add(ct);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi dòng mặt hàng: " + ex.Message);
                    }
                }

                db.SaveChanges();
            }

            MessageBox.Show("Lưu hóa đơn thành công!");
            dgvChiTiet.Rows.Clear();
            TinhTongTien();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Bạn có chắc muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dgvChiTiet.Rows.RemoveAt(dgvChiTiet.SelectedRows[0].Index);
                    TinhTongTien(); // Cập nhật lại tổng tiền
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }

        private void btnTruMot_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.SelectedRows.Count == 0) return;

            DataGridViewRow row = dgvChiTiet.SelectedRows[0];

            int slHienTai = Convert.ToInt32(row.Cells["SOLUONG"].Value);

            if (slHienTai > 1)
            {
                slHienTai -= 1;
                row.Cells["SOLUONG"].Value = slHienTai;

                decimal giaban = Convert.ToDecimal(row.Cells["GIABAN"].Value);
                row.Cells["THANHTIEN"].Value = giaban * slHienTai;

                TinhTongTien();
            }
            else
            {
                MessageBox.Show("Số lượng tối thiểu là 1. Nếu muốn xóa, hãy dùng nút 'Xóa Hàng'.");
            }
        }

        private void btnCongMot_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.SelectedRows.Count == 0) return;

            DataGridViewRow row = dgvChiTiet.SelectedRows[0];

            int slHienTai = Convert.ToInt32(row.Cells["SOLUONG"].Value);
            slHienTai += 1;
            row.Cells["SOLUONG"].Value = slHienTai;

            decimal giaban = Convert.ToDecimal(row.Cells["GIABAN"].Value);
            row.Cells["THANHTIEN"].Value = giaban * slHienTai;

            TinhTongTien();
        }

        private void btnXoaAll_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Không có mặt hàng nào để xóa.");
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ mặt hàng trong hóa đơn?",
                                         "Xác nhận xóa tất cả",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                dgvChiTiet.Rows.Clear();
                TinhTongTien();
            }
        }
    }
}
