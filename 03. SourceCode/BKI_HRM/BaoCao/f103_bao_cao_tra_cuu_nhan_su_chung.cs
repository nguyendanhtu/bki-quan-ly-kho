///************************************************
/// Generated by: TrongHV
/// Date: 28/02/2014 03:03:05
/// Goal: Create Form for V_DM_DU_LIEU_NHAN_VIEN
///************************************************

using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;

using BKI_HRM.US;
using BKI_HRM.DS;
using BKI_HRM.DS.CDBNames;

using C1.Win.C1FlexGrid;
using SIS.Controls.Button;

namespace BKI_HRM {

    public class f103_bao_cao_tra_cuu_nhan_su : Form {
        internal ImageList ImageList;
        private C1FlexGrid m_fg;
        private Panel panel1;
        private Label m_lbl_so_nhan_vien;
        private Label label2;
        private ComboBox m_cbo_gioi_tinh;
        private Label label1;
        internal SiSButton m_cmd_search;
        private TextBox m_txt_tim_kiem;
        private Label m_lbl_tim_kiem;
        internal Panel m_pnl_out_place_dm;
        internal SiSButton m_cmd_xuat_excel;
        internal SiSButton m_cmd_exit;
        private ToolTip m_tooltip;
        private ComboBox m_cbo_trang_thai;
        private Label label3;
        private IContainer components;

