using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_KHO.US;

namespace BKI_KHO.DanhMuc
{
	public partial class f501_DM_KHO_DE_THEM : Form
	{
		#region Members
		US_DM_KHO m_us_kho;
		#endregion Members

		#region structure

		#endregion structure

		#region private methods
		private void m_cmd_thoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void xoa_trang()
		{
			this.m_txt_dia_chi.Text = "";
			this.m_txt_ghi_chu.Text = "";
			this.m_txt_ma_nv.Text = "";
			this.m_txt_so_dien_thoai.Text = "";
			this.m_txt_ma_kho.Text = "";
		}

		private void m_cmd_xoa_trang_Click(object sender, EventArgs e)
		{
			xoa_trang();
		}
		private void form_to_us_object()
		{
			m_us_kho.strDIA_CHI = this.m_txt_dia_chi.Text;
			m_us_kho.strDIEN_THOAI = this.m_txt_so_dien_thoai.Text;
			m_us_kho.strGHI_CHU = this.m_txt_ghi_chu.Text;
			m_us_kho.dcID_NHAN_VIEN = decimal.Parse(this.m_txt_ma_nv.Text);
			m_us_kho.strMA_KHO = m_txt_ma_kho.Text;
		}
		private void m_cmd_them_Click(object sender, EventArgs e)
		{
			// kiem tra null
			if (this.m_txt_dia_chi.Text == "" || this.m_txt_ghi_chu.Text == "" || this.m_txt_ma_kho.Text == "" || this.m_txt_ma_nv.Text == "" || this.m_txt_so_dien_thoai.Text == "")
			{
				form_to_us_object();
				m_us_kho.Insert();
			}
			// Xoa trang cac truong
			xoa_trang();
		}
		#endregion private methods

		#region public interface
		public f501_DM_KHO_DE_THEM()
		{
			InitializeComponent();
		}
		public void display()
		{
			this.ShowDialog();
		}
		#endregion public interface
	}
}
