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
    public partial class f112_DM_LOAI_CHUNG_TU_DE : Form
    {
        #region public interface
        public f112_DM_LOAI_CHUNG_TU_DE()
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
            m_us = m_us_dm_loai_chung_tu;
            us_object_2_form();
            this.ShowDialog();
        }

        

        #endregion

        #region Events
        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_refresh_Click(object sender, EventArgs e)
        {
            m_txt_ghi_chu.Text = "";
            m_txt_ma_loai_chung_tu.Text = "";
            m_txt_ten_loai_chung_tu.Text = "";
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode;
        US_DM_LOAI_CHUNG_TU m_us_dm_loai_chung_tu = new US_DM_LOAI_CHUNG_TU();
        #endregion

        #region private method
        private void save_data()
        {
            if (is_validate_data_ok() == false)
                return;
            form_2_us_object();
            switch (m_e_form_mode)
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
        private void us_object_2_form()
        {
            m_txt_ten_loai_chung_tu.Text = m_us_dm_loai_chung_tu.strTEN_LOAI_CT;
            m_txt_ma_loai_chung_tu.Text = m_us_dm_loai_chung_tu.strMA_LOAI_CT;
            m_txt_ghi_chu.Text = m_us_dm_loai_chung_tu.strGHI_CHU;
        }

        private void form_2_us_object()
        {
            m_us_dm_loai_chung_tu.strGHI_CHU = m_txt_ghi_chu.Text;
            m_us_dm_loai_chung_tu.strMA_LOAI_CT = m_txt_ma_loai_chung_tu.Text;
            m_us_dm_loai_chung_tu.strTEN_LOAI_CT = m_txt_ten_loai_chung_tu.Text;
        }

        private bool is_validate_data_ok()
        {
            if (!CValidateTextBox.IsValid(
                m_txt_ma_loai_chung_tu
                , DataType.StringType
                , allowNull.NO
                , true)) return false;
            if (!CValidateTextBox.IsValid(
                m_txt_ten_loai_chung_tu
                , DataType.StringType
                , allowNull.NO
                , true)) return false;
            return true;
        }
        #endregion

        private void f112_DM_LOAI_CHUNG_TU_DE_Load(object sender, EventArgs e)
        {

        }
    }
}
