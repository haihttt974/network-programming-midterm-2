using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_2_mmt.Forms.NV_BanHang;
using test_2_mmt.Forms.NV_HeThong;

namespace test_2_mmt
{
    public partial class frmNhanVien : Form
    {
        private string maNhanVienDangNhap;

        public frmNhanVien(string maNV)
        {
            InitializeComponent();
            this.maNhanVienDangNhap = maNV;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmLogin loginForm = new frmLogin();
                loginForm.Show(); 
                this.Close();
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau(maNhanVienDangNhap);
            frm.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tạoHóaĐơnMớToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmTaoHoaDon();
            frm.ShowDialog();
        }
    }
}
