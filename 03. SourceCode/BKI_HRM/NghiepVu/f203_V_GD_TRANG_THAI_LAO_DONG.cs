///************************************************
/// Generated by: AnhHT
/// Date: 04/03/2014 01:25:54
/// Goal: Create Form for V_GD_TRANG_THAI_LAO_DONG
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

using BKI_HRM.US;
using BKI_HRM.DS;
using BKI_HRM.DS.CDBNames;

using C1.Win.C1FlexGrid;

namespace BKI_HRM
{



	public class f203_v_gd_trang_thai_lao_dong : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_grv_trang_thai_ld;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
		internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
		internal SIS.Controls.Button.SiSButton m_cmd_view;
        private Label m_lbl_tim_kiem;
        private TextBox m_txt_tim_kiem;
        internal SIS.Controls.Button.SiSButton m_cmd_tim_kiem;
		private System.ComponentModel.IContainer components;

		public f203_v_gd_trang_thai_lao_dong()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f203_v_gd_trang_thai_lao_dong));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_grv_trang_thai_ld = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_lbl_tim_kiem = new System.Windows.Forms.Label();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.m_cmd_tim_kiem = new SIS.Controls.Button.SiSButton();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_trang_thai_ld)).BeginInit();
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_view);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 373);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(840, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert.ImageIndex = 2;
            this.m_cmd_insert.ImageList = this.ImageList;
            this.m_cmd_insert.Location = new System.Drawing.Point(438, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(134, 28);
            this.m_cmd_insert.TabIndex = 12;
            this.m_cmd_insert.Text = "&Thay đổi trạng thái";
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_update.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_update.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_update.ImageIndex = 3;
            this.m_cmd_update.ImageList = this.ImageList;
            this.m_cmd_update.Location = new System.Drawing.Point(572, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_update.TabIndex = 13;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_view
            // 
            this.m_cmd_view.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_view.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_view.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_view.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_view.ImageIndex = 18;
            this.m_cmd_view.ImageList = this.ImageList;
            this.m_cmd_view.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_view.Name = "m_cmd_view";
            this.m_cmd_view.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_view.TabIndex = 21;
            this.m_cmd_view.Text = "Xem";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_delete.ImageIndex = 4;
            this.m_cmd_delete.ImageList = this.ImageList;
            this.m_cmd_delete.Location = new System.Drawing.Point(660, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_delete.TabIndex = 14;
            this.m_cmd_delete.Text = "&Xoá";
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(748, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // m_grv_trang_thai_ld
            // 
            this.m_grv_trang_thai_ld.ColumnInfo = resources.GetString("m_grv_trang_thai_ld.ColumnInfo");
            this.m_grv_trang_thai_ld.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_grv_trang_thai_ld.Location = new System.Drawing.Point(0, 60);
            this.m_grv_trang_thai_ld.Name = "m_grv_trang_thai_ld";
            this.m_grv_trang_thai_ld.Size = new System.Drawing.Size(840, 313);
            this.m_grv_trang_thai_ld.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_grv_trang_thai_ld.Styles"));
            this.m_grv_trang_thai_ld.TabIndex = 20;
            // 
            // m_lbl_tim_kiem
            // 
            this.m_lbl_tim_kiem.AutoSize = true;
            this.m_lbl_tim_kiem.Location = new System.Drawing.Point(114, 25);
            this.m_lbl_tim_kiem.Name = "m_lbl_tim_kiem";
            this.m_lbl_tim_kiem.Size = new System.Drawing.Size(49, 13);
            this.m_lbl_tim_kiem.TabIndex = 21;
            this.m_lbl_tim_kiem.Text = "Tìm kiếm";
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.m_txt_tim_kiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.m_txt_tim_kiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_tim_kiem.ForeColor = System.Drawing.Color.Gray;
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(174, 22);
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(430, 20);
            this.m_txt_tim_kiem.TabIndex = 22;
            this.m_txt_tim_kiem.Text = "Nhập mã nhân viên hoặc họ tên để tìm kiếm";
            this.m_txt_tim_kiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.m_txt_tim_kiem_MouseClick);
            this.m_txt_tim_kiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_txt_tim_kiem_KeyDown);
            this.m_txt_tim_kiem.Leave += new System.EventHandler(this.m_txt_tim_kiem_Leave);
            // 
            // m_cmd_tim_kiem
            // 
            this.m_cmd_tim_kiem.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_tim_kiem.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_tim_kiem.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_tim_kiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_tim_kiem.ImageIndex = 5;
            this.m_cmd_tim_kiem.ImageList = this.ImageList;
            this.m_cmd_tim_kiem.Location = new System.Drawing.Point(629, 17);
            this.m_cmd_tim_kiem.Name = "m_cmd_tim_kiem";
            this.m_cmd_tim_kiem.Size = new System.Drawing.Size(100, 28);
            this.m_cmd_tim_kiem.TabIndex = 23;
            this.m_cmd_tim_kiem.Text = "Tìm kiếm(&S)";
            this.m_cmd_tim_kiem.Click += new System.EventHandler(this.m_cmd_tim_kiem_Click);
            // 
            // f203_v_gd_trang_thai_lao_dong
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.m_cmd_exit;
            this.ClientSize = new System.Drawing.Size(840, 409);
            this.Controls.Add(this.m_cmd_tim_kiem);
            this.Controls.Add(this.m_txt_tim_kiem);
            this.Controls.Add(this.m_lbl_tim_kiem);
            this.Controls.Add(this.m_grv_trang_thai_ld);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f203_v_gd_trang_thai_lao_dong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F203 - Thay đổi trạng thái lao động";
            this.Load += new System.EventHandler(this.f203_v_gd_trang_thai_lao_dong_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_trang_thai_ld)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		#region Public Interface
		public void display(){			
			this.ShowDialog();
		}
		#endregion

		#region Data Structure
		private enum e_col_Number{
			LOAI_QUYET_DINH = 6
,TRANG_THAI_LAO_DONG = 4
,MA_NV = 1
,HO_DEM = 2
,NGAY_HET_HIEU_LUC = 8
,TEN = 3
,MA_QUYET_DINH = 5
,TRANG_THAI_HIEN_TAI = 9
,NGAY_CO_HIEU_LUC = 7

		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_GD_TRANG_THAI_LAO_DONG m_ds = new DS_V_GD_TRANG_THAI_LAO_DONG();
		US_V_GD_TRANG_THAI_LAO_DONG m_us = new US_V_GD_TRANG_THAI_LAO_DONG();
        string m_str_message_tim_kiem = "Nhập mã nhân viên hoặc họ tên để tìm kiếm";
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201());
			CControlFormat.setC1FlexFormat(m_grv_trang_thai_ld);
			CGridUtils.AddSave_Excel_Handlers(m_grv_trang_thai_ld);
            CGridUtils.AddSearch_Handlers(m_grv_trang_thai_ld);
            m_grv_trang_thai_ld.Tree.Column = (int)e_col_Number.MA_NV;
            m_grv_trang_thai_ld.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.SimpleLeaf;
			set_define_events();
			this.KeyPreview = true;
            m_txt_tim_kiem.ForeColor = Color.Gray;
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_grv_trang_thai_ld);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_GD_TRANG_THAI_LAO_DONG.LOAI_QUYET_DINH, e_col_Number.LOAI_QUYET_DINH);
			v_htb.Add(V_GD_TRANG_THAI_LAO_DONG.TRANG_THAI_LAO_DONG, e_col_Number.TRANG_THAI_LAO_DONG);
			v_htb.Add(V_GD_TRANG_THAI_LAO_DONG.MA_NV, e_col_Number.MA_NV);
			v_htb.Add(V_GD_TRANG_THAI_LAO_DONG.HO_DEM, e_col_Number.HO_DEM);
			v_htb.Add(V_GD_TRANG_THAI_LAO_DONG.NGAY_HET_HIEU_LUC, e_col_Number.NGAY_HET_HIEU_LUC);
			v_htb.Add(V_GD_TRANG_THAI_LAO_DONG.TEN, e_col_Number.TEN);
			v_htb.Add(V_GD_TRANG_THAI_LAO_DONG.MA_QUYET_DINH, e_col_Number.MA_QUYET_DINH);
			v_htb.Add(V_GD_TRANG_THAI_LAO_DONG.TRANG_THAI_HIEN_TAI, e_col_Number.TRANG_THAI_HIEN_TAI);
			v_htb.Add(V_GD_TRANG_THAI_LAO_DONG.NGAY_CO_HIEU_LUC, e_col_Number.NGAY_CO_HIEU_LUC);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_GD_TRANG_THAI_LAO_DONG.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_V_GD_TRANG_THAI_LAO_DONG();			
			m_us.FillDataset(m_ds);
			m_grv_trang_thai_ld.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_grv_trang_thai_ld, m_obj_trans);
            m_grv_trang_thai_ld.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
              , 0
              , (int)e_col_Number.MA_NV // chỗ này là tên trường mà mình nhóm
              , (int)e_col_Number.TRANG_THAI_LAO_DONG // chỗ này là tên trường mà mình Count
              , "{0}"
              );
           
			m_grv_trang_thai_ld.Redraw = true;
		}
        private void load_data_2_grid_search()
        {
            m_ds = new DS_V_GD_TRANG_THAI_LAO_DONG();
            m_us.FillDataset_Search(m_ds, m_txt_tim_kiem.Text.Trim());
            m_grv_trang_thai_ld.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_grv_trang_thai_ld, m_obj_trans);
            m_grv_trang_thai_ld.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
              , 0
              , (int)e_col_Number.MA_NV // chỗ này là tên trường mà mình nhóm
              , (int)e_col_Number.TRANG_THAI_LAO_DONG // chỗ này là tên trường mà mình Count
              , "{0}"
              );
           
            m_grv_trang_thai_ld.Redraw = true;
        }
        private void load_custom_source_2_m_txt_tim_kiem()
        {
            
            int count = m_ds.Tables["V_GD_TRANG_THAI_LAO_DONG"].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                DataRow dr = m_ds.Tables["V_GD_TRANG_THAI_LAO_DONG"].Rows[i];
                m_txt_tim_kiem.AutoCompleteCustomSource.Add(dr[0].ToString());
                m_txt_tim_kiem.AutoCompleteCustomSource.Add(dr[1].ToString() + " " + dr[2].ToString());
                m_txt_tim_kiem.AutoCompleteCustomSource.Add(dr[2].ToString());
            }
        }
		private void grid2us_object(US_V_GD_TRANG_THAI_LAO_DONG i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_grv_trang_thai_ld.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_GD_TRANG_THAI_LAO_DONG i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_grv_trang_thai_ld.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_v_gd_trang_thai_lao_dong(){
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_trang_thai_ld)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_trang_thai_ld, m_grv_trang_thai_ld.Row)) return;
            if (m_grv_trang_thai_ld.Rows[m_grv_trang_thai_ld.Row].UserData != null)
            {

                grid2us_object(m_us, m_grv_trang_thai_ld.Row);
                
            }
            else
            {
                grid2us_object(m_us, m_grv_trang_thai_ld.Row + 1);
            }
            f203_v_gd_trang_thai_lao_dong_de v_fDE = new f203_v_gd_trang_thai_lao_dong_de();
            v_fDE.display_for_insert(m_us);
            
		}

		private void update_v_gd_trang_thai_lao_dong(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_trang_thai_ld)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_trang_thai_ld, m_grv_trang_thai_ld.Row)) return;
            if (m_grv_trang_thai_ld.Rows[m_grv_trang_thai_ld.Row].UserData != null)
            {

                grid2us_object(m_us, m_grv_trang_thai_ld.Row);
                f203_v_gd_trang_thai_lao_dong_de v_fDE = new f203_v_gd_trang_thai_lao_dong_de();
                v_fDE.display_for_update(m_us);
                load_data_2_grid();
            }
            else
            {
                MessageBox.Show("Chọn dòng khác để sửa.");
            }
		}
				
		private void delete_v_gd_trang_thai_lao_dong(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_trang_thai_ld)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_trang_thai_ld, m_grv_trang_thai_ld.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_V_GD_TRANG_THAI_LAO_DONG v_us = new US_V_GD_TRANG_THAI_LAO_DONG();
			grid2us_object(v_us, m_grv_trang_thai_ld.Row);
			try {			
				v_us.BeginTransaction();    											
				v_us.Delete();                      								
				v_us.CommitTransaction();
				m_grv_trang_thai_ld.Rows.Remove(m_grv_trang_thai_ld.Row);				
			}
			catch (Exception v_e) {
				v_us.Rollback();
				CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
					new CDBClientDBExceptionInterpret());
				v_objErrHandler.showErrorMessage();
			}
		}

		private void view_v_gd_trang_thai_lao_dong(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_trang_thai_ld)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_trang_thai_ld, m_grv_trang_thai_ld.Row)) return;
			grid2us_object(m_us, m_grv_trang_thai_ld.Row);
		//	f203_v_gd_trang_thai_lao_dong_DE v_fDE = new f203_v_gd_trang_thai_lao_dong_DE();			
		//	v_fDE.display(m_us);
		}
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
			m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
			m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
			m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
		}
		#endregion

        #region Event Hanlders
        private void f203_v_gd_trang_thai_lao_dong_Load(object sender, System.EventArgs e)
        {
            try
            {
                set_initial_form_load();
                load_custom_source_2_m_txt_tim_kiem();
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

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                insert_v_gd_trang_thai_lao_dong();
                if (m_txt_tim_kiem.Text == m_str_message_tim_kiem)
                {
                    m_txt_tim_kiem.Text = "";
                    load_data_2_grid_search();
                    m_txt_tim_kiem.Text = m_str_message_tim_kiem;
                }
                else
                    load_data_2_grid_search();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                update_v_gd_trang_thai_lao_dong();
                if (m_txt_tim_kiem.Text == m_str_message_tim_kiem)
                {
                    m_txt_tim_kiem.Text = "";
                    load_data_2_grid_search();
                    m_txt_tim_kiem.Text = m_str_message_tim_kiem;
                }
                else
                    load_data_2_grid_search();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                delete_v_gd_trang_thai_lao_dong();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_view_Click(object sender, EventArgs e)
        {
            try
            {
                view_v_gd_trang_thai_lao_dong();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_tim_kiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_tim_kiem.Text == m_str_message_tim_kiem)
                {
                    m_txt_tim_kiem.Text = "";
                    load_data_2_grid_search();
                    m_txt_tim_kiem.Text = m_str_message_tim_kiem;
                }
                else
                    load_data_2_grid_search();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_txt_tim_kiem_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    load_data_2_grid_search();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
            private void m_txt_tim_kiem_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (m_txt_tim_kiem.Text == m_str_message_tim_kiem)
                    m_txt_tim_kiem.Text = "";
                m_txt_tim_kiem.ForeColor = Color.Black;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_txt_tim_kiem_Leave(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_tim_kiem.Text == "")
                {
                    m_txt_tim_kiem.Text = m_str_message_tim_kiem;
                    m_txt_tim_kiem.ForeColor = Color.Gray;
                }

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
#endregion

       
        

		

	}
}
