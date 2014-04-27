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
using BKI_KHO.DS.CDBNames;
using IP.Core.IPSystemAdmin;

namespace BKI_KHO.DanhMuc
{
    public partial class f300_V_DM_HANG_HOA_DE : Form
    {

        #region Members
        private DataEntryFormMode m_e_form_mode;
        US_V_DM_HANG_HOA m_us_v_dm_hang_hoa = new US_V_DM_HANG_HOA();
        #endregion

        #region Public Interface
        public f300_V_DM_HANG_HOA_DE()
        {
            InitializeComponent();
            format_control();
            load_data_to_combox();
        }


        public void display_for_insert()
        {
            /*Thay đổi trạng thái sang insert*/
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }


        public void display_for_update(US_V_DM_HANG_HOA us_dm_hang_hoa)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_obj_2_form(m_us_v_dm_hang_hoa);
            this.ShowDialog();
        }
        #endregion

        #region Private Methods
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
        }
        private void load_data_to_combox()
        {
            load_data_to_combox_nhom_hang();
            load_data_to_combox_tu_dien();        
        }
        private void load_data_to_combox_nhom_hang()
        {
            US_DM_NHOM_HANG v_us = new US_DM_NHOM_HANG();
            DS_DM_NHOM_HANG v_ds = new DS_DM_NHOM_HANG();
            v_us.FillDataset(v_ds);
            m_cbo_nhom.DataSource = v_ds.DM_NHOM_HANG;
            m_cbo_nhom.ValueMember = DM_NHOM_HANG.ID;
            m_cbo_nhom.DisplayMember = DM_NHOM_HANG.TEN;
        }
        private void load_data_to_combox_tu_dien()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();

            v_us_tu_dien.FillDatasetByIdLoaiTuDien(v_ds_tu_dien, 15);
            m_cbo_trang_thai.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
            m_cbo_trang_thai.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_trang_thai.DisplayMember = CM_DM_TU_DIEN.TEN;
        }
        private void save_data()
        {
            if (!is_validate_data_ok())
                return;
            form_2_us_obj();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_v_dm_hang_hoa.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_v_dm_hang_hoa.Update();
                    break;
            }
            BaseMessages.MsgBox_Infor("Dữ liệu đã được cập nhật");
            this.Close();
        }

        private bool is_validate_data_ok()
        {
            if (!CValidateTextBox.IsValid(
                m_txt_ma_hang
                , DataType.StringType
                , allowNull.NO
                ,true))
                return false;
            if (!CValidateTextBox.IsValid(
                m_txt_ten_hang
                , DataType.StringType
                , allowNull.NO
                , true))
                return false;
            if (!CValidateTextBox.IsValid(
                m_txt_gia_nhap
                , DataType.StringType
                , allowNull.NO
                , true))
                return false;
            if (!CValidateTextBox.IsValid(
                m_txt_gia_ban
                , DataType.StringType
                , allowNull.NO
                , true))
                return false;
            return true;
        }
        private void form_2_us_obj()
        {
            m_us_v_dm_hang_hoa.strTEN_HANG_VN = m_txt_ten_hang.Text.Trim();
            m_us_v_dm_hang_hoa.strMA_HANG = m_txt_ma_hang.Text.Trim();
            m_us_v_dm_hang_hoa.dcID_NHOM = CIPConvert.ToDecimal(m_cbo_nhom.SelectedValue);          
            m_us_v_dm_hang_hoa.dcGiA_NHAP = CIPConvert.ToDecimal(m_txt_gia_nhap.Text);
            m_us_v_dm_hang_hoa.dcGIA_BAN = CIPConvert.ToDecimal(m_txt_gia_ban.Text);
            m_us_v_dm_hang_hoa.strTRANG_THAI= CIPConvert.ToStr(m_cbo_trang_thai.SelectedValue);
        }
        private void us_obj_2_form(US_V_DM_HANG_HOA ip_v_us_dm_hang_hoa)
        {
            m_us_v_dm_hang_hoa.dcID = ip_v_us_dm_hang_hoa.dcID;
            m_txt_ten_hang.Text = ip_v_us_dm_hang_hoa.strTEN_HANG_VN;
            m_txt_ma_hang.Text = ip_v_us_dm_hang_hoa.strMA_HANG;
            m_cbo_nhom.SelectedValue = ip_v_us_dm_hang_hoa.dcID_NHOM;
            //m_cbo_nha_cung_cap.SelectedValue = ip_us_dm_hang_hoa.dcID_NHA_CUNG_CAP;
            //m_txt_mo_ta.Text = ip_us_dm_hang_hoa.strMO_TA;
            m_txt_gia_nhap.Text = CIPConvert.ToStr(ip_v_us_dm_hang_hoa.dcGiA_NHAP);
            m_txt_gia_nhap.Text = CIPConvert.ToStr(ip_v_us_dm_hang_hoa.dcGIA_BAN);
            m_cbo_trang_thai.SelectedValue = ip_v_us_dm_hang_hoa.strTRANG_THAI;
        }
        #endregion

        #region Events
        //private void f300_V_DM_HANG_HOA_DE_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        load_data_to_combox(); /*Load dữ liệu từ lưới vào combobox*/
        //    }
        //    catch (System.Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}
        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        #endregion

    }
}
