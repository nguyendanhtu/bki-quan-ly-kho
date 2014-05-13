using BKI_KHO.DS;
using BKI_KHO.US;
using IP.Core.IPCommon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPSystemAdmin;
using BKI_KHO.DS.CDBNames;
namespace BKI_KHO
{
    public partial class f604_phieu_xuat_kho : Form
    {
        public f604_phieu_xuat_kho()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        public DialogResult display_detail_chung_tu(US_V_GD_CHUNG_TU i_us)
        {
            m_v_us_chung_tu = i_us;
            m_e_form_mode = DataEntryFormMode.SelectDataState;
            us_2_form_objects(m_v_us_chung_tu);
            this.ShowDialog();
            m_cmd_insert.Enabled = false;
            return m_dlg_result;
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
           
            MA_HANG_HOA = 1
            ,
            TEN_HANG_HOA = 2
                ,
            DON_VI_TINH = 3
                , SO_TIEN = 4
        }
        #endregion

        #region Members
        DialogResult m_dlg_result;
        DataEntryFormMode m_e_form_mode;
        ITransferDataRow m_obj_trans;
        decimal tong_tien = 0;
        decimal m_dc_tong_tien = 0;
        decimal m_dc_id = 0;
        decimal id_hang_hoa = 0;
        US_V_GD_CHUNG_TU m_v_us_chung_tu = new US_V_GD_CHUNG_TU();
        DS_V_DM_KHO m_ds_kho = new DS_V_DM_KHO();
        US_V_DM_KHO m_us_kho = new US_V_DM_KHO();
 
        US_GD_CHUNG_TU m_us_gd_chung_tu = new US_GD_CHUNG_TU();

        US_GD_CHI_TIET_CHUNG_TU m_us_gd_chung_tu_detail = new US_GD_CHI_TIET_CHUNG_TU();

        US_DM_NHAN_VIEN m_us_nhan_vien = new US_DM_NHAN_VIEN();

        US_GD_CHUNG_TU_NHAN_VIEN m_us_chung_tu_nv = new US_GD_CHUNG_TU_NHAN_VIEN();

        #endregion

        #region Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.m_lbl_ten_phieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            CGridUtils.ClearDataInGrid(m_fg);
            m_fg.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.None;
            m_fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
            m_fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
            this.MinimizeBox = true;
            this.MaximizeBox = true;
            set_define_events();
            m_txt_nguoi_thu.Enabled = false;
            m_fg.AllowEditing = true;
            this.KeyPreview = true;
            m_cmd_sua_phieu.Enabled = false;
            m_txt_so_phieu_thu_chi.Text = "PX-";
        }
        private void set_initial_form_load()
        {
            load_data_kho();
            m_dat_ngay_lap.Value = CIPConvert.ToStr(CAppContext_201.getCurentDate());
        }
        
