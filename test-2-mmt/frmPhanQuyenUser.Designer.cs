namespace test_2_mmt
{
    partial class frmPhanQuyenUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanQuyenUser));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQLNhanVienQL = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvQLNhanVienBH = new System.Windows.Forms.DataGridView();
            this.colTenDangNhap2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhanVien2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pcbSearchBH = new System.Windows.Forms.PictureBox();
            this.colThayDoi2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pcbSearchQL = new System.Windows.Forms.PictureBox();
            this.colThayDoi = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtSearchQL = new System.Windows.Forms.TextBox();
            this.txtSearchBH = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNhanVienQL)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNhanVienBH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSearchBH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSearchQL)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchQL);
            this.groupBox1.Controls.Add(this.pcbSearchQL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvQLNhanVienQL);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1273, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhân viên quản lý";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drag a column header here to group by that column";
            // 
            // dgvQLNhanVienQL
            // 
            this.dgvQLNhanVienQL.AllowUserToAddRows = false;
            this.dgvQLNhanVienQL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLNhanVienQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLNhanVienQL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colThayDoi,
            this.colTenDangNhap,
            this.colTenNhanVien,
            this.colSDT,
            this.colGioiTinh,
            this.colNgaySinh});
            this.dgvQLNhanVienQL.Location = new System.Drawing.Point(6, 63);
            this.dgvQLNhanVienQL.Name = "dgvQLNhanVienQL";
            this.dgvQLNhanVienQL.RowHeadersWidth = 51;
            this.dgvQLNhanVienQL.RowTemplate.Height = 24;
            this.dgvQLNhanVienQL.Size = new System.Drawing.Size(1261, 252);
            this.dgvQLNhanVienQL.TabIndex = 0;
            this.dgvQLNhanVienQL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLNhanVienQL_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearchBH);
            this.groupBox2.Controls.Add(this.pcbSearchBH);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dgvQLNhanVienBH);
            this.groupBox2.Location = new System.Drawing.Point(12, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1273, 323);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhân viên bán hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drag a column header here to group by that column";
            // 
            // dgvQLNhanVienBH
            // 
            this.dgvQLNhanVienBH.AllowUserToAddRows = false;
            this.dgvQLNhanVienBH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLNhanVienBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLNhanVienBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colThayDoi2,
            this.colTenDangNhap2,
            this.colTenNhanVien2,
            this.colSDT2,
            this.colGioiTinh2,
            this.colNgaySinh2});
            this.dgvQLNhanVienBH.Location = new System.Drawing.Point(6, 64);
            this.dgvQLNhanVienBH.Name = "dgvQLNhanVienBH";
            this.dgvQLNhanVienBH.RowHeadersWidth = 51;
            this.dgvQLNhanVienBH.RowTemplate.Height = 24;
            this.dgvQLNhanVienBH.Size = new System.Drawing.Size(1261, 225);
            this.dgvQLNhanVienBH.TabIndex = 0;
            this.dgvQLNhanVienBH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLNhanVienBH_CellClick);
            // 
            // colTenDangNhap2
            // 
            this.colTenDangNhap2.HeaderText = "TÊN ĐĂNG NHẬP";
            this.colTenDangNhap2.MinimumWidth = 6;
            this.colTenDangNhap2.Name = "colTenDangNhap2";
            // 
            // colTenNhanVien2
            // 
            this.colTenNhanVien2.HeaderText = "TÊN NHÂN VIÊN";
            this.colTenNhanVien2.MinimumWidth = 6;
            this.colTenNhanVien2.Name = "colTenNhanVien2";
            // 
            // colSDT2
            // 
            this.colSDT2.HeaderText = "SỐ ĐIỆN THOẠI";
            this.colSDT2.MinimumWidth = 6;
            this.colSDT2.Name = "colSDT2";
            // 
            // colGioiTinh2
            // 
            this.colGioiTinh2.HeaderText = "GIỚI TÍNH";
            this.colGioiTinh2.MinimumWidth = 6;
            this.colGioiTinh2.Name = "colGioiTinh2";
            // 
            // colNgaySinh2
            // 
            this.colNgaySinh2.HeaderText = "NGÀY SINH";
            this.colNgaySinh2.MinimumWidth = 6;
            this.colNgaySinh2.Name = "colNgaySinh2";
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.HeaderText = "TÊN ĐĂNG NHẬP";
            this.colTenDangNhap.MinimumWidth = 6;
            this.colTenDangNhap.Name = "colTenDangNhap";
            // 
            // colTenNhanVien
            // 
            this.colTenNhanVien.HeaderText = "TÊN NHÂN VIÊN";
            this.colTenNhanVien.MinimumWidth = 6;
            this.colTenNhanVien.Name = "colTenNhanVien";
            // 
            // colSDT
            // 
            this.colSDT.HeaderText = "SỐ ĐIỆN THOẠI";
            this.colSDT.MinimumWidth = 6;
            this.colSDT.Name = "colSDT";
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.HeaderText = "GIỚI TÍNH";
            this.colGioiTinh.MinimumWidth = 6;
            this.colGioiTinh.Name = "colGioiTinh";
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.HeaderText = "NGÀY SINH";
            this.colNgaySinh.MinimumWidth = 6;
            this.colNgaySinh.Name = "colNgaySinh";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "THAY ĐỔI";
            this.dataGridViewImageColumn1.Image = global::test_2_mmt.Properties.Resources.down;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 201;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "THAY ĐỔI";
            this.dataGridViewImageColumn2.Image = global::test_2_mmt.Properties.Resources.up;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 201;
            // 
            // pcbSearchBH
            // 
            this.pcbSearchBH.Image = global::test_2_mmt.Properties.Resources.search;
            this.pcbSearchBH.Location = new System.Drawing.Point(1219, 21);
            this.pcbSearchBH.Name = "pcbSearchBH";
            this.pcbSearchBH.Size = new System.Drawing.Size(39, 37);
            this.pcbSearchBH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbSearchBH.TabIndex = 2;
            this.pcbSearchBH.TabStop = false;
            this.pcbSearchBH.Click += new System.EventHandler(this.pcbSearchBH_Click);
            // 
            // colThayDoi2
            // 
            this.colThayDoi2.HeaderText = "THAY ĐỔI";
            this.colThayDoi2.Image = global::test_2_mmt.Properties.Resources.up;
            this.colThayDoi2.MinimumWidth = 6;
            this.colThayDoi2.Name = "colThayDoi2";
            this.colThayDoi2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colThayDoi2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pcbSearchQL
            // 
            this.pcbSearchQL.Image = global::test_2_mmt.Properties.Resources.search;
            this.pcbSearchQL.InitialImage = null;
            this.pcbSearchQL.Location = new System.Drawing.Point(1219, 21);
            this.pcbSearchQL.Name = "pcbSearchQL";
            this.pcbSearchQL.Size = new System.Drawing.Size(39, 31);
            this.pcbSearchQL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbSearchQL.TabIndex = 2;
            this.pcbSearchQL.TabStop = false;
            this.pcbSearchQL.Click += new System.EventHandler(this.pcbSearchQL_Click);
            // 
            // colThayDoi
            // 
            this.colThayDoi.HeaderText = "THAY ĐỔI";
            this.colThayDoi.Image = ((System.Drawing.Image)(resources.GetObject("colThayDoi.Image")));
            this.colThayDoi.MinimumWidth = 6;
            this.colThayDoi.Name = "colThayDoi";
            this.colThayDoi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colThayDoi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtSearchQL
            // 
            this.txtSearchQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearchQL.Location = new System.Drawing.Point(663, 22);
            this.txtSearchQL.Name = "txtSearchQL";
            this.txtSearchQL.Size = new System.Drawing.Size(550, 30);
            this.txtSearchQL.TabIndex = 3;
            // 
            // txtSearchBH
            // 
            this.txtSearchBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearchBH.Location = new System.Drawing.Point(663, 27);
            this.txtSearchBH.Name = "txtSearchBH";
            this.txtSearchBH.Size = new System.Drawing.Size(550, 30);
            this.txtSearchBH.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogout.Location = new System.Drawing.Point(1036, 668);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(214, 42);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmPhanQuyenUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 722);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPhanQuyenUser";
            this.Text = "frmPhanQuyenUser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNhanVienQL)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNhanVienBH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSearchBH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSearchQL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvQLNhanVienBH;
        private System.Windows.Forms.DataGridView dgvQLNhanVienQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcbSearchQL;
        private System.Windows.Forms.PictureBox pcbSearchBH;
        private System.Windows.Forms.DataGridViewImageColumn colThayDoi2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDangNhap2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhanVien2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn colThayDoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.TextBox txtSearchQL;
        private System.Windows.Forms.TextBox txtSearchBH;
        private System.Windows.Forms.Button btnLogout;
    }
}