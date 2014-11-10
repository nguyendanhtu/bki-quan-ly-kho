namespace DemoKho
{
    partial class F100_main
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
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarQLKho = new DevExpress.XtraNavBar.NavBarGroup();
            this.navDanhMuc = new DevExpress.XtraNavBar.NavBarItem();
            this.navNhapKho = new DevExpress.XtraNavBar.NavBarItem();
            this.navXuatKho = new DevExpress.XtraNavBar.NavBarItem();
            this.navBaoCao = new DevExpress.XtraNavBar.NavBarItem();
            this.navTraCuu = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarHeThong = new DevExpress.XtraNavBar.NavBarGroup();
            this.navNguoiDung = new DevExpress.XtraNavBar.NavBarItem();
            this.navNhomNguoiDung = new DevExpress.XtraNavBar.NavBarItem();
            this.navPhanQuyenChoNhom = new DevExpress.XtraNavBar.NavBarItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarQLKho;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarQLKho,
            this.navBarHeThong});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navDanhMuc,
            this.navNhapKho,
            this.navXuatKho,
            this.navBaoCao,
            this.navTraCuu,
            this.navNguoiDung,
            this.navNhomNguoiDung,
            this.navPhanQuyenChoNhom});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 177;
            this.navBarControl1.Size = new System.Drawing.Size(177, 642);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("DevExpress Style");
            // 
            // navBarQLKho
            // 
            this.navBarQLKho.Caption = "Quản lý kho";
            this.navBarQLKho.Expanded = true;
            this.navBarQLKho.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navDanhMuc),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navNhapKho),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navXuatKho),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBaoCao),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navTraCuu)});
            this.navBarQLKho.Name = "navBarQLKho";
            // 
            // navDanhMuc
            // 
            this.navDanhMuc.Caption = "Danh mục";
            this.navDanhMuc.Name = "navDanhMuc";
            // 
            // navNhapKho
            // 
            this.navNhapKho.Caption = "Nhập kho";
            this.navNhapKho.Name = "navNhapKho";
            this.navNhapKho.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navNhapKho_LinkClicked);
            // 
            // navXuatKho
            // 
            this.navXuatKho.Caption = "Xuất kho";
            this.navXuatKho.Name = "navXuatKho";
            this.navXuatKho.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navXuatKho_LinkClicked);
            // 
            // navBaoCao
            // 
            this.navBaoCao.Caption = "Báo cáo";
            this.navBaoCao.Name = "navBaoCao";
            // 
            // navTraCuu
            // 
            this.navTraCuu.Caption = "Tra cứu";
            this.navTraCuu.Name = "navTraCuu";
            // 
            // navBarHeThong
            // 
            this.navBarHeThong.Caption = "Quản trị hệ thống";
            this.navBarHeThong.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navNguoiDung),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navNhomNguoiDung),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navPhanQuyenChoNhom)});
            this.navBarHeThong.Name = "navBarHeThong";
            // 
            // navNguoiDung
            // 
            this.navNguoiDung.Caption = "Quản lý người dùng";
            this.navNguoiDung.Name = "navNguoiDung";
            // 
            // navNhomNguoiDung
            // 
            this.navNhomNguoiDung.Caption = "Quản lý nhóm người dùng";
            this.navNhomNguoiDung.Name = "navNhomNguoiDung";
            // 
            // navPhanQuyenChoNhom
            // 
            this.navPhanQuyenChoNhom.Caption = "Phân quyền cho nhóm";
            this.navPhanQuyenChoNhom.Name = "navPhanQuyenChoNhom";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.navBarControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 642);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.xtraTabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(177, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1087, 642);
            this.panel2.TabIndex = 2;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.Size = new System.Drawing.Size(1087, 642);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.CloseButtonClick += new System.EventHandler(this.xtraTabControl1_CloseButtonClick);
            // 
            // F100_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 642);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "F100_main";
            this.Text = "F100 Trang chủ";
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarQLKho;
        private DevExpress.XtraNavBar.NavBarItem navDanhMuc;
        private DevExpress.XtraNavBar.NavBarItem navTraCuu;
        private DevExpress.XtraNavBar.NavBarItem navBaoCao;
        private DevExpress.XtraNavBar.NavBarItem navXuatKho;
        private DevExpress.XtraNavBar.NavBarItem navNhapKho;
        private DevExpress.XtraNavBar.NavBarGroup navBarHeThong;
        private DevExpress.XtraNavBar.NavBarItem navPhanQuyenChoNhom;
        private DevExpress.XtraNavBar.NavBarItem navNhomNguoiDung;
        private DevExpress.XtraNavBar.NavBarItem navNguoiDung;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
    }
}