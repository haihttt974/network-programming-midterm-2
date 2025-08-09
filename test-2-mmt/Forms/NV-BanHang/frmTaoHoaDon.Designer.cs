namespace test_2_mmt.Forms.NV_BanHang
{
    partial class frmTaoHoaDon
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.btnThemKhachHang = new System.Windows.Forms.Button();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbHoaDon = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMatHang = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnThemMatHang = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.btnLuuHoaDon = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.MAMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoaHang = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCongMot = new System.Windows.Forms.Button();
            this.btnTruMot = new System.Windows.Forms.Button();
            this.btnXoaAll = new System.Windows.Forms.Button();
            this.grbHoaDon.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNhanVien.Location = new System.Drawing.Point(452, 12);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(336, 28);
            this.txtNhanVien.TabIndex = 11;
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemKhachHang.Location = new System.Drawing.Point(314, 136);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Size = new System.Drawing.Size(436, 35);
            this.btnThemKhachHang.TabIndex = 10;
            this.btnThemKhachHang.Text = "Thêm khách hàng";
            this.btnThemKhachHang.UseVisualStyleBackColor = true;
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(314, 93);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(436, 30);
            this.cboKhachHang.TabIndex = 9;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayLap.Location = new System.Drawing.Point(314, 45);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(436, 28);
            this.dtpNgayLap.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(47, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ngày lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(47, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Danh sách khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(47, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Thêm khách hàng";
            // 
            // grbHoaDon
            // 
            this.grbHoaDon.Controls.Add(this.label1);
            this.grbHoaDon.Controls.Add(this.label3);
            this.grbHoaDon.Controls.Add(this.dtpNgayLap);
            this.grbHoaDon.Controls.Add(this.btnThemKhachHang);
            this.grbHoaDon.Controls.Add(this.label2);
            this.grbHoaDon.Controls.Add(this.cboKhachHang);
            this.grbHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbHoaDon.Location = new System.Drawing.Point(12, 37);
            this.grbHoaDon.Name = "grbHoaDon";
            this.grbHoaDon.Size = new System.Drawing.Size(776, 192);
            this.grbHoaDon.TabIndex = 13;
            this.grbHoaDon.TabStop = false;
            this.grbHoaDon.Text = "Hóa đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblTongTien);
            this.groupBox1.Controls.Add(this.dgvChiTiet);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnLuuHoaDon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.cboMatHang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 562);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết mặt hàng";
            // 
            // cboMatHang
            // 
            this.cboMatHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMatHang.FormattingEnabled = true;
            this.cboMatHang.Location = new System.Drawing.Point(225, 48);
            this.cboMatHang.Name = "cboMatHang";
            this.cboMatHang.Size = new System.Drawing.Size(378, 30);
            this.cboMatHang.TabIndex = 0;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(225, 100);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(111, 28);
            this.txtSoLuong.TabIndex = 1;
            // 
            // btnThemMatHang
            // 
            this.btnThemMatHang.Location = new System.Drawing.Point(6, 27);
            this.btnThemMatHang.Name = "btnThemMatHang";
            this.btnThemMatHang.Size = new System.Drawing.Size(230, 38);
            this.btnThemMatHang.TabIndex = 2;
            this.btnThemMatHang.Text = "Thêm vào chi tiết mua";
            this.btnThemMatHang.UseVisualStyleBackColor = true;
            this.btnThemMatHang.Click += new System.EventHandler(this.btnThemMatHang_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(18, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Danh sách sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(18, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nhập số lượng";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAMH,
            this.TENMH,
            this.GIABAN,
            this.SOLUONG,
            this.THANHTIEN});
            this.dgvChiTiet.Location = new System.Drawing.Point(22, 232);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersWidth = 51;
            this.dgvChiTiet.RowTemplate.Height = 24;
            this.dgvChiTiet.Size = new System.Drawing.Size(728, 265);
            this.dgvChiTiet.TabIndex = 13;
            // 
            // btnLuuHoaDon
            // 
            this.btnLuuHoaDon.Location = new System.Drawing.Point(634, 503);
            this.btnLuuHoaDon.Name = "btnLuuHoaDon";
            this.btnLuuHoaDon.Size = new System.Drawing.Size(116, 38);
            this.btnLuuHoaDon.TabIndex = 2;
            this.btnLuuHoaDon.Text = "Lưu";
            this.btnLuuHoaDon.UseVisualStyleBackColor = true;
            this.btnLuuHoaDon.Click += new System.EventHandler(this.btnLuuHoaDon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(520, 503);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(99, 38);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(18, 511);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(87, 22);
            this.lblTongTien.TabIndex = 14;
            this.lblTongTien.Text = "Tổng: .....";
            // 
            // MAMH
            // 
            this.MAMH.HeaderText = "Mã MH";
            this.MAMH.MinimumWidth = 6;
            this.MAMH.Name = "MAMH";
            // 
            // TENMH
            // 
            this.TENMH.HeaderText = "Tên MH";
            this.TENMH.MinimumWidth = 6;
            this.TENMH.Name = "TENMH";
            // 
            // GIABAN
            // 
            this.GIABAN.HeaderText = "Đơn giá";
            this.GIABAN.MinimumWidth = 6;
            this.GIABAN.Name = "GIABAN";
            // 
            // SOLUONG
            // 
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.HeaderText = "Thành tiền";
            this.THANHTIEN.MinimumWidth = 6;
            this.THANHTIEN.Name = "THANHTIEN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(291, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tên nhân viên: ";
            // 
            // btnXoaHang
            // 
            this.btnXoaHang.Location = new System.Drawing.Point(473, 27);
            this.btnXoaHang.Name = "btnXoaHang";
            this.btnXoaHang.Size = new System.Drawing.Size(124, 38);
            this.btnXoaHang.TabIndex = 2;
            this.btnXoaHang.Text = "Xóa hàng";
            this.btnXoaHang.UseVisualStyleBackColor = true;
            this.btnXoaHang.Click += new System.EventHandler(this.btnXoaHang_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTruMot);
            this.groupBox2.Controls.Add(this.btnCongMot);
            this.groupBox2.Controls.Add(this.btnXoaAll);
            this.groupBox2.Controls.Add(this.btnXoaHang);
            this.groupBox2.Controls.Add(this.btnThemMatHang);
            this.groupBox2.Location = new System.Drawing.Point(22, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 79);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // btnCongMot
            // 
            this.btnCongMot.Location = new System.Drawing.Point(398, 27);
            this.btnCongMot.Name = "btnCongMot";
            this.btnCongMot.Size = new System.Drawing.Size(69, 38);
            this.btnCongMot.TabIndex = 2;
            this.btnCongMot.Text = "+ 1";
            this.btnCongMot.UseVisualStyleBackColor = true;
            this.btnCongMot.Click += new System.EventHandler(this.btnCongMot_Click);
            // 
            // btnTruMot
            // 
            this.btnTruMot.Location = new System.Drawing.Point(325, 27);
            this.btnTruMot.Name = "btnTruMot";
            this.btnTruMot.Size = new System.Drawing.Size(67, 38);
            this.btnTruMot.TabIndex = 2;
            this.btnTruMot.Text = "- 1";
            this.btnTruMot.UseVisualStyleBackColor = true;
            this.btnTruMot.Click += new System.EventHandler(this.btnTruMot_Click);
            // 
            // btnXoaAll
            // 
            this.btnXoaAll.Location = new System.Drawing.Point(603, 27);
            this.btnXoaAll.Name = "btnXoaAll";
            this.btnXoaAll.Size = new System.Drawing.Size(124, 38);
            this.btnXoaAll.TabIndex = 2;
            this.btnXoaAll.Text = "Xóa tất cả";
            this.btnXoaAll.UseVisualStyleBackColor = true;
            this.btnXoaAll.Click += new System.EventHandler(this.btnXoaAll_Click);
            // 
            // frmTaoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 809);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbHoaDon);
            this.Controls.Add(this.txtNhanVien);
            this.Name = "frmTaoHoaDon";
            this.Text = "frmTaoHoaDon";
            this.Load += new System.EventHandler(this.frmTaoHoaDon_Load);
            this.grbHoaDon.ResumeLayout(false);
            this.grbHoaDon.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Button btnThemKhachHang;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemMatHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cboMatHang;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuuHoaDon;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIABAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoaHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTruMot;
        private System.Windows.Forms.Button btnCongMot;
        private System.Windows.Forms.Button btnXoaAll;
    }
}