﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using BKI_KHO;
using BKI_KHO.US;
using BKI_KHO.DanhMuc;
using IP.Core.IPCommon;
using IP.Core.IPExcelReport;
using IP.Core.IPSystemAdmin;

namespace BKI_KHO
{
    public partial class f400_Main : Form
    {
        public f400_Main()
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
            this.m_menuitem_tudien.Click += new EventHandler(m_mnu_tu_dien_he_thong_Click);
            //this.m_menuitem_user.Click += new EventHandler(m_mnu_quan_ly_nguoi_su_dung_Click);
            //this.m_menuitem_thoat.Click += new EventHandler(m_menuitem_thoat_Click);
            //this.m_menuitem_qldonvi.Click += new EventHandler(m_menuitem_qldonvi_Click);
            //this.m_menu_dsnhansu.Click += new EventHandler(m_menu_dsnhansu_Click);
            //this.m_menuitem_traCuuNhanSuChung.Click += new EventHandler(m_menuitem_traCuuNhanSuChung_Click);
            //m_menuitem_nhan_su_theo_phong_ban.Click += new System.EventHandler(m_menuitem_nhan_su_theo_phong_ban_Click);
        }

        private void m_menu_dsnhansu_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_mnu_quan_ly_nguoi_su_dung_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_mnu_tu_dien_he_thong_Click(object sender, EventArgs e)
        {
            try
            {
                IP.Core.IPSystemAdmin.f100_TuDien v_f100_td = new f100_TuDien();
                v_f100_td.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menuitem_thoat_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menuitem_user_Click(object sender, EventArgs e)
        {
            try
            {
                f999_ht_nguoi_su_dung frm = new f999_ht_nguoi_su_dung();
                frm.Show();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menuitem_qlchucvu_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_menuitem_qldonvi_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_meuitem_ttduan_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menuitem_bcnhansu_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menuitem_qlquyetdinh_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menuitem_trangthailaodong_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menuitem_nhan_su_theo_phong_ban_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menuitem_hopdong_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menuitem_quatrinhlamviec_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void nhânSựTheoChứcVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_meuitem_nhansuduan_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menuitem_bcduan_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menuitem_traCuuNhanSuChung_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void f400_Main_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_lbl_du_an_sap_kt_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void báoCáoHợpĐồngĐãHếtHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_lbl_thong_bao_hop_dong_sap_het_han_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Chưa có chức năng này!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menuitem_hanghoa_Click(object sender, EventArgs e)
        {
            f300_V_DM_HANG_HOA f300_v_dm_hang_hoa = new f300_V_DM_HANG_HOA();
            f300_v_dm_hang_hoa.ShowDialog();
        }

        private void m_menuitem_donvitinh_Click(object sender, EventArgs e)
        {
            f301_DM_DON_VI f301_dm_don_vi = new f301_DM_DON_VI();
            f301_dm_don_vi.ShowDialog();
        }

        private void m_menuitem_nhomhanghoa_Click(object sender, EventArgs e)
        {
            try
            {
                f801_DM_NHOM_HANG f801 = new f801_DM_NHOM_HANG();
                f801.ShowDialog();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }



    }
}