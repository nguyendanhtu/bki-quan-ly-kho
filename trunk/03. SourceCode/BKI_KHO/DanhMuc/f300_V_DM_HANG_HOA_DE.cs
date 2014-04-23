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
using BKI_KHO.DS;
using BKI_KHO.DS.CDBNames;

namespace BKI_KHO.DanhMuc
{
    public partial class f300_V_DM_HANG_HOA_DE : Form
    {

        #region Members
        private DataEntryFormMode m_e_form_mode;// = DataEntryFormMode.InsertDataState;
        DS_DM_HANG_HOA m_ds = new DS_DM_HANG_HOA();
        US_DM_HANG_HOA m_us = new US_DM_HANG_HOA();
        #endregion

        #region Public Interface
        public f300_V_DM_HANG_HOA_DE()
        {
            InitializeComponent();
        }
        public void display_for_insert()
        {
            /*Thay đổi trạng thái sang insert*/
            
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        private void load_data_to_combox()
        {   
            /*Do du lieu len combobox Nhom*/
            US_DM_NHOM_HANG v_us = new US_DM_NHOM_HANG();
            DS_DM_NHOM_HANG v_ds = new DS_DM_NHOM_HANG();           
            v_us.FillDataset(v_ds);
            m_cbo_nhom.DataSource = v_ds.DM_NHOM_HANG;
            m_cbo_nhom.ValueMember = DM_NHOM_HANG.ID;
            m_cbo_nhom.DisplayMember = DM_NHOM_HANG.TEN;

          
            /*Do du lieu len combobox Nha cung cap*/
            US_DM_NHA_CUNG_CAP v_us_ncc = new US_DM_NHA_CUNG_CAP();
            DS_DM_NHA_CUNG_CAP v_ds_ncc = new DS_DM_NHA_CUNG_CAP();
            v_us_ncc.FillDataset(v_ds_ncc);
            m_cbo_nha_cung_cap.DataSource = v_ds_ncc.DM_NHA_CUNG_CAP;
            m_cbo_nha_cung_cap.DisplayMember = DM_NHA_CUNG_CAP.TEN_NHA_CUNG_CAP;
            m_cbo_nha_cung_cap.ValueMember = DM_NHA_CUNG_CAP.ID;

            /*	Do du lieu len cobombox Trang thai */
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();

            v_us_tu_dien.FillDatasetByIdLoaiTuDien(v_ds_tu_dien, 15);
            m_cbo_trang_thai.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
            m_cbo_trang_thai.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_trang_thai.DisplayMember = CM_DM_TU_DIEN.TEN;



            /*Tao autocomplete combobox*/
            m_cbo_nhom.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            m_cbo_nhom.AutoCompleteSource = AutoCompleteSource.ListItems;

            m_cbo_nha_cung_cap.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            m_cbo_nha_cung_cap.AutoCompleteSource = AutoCompleteSource.ListItems;

            m_cbo_trang_thai.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            m_cbo_trang_thai.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        public void display_for_update(US_DM_HANG_HOA us_dm_hang_hoa)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_obj_2_form(us_dm_hang_hoa);
            this.ShowDialog();
        }
        #endregion          

        #region Private Methods
        private void save_data()
        {
            /* If(check_da_ta_is_ok) */
            form_2_us_obj();
            switch(m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us.Update();
                    break;
            }
            BaseMessages.MsgBox_Infor("Dữ liệu đã được cập nhật");
            this.Close();
        }
        private void form_2_us_obj()
        {
            m_us.strTEN_HANG_VN = m_txt_ten_hang.Text;
            m_us.strMA_HANG = m_txt_ma_hang.Text;
            m_us.dcID_NHOM = CIPConvert.ToDecimal(m_cbo_nhom.SelectedValue);
            m_us.dcID_NHA_CUNG_CAP = CIPConvert.ToDecimal(m_cbo_nha_cung_cap.SelectedValue);
            m_us.strMO_TA = m_txt_mo_ta.Text;
            m_us.dcGIA_NHAP = CIPConvert.ToDecimal(m_txt_gia_nhap.Text);
            m_us.dcGIA_BAN = CIPConvert.ToDecimal(m_txt_gia_ban.Text);
            m_us.dcID_TRANG_THAI = CIPConvert.ToDecimal(m_cbo_trang_thai.SelectedValue);
        }
        private void us_obj_2_form(US_DM_HANG_HOA ip_us_dm_hang_hoa)
        {
            m_us.dcID = ip_us_dm_hang_hoa.dcID;
            m_txt_ten_hang.Text = ip_us_dm_hang_hoa.strTEN_HANG_VN;
            m_txt_ma_hang.Text = ip_us_dm_hang_hoa.strMA_HANG;
            m_cbo_nhom.SelectedValue = ip_us_dm_hang_hoa.dcID_NHOM;
            m_cbo_nha_cung_cap.SelectedValue = ip_us_dm_hang_hoa.dcID_NHA_CUNG_CAP;
            m_txt_mo_ta.Text = ip_us_dm_hang_hoa.strMO_TA;
            m_txt_gia_nhap.Text = CIPConvert.ToStr(ip_us_dm_hang_hoa.dcGIA_NHAP);
            m_txt_gia_ban.Text = CIPConvert.ToStr(ip_us_dm_hang_hoa.dcGIA_BAN);
            m_cbo_trang_thai.SelectedValue = ip_us_dm_hang_hoa.dcID_TRANG_THAI;
        }
        private void xoa_trang()
        {
            m_txt_ma_hang.Text = null;
            m_txt_ten_hang.Text = null;
            m_txt_mo_ta.Text = null;
            m_txt_gia_ban.Text = null;
            m_txt_gia_nhap.Text = null;
        }
        #endregion

        #region Events
        private void f300_V_DM_HANG_HOA_DE_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_to_combox(); /*Load dữ liệu từ lưới vào combobox*/
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

        


        
    }
}
