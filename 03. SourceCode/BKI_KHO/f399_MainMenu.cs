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
using IP.Core.IPSystemAdmin;
using System.Security.Policy;
using BKI_KHO.NghiepVu;
using BKI_KHO.HeThong;
using GuiDev;
using DevExpress.XtraTab;

namespace Form_menu {
    public partial class f399_MainMenu : DevComponents.DotNetBar.Office2007RibbonForm {
        TabAdd m_tab_add = new TabAdd();
        public f399_MainMenu() {
            InitializeComponent();
            format_controls();
            m_tab_add.setCloseButtonTab(xtraTabControl1, ClosePageButtonShowMode.InAllTabPageHeaders);
        }
        #region Members
        int trangthaiweb = 1;
        #endregion
        #region Public Interface
        public void display(ref IP.Core.IPCommon.IPConstants.HowUserWantTo_Exit_MainForm v_exitmode) {
            try {
                this.ShowDialog();
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }

        }
        #endregion
        #region Private Method

        private void format_controls() {
            //CControlFormat.setFormStyle(this, new CAppContext_201());
            set_define_events();
            this.ShowInTaskbar = true;
            m_cmd_dang_nhap.Enabled = false;
            m_cmd_thong_tin.Enabled = false;
            m_cmd_sao_luu.Enabled = false;
            m_cmd_phuc_hoi.Enabled = false;
            m_cmd_doi_mat_khau.Enabled = true;
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
        public void closeTabPage(EventArgs e)
        {
            m_tab_add.setCloseTabInEventCloseForm(xtraTabControl1, e);
        }
        #endregion
        // Event handlers
        private void set_define_events() {
            m_cmd_nhap_kho.Click += m_cmd_nhap_kho_Click;
            m_cmd_xuat_kho.Click += m_cmd_xuat_kho_Click;
            xtraTabControl1.CloseButtonClick += xtraTabControl1_CloseButtonClick;
        }
   

        public void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            closeTabPage(e);
        }
        void m_cmd_xuat_kho_Click(object sender, EventArgs e) {
            try {
                f604_phieu_xuat_kho v_frm = new f604_phieu_xuat_kho();
                v_frm.display();
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_nhap_kho_Click(object sender, EventArgs e) {
            try {
                f201_nhap_kho v_frm = new f201_nhap_kho();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_mat_hang_Click(object sender, EventArgs e) {
            try {
                f305_V_DM_HANG_HOA v_f = new f305_V_DM_HANG_HOA();
                m_tab_add.AddTab(xtraTabControl1, v_f.Name, v_f.Text, v_f, new UserControl());
                //v_f.display();
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_nhom_hang_Click(object sender, EventArgs e) {
            try {
                f302_V_DM_NHOM_HANG v_f = new f302_V_DM_NHOM_HANG();
                m_tab_add.AddTab(xtraTabControl1, v_f.Name, v_f.Text, v_f, new UserControl());
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_doanh_thu_theo_nhan_vien_Click(object sender, EventArgs e) {
            try {
                f702_BAO_CAO_DOANH_THU_THEO_NHAN_VIEN v_frm = new f702_BAO_CAO_DOANH_THU_THEO_NHAN_VIEN();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_nhan_vien_Click(object sender, EventArgs e) {
            try {
                f701_DM_NHAN_VIEN v_frm = new f701_DM_NHAN_VIEN();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_kho_Click(object sender, EventArgs e) {
            try {
                f110_V_DM_KHO frm = new f110_V_DM_KHO();
                m_tab_add.AddTab(xtraTabControl1, frm.Name, frm.Text, frm, new UserControl());
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_mat_hang_theo_nhom_Click(object sender, EventArgs e) {
            try {

                f305_V_DM_HANG_HOA v_frm = new f305_V_DM_HANG_HOA();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_loai_chung_tu_Click(object sender, EventArgs e) {
            try {
                f112_DM_LOAI_CHUNG_TU v_frm = new f112_DM_LOAI_CHUNG_TU();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_khach_hang_Click(object sender, EventArgs e) {
            try {
                f105_DM_KHACH_HANG v_frm = new f105_DM_KHACH_HANG();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_don_vi_tinh_Click(object sender, EventArgs e) {
            try {
                f301_DM_DON_VI v_frm = new f301_DM_DON_VI();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_nha_san_xuat_Click(object sender, EventArgs e) {
            try {
                f304_DM_NHA_SX v_frm = new f304_DM_NHA_SX();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        

        private void m_cmd_xuat_nhap_ton_Click(object sender, EventArgs e) {
            try {
                f806_RPT_XUAT_NHAP_TON v_frm = new f806_RPT_XUAT_NHAP_TON();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_loi_nhuan_gop_Click(object sender, EventArgs e) {
            try {
                f807_RPT_LOI_NHUAN v_frm = new f807_RPT_LOI_NHUAN();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_phan_quyen_Click(object sender, EventArgs e) {
            try {
                f999_ht_nguoi_su_dung v_frm = new f999_ht_nguoi_su_dung();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);

            }
        }

        private void m_cmd_thoat_Click(object sender, EventArgs e) {
            try {
                this.Close();
            }
            catch(Exception v_e) {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tu_dien_Click(object sender, EventArgs e) {
            try {
                f100_TuDien v_frm = new f100_TuDien();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch(Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_nhap_so_du_dau_Click(object sender, EventArgs e) {
            try {
                f300_NHAP_SO_DU_DAU v_frm = new f300_NHAP_SO_DU_DAU();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch(System.Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_cmd_sua_chua_Click(object sender, EventArgs e) {
            try
            {
                F704_V_BAO_HANH_SUA_CHUA v_frm = new F704_V_BAO_HANH_SUA_CHUA();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_nhom_nguoi_sd_Click(object sender, EventArgs e) {
            try
            {
                f306_HT_USER_GROUP v_frm = new f306_HT_USER_GROUP();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_phan_quyen_cho_nhom_Click(object sender, EventArgs e) {
            try
            {
                f995_ht_phan_quyen_cho_nhom v_frm = new f995_ht_phan_quyen_cho_nhom();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_phan_quyen_he_thong_Click(object sender, EventArgs e) {
            try
            {
                f993_phan_quyen_he_thong v_frm = new f993_phan_quyen_he_thong();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_phan_quyen_chi_tiet_Click(object sender, EventArgs e) {
            try
            {
                f994_phan_quyen_detail v_frm = new f994_phan_quyen_detail();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_doi_mat_khau_Click(object sender, EventArgs e) {
            try
            {
                f308_DOI_MAT_KHAU_NGUOI_SD v_frm = new f308_DOI_MAT_KHAU_NGUOI_SD();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
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
                f107_V_TRA_CUU_BAO_HANH v_frm = new f107_V_TRA_CUU_BAO_HANH();
                m_tab_add.AddTab(xtraTabControl1, v_frm.Name, v_frm.Text, v_frm, new UserControl());
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


    }
}
