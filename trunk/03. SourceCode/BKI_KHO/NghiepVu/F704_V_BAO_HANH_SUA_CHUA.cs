using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
    public partial class F704_V_BAO_HANH_SUA_CHUA : Form
    {
        public F704_V_BAO_HANH_SUA_CHUA()
        {
            InitializeComponent();
            format_controls();
        }

        #region Data Structure
        private enum e_col_number
        {
            HO_TEN = 1,
            SO_TIEN = 2
        }
        #endregion

        #region Member
        private DataEntryFormMode m_e_form_mode;
        ITransferDataRow m_obj_trans;
        US_GD_CHUNG_TU m_us_gd_chung_tu = new US_GD_CHUNG_TU();
        DS_GD_CHUNG_TU m_ds_gd_chung_tu = new DS_GD_CHUNG_TU();
        US_GD_CHI_TIET_CHUNG_TU m_us_gd_chi_tiet_chung_tu = new US_GD_CHI_TIET_CHUNG_TU();
        DS_GD_CHI_TIET_CHUNG_TU m_ds_gd_chi_tiet_chung_tu = new DS_GD_CHI_TIET_CHUNG_TU();
        US_GD_CHUNG_TU_NHAN_VIEN m_us_gd_chung_tu_nhan_vien = new US_GD_CHUNG_TU_NHAN_VIEN();
        DS_GD_CHUNG_TU_NHAN_VIEN m_ds_gd_chung_tu_nhan_vien = new DS_GD_CHUNG_TU_NHAN_VIEN();
        US_V_BAO_HANH_SUA_CHUA m_us_v_bao_hanh_sua_chua = new US_V_BAO_HANH_SUA_CHUA();
        DS_V_BAO_HANH_SUA_CHUA m_ds_v_bao_hanh_sua_chua = new DS_V_BAO_HANH_SUA_CHUA();
        decimal[] m_array_dc_so_tien = new decimal[10];
        #endregion

        #region Public method
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.Show();
        }

        public void display_for_update(US_GD_CHUNG_TU ip_m_us_gd_chung_tu)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            us_object_2_form(ip_m_us_gd_chung_tu);
            m_us_gd_chung_tu.dcID = ip_m_us_gd_chung_tu.dcID;
            this.Show();
        }
        #endregion

        #region Private method
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_cbo_nhan_vien_to_grid();
        }

        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            var v_htb = new Hashtable();
            v_htb.Add(V_BAO_HANH_SUA_CHUA.HO_TEN, e_col_number.HO_TEN);
            v_htb.Add(V_BAO_HANH_SUA_CHUA.SO_TIEN, e_col_number.SO_TIEN);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds_v_bao_hanh_sua_chua.V_BAO_HANH_SUA_CHUA.NewRow());
            return v_obj_trans;
        }

        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            CGridUtils.ClearDataInGrid(m_fg);
            m_fg.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.None;
            m_fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
            m_fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
            this.MinimizeBox = true;
            this.MaximizeBox = true;
            m_fg.AllowEditing = true;
            this.KeyPreview = true;
        }

        private Hashtable get_mapping_col_nhan_vien()
        {
            US_DM_NHAN_VIEN v_us_dm_nhan_vien = new US_DM_NHAN_VIEN();
            DS_DM_NHAN_VIEN v_ds_dm_nhan_vien = new DS_DM_NHAN_VIEN();
            var v_htb = new Hashtable();
            try
            {
                v_us_dm_nhan_vien.BeginTransaction();
                v_us_dm_nhan_vien.FillDataset(v_ds_dm_nhan_vien, "ORDER BY TEN, HO_DEM");
                v_us_dm_nhan_vien.CommitTransaction();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

            foreach (DataRow v_dr in v_ds_dm_nhan_vien.DM_NHAN_VIEN.Rows)
            {
                v_htb.Add(v_dr[DM_NHAN_VIEN.MA_NHAN_VIEN], v_dr[DM_NHAN_VIEN.HO_DEM] + " " + v_dr[DM_NHAN_VIEN.TEN]);
            }
            return v_htb;
        }

        private void load_cbo_nhan_vien_to_grid()
        {
            m_fg.Cols[(int)e_col_number.HO_TEN].DataMap = get_mapping_col_nhan_vien();
        }

        private bool check_validate_is_ok()
        {
            if (m_txt_ho_ten_khach_hang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng!");
                return false;
            }
            if (m_txt_dien_thoai_khach_hang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại khách hàng!");
                return false;
            }
            if (m_txt_tien_sua_chua.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập số tiền sửa chữa!");
                return false;
            }
            return true;
        }

        private void form_2_us_gd_chung_tu()
        {
            m_us_gd_chung_tu.strGHI_CHU_1 = m_txt_ho_ten_khach_hang.Text;
            m_us_gd_chung_tu.strGHI_CHU_2 = m_txt_dien_thoai_khach_hang.Text;
            m_us_gd_chung_tu.strGHI_CHU_3 = m_txt_dia_chi.Text;
            m_us_gd_chung_tu.strDIEN_GIAI = m_txt_noi_dung.Text;
            m_us_gd_chung_tu.strMA_CT = m_txt_so.Text;
            m_us_gd_chung_tu.datNGAY_CT = m_dat_ngay.Value;
            m_us_gd_chung_tu.dcID_LOAI_CT = 37;
            m_us_gd_chung_tu.dcTONG_TIEN = int.Parse(m_txt_tien_sua_chua.Text.Replace(",", ""));
        }

        private void us_object_2_form(US_GD_CHUNG_TU ip_m_us_gd_chung_tu)
        {
            m_txt_so.Text = ip_m_us_gd_chung_tu.strMA_CT;
            m_dat_ngay.Value = ip_m_us_gd_chung_tu.datNGAY_CT;
            m_txt_ho_ten_khach_hang.Text = ip_m_us_gd_chung_tu.strGHI_CHU_1;
            m_txt_dien_thoai_khach_hang.Text = ip_m_us_gd_chung_tu.strGHI_CHU_2;
            m_txt_dia_chi.Text = ip_m_us_gd_chung_tu.strGHI_CHU_3;
            m_txt_tien_sua_chua.TextDetached = true;
            m_txt_tien_sua_chua.Text = string.Format("{0:0,0}", ip_m_us_gd_chung_tu.dcTONG_TIEN);

            m_us_gd_chi_tiet_chung_tu.FillDatasetByIDChungTu(m_ds_gd_chi_tiet_chung_tu, ip_m_us_gd_chung_tu.dcID);

            m_us_v_bao_hanh_sua_chua.FillDatasetByIDChungTu(m_ds_v_bao_hanh_sua_chua, ip_m_us_gd_chung_tu.dcID);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds_v_bao_hanh_sua_chua, m_fg, get_trans_object(m_fg));
            m_fg.Redraw = true;
        }

        private void save_data()
        {
            if (check_validate_is_ok() == false)
                return;
            form_2_us_gd_chung_tu();
            form_2_us_gd_chi_tiet_chung_tu();
            form_2_us_gd_chung_tu_nhan_vien(DataEntryFormMode.ViewDataState);
            decimal v_dc_total = 0;
            foreach (var v_us in m_array_dc_so_tien)
            {
                if (v_us != null)
                    v_dc_total += v_us;
                else
                    break;
            }
            if (v_dc_total != decimal.Parse(m_txt_tien_sua_chua.Text))
            {
                MessageBox.Show("Tổng số tiền của nhân viên phải bằng với tiền sửa chữa!");
                return;
            }

            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_gd_chung_tu.Insert();
                    m_us_gd_chung_tu.FillDatasetByMaChungTu(m_ds_gd_chung_tu, m_txt_so.Text);
                    m_us_gd_chi_tiet_chung_tu.dcID_CHUNG_TU = decimal.Parse(m_ds_gd_chung_tu.GD_CHUNG_TU.Rows[0]["ID"].ToString());
                    m_us_gd_chi_tiet_chung_tu.Insert();
                    form_2_us_gd_chung_tu_nhan_vien(DataEntryFormMode.InsertDataState);
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_gd_chung_tu.Update();
                    break;
            }
            MessageBox.Show("Phiếu sửa chữa đã được lưu.");
        }

        private void form_2_us_gd_chi_tiet_chung_tu()
        {
            m_us_gd_chi_tiet_chung_tu.strSO_SERI = m_txt_serial.Text;
        }

        private void form_2_us_gd_chung_tu_nhan_vien(DataEntryFormMode v_form_mode)
        {
            for (int v_i_cur_grid_row = m_fg.Rows.Fixed; v_i_cur_grid_row < m_fg.Rows.Count - 1; v_i_cur_grid_row++)
            {
                if (m_fg[v_i_cur_grid_row, (int)e_col_number.HO_TEN] == null)
                    return;
                m_us_gd_chung_tu_nhan_vien.dcSO_TIEN = decimal.Parse(m_fg[v_i_cur_grid_row, (int)e_col_number.SO_TIEN].ToString());

                US_DM_NHAN_VIEN v_us_dm_nhan_vien = new US_DM_NHAN_VIEN();
                DS_DM_NHAN_VIEN v_ds_dm_nhan_vien = new DS_DM_NHAN_VIEN();
                v_us_dm_nhan_vien.FillDatasetSearchByMaNhanVien(v_ds_dm_nhan_vien, m_fg[v_i_cur_grid_row, (int)e_col_number.HO_TEN].ToString());
                m_us_gd_chung_tu_nhan_vien.dcID_NHAN_VIEN = decimal.Parse(v_ds_dm_nhan_vien.DM_NHAN_VIEN.Rows[0]["ID"].ToString());
                m_array_dc_so_tien[v_i_cur_grid_row - 1] = m_us_gd_chung_tu_nhan_vien.dcSO_TIEN;
                if (v_form_mode == DataEntryFormMode.InsertDataState)
                {
                    m_us_gd_chung_tu_nhan_vien.Insert();
                }
            }
        }
        #endregion

        #region Event
        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_danh_sach_Click(object sender, EventArgs e)
        {
            try
            {
                F706_GD_PHIEU_BAO_HANH frm = new F706_GD_PHIEU_BAO_HANH();
                frm.Show();
                Hide();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void F704_V_BAO_HANH_SUA_CHUA_Load(object sender, EventArgs e)
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

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
