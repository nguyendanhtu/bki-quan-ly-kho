using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;

namespace BKI_KHO.NghiepVu
{
    public partial class f202_nhap_kho_de : Form
    {
        public f202_nhap_kho_de()
        {
            InitializeComponent();
            format_control();
        }

        
        #region Public Interfaces
        public void display()
        {
            this.ShowDialog();
        }
        #endregion
        #region Private Methods
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
        }
        #endregion
    }
}
