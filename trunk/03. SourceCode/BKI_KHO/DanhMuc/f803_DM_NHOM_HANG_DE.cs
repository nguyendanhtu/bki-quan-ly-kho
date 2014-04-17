using System.Windows.Forms;
using System;
using BKI_KHO.US;
using IP.Core.IPCommon;
using System.Data;
using System.Collections.Generic;

namespace BKI_KHO.DanhMuc
{
    public partial class f803_DM_NHOM_HANG_DE : Form
    {
        #region Members
        DataEntryFormMode m_e_form_mode;
        US_DM_NHOM_HANG m_us_dm_nhom_hang = new US_DM_NHOM_HANG();
        #endregion

        #region Public Interface
        public f803_DM_NHOM_HANG_DE()
        {
            InitializeComponent();
        }

        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            m_cmd_save.Text = "Thêm mới";
            this.ShowDialog();
        }

        public void display_for_update(US_DM_NHOM_HANG m_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_nhom_hang = m_us;
            us_obj_2_form();
            m_cmd_save.Text = "Cập nhật";
            this.ShowDialog();
        }
        #endregion

        #region Private Methods
        private void us_obj_2_form()
        {
            m_nud_cap_do.Value = m_us_dm_nhom_hang.dcLEVEL_MODE;
            m_txt_ten.Text = m_us_dm_nhom_hang.strTEN;
            m_txt_mo_ta.Text = m_us_dm_nhom_hang.strMO_TA;
            m_nud_so_thu_tu.Value = m_us_dm_nhom_hang.dcSTT;
        }

        private void form_2_us_obj()
        {
            m_us_dm_nhom_hang.dcLEVEL_MODE = m_nud_cap_do.Value;
            m_us_dm_nhom_hang.strTEN = m_txt_ten.Text;
            m_us_dm_nhom_hang.strMO_TA = m_txt_mo_ta.Text;
            m_us_dm_nhom_hang.dcSTT = m_nud_so_thu_tu.Value;
        }
        #endregion

        #region Events
        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                form_2_us_obj();
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        m_us_dm_nhom_hang.Insert();
                        this.Close();
                        break;
                    case DataEntryFormMode.SelectDataState:
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        m_us_dm_nhom_hang.Update();
                        this.Close();
                        break;
                    case DataEntryFormMode.ViewDataState:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
