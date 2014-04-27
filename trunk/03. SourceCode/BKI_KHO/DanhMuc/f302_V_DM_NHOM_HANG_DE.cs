using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_KHO.US;
//using IP.Core.IPCommon.MessageForms;
using IP.Core.IPCommon;
using BKI_KHO.DS;
using IP.Core.IPSystemAdmin;

namespace BKI_KHO.DanhMuc
{
    public partial class f302_V_DM_NHOM_HANG_DE : Form
    {
        public f302_V_DM_NHOM_HANG_DE()
        {
            InitializeComponent();
            format_control();
        }

        
        #region Members
        DataEntryFormMode m_e_form_mode;
        DS_V_DM_NHOM_HANG m_ds = new DS_V_DM_NHOM_HANG();
        US_V_DM_NHOM_HANG m_us = new US_V_DM_NHOM_HANG();

        DS_DM_NHOM_HANG m_ds_dm_nhom_hang = new DS_DM_NHOM_HANG();
        US_DM_NHOM_HANG m_us_dm_nhom_hang = new US_DM_NHOM_HANG();
        #endregion

        #region Public Interface

        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
        }
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            load_data_2_combox();
            this.ShowDialog();
        }
        public void display_for_update(US_DM_NHOM_HANG ip_m_us_dm_nhom_hang)
        {
            load_data_2_combox();
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_object_2_form(ip_m_us_dm_nhom_hang);
            //dr_2_form(v_dr);
            this.ShowDialog();
        }

        private void us_object_2_form(US_DM_NHOM_HANG ip_m_us_dm_nhom_hang)
        {          
            m_us_dm_nhom_hang.dcID = ip_m_us_dm_nhom_hang.dcID;
            m_txt_ten_nhom.Text = ip_m_us_dm_nhom_hang.strTEN;
            m_txt_mo_ta.Text = ip_m_us_dm_nhom_hang.strMO_TA;
            m_cbo_ten_nhom_cha.SelectedValue = ip_m_us_dm_nhom_hang.dcID_NHOM_CHA;
        }

        private void dr_2_form(DataRow v_dr)
        {
            m_txt_ten_nhom.Text = v_dr["TEN"].ToString();
            m_txt_mo_ta.Text = v_dr["MO_TA"].ToString();
            m_cbo_ten_nhom_cha.SelectedValue = v_dr["ID_NHOM_CHA"];
        }
        
        #endregion
        
        #region Private Methods
        private void load_data_2_combox()
        {
            DS_DM_NHOM_HANG v_ds = new DS_DM_NHOM_HANG();
            US_DM_NHOM_HANG v_us = new US_DM_NHOM_HANG();

            v_us.FillDataset(v_ds);

            m_cbo_ten_nhom_cha.DataSource = v_ds.DM_NHOM_HANG;
            m_cbo_ten_nhom_cha.ValueMember = "ID";
            m_cbo_ten_nhom_cha.DisplayMember = "TEN";

            m_cbo_ten_nhom_cha.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            m_cbo_ten_nhom_cha.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private bool is_validate_data_ok()
        {
            if (!CValidateTextBox.IsValid(
                m_txt_ten_nhom
                , DataType.StringType
                , allowNull.NO
                , true))
                return false;                   
            return true;
        }

        private void form_2_us_obj()
        {                 
                m_us_dm_nhom_hang.strTEN = m_txt_ten_nhom.Text;       
                m_us_dm_nhom_hang.dcID_NHOM_CHA = CIPConvert.ToDecimal(m_cbo_ten_nhom_cha.SelectedValue);
                m_us_dm_nhom_hang.strMO_TA = m_txt_mo_ta.Text;                                        
        }
        private void us_obj_2_form()
        {

        }
        #endregion
   
        #region Events
        private void m_cmd_exit_Click(object sender, EventArgs e)
        {           
            this.Close();
        }
        private void m_cmd_save_Click(object sender, EventArgs e)
        {   
            try
            {
                if (!is_validate_data_ok())
                    return;
                form_2_us_obj();

                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:                      
                        m_us_dm_nhom_hang.Insert();
                        this.Close();
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        m_us_dm_nhom_hang.Update();
                        this.Close();
                        break;
                    default: break;
                }
                
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }          
        }
        #endregion                  
    
        
    }
}
