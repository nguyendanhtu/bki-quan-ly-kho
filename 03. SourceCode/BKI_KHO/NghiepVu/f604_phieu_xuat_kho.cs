using BKI_KHO.DS;
using BKI_KHO.US;
using IP.Core.IPCommon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPSystemAdmin;
using BKI_KHO.DS.CDBNames;
namespace BKI_KHO
{
    public partial class f604_phieu_xuat_kho : Form
    {
        public f604_phieu_xuat_kho()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        public DialogResult display_detail_chung_tu(US_V_GD_CHUNG_TU i_us)
        {
            m_v_us_chung_tu = i_us;
            m_dlg_result = DialogResult.Cancel;
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            this.display();
            m_cmd_insert.Enabled = false;
            
            return m_dlg_result;
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
           
            MA_HANG_HOA = 1
            ,
            TEN_HANG_HOA = 2
                ,
            DON_VI_TINH = 3
                , SO_TIEN = 4
        }
        #endregion

        #region Members
        DialogResult m_dlg_result;
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        decimal tong_tien = 0;
        decimal m_dc_tong_tien = 0;
        bool m_b_load_kho = false;

        US_V_GD_CHUNG_TU m_v_us_chung_tu = new US_V_GD_CHUNG_TU();
        DS_V_DM_KHO m_ds_kho = new DS_V_DM_KHO();
        US_V_DM_KHO m_us_kho = new US_V_DM_KHO();
 
        US_GD_CHUNG_TU m_us_gd_chung_tu = new US_GD_CHUNG_TU();

        US_GD_CHI_TIET_CHUNG_TU m_us_gd_chung_tu_detail = new US_GD_CHI_TIET_CHUNG_TU();
        DS_DM_NHAN_VIEN m_ds_nhan_vien = new DS_DM_NHAN_VIEN();
        US_DM_NHAN_VIEN m_us_nhan_vien = new US_DM_NHAN_VIEN();

        US_GD_CHUNG_TU_NHAN_VIEN m_us_chung_tu_nv = new US_GD_CHUNG_TU_NHAN_VIEN();

        US_DM_HANG_HOA m_us_hang_hoa = new US_DM_HANG_HOA();
        DS_DM_HANG_HOA m_ds_hang_hoa = new DS_DM_HANG_HOA();

        US_V_DM_HANG_HOA m_us_v_hang_hoa = new US_V_DM_HANG_HOA();
        DS_V_DM_HANG_HOA m_ds_v_hang_hoa = new DS_V_DM_HANG_HOA();

        DS_DM_DON_VI m_ds_don_vi = new DS_DM_DON_VI();
        US_DM_DON_VI m_us_don_vi = new US_DM_DON_VI();

        DataTable m_dt = new DataTable();
        List<string> m_lst_id_hang_hoa = new List<string>();

        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.m_lbl_ten_phieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = true;
            this.MaximizeBox = true;
            set_define_events();
            //m_txt_nguoi_thu.Enabled = false;
            this.KeyPreview = true;
            
            m_txt_so_phieu_thu_chi.Text = "PX-";
        }
        private void set_initial_form_load()
        {
            design_data_table();
            gridControl1.DataSource = m_dt;
            load_data_2_custom_source_for_txt_nhan_vien();
            load_data_kho();
            m_dat_ngay_lap.Value = CIPConvert.ToStr(CAppContext_201.getCurentDate());
        }

        private void design_data_table()
        {
            m_dt.Columns.Add(V_DM_HANG_HOA.GIA_BAN);
            m_dt.Columns.Add(V_DM_HANG_HOA.ID);
            m_dt.Columns.Add(V_DM_HANG_HOA.MA_HANG);
            m_dt.Columns.Add(V_DM_HANG_HOA.TEN_HANG_VN);
            m_dt.Columns.Add(V_DM_HANG_HOA.TEN_NHOM);
            m_dt.Columns.Add(V_DM_HANG_HOA.TEN_NHOM_CHA);
            m_dt.Columns.Add(V_DM_HANG_HOA.TEN_DON_VI);
        }

