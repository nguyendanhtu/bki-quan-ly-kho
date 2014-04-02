using BKI_KHO.US;
using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_KHO.DanhMuc
{
    public partial class f802_DM_TIEN_TE_DE : Form
    {
        #region Members
        DataEntryFormMode m_e_form_mode;
        US_DM_TIEN_TE m_us_dm_tien_te = new US_DM_TIEN_TE();
        #endregion

        #region Public Interfaces
        public f802_DM_TIEN_TE_DE()
        {
            InitializeComponent();
        }

        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            m_cmd_save.Text = "Thêm mới";
            this.ShowDialog();
        }

        public void display_for_update(US_DM_TIEN_TE m_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_tien_te = m_us;
            us_obj_2_form();
            m_cmd_save.Text = "Cập nhật";
            this.ShowDialog();
        }
        #endregion

        #region Private Methods
        private void form_2_us_obj()
        {
            m_us_dm_tien_te.strMA_TIEN_TE = m_txt_ma_tien_te.Text;
            m_us_dm_tien_te.strTEN_TIEN_TE = m_txt_ten_tien_te.Text;
            m_us_dm_tien_te.strDANG_CHU = m_txt_dang_chu.Text;
            m_us_dm_tien_te.strDOI_TEN = m_txt_doi_ten.Text;
            m_us_dm_tien_te.strKY_HIEU = m_txt_ky_hieu.Text;
            m_us_dm_tien_te.dcDANG_THAP_PHAN = m_numud_dang_thap_phan.Value;
            m_us_dm_tien_te.strGHI_CHU = m_txt_ghi_chu.Text;
        }

        private void us_obj_2_form()
        {
            m_txt_ma_tien_te.Text = m_us_dm_tien_te.strMA_TIEN_TE;
            m_txt_ten_tien_te.Text = m_us_dm_tien_te.strTEN_TIEN_TE;
            m_txt_dang_chu.Text = m_us_dm_tien_te.strDANG_CHU;
            m_txt_doi_ten.Text = m_us_dm_tien_te.strDOI_TEN;
            m_txt_ky_hieu.Text = m_us_dm_tien_te.strKY_HIEU;
            m_numud_dang_thap_phan.Value = m_us_dm_tien_te.dcDANG_THAP_PHAN;
            m_txt_ghi_chu.Text = m_us_dm_tien_te.strGHI_CHU;
        }
        #endregion

        #region Events
        private void m_cmd_save_click(object sender, EventArgs e)
        {
            try
            {
                form_2_us_obj();
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        m_us_dm_tien_te.Insert();
                        this.Close();
                        break;
                    case DataEntryFormMode.SelectDataState:
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        m_us_dm_tien_te.Update();
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
