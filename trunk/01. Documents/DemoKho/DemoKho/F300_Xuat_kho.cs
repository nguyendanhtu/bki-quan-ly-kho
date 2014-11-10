using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoKho
{
    public partial class F300_Xuat_kho : Form
    {
        public F300_Xuat_kho()
        {
            InitializeComponent();
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void m_cmd_chon_thiet_bi_xuat_kho_Click(object sender, EventArgs e)
        {
            F300_Xuat_kho_DE v_f = new F300_Xuat_kho_DE();
            v_f.ShowDialog();
        }
    }
}
