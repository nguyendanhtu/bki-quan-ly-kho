using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_KHO.US;
using BKI_KHO.DS;
using IP.Core.IPCommon;

namespace BKI_KHO.DanhMuc
{
	public partial class f501_DM_KHO_DE : Form
	{
		#region Members
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        US_DM_KHO m_us_dm_kho = new US_DM_KHO();
		#endregion

		#region Events
        private void m_cmd_them_Click(object sender, EventArgs e)
        {
            form_to_us_object();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_dm_kho.Insert();
                    this.Close();
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_dm_kho.Update();
                    this.Close();
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }

        }

        private void m_cmd_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_xoa_trang_Click(object sender, EventArgs e)
        {
            xoa_trang();
        }
		#endregion

		#region private methods
		
		private void xoa_trang()
		{
			this.m_txt_dia_chi.Text = "";
			this.m_txt_ghi_chu.Text = "";
			this.m_txt_ma_nv.Text = "";
			this.m_txt_so_dien_thoai.Text = "";
			this.m_txt_ma_kho.Text = "";
            this.m_txt_ten_kho.Text = "";
		}

		
		private void form_to_us_object()
		{
			m_us_dm_kho.strDIA_CHI = m_txt_dia_chi.Text;
			m_us_dm_kho.strDIEN_THOAI = m_txt_so_dien_thoai.Text;
			m_us_dm_kho.strGHI_CHU = m_txt_ghi_chu.Text;
			m_us_dm_kho.dcID_NHAN_VIEN = decimal.Parse(m_txt_ma_nv.Text);
			m_us_dm_kho.strMA_KHO = m_txt_ma_kho.Text;
            m_us_dm_kho.strTEN_KHO = m_txt_ten_kho.Text;
		}
		
        private void us_obj_2_form()
        {
            m_txt_dia_chi.Text = m_us_dm_kho.strDIA_CHI;
            m_txt_so_dien_thoai.Text = m_us_dm_kho.strDIEN_THOAI;
            m_txt_ghi_chu.Text = m_us_dm_kho.strGHI_CHU;
            m_txt_ma_nv.Text = Convert.ToString(m_us_dm_kho.dcID_NHAN_VIEN);
            m_txt_ma_kho.Text = m_us_dm_kho.strMA_KHO;
            m_txt_ten_kho.Text = m_us_dm_kho.strTEN_KHO;
        }
		#endregion

		#region public interface
		public f501_DM_KHO_DE()
		{
			InitializeComponent();
		}

        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();

        }

        public void display_for_update(US_DM_KHO m_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_kho = m_us;
            us_obj_2_form();
            this.ShowDialog();
        }

        
		#endregion

        
    }
}
