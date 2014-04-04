using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_KHO.US;

namespace BKI_KHO.DanhMuc
{
    public partial class f100_DM_THUE_DE : Form
    {
        #region public interface
        public f100_DM_THUE_DE()
        {
            InitializeComponent();
        }

        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void display_for_update(US.US_DM_THUE m_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_thue = m_us;
            us_obj_2_form();
            this.ShowDialog();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode;
        US_DM_THUE m_us_dm_thue = new US_DM_THUE();
        #endregion

        #region Events
        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            form_2_us_obj();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_dm_thue.Insert();
                    this.Close();
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_dm_thue.Update();
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

        #region private methods
        private void us_obj_2_form()
        {
            m_txt_ghi_chu.Text = m_us_dm_thue.strGHI_CHU;
            m_txt_ten.Text = m_us_dm_thue.strTEN;
            m_txt_ten_ngan.Text = m_us_dm_thue.strTEN_NGAN;
            m_txt_ty_le.Text = Convert.ToString(m_us_dm_thue.dcTY_LE);
        }

        private void form_2_us_obj()
        {
            m_us_dm_thue.strGHI_CHU = m_txt_ghi_chu.Text;
            m_us_dm_thue.strTEN = m_txt_ten.Text;
            m_us_dm_thue.strTEN_NGAN = m_txt_ten_ngan.Text;
            m_us_dm_thue.dcTY_LE = decimal.Parse(m_txt_ty_le.Text);
        }
        #endregion

        
    }
}
