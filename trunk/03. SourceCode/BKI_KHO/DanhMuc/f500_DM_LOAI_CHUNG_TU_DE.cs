using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_KHO.US;
using BKI_KHO.DS;
using IP.Core.IPCommon;

namespace BKI_KHO.DanhMuc
{
    public partial class f500_DM_LOAI_CHUNG_TU_DE : Form
    {
        #region public interface
        public f500_DM_LOAI_CHUNG_TU_DE()
        {
            InitializeComponent();
        }

        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void display_for_update(US.US_DM_LOAI_CHUNG_TU m_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_loai_chung_tu = m_us;
            us_obj_2_form();
            this.ShowDialog();
        }

        
        #endregion
        #region private method
        private void us_obj_2_form()
        {
            m_txt_ghi_chu.Text = m_us_dm_loai_chung_tu.strGHI_CHU;
            m_txt_ma_loai_chung_tu.Text = m_us_dm_loai_chung_tu.strMA_LOAI_CT;
            m_txt_ten_loai_chung_tu.Text = m_us_dm_loai_chung_tu.strTEN_LOAI_CT;
        }
        private void form_2_us_obj()
        {
            m_us_dm_loai_chung_tu.strGHI_CHU = m_txt_ghi_chu.Text;
            m_us_dm_loai_chung_tu.strMA_LOAI_CT = m_txt_ma_loai_chung_tu.Text;
            m_us_dm_loai_chung_tu.strTEN_LOAI_CT = m_txt_ten_loai_chung_tu.Text;
        }
        #endregion
        #region Members
        DataEntryFormMode m_e_form_mode;
        US_DM_LOAI_CHUNG_TU m_us_dm_loai_chung_tu = new US_DM_LOAI_CHUNG_TU();
        #endregion
        #region Events
        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            form_2_us_obj();
            switch(m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_dm_loai_chung_tu.Insert();
                    this.Close();
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_dm_loai_chung_tu.Update();
                    this.Close();
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }
        }

        private void m_cmd_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
