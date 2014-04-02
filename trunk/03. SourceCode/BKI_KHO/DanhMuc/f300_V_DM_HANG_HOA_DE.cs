using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_KHO.DS;
using BKI_KHO.DS.CDBNames;
using BKI_KHO.US;
using IP.Core.IPCommon;

namespace BKI_KHO.DanhMuc
{
    public partial class f300_V_DM_HANG_HOA_DE : Form
    {     
        #region Public Interfaces
        public f300_V_DM_HANG_HOA_DE()
        {
            InitializeComponent();
        }
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            load_data_2_combox();
            this.ShowDialog();        
        }
        public void display_for_update(US_V_DM_HANG_HOA m_us)
        {
            load_data_2_combox();
            m_e_form_mode = DataEntryFormMode.UpdateDataState;

            US_DM_HANG_HOA v_us = new US_DM_HANG_HOA();

            DS_DM_HANG_HOA v_ds = new DS_DM_HANG_HOA();
            v_us.FillDatasetById(v_ds, m_us.dcID);

            DataRow v_dr = v_ds.Tables[0].Rows[0];
            dr_to_form(v_dr);
            this.ShowDialog();
        }
        
        #endregion
        #region Members
        DataEntryFormMode m_e_form_mode;
        US_DM_HANG_HOA m_us_dm_hang_hoa = new US_DM_HANG_HOA();
        #endregion
        #region Private Methods

        private void load_data_2_cbo_don_vi()
        {
            US_DM_DON_VI v_us = new US_DM_DON_VI();
            DS_DM_DON_VI v_ds = new DS_DM_DON_VI();

            v_us.FillDataset(v_ds);

            m_cbo_don_vi.DataSource = v_ds.Tables[0];
            m_cbo_don_vi.DisplayMember = DM_DON_VI.TEN;
            m_cbo_don_vi.ValueMember = DM_DON_VI.ID;
        }
        private void load_data_2_combox()
        {
            load_data_2_cbo_don_vi();
        }
        private void form_2_us_obj()
        {
            //m_us_dm_hang_hoa.dcGIA_BAN = CIPConvert.ToDecimal(m_txt_gia_ban.Text);
            //m_us_dm_hang_hoa.dcGIA_BAN_LE = CIPConvert.ToDecimal(m_txt_gia_ban_le.Text);
            //m_us_dm_hang_hoa.dcGIA_NHAP = CIPConvert.ToDecimal(m_txt_gia_nhap.Text);
            m_us_dm_hang_hoa.dcID_DON_VI = CIPConvert.ToDecimal(m_cbo_don_vi.SelectedValue);
            //m_us_dm_hang_hoa.dcID_NHA_CUNG_CAP = CIPConvert.ToDecimal(m_cbo_nha_cung_cap.SelectedValue);
            //m_us_dm_hang_hoa.dcID_NHOM = CIPConvert.ToDecimal(m_cbo_nhom.SelectedValue);
            //m_us_dm_hang_hoa.dcID_NHOM_GOC = CIPConvert.ToDecimal(m_cbo_nhom_goc.SelectedValue);

            m_us_dm_hang_hoa.strMA_HANG = m_txt_hang_hoa.Text;
            m_us_dm_hang_hoa.strMO_TA = m_txt_mo_ta.Text;
            m_us_dm_hang_hoa.strTEN_HANG_EN = m_txt_ten_hang_en.Text;
            m_us_dm_hang_hoa.strTEN_HANG_VN = m_txt_ten_hang_vn.Text;
        }
        private void us_obj_2_form()
        {
            m_txt_hang_hoa.Text = m_us_dm_hang_hoa.strMA_HANG;
            m_txt_ten_hang_vn.Text = m_us_dm_hang_hoa.strTEN_HANG_VN;
            m_txt_ten_hang_en.Text = m_us_dm_hang_hoa.strTEN_HANG_EN;
            m_txt_mo_ta.Text = m_us_dm_hang_hoa.strMO_TA;
            m_txt_gia_nhap.Text = CIPConvert.ToStr(m_us_dm_hang_hoa.dcGIA_NHAP);
            m_txt_gia_ban.Text = CIPConvert.ToStr(m_us_dm_hang_hoa.dcGIA_BAN);
            m_txt_gia_ban_le.Text = CIPConvert.ToStr(m_us_dm_hang_hoa.dcGIA_BAN_LE);
            m_cbo_don_vi.SelectedValue = m_us_dm_hang_hoa.dcID_DON_VI;
            m_cbo_nhom.SelectedValue = CIPConvert.ToStr(m_us_dm_hang_hoa.dcID_NHOM);
            m_cbo_nhom_goc.SelectedValue = CIPConvert.ToStr(m_us_dm_hang_hoa.dcID_NHOM_GOC);
            m_cbo_nha_cung_cap.SelectedValue = CIPConvert.ToStr(m_us_dm_hang_hoa.dcID_NHA_CUNG_CAP);
        }
        #endregion
        #region Events
        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            form_2_us_obj();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_dm_hang_hoa.Insert();
                    this.Close();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_dm_hang_hoa.Update();
                    this.Close();
                    break;
                default: break;
            }
        }
        private void m_cmd_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                xoa_trang();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void xoa_trang()
        {
            m_txt_hang_hoa.Text = "";
            m_txt_gia_nhap.Text = "";
            m_txt_gia_ban.Text = "";
            m_txt_gia_ban_le.Text = "";
            m_txt_mo_ta.Text = "";
            m_txt_ten_hang_vn.Text = "";
            m_txt_ten_hang_en.Text = "";
            m_cbo_don_vi.Text = "";
            m_cbo_don_vi.ValueMember = null;
        }
        //public void display_for_update(US_DM_HANG_HOA m_us)
        //{
            
        //}

        #endregion       
    
        
       
    
        

        private void dr_to_form(DataRow v_dr)
        {           
            m_us_dm_hang_hoa.dcID = CIPConvert.ToDecimal(v_dr[DM_HANG_HOA.ID]);
            m_txt_hang_hoa.Text = v_dr[DM_HANG_HOA.MA_HANG].ToString();
            m_txt_ten_hang_vn.Text = v_dr[DM_HANG_HOA.TEN_HANG_VN].ToString();
            m_txt_ten_hang_en.Text = v_dr[DM_HANG_HOA.TEN_HANG_EN].ToString();
            m_txt_mo_ta.Text = v_dr[DM_HANG_HOA.MO_TA].ToString();

            m_txt_gia_ban.Text = CIPConvert.ToStr(v_dr[DM_HANG_HOA.GIA_BAN]);
            m_txt_gia_nhap.Text = CIPConvert.ToStr(v_dr[DM_HANG_HOA.GIA_NHAP]);
            m_txt_gia_ban_le.Text = CIPConvert.ToStr(v_dr[DM_HANG_HOA.GIA_BAN_LE]);

            m_cbo_don_vi.SelectedValue = v_dr[DM_HANG_HOA.ID_DON_VI];
        }
    }
}
