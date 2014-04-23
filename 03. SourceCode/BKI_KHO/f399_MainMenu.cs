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
            f110_V_DM_KHO frm = new f110_V_DM_KHO();
            frm.ShowDialog();
        }
    }
}