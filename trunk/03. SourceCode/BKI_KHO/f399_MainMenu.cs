using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_KHO;
//using DevComponents.DotNetBar;

namespace Form_menu
{
    public partial class f399_MainMenu : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public f399_MainMenu()
        {
            InitializeComponent();
            format_controls();
        }
        #region Public Interface
        public void display(ref IP.Core.IPCommon.IPConstants.HowUserWantTo_Exit_MainForm v_exitmode)
        {
            try
            {
                this.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }

        }
        #endregion
        #region Private Method

        private void format_controls()
        {
            //CControlFormat.setFormStyle(this, new CAppContext_201());
            set_define_events();
            this.ShowInTaskbar = true;
            m_cmd_dang_nhap.Enabled = false;
            m_cmd_thong_tin.Enabled = false;
            m_cmd_sao_luu.Enabled = false;
            m_cmd_phuc_hoi.Enabled = false;
            m_cmd_mat_khau.Enabled = false;
            m_cmd_nhat_ky_he_thong.Enabled = false;
            m_cmd_mua_hang.Enabled = false;
            m_cmd_ban_hang.Enabled = false;
            m_cmd_nhap_tu_excel.Enabled = false;
            m_cmd_tien_te.Enabled = false;
            m_cmd_thue.Enabled = false;
            m_cmd_tai_khoan.Enabled = false;
            m_cmd_nha_cung_cap.Enabled = false;
            m_cmd_nhap_so_du_dau.Enabled = false;
            m_cmd_ma_vach.Enabled = false;
        }
        #endregion
        // Event handlers
        private void set_define_events()
        {
            m_cmd_nhap_kho.Click += m_cmd_nhap_kho_Click;
        }

        void m_cmd_nhap_kho_Click(object sender, EventArgs e)
        {
            f600_phieu_nhap_kho v_frm = new f600_phieu_nhap_kho();
            v_frm.display();
            
        }
        
        private void m_cmd_mat_hang_Click(object sender, EventArgs e)
        {
            try
            {
                f305_V_DM_HANG_HOA v_f = new f305_V_DM_HANG_HOA();
                v_f.ShowDialog();
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_nhom_hang_Click(object sender, EventArgs e)
        {
            f302_V_DM_NHOM_HANG f302 = new f302_V_DM_NHOM_HANG();
            f302.ShowDialog();
        }

        private void m_cmd_doanh_thu_theo_nhan_vien_Click(object sender, EventArgs e)
        {
            f702_BAO_CAO_DOANH_THU_THEO_NHAN_VIEN frm = new f702_BAO_CAO_DOANH_THU_THEO_NHAN_VIEN();
            frm.ShowDialog();
        }

        private void m_cmd_nhan_vien_Click(object sender, EventArgs e)
        {
            f701_DM_NHAN_VIEN frm = new f701_DM_NHAN_VIEN();
            frm.ShowDialog();
        }

        private void m_cmd_kho_Click(object sender, EventArgs e)
        {
            try
            {
                f110_V_DM_KHO frm = new f110_V_DM_KHO();
                frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_mat_hang_theo_nhom_Click(object sender, EventArgs e)
        {
           try
           {
               f305_V_DM_HANG_HOA v_f = new f305_V_DM_HANG_HOA();
               v_f.ShowDialog();
           }
           catch (System.Exception v_e)
           {
           	CSystemLog_301.ExceptionHandle(v_e);
           }
        }

        private void m_cmd_loai_chung_tu_Click(object sender, EventArgs e)
        {
            try
            {
                f112_DM_LOAI_CHUNG_TU frm = new f112_DM_LOAI_CHUNG_TU();
                frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_khach_hang_Click(object sender, EventArgs e)
        {
            try
            {
                f105_DM_KHACH_HANG frm = new f105_DM_KHACH_HANG();
                frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_don_vi_tinh_Click(object sender, EventArgs e)
        {
            f303_DM_DON_VI frm = new f303_DM_DON_VI();
            frm.ShowDialog();
        }

        private void m_cmd_nha_san_xuat_Click(object sender, EventArgs e)
        {
            try
            {
                f304_DM_NHA_SX v_f = new f304_DM_NHA_SX();
                v_f.ShowDialog();
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_bao_hanh_seri_Click(object sender, EventArgs e)
        {
            try
            {
                f107_V_BAO_CAO_BAO_HANH frm = new f107_V_BAO_CAO_BAO_HANH();
                frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_xuat_nhap_ton_Click(object sender, EventArgs e)
        {
            try
            {
                f806_RPT_XUAT_NHAP_TON frm = new f806_RPT_XUAT_NHAP_TON();
                frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_loi_nhuan_gop_Click(object sender, EventArgs e)
        {
            try
            {
                f807_RPT_LOI_NHUAN frm = new f807_RPT_LOI_NHUAN();
                frm.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_phan_quyen_Click(object sender, EventArgs e)
        {
            try
            {
                f999_ht_nguoi_su_dung frm999 = new f999_ht_nguoi_su_dung();
                frm999.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
                
            }
        }

        private void m_cmd_thoat_Click(object sender, EventArgs e)
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
    }
}
