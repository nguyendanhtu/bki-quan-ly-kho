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
            f300_V_DM_HANG_HOA f300 = new f300_V_DM_HANG_HOA();
            f300.ShowDialog();
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
            f300_V_DM_HANG_HOA frm = new f300_V_DM_HANG_HOA();     
            //frm.m_cmd_view.Visible = false;
            //frm.m_cmd_insert.Visible = false;
            //frm.m_cmd_update.Visible = false;
            //frm.m_cmd_exit.Visible = false;
            //frm.m_cmd_delete.Visible = false;
            frm.m_pnl_out_place_dm.Visible = false;
            frm.m_tab_thong_tin_dm_hang_hoa.Visible = false;
            frm.Size = new System.Drawing.Size(1241, 450);
            frm.ShowDialog();
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
                f107_V_DM_BAO_HANH frm = new f107_V_DM_BAO_HANH();
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
    }
}