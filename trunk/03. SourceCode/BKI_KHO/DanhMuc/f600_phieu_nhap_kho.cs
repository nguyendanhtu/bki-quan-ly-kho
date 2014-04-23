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
namespace BKI_KHO.DanhMuc
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
           LOAI_HANG_HOA=1
            ,SO_LUONG=2
            ,SO_TIEN=3
        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;

        DS_DM_KHO m_ds_kho=new DS_DM_KHO ();
        US_DM_KHO m_us_kho=new US_DM_KHO ();
        

        #endregion

        private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201());
			CControlFormat.setC1FlexFormat(m_fg);
			CGridUtils.AddSave_Excel_Handlers(m_fg);
            			CGridUtils.AddSearch_Handlers(m_fg);

			set_define_events();
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
			load_data_2_grid();
            //String.Format("{0:0,0 VNĐ}", m_ds.Tables[0].Columns["GIA_NHAP"].ToString()).Replace(",", ".");
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(PHIEU_NHAP_KHO_DETAIL.LOAI_HANG_HOA, e_col_Number.LOAI_HANG_HOA);
			v_htb.Add(PHIEU_NHAP_KHO_DETAIL.SO_LUONG, e_col_Number.SO_LUONG);
			v_htb.Add(PHIEU_NHAP_KHO_DETAIL.SO_TIEN, e_col_Number.SO_TIEN);
			
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds_kho.DM_KHO.NewDM_KHORow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			
            
			m_fg.Redraw = false;
			//CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
			m_fg.Redraw = true;
            
		}
		


		
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			
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
