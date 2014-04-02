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

namespace BKI_KHO.DanhMuc
{
    public partial class f301_DM_DON_VI_DE : Form
    {
        
        #region Public Interface
        public f301_DM_DON_VI_DE()
        {
            InitializeComponent();
        }
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        #endregion
        DataEntryFormMode m_e_form_mode;
        US_DM_DON_VI m_us_dm_don_vi = new US_DM_DON_VI();      
        #region Members
        #endregion
        #region Private Methods
        private void form_2_us_obj()
        {
            m_us_dm_don_vi.strMA = m_txt_ma_don_vi.Text;
            m_us_dm_don_vi.strTEN = m_txt_ten_don_vi.Text;
            m_us_dm_don_vi.strGHI_CHU = m_txt_ghi_chu.Text;           
        }
        private void us_obj_2_form()
        {
            m_txt_ma_don_vi.Text = m_us_dm_don_vi.strMA;
            m_txt_ten_don_vi.Text = m_us_dm_don_vi.strTEN;
            m_txt_ghi_chu.Text = m_us_dm_don_vi.strGHI_CHU;
        }
        #endregion
        #region Events
        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            form_2_us_obj();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_dm_don_vi.Insert();
                    //this.ShowDialog();
                    this.Close();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_dm_don_vi.Update();
                    this.Close();
                    break;
                default: break;
            }

        }
        #endregion

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void display_for_update(US_DM_DON_VI m_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_don_vi = m_us;
            us_obj_2_form();
            this.ShowDialog();
        }
    }
}
