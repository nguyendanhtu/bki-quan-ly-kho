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
    public partial class f500_DM_LOAI_CHUNG_TU_DE : Form
    {
        #region Members
        US_DM_LOAI_CHUNG_TU m_us_dm_loai_chung_tu = new US_DM_LOAI_CHUNG_TU();
        #endregion Members

        #region structure

        #endregion structure

        #region private methods
        private void form_to_us_object()
        {
                m_us_dm_loai_chung_tu.strMA_LOAI_CT = this.m_tbo_ma_loai_ct.Text;
                m_us_dm_loai_chung_tu.strGHI_CHU = this.m_tbo_ghi_chu.Text;
        }
        private void m_bto_them_Click(object sender, EventArgs e)
        {
            if (this.m_tbo_ma_loai_ct.Text != "" && this.m_tbo_ghi_chu.Text != "")
            {
                // Thu thap du lieu va do vao us tuong ung
                form_to_us_object();
                // Them vao co so du lieu
                m_us_dm_loai_chung_tu.Insert();
                // Thoat form DE
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ trường dữ liệu", "Data null", MessageBoxButtons.OK);
            }
        }
        private void m_bto_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion private methods

        #region public interface
        public f500_DM_LOAI_CHUNG_TU_DE()
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
