using BKI_KHO.DS.CDBNames;
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
using BKI_KHO.DS;
using BKI_KHO.US;
using IP.Core.IPSystemAdmin;
namespace BKI_KHO
{
    public partial class f600_phieu_nhap_kho : Form
    {
        public f600_phieu_nhap_kho()
        {
            InitializeComponent();
            format_controls();

        }
        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            MA_HANG_HOA=1
           ,SO_LUONG=2
            ,SO_TIEN=3
            //,THANH_TIEN=4
        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        decimal m_dc_tong_tien = 0;
        DS_V_DM_KHO m_ds_kho = new DS_V_DM_KHO();
        US_V_DM_KHO m_us_kho = new US_V_DM_KHO();

        DS_V_GD_CHUNG_TU v_ds_chung_tu = new DS_V_GD_CHUNG_TU();
        US_V_GD_CHUNG_TU v_us_chung_tu = new US_V_GD_CHUNG_TU();
        decimal id_nhan_vien = 0;
        US_GD_CHUNG_TU v_us_gd_chung_tu = new US_GD_CHUNG_TU();
        US_GD_CHI_TIET_CHUNG_TU v_us_gd_chung_tu_detail = new US_GD_CHI_TIET_CHUNG_TU();

        US_DM_NHAN_VIEN v_us_nhan_vien = new US_DM_NHAN_VIEN();
        US_GD_CHUNG_TU_NHAN_VIEN v_us_chung_tu_nv = new US_GD_CHUNG_TU_NHAN_VIEN();
        #endregion

