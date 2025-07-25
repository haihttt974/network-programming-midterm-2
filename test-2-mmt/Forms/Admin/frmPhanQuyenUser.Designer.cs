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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchQL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQLNhanVienQL = new System.Windows.Forms.DataGridView();
            this.colTenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearchBH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvQLNhanVienBH = new System.Windows.Forms.DataGridView();
            this.colTenDangNhap2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhanVien2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBoxGioiTinh = new System.Windows.Forms.GroupBox();
            this.rdoKhac = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.txtDiaChi = new System.Windows.Forms.RichTextBox();
            this.cmbQuyen = new System.Windows.Forms.ComboBox();
            this.rdoNoHoatDong = new System.Windows.Forms.RadioButton();
            this.rdoYesHoatDong = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.lblHoatDong = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.lblSdt = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNhanVienQL)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNhanVienBH)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBoxGioiTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchQL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvQLNhanVienQL);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1273, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhân viên quản lý";
            // 
            // txtSearchQL
            // 
            this.txtSearchQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearchQL.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchQL.Location = new System.Drawing.Point(579, 22);
            this.txtSearchQL.Name = "txtSearchQL";
            this.txtSearchQL.Size = new System.Drawing.Size(688, 27);
            this.txtSearchQL.TabIndex = 3;
            this.txtSearchQL.Text = "Tìm kiếm nhân viên quản lý.....";
            this.txtSearchQL.TextChanged += new System.EventHandler(this.txtSearchQL_TextChanged);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearchBH);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dgvQLNhanVienBH);
            this.groupBox2.Location = new System.Drawing.Point(12, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1273, 323);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhân viên bán hàng";
            // 
            // txtSearchBH
            // 
            this.txtSearchBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearchBH.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchBH.Location = new System.Drawing.Point(579, 27);
            this.txtSearchBH.Name = "txtSearchBH";
            this.txtSearchBH.Size = new System.Drawing.Size(688, 27);
            this.txtSearchBH.TabIndex = 4;
            this.txtSearchBH.TextChanged += new System.EventHandler(this.txtSearchBH_TextChanged);
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
            this.colTenDangNhap2,
            this.colTenNhanVien2,
            this.colSDT2,
            this.colGioiTinh2,
            this.colNgaySinh2});
            this.dgvQLNhanVienBH.Location = new System.Drawing.Point(6, 64);
            this.dgvQLNhanVienBH.Name = "dgvQLNhanVienBH";
            this.dgvQLNhanVienBH.RowHeadersWidth = 51;
            this.dgvQLNhanVienBH.RowTemplate.Height = 24;
            this.dgvQLNhanVienBH.Size = new System.Drawing.Size(1261, 253);
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
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogout.Location = new System.Drawing.Point(313, 602);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(173, 42);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBoxGioiTinh);
            this.groupBox3.Controls.Add(this.txtDiaChi);
            this.groupBox3.Controls.Add(this.cmbQuyen);
            this.groupBox3.Controls.Add(this.rdoNoHoatDong);
            this.groupBox3.Controls.Add(this.rdoYesHoatDong);
            this.groupBox3.Controls.Add(this.dtpNgaySinh);
            this.groupBox3.Controls.Add(this.lblQuyen);
            this.groupBox3.Controls.Add(this.lblHoatDong);
            this.groupBox3.Controls.Add(this.lblNgaySinh);
            this.groupBox3.Controls.Add(this.txtSdt);
            this.groupBox3.Controls.Add(this.lblSdt);
            this.groupBox3.Controls.Add(this.lblDiaChi);
            this.groupBox3.Controls.Add(this.txtTenDangNhap);
            this.groupBox3.Controls.Add(this.lblTenDangNhap);
            this.groupBox3.Controls.Add(this.txtTenNhanVien);
            this.groupBox3.Controls.Add(this.lblTenNhanVien);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnLogout);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1291, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(492, 650);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết nhân viên";
            // 
            // groupBoxGioiTinh
            // 
            this.groupBoxGioiTinh.Controls.Add(this.rdoKhac);
            this.groupBoxGioiTinh.Controls.Add(this.rdoNam);
            this.groupBoxGioiTinh.Controls.Add(this.rdoNu);
            this.groupBoxGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxGioiTinh.Location = new System.Drawing.Point(22, 313);
            this.groupBoxGioiTinh.Name = "groupBoxGioiTinh";
            this.groupBoxGioiTinh.Size = new System.Drawing.Size(464, 70);
            this.groupBoxGioiTinh.TabIndex = 8;
            this.groupBoxGioiTinh.TabStop = false;
            this.groupBoxGioiTinh.Text = "Giới tính";
            // 
            // rdoKhac
            // 
            this.rdoKhac.AutoSize = true;
            this.rdoKhac.Location = new System.Drawing.Point(341, 30);
            this.rdoKhac.Name = "rdoKhac";
            this.rdoKhac.Size = new System.Drawing.Size(72, 24);
            this.rdoKhac.TabIndex = 5;
            this.rdoKhac.TabStop = true;
            this.rdoKhac.Text = "Khác";
            this.rdoKhac.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(72, 28);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(68, 24);
            this.rdoNam.TabIndex = 5;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(211, 30);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(53, 24);
            this.rdoNu.TabIndex = 5;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(169, 169);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(317, 53);
            this.txtDiaChi.TabIndex = 7;
            this.txtDiaChi.Text = "";
            // 
            // cmbQuyen
            // 
            this.cmbQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuyen.FormattingEnabled = true;
            this.cmbQuyen.Items.AddRange(new object[] {
            "Quản lý",
            "Bán hàng"});
            this.cmbQuyen.Location = new System.Drawing.Point(169, 513);
            this.cmbQuyen.Name = "cmbQuyen";
            this.cmbQuyen.Size = new System.Drawing.Size(317, 32);
            this.cmbQuyen.TabIndex = 6;
            // 
            // rdoNoHoatDong
            // 
            this.rdoNoHoatDong.AutoSize = true;
            this.rdoNoHoatDong.Location = new System.Drawing.Point(352, 460);
            this.rdoNoHoatDong.Name = "rdoNoHoatDong";
            this.rdoNoHoatDong.Size = new System.Drawing.Size(56, 28);
            this.rdoNoHoatDong.TabIndex = 5;
            this.rdoNoHoatDong.TabStop = true;
            this.rdoNoHoatDong.Text = "No";
            this.rdoNoHoatDong.UseVisualStyleBackColor = true;
            // 
            // rdoYesHoatDong
            // 
            this.rdoYesHoatDong.AutoSize = true;
            this.rdoYesHoatDong.Location = new System.Drawing.Point(216, 461);
            this.rdoYesHoatDong.Name = "rdoYesHoatDong";
            this.rdoYesHoatDong.Size = new System.Drawing.Size(60, 28);
            this.rdoYesHoatDong.TabIndex = 5;
            this.rdoYesHoatDong.TabStop = true;
            this.rdoYesHoatDong.Text = "Yes";
            this.rdoYesHoatDong.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(169, 393);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(317, 29);
            this.dtpNgaySinh.TabIndex = 4;
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyen.Location = new System.Drawing.Point(18, 515);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(63, 22);
            this.lblQuyen.TabIndex = 2;
            this.lblQuyen.Text = "Quyền";
            // 
            // lblHoatDong
            // 
            this.lblHoatDong.AutoSize = true;
            this.lblHoatDong.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoatDong.Location = new System.Drawing.Point(18, 460);
            this.lblHoatDong.Name = "lblHoatDong";
            this.lblHoatDong.Size = new System.Drawing.Size(99, 22);
            this.lblHoatDong.TabIndex = 2;
            this.lblHoatDong.Text = "Hoạt động";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(18, 395);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(89, 22);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSdt.Location = new System.Drawing.Point(169, 260);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(317, 27);
            this.txtSdt.TabIndex = 3;
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSdt.Location = new System.Drawing.Point(18, 265);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(121, 22);
            this.lblSdt.TabIndex = 2;
            this.lblSdt.Text = "Số điện thoại";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(18, 172);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(66, 22);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(169, 109);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.ReadOnly = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(317, 27);
            this.txtTenDangNhap.TabIndex = 3;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.Location = new System.Drawing.Point(18, 114);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(134, 22);
            this.lblTenDangNhap.TabIndex = 2;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNhanVien.Location = new System.Drawing.Point(169, 57);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(317, 27);
            this.txtTenNhanVien.TabIndex = 3;
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhanVien.Location = new System.Drawing.Point(18, 62);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(121, 22);
            this.lblTenNhanVien.TabIndex = 2;
            this.lblTenNhanVien.Text = "Tên nhân viên";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.Location = new System.Drawing.Point(151, 602);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 42);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmPhanQuyenUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1795, 674);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPhanQuyenUser";
            this.Text = "frmPhanQuyenUser";
            this.Load += new System.EventHandler(this.frmPhanQuyenUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNhanVienQL)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNhanVienBH)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxGioiTinh.ResumeLayout(false);
            this.groupBoxGioiTinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvQLNhanVienBH;
        private System.Windows.Forms.DataGridView dgvQLNhanVienQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TextBox txtSearchQL;
        private System.Windows.Forms.TextBox txtSearchBH;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label lblHoatDong;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.ComboBox cmbQuyen;
        private System.Windows.Forms.RadioButton rdoNoHoatDong;
        private System.Windows.Forms.RadioButton rdoYesHoatDong;
        private System.Windows.Forms.RichTextBox txtDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDangNhap2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhanVien2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh2;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdoKhac;
        private System.Windows.Forms.GroupBox groupBoxGioiTinh;
    }
}