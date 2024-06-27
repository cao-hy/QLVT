
namespace QLVT
{
    partial class FormChinh
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChinh));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.plus = new DevExpress.XtraBars.BarButtonItem();
            this.btnVatTu = new DevExpress.XtraBars.BarButtonItem();
            this.btnKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnDonHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachVatTu = new DevExpress.XtraBars.BarButtonItem();
            this.btnChiTietNhapXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDonHangKhongPhieuNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoatDongNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnTongHopNhapXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnMENU = new DevExpress.XtraBars.BarSubItem();
            this.btnDonDatHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnLapTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.pageNhapXuat = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.panelInfo = new DevExpress.XtraEditors.PanelControl();
            this.txtServer = new DevExpress.XtraEditors.LabelControl();
            this.txtVaiTro = new DevExpress.XtraEditors.LabelControl();
            this.txtHoTen = new DevExpress.XtraEditors.LabelControl();
            this.txtMaNV = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInfo)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.BackColor = System.Drawing.Color.Cornsilk;
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26, 24, 26, 24);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.plus,
            this.btnVatTu,
            this.btnKho,
            this.btnDonHang,
            this.btnDanhSachNhanVien,
            this.btnDanhSachVatTu,
            this.btnChiTietNhapXuat,
            this.btnDonHangKhongPhieuNhap,
            this.btnHoatDongNhanVien,
            this.btnTongHopNhapXuat,
            this.btn,
            this.barButtonItem12,
            this.btnDangXuat,
            this.btnDangNhap,
            this.btnThoat,
            this.barButtonItem1,
            this.btnTaoTaiKhoan,
            this.btnXoaTaiKhoan,
            this.btnMENU,
            this.barButtonItem2,
            this.btnDonDatHang,
            this.btnPhieuNhap,
            this.btnPhieuXuat,
            this.btnLapTaiKhoan});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(5);
            this.ribbon.MaxItemId = 28;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 283;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pageNhapXuat,
            this.pageBaoCao,
            this.pageHeThong});
            this.ribbon.Size = new System.Drawing.Size(1186, 158);
            // 
            // plus
            // 
            this.plus.Caption = "NHÂN VIÊN";
            this.plus.Id = 1;
            this.plus.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("plus.ImageOptions.LargeImage")));
            this.plus.LargeWidth = 100;
            this.plus.Name = "plus";
            this.plus.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnVatTu
            // 
            this.btnVatTu.Caption = "VẬT TƯ";
            this.btnVatTu.Id = 2;
            this.btnVatTu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnVatTu.ImageOptions.LargeImage")));
            this.btnVatTu.LargeWidth = 100;
            this.btnVatTu.Name = "btnVatTu";
            this.btnVatTu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVatTu_ItemClick);
            // 
            // btnKho
            // 
            this.btnKho.Caption = "KHO HÀNG";
            this.btnKho.Id = 3;
            this.btnKho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKho.ImageOptions.LargeImage")));
            this.btnKho.LargeWidth = 100;
            this.btnKho.Name = "btnKho";
            this.btnKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKho_ItemClick);
            // 
            // btnDonHang
            // 
            this.btnDonHang.Id = 21;
            this.btnDonHang.Name = "btnDonHang";
            // 
            // btnDanhSachNhanVien
            // 
            this.btnDanhSachNhanVien.Caption = "DANH SÁCH NHÂN VIÊN";
            this.btnDanhSachNhanVien.Id = 5;
            this.btnDanhSachNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDanhSachNhanVien.ImageOptions.LargeImage")));
            this.btnDanhSachNhanVien.LargeWidth = 100;
            this.btnDanhSachNhanVien.Name = "btnDanhSachNhanVien";
            this.btnDanhSachNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhSachNhanVien_ItemClick);
            // 
            // btnDanhSachVatTu
            // 
            this.btnDanhSachVatTu.Caption = "DANH SÁCH VẬT TƯ";
            this.btnDanhSachVatTu.Id = 6;
            this.btnDanhSachVatTu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDanhSachVatTu.ImageOptions.LargeImage")));
            this.btnDanhSachVatTu.LargeWidth = 100;
            this.btnDanhSachVatTu.Name = "btnDanhSachVatTu";
            this.btnDanhSachVatTu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhSachVatTu_ItemClick);
            // 
            // btnChiTietNhapXuat
            // 
            this.btnChiTietNhapXuat.Caption = "CHI TIẾT NHẬP XUẤT";
            this.btnChiTietNhapXuat.Id = 7;
            this.btnChiTietNhapXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChiTietNhapXuat.ImageOptions.LargeImage")));
            this.btnChiTietNhapXuat.LargeWidth = 100;
            this.btnChiTietNhapXuat.Name = "btnChiTietNhapXuat";
            this.btnChiTietNhapXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChiTietNhapXuat_ItemClick);
            // 
            // btnDonHangKhongPhieuNhap
            // 
            this.btnDonHangKhongPhieuNhap.Caption = "ĐƠN HÀNG KHÔNG PHIẾU NHẬP";
            this.btnDonHangKhongPhieuNhap.Id = 8;
            this.btnDonHangKhongPhieuNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDonHangKhongPhieuNhap.ImageOptions.LargeImage")));
            this.btnDonHangKhongPhieuNhap.LargeWidth = 100;
            this.btnDonHangKhongPhieuNhap.Name = "btnDonHangKhongPhieuNhap";
            this.btnDonHangKhongPhieuNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDonHangKhongPhieuNhap_ItemClick);
            // 
            // btnHoatDongNhanVien
            // 
            this.btnHoatDongNhanVien.Caption = "HOẠT ĐỒNG NHÂN VIÊN";
            this.btnHoatDongNhanVien.Id = 9;
            this.btnHoatDongNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHoatDongNhanVien.ImageOptions.LargeImage")));
            this.btnHoatDongNhanVien.LargeWidth = 100;
            this.btnHoatDongNhanVien.Name = "btnHoatDongNhanVien";
            this.btnHoatDongNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHoatDongNhanVien_ItemClick);
            // 
            // btnTongHopNhapXuat
            // 
            this.btnTongHopNhapXuat.Caption = "TỔNG HỢP NHẬP XUẤT";
            this.btnTongHopNhapXuat.Id = 10;
            this.btnTongHopNhapXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTongHopNhapXuat.ImageOptions.LargeImage")));
            this.btnTongHopNhapXuat.LargeWidth = 100;
            this.btnTongHopNhapXuat.Name = "btnTongHopNhapXuat";
            this.btnTongHopNhapXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTongHopNhapXuat_ItemClick);
            // 
            // btn
            // 
            this.btn.Caption = "12";
            this.btn.Id = 11;
            this.btn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn.ImageOptions.SvgImage")));
            this.btn.LargeWidth = 100;
            this.btn.Name = "btn";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "DANG XUAT";
            this.barButtonItem12.Id = 12;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "ĐĂNG XUẤT";
            this.btnDangXuat.Enabled = false;
            this.btnDangXuat.Id = 13;
            this.btnDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.LargeImage")));
            this.btnDangXuat.LargeWidth = 100;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "ĐĂNG NHẬP";
            this.btnDangNhap.Id = 14;
            this.btnDangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.LargeImage")));
            this.btnDangNhap.LargeWidth = 100;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "THOÁT";
            this.btnThoat.Id = 15;
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.LargeWidth = 100;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 16;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Caption = "TẠO MỚI";
            this.btnTaoTaiKhoan.Id = 17;
            this.btnTaoTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.SvgImage")));
            this.btnTaoTaiKhoan.LargeWidth = 100;
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.Caption = "XÓA";
            this.btnXoaTaiKhoan.Id = 18;
            this.btnXoaTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaTaiKhoan.ImageOptions.SvgImage")));
            this.btnXoaTaiKhoan.LargeWidth = 100;
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            // 
            // btnMENU
            // 
            this.btnMENU.Caption = "LẬP PHIẾU";
            this.btnMENU.Id = 22;
            this.btnMENU.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMENU.ImageOptions.LargeImage")));
            this.btnMENU.LargeWidth = 100;
            this.btnMENU.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDonDatHang),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhieuNhap),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhieuXuat)});
            this.btnMENU.Name = "btnMENU";
            // 
            // btnDonDatHang
            // 
            this.btnDonDatHang.Caption = "Đơn Đặt Hàng";
            this.btnDonDatHang.Id = 24;
            this.btnDonDatHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDonDatHang.ImageOptions.Image")));
            this.btnDonDatHang.Name = "btnDonDatHang";
            this.btnDonDatHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDonDatHang_ItemClick);
            // 
            // btnPhieuNhap
            // 
            this.btnPhieuNhap.Caption = "Phiếu Nhập";
            this.btnPhieuNhap.Id = 25;
            this.btnPhieuNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuNhap.ImageOptions.Image")));
            this.btnPhieuNhap.Name = "btnPhieuNhap";
            this.btnPhieuNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuNhap_ItemClick);
            // 
            // btnPhieuXuat
            // 
            this.btnPhieuXuat.Caption = "Phiếu Xuất";
            this.btnPhieuXuat.Id = 26;
            this.btnPhieuXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuXuat.ImageOptions.Image")));
            this.btnPhieuXuat.Name = "btnPhieuXuat";
            this.btnPhieuXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuXuat_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 23;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnLapTaiKhoan
            // 
            this.btnLapTaiKhoan.Caption = "TẠO TÀI KHOẢN";
            this.btnLapTaiKhoan.Enabled = false;
            this.btnLapTaiKhoan.Id = 27;
            this.btnLapTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLapTaiKhoan.ImageOptions.LargeImage")));
            this.btnLapTaiKhoan.LargeWidth = 100;
            this.btnLapTaiKhoan.Name = "btnLapTaiKhoan";
            this.btnLapTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLapTaiKhoan_ItemClick);
            // 
            // pageNhapXuat
            // 
            this.pageNhapXuat.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.pageNhapXuat.Name = "pageNhapXuat";
            this.pageNhapXuat.Text = "NHẬP XUẤT";
            this.pageNhapXuat.Visible = false;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.plus);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnVatTu);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKho);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMENU);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "QUẢN LÝ NHẬP XUẤT";
            // 
            // pageBaoCao
            // 
            this.pageBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.pageBaoCao.Name = "pageBaoCao";
            this.pageBaoCao.Text = "BÁO CÁO";
            this.pageBaoCao.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDanhSachNhanVien);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDanhSachVatTu);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnChiTietNhapXuat);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDonHangKhongPhieuNhap);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnHoatDongNhanVien);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTongHopNhapXuat);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "QUẢN LÝ BÁO CÁO";
            // 
            // pageHeThong
            // 
            this.pageHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.pageHeThong.Name = "pageHeThong";
            this.pageHeThong.Text = "HỆ THỐNG";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnLapTaiKhoan);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnThoat);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // panelInfo
            // 
            this.panelInfo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelInfo.Appearance.Options.UseBackColor = true;
            this.panelInfo.Controls.Add(this.txtServer);
            this.panelInfo.Controls.Add(this.txtVaiTro);
            this.panelInfo.Controls.Add(this.txtHoTen);
            this.panelInfo.Controls.Add(this.txtMaNV);
            this.panelInfo.Controls.Add(this.labelControl4);
            this.panelInfo.Controls.Add(this.labelControl3);
            this.panelInfo.Controls.Add(this.labelControl2);
            this.panelInfo.Controls.Add(this.labelControl1);
            this.panelInfo.Location = new System.Drawing.Point(913, 60);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(273, 98);
            this.panelInfo.TabIndex = 6;
            this.panelInfo.Visible = false;
            this.panelInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInfo_Paint);
            // 
            // txtServer
            // 
            this.txtServer.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtServer.Appearance.Options.UseFont = true;
            this.txtServer.Location = new System.Drawing.Point(100, 70);
            this.txtServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(0, 14);
            this.txtServer.TabIndex = 14;
            // 
            // txtVaiTro
            // 
            this.txtVaiTro.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtVaiTro.Appearance.Options.UseFont = true;
            this.txtVaiTro.Location = new System.Drawing.Point(100, 50);
            this.txtVaiTro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVaiTro.Name = "txtVaiTro";
            this.txtVaiTro.Size = new System.Drawing.Size(0, 14);
            this.txtVaiTro.TabIndex = 13;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtHoTen.Appearance.Options.UseFont = true;
            this.txtHoTen.Location = new System.Drawing.Point(100, 31);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(0, 14);
            this.txtHoTen.TabIndex = 12;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtMaNV.Appearance.Options.UseFont = true;
            this.txtMaNV.Location = new System.Drawing.Point(100, 11);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(0, 14);
            this.txtMaNV.TabIndex = 11;
            this.txtMaNV.UseWaitCursor = true;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(4, 70);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 14);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "SERVER:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(4, 50);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 14);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "VAI TRÒ:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(4, 31);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 14);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "HỌ VÀ TÊN:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(4, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 14);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "MÃ NHÂN VIÊN:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // FormChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 639);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FormChinh.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormChinh";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ VẬT TƯ";
            this.Load += new System.EventHandler(this.FormChinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInfo)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageNhapXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem plus;
        private DevExpress.XtraBars.BarButtonItem btnVatTu;
        private DevExpress.XtraBars.BarButtonItem btnKho;
        private DevExpress.XtraBars.BarButtonItem btnDonHang;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachVatTu;
        private DevExpress.XtraBars.BarButtonItem btnChiTietNhapXuat;
        private DevExpress.XtraBars.BarButtonItem btnDonHangKhongPhieuNhap;
        private DevExpress.XtraBars.BarButtonItem btnHoatDongNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnTongHopNhapXuat;
        private DevExpress.XtraBars.BarButtonItem btn;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnTaoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnXoaTaiKhoan;
        private DevExpress.XtraBars.BarSubItem btnMENU;
        private DevExpress.XtraBars.BarButtonItem btnDonDatHang;
        private DevExpress.XtraBars.BarButtonItem btnPhieuNhap;
        private DevExpress.XtraBars.BarButtonItem btnPhieuXuat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnLapTaiKhoan;
        public DevExpress.XtraEditors.PanelControl panelInfo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.LabelControl txtServer;
        public DevExpress.XtraEditors.LabelControl txtVaiTro;
        public DevExpress.XtraEditors.LabelControl txtHoTen;
        public DevExpress.XtraEditors.LabelControl txtMaNV;
    }
}