namespace test_2_mmt
{
    partial class frmNhanVien
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoHóaĐơnMớToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuMặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuTheoLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trangCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhSốBánHàngcáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmBánChạyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuPhầnMềmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem1,
            this.bánHàngToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.traCứuToolStripMenuItem,
            this.trangCáNhânToolStripMenuItem,
            this.hệThốngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem1
            // 
            this.hệThốngToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hệThốngToolStripMenuItem1.Name = "hệThốngToolStripMenuItem1";
            this.hệThốngToolStripMenuItem1.Size = new System.Drawing.Size(87, 25);
            this.hệThốngToolStripMenuItem1.Text = "Hệ thống";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // bánHàngToolStripMenuItem
            // 
            this.bánHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoHóaĐơnMớToolStripMenuItem,
            this.traCứuHóaĐơnToolStripMenuItem});
            this.bánHàngToolStripMenuItem.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            this.bánHàngToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.bánHàngToolStripMenuItem.Text = "Bán hàng";
            // 
            // tạoHóaĐơnMớToolStripMenuItem
            // 
            this.tạoHóaĐơnMớToolStripMenuItem.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tạoHóaĐơnMớToolStripMenuItem.Name = "tạoHóaĐơnMớToolStripMenuItem";
            this.tạoHóaĐơnMớToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tạoHóaĐơnMớToolStripMenuItem.Text = "Tạo hóa đơn mới";
            this.tạoHóaĐơnMớToolStripMenuItem.Click += new System.EventHandler(this.tạoHóaĐơnMớToolStripMenuItem_Click);
            // 
            // traCứuHóaĐơnToolStripMenuItem
            // 
            this.traCứuHóaĐơnToolStripMenuItem.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traCứuHóaĐơnToolStripMenuItem.Name = "traCứuHóaĐơnToolStripMenuItem";
            this.traCứuHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.traCứuHóaĐơnToolStripMenuItem.Text = "Tra cứu hóa đơn";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmKháchHàngToolStripMenuItem,
            this.traCứuKháchHàngToolStripMenuItem});
            this.kháchHàngToolStripMenuItem.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            // 
            // thêmKháchHàngToolStripMenuItem
            // 
            this.thêmKháchHàngToolStripMenuItem.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thêmKháchHàngToolStripMenuItem.Name = "thêmKháchHàngToolStripMenuItem";
            this.thêmKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.thêmKháchHàngToolStripMenuItem.Text = "Thêm khách hàng";
            // 
            // traCứuKháchHàngToolStripMenuItem
            // 
            this.traCứuKháchHàngToolStripMenuItem.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traCứuKháchHàngToolStripMenuItem.Name = "traCứuKháchHàngToolStripMenuItem";
            this.traCứuKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.traCứuKháchHàngToolStripMenuItem.Text = "Tra cứu khách hàng";
            // 
            // traCứuToolStripMenuItem
            // 
            this.traCứuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traCứuMặtHàngToolStripMenuItem,
            this.traCứuTheoLoạiToolStripMenuItem});
            this.traCứuToolStripMenuItem.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traCứuToolStripMenuItem.Name = "traCứuToolStripMenuItem";
            this.traCứuToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.traCứuToolStripMenuItem.Text = "Sản phẩm";
            // 
            // traCứuMặtHàngToolStripMenuItem
            // 
            this.traCứuMặtHàngToolStripMenuItem.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traCứuMặtHàngToolStripMenuItem.Name = "traCứuMặtHàngToolStripMenuItem";
            this.traCứuMặtHàngToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.traCứuMặtHàngToolStripMenuItem.Text = "Tra cứu mặt hàng";
            // 
            // traCứuTheoLoạiToolStripMenuItem
            // 
            this.traCứuTheoLoạiToolStripMenuItem.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traCứuTheoLoạiToolStripMenuItem.Name = "traCứuTheoLoạiToolStripMenuItem";
            this.traCứuTheoLoạiToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.traCứuTheoLoạiToolStripMenuItem.Text = "Tra cứu theo loại";
            // 
            // trangCáNhânToolStripMenuItem
            // 
            this.trangCáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhSốBánHàngcáNhânToolStripMenuItem,
            this.sảnPhẩmBánChạyToolStripMenuItem});
            this.trangCáNhânToolStripMenuItem.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trangCáNhânToolStripMenuItem.Name = "trangCáNhânToolStripMenuItem";
            this.trangCáNhânToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.trangCáNhânToolStripMenuItem.Text = "Thống kê";
            // 
            // doanhSốBánHàngcáNhânToolStripMenuItem
            // 
            this.doanhSốBánHàngcáNhânToolStripMenuItem.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doanhSốBánHàngcáNhânToolStripMenuItem.Name = "doanhSốBánHàngcáNhânToolStripMenuItem";
            this.doanhSốBánHàngcáNhânToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.doanhSốBánHàngcáNhânToolStripMenuItem.Text = "Doanh số bán hàng (cá nhân)";
            // 
            // sảnPhẩmBánChạyToolStripMenuItem
            // 
            this.sảnPhẩmBánChạyToolStripMenuItem.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sảnPhẩmBánChạyToolStripMenuItem.Name = "sảnPhẩmBánChạyToolStripMenuItem";
            this.sảnPhẩmBánChạyToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.sảnPhẩmBánChạyToolStripMenuItem.Text = "Sản phẩm bán chạy";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnSửDụngToolStripMenuItem,
            this.giớiThiệuPhầnMềmToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.hệThốngToolStripMenuItem.Text = "Trợ giúp";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            // 
            // giớiThiệuPhầnMềmToolStripMenuItem
            // 
            this.giớiThiệuPhầnMềmToolStripMenuItem.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giớiThiệuPhầnMềmToolStripMenuItem.Name = "giớiThiệuPhầnMềmToolStripMenuItem";
            this.giớiThiệuPhầnMềmToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.giớiThiệuPhầnMềmToolStripMenuItem.Text = "Giới thiệu phần mềm";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoHóaĐơnMớToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trangCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuMặtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuTheoLoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhSốBánHàngcáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmBánChạyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuPhầnMềmToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}