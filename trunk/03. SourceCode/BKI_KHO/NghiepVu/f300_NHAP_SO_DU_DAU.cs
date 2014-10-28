using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPExcelReport;
using BKI_KHO.DS;
using BKI_KHO.US;
using BKI_KHO.DS.CDBNames;
namespace BKI_KHO.NghiepVu {
    public partial class f300_NHAP_SO_DU_DAU : Form {
        public f300_NHAP_SO_DU_DAU() {
            InitializeComponent();
            format_control();
        }

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        #endregion

        #region Public Interface
        public void display() {
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number {
            NHOM_HANG = 1
           ,
            TEN_HANG = 2
            ,
            MA_HANG = 3
                ,
            DON_VI_TINH = 4
                ,
            GIA_NHAP = 5

        }
        private enum e_col_ExcelNumber {
            NHOM_HANG = 7
           ,
            TEN_HANG = 3
            ,
            MA_HANG = 4
                ,
            DON_VI_TINH = 8
                ,
            GIA_NHAP = 6

        }
        #endregion

        #region Privates Methods
        private void format_control() {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.m_lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);

            //CGridUtils.ClearDataInGrid(m_fg);
            m_fg.AllowAddNew = true;
            //CGridUtils.ClearDataInGrid(m_fg);

            m_fg.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.None;
            m_fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
            m_fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
          
            set_define_events();

            m_fg.AllowEditing = true;
            this.KeyPreview = true;
        }
        private void set_initial_form_load() {
            load_cbo_nhom_hang_2_grid();
            load_cbo_don_vi_tinh_2_grid();
            switch(m_e_form_mode) {
                case DataEntryFormMode.InsertDataState:
                    m_txt_ma_ct.Text = "SDD-" + CIPConvert.ToStr(CAppContext_201.getCurentDate(), "yyy-MM-dd");
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }
        }
        private void load_cbo_don_vi_tinh_2_grid() {
            m_fg.Cols[(int) e_col_Number.DON_VI_TINH].DataMap = get_mapping_col_don_vi_tinh();
        }
        private Hashtable get_mapping_col_don_vi_tinh() {
            Hashtable v_hst = new Hashtable();
            DS_DM_DON_VI v_ds_dm_don_vi = new DS_DM_DON_VI();
            US_DM_DON_VI v_us_dm_don_vi = new US_DM_DON_VI();


            v_us_dm_don_vi.FillDataset(v_ds_dm_don_vi);

            foreach(DataRow v_dr in v_ds_dm_don_vi.DM_DON_VI.Rows) {
                v_hst.Add(v_dr[DM_DON_VI.ID], v_dr[DM_DON_VI.TEN]);
            }
            return v_hst;
        }
        private Hashtable get_mapping_col_excel_grid() {
            Hashtable v_hst = new Hashtable();
            v_hst.Add((int) e_col_Number.NHOM_HANG, (int) e_col_ExcelNumber.NHOM_HANG);
            v_hst.Add((int) e_col_Number.TEN_HANG, (int) e_col_ExcelNumber.TEN_HANG);
            v_hst.Add((int) e_col_Number.MA_HANG, (int) e_col_ExcelNumber.MA_HANG);
            v_hst.Add((int) e_col_Number.DON_VI_TINH, (int) e_col_ExcelNumber.DON_VI_TINH);
            v_hst.Add((int) e_col_Number.GIA_NHAP, (int) e_col_ExcelNumber.GIA_NHAP);
            return v_hst;
        }
        private void load_cbo_nhom_hang_2_grid() {
            m_fg.Cols[(int) e_col_Number.NHOM_HANG].DataMap = get_mapping_col_nhom_hang();
        }
        private Hashtable get_mapping_col_nhom_hang() {
            Hashtable v_hst = new Hashtable();

            US_DM_NHOM_HANG v_us_nhom_hang = new US_DM_NHOM_HANG();
            DS_DM_NHOM_HANG v_ds_nhom_hang = new DS_DM_NHOM_HANG();

            v_us_nhom_hang.FillDataset(v_ds_nhom_hang);


            foreach(DataRow v_dr in v_ds_nhom_hang.DM_NHOM_HANG.Rows) {
                v_hst.Add(v_dr[DM_NHOM_HANG.ID], v_dr[DM_NHOM_HANG.TEN]);
            }
            return v_hst;
        }
        private bool check_validate_is_ok() {
            if(!CValidateTextBox.IsValid(m_txt_ma_ct, DataType.StringType, allowNull.NO, true))
                return false;
            if(!check_validate_grid_is_ok())
                return false;

            return true;
        }
        private bool check_validate_grid_is_ok() {
            if(!check_so_chung_tu_is_not_exits_db()) {
                BaseMessages.MsgBox_Infor("Số chứng từ đã tồn tại, nhập số chứng từ khác");
                m_txt_ma_ct.Select();
            }
            for(int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count - 1; v_i_cur_row++) {
                if(m_fg[v_i_cur_row, (int) e_col_Number.NHOM_HANG] == null) {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập thông tin nhóm hàng ở một số mặt hàng");
                    m_fg.Select(v_i_cur_row, (int) e_col_Number.NHOM_HANG);
                    return false;
                }
                if(m_fg[v_i_cur_row, (int) e_col_Number.TEN_HANG] == null) {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập thông tin tên hàng ở một số mặt hàng");
                    m_fg.Select(v_i_cur_row, (int) e_col_Number.TEN_HANG);
                    return false;
                }
                if(m_fg[v_i_cur_row, (int) e_col_Number.MA_HANG] == null) {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập thông tin mã hàng ở một số mặt hàng");
                    m_fg.Select(v_i_cur_row, (int) e_col_Number.MA_HANG);
                    return false;
                }
                if(m_fg[v_i_cur_row, (int) e_col_Number.DON_VI_TINH] == null) {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập thông tin đơn vị tính ở một số mặt hàng");
                    m_fg.Select(v_i_cur_row, (int) e_col_Number.DON_VI_TINH);
                    return false;
                }
                if(m_fg[v_i_cur_row, (int) e_col_Number.GIA_NHAP] == null) {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập thông tin giá nhập ở một số mặt hàng");
                    m_fg.Select(v_i_cur_row, (int) e_col_Number.GIA_NHAP);
                    return false;
                }
            }
            return true;
        }
        private decimal get_tong_tien() {
            decimal v_dc_tong_tien = 0;
            for(int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count - 1; v_i_cur_row++) {
                v_dc_tong_tien += CIPConvert.ToDecimal(m_fg[v_i_cur_row, (int) e_col_Number.GIA_NHAP]);
            }

            return v_dc_tong_tien;
        }
        private void form_2_us_v_gd_chung_tu(US_GD_CHUNG_TU ip_us_gd_chung_tu) {

            ip_us_gd_chung_tu.dcID_LOAI_CT = CONST_ID_DM_LOAI_CHUNG_TU.ID_NHAP_SO_DU;
            ip_us_gd_chung_tu.strDIEN_GIAI = "Nhập sô dư đầu hàng hóa cho kho";
            ip_us_gd_chung_tu.strMA_CT = m_txt_ma_ct.Text;

            ip_us_gd_chung_tu.dcTONG_TIEN = get_tong_tien();
            ip_us_gd_chung_tu.SetID_TO_CHUC_DICHNull();
            ip_us_gd_chung_tu.SetID_TO_CHUC_NGUONNull();
            ip_us_gd_chung_tu.SetID_NGUOI_GIAO_DICHNull();

            ip_us_gd_chung_tu.SetGHI_CHU_1Null();
            ip_us_gd_chung_tu.SetGHI_CHU_2Null();
            ip_us_gd_chung_tu.SetGHI_CHU_3Null();

            ip_us_gd_chung_tu.dcID_NGUOI_NHAP = CAppContext_201.getCurrentUserID();
            ip_us_gd_chung_tu.datNGAY_CT = IP.Core.IPSystemAdmin.CAppContext_201.getCurentDate();
            ip_us_gd_chung_tu.datNGAY_NHAP = IP.Core.IPSystemAdmin.CAppContext_201.getCurentDate();
            ip_us_gd_chung_tu.datNGAY_NHAP_CUOI = IP.Core.IPSystemAdmin.CAppContext_201.getCurentDate();
        }
        private void grid_row_2_us_gd_chi_tiet_chung_tu(
            int ip_grid_row
            , US_V_GD_CHI_TIET_CHUNG_TU iop_us_gd_chi_tiet_chung_tu
            , US_GD_CHUNG_TU ip_us_gd_chung_tu) {

            iop_us_gd_chi_tiet_chung_tu.dcID_CHUNG_TU 
                = ip_us_gd_chung_tu.dcID;

            iop_us_gd_chi_tiet_chung_tu.SetMA_CTNull();                 //NULL
            iop_us_gd_chi_tiet_chung_tu.SetNGAY_CTNull();               //NULL
            iop_us_gd_chi_tiet_chung_tu.SetDIEN_GIAINull();             //NULL
            iop_us_gd_chi_tiet_chung_tu.SetTONG_TIENNull();             //NULL
            iop_us_gd_chi_tiet_chung_tu.SetID_TO_CHUC_NGUONNull();      //NULL
            iop_us_gd_chi_tiet_chung_tu.SetID_NGUOI_GIAO_DICHNull();    //NULL
            iop_us_gd_chi_tiet_chung_tu.SetID_NGUOI_NHAPNull();         //NULL
            iop_us_gd_chi_tiet_chung_tu.SetNGAY_NHAP_PMNull();          //NULL

            iop_us_gd_chi_tiet_chung_tu.dcID_NHOM                      
                = CIPConvert.ToDecimal(m_fg[ip_grid_row, (int) e_col_Number.NHOM_HANG]);

            iop_us_gd_chi_tiet_chung_tu.strMA_HANG
                = CIPConvert.ToStr(m_fg[ip_grid_row, (int) e_col_Number.MA_HANG]);

            iop_us_gd_chi_tiet_chung_tu.strTEN_HANG_VN 
                = CIPConvert.ToStr(m_fg[ip_grid_row, (int) e_col_Number.TEN_HANG]);

            iop_us_gd_chi_tiet_chung_tu.dcGIA_NHAP 
                = CIPConvert.ToDecimal(m_fg[ip_grid_row, (int) e_col_Number.GIA_NHAP]);

            iop_us_gd_chi_tiet_chung_tu.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_HANG_HOA.ID_DA_NHAP;


            iop_us_gd_chi_tiet_chung_tu.dcSO_LUONG = 1;

            iop_us_gd_chi_tiet_chung_tu.dcID_DON_VI_TINH
                = CIPConvert.ToDecimal(m_fg[ip_grid_row, (int) e_col_Number.DON_VI_TINH]);
            iop_us_gd_chi_tiet_chung_tu.SetTEN_LOAI_CTNull();
            iop_us_gd_chi_tiet_chung_tu.dcID_DVT_THOI_GIAN = CONST_ID_DVT_THOI_GIAN.ID_THANG;
        }
        private void save_data() {
            //1. Kiem tra du lieu da ok chua? Neu chua OK thi khong lam gi het!
            if(!check_validate_is_ok())
                return;

            US_GD_CHUNG_TU v_us_gd_chung_tu = new US_GD_CHUNG_TU();
            US_V_GD_CHI_TIET_CHUNG_TU v_us_gd_chi_tiet_chung_tu = new US_V_GD_CHI_TIET_CHUNG_TU();

            try {

                v_us_gd_chung_tu.BeginTransaction();
                //2. insert data
                //2.1 insert chung tu
                form_2_us_v_gd_chung_tu(v_us_gd_chung_tu);
                v_us_gd_chung_tu.Insert();
                v_us_gd_chi_tiet_chung_tu.UseTransOfUSObject(v_us_gd_chung_tu);
                //2.2 insert hang hoa va gd chi tiet chung tu
                for(int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count - 1; v_i_cur_row++) {
                    grid_row_2_us_gd_chi_tiet_chung_tu(v_i_cur_row, v_us_gd_chi_tiet_chung_tu, v_us_gd_chung_tu);
                    v_us_gd_chi_tiet_chung_tu.Insert();
                }
                v_us_gd_chung_tu.CommitTransaction();
            }
            catch(System.Exception v_e) {
                if(v_us_gd_chung_tu.is_having_transaction()) {
                    v_us_gd_chung_tu.Rollback();
                }
                throw v_e;
            }

            //3. Thong bao thanh cong
            BaseMessages.MsgBox_Infor("Bạn đã cập nhật xong số dư đầu cho hàng hóa!");
        }
        private void excel_2_grid() {
            if(!CValidateTextBox.IsValid(m_txt_so_ban_ghi, DataType.NumberType, allowNull.NO, true))
                return;
            m_obj_dialog = new System.Windows.Forms.OpenFileDialog();
            m_obj_dialog.ShowDialog();

            m_fg.Rows.Count = int.Parse(m_txt_so_ban_ghi.Text) + 2;
            Hashtable v_hst_excel_col = get_mapping_col_excel_grid();

            CExcelReport v_obj_excel_rpt = new CExcelReport(m_obj_dialog.FileName);
            int v_i_start_excel_row = 2;
            //for(int v_i_cur_col = m_fg.Cols.Fixed; v_i_cur_col < m_fg.Cols.Count; v_i_cur_col++)// {
            //   // v_obj_excel_rpt.Export2Grid(m_fg
            //        , v_i_start_excel_row
            //        , (int) v_hst_excel_col[v_i_cur_col]
            //        , v_i_cur_col
            //        , true);
         //   }
            CGridUtils.MakeSoTT(0, m_fg);
        }
        private void set_define_events() {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            this.Load += f300_NHAP_SO_DU_DAU_Load;
            m_cmd_save.Click += m_cmd_save_Click;
            m_cmd_nhap_lo.Click += m_cmd_nhap_lo_Click;
            m_cmd_del.Click += m_cmd_del_Click;
            m_fg.AfterAddRow += m_fg_AfterAddRow;
        }
        private bool check_so_chung_tu_is_not_exits_db() {
            DS_GD_CHUNG_TU v_ds_gd_chung_tu = new DS_GD_CHUNG_TU();
            US_GD_CHUNG_TU v_us_gd_chung_tu = new US_GD_CHUNG_TU();

            v_us_gd_chung_tu.FillDataset(v_ds_gd_chung_tu);

            foreach(DataRow v_dr in v_ds_gd_chung_tu.GD_CHUNG_TU.Rows) {
                if(v_dr["MA_CT"].ToString() == m_txt_ma_ct.Text.Trim())
                    return false;
            }
            return true;
        }
        #endregion

        #region Events
        void m_cmd_del_Click(object sender, EventArgs e) {
            try {
                if(m_fg.Rows.Count == 3) {
                    return;
                }
                m_fg.Rows.Remove(m_fg.Row);
                CGridUtils.MakeSoTT(0, m_fg);
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void f300_NHAP_SO_DU_DAU_Load(object sender, EventArgs e) {
            try {
                set_initial_form_load();
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_exit_Click(object sender, EventArgs e) {
            try {
                this.Close();
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_save_Click(object sender, EventArgs e) {
            try {
                save_data();
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_nhap_lo_Click(object sender, EventArgs e) {
            try {

                excel_2_grid();
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_fg_AfterAddRow(object sender, C1.Win.C1FlexGrid.RowColEventArgs e) {
            CGridUtils.MakeSoTT(0, m_fg);
        }
        #endregion
    }
}