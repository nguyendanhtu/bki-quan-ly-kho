using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;

using BKI_KHO.US;
using BKI_KHO.DS;
using BKI_KHO.DS.CDBNames;

using C1.Win.C1FlexGrid;

namespace BKI_KHO.BaoCao
{
    public partial class f107_V_PHIEU_BAO_HANH : Form
    {
        public f107_V_PHIEU_BAO_HANH()
        {
            InitializeComponent();
        }
        void m_fg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                danh_sach_chung_tu_theo_nhan_vien();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void danh_sach_chung_tu_theo_nhan_vien()
        {
            f107_V_PHIEU_BAO_HANH frm = new f107_V_PHIEU_BAO_HANH();
            frm.ShowDialog();
        }

        #region Members
        DataEntryFormMode m_e_form_mode;
        US_V_BAO_CAO_BAO_HANH m_us_v_bao_cao_bao_hanh = new US_V_BAO_CAO_BAO_HANH();
        US_DM_KHACH_HANG m_us_dm_khach_hang = new US_DM_KHACH_HANG();
        #endregion


        #region private method
        private void us_obj_2_form()
        {
            m_lbl_ma_san_pham.Text = m_us_v_bao_cao_bao_hanh.strMA_HANG;
            m_lbl_ten_san_pham.Text = m_us_v_bao_cao_bao_hanh.strTEN_HANG_VN;
            //m_lbl_ngay_mua.Text = Convert.ToString(m_us_v_bao_cao_bao_hanh.datNGAY_CT);
        }
        #endregion

        #region public interface
        
    
        public void display_infor(US_V_BAO_CAO_BAO_HANH m_us)
        {

            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_v_bao_cao_bao_hanh = m_us;
            us_obj_2_form();
            this.ShowDialog();
        }
        #endregion  
    }
}
