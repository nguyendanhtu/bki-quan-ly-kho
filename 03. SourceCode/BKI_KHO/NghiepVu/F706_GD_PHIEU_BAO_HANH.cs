///************************************************
/// Generated by: HOANGNH
/// Date: 02/05/2014 12:22:14
/// Goal: Create Form for GD_CHUNG_TU
///************************************************


using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using BKI_KHO.NghiepVu;
using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;

using BKI_KHO.US;
using BKI_KHO.DS;
using BKI_KHO.DS.CDBNames;

using C1.Win.C1FlexGrid;

namespace BKI_KHO
{



    public class F706_GD_PHIEU_BAO_HANH : System.Windows.Forms.Form
    {
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private Panel m_pn_top;
        private Label m_lbl_total_record;
        private Label label2;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private TextBox m_txt_tim_kiem;
        private Label m_lbl_total_rows;
        internal SIS.Controls.Button.SiSButton m_cmd_view;
        internal SIS.Controls.Button.SiSButton m_cmd_select;
        private System.ComponentModel.IContainer components;

        public F706_GD_PHIEU_BAO_HANH()
        {
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F706_GD_PHIEU_BAO_HANH));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_select = new SIS.Controls.Button.SiSButton();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_pn_top = new System.Windows.Forms.Panel();
            this.m_lbl_total_rows = new System.Windows.Forms.Label();
            this.m_lbl_total_record = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.m_pn_top.SuspendLayout();
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
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_select);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_view);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 505);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(1074, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_cmd_select
            // 
            this.m_cmd_select.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_select.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_select.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_select.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_select.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_select.ImageIndex = 13;
            this.m_cmd_select.ImageList = this.ImageList;
            this.m_cmd_select.Location = new System.Drawing.Point(428, 4);
            this.m_cmd_select.Name = "m_cmd_select";
            this.m_cmd_select.Size = new System.Drawing.Size(153, 28);
            this.m_cmd_select.TabIndex = 23;
            this.m_cmd_select.Text = "Chọn phiếu";
            this.m_cmd_select.Click += new System.EventHandler(this.m_cmd_select_Click);
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
            this.m_cmd_insert.Location = new System.Drawing.Point(581, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_insert.TabIndex = 12;
            this.m_cmd_insert.Text = "&Thêm";
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
            this.m_cmd_update.Location = new System.Drawing.Point(669, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(87, 28);
            this.m_cmd_update.TabIndex = 13;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_view
            // 
            this.m_cmd_view.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_view.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_view.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_view.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_view.ImageIndex = 18;
            this.m_cmd_view.ImageList = this.ImageList;
            this.m_cmd_view.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_view.Name = "m_cmd_view";
            this.m_cmd_view.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_view.TabIndex = 21;
            this.m_cmd_view.Text = "Xem";
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
            this.m_cmd_delete.Location = new System.Drawing.Point(756, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(158, 28);
            this.m_cmd_delete.TabIndex = 14;
            this.m_cmd_delete.Text = "&Xoá";
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
            this.m_cmd_exit.Location = new System.Drawing.Point(914, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(156, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 83);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(1074, 422);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // m_pn_top
            // 
            this.m_pn_top.Controls.Add(this.m_lbl_total_rows);
            this.m_pn_top.Controls.Add(this.m_lbl_total_record);
            this.m_pn_top.Controls.Add(this.label2);
            this.m_pn_top.Controls.Add(this.m_cmd_search);
            this.m_pn_top.Controls.Add(this.m_txt_tim_kiem);
            this.m_pn_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_pn_top.Location = new System.Drawing.Point(0, 0);
            this.m_pn_top.Name = "m_pn_top";
            this.m_pn_top.Size = new System.Drawing.Size(1074, 83);
            this.m_pn_top.TabIndex = 22;
            // 
            // m_lbl_total_rows
            // 
            this.m_lbl_total_rows.AutoSize = true;
            this.m_lbl_total_rows.Location = new System.Drawing.Point(146, 52);
            this.m_lbl_total_rows.Name = "m_lbl_total_rows";
            this.m_lbl_total_rows.Size = new System.Drawing.Size(0, 13);
            this.m_lbl_total_rows.TabIndex = 27;
            // 
            // m_lbl_total_record
            // 
            this.m_lbl_total_record.AutoSize = true;
            this.m_lbl_total_record.Location = new System.Drawing.Point(12, 61);
            this.m_lbl_total_record.Name = "m_lbl_total_record";
            this.m_lbl_total_record.Size = new System.Drawing.Size(0, 13);
            this.m_lbl_total_record.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tìm kiếm";
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(841, 14);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 24;
            this.m_cmd_search.Text = "Tìm kiếm";
            this.m_cmd_search.Click += new System.EventHandler(this.m_cmd_search_Click);
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_txt_tim_kiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.m_txt_tim_kiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.m_txt_tim_kiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(201, 19);
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(634, 20);
            this.m_txt_tim_kiem.TabIndex = 23;
            // 
            // F706_GD_PHIEU_BAO_HANH
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1074, 541);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pn_top);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "F706_GD_PHIEU_BAO_HANH";
            this.Text = "F706 - Danh sách phiếu bảo hành";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F706_GD_PHIEU_BAO_HANH_FormClosed);
            this.Load += new System.EventHandler(this.F706_GD_PHIEU_BAO_HANH_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.m_pn_top.ResumeLayout(false);
            this.m_pn_top.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            NGAY_CT = 2
,
            GHI_CHU_3 = 7
                ,
            GHI_CHU_2 = 6
                ,
            TONG_TIEN = 4
                ,
            DIEN_GIAI = 3
                ,
            MA_CT = 1
                , GHI_CHU_1 = 5

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_GD_CHUNG_TU m_ds = new DS_GD_CHUNG_TU();
        US_GD_CHUNG_TU m_us = new US_GD_CHUNG_TU();

        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            set_define_events();
            this.KeyPreview = true;
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_grid();
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(GD_CHUNG_TU.NGAY_CT, e_col_Number.NGAY_CT);
            v_htb.Add(GD_CHUNG_TU.GHI_CHU_3, e_col_Number.GHI_CHU_3);
            v_htb.Add(GD_CHUNG_TU.GHI_CHU_2, e_col_Number.GHI_CHU_2);
            v_htb.Add(GD_CHUNG_TU.TONG_TIEN, e_col_Number.TONG_TIEN);
            v_htb.Add(GD_CHUNG_TU.DIEN_GIAI, e_col_Number.DIEN_GIAI);
            v_htb.Add(GD_CHUNG_TU.MA_CT, e_col_Number.MA_CT);
            v_htb.Add(GD_CHUNG_TU.GHI_CHU_1, e_col_Number.GHI_CHU_1);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.GD_CHUNG_TU.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_GD_CHUNG_TU();
            m_us.FillDatasetByLoaiChungTu(m_ds, m_txt_tim_kiem.Text);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }
        private void grid2us_object(US_GD_CHUNG_TU i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_GD_CHUNG_TU i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_gd_chung_tu()
        {
            //	F706_GD_PHIEU_BAO_HANH_DE v_fDE = new  F706_GD_PHIEU_BAO_HANH_DE();								
            //	v_fDE.display();
            load_data_2_grid();
        }

        private void update_gd_chung_tu()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	F706_GD_PHIEU_BAO_HANH_DE v_fDE = new F706_GD_PHIEU_BAO_HANH_DE();
            //	v_fDE.display(m_us);
            load_data_2_grid();
        }

        private void delete_gd_chung_tu()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_GD_CHUNG_TU v_us = new US_GD_CHUNG_TU();
            grid2us_object(v_us, m_fg.Row);
            try
            {
                v_us.BeginTransaction();
                US_GD_CHI_TIET_CHUNG_TU v_us_gd_chi_tiet_chung_tu = new US_GD_CHI_TIET_CHUNG_TU();
                DS_GD_CHI_TIET_CHUNG_TU v_ds_gd_chi_tiet_chung_tu = new DS_GD_CHI_TIET_CHUNG_TU();
                US_GD_CHUNG_TU_NHAN_VIEN v_us_gd_chung_tu_nhan_vien = new US_GD_CHUNG_TU_NHAN_VIEN();
                DS_GD_CHUNG_TU_NHAN_VIEN v_ds_gd_chung_tu_nhan_vien = new DS_GD_CHUNG_TU_NHAN_VIEN();

                v_us_gd_chung_tu_nhan_vien.FillDatasetByIDChungTu(v_ds_gd_chung_tu_nhan_vien, v_us.dcID);
                for (int i = 0; i < v_ds_gd_chung_tu_nhan_vien.GD_CHUNG_TU_NHAN_VIEN.Count; i++)
                {
                    v_us_gd_chung_tu_nhan_vien.DeleteByID((decimal)v_ds_gd_chung_tu_nhan_vien.Tables[0].Rows[i]["ID"]);
                }
                v_us_gd_chi_tiet_chung_tu.FillDatasetByIDChungTu(v_ds_gd_chi_tiet_chung_tu, v_us.dcID);
                for (int i = 0; i < v_ds_gd_chi_tiet_chung_tu.GD_CHI_TIET_CHUNG_TU.Count; i++)
                {
                    v_us_gd_chi_tiet_chung_tu.DeleteByID((decimal)v_ds_gd_chi_tiet_chung_tu.Tables[0].Rows[i]["ID"]);
                }
                v_us.Delete();
                v_us.CommitTransaction();
                m_fg.Rows.Remove(m_fg.Row);
            }
            catch (Exception v_e)
            {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_gd_chung_tu()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	F706_GD_PHIEU_BAO_HANH_DE v_fDE = new F706_GD_PHIEU_BAO_HANH_DE();			
            //	v_fDE.display(m_us);
        }

        private void select_phieu_sua_chua()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            F704_V_BAO_HANH_SUA_CHUA frm = new F704_V_BAO_HANH_SUA_CHUA();
            frm.display_for_update(m_us);
            this.Hide();
        }

        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
        }
        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //
        private void F706_GD_PHIEU_BAO_HANH_Load(object sender, System.EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                insert_gd_chung_tu();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                update_gd_chung_tu();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                delete_gd_chung_tu();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_view_Click(object sender, EventArgs e)
        {
            try
            {
                view_gd_chung_tu();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void F706_GD_PHIEU_BAO_HANH_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                F704_V_BAO_HANH_SUA_CHUA frm = new F704_V_BAO_HANH_SUA_CHUA();
                frm.Show();
                this.Hide();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_select_Click(object sender, EventArgs e)
        {
            try
            {
                select_phieu_sua_chua();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}

