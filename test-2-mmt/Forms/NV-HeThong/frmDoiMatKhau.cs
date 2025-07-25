using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_2_mmt.Models;

namespace test_2_mmt.Forms.NV_HeThong
{
    public partial class frmDoiMatKhau : Form
    {
        private string manv;
        public frmDoiMatKhau(string manvDangNhap)
        {
            InitializeComponent();
            this.manv = manvDangNhap;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string oldPass = txtOldPass.Text.Trim();
            string newPass = txtNewPass.Text.Trim();
            string confirm = txtConfirm.Text.Trim();

            if (string.IsNullOrEmpty(oldPass) || string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirm))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass != confirm)
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new Model1()) // hoặc DBContext nếu bạn đổi tên
                {
                    var nhanVien = db.NHAN_VIEN.FirstOrDefault(nv => nv.MANHANVIEN == manv);

                    if (nhanVien == null)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string oldPassHashed = TinhMD5(oldPass);
                    if (nhanVien.MATKHAU != oldPassHashed)
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    nhanVien.MATKHAU = TinhMD5(newPass);
                    db.SaveChanges();

                    MessageBox.Show("Đổi mật khẩu thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đổi mật khẩu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string TinhMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                    sb.Append(b.ToString("x2")); // 2 chữ số hex thường
                return sb.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOldPass_Enter(object sender, EventArgs e)
        {
            if (txtOldPass.Text == "Old Password")
            {
                txtOldPass.Text = "";
                txtOldPass.ForeColor = Color.Black;
            }
        }

        private void txtOldPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOldPass.Text))
            {
                txtOldPass.Text = "Old Password";
                txtOldPass.ForeColor = Color.Silver;
            }
        }

        private void txtNewPass_Enter(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "New Password")
            {
                txtNewPass.Text = "";
                txtNewPass.ForeColor = Color.Black;
            }
        }

        private void txtNewPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewPass.Text))
            {
                txtNewPass.Text = "New Password";
                txtNewPass.ForeColor = Color.Silver;
            }
        }

        private void txtConfirm_Enter(object sender, EventArgs e)
        {
            if (txtConfirm.Text == "Confirm Password")
            {
                txtConfirm.Text = "";
                txtConfirm.ForeColor = Color.Black;
            }
        }

        private void txtConfirm_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirm.Text))
            {
                txtConfirm.Text = "Confirm Password";
                txtConfirm.ForeColor = Color.Silver;
            }
        }
    }
}
