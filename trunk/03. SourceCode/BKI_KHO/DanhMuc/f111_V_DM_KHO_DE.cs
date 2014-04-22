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

        #region public interface
        public f111_V_DM_KHO_DE()
        {
            InitializeComponent();
        }

        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void display_for_update(US_V_DM_KHO ip_m_us_v_dm_kho)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_object_2_form(ip_m_us_v_dm_kho);
            m_v_us = ip_m_us_v_dm_kho;
            this.ShowDialog();
        }

        #endregion

        #region private method
        private void form_2_us_object()
        {
            m_us.strDIA_CHI = m_txt_dia_chi.Text.Trim();
            m_us.strDIEN_THOAI = m_txt_dien_thoai.Text.Trim();
            m_us.strGHI_CHU = m_txt_ghi_chu.Text.Trim();
            m_us.strMA_KHO = m_txt_ma_kho.Text.Trim();
            m_us.strTEN_KHO = m_txt_ten_kho.Text.Trim();
            m_v_us.strHO_DEM = m_txt_ho_dem.Text.Trim();
            m_v_us.strTEN = m_txt_ten.Text.Trim();
        }

        private void us_object_2_form(US_V_DM_KHO ip_us_v_dm_kho)
        {
            m_txt_dia_chi.Text = ip_us_v_dm_kho.strDIA_CHI;
            m_txt_dien_thoai.Text = ip_us_v_dm_kho.strDIEN_THOAI;
            m_txt_ghi_chu.Text = ip_us_v_dm_kho.strGHI_CHU;
            m_txt_ma_kho.Text = ip_us_v_dm_kho.strMA_KHO;
            m_txt_ten_kho.Text = ip_us_v_dm_kho.strTEN_KHO;
            m_txt_ten.Text = m_v_us.strTEN;
            m_txt_ho_dem.Text = m_v_us.strHO_DEM;
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode;
        US_DM_KHO m_us_1 = new US_DM_KHO();
        US_V_DM_KHO m_v_us = new US_V_DM_KHO();
        DS_V_DM_KHO m_v_ds = new DS_V_DM_KHO();
        US_DM_KHO m_us = new US_DM_KHO();
        DS_DM_KHO m_ds = new DS_DM_KHO();
        #endregion

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            form_2_us_object();
            switch(m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us.Insert();
                    this.Close();
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us.Update();
                    this.Close();
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Events
        #endregion
    }
}
