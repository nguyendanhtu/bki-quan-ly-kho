﻿using System;
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
using IP.Core.IPSystemAdmin;
using System.Security.Policy;
using BKI_KHO.NghiepVu;

namespace Form_menu
{
    public partial class f399_MainMenu : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public f399_MainMenu()
        {
            InitializeComponent();
            format_controls();
        }
#region Members
        int trangthaiweb = 1;
#endregion
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
            //m_cmd_nha_cung_cap.Enabled = false;
            //m_cmd_nhap_so_du_dau.Enabled = false;
            m_cmd_ma_vach.Enabled = false;
        }
        #endregion
        // Event handlers
        private void set_define_events()
        {
            m_cmd_nhap_kho.Click += m_cmd_nhap_kho_Click;
            m_cmd_xuat_kho.Click += m_cmd_xuat_kho_Click;
        }

        void m_cmd_xuat_kho_Click(object sender, EventArgs e)
        {
            try
            {
                f604_phieu_xuat_kho v_frm = new f604_phieu_xuat_kho();
                v_frm.display();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_nhap_kho_Click(object sender, EventArgs e)
        {
            try
            {
                f600_phieu_nhap_kho v_frm = new f600_phieu_nhap_kho();
                v_frm.display();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
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
            try
            {
                f302_V_DM_NHOM_HANG f302 = new f302_V_DM_NHOM_HANG();
                f302.ShowDialog();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_doanh_thu_theo_nhan_vien_Click(object sender, EventArgs e)
        {
            try
            {
                f702_BAO_CAO_DOANH_THU_THEO_NHAN_VIEN frm = new f702_BAO_CAO_DOANH_THU_THEO_NHAN_VIEN();
                frm.ShowDialog();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_nhan_vien_Click(object sender, EventArgs e)
        {
            try
            {
                f701_DM_NHAN_VIEN frm = new f701_DM_NHAN_VIEN();
                frm.ShowDialog();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
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
            try
            {
                f301_DM_DON_VI frm = new f301_DM_DON_VI();
                frm.ShowDialog();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
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

        private void m_cmd_tu_dien_Click(object sender, EventArgs e)
        {
            try
            {
                f100_TuDien frm100 = new f100_TuDien();
                frm100.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void f399_MainMenu_Load(object sender, EventArgs e)
        {
            string url = @"http://bkindex.com/home/";
            webBrowser1.Url = new Uri(url);
            webBrowser1.ScriptErrorsSuppressed = true;
            m_cmd_browser.Text = "Tắt duyệt web";
        }       
        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string url = null;
                    if (toolStripTextBox1.Text.Contains("http://"))
                    {
                        url = toolStripTextBox1.Text.Trim();

                    }
                    else
                        url = "http://" + toolStripTextBox1.Text.Trim();

                    webBrowser1.Url = new Uri(url);
                }
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                string url = null;
                if (toolStripTextBox1.Text.Contains("http://"))
                {
                    url = toolStripTextBox1.Text.Trim();

                }
                else
                    url = "http://" + toolStripTextBox1.Text.Trim();

                webBrowser1.Url = new Uri(url);
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.GoBack();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.GoForward();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Refresh();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_browser_Click(object sender, EventArgs e)
        {
            try
            {
                switch (trangthaiweb)
                {
                    case 1:
                        webBrowser1.Dispose();
                        webBrowser1.Visible = false;
                        toolStrip1.Visible = false;
                        trangthaiweb = 0;
                        m_cmd_browser.Text = "Bật duyệt web";
                        break;
                    case 0:
                        webBrowser1.Visible = true;
                        toolStrip1.Visible = true;
                        trangthaiweb = 1;
                        m_cmd_browser.Text = "Tắt duyệt web";
                        break;
                }
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_nhap_so_du_dau_Click(object sender, EventArgs e)
        {
            try
            {
                f300_NHAP_SO_DU_DAU v_f = new f300_NHAP_SO_DU_DAU();
                v_f.ShowDialog();
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