        #region Methods
        private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201());
			CControlFormat.setC1FlexFormat(m_fg);
			CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            CGridUtils.ClearDataInGrid(m_fg);
            this.MinimizeBox = true;
            this.MaximizeBox = true;
			set_define_events();
            m_fg.AllowEditing = true;
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
            load_cbo_ten_hang_hoa_on_grid();
			//load_data_2_grid();
            //String.Format("{0:0,0 VNĐ}", m_ds.Tables[0].Columns["GIA_NHAP"].ToString()).Replace(",", ".");
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(v_gd_chung_tu.MA_HANG, e_col_Number.MA_HANG_HOA);
            v_htb.Add(v_gd_chung_tu.SO_LUONG, e_col_Number.SO_LUONG);
            v_htb.Add(v_gd_chung_tu.GIA_NHAP, e_col_Number.SO_TIEN);


            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, v_ds_chung_tu.v_gd_chung_tu.Newv_gd_chung_tuRow());
			return v_obj_trans;			
		}
		
        private Hashtable get_mapping_col_muc_dich()
        {
            US_DM_HANG_HOA v_us_hang_hoa = new US_DM_HANG_HOA();
            DS_DM_HANG_HOA v_ds_hang_hoa = new DS_DM_HANG_HOA();
            Hashtable v_hst = new Hashtable();
            try
            {
                v_us_hang_hoa.BeginTransaction();

                v_us_hang_hoa.FillDataset(v_ds_hang_hoa, "order by ma_hang");
                v_us_hang_hoa.CommitTransaction();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
            foreach (DataRow v_dr in v_ds_hang_hoa.DM_HANG_HOA.Rows)
            {
                v_hst.Add(v_dr[DM_HANG_HOA.ID], v_dr[DM_HANG_HOA.TEN_HANG_VN]);
            }
            return v_hst;
        }
        private void load_cbo_ten_hang_hoa_on_grid()
        {
            m_fg.Cols[(int)e_col_Number.MA_HANG_HOA].DataMap = get_mapping_col_muc_dich();
        }
        private bool check_validate()
        {
            if (!CValidateTextBox.IsValid(m_txt_so_phieu_thu_chi, DataType.StringType, allowNull.NO, true))
            {
                BaseMessages.MsgBox_Error("Số chứng từ không được để trống.");
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
                BaseMessages.MsgBox_Error("Bạn phải chọn học viên");
                m_txt_ten_kho.Focus();
                return false;
            }

            return true;
        }
        private bool check_so_chung_tu()
        {
            US_GD_CHUNG_TU v_gd_chung_tu = new US_GD_CHUNG_TU();
            bool v_bol_trung = false;
            try
            {
                v_gd_chung_tu.BeginTransaction();
                v_bol_trung = v_gd_chung_tu.trung_so_chung_tu(m_txt_so_phieu_thu_chi.Text.Trim());
                v_gd_chung_tu.CommitTransaction();
                if (v_bol_trung)
                {
                    BaseMessages.MsgBox_Error("Số chứng từ đã tồn tại, không thể dùng số chứng từ " + m_txt_so_phieu_thu_chi.Text);
                    m_txt_so_phieu_thu_chi.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception v_e)
            {
                v_gd_chung_tu.Rollback();
                throw v_e;
            }
        }
        private bool check_ma_nhan_vien()
        {
            US_DM_NHAN_VIEN v_nhan_vien = new US_DM_NHAN_VIEN();
            bool v_bol_trung = false;
            
            try
            {
                v_nhan_vien.BeginTransaction();
                v_bol_trung = v_nhan_vien.trung_nhan_vien(m_txt_nguoi_thu.Text.Trim(),ref  id_nhan_vien);
                v_nhan_vien.CommitTransaction();
                if (!v_bol_trung)
                {
                    BaseMessages.MsgBox_Error("Không tồn tại nhân viên có mã nhân viên " + m_txt_nguoi_thu.Text);
                    m_txt_nguoi_thu.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception v_e)
            {
                v_nhan_vien.Rollback();
                throw v_e;
            }
        }
        private bool check_value_phieu_detail()
        {
            int i = 1;
            for (i = 1; i <= m_fg.Rows.Count - 2; i++)
            {
                if (m_fg[i, (int)e_col_Number.MA_HANG_HOA] == null && m_fg[i, (int)e_col_Number.SO_TIEN] == null && m_fg[i, (int)e_col_Number.SO_LUONG] == null)
                {
                    m_fg.Rows.Remove(i);
                }
                else if (m_fg[i, (int)e_col_Number.MA_HANG_HOA] == null || m_fg[i, (int)e_col_Number.SO_LUONG] == null || m_fg[i, (int)e_col_Number.SO_TIEN] == null)
                {
                    return false;
                }
            }
            return true;
        }
        private bool check_tong_tien()
        {
            decimal v_dc_tong_tien = CIPConvert.ToDecimal(m_txt_tong_tien.Value);
            if (v_dc_tong_tien != get_tong_tien_nhap()) return false;
            return true;
        }
        private decimal get_tong_tien_nhap()
        {
            m_dc_tong_tien = 0;
            for (int i = 1; i <= m_fg.Rows.Count - 2; i++)
            {
                m_dc_tong_tien = m_dc_tong_tien + CIPConvert.ToDecimal(m_fg[i, (int)e_col_Number.SO_TIEN]) * CIPConvert.ToDecimal(m_fg[i, (int)e_col_Number.SO_LUONG]);
            }
            return m_dc_tong_tien;
        }
        private void save_data_2db()
        {
            int i = 1;
            //lay id nhan vien lap phieu nhap kho

            form_2_us_object();
            try
            {
                //1. insert ban ghi vao phieu_thu_chid
                v_us_gd_chung_tu.BeginTransaction();
                v_us_gd_chung_tu.Insert();
                v_us_gd_chung_tu.CommitTransaction();
               
                //2. insert ban ghi vao phieu_thu_chi_detail
                for (i = 1; i <= m_fg.Rows.Count - 2; i++)
                {
                    v_us_gd_chung_tu_detail.dcID_CHUNG_TU = v_us_gd_chung_tu.dcID;
                    v_us_gd_chung_tu_detail.dcID_HANG_HOA = CIPConvert.ToDecimal(m_fg[i, (int)e_col_Number.MA_HANG_HOA]);
                    v_us_gd_chung_tu_detail.dcSO_LUONG = CIPConvert.ToDecimal(m_fg[i, (int)e_col_Number.SO_LUONG]);
                    v_us_gd_chung_tu_detail.dcGIA_GIAO_DICH = CIPConvert.ToDecimal(m_fg[i, (int)e_col_Number.SO_TIEN]);
                    v_us_gd_chung_tu_detail.SetID_DON_VI_TINHNull();
                    v_us_gd_chung_tu_detail.SetSO_SERINull();
                    v_us_gd_chung_tu_detail.SetTHOI_GIAN_BHNull();
                    v_us_gd_chung_tu_detail.SetID_DVT_THOI_GIANNull();
                    try
                    {
                        //v_us_gd_chung_tu_detail.BeginTransaction();
                        v_us_gd_chung_tu_detail.Insert();
                       // v_us_gd_chung_tu_detail.CommitTransaction();

                    }
                    catch (Exception v_e)
                    {
                        v_us_gd_chung_tu_detail.Rollback();
                        throw v_e;
                    }
                    //2. insert gd chứng từ nhân viên
                    v_us_chung_tu_nv.dcID_CHUNG_TU = v_us_gd_chung_tu.dcID;
                    v_us_chung_tu_nv.dcID_NHAN_VIEN = id_nhan_vien;

                    //v_us_chung_tu_nv.BeginTransaction();
                    v_us_chung_tu_nv.Insert();
                    // v_us_chung_tu_nv.CommitTransaction();
                }
                BaseMessages.MsgBox_Infor("Đã lập phiếu nhập kho thành công.");

            }
            catch (Exception v_e)
            {
                v_us_gd_chung_tu.Rollback();
                throw v_e;
            }

        }
        private void form_2_us_object()
        {
            //GD chứng từ
            string v_str_ngay_thu_chi = CIPConvert.ToStr(m_dat_ngay_lap.Value, "dd/MM/yyyy");
            v_us_gd_chung_tu.strDIEN_GIAI = m_txt_noi_dung.Text;
            v_us_gd_chung_tu.dcID_LOAI_CT = 1;//phiếu nhập kho
            v_us_gd_chung_tu.strMA_CT = m_txt_so_phieu_thu_chi.Text;
            v_us_gd_chung_tu.datNGAY_CT = IP.Core.IPSystemAdmin.CAppContext_201.getCurentDate();
            v_us_gd_chung_tu.dcTONG_TIEN = CIPConvert.ToDecimal(m_txt_tong_tien.Text);
            v_us_gd_chung_tu.SetID_TO_CHUC_DICHNull();
            v_us_gd_chung_tu.SetID_TO_CHUC_NGUONNull();
            v_us_gd_chung_tu.SetID_NGUOI_GIAO_DICHNull();
            v_us_gd_chung_tu.SetID_NGUOI_NHAPNull();
            v_us_gd_chung_tu.SetID_NGAY_NHAPNull();
            v_us_gd_chung_tu.SetID_NGAY_NHAP_CUOINull();
            v_us_gd_chung_tu.SetGHI_CHU_1Null();
            v_us_gd_chung_tu.SetGHI_CHU_2Null();
            v_us_gd_chung_tu.SetGHI_CHU_3Null();
            //gd chứng từ chi tiết
            
        }
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_chon_kho.Click += m_cmd_chon_kho_Click;
            this.Load += f600_phieu_nhap_kho_Load;
            m_txt_tong_tien.Leave += m_txt_tong_tien_Leave;
            m_cmd_insert.Click += m_cmd_insert_Click;
		}

        void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!check_validate()) return;
                if (!check_so_chung_tu()) return;
                if (!check_ma_nhan_vien()) return;
                if (!check_value_phieu_detail())
                {
                    BaseMessages.MsgBox_Infor("Các bút toán cần được nhập đầy đủ!");
                    return;
                }
                if (!check_tong_tien())
                {
                    BaseMessages.MsgBox_Infor("Tổng số tiền không bằng nhau");
                    return;
                }
                if (BaseMessages.MsgBox_Confirm("Bạn có chắc chắn lập phiếu thu này không?") == false)
                {
                    return;
                }
                //if(m_str_loai_phieu=="PC") // Neu la phieu chi thi moi can kiem tra so du
                //    if(!check_so_du_tai_khoan()) return;
                save_data_2db();
               
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_txt_tong_tien_Leave(object sender, EventArgs e)
        {
            string v_str_tien_chu = "";
            if (m_txt_tong_tien.Text == "") return;
            try
            {
                //m_us_phieu_thu_chi.open_connection();
                //m_us_phieu_thu_chi.so_tien_bang_chu(CIPConvert.ToStr(m_txt_tong_tien.Value), ref v_str_tien_chu);
                //m_us_phieu_thu_chi.commit_close_connection();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
            m_lab_tien_bang_chu.Text = v_str_tien_chu;
        }

       
        #endregion

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
            f110_V_DM_KHO v_frm = new f110_V_DM_KHO();
            DialogResult v_dlg_result = v_frm.display_select_f250(m_us_kho);
            if (v_dlg_result == DialogResult.OK)
            {
                m_txt_ten_kho.Text = m_us_kho.strMA_KHO;
            }
        }
		

        private void m_cmd_exit_Click(object sender, EventArgs e) {
			try{
				this.Close();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}
    }
}
