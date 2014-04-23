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
    public partial class f304_DM_NHA_SX_DE : Form
    {
        #region Members
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        DS_DM_NHA_SX m_ds = new DS_DM_NHA_SX();
        US_DM_NHA_SX m_us = new US_DM_NHA_SX();
        #endregion

        #region Public Interface
        public f304_DM_NHA_SX_DE()
        {
            InitializeComponent();
        }


        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        #endregion

        #region  Private Methods
        private void form_2_us_obj()
        {
            m_us.strMA_NSX = m_txt_ma_nha_sx.Text;
            m_us.strTEN_NSX = m_txt_ten_nha_sx.Text;
            m_us.strNGUOI_DAI_DIEN = m_txt_nguoi_dai_dien.Text;
            m_us.strMOBILE = m_txt_dien_thoai.Text;
            m_us.strWEBSITE = m_txt_email.Text;
            m_us.strFAX = m_txt_fax.Text;
            m_us.strGHI_CHU = m_txt_ghi_chu.Text;
            m_us.strEMAIL = m_txt_email.Text;
            m_us.strDIA_CHI = m_txt_dia_chi.Text;
        }
        private void us_obj_2_form(US_DM_NHA_SX ip_us)
        {
            m_us.dcID = ip_us.dcID;
            m_txt_ma_nha_sx.Text = ip_us.strMA_NSX;
            m_txt_ten_nha_sx.Text = ip_us.strTEN_NSX;
            m_txt_nguoi_dai_dien.Text = ip_us.strNGUOI_DAI_DIEN;
            m_txt_dien_thoai.Text = ip_us.strMOBILE;
            m_txt_email.Text = ip_us.strEMAIL;
            m_txt_fax.Text = ip_us.strFAX;
            m_txt_ghi_chu.Text = ip_us.strGHI_CHU;
            m_txt_email.Text = ip_us.strEMAIL;
            m_txt_dia_chi.Text = ip_us.strDIA_CHI;
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

        #endregion


        public void display_for_update(US_DM_NHA_SX m_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_obj_2_form(m_us);
            this.ShowDialog();
        }
    }
}
