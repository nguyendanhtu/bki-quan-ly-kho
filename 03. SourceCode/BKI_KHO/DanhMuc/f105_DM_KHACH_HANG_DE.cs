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
        #region public interface
        public f105_DM_KHACH_HANG_DE()
        {
            InitializeComponent();
        }

        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void display_for_update(US.US_DM_KHACH_HANG m_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_khach_hang = m_us;
            this.ShowDialog();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode;
        US_DM_KHACH_HANG m_us_dm_khach_hang = new US_DM_KHACH_HANG();
        #endregion

        #region Events
        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            form_2_us_obj();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_dm_khach_hang.Insert();
                    this.Close();
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_dm_khach_hang.Update();
                    this.Close();
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }
        }

        private void m_cmd_refresh_Click(object sender, EventArgs e)
        {
            m_dat_ngay_sinh.Value = m_us_dm_khach_hang.datNGAY_SINH;
            m_dat_ngay_tham_gia.Value = m_us_dm_khach_hang.datNGAY_THAM_GIA;
            m_dat_ngay_tham_gia_gan_nhat.Value = m_us_dm_khach_hang.datNGAY_THAM_GIA_GAN_NHAT;
            m_dat_thoi_gia_gan_nhat.Value = m_us_dm_khach_hang.datTHOI_GIAN_GAN_NHAT;
            m_dat_time_stamp.Value = m_us_dm_khach_hang.datTIMESTAMP;
            m_txt_creditlimit.Text = "";
            m_txt_ma_kho.Text = "";
            m_txt_ma_kieu_khach_hang.Text = "";
            m_txt_ma_kieu_mua_hang.Text = "";
            m_txt_ma_kieu_thanh_toan.Text = "";
            m_txt_ma_nhan_vien.Text = "";
            m_txt_ma_ship.Text = "";
            m_txt_ma_tien_te.Text = "";
            m_txt_di_dong.Text = "";
            m_txt_dia_chi.Text = "";
            m_txt_dien_thoai.Text = "";
            m_txt_dien_thoai_1.Text = "";
            m_txt_dien_thoai_2.Text = "";
            m_txt_email.Text = "";
            m_txt_fax.Text = "";
            m_txt_ghi_chu.Text = "";
            m_txt_ma_nguoi_dung.Text = "";
            m_txt_ma_user.Text = "";
            m_txt_ma_buu_dien.Text = "";
            m_txt_ma_khach_hang.Text = "";
            m_txt_ma_so_thue.Text = "";
            m_txt_ten_cong_ty.Text = "";
            m_txt_ten_khach_hang.Text = "";
            m_txt_thanh_pho.Text = "";
            m_txt_trang_thai.Text = "";
            m_txt_website.Text = "";
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region private method
        private void form_2_us_obj()
        {
            m_us_dm_khach_hang.datNGAY_SINH = m_dat_ngay_sinh.Value;
            m_us_dm_khach_hang.datNGAY_THAM_GIA = m_dat_ngay_tham_gia.Value;
            m_us_dm_khach_hang.datNGAY_THAM_GIA_GAN_NHAT = m_dat_ngay_tham_gia_gan_nhat.Value;
            m_us_dm_khach_hang.datTHOI_GIAN_GAN_NHAT = m_dat_thoi_gia_gan_nhat.Value;
            m_us_dm_khach_hang.datTIMESTAMP = m_dat_time_stamp.Value;
            m_us_dm_khach_hang.dcCreditLimit = Int32.Parse(m_txt_creditlimit.Text);
            m_us_dm_khach_hang.dcID_KHO = Int32.Parse(m_txt_ma_kho.Text);
            m_us_dm_khach_hang.dcID_KIEU_KHACH_HANG = Int32.Parse(m_txt_ma_kieu_khach_hang.Text);
            m_us_dm_khach_hang.dcID_KIEU_MUA_HANG = Int32.Parse(m_txt_ma_kieu_mua_hang.Text);
            m_us_dm_khach_hang.dcID_KIEU_THANH_TOAN = Int32.Parse(m_txt_ma_kieu_thanh_toan.Text);
            m_us_dm_khach_hang.dcID_NHAN_VIEN = Int32.Parse(m_txt_ma_nhan_vien.Text);
            m_us_dm_khach_hang.dcID_SHIP = Int32.Parse(m_txt_ma_ship.Text);
            m_us_dm_khach_hang.dcID_TIEN_TE = Int32.Parse(m_txt_ma_tien_te.Text);
            m_us_dm_khach_hang.strDI_DONG = m_txt_di_dong.Text;
            m_us_dm_khach_hang.strDIA_CHI = m_txt_dia_chi.Text;
            m_us_dm_khach_hang.strDIEN_THOAI = m_txt_dien_thoai.Text;
            m_us_dm_khach_hang.strDIEN_THOAI_1 = m_txt_dien_thoai_1.Text;
            m_us_dm_khach_hang.strDIEN_THOAI_2 = m_txt_dien_thoai_2.Text;
            m_us_dm_khach_hang.strEMAIL = m_txt_email.Text;
            m_us_dm_khach_hang.strFAX = m_txt_fax.Text;
            m_us_dm_khach_hang.strGHI_CHU = m_txt_ghi_chu.Text;
            m_us_dm_khach_hang.strID_NGUOI_DUNG_MOI_NHAT = m_txt_ma_nguoi_dung.Text;
            m_us_dm_khach_hang.strID_USER = m_txt_ma_user.Text;
            m_us_dm_khach_hang.strMA_BUU_DIEN = m_txt_ma_buu_dien.Text;
            m_us_dm_khach_hang.strMA_KHACH_HANG = m_txt_ma_khach_hang.Text;
            m_us_dm_khach_hang.strMA_SO_THUE = m_txt_ma_so_thue.Text;
            m_us_dm_khach_hang.strTEN_CONG_TY = m_txt_ten_cong_ty.Text;
            m_us_dm_khach_hang.strTEN_KHACH_HANG = m_txt_ten_khach_hang.Text;
            m_us_dm_khach_hang.strTHANH_PHO = m_txt_thanh_pho.Text;
            m_us_dm_khach_hang.strTRANG_THAI = m_txt_trang_thai.Text;
            m_us_dm_khach_hang.strWEBSITE = m_txt_website.Text;
        }

        private void us_obj_2_form()
        {
            m_dat_ngay_sinh.Value=m_us_dm_khach_hang.datNGAY_SINH;
            m_dat_ngay_tham_gia.Value=m_us_dm_khach_hang.datNGAY_THAM_GIA;
            m_dat_ngay_tham_gia_gan_nhat.Value=m_us_dm_khach_hang.datNGAY_THAM_GIA_GAN_NHAT;
            m_dat_thoi_gia_gan_nhat.Value=m_us_dm_khach_hang.datTHOI_GIAN_GAN_NHAT;
            m_dat_time_stamp.Value=m_us_dm_khach_hang.datTIMESTAMP;
            m_txt_creditlimit.Text=Convert.ToString(m_us_dm_khach_hang.dcCreditLimit);
            m_txt_ma_kho.Text = Convert.ToString(m_us_dm_khach_hang.dcID_KHO);
            m_txt_ma_kieu_khach_hang.Text=Convert.ToString(m_us_dm_khach_hang.dcID_KIEU_KHACH_HANG);
            m_txt_ma_kieu_mua_hang.Text=Convert.ToString(m_us_dm_khach_hang.dcID_KIEU_MUA_HANG);
            m_txt_ma_kieu_thanh_toan.Text=Convert.ToString(m_us_dm_khach_hang.dcID_KIEU_THANH_TOAN);
            m_txt_ma_nhan_vien.Text=Convert.ToString(m_us_dm_khach_hang.dcID_NHAN_VIEN);
            m_txt_ma_ship.Text=Convert.ToString(m_us_dm_khach_hang.dcID_SHIP);
            m_txt_ma_tien_te.Text=Convert.ToString(m_us_dm_khach_hang.dcID_TIEN_TE);
            m_txt_di_dong.Text=m_us_dm_khach_hang.strDI_DONG;
             m_txt_dia_chi.Text=m_us_dm_khach_hang.strDIA_CHI;
            m_txt_dien_thoai.Text=m_us_dm_khach_hang.strDIEN_THOAI;
            m_txt_dien_thoai_1.Text=m_us_dm_khach_hang.strDIEN_THOAI_1;
            m_txt_dien_thoai_2.Text=m_us_dm_khach_hang.strDIEN_THOAI_2;
            m_txt_email.Text=m_us_dm_khach_hang.strEMAIL;
            m_txt_fax.Text=m_us_dm_khach_hang.strFAX;
            m_txt_ghi_chu.Text=m_us_dm_khach_hang.strGHI_CHU;
            m_txt_ma_nguoi_dung.Text=m_us_dm_khach_hang.strID_NGUOI_DUNG_MOI_NHAT;
            m_txt_ma_user.Text = m_us_dm_khach_hang.strID_USER;
            m_txt_ma_buu_dien.Text=m_us_dm_khach_hang.strMA_BUU_DIEN;
             m_txt_ma_khach_hang.Text=m_us_dm_khach_hang.strMA_KHACH_HANG;
            m_txt_ma_so_thue.Text=m_us_dm_khach_hang.strMA_SO_THUE;
            m_txt_ten_cong_ty.Text=m_us_dm_khach_hang.strTEN_CONG_TY;
            m_txt_ten_khach_hang.Text=m_us_dm_khach_hang.strTEN_KHACH_HANG;
            m_txt_thanh_pho.Text=m_us_dm_khach_hang.strTHANH_PHO;
            m_txt_trang_thai.Text=m_us_dm_khach_hang.strTRANG_THAI;
            m_txt_website.Text=m_us_dm_khach_hang.strWEBSITE;
        }
        #endregion

        
    }
}
