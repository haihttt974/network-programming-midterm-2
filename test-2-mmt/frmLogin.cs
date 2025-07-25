using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_2_mmt.Data_;

namespace test_2_mmt
{
    public partial class frmLogin : Form
    {
        private Model1 dbContext;

        public frmLogin()
        {
            InitializeComponent();
            dbContext = new Model1();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string hashedPassword = GetMD5Hash(password);

                var user = dbContext.NHAN_VIEN
                    .FirstOrDefault(nv => nv.TENDANGNHAP == username && nv.MATKHAU == hashedPassword);

                if (user != null)
                {
                    if (user.VOHIEUHOA == true)
                    {
                        MessageBox.Show("Tài khoản đã bị vô hiệu hóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show($"Xin chào {(user.LAQUANLY == true ? "quản lý" : "nhân viên bán hàng")}!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (user.LAQUANLY == true)
                    {
                        frmPhanQuyenUser mainForm = new frmPhanQuyenUser(user); // Truyền user
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        frmNhanVien staffForm = new frmNhanVien();
                        staffForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}