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
    public partial class F200_Nhap_kho : Form
    {
        public F200_Nhap_kho()
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

        private void m_cmd_them_thiet_bi_Click(object sender, EventArgs e)
        {
            F200_Nhap_kho_DE v_f = new F200_Nhap_kho_DE();
            v_f.ShowDialog();
        }
    }
}
