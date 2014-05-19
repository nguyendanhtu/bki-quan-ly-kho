using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_KHO.US;
using IP.Core.IPCommon;

namespace BKI_KHO.BaoCao
{
    public partial class f108_V_TRA_CUU_BAO_HANH_DE : Form
    {
        public f108_V_TRA_CUU_BAO_HANH_DE()
        {
            InitializeComponent();
        }

        #region Members
        //DataEntryFormMode m_e_form_mode;
        US_V_TRA_CUU_BAO_HANH m_us_v_tra_cuu_bao_hanh = new US_V_TRA_CUU_BAO_HANH();
        #endregion

        private void grid_2_form(US_V_TRA_CUU_BAO_HANH m_us_tra_cuu_bao_hanh)
        {
            m_txt_ma_hang.Text = m_us_tra_cuu_bao_hanh.strMA_HANG;
            m_txt_so_phieu.Text = Convert.ToString(m_us_tra_cuu_bao_hanh.dcID_HANG_HOA);
            m_txt_thoi_gian_bao_hanh.Text = Convert.ToString(m_us_tra_cuu_bao_hanh.dcTHOI_GIAN_BH);
            m_dat_ngay_ban.Value = m_us_tra_cuu_bao_hanh.datNGAY_CT;
        }
        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void display(US_V_TRA_CUU_BAO_HANH m_us)
        {
            grid_2_form(m_us);
            m_us_v_tra_cuu_bao_hanh = m_us;
            this.ShowDialog();
        }

        private void m_cmd_exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
