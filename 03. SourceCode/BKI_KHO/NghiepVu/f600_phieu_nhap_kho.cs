using BKI_KHO.DS.CDBNames;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_KHO.DS;
using BKI_KHO.US;
using System.Diagnostics;

namespace BKI_KHO
{
    public partial class f600_phieu_nhap_kho : Form
    {
        public f600_phieu_nhap_kho()
        {
            InitializeComponent();
            format_controls();

        }

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        public DialogResult display_detail_chung_tu(US_V_GD_CHUNG_TU i_us_v_gd_chung_tu)
        {
            m_us_v_chung_tu = i_us_v_gd_chung_tu;
            m_dlg_result = DialogResult.Cancel;
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            this.ShowDialog();
            //this.Close();
            return m_dlg_result;

        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            MA_HANG = 3,
            TEN_NHOM = 2,
            TEN_NHOM_CHA = 1,
            DON_VI_TINH = 6,
            TEN_HANG_VN = 4,
            GIA_NHAP = 7,
            MO_TA = 5,
            PART_NUMBER = 8,
            CHI_TIET = 9
        }
        #endregion

        #region Members
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        DialogResult m_dlg_result;

        US_V_GD_CHUNG_TU m_us_v_chung_tu = new US_V_GD_CHUNG_TU();

        US_DM_NHAN_VIEN m_us_nhan_vien = new US_DM_NHAN_VIEN();

        US_DM_KHO m_us_dm_kho = new US_DM_KHO();

        ArrayList _al = new ArrayList();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.m_lbl_ten_phieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            CGridUtils.ClearDataInGrid(m_fg);
            m_fg.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.None;
            m_fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;
            m_fg.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcrossOut;

            m_fg.AllowEditing = true;
            this.KeyPreview = true;

