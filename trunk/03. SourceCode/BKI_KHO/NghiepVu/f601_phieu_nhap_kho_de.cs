using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_KHO.DS;
using BKI_KHO.DS.CDBNames;
using BKI_KHO.US;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;

namespace BKI_KHO.NghiepVu
{
    public partial class f601_phieu_nhap_kho_de : Form
    {
        public f601_phieu_nhap_kho_de()
        {
            InitializeComponent();
            format_control();
        }

        
        #region Public Interfaces
        public void display(US_V_DM_HANG_HOA i_us)
        {
            m_v_us_dm_hang_hoa = i_us;
            this.ShowDialog();
        }
        #endregion
        US_V_DM_HANG_HOA m_v_us_dm_hang_hoa = new US_V_DM_HANG_HOA();
        #region Members
        
        #endregion
        #region Data Structure
         private enum e_col_Number
        {
            MA_HANG = 1,
            DON_VI_TINH = 4,
            TEN_HANG_VN = 2,
            GIA_NHAP = 5,
            MO_TA = 3,
            PART_NUMBER = 6,
        }
        #endregion
        #region Private Methods
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.ClearDataInGrid(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            set_define_events();
            this.KeyPreview = true;
        }
        private void load_hang_cha(){
            m_txt_ten_hang_cha.Text = m_v_us_dm_hang_hoa.strTEN_HANG_VN;
        }
        private void set_initial_form_load()
        {
            load_hang_cha();
            load_data_2_cbo_don_vi();
        }
        private void load_data_2_cbo_don_vi()
        {
            US_DM_DON_VI v_us_dm_don_vi_tinh = new US_DM_DON_VI();
            DS_DM_DON_VI v_ds_dm_don_vi_tinh = new DS_DM_DON_VI();
            v_us_dm_don_vi_tinh.FillDataset(v_ds_dm_don_vi_tinh);

            m_cbo_dvt.DataSource = v_ds_dm_don_vi_tinh.DM_DON_VI;
            m_cbo_dvt.ValueMember = DM_DON_VI.ID;
            m_cbo_dvt.DisplayMember = DM_DON_VI.TEN;
        }
        private bool check_validate_data_before()
        {
            if (!CValidateTextBox.IsValid(
                m_txt_ma_hang
                , DataType.StringType
                , allowNull.NO
                , true))
                return false;
            if (!CValidateTextBox.IsValid(
                m_txt_ten_hang
                , DataType.StringType
                , allowNull.NO
                , true))
                return false;
            for (int v_cur_row = m_fg.Rows.Fixed; v_cur_row < m_fg.Rows.Count; v_cur_row++)
            {
                if (m_txt_ma_hang.Text == m_fg.Rows[v_cur_row][(int)e_col_Number.MA_HANG].ToString())
                {
                    BaseMessages.MsgBox_Infor("Bạn vừa nhập mã hàng này rồi!");
                    return false;
                }
            }
            return true;
        }
        private void insert_row_2_grid()
        {
            if (!check_validate_data_before()) return;

            m_fg.Rows.Add();

            int cur_row = m_fg.Rows.Count - 1;
            m_fg.Rows[cur_row][(int)e_col_Number.MA_HANG] = m_txt_ma_hang.Text;
            m_fg.Rows[cur_row][(int)e_col_Number.TEN_HANG_VN] = m_txt_ten_hang.Text;
            m_fg.Rows[cur_row][(int)e_col_Number.MO_TA] = m_txt_mo_ta.Text;
            m_fg.Rows[cur_row][(int)e_col_Number.DON_VI_TINH] = m_cbo_dvt.SelectedValue;
            m_fg.Rows[cur_row][(int)e_col_Number.GIA_NHAP] = m_txt_gia_nhap.Text;
            m_fg.Rows[cur_row][(int)e_col_Number.PART_NUMBER] = m_txt_part_number.Text;

            CControlFormat.wrap_text_cells(m_fg);

            save_data();

            
        }
        private void save_data()
        {
            US_V_DM_HANG_HOA v_us = new US_V_DM_HANG_HOA();
            v_us.strMA_HANG = m_txt_ma_hang.Text;
            v_us.strTEN_HANG_VN = m_txt_ten_hang.Text;
            v_us.strMO_TA = m_txt_mo_ta.Text;
            v_us.dcID_DON_VI = CIPConvert.ToDecimal(m_cbo_dvt.SelectedValue);
            v_us.dcGIA_NHAP = CIPConvert.ToDecimal(m_txt_gia_nhap.Text);
            v_us.dcID_TRANG_THAI = 691;
            v_us.dcID_KHO = m_v_us_dm_hang_hoa.dcID_KHO;
            v_us.dcID_HANG_CHA = m_v_us_dm_hang_hoa.dcID;

            v_us.SetID_NHOMNull();
            v_us.SetID_NHOM_CHANull();
            v_us.SetTEN_NHOMNull();
            v_us.SetTEN_NHOM_CHANull();
            v_us.SetID_NHA_CUNG_CAPNull();
            v_us.SetTEN_NHA_CUNG_CAPNull();
            //v_us.SetID_DON_VINull();
            v_us.SetTEN_DON_VINull();
            //v_us.SetTEN_HANG_VNNull();
            v_us.SetTEN_HANG_ENNull();
            v_us.SetANHNull();
            v_us.SetMA_VACHNull();
            //v_us.SetGIA_NHAPNull();
            v_us.SetGIA_BANNull();
            v_us.SetGIA_BAN_LENull();
            //v_us.SetMO_TANull();
            v_us.SetTRANG_THAI_HANGNull();
            //v_us.SetID_TRANG_THAINull();
            v_us.SetPART_NUMBERNull();
            v_us.SetNGUOI_MUONNull();
            v_us.SetNGAY_MUONNull();
            v_us.SetNGAY_PHAI_TRANull();
            v_us.SetNGUOI_TRANull();
            v_us.SetNGAY_TRANull();
            v_us.SetID_LOAI_HANGNull();
            v_us.SetTEN_LOAI_HANGNull();
            //v_us.SetID_KHONull();
            v_us.SetTEN_KHONull();
            v_us.SetLEVEL_MODENull();
            //v_us.SetID_HANG_CHANull();
            v_us.SetTEN_HANG_CHANull();

            v_us.Insert();
        }
        #endregion
        #region Events
        private void set_define_events()
        {
            this.Load += f601_phieu_nhap_kho_de_Load;
            m_cmd_clear_grid.Click += m_cmd_clear_grid_Click;
            m_cmd_nhap_hang.Click += m_cmd_nhap_hang_Click;
            m_cmd_save.Click += m_cmd_save_Click;
        }

        void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                //save_data();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_nhap_hang_Click(object sender, EventArgs e)
        {
            try
            {
                insert_row_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_clear_grid_Click(object sender, EventArgs e)
        {
            try
            {
                if (BaseMessages.MsgBox_Confirm("Bạn có muốn xóa dữ liệu trên phiếu để?") == true)
                    CGridUtils.ClearDataInGrid(m_fg);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f601_phieu_nhap_kho_de_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