        private void load_data_2_custom_source_for_txt_nhan_vien()
        {
            m_us_nhan_vien.FillDataset(m_ds_nhan_vien);
            foreach (DataRow item in m_ds_nhan_vien.Tables[0].Rows)
            {
                m_txt_nguoi_thu.AutoCompleteCustomSource.Add(item[DM_NHAN_VIEN.HO_DEM].ToString() + " " + item[DM_NHAN_VIEN.TEN].ToString() + "-" + item[DM_NHAN_VIEN.MA_NHAN_VIEN].ToString());
            }
        }

        private Hashtable get_mapping_col_don_vi()
        {

            Hashtable v_hst = new Hashtable();
            m_ds_don_vi.EnforceConstraints = false;
            try
            {
                m_us_don_vi.FillDataset(m_ds_don_vi);

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
            foreach (DataRow v_dr in m_ds_don_vi.DM_DON_VI.Rows)
            {
                v_hst.Add(v_dr[DM_DON_VI.ID], v_dr[DM_DON_VI.TEN]);
            }
            return v_hst;
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            DS_V_GD_CHI_TIET_CHUNG_TU v_ds_gd_chitiet_chung_tu = new DS_V_GD_CHI_TIET_CHUNG_TU();
            Hashtable v_htb = new Hashtable();
            
            v_htb.Add(V_GD_CHI_TIET_CHUNG_TU.MA_HANG, e_col_Number.MA_HANG_HOA);
            v_htb.Add(V_GD_CHI_TIET_CHUNG_TU.TEN_HANG_VN, e_col_Number.TEN_HANG_HOA);
            v_htb.Add(V_GD_CHI_TIET_CHUNG_TU.GIA_NHAP, e_col_Number.SO_TIEN);
            v_htb.Add(V_GD_CHI_TIET_CHUNG_TU.ID_DON_VI_TINH, e_col_Number.DON_VI_TINH);


            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, v_ds_gd_chitiet_chung_tu.V_GD_CHI_TIET_CHUNG_TU.NewRow());
            return v_obj_trans;
        }
        private bool check_validate_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_so_phieu_thu_chi, DataType.StringType, allowNull.NO, false))
            {
                BaseMessages.MsgBox_Error("Số chứng từ không được để trống!");
                return false;
            }

            if (!CValidateTextBox.IsValid(m_dat_ngay_lap, DataType.DateType, allowNull.NO, true)) return false;


            if (CIPConvert.ToDecimal(m_txt_tong_tien.Text) == 0)
            {
                BaseMessages.MsgBox_Error("Số tiền phải lớn hơn 0 (vnđ)");
                m_txt_tong_tien.Focus();
                return false;
            }            
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
        //private bool check_ma_hang_hoa()
        //{
        //    US_DM_HANG_HOA v_hang_hoa = new US_DM_HANG_HOA();
        //    bool v_bol_trung = false;
        //    for (int i = 1; i < m_fg.Rows.Count - 1; i++)
        //    {
        //        v_bol_trung = v_hang_hoa.exit_hang_hoa_yn(CIPConvert.ToStr(m_fg[i, (int)e_col_Number.MA_HANG_HOA]));

        //        if (!v_bol_trung)
        //        {
        //            BaseMessages.MsgBox_Confirm("Kiểm tra lại mã hàng hóa");
        //            m_fg.Select(i, (int)e_col_Number.MA_HANG_HOA);
        //            return false;
        //        }
        //    }
        //    return true;

        //}
        
        private void form_2_us_obj_chung_tu_nhan_vien(US_GD_CHUNG_TU i_us_chung_tu)
        {
            m_us_chung_tu_nv.dcID_CHUNG_TU = i_us_chung_tu.dcID;
            m_us_chung_tu_nv.dcID_NHAN_VIEN = i_us_chung_tu.dcID_NGUOI_GIAO_DICH;
            m_us_chung_tu_nv.dcSO_TIEN = i_us_chung_tu.dcTONG_TIEN;
        }
        
        private void form_2_us_gd_chung_tu()
        {
            //GD chứng từ
            string v_str_ngay_thu_chi = CIPConvert.ToStr(m_dat_ngay_lap.Value, "dd/MM/yyyy");
            m_us_gd_chung_tu.strDIEN_GIAI = m_txt_noi_dung.Text;
            m_us_gd_chung_tu.dcID_LOAI_CT = 2;//phiếu xuất kho
            m_us_gd_chung_tu.strMA_CT = m_txt_so_phieu_thu_chi.Text;
            m_us_gd_chung_tu.datNGAY_CT = IP.Core.IPSystemAdmin.CAppContext_201.getCurentDate();
            m_us_gd_chung_tu.dcTONG_TIEN = CIPConvert.ToDecimal(m_txt_tong_tien.Text);
            m_us_gd_chung_tu.SetID_TO_CHUC_DICHNull();
            m_us_gd_chung_tu.dcID_TO_CHUC_NGUON = m_us_kho.dcID;
            m_us_gd_chung_tu.dcID_NGUOI_GIAO_DICH = m_us_nhan_vien.dcID;
            m_us_gd_chung_tu.dcID_NGUOI_NHAP = CAppContext_201.getCurrentUserID();
            m_us_gd_chung_tu.datNGAY_NHAP = CAppContext_201.getCurentDate();
            m_us_gd_chung_tu.datNGAY_NHAP_CUOI = CAppContext_201.getCurentDate();
            m_us_gd_chung_tu.SetGHI_CHU_1Null();
            m_us_gd_chung_tu.SetGHI_CHU_2Null();
            m_us_gd_chung_tu.SetGHI_CHU_3Null();
        }
        private void load_data_kho()
        {
            try
            {
                m_us_kho.FillDataset(m_ds_kho);
                m_cbo_kho.DataSource = m_ds_kho.Tables[0];
                m_cbo_kho.DisplayMember = DM_KHO.TEN_KHO;
                m_cbo_kho.ValueMember = DM_KHO.ID;
                m_b_load_kho = true;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }


        }
       
        private void set_define_events()
        {
            m_cmd_exit.Click += m_cmd_exit_Click;
            //m_cmd_chon_kho.Click += m_cmd_chon_kho_Click;
            this.Load += f604_phieu_xuat_kho_Load;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_xem.Click += m_cmd_xem_Click;
        }

        void f604_phieu_xuat_kho_Load(object sender, EventArgs e)
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

        void m_cmd_exit_Click(object sender, EventArgs e)
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
        void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_dc_id_chung_tu = tao_phieu();
                tao_chi_tiet_phieu(v_dc_id_chung_tu);
                tao_chi_tiet_nhan_vien(v_dc_id_chung_tu);
                MessageBox.Show("Lập phiếu xuất thành công");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void tao_chi_tiet_nhan_vien(decimal ip_dc_id_chung_tu)
        {
            US_GD_CHUNG_TU_NHAN_VIEN v_us = new US_GD_CHUNG_TU_NHAN_VIEN();
            v_us.dcID_CHUNG_TU = ip_dc_id_chung_tu;
            var v_str_ma_nv = m_txt_nguoi_thu.Text.Split('-')[1];
            DataTable v_dt = m_ds_nhan_vien.Tables[0];
            DataRow[] dr = v_dt.Select("MA_NHAN_VIEN = '" + v_str_ma_nv + "'");
            v_us.dcID_NHAN_VIEN =CIPConvert.ToDecimal(dr[0]["ID"]);
            v_us.dcSO_TIEN = 0;
            v_us.Insert();
        }

        private void tao_chi_tiet_phieu(decimal ip_dc_id_chung_tu)
        {
            foreach (string item in m_lst_id_hang_hoa)
            {
                DataTable v_dt = m_ds_v_hang_hoa.Tables[0] ;
                DataRow[] dr = v_dt.Select("ID = " + item);
                US_GD_CHI_TIET_CHUNG_TU v_us = new US_GD_CHI_TIET_CHUNG_TU();
                v_us.dcID_CHUNG_TU = ip_dc_id_chung_tu;
                v_us.dcID_HANG_HOA = CIPConvert.ToDecimal(item);
                v_us.dcSO_LUONG = 1;
                v_us.dcID_DON_VI_TINH = CIPConvert.ToDecimal(dr[0][V_DM_HANG_HOA.ID_DON_VI].ToString());
                v_us.Insert();
            }
        }

        private decimal tao_phieu()
        {
            US_GD_CHUNG_TU v_us_gd_ct = new US_GD_CHUNG_TU();
            v_us_gd_ct.dcID_LOAI_CT = 2;
            v_us_gd_ct.strMA_CT = m_txt_so_phieu_thu_chi.Text;
            v_us_gd_ct.datNGAY_CT = CIPConvert.ToDatetime(m_dat_ngay_lap.Value);
            v_us_gd_ct.strDIEN_GIAI = m_txt_noi_dung.Text;
            v_us_gd_ct.dcTONG_TIEN = 0;
            v_us_gd_ct.datNGAY_NHAP = DateTime.Now.Date;
            v_us_gd_ct.datNGAY_NHAP_CUOI = DateTime.Now.Date;
            v_us_gd_ct.Insert();
            return v_us_gd_ct.dcID;
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

        //void m_cmd_chon_kho_Click(object sender, EventArgs e)
        //{
        //    //f110_V_DM_KHO v_frm = new f110_V_DM_KHO();
        //    //DialogResult v_dlg_result = v_frm.display_select_f250(m_us_kho);
        //    //if (v_dlg_result == DialogResult.OK)
        //    //{
        //    //    m_txt_ten_kho.Text = m_us_kho.strMA_KHO;
        //    //}

        //    f701_DM_NHAN_VIEN v_frm = new f701_DM_NHAN_VIEN();
        //    DialogResult v_dlg_result = v_frm.display_select_f250(m_us_nhan_vien);
        //    if (v_dlg_result == DialogResult.OK)
        //    {
        //        m_txt_nguoi_thu.Text = m_us_nhan_vien.strHO_DEM + " " + m_us_nhan_vien.strTEN;
        //        m_txt_nguoi_thu.Enabled = false;
        //    }
        //}
        void m_cmd_xem_Click(object sender, EventArgs e)
        {
            f602_v_gd_chung_tu v_frm = new f602_v_gd_chung_tu();
            if (v_frm.select_chung_tu(2, m_v_us_chung_tu) == DialogResult.OK)
            {
                m_e_form_mode = DataEntryFormMode.UpdateDataState;
            }
        }

        #endregion

        private void m_cbo_kho_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal selectedValue;
            if (m_b_load_kho)
            {
                selectedValue = CIPConvert.ToDecimal(m_cbo_kho.SelectedValue);
            }
            else
            {
                selectedValue = 1;
            }

            m_us_v_hang_hoa.FillDatasetByIdKho(selectedValue, m_ds_v_hang_hoa);
            m_cbo_ma_hang_hoa.DisplayMember = DM_HANG_HOA.MA_HANG;
            m_cbo_ma_hang_hoa.ValueMember = DM_HANG_HOA.ID;
            m_cbo_ma_hang_hoa.DataSource = m_ds_v_hang_hoa.Tables[0];
        }

        private void m_cbo_ma_hang_hoa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                them_hang_hoa_vao_grid();
            }
        }

        private void them_hang_hoa_vao_grid() {
            DataTable v_dt = m_ds_v_hang_hoa.Tables[0] ;
            DataRow[] dr = v_dt.Select("ID = " + m_cbo_ma_hang_hoa.SelectedValue.ToString());
            DataRow v_dr = m_dt.NewRow();
            v_dr[V_DM_HANG_HOA.ID] = dr[0][V_DM_HANG_HOA.ID];
            v_dr[V_DM_HANG_HOA.MA_HANG] = dr[0][V_DM_HANG_HOA.MA_HANG];
            v_dr[V_DM_HANG_HOA.TEN_HANG_VN] = dr[0][V_DM_HANG_HOA.TEN_HANG_VN];
            v_dr[V_DM_HANG_HOA.TEN_DON_VI] = dr[0][V_DM_HANG_HOA.TEN_DON_VI];
            v_dr[V_DM_HANG_HOA.TEN_NHOM_CHA] = dr[0][V_DM_HANG_HOA.TEN_NHOM_CHA];
            v_dr[V_DM_HANG_HOA.TEN_NHOM] = dr[0][V_DM_HANG_HOA.TEN_NHOM];
            v_dr[V_DM_HANG_HOA.GIA_BAN] = dr[0][V_DM_HANG_HOA.GIA_BAN];
            m_dt.Rows.Add(v_dr);
            m_lst_id_hang_hoa.Add(m_cbo_ma_hang_hoa.SelectedValue.ToString());
            gridControl1.DataSource = m_dt;
        }
    }
}