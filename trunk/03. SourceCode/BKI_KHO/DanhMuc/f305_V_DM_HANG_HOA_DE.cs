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
using BKI_KHO.US;
using BKI_KHO.DS;
using BKI_KHO.DS.CDBNames;
using System.Collections;
using C1.Win.C1FlexGrid;
namespace BKI_KHO.DanhMuc
{
    public partial class f305_V_DM_HANG_HOA_DE : Form
    {
        public f305_V_DM_HANG_HOA_DE()
        {
            InitializeComponent();
            format_control();
            
        }

        #region Members
        DataEntryFormMode m_e_form_mode;
        US_V_DM_HANG_HOA m_us = new US_V_DM_HANG_HOA();
        DS_V_DM_HANG_HOA m_ds = new DS_V_DM_HANG_HOA();
        ITransferDataRow m_obj_trans;
        #endregion

        #region Public Interface
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void display_for_update(US_V_DM_HANG_HOA ip_us) {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us= ip_us;
            us_obj_2_form();
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            TEN_HANG_CHA = 4,
            MA_HANG = 5,
            TEN_NHOM = 3,
            TEN_NHOM_CHA = 2,
            TEN_DON_VI = 9,
            TEN_HANG_VN = 7,
            GIA_NHAP = 10,
            GIA_BAN = 11,
            MO_TA = 8,
            TRANG_THAI_HANG = 6,
            PART_NUMBER = 12,
            NGUOI_MUON = 13,
            NGAY_MUON = 14,
            NGAY_PHAI_TRA = 15,
            NGUOI_TRA = 16,
            NGAY_TRA = 17,
            TEN_KHO = 1,
        }
        #endregion
        #region Private Methods
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            m_fg.Cols[(int)e_col_Number.TEN_KHO].Visible = false;

            m_fg.Cols[(int)e_col_Number.TEN_NHOM_CHA].Visible = false;