        private bool check_validate_is_ok()
        {
            for (int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count - 1; v_i_cur_row++)
            {

                if (m_fg[v_i_cur_row, (int)e_col_Number.TEN_HANG_HOA].ToString() == "")
                {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập thông tin tên hàng ở một số mặt hàng");
                    m_fg.Select(v_i_cur_row, (int)e_col_Number.TEN_HANG_HOA);
                    return false;
                }
                if (m_fg[v_i_cur_row, (int)e_col_Number.MA_HANG_HOA].ToString() == "")
                {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập thông tin mã hàng ở một số mặt hàng");
                    m_fg.Select(v_i_cur_row, (int)e_col_Number.MA_HANG_HOA);
                    return false;
                }
                if (m_fg[v_i_cur_row, (int)e_col_Number.DON_VI_TINH].ToString() == "")
                {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập thông tin đơn vị tính ở một số mặt hàng");
                    m_fg.Select(v_i_cur_row, (int)e_col_Number.DON_VI_TINH);
                    return false;
                }
                if (m_fg[v_i_cur_row, (int)e_col_Number.SO_TIEN].ToString() == "")
                {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập thông tin giá nhập ở một số mặt hàng");
                    m_fg.Select(v_i_cur_row, (int)e_col_Number.SO_TIEN);
                    return false;
                }
            }
            if (!CValidateTextBox.IsValid(m_txt_so_phieu_thu_chi, DataType.StringType, allowNull.NO, false))
            {
                BaseMessages.MsgBox_Error("Số chứng từ không được để trống!");
                return false;
            }

            if (!CValidateTextBox.IsValid(m_dat_ngay_lap, DataType.DateType, allowNull.NO, true)) return false;


            if (CIPConvert.ToDecimal(m_txt_tong_tien.Text) == 0)
            {
                BaseMessages.MsgBox_Error("Số tiền phải lớn hơn 0 (vnđ)");
                m_txt_tong_tien.Focus();
                return false;
            }
            if (m_txt_ten_kho.Text.Length == 0)
            {
                BaseMessages.MsgBox_Error("Bạn phải chọn kho để nhập hàng hóa");
                m_txt_ten_kho.Focus();
                return false;
            }
            if (!check_so_chung_tu_is_not_exits_db()) return false;
            if (!check_value_phieu_detail())
                return false;

            if (!check_tong_tien()) return false;
            if (!check_ma_hang_hoa()) return false;
            return true;
        }
        private bool check_so_chung_tu_is_not_exits_db()
        {
            US_GD_CHUNG_TU v_gd_chung_tu = new US_GD_CHUNG_TU();
            bool v_bol_trung = false;

            v_bol_trung = v_gd_chung_tu.trung_so_chung_tu(m_txt_so_phieu_thu_chi.Text.Trim());

            if (v_bol_trung)
            {
                BaseMessages.MsgBox_Error("Số chứng từ đã tồn tại, không thể dùng số chứng từ " + m_txt_so_phieu_thu_chi.Text);
                m_txt_so_phieu_thu_chi.Focus();
                return false;
            }
            return true;

        }
        private bool check_ma_hang_hoa()
        {
            US_DM_HANG_HOA v_hang_hoa = new US_DM_HANG_HOA();
            bool v_bol_trung = false;
            for (int i = 1; i < m_fg.Rows.Count - 1; i++)
            {
                v_bol_trung = v_hang_hoa.exit_hang_hoa_yn(CIPConvert.ToStr(m_fg[i, (int)e_col_Number.MA_HANG_HOA]));

                if (!v_bol_trung)
                {
                    BaseMessages.MsgBox_Confirm("Kiểm tra lại mã hàng hóa");
                    m_fg.Select(i, (int)e_col_Number.MA_HANG_HOA);
                    return false;
                }
            }
            return true;

        }
        private bool check_value_phieu_detail()
        {
            int i = 1;
            for (i = 1; i <= m_fg.Rows.Count - 2; i++)
            {
                if (m_fg[i, (int)e_col_Number.MA_HANG_HOA] == null && m_fg[i, (int)e_col_Number.SO_TIEN] == null)
                {
                    m_fg.Rows.Remove(i);
                }
                else if (m_fg[i, (int)e_col_Number.MA_HANG_HOA] == null || m_fg[i, (int)e_col_Number.TEN_HANG_HOA] == null || m_fg[i, (int)e_col_Number.SO_TIEN] == null)
                {
                    BaseMessages.MsgBox_Infor("Các bút toán cần được nhập đầy đủ!");
                    return false;
                }
            }
            return true;
        }
        private bool check_tong_tien()
        {
            decimal v_dc_tong_tien = CIPConvert.ToDecimal(m_txt_tong_tien.Value);
            if (v_dc_tong_tien != get_tong_tien_nhap())
            {
                BaseMessages.MsgBox_Infor("Tổng số tiền chứng từ không bằng tổng số tiền chi tiết");
                return false;
            }
            return true;
        }
        private decimal get_tong_tien_nhap()
        {
            m_dc_tong_tien = 0;
            for (int i = 1; i <= m_fg.Rows.Count - 2; i++)
            {
                m_dc_tong_tien = m_dc_tong_tien + CIPConvert.ToDecimal(m_fg[i, (int)e_col_Number.SO_TIEN]);// * CIPConvert.ToDecimal(m_fg[i, (int)e_col_Number.SO_LUONG]
            }
            return m_dc_tong_tien;
        }
        private void save_data_2db()
        {
            US_DM_HANG_HOA v_us_hang_hoa = new US_DM_HANG_HOA();
            DS_DM_HANG_HOA v_ds_hang_hoa=new DS_DM_HANG_HOA ();
            if (!check_validate_is_ok()) return;
            form_2_us_gd_chung_tu();
            try
            {

                //1. insert ban ghi vao phieu_thu_chid
                m_us_gd_chung_tu.BeginTransaction();
                m_us_gd_chung_tu.Insert();
              
                //2. insert ban ghi vao phieu_thu_chi_detail
                m_us_gd_chung_tu_detail.UseTransOfUSObject(m_us_gd_chung_tu);
                for (int v_i_cur_grid_row = m_fg.Rows.Fixed; v_i_cur_grid_row <= m_fg.Rows.Count - 2; v_i_cur_grid_row++)
                {
                    //update giá xuất hàng
                    v_us_hang_hoa.UseTransOfUSObject(m_us_gd_chung_tu);
                    v_us_hang_hoa.update_gia_ban_hang(CIPConvert.ToStr(m_fg[v_i_cur_grid_row, (int)e_col_Number.MA_HANG_HOA])
                                            , CIPConvert.ToDecimal(m_fg[v_i_cur_grid_row, (int)e_col_Number.SO_TIEN])
                                            , v_ds_hang_hoa
                                            ,v_us_hang_hoa);
                    //insert phiếu detail
                    grid_row_2_us_gd_chi_tiet_chung_tu(
                        v_i_cur_grid_row
                        , m_us_gd_chung_tu_detail);
                    m_us_gd_chung_tu_detail.dcID_HANG_HOA = v_us_hang_hoa.dcID;
                    m_us_gd_chung_tu_detail.Insert();
                   
                }
                //2. insert gd chứng từ nhân viên
                m_us_chung_tu_nv.UseTransOfUSObject(m_us_gd_chung_tu);
                m_us_chung_tu_nv.dcID_CHUNG_TU = m_us_gd_chung_tu.dcID;
                m_us_chung_tu_nv.dcID_NHAN_VIEN = m_us_nhan_vien.dcID;
                m_us_chung_tu_nv.dcSO_TIEN = m_us_gd_chung_tu.dcTONG_TIEN;

                m_us_chung_tu_nv.Insert();
                m_us_gd_chung_tu.CommitTransaction();
                BaseMessages.MsgBox_Infor("Đã lập phiếu nhập kho thành công.");

            }
            catch (Exception v_e)
            {
                if (m_us_gd_chung_tu.is_having_transaction())
                {
                    m_us_gd_chung_tu.Rollback();
                }
                throw v_e;
            }

        }
        private void us_2_form_objects(US_V_GD_CHUNG_TU i_us)
        {
            m_txt_so_phieu_thu_chi.Text = i_us.strMA_CT;
            m_txt_tong_tien.Text = CIPConvert.ToStr(i_us.dcTONG_TIEN);
            m_dat_ngay_lap.Value = CIPConvert.ToDatetime(CIPConvert.ToStr(i_us.datNGAY_CT), "dd/MM/yyyy");
            m_txt_noi_dung.Text = i_us.strDIEN_GIAI;
            m_txt_ten_kho.Text = CIPConvert.ToStr(i_us.dcID_TO_CHUC_NGUON);
            m_txt_nguoi_thu.Text = CIPConvert.ToStr(i_us.dcID_NGUOI_GIAO_DICH);

        }
        private void form_2_us_gd_chung_tu()
        {
            //GD chứng từ
            string v_str_ngay_thu_chi = CIPConvert.ToStr(m_dat_ngay_lap.Value, "dd/MM/yyyy");
            m_us_gd_chung_tu.strDIEN_GIAI = m_txt_noi_dung.Text;
            m_us_gd_chung_tu.dcID_LOAI_CT = 2;//phiếu xuất kho
            m_us_gd_chung_tu.strMA_CT = m_txt_so_phieu_thu_chi.Text;
            m_us_gd_chung_tu.datNGAY_CT = IP.Core.IPSystemAdmin.CAppContext_201.getCurentDate();
            m_us_gd_chung_tu.dcTONG_TIEN = CIPConvert.ToDecimal(m_txt_tong_tien.Text);
            m_us_gd_chung_tu.SetID_TO_CHUC_DICHNull();
            m_us_gd_chung_tu.SetID_TO_CHUC_NGUONNull();
            m_us_gd_chung_tu.SetID_NGUOI_GIAO_DICHNull();
            m_us_gd_chung_tu.SetID_NGUOI_NHAPNull();
            m_us_gd_chung_tu.SetNGAY_NHAPNull();
            m_us_gd_chung_tu.SetNGAY_NHAP_CUOINull();
            m_us_gd_chung_tu.SetGHI_CHU_1Null();
            m_us_gd_chung_tu.SetGHI_CHU_2Null();
            m_us_gd_chung_tu.SetGHI_CHU_3Null();
        }
        private void load_data_kho()
        {

            try
            {
                m_us_kho.FillDataset(m_ds_kho);
                DataRow v_dr = (DataRow)m_ds_kho.V_DM_KHO.Rows[0];
                m_us_kho.DataRow2Me(v_dr);
                m_txt_ten_kho.Text = m_us_kho.strTEN_KHO;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }


        }
        private void grid_row_2_us_gd_chi_tiet_chung_tu(
            int ip_grid_row
            , US_GD_CHI_TIET_CHUNG_TU ip_us_gd_chi_tiet_chung_tu)
        {
            ip_us_gd_chi_tiet_chung_tu.dcID_CHUNG_TU = m_us_gd_chung_tu.dcID;
            //ip_us_gd_chi_tiet_chung_tu.dcID_HANG_HOA = CIPConvert.ToDecimal(m_fg[ip_grid_row, (int)e_col_Number.TEN_HANG_HOA]);
            ip_us_gd_chi_tiet_chung_tu.dcSO_LUONG = 1;
            ip_us_gd_chi_tiet_chung_tu.dcGIA_GIAO_DICH = CIPConvert.ToDecimal(m_fg[ip_grid_row, (int)e_col_Number.SO_TIEN]);
            ip_us_gd_chi_tiet_chung_tu.SetID_DON_VI_TINHNull();
            ip_us_gd_chi_tiet_chung_tu.strSO_SERI = CIPConvert.ToStr(m_fg[ip_grid_row, (int)e_col_Number.MA_HANG_HOA]);
            ip_us_gd_chi_tiet_chung_tu.SetTHOI_GIAN_BHNull();
            ip_us_gd_chi_tiet_chung_tu.SetID_DVT_THOI_GIANNull();

        }
        private void grid2us_object(US_V_GD_CHUNG_TU i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }
       
