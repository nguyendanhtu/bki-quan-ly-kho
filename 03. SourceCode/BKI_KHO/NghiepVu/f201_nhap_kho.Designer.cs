namespace BKI_KHO.NghiepVu
{
    partial class f201_nhap_kho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f201_nhap_kho));
            this.m_lbl_ten_phieu = new System.Windows.Forms.Label();
            this.m_lab_ngay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_dat_ngay_lap = new DevExpress.XtraEditors.DateEdit();
            this.m_txt_nguoi_thu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_cbo_kho = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_txt_so_phieu_thu_chi = new System.Windows.Forms.TextBox();
            this.m_lab_so_phieu = new System.Windows.Forms.Label();
            this.m_v = new DevExpress.XtraGrid.GridControl();
            this.m_fg = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navbarImageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.navbarImageList = new System.Windows.Forms.ImageList(this.components);
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_xem = new SIS.Controls.Button.SiSButton();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_ngay_lap.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_ngay_lap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_v)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_lbl_ten_phieu
            // 
            this.m_lbl_ten_phieu.AutoSize = true;
            this.m_lbl_ten_phieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_lbl_ten_phieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_ten_phieu.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_ten_phieu.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_ten_phieu.Name = "m_lbl_ten_phieu";
            this.m_lbl_ten_phieu.Size = new System.Drawing.Size(184, 24);
            this.m_lbl_ten_phieu.TabIndex = 1;
            this.m_lbl_ten_phieu.Text = "PHIẾU NHẬP KHO";
            // 
            // m_lab_ngay
            // 
            this.m_lab_ngay.AutoSize = true;
            this.m_lab_ngay.Location = new System.Drawing.Point(12, 41);
            this.m_lab_ngay.Name = "m_lab_ngay";
            this.m_lab_ngay.Size = new System.Drawing.Size(116, 13);
            this.m_lab_ngay.TabIndex = 4;
            this.m_lab_ngay.Text = "Bước 1: Nhập ngày lập";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_dat_ngay_lap);
            this.panel1.Controls.Add(this.m_txt_nguoi_thu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_cbo_kho);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.m_txt_so_phieu_thu_chi);
            this.panel1.Controls.Add(this.m_lab_so_phieu);
            this.panel1.Controls.Add(this.m_lab_ngay);
            this.panel1.Controls.Add(this.m_lbl_ten_phieu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 150);
            this.panel1.TabIndex = 6;
            // 
            // m_dat_ngay_lap
            // 
            this.m_dat_ngay_lap.EditValue = null;
            this.m_dat_ngay_lap.Location = new System.Drawing.Point(151, 38);
            this.m_dat_ngay_lap.Name = "m_dat_ngay_lap";
            this.m_dat_ngay_lap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_ngay_lap.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.m_dat_ngay_lap.Size = new System.Drawing.Size(113, 20);
            this.m_dat_ngay_lap.TabIndex = 20;
            // 
            // m_txt_nguoi_thu
            // 
            this.m_txt_nguoi_thu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_txt_nguoi_thu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_nguoi_thu.Location = new System.Drawing.Point(151, 121);
            this.m_txt_nguoi_thu.MaxLength = 10;
            this.m_txt_nguoi_thu.Name = "m_txt_nguoi_thu";
            this.m_txt_nguoi_thu.Size = new System.Drawing.Size(167, 20);
            this.m_txt_nguoi_thu.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Bước 4: Thủ kho";
            // 
            // m_cbo_kho
            // 
            this.m_cbo_kho.FormattingEnabled = true;
            this.m_cbo_kho.Location = new System.Drawing.Point(151, 90);
            this.m_cbo_kho.Name = "m_cbo_kho";
            this.m_cbo_kho.Size = new System.Drawing.Size(135, 21);
            this.m_cbo_kho.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Bước 3: Nhập vào kho";
            // 
            // m_txt_so_phieu_thu_chi
            // 
            this.m_txt_so_phieu_thu_chi.BackColor = System.Drawing.SystemColors.Window;
            this.m_txt_so_phieu_thu_chi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_so_phieu_thu_chi.Location = new System.Drawing.Point(151, 64);
            this.m_txt_so_phieu_thu_chi.MaxLength = 20;
            this.m_txt_so_phieu_thu_chi.Name = "m_txt_so_phieu_thu_chi";
            this.m_txt_so_phieu_thu_chi.Size = new System.Drawing.Size(113, 20);
            this.m_txt_so_phieu_thu_chi.TabIndex = 8;
            // 
            // m_lab_so_phieu
            // 
            this.m_lab_so_phieu.AutoSize = true;
            this.m_lab_so_phieu.Location = new System.Drawing.Point(12, 66);
            this.m_lab_so_phieu.Name = "m_lab_so_phieu";
            this.m_lab_so_phieu.Size = new System.Drawing.Size(132, 13);
            this.m_lab_so_phieu.TabIndex = 7;
            this.m_lab_so_phieu.Text = "Bước 2: Nhập số chứng từ";
            // 
            // m_v
            // 
            this.m_v.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_v.Location = new System.Drawing.Point(0, 150);
            this.m_v.MainView = this.m_fg;
            this.m_v.Name = "m_v";
            this.m_v.Size = new System.Drawing.Size(908, 268);
            this.m_v.TabIndex = 7;
            this.m_v.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_fg});
            // 
            // m_fg
            // 
            this.m_fg.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn6,
            this.gridColumn9});
            this.m_fg.GridControl = this.m_v;
            this.m_fg.GroupCount = 2;
            this.m_fg.Name = "m_fg";
            this.m_fg.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "STT";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 62;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Loại thiết bị";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 104;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Dòng thiết bị";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 104;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "SN Thiết bị";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 104;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Mô tả";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 104;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Giá nhập";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 104;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Part Number";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            this.gridColumn8.Width = 104;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tên thành phần";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 104;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "SN Thành phần";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 5;
            this.gridColumn9.Width = 117;
            // 
            // navbarImageListLarge
            // 
            this.navbarImageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("navbarImageListLarge.ImageStream")));
            this.navbarImageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageListLarge.Images.SetKeyName(0, "Mail_16x16.png");
            this.navbarImageListLarge.Images.SetKeyName(1, "Organizer_16x16.png");
            // 
            // navbarImageList
            // 
            this.navbarImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("navbarImageList.ImageStream")));
            this.navbarImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageList.Images.SetKeyName(0, "Inbox_16x16.png");
            this.navbarImageList.Images.SetKeyName(1, "Outbox_16x16.png");
            this.navbarImageList.Images.SetKeyName(2, "Drafts_16x16.png");
            this.navbarImageList.Images.SetKeyName(3, "Trash_16x16.png");
            this.navbarImageList.Images.SetKeyName(4, "Calendar_16x16.png");
            this.navbarImageList.Images.SetKeyName(5, "Tasks_16x16.png");
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.BackColor = System.Drawing.Color.Lavender;
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xem);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 418);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(908, 36);
            this.m_pnl_out_place_dm.TabIndex = 20;
            // 
            // m_cmd_xem
            // 
            this.m_cmd_xem.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_xem.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_xem.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_xem.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_xem.ImageIndex = 10;
            this.m_cmd_xem.ImageList = this.ImageList;
            this.m_cmd_xem.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_xem.Name = "m_cmd_xem";
            this.m_cmd_xem.Size = new System.Drawing.Size(157, 28);
            this.m_cmd_xem.TabIndex = 15;
            this.m_cmd_xem.Text = "Xem danh sách phiếu";
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert.ImageIndex = 2;
            this.m_cmd_insert.ImageList = this.ImageList;
            this.m_cmd_insert.Location = new System.Drawing.Point(464, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(121, 28);
            this.m_cmd_insert.TabIndex = 12;
            this.m_cmd_insert.Text = "&Thêm thiết bị";
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_update.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_update.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_update.ImageIndex = 3;
            this.m_cmd_update.ImageList = this.ImageList;
            this.m_cmd_update.Location = new System.Drawing.Point(585, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(112, 28);
            this.m_cmd_update.TabIndex = 13;
            this.m_cmd_update.Text = "&Sửa nội dung";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_delete.ImageIndex = 4;
            this.m_cmd_delete.ImageList = this.ImageList;
            this.m_cmd_delete.Location = new System.Drawing.Point(697, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(107, 28);
            this.m_cmd_delete.TabIndex = 14;
            this.m_cmd_delete.Text = "&Xoá thiết bị";
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(804, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(100, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // f201_nhap_kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 454);
            this.Controls.Add(this.m_v);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.panel1);
            this.Name = "f201_nhap_kho";
            this.Text = "F201 - PHIẾU NHẬP KHO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_ngay_lap.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_ngay_lap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_v)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label m_lbl_ten_phieu;
        private System.Windows.Forms.Label m_lab_ngay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox m_txt_so_phieu_thu_chi;
        private System.Windows.Forms.Label m_lab_so_phieu;
        private System.Windows.Forms.ComboBox m_cbo_kho;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl m_v;
        private DevExpress.XtraGrid.Views.Grid.GridView m_fg;
        private System.Windows.Forms.ImageList navbarImageListLarge;
        private System.Windows.Forms.ImageList navbarImageList;
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        internal SIS.Controls.Button.SiSButton m_cmd_xem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_txt_nguoi_thu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.DateEdit m_dat_ngay_lap;
    }
}