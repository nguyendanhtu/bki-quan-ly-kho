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
using BKI_KHO.DS;
using IP.Core.IPData;
using BKI_KHO.DS.CDBNames;
using System.IO;
using IP.Core.IPUserService;


namespace BKI_KHO.DanhMuc
{
    public partial class f111_V_DM_KHO_DE : Form
    {
        public f111_V_DM_KHO_DE()
        {
            InitializeComponent();
            load_data_2_combox();
        }
        #region public interface
      
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void display_for_update(US_V_DM_KHO ip_m_us_dm_kho)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_object_2_form(ip_m_us_dm_kho);
            m_us_v_dm_kho = ip_m_us_dm_kho;
            this.ShowDialog();
        }

        #endregion


        #region Members
        DataEntryFormMode m_e_form_mode;
        US_V_DM_KHO m_us_v_dm_kho = new US_V_DM_KHO();
        
      
        #endregion


        #region private method
        private void form_2_us_object()
        {
            m_us_v_dm_kho.strDIA_CHI = m_txt_dia_chi.Text.Trim();
            m_us_v_dm_kho.strDIEN_THOAI = m_txt_dien_thoai.Text.Trim();
            m_us_v_dm_kho.strGHI_CHU = m_txt_ghi_chu.Text.Trim();
            m_us_v_dm_kho.strMA_KHO = m_txt_ma_kho.Text.Trim();
            m_us_v_dm_kho.strTEN_KHO = m_txt_ten_kho.Text.Trim();
            m_us_v_dm_kho.dcID_NHAN_VIEN = CIPConvert.ToDecimal(m_cbo_ten.SelectedValue);

        }

        private void us_object_2_form(US_V_DM_KHO ip_us_dm_kho)
        {
            m_txt_dia_chi.Text = ip_us_dm_kho.strDIA_CHI;
            m_txt_dien_thoai.Text = ip_us_dm_kho.strDIEN_THOAI;
            m_txt_ghi_chu.Text = ip_us_dm_kho.strGHI_CHU;
            m_txt_ma_kho.Text = ip_us_dm_kho.strMA_KHO;
            m_txt_ten_kho.Text = ip_us_dm_kho.strTEN_KHO;
            m_cbo_ten.SelectedValue = ip_us_dm_kho.dcID_NHAN_VIEN;
        }

        private void load_data_2_combox()
        {
            US_V_DM_NHAN_VIEN m_us = new US_V_DM_NHAN_VIEN();
            DS_V_DM_NHAN_VIEN m_ds = new DS_V_DM_NHAN_VIEN();
            m_us.FillDataset(m_ds);
            m_cbo_ten.DataSource = m_ds.V_DM_NHAN_VIEN;
            m_cbo_ten.ValueMember = V_DM_NHAN_VIEN.ID;
            m_cbo_ten.DisplayMember = V_DM_NHAN_VIEN.HO_TEN;
        }

        private bool is_validate_data_ok()
        {
            if (!CValidateTextBox.IsValid(
                m_txt_ma_kho
                , DataType.StringType
                , allowNull.NO
                , true)) return false;
            if (!CValidateTextBox.IsValid(
                m_txt_ten_kho
                , DataType.StringType
                , allowNull.NO
                , true)) return false;
            return true;
        }

        private void save_data()
        {
            if (!is_validate_data_ok()) return;
            form_2_us_object();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_v_dm_kho.Insert();

                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_v_dm_kho.Update();

                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }
            this.Close();
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
        private void m_cmd_refresh_Click(object sender, EventArgs e)
        {
            m_txt_dia_chi.Text = "";
            m_txt_dien_thoai.Text = "";
            m_txt_ghi_chu.Text = "";
            m_txt_ma_kho.Text = "";
            m_txt_ten_kho.Text = "";
        }
        private void m_cmd_save_Click_1(object sender, EventArgs e)
        {
            try
            {
                save_data();
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        

    }
}
