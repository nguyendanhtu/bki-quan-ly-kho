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
    public partial class f105_DM_KHACH_HANG_DE : Form
    {
        public f105_DM_KHACH_HANG_DE()
        {
            InitializeComponent();
        }

        #region public interface
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void display_for_update(US.US_DM_KHACH_HANG m_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_khach_hang=m_us;
            us_obj_2_form();
            this.ShowDialog();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode;
        US_DM_KHACH_HANG m_us_dm_khach_hang = new US_DM_KHACH_HANG();
        #endregion

        #region private method
        private void form_2_us_obj()
        {
            m_us_dm_khach_hang.datNGAY_SINH = m_dat_ngay_sinh.Value;
            m_us_dm_khach_hang.datNGAY_THAM_GIA = m_dat_ngay_tham_gia.Value;
            m_us_dm_khach_hang.datNGAY_THAM_GIA_GAN_NHAT = m_dat_ngay_tham_gia_gan_nhat.Value;
            m_us_dm_khach_hang.strDI_DONG = m_txt_di_dong.Text;
            m_us_dm_khach_hang.strDIA_CHI = m_txt_dia_chi.Text;
            m_us_dm_khach_hang.strDIEN_THOAI = m_txt_dien_thoai.Text;
            m_us_dm_khach_hang.strEMAIL = m_txt_email.Text;
            m_us_dm_khach_hang.strFAX = m_txt_fax.Text;
            m_us_dm_khach_hang.strGHI_CHU = m_txt_ghi_chu.Text;
            m_us_dm_khach_hang.strMA_SO_THUE = m_txt_ma_so_thue.Text;
            m_us_dm_khach_hang.strTHANH_PHO = m_txt_thanh_pho.Text;
            m_us_dm_khach_hang.strTRANG_THAI = m_txt_trang_thai.Text;
            m_us_dm_khach_hang.strWEBSITE = m_txt_website.Text;
            m_us_dm_khach_hang.strTEN_CONG_TY = m_txt_ten_cong_ty.Text;
            m_us_dm_khach_hang.strTEN_KHACH_HANG = m_txt_ten_khach_hang.Text;
            m_us_dm_khach_hang.strMA_BUU_DIEN = m_txt_ma_buu_dien.Text;
            m_us_dm_khach_hang.strMA_KHACH_HANG = m_txt_ma_khach_hang.Text;
        }

        private void us_obj_2_form()
        {
            m_dat_ngay_sinh.Value = m_us_dm_khach_hang.datNGAY_SINH;
            m_dat_ngay_tham_gia.Value = m_us_dm_khach_hang.datNGAY_THAM_GIA;
            m_dat_ngay_tham_gia_gan_nhat.Value = m_us_dm_khach_hang.datNGAY_THAM_GIA_GAN_NHAT;
            m_txt_di_dong.Text = m_us_dm_khach_hang.strDI_DONG;
            m_txt_dia_chi.Text = m_us_dm_khach_hang.strDIA_CHI;
            m_txt_dien_thoai.Text = m_us_dm_khach_hang.strDIEN_THOAI;
            m_txt_email.Text = m_us_dm_khach_hang.strEMAIL;
            m_txt_fax.Text = m_us_dm_khach_hang.strFAX;
            m_txt_ghi_chu.Text = m_us_dm_khach_hang.strGHI_CHU;
            m_txt_ma_so_thue.Text = m_us_dm_khach_hang.strMA_SO_THUE;
            m_txt_thanh_pho.Text = m_us_dm_khach_hang.strTHANH_PHO;
            m_txt_trang_thai.Text = m_us_dm_khach_hang.strTRANG_THAI;
            m_txt_website.Text = m_us_dm_khach_hang.strWEBSITE;
            m_txt_ten_cong_ty.Text = m_us_dm_khach_hang.strTEN_CONG_TY;
            m_txt_ten_khach_hang.Text = m_us_dm_khach_hang.strTEN_KHACH_HANG;
            m_txt_ma_buu_dien.Text = m_us_dm_khach_hang.strMA_BUU_DIEN;
            m_txt_ma_khach_hang.Text = m_us_dm_khach_hang.strMA_KHACH_HANG;
        }

        private void save_data()
        {
            if (is_validate_data_ok() == false)
                return;
            form_2_us_obj();
            switch(m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_dm_khach_hang.Insert();

                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_dm_khach_hang.Update();

                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }
            this.Close();
        }

        private bool is_validate_data_ok()
        {
            if (!CValidateTextBox.IsValid(
                m_txt_ma_khach_hang
                , DataType.StringType
                , allowNull.NO
                , true)) return false;
            if (!CValidateTextBox.IsValid(
                m_txt_ten_khach_hang
                , DataType.StringType
                , allowNull.NO
                , true)) return false;
            return true;
        }
        #endregion

        #region Event
        private void f105_DM_KHACH_HANG_DE_Load(object sender, EventArgs e)
        {

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


    }
}
