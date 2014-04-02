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
    public partial class f800_DM_NHA_CUNG_CAP_DE : Form
    {
        #region Members
        DataEntryFormMode m_e_form_mode;
        US_DM_NHA_CUNG_CAP m_us_dm_nha_cung_cap = new US_DM_NHA_CUNG_CAP();
        #endregion

        #region Public Interfaces
        public f800_DM_NHA_CUNG_CAP_DE()
        {
            InitializeComponent();
        }

        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            m_cmd_save.Text = "Thêm mới";
            this.ShowDialog();
        }

        public void display_for_update(US_DM_NHA_CUNG_CAP m_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_nha_cung_cap = m_us;
            us_obj_2_form();
            m_cmd_save.Text = "Cập nhật";
            this.ShowDialog();
        }
        #endregion

        #region Private Methods
        private void form_2_us_obj()
        {
            m_us_dm_nha_cung_cap.strMA_NHA_CUNG_CAP = m_txt_ma_nha_cung_cap.Text;
            m_us_dm_nha_cung_cap.strTEN_NHA_CUNG_CAP = m_txt_ten_nha_cung_cap.Text;
            m_us_dm_nha_cung_cap.strDIA_CHI = m_txt_dia_chi.Text;
            m_us_dm_nha_cung_cap.strTEL = m_txt_so_dien_thoai.Text;
            m_us_dm_nha_cung_cap.strFAX = m_txt_so_fax.Text;
            m_us_dm_nha_cung_cap.strEMAIL = m_txt_email.Text;
            m_us_dm_nha_cung_cap.strWEBSITE = m_txt_website.Text;
            m_us_dm_nha_cung_cap.strMA_SO_THUE = m_txt_ma_so_thue.Text;
            m_us_dm_nha_cung_cap.strNGUOI_DAI_DIEN = m_txt_nguoi_dai_dien.Text;
            m_us_dm_nha_cung_cap.strGHI_CHU = m_txt_ghi_chu.Text;

            Decimal dc;
            if (!Decimal.TryParse(m_cbo_nhom_nha_cung_cap.Text, out dc))
                throw new Exception("Lỗi Chuyển đổi dữ liệu");
            m_us_dm_nha_cung_cap.dcID_NHOM_NHA_CUNG_CAP = dc;
        }

        private void us_obj_2_form()
        {
            m_txt_ma_nha_cung_cap.Text = m_us_dm_nha_cung_cap.strMA_NHA_CUNG_CAP;
            m_txt_ten_nha_cung_cap.Text = m_us_dm_nha_cung_cap.strTEN_NHA_CUNG_CAP;
            m_txt_dia_chi.Text = m_us_dm_nha_cung_cap.strDIA_CHI;
            m_txt_so_dien_thoai.Text = m_us_dm_nha_cung_cap.strTEL;
            m_txt_so_fax.Text = m_us_dm_nha_cung_cap.strFAX;
            m_txt_email.Text = m_us_dm_nha_cung_cap.strEMAIL;
            m_txt_website.Text = m_us_dm_nha_cung_cap.strWEBSITE;
            m_txt_ma_so_thue.Text = m_us_dm_nha_cung_cap.strMA_SO_THUE;
            m_txt_nguoi_dai_dien.Text = m_us_dm_nha_cung_cap.strNGUOI_DAI_DIEN;
            m_txt_ghi_chu.Text = m_us_dm_nha_cung_cap.strGHI_CHU;

            m_cbo_nhom_nha_cung_cap.Text = m_us_dm_nha_cung_cap.dcID_NHOM_NHA_CUNG_CAP.ToString();
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
                        m_us_dm_nha_cung_cap.Insert();
                        this.Close();
                        break;
                    case DataEntryFormMode.SelectDataState:
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        m_us_dm_nha_cung_cap.Update();
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
