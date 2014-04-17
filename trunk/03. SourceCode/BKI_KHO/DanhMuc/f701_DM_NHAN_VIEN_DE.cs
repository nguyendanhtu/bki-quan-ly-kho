using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_KHO.DS;
using BKI_KHO.US;

namespace BKI_KHO.DanhMuc
{
    public partial class f701_DM_NHAN_VIEN_DE : Form
    {
        public f701_DM_NHAN_VIEN_DE()
        {
            InitializeComponent();
        }

        #region Members
        private DataEntryFormMode m_e_form_mode;
        US_DM_NHAN_VIEN m_us = new US_DM_NHAN_VIEN();
        DS_DM_NHAN_VIEN m_ds = new DS_DM_NHAN_VIEN();
        private decimal m_str_ma_nhan_vien_old = 0;
        #endregion

        #region Public Methods
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void display_for_update(US_DM_NHAN_VIEN ip_m_us_dm_nhan_vien)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_object_2_form(ip_m_us_dm_nhan_vien);
            m_str_ma_nhan_vien_old = ip_m_us_dm_nhan_vien.dcID;
            this.ShowDialog();
        }

        private void us_object_2_form(US_DM_NHAN_VIEN ip_us_dm_nhan_vien)
        {
            m_us.dcID = ip_us_dm_nhan_vien.dcID;
            m_txt_ma_nhan_vien.Text = ip_us_dm_nhan_vien.strMA_NHAN_VIEN;
            m_txt_ho_dem.Text = ip_us_dm_nhan_vien.strHO_DEM;
            m_txt_ten.Text = ip_us_dm_nhan_vien.strTEN;
            m_txt_so_dien_thoai.Text = ip_us_dm_nhan_vien.strSO_DIEN_THOAI;
            m_txt_cmnd.Text = ip_us_dm_nhan_vien.strCMND;
            m_txt_dia_chi.Text = ip_us_dm_nhan_vien.strDIA_CHI;
            m_txt_email.Text = ip_us_dm_nhan_vien.strEMAIL;
        }

        #endregion

        #region Private Methods
        private void xoa_trang()
        {

        }

        private void save_data()
        {
            if (check_data_is_ok() == false)
                return;
            form_2_us_object();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    if (ma_nhan_vien_ton_tai(m_txt_ma_nhan_vien.Text))
                    {
                        BaseMessages.MsgBox_Error("Mã nhân viên đã tồn tại.");
                        m_txt_ma_nhan_vien.Focus();
                        return;
                    }
                    m_us.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    US_DM_NHAN_VIEN v_us = new US_DM_NHAN_VIEN(m_str_ma_nhan_vien_old);
                    if (!m_txt_ma_nhan_vien.Text.Equals(v_us.strMA_NHAN_VIEN))
                    {
                        if (ma_nhan_vien_ton_tai(m_txt_ma_nhan_vien.Text))
                        {
                            BaseMessages.MsgBox_Error("Mã nhân viên đã tồn tại.");
                            m_txt_ma_nhan_vien.Focus();
                            return;
                        }
                    }
                    m_us.Update();
                    break;
            }
            BaseMessages.MsgBox_Infor("Dữ liệu đã được cập nhật");
            this.Close();
        }

        private bool ma_nhan_vien_ton_tai(string ip_str_ma_nhan_vien)
        {
            DS_DM_NHAN_VIEN v_ds = new DS_DM_NHAN_VIEN();
            m_us.FillDatasetSearchByMaNhanVien(v_ds, ip_str_ma_nhan_vien);
            if (v_ds.DM_NHAN_VIEN.Count > 0)
                return true;
            return false;
        }

        private void form_2_us_object()
        {
            m_us.strMA_NHAN_VIEN = m_txt_ma_nhan_vien.Text;
            m_us.strHO_DEM = m_txt_ho_dem.Text;
            m_us.strTEN = m_txt_ten.Text;
            m_us.strSO_DIEN_THOAI = m_txt_so_dien_thoai.Text;
            m_us.strCMND = m_txt_cmnd.Text;
            m_us.strEMAIL = m_txt_email.Text;
            m_us.strDIA_CHI = m_txt_dia_chi.Text;
        }

        private bool check_data_is_ok()
        {
            return true;
        }

        #endregion

        #region Event
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
            try
            {
                xoa_trang();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

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
        #endregion
    }
}
