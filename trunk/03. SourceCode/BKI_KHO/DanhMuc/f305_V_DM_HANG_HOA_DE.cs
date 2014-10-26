using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using BKI_KHO.US;
using BKI_KHO.DS;
using BKI_KHO.DS.CDBNames;
namespace BKI_KHO.DanhMuc
{
    public partial class f305_V_DM_HANG_HOA_DE : Form
    {
        public f305_V_DM_HANG_HOA_DE()
        {
            InitializeComponent();
            format_control();
            load_data_2_cbo();
        }



        #region Members
        DataEntryFormMode m_e_form_mode;
        US_V_DM_HANG_HOA m_us_v_dm_hang_hoa = new US_V_DM_HANG_HOA();
        #endregion

        #region Public Interface
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void display_for_update(US_V_DM_HANG_HOA m_us) {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_v_dm_hang_hoa = m_us;
            us_obj_2_form();
            this.ShowDialog();
        }
        #endregion

        #region Private Methods
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
        }
        private void load_data_2_cbo()
        {
            load_data_2_cboNhomHang();
            load_data_2_cboTrangThai();
            load_data_2_cboDonViTinh();
        }

        private void load_data_2_cboDonViTinh() {
            US_DM_DON_VI v_us_dm_don_vi = new US_DM_DON_VI();
            DS_DM_DON_VI v_ds_dm_don_vi = new DS_DM_DON_VI();

            v_us_dm_don_vi.FillDataset(v_ds_dm_don_vi);

            m_cbo_don_vi_tinh.DataSource = v_ds_dm_don_vi.DM_DON_VI;
            m_cbo_don_vi_tinh.ValueMember = DM_DON_VI.ID;
            m_cbo_don_vi_tinh.DisplayMember = DM_DON_VI.TEN;
        }

        private void load_data_2_cboTrangThai()
        {
            US_CM_DM_TU_DIEN v_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_cm_tu_dien = new DS_CM_DM_TU_DIEN();

            v_us_cm_dm_tu_dien.FillDatasetByIdLoaiTuDien(v_ds_cm_tu_dien
                , 15);
            m_cbo_trang_thai.DataSource = v_ds_cm_tu_dien.CM_DM_TU_DIEN;
            m_cbo_trang_thai.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_trang_thai.DisplayMember = CM_DM_TU_DIEN.TEN;
        }

        private void load_data_2_cboNhomHang()
        {
            US_DM_NHOM_HANG v_us_dm_hang_hoa = new US_DM_NHOM_HANG();
            DS_DM_NHOM_HANG v_ds_dm_hang_hoa = new DS_DM_NHOM_HANG();

            v_us_dm_hang_hoa.FillDataset(v_ds_dm_hang_hoa);
            m_cbo_nhom.ValueMember = DM_NHOM_HANG.ID;
            m_cbo_nhom.DisplayMember = DM_NHOM_HANG.TEN;

            m_cbo_nhom.DataSource = v_ds_dm_hang_hoa.DM_NHOM_HANG;
            
        }
        private void form_2_us_obj()
        {
            m_us_v_dm_hang_hoa.strMA_HANG = m_txt_ma_hang.Text.Trim();
            m_us_v_dm_hang_hoa.strTEN_HANG_VN = m_txt_ten_hang.Text.Trim();
            m_us_v_dm_hang_hoa.dcID_NHOM = CIPConvert.ToDecimal(m_cbo_nhom.SelectedValue);
            m_us_v_dm_hang_hoa.dcID_TRANG_THAI = CIPConvert.ToDecimal(m_cbo_trang_thai.SelectedValue);
            m_us_v_dm_hang_hoa.dcGIA_NHAP = CIPConvert.ToDecimal(m_txt_gia_nhap.Text.Trim());
            m_us_v_dm_hang_hoa.dcGIA_BAN = CIPConvert.ToDecimal(m_txt_gia_ban.Text.Trim());
        }
        private void us_obj_2_form()
        {
            m_txt_ma_hang.Text = m_us_v_dm_hang_hoa.strMA_HANG;
            m_txt_ten_hang.Text = m_us_v_dm_hang_hoa.strTEN_HANG_VN;
            m_cbo_nhom.SelectedValue = m_us_v_dm_hang_hoa.dcID_NHOM;
            m_cbo_trang_thai.SelectedValue = m_us_v_dm_hang_hoa.dcID_TRANG_THAI;
            m_txt_gia_nhap.Text = CIPConvert.ToStr(m_us_v_dm_hang_hoa.dcGIA_NHAP);
            m_txt_gia_ban.Text = CIPConvert.ToStr(m_us_v_dm_hang_hoa.dcGIA_BAN);
            m_cbo_don_vi_tinh.SelectedValue = m_us_v_dm_hang_hoa.dcID_DON_VI;
        }
        private bool is_validate_data_ok()
        {
            if (!CValidateTextBox.IsValid(
                m_txt_ma_hang
                , DataType.StringType
                , allowNull.NO
                , true))
                return false;
            if (!CValidateTextBox.IsValid(
                m_txt_ten_hang
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
            if (!CValidateTextBox.IsValid(
                m_txt_gia_nhap
                , DataType.StringType
                , allowNull.NO
                , true))
                return false;
            //if (!CValidateTextBox.IsValid(
            //    m_txt_gia_ban
            //    , DataType.StringType
            //    , allowNull.NO
            //    , true))
            //    return false;
            return true;
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
            BaseMessages.MsgBox_Infor("Đã cập nhật thông tin thành công!");
            this.Close();
        }
        #endregion


        #region Events
        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (System.Exception v_e)
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
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
