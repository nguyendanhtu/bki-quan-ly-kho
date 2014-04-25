using System.Windows.Forms;
using System;
using BKI_KHO.US;
using BKI_KHO.DS;
using BKI_KHO.DS.CDBNames;
using IP.Core.IPCommon;
using System.Data;
using System.Collections.Generic;

namespace BKI_KHO.DanhMuc
{
    public partial class f803_DM_NHOM_HANG_DE : Form
    {
        #region Members
        DataEntryFormMode m_e_form_mode;
        US_DM_NHOM_HANG m_us_dm_nhom_hang = new US_DM_NHOM_HANG();
        #endregion

        #region Public Interface
        public f803_DM_NHOM_HANG_DE()
        {
            InitializeComponent();
        }

        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            load_data_2_cbo();
            load_data_2_read_only_control();
            m_cmd_save.Text = "Thêm mới";
            this.ShowDialog();
        }

        public void display_for_update(US_DM_NHOM_HANG m_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            load_data_2_cbo();
            load_data_2_read_only_control();
            m_us_dm_nhom_hang = m_us;
            us_obj_2_form();
            m_cmd_save.Text = "Cập nhật";
            this.ShowDialog();
        }
        #endregion

        #region Private Methods
        private void load_data_2_cbo_nhom_cha()
        {
            US_DM_NHOM_HANG v_us = new US_DM_NHOM_HANG();
            DS_DM_NHOM_HANG v_ds = new DS_DM_NHOM_HANG();

            v_us.FillDataset(v_ds);

            DataRow v_dr = v_ds.Tables[0].NewRow();

            v_dr[DM_NHOM_HANG.TEN] = "(Không có)";
            v_dr[DM_NHOM_HANG.ID] = -1;

            v_ds.Tables[0].Rows.InsertAt(v_dr, 0);

            m_cbo_nhom_cha.DataSource = v_ds.Tables[0];
            m_cbo_nhom_cha.DisplayMember = DM_NHOM_HANG.TEN;
            m_cbo_nhom_cha.ValueMember = DM_NHOM_HANG.ID;
            m_cbo_nhom_cha.SelectedIndex = 0;
        }

        private void load_data_2_cbo()
        {
            load_data_2_cbo_nhom_cha();
        }

        private void load_data_2_read_only_control()
        {
            load_data_2_nud_cap_do();
        }

        private void load_data_2_nud_cap_do()
        {
            if (m_cbo_nhom_cha.Text == "(Không có)")
                m_nud_cap_do.Value = 0;
            else
            {
                DS_DM_NHOM_HANG v_ds = new DS_DM_NHOM_HANG();
                US_DM_NHOM_HANG v_us = new US_DM_NHOM_HANG();

                v_us.FillDataset(v_ds);

                DataRow v_dr = v_ds.Tables[0].NewRow();
                v_dr = v_ds.Tables[0].Rows.Find(m_cbo_nhom_cha.SelectedValue);

                m_nud_cap_do.Value = Decimal.Parse(v_dr[DM_NHOM_HANG.LEVEL_MODE].ToString()) + 1;
            }
        }

        private void us_obj_2_form()
        {
            m_cbo_nhom_cha.SelectedValue = m_us_dm_nhom_hang.dcID_NHOM_CHA;
            m_nud_cap_do.Value = m_us_dm_nhom_hang.dcLEVEL_MODE;
            m_txt_ten.Text = m_us_dm_nhom_hang.strTEN;
            m_txt_mo_ta.Text = m_us_dm_nhom_hang.strMO_TA;
            m_nud_so_thu_tu.Value = m_us_dm_nhom_hang.dcSTT;
        }

        private void form_2_us_obj()
        {
            m_us_dm_nhom_hang = new US_DM_NHOM_HANG();

            if (m_cbo_nhom_cha.SelectedValue != (Object)(-1))
                m_us_dm_nhom_hang.dcID_NHOM_CHA = (Decimal)m_cbo_nhom_cha.SelectedValue;
            m_us_dm_nhom_hang.dcLEVEL_MODE = m_nud_cap_do.Value;
            m_us_dm_nhom_hang.strTEN = m_txt_ten.Text;
            m_us_dm_nhom_hang.strMO_TA = m_txt_mo_ta.Text;
            m_us_dm_nhom_hang.dcSTT = m_nud_so_thu_tu.Value;
        }
        #endregion

        #region Events
        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                form_2_us_obj();
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        m_us_dm_nhom_hang.Insert();
                        this.Close();
                        break;
                    case DataEntryFormMode.SelectDataState:
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        m_us_dm_nhom_hang.Update();
                        this.Close();
                        break;
                    case DataEntryFormMode.ViewDataState:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cbo_nhom_cha_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_data_2_nud_cap_do();
        }
        #endregion
    }
}
