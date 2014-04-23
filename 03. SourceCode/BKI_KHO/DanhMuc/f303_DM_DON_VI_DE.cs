using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_KHO.DS;
using BKI_KHO.US;
using IP.Core.IPCommon;

namespace BKI_KHO.DanhMuc
{
    public partial class f303_DM_DON_VI_DE : Form
    {
        #region Members
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        US_DM_DON_VI m_us = new US_DM_DON_VI();
        DS_DM_DON_VI m_ds = new DS_DM_DON_VI();
        #endregion

        #region Public Interface
        public f303_DM_DON_VI_DE()
        {
            InitializeComponent();
        }

        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        #endregion

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                form_2_us_obj();
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        m_us.Insert();
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        m_us.Update();
                        break;
                }
                BaseMessages.MsgBox_Infor("Dữ liệu đã được cập nhật");
                this.Close();
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void form_2_us_obj()
        {
            m_us.strMA = m_txt_ma_don_vi.Text;
            m_us.strTEN = m_txt_ma_don_vi.Text;
            m_us.strGHI_CHU = m_txt_ghi_chu.Text;
        }
        private void us_obj_2_form(US_DM_DON_VI ip_us)
        {
            m_us.dcID = ip_us.dcID;
            m_txt_ma_don_vi.Text = ip_us.strMA;
            m_txt_ten_don_vi.Text = ip_us.strTEN;
            m_txt_ghi_chu.Text = ip_us.strGHI_CHU;
        }

        private void m_cmd_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                m_txt_ma_don_vi.Text = null;
                m_txt_ghi_chu.Text = null;
                m_txt_ten_don_vi.Text = null;
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Private Methods
        #endregion

        #region Events
        #endregion


        public void display_for_update(US_DM_DON_VI m_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_obj_2_form(m_us);
            this.ShowDialog();          
        }
    }
}
