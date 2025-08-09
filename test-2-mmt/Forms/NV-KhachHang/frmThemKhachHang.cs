using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_2_mmt.Models;

namespace test_2_mmt.Forms.NV_KhachHang
{
    public partial class frmThemKhachHang : Form
    {
        public int MaKHMoi { get; private set; }
        public frmThemKhachHang()
        {
            InitializeComponent();
            cboGioiTinh.Items.AddRange(new string[] { "Nam", "Nữ", "Khác" });
            cboGioiTinh.SelectedIndex = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenKH = txtTenKH.Text.Trim();
            string gioiTinh = cboGioiTinh.Text;
            string sdt = txtSDT.Text.Trim();

            if (string.IsNullOrEmpty(tenKH))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new Model1())
            {
                var khachHang = new KHACH_HANG
                {
                    TENKH = tenKH,
                    GIOITINH = gioiTinh,
                    SDT = string.IsNullOrWhiteSpace(sdt) ? null : sdt,
                    VOHIEUHOA = false
                };

                db.KHACH_HANG.Add(khachHang);
                db.SaveChanges();

                MaKHMoi = khachHang.MAKH; // EF tự lấy identity
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
