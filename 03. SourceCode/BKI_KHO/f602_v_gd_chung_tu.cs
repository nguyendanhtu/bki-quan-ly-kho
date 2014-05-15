///************************************************
/// Generated by: tuyendv
/// Date: 05/05/2014 12:08:03
/// Goal: Create Form for V_GD_CHUNG_TU
///************************************************


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

namespace BKI_KHO
{



	public class f602_v_gd_chung_tu : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private Panel panel1;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private TextBox m_txt_tim_kiem;
        private Label label2;
        private Label m_lbl_title;
        internal SIS.Controls.Button.SiSButton m_cmd_xoa_chung_tu;
		private System.ComponentModel.IContainer components;

		public f602_v_gd_chung_tu()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			format_controls();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f602_v_gd_chung_tu));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_lbl_title = new System.Windows.Forms.Label();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_cmd_xoa_chung_tu = new SIS.Controls.Button.SiSButton();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xoa_chung_tu);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 563);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(962, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(870, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 123);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(962, 440);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_lbl_title);
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.m_txt_tim_kiem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 123);
            this.panel1.TabIndex = 21;
            // 
            // m_lbl_title
            // 
            this.m_lbl_title.AutoSize = true;
            this.m_lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_title.Location = new System.Drawing.Point(271, 26);
            this.m_lbl_title.Name = "m_lbl_title";
            this.m_lbl_title.Size = new System.Drawing.Size(495, 31);
            this.m_lbl_title.TabIndex = 31;
            this.m_lbl_title.Text = "DANH SÁCH PHIẾU XUẤT NHẬP KHO";
            this.m_lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(622, 73);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(82, 28);
            this.m_cmd_search.TabIndex = 30;
            this.m_cmd_search.Text = "Tìm kiếm";
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(243, 73);
            this.m_txt_tim_kiem.Multiline = true;
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(350, 28);
            this.m_txt_tim_kiem.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tìm kiếm";
            // 
            // m_cmd_xoa_chung_tu
            // 
            this.m_cmd_xoa_chung_tu.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_xoa_chung_tu.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_xoa_chung_tu.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_xoa_chung_tu.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xoa_chung_tu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_xoa_chung_tu.ImageIndex = 4;
            this.m_cmd_xoa_chung_tu.ImageList = this.ImageList;
            this.m_cmd_xoa_chung_tu.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_xoa_chung_tu.Name = "m_cmd_xoa_chung_tu";
            this.m_cmd_xoa_chung_tu.Size = new System.Drawing.Size(120, 28);
            this.m_cmd_xoa_chung_tu.TabIndex = 12;
            this.m_cmd_xoa_chung_tu.Text = "Xóa chứng từ";
            // 
            // f602_v_gd_chung_tu
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(962, 599);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f602_v_gd_chung_tu";
            this.Text = "F602 - DANH SACH PHIEU NHAP KHO";
            this.Load += new System.EventHandler(this.f602_v_gd_chung_tu_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#region Public Interface
        public void display(decimal ip_id_loai_ct)
        {
            id_loai_ct = ip_id_loai_ct;
            this.ShowDialog();
        }
        public DialogResult select_chung_tu(decimal ip_id_loai_ct ,US_V_GD_CHUNG_TU i_us)
        {
            m_dlg_result = DialogResult.Cancel;
           id_loai_ct = ip_id_loai_ct;
            m_us = i_us;
			this.ShowDialog();
            return m_dlg_result;
		}
		#endregion

		#region Data Structure
		private enum e_col_Number{
            STT=0,
			GIA_NHAP = 10
,GHI_CHU_1 = 5
,TEN_HANG_VN = 8
,DIEN_GIAI = 6
,GIA_GIAO_DICH = 12
,TEN_HANG_EN = 9
,MA_CT = 3
,TEN_LOAI_CT = 2
,MA_HANG = 7
,SO_SERI = 13
,MA_LOAI_CT = 1
,NGAY_CT = 4
,SO_LUONG = 11

		}			
		#endregion

		#region Members
        decimal id_loai_ct;
        DialogResult m_dlg_result = DialogResult.Cancel;
        DataEntryFormMode m_e_form_mode;
		ITransferDataRow m_obj_trans;		
		DS_V_GD_CHUNG_TU m_ds = new DS_V_GD_CHUNG_TU();
		US_V_GD_CHUNG_TU m_us = new US_V_GD_CHUNG_TU();

        
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201());
			CControlFormat.setC1FlexFormat(m_fg);
			CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            this.MaximizeBox = true;
            this.MinimizeBox = true;
			set_define_events();
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
            load_data_2_grid(id_loai_ct);		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_GD_CHUNG_TU.GIA_NHAP, e_col_Number.GIA_NHAP);
			v_htb.Add(V_GD_CHUNG_TU.GHI_CHU_1, e_col_Number.GHI_CHU_1);
			v_htb.Add(V_GD_CHUNG_TU.TEN_HANG_VN, e_col_Number.TEN_HANG_VN);
			v_htb.Add(V_GD_CHUNG_TU.DIEN_GIAI, e_col_Number.DIEN_GIAI);
			v_htb.Add(V_GD_CHUNG_TU.GIA_GIAO_DICH, e_col_Number.GIA_GIAO_DICH);
			v_htb.Add(V_GD_CHUNG_TU.TEN_HANG_EN, e_col_Number.TEN_HANG_EN);
			v_htb.Add(V_GD_CHUNG_TU.MA_CT, e_col_Number.MA_CT);
			v_htb.Add(V_GD_CHUNG_TU.TEN_LOAI_CT, e_col_Number.TEN_LOAI_CT);
			v_htb.Add(V_GD_CHUNG_TU.MA_HANG, e_col_Number.MA_HANG);
			v_htb.Add(V_GD_CHUNG_TU.SO_SERI, e_col_Number.SO_SERI);
			v_htb.Add(V_GD_CHUNG_TU.MA_LOAI_CT, e_col_Number.MA_LOAI_CT);
			v_htb.Add(V_GD_CHUNG_TU.NGAY_CT, e_col_Number.NGAY_CT);
			v_htb.Add(V_GD_CHUNG_TU.SO_LUONG, e_col_Number.SO_LUONG);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_GD_CHUNG_TU.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(decimal ip_id_loai_chung_tu){						
			m_ds = new DS_V_GD_CHUNG_TU();
            if (m_txt_tim_kiem.Text.Length>0)
            m_us.Filldataset_by_search(ip_id_loai_chung_tu, m_txt_tim_kiem.Text, m_ds);    //.FillDataset(m_ds, "where ID_LOAI_CT=" + ip_id_loai_chung_tu);
			else
                m_us.FillDataset(m_ds,"where ID_LOAI_CT="+ip_id_loai_chung_tu);
            m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
			m_fg.Redraw = true;
            make_stt();
		}
		private void grid2us_object(US_V_GD_CHUNG_TU i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_GD_CHUNG_TU i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}

        private void make_stt()
        {
            int v_dc_stt = 0;
            for (int i_stt = 1; i_stt <= m_fg.Rows.Count - 1; i_stt++)
            {
                if (m_fg.Rows[i_stt].IsNode)
                {
                    v_dc_stt = 0;
                }
                else
                {
                    v_dc_stt = v_dc_stt + 1;
                    m_fg[i_stt, (int)e_col_Number.STT] = v_dc_stt;
                }
            }
        }
		
			
		private void delete_v_gd_chung_tu(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_V_GD_CHUNG_TU v_us = new US_V_GD_CHUNG_TU();
			grid2us_object(v_us, m_fg.Row);
           //xóa bang gd_chung_tu,gd_chi_tiet_chung_tu,gd_chung_tu_nhan_vien
           // v_us.Delete();
			try {			
				v_us.BeginTransaction();
                v_us.delete_v_gd_chung_tu(v_us.dcID_CHUNG_TU, v_us.dcID_CHUNG_TU_DETAIL, v_us.dcID_NGUOI_NHAP);                  								
				v_us.CommitTransaction();
				m_fg.Rows.Remove(m_fg.Row);				
			}
			catch (Exception v_e) {
				v_us.Rollback();
				CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
					new CDBClientDBExceptionInterpret());
				v_objErrHandler.showErrorMessage();
			}
		}

		
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_search.Click += m_cmd_search_Click;
            m_cmd_xoa_chung_tu.Click += m_cmd_xoa_chung_tu_Click;
            m_fg.DoubleClick += m_fg_DoubleClick;
		}

        void m_cmd_xoa_chung_tu_Click(object sender, EventArgs e)
        {
            try
            {
                delete_v_gd_chung_tu();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid(id_loai_ct);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_fg_DoubleClick(object sender, EventArgs e)
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            m_dlg_result = DialogResult.OK;
            this.Close();
            //if (m_e_form_mode == DataEntryFormMode.SelectDataState)
            //{
            //    m_dlg_result = DialogResult.OK;
            //    this.Close();
            //}
            if (m_us.dcID_LOAI_CT == 1)
            {
                this.Close();
                f600_phieu_nhap_kho v_frm = new f600_phieu_nhap_kho();
                v_frm.display_detail_chung_tu(m_us);

            }
            else
            {
                f604_phieu_xuat_kho v_frm = new f604_phieu_xuat_kho();
                v_frm.display_detail_chung_tu(m_us);
            }
            //this.Close();
        }

        void m_fg_Click(object sender, EventArgs e)
        {
            

        }
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f602_v_gd_chung_tu_Load(object sender, System.EventArgs e) {
			try{
				set_initial_form_load();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		
		}

		private void m_cmd_exit_Click(object sender, EventArgs e) {
			try{
				this.Close();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

	}
}

