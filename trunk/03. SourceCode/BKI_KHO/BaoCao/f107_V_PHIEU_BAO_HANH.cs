using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;

using BKI_KHO.US;
using BKI_KHO.DS;
using BKI_KHO.DS.CDBNames;

using C1.Win.C1FlexGrid;

namespace BKI_KHO.BaoCao
{
    public partial class f107_V_PHIEU_BAO_HANH : Form
    {
        public f107_V_PHIEU_BAO_HANH()
        {
            InitializeComponent();
        }
        void m_fg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                danh_sach_chung_tu_theo_nhan_vien();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void danh_sach_chung_tu_theo_nhan_vien()
        {


            f107_V_PHIEU_BAO_HANH frm = new f107_V_PHIEU_BAO_HANH();
            frm.ShowDialog();
        }

    }
}