        public f103_bao_cao_tra_cuu_nhan_su() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            format_controls();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f103_bao_cao_tra_cuu_nhan_su));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cbo_trang_thai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_lbl_so_nhan_vien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_cbo_gioi_tinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.m_lbl_tim_kiem = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_tooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.panel1.SuspendLayout();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.SuspendLayout();
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
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Location = new System.Drawing.Point(0, 94);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(1189, 478);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cbo_trang_thai);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.m_lbl_so_nhan_vien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.m_cbo_gioi_tinh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.m_txt_tim_kiem);
            this.panel1.Controls.Add(this.m_lbl_tim_kiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 95);
            this.panel1.TabIndex = 24;
            // 
            // m_cbo_trang_thai
            // 
            this.m_cbo_trang_thai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_trang_thai.FormattingEnabled = true;
            this.m_cbo_trang_thai.Location = new System.Drawing.Point(266, 14);
            this.m_cbo_trang_thai.Name = "m_cbo_trang_thai";
            this.m_cbo_trang_thai.Size = new System.Drawing.Size(121, 22);
            this.m_cbo_trang_thai.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 14);
            this.label3.TabIndex = 29;
            this.label3.Text = "Trạng thái lao động";
            // 
            // m_lbl_so_nhan_vien
            // 
            this.m_lbl_so_nhan_vien.AutoSize = true;
            this.m_lbl_so_nhan_vien.Location = new System.Drawing.Point(204, 77);
            this.m_lbl_so_nhan_vien.Name = "m_lbl_so_nhan_vien";
            this.m_lbl_so_nhan_vien.Size = new System.Drawing.Size(25, 14);
            this.m_lbl_so_nhan_vien.TabIndex = 28;
            this.m_lbl_so_nhan_vien.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 14);
            this.label2.TabIndex = 27;
            this.label2.Text = "Số lượng nhân viên trong danh sách:";
            // 
            // m_cbo_gioi_tinh
            // 
            this.m_cbo_gioi_tinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_gioi_tinh.FormattingEnabled = true;
            this.m_cbo_gioi_tinh.Items.AddRange(new object[] {
            "Tất cả",
            "Nam",
            "Nữ"});
            this.m_cbo_gioi_tinh.Location = new System.Drawing.Point(464, 14);
            this.m_cbo_gioi_tinh.Name = "m_cbo_gioi_tinh";
            this.m_cbo_gioi_tinh.Size = new System.Drawing.Size(69, 22);
            this.m_cbo_gioi_tinh.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 25;
            this.label1.Text = "Giới tính";
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(1069, 39);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 2;
            this.m_cmd_search.Text = "Tìm kiếm";
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_txt_tim_kiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(266, 50);
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(766, 20);
            this.m_txt_tim_kiem.TabIndex = 1;
            this.m_tooltip.SetToolTip(this.m_txt_tim_kiem, "Để tìm kiếm nhân viên sinh nhật theo tháng, bạn gõ: Tháng 10");
            // 
            // m_lbl_tim_kiem
            // 
            this.m_lbl_tim_kiem.AutoSize = true;
            this.m_lbl_tim_kiem.Location = new System.Drawing.Point(155, 50);
            this.m_lbl_tim_kiem.Name = "m_lbl_tim_kiem";
            this.m_lbl_tim_kiem.Size = new System.Drawing.Size(87, 14);
            this.m_lbl_tim_kiem.TabIndex = 24;
            this.m_lbl_tim_kiem.Text = "Từ khoá tìm kiếm";
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xuat_excel);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 536);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(1189, 36);
            this.m_pnl_out_place_dm.TabIndex = 31;
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_xuat_excel.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_xuat_excel.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xuat_excel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.m_cmd_xuat_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_xuat_excel.ImageIndex = 19;
            this.m_cmd_xuat_excel.ImageList = this.ImageList;
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(118, 28);
            this.m_cmd_xuat_excel.TabIndex = 12;
            this.m_cmd_xuat_excel.Text = "Xuất Excel";
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.m_cmd_exit.ForeColor = System.Drawing.Color.Maroon;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(1067, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(118, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // f103_bao_cao_tra_cuu_nhan_su
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1189, 572);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_fg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f103_bao_cao_tra_cuu_nhan_su";
            this.Text = "F103 - Tra cứu nhân sự chung";
            this.Load += new System.EventHandler(this.f103_bao_cao_tra_cuu_nhan_su_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Public Interface
        public void display() {
            ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number {
            LOAI_DON_VI = 13
,
            TEN_DON_VI = 1//12
                ,
            MA_NV = 3
                ,
            CAP_DON_VI = 14
                ,
            TRANG_THAI_LAO_DONG = 16
                ,
            DIA_BAN = 15
                ,
            TEN = 5
                ,
            NGAY_CO_HIEU_LUC = 17
                ,
            TRANG_THAI_HIEN_TAI = 19
                ,
            MA_DON_VI = 2 //11
                ,
            HO_DEM = 4
                ,
            TY_LE_THAM_GIA = 12
                ,
            TEN_CV = 10
                ,
            NGAY_HET_HIEU_LUC = 18
                ,
            NGAY_SINH = 7
                ,
            TRINH_DO = 8
                ,
            TRANG_THAI_CV = 11
                ,
            GIOI_TINH = 6
                , MA_CV = 9

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_DM_DU_LIEU_NHAN_VIEN m_ds = new DS_V_DM_DU_LIEU_NHAN_VIEN();
        US_V_DM_DU_LIEU_NHAN_VIEN m_us = new US_V_DM_DU_LIEU_NHAN_VIEN();
        private const String m_str_goi_y_tim_kiem = "Nhập Họ tên nhân viên, Mã nhân viên, Chức vụ, Trình độ,...";

        #endregion

        #region Private Methods
        private void format_controls() {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            m_fg.Tree.Column = (int)e_col_Number.TEN_DON_VI;
            m_fg.Tree.Style = TreeStyleFlags.Simple;
            set_define_events();
            KeyPreview = true;
        }
        private void set_initial_form_load() {
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_grid();
            if (m_cbo_gioi_tinh != null) {
                m_cbo_gioi_tinh.SelectedIndex = 0;
            }
            /*
            WinFormControls.load_data_to_cbo_tu_dien(WinFormControls.eLOAI_TU_DIEN.TRANG_THAI_LAO_DONG,
                                                    WinFormControls.eTAT_CA.YES,
                                                    m_cbo_trang_thai);
             * */
            //Load combobox "Trạng thái"
            load_data_to_cbo_trang_thai();
            load_custom_source_2_m_txt_tim_kiem();
        }

        private void load_data_to_cbo_trang_thai() {
            var v_us_dm_tu_dien = new IP.Core.IPUserService.US_CM_DM_TU_DIEN();
            var v_ds_dm_tu_dien = new IP.Core.IPData.DS_CM_DM_TU_DIEN();
            var v_str_loai_tu_dien = "";
            v_str_loai_tu_dien = MA_LOAI_TU_DIEN.TRANG_THAI_LAO_DONG;
            v_us_dm_tu_dien.fill_tu_dien_cung_loai_ds(
                v_str_loai_tu_dien
                , CM_DM_TU_DIEN.GHI_CHU
                , v_ds_dm_tu_dien);

            m_cbo_trang_thai.DataSource = v_ds_dm_tu_dien.CM_DM_TU_DIEN;
            m_cbo_trang_thai.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_trang_thai.ValueMember = CM_DM_TU_DIEN.ID;

            DataRow v_dr = v_ds_dm_tu_dien.CM_DM_TU_DIEN.NewRow();
            v_dr[CM_DM_TU_DIEN.ID] = -1;
            v_dr[CM_DM_TU_DIEN.TEN] = "------ Tất cả ------";
            v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = "";
            v_dr[CM_DM_TU_DIEN.TEN_NGAN] = "";
            v_dr[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN] = 1;
            v_dr[CM_DM_TU_DIEN.GHI_CHU] = "";
            v_ds_dm_tu_dien.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);
            m_cbo_trang_thai.SelectedIndex = 0;
        }
        private void load_custom_source_2_m_txt_tim_kiem() {
            var count = m_ds.Tables["V_DM_DU_LIEU_NHAN_VIEN"].Rows.Count;
            for (var i = 0; i < count; i++) {
                var dr = m_ds.Tables["V_DM_DU_LIEU_NHAN_VIEN"].Rows[i];
                m_txt_tim_kiem.AutoCompleteCustomSource.Add(dr["HO_DEM"].ToString());
                m_txt_tim_kiem.AutoCompleteCustomSource.Add(dr["TEN"].ToString());
                m_txt_tim_kiem.AutoCompleteCustomSource.Add(dr["HO_DEM"] + " " + dr["TEN"]);
                m_txt_tim_kiem.AutoCompleteCustomSource.Add(dr["HO_DEM"] + " " + dr["TEN"] + " - " + dr["MA_NV"]);
                m_txt_tim_kiem.AutoCompleteCustomSource.Add(dr["TRINH_DO"] + " - " + dr["TEN"]);
                m_txt_tim_kiem.AutoCompleteCustomSource.Add(dr["TRINH_DO"].ToString());
                m_txt_tim_kiem.AutoCompleteCustomSource.Add(dr["TEN_CV"].ToString());
            }
        }
        private ITransferDataRow get_trans_object(C1FlexGrid i_fg) {
            var v_htb = new Hashtable();
            v_htb.Add(V_DM_DU_LIEU_NHAN_VIEN.LOAI_DON_VI, e_col_Number.LOAI_DON_VI);
            v_htb.Add(V_DM_DU_LIEU_NHAN_VIEN.TEN_DON_VI, e_col_Number.TEN_DON_VI);
            v_htb.Add(V_DM_DU_LIEU_NHAN_VIEN.MA_NV, e_col_Number.MA_NV);
            v_htb.Add(V_DM_DU_LIEU_NHAN_VIEN.CAP_DON_VI, e_col_Number.CAP_DON_VI);
            v_htb.Add(V_DM_DU_LIEU_NHAN_VIEN.TRANG_THAI_LAO_DONG, e_col_Number.TRANG_THAI_LAO_DONG);
            v_htb.Add(V_DM_DU_LIEU_NHAN_VIEN.DIA_BAN, e_col_Number.DIA_BAN);
            v_htb.Add(V_DM_DU_LIEU_NHAN_VIEN.TEN, e_col_Number.TEN);
            v_htb.Add(V_DM_DU_LIEU_NHAN_VIEN.NGAY_CO_HIEU_LUC, e_col_Number.NGAY_CO_HIEU_LUC);
            v_htb.Add(V_DM_DU_LIEU_NHAN_VIEN.TRANG_THAI_HIEN_TAI, e_col_Number.TRANG_THAI_HIEN_TAI);
            v_htb.Add(V_DM_DU_LIEU_NHAN_VIEN.MA_DON_VI, e_col_Number.MA_DON_VI);
            v_htb.Add(V_DM_DU_LIEU_NHAN_VIEN.HO_DEM, e_col_Number.HO_DEM);
            v_htb.Add(V_DM_DU_LIEU_NHAN_VIEN.TY_LE_THAM_GIA, e_col_Number.TY_LE_THAM_GIA);
            v_htb.Add(V_DM_DU_LIEU_NHAN_VIEN.TEN_CV, e_col_Number.TEN_CV);
            v_htb.Add(V_DM_DU_LIEU_NHAN_VIEN.NGAY_HET_HIEU_LUC, e_col_Number.NGAY_HET_HIEU_LUC);
            v_htb.Add(V_DM_DU_LIEU_NHAN_VIEN.NGAY_SINH, e_col_Number.NGAY_SINH);
            v_htb.Add(V_DM_DU_LIEU_NHAN_VIEN.TRINH_DO, e_col_Number.TRINH_DO);
            v_htb.Add(V_DM_DU_LIEU_NHAN_VIEN.TRANG_THAI_CV, e_col_Number.TRANG_THAI_CV);
            v_htb.Add(V_DM_DU_LIEU_NHAN_VIEN.GIOI_TINH, e_col_Number.GIOI_TINH);
            v_htb.Add(V_DM_DU_LIEU_NHAN_VIEN.MA_CV, e_col_Number.MA_CV);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_DM_DU_LIEU_NHAN_VIEN.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid() {
            m_ds = new DS_V_DM_DU_LIEU_NHAN_VIEN();
            /*Xử lý tìm kiếm*/
            var v_str_search = m_txt_tim_kiem.Text.Trim();
            if (v_str_search.Equals(m_str_goi_y_tim_kiem)) {
                v_str_search = "";
            }
            /*
            var v_dat_thoi_diem = DateTime.Now;
            if (m_dtp_thoidiem.Checked) {
                v_dat_thoi_diem = m_dtp_thoidiem.Value.Date;
            }
            */
            var v_str_month = Regex.Match(v_str_search, @"\d+").Value;
            if (!v_str_month.Equals("")) {
                v_str_search = v_str_month;
            }
            m_us.FillDatasetTraCuuThongTinNhanVienChung(m_ds, v_str_search, get_gender(), get_trang_thai_lao_dong());
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            m_fg.Redraw = true;
            // Group (subtotal) trên grid.
            m_fg.Subtotal(AggregateEnum.Count
              , 0
              , (int)e_col_Number.TEN_DON_VI    // Group theo cột này
              , (int)e_col_Number.MA_NV         // Subtotal theo cột này
              , "{0}"
              );
            set_search_format_before();
            m_lbl_so_nhan_vien.Text = lay_so_ban_ghi().ToString(CultureInfo.InvariantCulture);
        }
        private int lay_so_ban_ghi() {
            return m_ds.V_DM_DU_LIEU_NHAN_VIEN.Count;
        }
        private string get_gender() {
            if (m_cbo_gioi_tinh.SelectedIndex == 1) {
                return "Nam";
            }
            if (m_cbo_gioi_tinh.SelectedIndex == 2) {
                return "Nữ";
            }
            return "";
        }
        private string get_trang_thai_lao_dong() {
            if (m_cbo_trang_thai.SelectedIndex != 0) {
                return m_cbo_trang_thai.Text;
            }
            return "";
        }
        private void set_search_format_before() {
            if (m_txt_tim_kiem.Text == "") {
                m_txt_tim_kiem.Text = m_str_goi_y_tim_kiem;
                m_txt_tim_kiem.ForeColor = Color.Gray;
            }
        }
        private void set_search_format_after() {
            if (m_txt_tim_kiem.Text == m_str_goi_y_tim_kiem) {
                m_txt_tim_kiem.Text = "";
            }
            m_txt_tim_kiem.ForeColor = Color.Black;
        }


        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //
        private void set_define_events() {
            m_cmd_exit.Click += m_cmd_exit_Click;
            m_cmd_search.Click += m_cmd_search_Click;
            m_txt_tim_kiem.KeyDown += m_txt_tim_kiem_KeyDown;
            m_cbo_trang_thai.SelectedIndexChanged += m_cbo_trang_thai_SelectedIndexChanged;
            m_txt_tim_kiem.KeyPress += CheckEnterKeyPress;
            m_txt_tim_kiem.MouseClick += m_txt_tim_kiem_MouseClick;
            m_txt_tim_kiem.Leave += m_txt_tim_kiem_Leave;
        }

        private void f103_bao_cao_tra_cuu_nhan_su_Load(object sender, EventArgs e) {
            try {
                set_initial_form_load();
            } catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_exit_Click(object sender, EventArgs e) {
            try {
                Close();
            } catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_search_Click(object sender, EventArgs e) {
            try {
                load_data_2_grid();
            } catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_tim_kiem_KeyDown(object sender, KeyEventArgs e) {
            try {
                if (e.KeyData == Keys.Enter)
                    load_data_2_grid();
            } catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cbo_trang_thai_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                load_data_2_grid();
            } catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e) {
            try {
                if (e.KeyChar == (char)Keys.Return) {
                    load_data_2_grid();
                }
            } catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_tim_kiem_MouseClick(object sender, MouseEventArgs e) {
            try {
                set_search_format_after();
            } catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_tim_kiem_Leave(object sender, EventArgs e) {
            try {
                set_search_format_before();
            } catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}

