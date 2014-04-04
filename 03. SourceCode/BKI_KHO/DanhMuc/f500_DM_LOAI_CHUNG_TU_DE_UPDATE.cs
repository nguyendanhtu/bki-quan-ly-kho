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
    public partial class f500_DM_LOAI_CHUNG_TU_DE_UPDATE : Form
    {
        #region Members
        US_DM_LOAI_CHUNG_TU m_us;
        #endregion Members

        #region structure

        #endregion structure

        #region private methods
        private void m_bto_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_bto_update_Click(object sender, EventArgs e)
        {
            string v_thong_bao;
            v_thong_bao = "Thông tin sửa thành: " + this.m_tbo_ma_loai_ct.Text + " - " + this.m_tbo_ghi_chu.Text;
            if(MessageBox.Show(v_thong_bao,"Cảnh báo", MessageBoxButtons.YesNoCancel)== DialogResult.Yes)
            {
                // Luu vao US
                m_us.strMA_LOAI_CT = this.m_tbo_ma_loai_ct.Text;
                m_us.strGHI_CHU = this.m_tbo_ghi_chu.Text;
                // DO US vao csdl
                m_us.Update();
                this.Close();
            }
        }
        #endregion private methods

        #region public interface
        public f500_DM_LOAI_CHUNG_TU_DE_UPDATE(US_DM_LOAI_CHUNG_TU m_us)
        {
            InitializeComponent();
            this.m_us = m_us;
        }
        public void display()
        {
            this.m_tbo_ma_loai_ct.Text = m_us.strMA_LOAI_CT;
            this.m_tbo_ghi_chu.Text = m_us.strGHI_CHU;
            this.m_bto_update.Enabled = false;
            this.ShowDialog();
        }
        #endregion public interface
        private void status_update()
        {
            m_bto_update.Enabled = true;
        }
        private void m_tbo_ma_loai_ct_TextChanged(object sender, EventArgs e)
        {
            status_update();
        }

        private void m_tbo_ghi_chu_TextChanged(object sender, EventArgs e)
        {
            status_update();
        }

        
    }
}
