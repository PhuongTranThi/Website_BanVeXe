namespace GUI_BanVeXe
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.btnDoiMK = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLNguoiDung = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhanQuyen = new DevExpress.XtraBars.BarButtonItem();
            this.btnBanVe = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLTaiXe = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLPhuXe = new DevExpress.XtraBars.BarButtonItem();
            this.btnNVBanVe = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLXe = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLTuyenDi = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLChuyenDi = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLDDDonKhach = new DevExpress.XtraBars.BarButtonItem();
            this.btnTKBanVe = new DevExpress.XtraBars.BarButtonItem();
            this.btnTKDoanhSo = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.groupDoiMatKhau = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupHeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonThongKe = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.CaptionBarItemLinks.Add(this.skinDropDownButtonItem1);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinDropDownButtonItem1,
            this.ribbon.ExpandCollapseItem,
            this.btnDoiMK,
            this.btnQLNguoiDung,
            this.btnPhanQuyen,
            this.btnBanVe,
            this.btnQLTaiXe,
            this.btnQLPhuXe,
            this.btnNVBanVe,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.btnQLKhachHang,
            this.btnQLXe,
            this.btnQLTuyenDi,
            this.btnQLChuyenDi,
            this.btnQLDDDonKhach,
            this.btnTKBanVe,
            this.btnTKDoanhSo,
            this.btnDangXuat});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 20;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.ribbon.PageHeaderItemLinks.Add(this.btnDangXuat);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonHeThong,
            this.ribbonNghiepVu,
            this.ribbonDanhMuc,
            this.ribbonThongKe});
            this.ribbon.Size = new System.Drawing.Size(1225, 178);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 19;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Caption = "Đổi mật khẩu\r\n";
            this.btnDoiMK.Id = 1;
            this.btnDoiMK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMK.ImageOptions.Image")));
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDoiMK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiMK_ItemClick);
            // 
            // btnQLNguoiDung
            // 
            this.btnQLNguoiDung.Caption = "Quản lý người dùng \r\n";
            this.btnQLNguoiDung.Id = 2;
            this.btnQLNguoiDung.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLNguoiDung.ImageOptions.Image")));
            this.btnQLNguoiDung.Name = "btnQLNguoiDung";
            this.btnQLNguoiDung.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnQLNguoiDung.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLNguoiDung_ItemClick);
            // 
            // btnPhanQuyen
            // 
            this.btnPhanQuyen.Caption = "Phân quyền\r\n";
            this.btnPhanQuyen.Id = 3;
            this.btnPhanQuyen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanQuyen.ImageOptions.Image")));
            this.btnPhanQuyen.Name = "btnPhanQuyen";
            this.btnPhanQuyen.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPhanQuyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhanQuyen_ItemClick);
            // 
            // btnBanVe
            // 
            this.btnBanVe.Caption = "Bán vé\r\n";
            this.btnBanVe.Id = 4;
            this.btnBanVe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBanVe.ImageOptions.Image")));
            this.btnBanVe.Name = "btnBanVe";
            this.btnBanVe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBanVe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBanVe_ItemClick);
            // 
            // btnQLTaiXe
            // 
            this.btnQLTaiXe.Caption = "Quản lý tài xế\r\n\r\n\r\n";
            this.btnQLTaiXe.Id = 5;
            this.btnQLTaiXe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLTaiXe.ImageOptions.Image")));
            this.btnQLTaiXe.Name = "btnQLTaiXe";
            this.btnQLTaiXe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnQLTaiXe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLTaiXe_ItemClick);
            // 
            // btnQLPhuXe
            // 
            this.btnQLPhuXe.Caption = "Quản lý phụ xe\r\n";
            this.btnQLPhuXe.Id = 6;
            this.btnQLPhuXe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLPhuXe.ImageOptions.Image")));
            this.btnQLPhuXe.Name = "btnQLPhuXe";
            this.btnQLPhuXe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnQLPhuXe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLPhuXe_ItemClick);
            // 
            // btnNVBanVe
            // 
            this.btnNVBanVe.Caption = "Quản lý nhân viên bán vé \r\n";
            this.btnNVBanVe.Id = 7;
            this.btnNVBanVe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNVBanVe.ImageOptions.Image")));
            this.btnNVBanVe.Name = "btnNVBanVe";
            this.btnNVBanVe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNVBanVe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNVBanVe_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 8;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 9;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "barButtonItem7";
            this.barButtonItem7.Id = 10;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnQLKhachHang
            // 
            this.btnQLKhachHang.Caption = "Quản lý khách hàng\r\n";
            this.btnQLKhachHang.Id = 11;
            this.btnQLKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLKhachHang.ImageOptions.Image")));
            this.btnQLKhachHang.Name = "btnQLKhachHang";
            this.btnQLKhachHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnQLKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLKhachHang_ItemClick);
            // 
            // btnQLXe
            // 
            this.btnQLXe.Caption = "Quản lý xe\r\n";
            this.btnQLXe.Id = 12;
            this.btnQLXe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLXe.ImageOptions.Image")));
            this.btnQLXe.Name = "btnQLXe";
            this.btnQLXe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnQLXe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLXe_ItemClick);
            // 
            // btnQLTuyenDi
            // 
            this.btnQLTuyenDi.Caption = "Quản lý tuyến đi\r\n";
            this.btnQLTuyenDi.Id = 13;
            this.btnQLTuyenDi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLTuyenDi.ImageOptions.Image")));
            this.btnQLTuyenDi.Name = "btnQLTuyenDi";
            this.btnQLTuyenDi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnQLTuyenDi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLTuyenDi_ItemClick);
            // 
            // btnQLChuyenDi
            // 
            this.btnQLChuyenDi.Caption = "Quản lý chuyến đi\r\n";
            this.btnQLChuyenDi.Id = 14;
            this.btnQLChuyenDi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLChuyenDi.ImageOptions.Image")));
            this.btnQLChuyenDi.Name = "btnQLChuyenDi";
            this.btnQLChuyenDi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnQLChuyenDi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLChuyenDi_ItemClick);
            // 
            // btnQLDDDonKhach
            // 
            this.btnQLDDDonKhach.Caption = "Địa điểm đón khách\r\n\r\n";
            this.btnQLDDDonKhach.Id = 15;
            this.btnQLDDDonKhach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLDDDonKhach.ImageOptions.Image")));
            this.btnQLDDDonKhach.Name = "btnQLDDDonKhach";
            this.btnQLDDDonKhach.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnQLDDDonKhach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLDDDonKhach_ItemClick);
            // 
            // btnTKBanVe
            // 
            this.btnTKBanVe.Caption = "Thống kê bán vé\r\n";
            this.btnTKBanVe.Id = 16;
            this.btnTKBanVe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTKBanVe.ImageOptions.Image")));
            this.btnTKBanVe.Name = "btnTKBanVe";
            this.btnTKBanVe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnTKDoanhSo
            // 
            this.btnTKDoanhSo.Caption = "Thống kê doanh số\r\n";
            this.btnTKDoanhSo.Id = 17;
            this.btnTKDoanhSo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTKDoanhSo.ImageOptions.Image")));
            this.btnTKDoanhSo.Name = "btnTKDoanhSo";
            this.btnTKDoanhSo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất\r\n";
            this.btnDangXuat.Id = 18;
            this.btnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.Image")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Text = "ribbonPageCategory1";
            this.ribbonPageCategory1.Visible = false;
            // 
            // ribbonHeThong
            // 
            this.ribbonHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.groupDoiMatKhau,
            this.groupHeThong});
            this.ribbonHeThong.Name = "ribbonHeThong";
            this.ribbonHeThong.Tag = "MH001";
            this.ribbonHeThong.Text = "Hệ Thống";
            // 
            // groupDoiMatKhau
            // 
            this.groupDoiMatKhau.ItemLinks.Add(this.btnDoiMK);
            this.groupDoiMatKhau.Name = "groupDoiMatKhau";
            // 
            // groupHeThong
            // 
            this.groupHeThong.ItemLinks.Add(this.btnQLNguoiDung);
            this.groupHeThong.ItemLinks.Add(this.btnPhanQuyen);
            this.groupHeThong.Name = "groupHeThong";
            this.groupHeThong.Text = "Hệ thống";
            this.groupHeThong.Visible = false;
            // 
            // ribbonNghiepVu
            // 
            this.ribbonNghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonNghiepVu.Name = "ribbonNghiepVu";
            this.ribbonNghiepVu.Tag = "MH003";
            this.ribbonNghiepVu.Text = "Nghiệp Vụ";
            this.ribbonNghiepVu.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBanVe);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Nghiệp vụ chính";
            // 
            // ribbonDanhMuc
            // 
            this.ribbonDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup1,
            this.ribbonPageGroup6});
            this.ribbonDanhMuc.Name = "ribbonDanhMuc";
            this.ribbonDanhMuc.Tag = "MH002";
            this.ribbonDanhMuc.Text = "Danh Mục";
            this.ribbonDanhMuc.Visible = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnQLTaiXe);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnQLPhuXe);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnNVBanVe);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Quản lý nhân viên";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnQLKhachHang);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản lý khách hàng";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnQLXe);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnQLTuyenDi);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnQLChuyenDi);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnQLDDDonKhach);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonThongKe
            // 
            this.ribbonThongKe.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonThongKe.Name = "ribbonThongKe";
            this.ribbonThongKe.Tag = "MH004";
            this.ribbonThongKe.Text = "Thống Kê";
            this.ribbonThongKe.Visible = false;
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnTKBanVe);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnTKDoanhSo);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 578);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1225, 37);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi mật khẩu\r\n";
            this.btnDoiMatKhau.Id = 11;
            this.btnDoiMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.Image")));
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 615);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Main";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "HỆ THỐNG QUẢN LÝ BÁN VÉ XE KHÁCH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupDoiMatKhau;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonNghiepVu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonThongKe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnDoiMK;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem btnQLNguoiDung;
        private DevExpress.XtraBars.BarButtonItem btnPhanQuyen;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupHeThong;
        private DevExpress.XtraBars.BarButtonItem btnBanVe;
        private DevExpress.XtraBars.BarButtonItem btnQLTaiXe;
        private DevExpress.XtraBars.BarButtonItem btnQLPhuXe;
        private DevExpress.XtraBars.BarButtonItem btnNVBanVe;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem btnQLKhachHang;
        private DevExpress.XtraBars.BarButtonItem btnQLXe;
        private DevExpress.XtraBars.BarButtonItem btnQLTuyenDi;
        private DevExpress.XtraBars.BarButtonItem btnQLChuyenDi;
        private DevExpress.XtraBars.BarButtonItem btnQLDDDonKhach;
        private DevExpress.XtraBars.BarButtonItem btnTKBanVe;
        private DevExpress.XtraBars.BarButtonItem btnTKDoanhSo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
    }
}