            set_define_events();
        }

        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            DS_V_GD_CHI_TIET_CHUNG_TU v_ds_gd_chitiet_chung_tu = new DS_V_GD_CHI_TIET_CHUNG_TU();
            Hashtable v_htb = new Hashtable();
            //v_htb.Add(V_GD_CHI_TIET_CHUNG_TU.ID_NHOM, e_col_Number.);
            v_htb.Add(V_GD_CHI_TIET_CHUNG_TU.MA_HANG, e_col_Number.MA_HANG);
            v_htb.Add(V_GD_CHI_TIET_CHUNG_TU.TEN_HANG_VN, e_col_Number.TEN_HANG_VN);
            v_htb.Add(V_GD_CHI_TIET_CHUNG_TU.GIA_NHAP, e_col_Number.GIA_NHAP);
            v_htb.Add(V_GD_CHI_TIET_CHUNG_TU.ID_DON_VI_TINH, e_col_Number.DON_VI_TINH);
            v_htb.Add(V_GD_CHI_TIET_CHUNG_TU.TEN_NHOM, e_col_Number.TEN_NHOM);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, v_ds_gd_chitiet_chung_tu.V_GD_CHI_TIET_CHUNG_TU.NewRow());
            return v_obj_trans;
        }

        private void set_initial_form_load()
        {
            load_data_kho();
            load_cbo_on_grid();
            set_btn_detail_grid(m_fg);
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_dat_ngay_lap.Value = CIPConvert.ToStr(CAppContext_201.getCurentDate());
                    m_cmd_insert.Text = "Lập phiếu";
                    m_txt_so_phieu_thu_chi.Text = "PN-";
                    m_txt_nguoi_thu.Enabled = false;
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    us_v_chung_tu_2_form(m_us_v_chung_tu);
                    m_cmd_insert.Text = "Cập nhật phiếu";
                    m_cmd_insert.Enabled = false;
                    m_txt_nguoi_thu.Enabled = false;
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }
        }
        private void load_data_kho()
        {
            DS_DM_KHO v_ds_dm_kho = new DS_DM_KHO();
            m_us_dm_kho.FillDataset(v_ds_dm_kho);

            if (v_ds_dm_kho.DM_KHO.Rows.Count == 0)
            {
                throw new Exception("Bạn cần cập nhật ít nhất một kho trước khi sử dụng ứng dụng này!");
            }

            m_cbo_kho.DataSource = v_ds_dm_kho.DM_KHO;
            m_cbo_kho.DisplayMember = DM_KHO.TEN_KHO;
            m_cbo_kho.ValueMember = DM_KHO.ID;
        }
        private void load_cbo_on_grid()
        {
            m_fg.Cols[(int)e_col_Number.TEN_NHOM_CHA].DataMap = get_mapping_col_nhom_hang_hoa_cha();
            m_fg.Cols[(int)e_col_Number.DON_VI_TINH].DataMap = get_mapping_col_don_vi();
        }

        private Hashtable get_mapping_col_nhom_hang_hoa_cha()
        {
            US_DM_NHOM_HANG v_us_TEN_NHOM = new US_DM_NHOM_HANG();
            DS_DM_NHOM_HANG v_ds_TEN_NHOM = new DS_DM_NHOM_HANG();
            Hashtable v_hst = new Hashtable();
            v_us_TEN_NHOM.FillDataset(v_ds_TEN_NHOM, "where id_nhom_cha is null");
            foreach (DataRow v_dr in v_ds_TEN_NHOM.DM_NHOM_HANG.Rows)
            {
                v_hst.Add(v_dr[DM_NHOM_HANG.ID], v_dr[DM_NHOM_HANG.TEN]);
            }
            return v_hst;
        }
        private Hashtable get_mapping_col_don_vi()
        {
            US_DM_DON_VI v_us_dm_don_vi_tinh = new US_DM_DON_VI();
            DS_DM_DON_VI v_ds_dm_don_vi_tinh = new DS_DM_DON_VI();
            Hashtable v_hst = new Hashtable();
            v_us_dm_don_vi_tinh.FillDataset(v_ds_dm_don_vi_tinh);
            foreach (DataRow v_dr in v_ds_dm_don_vi_tinh.DM_DON_VI.Rows)
            {
                v_hst.Add(v_dr[DM_DON_VI.ID], v_dr[DM_DON_VI.TEN]);
            }
            return v_hst;
        }
        private Hashtable get_mapping_col_nhom_hang_hoa(decimal i_id_nhom_cha)
        {
            US_DM_NHOM_HANG v_us = new US_DM_NHOM_HANG();
            DS_DM_NHOM_HANG v_ds = new DS_DM_NHOM_HANG();
            Hashtable v_hst = new Hashtable();
            v_us.FillDataset(v_ds, "where id_nhom_cha = " + i_id_nhom_cha);
            foreach (DataRow v_dr in v_ds.DM_NHOM_HANG.Rows)
            {
                v_hst.Add(v_dr[DM_NHOM_HANG.ID], v_dr[DM_NHOM_HANG.TEN]);
            }
            return v_hst;
        }
        private void set_btn_detail_grid(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            for (int v_row = i_fg.Rows.Fixed; v_row < i_fg.Rows.Count - 1; v_row++)
            {
                Button v_btn = new Button();
                v_btn.BackColor = SystemColors.Control;
                v_btn.Tag = v_row;
                v_btn.Text = "Chi tiết";

                v_btn.Click += v_btn_Click;
                m_fg.Paint += m_fg_Paint;
                _al.Add(new HostedControl(m_fg, v_btn, v_row, 9));
            }
        }




        private bool check_validate_is_ok()
        {

            if (!CValidateTextBox.IsValid(m_txt_so_phieu_thu_chi, DataType.StringType, allowNull.NO, false))
            {
                BaseMessages.MsgBox_Error("Số chứng từ không được để trống!");
                return false;
            }

            if (!CValidateTextBox.IsValid(m_dat_ngay_lap, DataType.DateType, allowNull.NO, true)) return false;

            //if (m_txt_ten_kho.Text.Length == 0) {
            //    BaseMessages.MsgBox_Error("Bạn phải chọn kho để nhập hàng hóa");
            //    m_txt_ten_kho.Focus();
            //    return false;
            //}


            if (!CValidateTextBox.IsValid(m_txt_tong_tien, DataType.NumberType, allowNull.NO, true)) return false;


            if (CIPConvert.ToDecimal(m_txt_tong_tien.Text) == 0)
            {
                BaseMessages.MsgBox_Error("Số tiền phải lớn hơn 0 (vnđ)");
                m_txt_tong_tien.Focus();
                return false;
            }

            for (int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count - 1; v_i_cur_row++)
            {

                if (m_fg[v_i_cur_row, (int)e_col_Number.TEN_NHOM] == null)
                {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập thông tin nhóm hàng ở một số mặt hàng");
                    m_fg.Select(v_i_cur_row, (int)e_col_Number.TEN_NHOM);
                    return false;
                }
                if (m_fg[v_i_cur_row, (int)e_col_Number.TEN_HANG_VN] == null)
                {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập thông tin tên hàng ở một số mặt hàng");
                    m_fg.Select(v_i_cur_row, (int)e_col_Number.TEN_HANG_VN);
                    return false;
                }
                if (m_fg[v_i_cur_row, (int)e_col_Number.MA_HANG] == null)
                {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập thông tin mã hàng ở một số mặt hàng");
                    m_fg.Select(v_i_cur_row, (int)e_col_Number.MA_HANG);
                    return false;
                }
                if (m_fg[v_i_cur_row, (int)e_col_Number.DON_VI_TINH] == null)
                {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập thông tin đơn vị tính ở một số mặt hàng");
                    m_fg.Select(v_i_cur_row, (int)e_col_Number.DON_VI_TINH);
                    return false;
                }
                if (m_fg[v_i_cur_row, (int)e_col_Number.GIA_NHAP] == null)
                {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập thông tin giá nhập ở một số mặt hàng");
                    m_fg.Select(v_i_cur_row, (int)e_col_Number.GIA_NHAP);
                    return false;
                }
            }

            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    if (!check_so_chung_tu_is_not_exits_db()) return false;
                    break;
            }

            if (!check_value_phieu_detail_is_ok())
                return false;

            if (!check_tong_tien_is_ok()) return false;
            return true;
        }
        private bool check_so_chung_tu_is_not_exits_db()
        {
            US_GD_CHUNG_TU v_gd_chung_tu = new US_GD_CHUNG_TU();
            bool v_bol_trung = false;

            v_bol_trung = v_gd_chung_tu.trung_so_chung_tu(m_txt_so_phieu_thu_chi.Text.Trim());

            if (v_bol_trung)
            {
                BaseMessages.MsgBox_Error("Số chứng từ đã tồn tại, không thể dùng số chứng từ " + m_txt_so_phieu_thu_chi.Text);
                m_txt_so_phieu_thu_chi.Focus();
                return false;
            }
            return true;

        }
        private void form_2_us_obj_chung_tu_nhan_vien(
            US_V_GD_CHUNG_TU i_us_v_chung_tu
            , US_GD_CHUNG_TU_NHAN_VIEN op_us_chung_tu_nv)
        {
            op_us_chung_tu_nv.dcID_CHUNG_TU = i_us_v_chung_tu.dcID;
            op_us_chung_tu_nv.dcID_NHAN_VIEN = m_us_nhan_vien.dcID;
            op_us_chung_tu_nv.dcSO_TIEN = i_us_v_chung_tu.dcTONG_TIEN;
        }
        private bool check_value_phieu_detail_is_ok()
        {

            for (int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row <= m_fg.Rows.Count - 2; v_i_cur_row++)
            {
                if (m_fg[v_i_cur_row, (int)e_col_Number.MA_HANG] == null && m_fg[v_i_cur_row, (int)e_col_Number.GIA_NHAP] == null)
                {
                    m_fg.Rows.Remove(v_i_cur_row);
                }
                else if (m_fg[v_i_cur_row, (int)e_col_Number.MA_HANG] == null || m_fg[v_i_cur_row, (int)e_col_Number.TEN_HANG_VN] == null || m_fg[v_i_cur_row, (int)e_col_Number.GIA_NHAP] == null)
                {
                    BaseMessages.MsgBox_Infor("Các bút toán cần được nhập đầy đủ!");
                    return false;
                }
            }
            return true;
        }
        private bool check_tong_tien_is_ok()
        {
            Debug.Assert(m_txt_tong_tien.Value != null, "function check_tong_tien_is_ok: m_txt_tong_tien.Value phải not null");
            Debug.Assert(!CIPConvert.is_valid_number(m_txt_tong_tien.Value), "function check_tong_tien_is_ok: m_txt_tong_tien.Value phải là số");
            decimal v_dc_tong_tien = CIPConvert.ToDecimal(m_txt_tong_tien.Value);
            if (v_dc_tong_tien != get_tong_tien())
            {
                BaseMessages.MsgBox_Infor("Tổng số tiền chứng từ không bằng tổng số tiền chi tiết");
                return false;
            }
            return true;
        }

        private void save_data_2db()
        {
            if (!check_validate_is_ok())
                return;
            US_DM_HANG_HOA v_us_dm_hang_hoa = new US_DM_HANG_HOA();
            US_GD_CHI_TIET_CHUNG_TU v_us_gd_chi_tiet_chung_tu = new US_GD_CHI_TIET_CHUNG_TU();
            US_GD_CHUNG_TU_NHAN_VIEN v_us_gd_chung_tu_nhan_vien = new US_GD_CHUNG_TU_NHAN_VIEN();
            try
            {
                //1. insert ban ghi vao phieu_thu_chid
                m_us_v_chung_tu.BeginTransaction();
                form_2_us_gd_chung_tu(m_us_v_chung_tu);

                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        m_us_v_chung_tu.Insert();
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        m_us_v_chung_tu.Update();
                        break;
                }

                v_us_gd_chi_tiet_chung_tu.UseTransOfUSObject(m_us_v_chung_tu);
                v_us_dm_hang_hoa.UseTransOfUSObject(m_us_v_chung_tu);
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        {
                            break;
                        }
                    case DataEntryFormMode.UpdateDataState:
                        {
                            //1.xoa phieu detail, hang hoa, nhan vien chung tu
                            m_us_v_chung_tu.Delete_Detail_by_ID_CHUNG_TU(m_us_v_chung_tu.dcID);
                            break;
                        }
                }

                //2.insert phieu detail
                for (int v_i_cur_grid_row = m_fg.Rows.Fixed; v_i_cur_grid_row <= m_fg.Rows.Count - 2; v_i_cur_grid_row++)
                {
                    // insert hang hoa
                    grid_row_2_us_hang_hoa(v_i_cur_grid_row, v_us_dm_hang_hoa);
                    v_us_dm_hang_hoa.Insert();

                    //insert chi tiet chung tu
                    grid_row_2_us_gd_chi_tiet_chung_tu(
                        v_i_cur_grid_row
                        , v_us_gd_chi_tiet_chung_tu
                        , m_us_v_chung_tu);
                    v_us_gd_chi_tiet_chung_tu.dcID_HANG_HOA = v_us_dm_hang_hoa.dcID;
                    v_us_gd_chi_tiet_chung_tu.Insert();

                }
                //3. insert gd chứng từ nhân viên
                v_us_gd_chung_tu_nhan_vien.UseTransOfUSObject(m_us_v_chung_tu);


                form_2_us_obj_chung_tu_nhan_vien(m_us_v_chung_tu, v_us_gd_chung_tu_nhan_vien);
                v_us_gd_chung_tu_nhan_vien.Insert();
                m_us_v_chung_tu.CommitTransaction();
                BaseMessages.MsgBox_Infor("Đã lập phiếu nhập kho thành công.");

            }
            catch (Exception v_e)
            {
                if (m_us_v_chung_tu.is_having_transaction())
                {
                    m_us_v_chung_tu.Rollback();
                }
                throw v_e;
            }

        }
        private void us_v_chung_tu_2_form(US_V_GD_CHUNG_TU i_us_v_gd_chung_tu)
        {
            Debug.Assert(i_us_v_gd_chung_tu != null, "function us_v_chung_tu_2_form: cần khởi tạo us_v_gd_chung_tu");
            Debug.Assert(!i_us_v_gd_chung_tu.IsID_NGUOI_GIAO_DICHNull(), "function us_v_chung_tu_2_form: chứng từ cần có ID_NGUOI_GIAO_DICH");


            //0. Lấy thông tin chung chứng từ
            m_txt_so_phieu_thu_chi.Text = i_us_v_gd_chung_tu.strMA_CT;
            m_dat_ngay_lap.Value = CIPConvert.ToStr(i_us_v_gd_chung_tu.datNGAY_CT);
            m_txt_noi_dung.Text = i_us_v_gd_chung_tu.strDIEN_GIAI;

            // 1. Lấy thông tin kho
            load_data_kho();
            //2. Lấy thông tin nhân viên

            US_DM_NHAN_VIEN v_us_nhan_vien = new US_DM_NHAN_VIEN(i_us_v_gd_chung_tu.dcID_NGUOI_GIAO_DICH);
            m_txt_nguoi_thu.Text = v_us_nhan_vien.strHO_DEM + " " + v_us_nhan_vien.strTEN;

            //3. Lấy thông tin  chi tiết chứng từ
            US_V_GD_CHI_TIET_CHUNG_TU v_us_gd_chi_tiet_chung_tu = new US_V_GD_CHI_TIET_CHUNG_TU();
            DS_V_GD_CHI_TIET_CHUNG_TU v_ds_gd_chi_tiet_chung_tu = new DS_V_GD_CHI_TIET_CHUNG_TU();
            v_us_gd_chi_tiet_chung_tu.FillDataset(i_us_v_gd_chung_tu.dcID, v_ds_gd_chi_tiet_chung_tu);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(v_ds_gd_chi_tiet_chung_tu, m_fg, get_trans_object(m_fg));
            m_fg.Redraw = true;
        }
        private void form_2_us_gd_chung_tu(US_V_GD_CHUNG_TU op_us_gd_chung_tu)
        {
            Debug.Assert(m_txt_tong_tien.Value != null, "function check_tong_tien_is_ok: m_txt_tong_tien.Value phải not null");
            Debug.Assert(!CIPConvert.is_valid_number(m_txt_tong_tien.Text), "function check_tong_tien_is_ok: m_txt_tong_tien.Value phải là số");

            op_us_gd_chung_tu.strDIEN_GIAI = m_txt_noi_dung.Text;
            op_us_gd_chung_tu.dcID_LOAI_CT = 1;//phiếu nhập kho
            op_us_gd_chung_tu.strMA_CT = m_txt_so_phieu_thu_chi.Text;
            op_us_gd_chung_tu.datNGAY_CT = IP.Core.IPSystemAdmin.CAppContext_201.getCurentDate();
            op_us_gd_chung_tu.dcTONG_TIEN = CIPConvert.ToDecimal(m_txt_tong_tien.Text);
            op_us_gd_chung_tu.SetID_TO_CHUC_DICHNull();
            op_us_gd_chung_tu.dcID_TO_CHUC_NGUON = m_us_dm_kho.dcID;
            op_us_gd_chung_tu.dcID_NGUOI_GIAO_DICH = m_us_nhan_vien.dcID;
            op_us_gd_chung_tu.dcID_NGUOI_NHAP = CAppContext_201.getCurrentUserID();
            op_us_gd_chung_tu.datNGAY_NHAP = CAppContext_201.getCurentDate();
            op_us_gd_chung_tu.datNGAY_NHAP_CUOI = CAppContext_201.getCurentDate();
            op_us_gd_chung_tu.SetGHI_CHU_1Null();
            op_us_gd_chung_tu.SetGHI_CHU_2Null();
            op_us_gd_chung_tu.SetGHI_CHU_3Null();

        }

        private void grid_row_2_us_hang_hoa(int i_row, US_DM_HANG_HOA op_us_dm_hang_hoa)
        {
            Debug.Assert(m_fg[i_row, (int)e_col_Number.TEN_NHOM] != null, "function form_2_us_hang_hoa: Nhóm hàng không được null");
            Debug.Assert(m_fg[i_row, (int)e_col_Number.DON_VI_TINH] != null, "function form_2_us_hang_hoa: Nhóm hàng không được null");
            Debug.Assert(m_fg[i_row, (int)e_col_Number.GIA_NHAP] != null, "function form_2_us_hang_hoa: Nhóm hàng không được null");


            op_us_dm_hang_hoa.SetID_NHOM_GOCNull();
            op_us_dm_hang_hoa.dcID_NHOM = CIPConvert.ToDecimal(m_fg[i_row, (int)e_col_Number.TEN_NHOM]);
            op_us_dm_hang_hoa.strMA_HANG = m_fg[i_row, (int)e_col_Number.MA_HANG].ToString();
            op_us_dm_hang_hoa.strTEN_HANG_VN = m_fg[i_row, (int)e_col_Number.TEN_HANG_VN].ToString();
            op_us_dm_hang_hoa.SetTEN_HANG_ENNull();
            op_us_dm_hang_hoa.SetIMAGENull();
            op_us_dm_hang_hoa.SetMO_TANull();
            op_us_dm_hang_hoa.SetID_NHA_CUNG_CAPNull();
            op_us_dm_hang_hoa.SetBARCODENull();
            op_us_dm_hang_hoa.dcID_DON_VI = CIPConvert.ToDecimal(m_fg[i_row, (int)e_col_Number.DON_VI_TINH]);
            op_us_dm_hang_hoa.dcGIA_NHAP = CIPConvert.ToDecimal(m_fg[i_row, (int)e_col_Number.GIA_NHAP]);
            op_us_dm_hang_hoa.SetGIA_BANNull();
            op_us_dm_hang_hoa.SetGIA_BAN_LENull();
            op_us_dm_hang_hoa.dcID_TRANG_THAI = CONST_ID_TRANG_THAI_HANG_HOA.ID_DA_NHAP;//nhap kho
        }

        private void grid_row_2_us_gd_chi_tiet_chung_tu(
            int ip_grid_row
            , US_GD_CHI_TIET_CHUNG_TU op_us_gd_chi_tiet_chung_tu
            , US_V_GD_CHUNG_TU ip_us_v_gd_chung_tu)
        {
            Debug.Assert(m_fg[ip_grid_row, (int)e_col_Number.TEN_NHOM] != null, "function form_2_us_hang_hoa: Nhóm hàng không được null");
            Debug.Assert(m_fg[ip_grid_row, (int)e_col_Number.DON_VI_TINH] != null, "function form_2_us_hang_hoa: Nhóm hàng không được null");
            Debug.Assert(m_fg[ip_grid_row, (int)e_col_Number.GIA_NHAP] != null, "function form_2_us_hang_hoa: Nhóm hàng không được null");
            op_us_gd_chi_tiet_chung_tu.dcID_CHUNG_TU = ip_us_v_gd_chung_tu.dcID;
            op_us_gd_chi_tiet_chung_tu.dcSO_LUONG = 1;
            op_us_gd_chi_tiet_chung_tu.dcGIA_GIAO_DICH = CIPConvert.ToDecimal(m_fg[ip_grid_row, (int)e_col_Number.GIA_NHAP]);
            op_us_gd_chi_tiet_chung_tu.dcID_DON_VI_TINH = CIPConvert.ToDecimal(m_fg[ip_grid_row, (int)e_col_Number.DON_VI_TINH]);
            op_us_gd_chi_tiet_chung_tu.strSO_SERI = CIPConvert.ToStr(m_fg[ip_grid_row, (int)e_col_Number.MA_HANG]);
            op_us_gd_chi_tiet_chung_tu.SetTHOI_GIAN_BHNull();
            op_us_gd_chi_tiet_chung_tu.SetID_DVT_THOI_GIANNull();

        }
        private decimal get_tong_tien()
        {
            decimal v_dc_tong_tien = 0;
            for (int v_i_cur_row = m_fg.Rows.Fixed; v_i_cur_row < m_fg.Rows.Count - 1; v_i_cur_row++)
            {
                if (m_fg[v_i_cur_row, (int)e_col_Number.GIA_NHAP] == null) continue;
                if (!CIPConvert.is_valid_number(m_fg[v_i_cur_row, (int)e_col_Number.GIA_NHAP])) continue;
                v_dc_tong_tien += CIPConvert.ToDecimal(m_fg[v_i_cur_row, (int)e_col_Number.GIA_NHAP]);
            }

            return v_dc_tong_tien;

        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_chon_nhan_vien.Click += m_cmd_chon_nhan_vien_Click;
            this.Load += f600_phieu_nhap_kho_Load;
            m_fg.CellChanged += m_fg_CellChanged;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_xem.Click += m_cmd_xem_Click;
            m_fg.Click += m_fg_Click;
            m_fg.AfterAddRow += m_fg_AfterAddRow;
            m_fg.AfterDeleteRow += m_fg_AfterDeleteRow;
        }

       

       

        

        
        #endregion

        //Event
        void m_fg_AfterDeleteRow(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                set_btn_detail_grid(m_fg);
                m_fg.Rows[m_fg.Rows.Count - 1].Clear(C1.Win.C1FlexGrid.ClearFlags.All);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_fg_AfterAddRow(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                set_btn_detail_grid(m_fg);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
       
        void m_fg_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                foreach (HostedControl hosted in _al)
                {
                    hosted.UpdatePosition();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void v_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Button v_btn = (Button)sender;
                decimal r_selected = CIPConvert.ToDecimal(v_btn.Tag.ToString());
                MessageBox.Show("Hang " + r_selected);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_chon_nhan_vien_Click(object sender, EventArgs e)
        {
            try
            {
                f701_DM_NHAN_VIEN v_frm = new f701_DM_NHAN_VIEN();
                DialogResult v_dlg_result = v_frm.display_select_f250(m_us_nhan_vien);
                if (v_dlg_result == DialogResult.OK)
                {
                    m_txt_nguoi_thu.Text = m_us_nhan_vien.strHO_DEM + " " + m_us_nhan_vien.strTEN;

                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        void m_fg_CellChanged(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                //if (e.Col == (int)e_col_Number.TEN_NHOM_CHA)
                //{
                //   m_fg.Cols[(int)e_col_Number.TEN_NHOM].DataMap = get_mapping_col_nhom_hang_hoa(CIPConvert.ToDecimal(m_fg.Rows[e.Row][e.Col]));
                //}

                //if (e.Col != (int)e_col_Number.GIA_NHAP) return;
                //m_txt_tong_tien.Value = get_tong_tien();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_fg_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_fg.Col == (decimal)e_col_Number.TEN_NHOM && m_fg.Rows[m_fg.Row][m_fg.Col - 1] != null && m_fg.Rows[m_fg.Row][m_fg.Col - 1].ToString() != "")
                {
                    m_fg.Cols[(int)e_col_Number.TEN_NHOM].DataMap = get_mapping_col_nhom_hang_hoa(CIPConvert.ToDecimal(m_fg.Rows[m_fg.Row][m_fg.Col-1]));
                }

                //if (e.Col != (int)e_col_Number.GIA_NHAP) return;
                //m_txt_tong_tien.Value = get_tong_tien();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_cmd_xem_Click(object sender, EventArgs e)
        {
            try
            {
                f602_v_gd_chung_tu v_frm = new f602_v_gd_chung_tu();
                //US_V_GD_CHUNG_TU v_us_chung_tu=new US_V_GD_CHUNG_TU ();
                if (v_frm.select_chung_tu(1, m_us_v_chung_tu) == DialogResult.OK)
                {
                    m_us_nhan_vien = new US_DM_NHAN_VIEN(m_us_v_chung_tu.dcID_NGUOI_GIAO_DICH);

                    us_v_chung_tu_2_form(m_us_v_chung_tu);

                    m_txt_tong_tien.Value = get_tong_tien();
                    m_e_form_mode = DataEntryFormMode.UpdateDataState;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                save_data_2db();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f600_phieu_nhap_kho_Load(object sender, EventArgs e)
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


    }
}