            m_fg.Cols[(int)e_col_Number.TEN_NHOM].Visible = false;
            m_fg.Cols[(int)e_col_Number.TEN_HANG_CHA].Visible = false;
            CGridUtils.AddSearch_Handlers(m_fg);
        }
        
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_HANG_HOA.TEN_KHO, e_col_Number.TEN_KHO);
            v_htb.Add(V_DM_HANG_HOA.TEN_NHOM_CHA, e_col_Number.TEN_NHOM_CHA);
            v_htb.Add(V_DM_HANG_HOA.TEN_NHOM, e_col_Number.TEN_NHOM);
            v_htb.Add(V_DM_HANG_HOA.MA_HANG, e_col_Number.MA_HANG);
            v_htb.Add(V_DM_HANG_HOA.TRANG_THAI_HANG, e_col_Number.TRANG_THAI_HANG);
            v_htb.Add(V_DM_HANG_HOA.TEN_HANG_VN, e_col_Number.TEN_HANG_VN);
            v_htb.Add(V_DM_HANG_HOA.MO_TA, e_col_Number.MO_TA);
            v_htb.Add(V_DM_HANG_HOA.TEN_DON_VI, e_col_Number.TEN_DON_VI);
            v_htb.Add(V_DM_HANG_HOA.GIA_NHAP, e_col_Number.GIA_NHAP);
            v_htb.Add(V_DM_HANG_HOA.GIA_BAN, e_col_Number.GIA_BAN);
            v_htb.Add(V_DM_HANG_HOA.PART_NUMBER, e_col_Number.PART_NUMBER);
            v_htb.Add(V_DM_HANG_HOA.NGUOI_MUON, e_col_Number.NGUOI_MUON);
            v_htb.Add(V_DM_HANG_HOA.NGAY_MUON, e_col_Number.NGAY_MUON);
            v_htb.Add(V_DM_HANG_HOA.NGAY_PHAI_TRA, e_col_Number.NGAY_PHAI_TRA);
            v_htb.Add(V_DM_HANG_HOA.NGUOI_TRA, e_col_Number.NGUOI_TRA);
            v_htb.Add(V_DM_HANG_HOA.NGAY_TRA, e_col_Number.NGAY_TRA);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_DM_HANG_HOA.NewRow());
            return v_obj_trans;
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            m_lbl_kho.Text = m_us.strTEN_KHO;
            load_data_2_cbo();
            load_data_2_grid();
        }
        private void load_data_2_grid(){
            m_us.FillDataset(m_ds, " where ID_KHO = " + m_us.dcID_KHO + " AND ID_HANG_CHA IS NOT NULL AND "+"ID_HANG_CHA = "+m_us.dcID + " ORDER BY " + V_DM_HANG_HOA.TEN_KHO + "," + V_DM_HANG_HOA.TEN_NHOM_CHA + "," + V_DM_HANG_HOA.TEN_NHOM);
            m_fg.Redraw = false;

            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);

            m_fg.AutoSizeCols();
            CControlFormat.wrap_text_cells(m_fg);
            CGridUtils.MakeSoTT(0, m_fg);
            m_fg.Redraw = true;
        }

        private void grid2us_object(US_V_DM_HANG_HOA i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }
        
        private void load_data_2_cbo()
        {
            load_data_2_cboTrangThai();
            load_data_2_cboDonViTinh();
        }
        private void load_data_2_cboDonViTinh() {
            US_DM_DON_VI v_us_dm_don_vi = new US_DM_DON_VI();
            DS_DM_DON_VI v_ds_dm_don_vi = new DS_DM_DON_VI();

            v_us_dm_don_vi.FillDataset(v_ds_dm_don_vi);

            m_cbo_don_vi_tinh.DataSource = v_ds_dm_don_vi.DM_DON_VI;
            m_cbo_don_vi_tinh.ValueMember = DM_DON_VI.ID;
            m_cbo_don_vi_tinh.DisplayMember = DM_DON_VI.TEN;
        }
        private void load_data_2_cboTrangThai()
        {
            US_CM_DM_TU_DIEN v_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_cm_tu_dien = new DS_CM_DM_TU_DIEN();

            v_us_cm_dm_tu_dien.FillDatasetByIdLoaiTuDien(v_ds_cm_tu_dien
                , 15);
            m_cbo_trang_thai.DataSource = v_ds_cm_tu_dien.CM_DM_TU_DIEN;
            m_cbo_trang_thai.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_trang_thai.DisplayMember = CM_DM_TU_DIEN.TEN;
        }

        private void form_2_us_obj()
        {
            m_us.strMA_HANG = m_txt_ma_hang.Text.Trim();
            m_us.strTEN_HANG_VN = m_txt_ten_hang.Text.Trim();
            m_us.dcID_TRANG_THAI = CIPConvert.ToDecimal(m_cbo_trang_thai.SelectedValue);
            m_us.dcGIA_NHAP = CIPConvert.ToDecimal(m_txt_gia_nhap.Text.Trim());
            m_us.dcGIA_BAN = CIPConvert.ToDecimal(m_txt_gia_ban.Text.Trim());
        }
        private void us_obj_2_form()
        {
            m_txt_ma_hang.Text = m_us.strMA_HANG;
            m_txt_ten_hang.Text = m_us.strTEN_HANG_VN;
            m_txt_gia_nhap.Text = CIPConvert.ToStr(m_us.dcGIA_NHAP);
            m_txt_gia_ban.Text = CIPConvert.ToStr(m_us.dcGIA_BAN);

            m_cbo_trang_thai.SelectedValue = m_us.dcID_TRANG_THAI;
            m_cbo_don_vi_tinh.SelectedValue = m_us.dcID_DON_VI;
        }
        private bool is_validate_data_ok()
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

            return true;
        }
        private void save_data()
        {
            if (!is_validate_data_ok())
                return;
            form_2_us_obj();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us.Update();
                    break;
            }
            BaseMessages.MsgBox_Infor("Đã cập nhật thông tin thành công!");
            this.Close();
        }
        #endregion

        #region Events
        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void f305_V_DM_HANG_HOA_DE_Load(object sender, EventArgs e)
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
