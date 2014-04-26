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
        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;

        DS_V_DM_KHO m_ds_kho = new DS_V_DM_KHO();
        US_V_DM_KHO m_us_kho = new US_V_DM_KHO();

        DS_V_GD_CHUNG_TU v_ds_chung_tu = new DS_V_GD_CHUNG_TU();
        US_V_GD_CHUNG_TU v_us_chung_tu = new US_V_GD_CHUNG_TU();

        
        #endregion

        #region Methods
        private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201());
			CControlFormat.setC1FlexFormat(m_fg);
			CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
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
                v_hst.Add(v_dr[DM_HANG_HOA.ID], v_dr[DM_HANG_HOA.MA_HANG]);
            }
            return v_hst;
        }
        private void load_cbo_ten_hang_hoa_on_grid()
        {
            m_fg.Cols[(int)e_col_Number.MA_HANG_HOA].DataMap = get_mapping_col_muc_dich();
        }
        

		
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_chon_kho.Click += m_cmd_chon_kho_Click;
            this.Load += f600_phieu_nhap_kho_Load;
            m_txt_tong_tien.Leave += m_txt_tong_tien_Leave;
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
