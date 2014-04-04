using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_KHO.US;
using IP.Core.IPCommon;

namespace BKI_KHO.DanhMuc
{
    public partial class f102_DM_KHACH_HANG_DE : Form
    {

        #region public interface
        public f102_DM_KHACH_HANG_DE()
        {
            InitializeComponent();
        }



        internal void display_for_insert()
        {
            throw new NotImplementedException();
        }

        internal void display_for_update(US.US_DM_KHACH_HANG m_us)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode;
        US_DM_KHACH_HANG m_us_dm_khach_hang = new US_DM_KHACH_HANG();
        #endregion

        #region Events
        #endregion

        #region private method
        private void form_2_us_obj()
        {
        }

        private void us_obj_2_form()
        {
 
        }
        #endregion
    }
}