        private void set_define_events()
        {
            m_cmd_exit.Click += m_cmd_exit_Click;
            m_cmd_chon_kho.Click += m_cmd_chon_kho_Click;
            this.Load += f604_phieu_xuat_kho_Load;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_xem.Click += m_cmd_xem_Click;
            m_fg.CellChanged += m_fg_CellChanged;
        }

        void m_fg_CellChanged(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                
                if (e.Col == (int)e_col_Number.SO_TIEN)
                {
                    
                    tong_tien += (CIPConvert.ToDecimal(m_fg[m_fg.Row, (int)e_col_Number.SO_TIEN]));
                    m_txt_tong_tien.Value = CIPConvert.ToStr(tong_tien);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f604_phieu_xuat_kho_Load(object sender, EventArgs e)
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

        void m_cmd_exit_Click(object sender, EventArgs e)
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
        void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                save_data_2db();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        
        void f600_phieu_nhap_kho_Load(object sender, EventArgs e)
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

        void m_cmd_chon_kho_Click(object sender, EventArgs e)
        {
            //f110_V_DM_KHO v_frm = new f110_V_DM_KHO();
            //DialogResult v_dlg_result = v_frm.display_select_f250(m_us_kho);
            //if (v_dlg_result == DialogResult.OK)
            //{
            //    m_txt_ten_kho.Text = m_us_kho.strMA_KHO;
            //}

            f701_DM_NHAN_VIEN v_frm = new f701_DM_NHAN_VIEN();
            DialogResult v_dlg_result = v_frm.display_select_f250(m_us_nhan_vien);
            if (v_dlg_result == DialogResult.OK)
            {
                m_txt_nguoi_thu.Text = m_us_nhan_vien.strHO_DEM + " " + m_us_nhan_vien.strTEN;
                m_txt_nguoi_thu.Enabled = false;
            }
        }
        void m_cmd_xem_Click(object sender, EventArgs e)
        {
            f602_v_gd_chung_tu v_frm = new f602_v_gd_chung_tu();
            v_frm.display(2);
          
        }

        #endregion
    }
}
