///************************************************
/// Generated by: DucVT
/// Date: 13/05/2014 09:53:53
/// Goal: Create Form for RPT_HANG_HOA_XUAT_NHAP
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



	public class f809_RPT_HANG_HOA_XUAT_NHAP : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_dgv;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
		internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
		internal SIS.Controls.Button.SiSButton m_cmd_view;
        private Label m_lbl_title;
        private Label label1;
        private Label m_lbl_tu_ngay;
        private Label label3;
        private Label m_lbl_den_ngay;
        private Label label5;
        private Label m_lbl_nhom_hang;
        private Label m_lbl_so_du_dau;
        private Label m_lbl_so_du_cuoi;
        private Label label2;
        private Label label4;
		private System.ComponentModel.IContainer components;

		public f809_RPT_HANG_HOA_XUAT_NHAP()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f809_RPT_HANG_HOA_XUAT_NHAP));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_dgv = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_lbl_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_lbl_tu_ngay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_lbl_den_ngay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.m_lbl_nhom_hang = new System.Windows.Forms.Label();
            this.m_lbl_so_du_dau = new System.Windows.Forms.Label();
            this.m_lbl_so_du_cuoi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgv)).BeginInit();
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
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(686, 36);
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
            this.m_cmd_insert.Location = new System.Drawing.Point(330, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_insert.TabIndex = 12;
            this.m_cmd_insert.Text = "&Thêm";
            this.m_cmd_insert.Visible = false;
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
            this.m_cmd_update.Location = new System.Drawing.Point(418, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_update.TabIndex = 13;
            this.m_cmd_update.Text = "&Sửa";
            this.m_cmd_update.Visible = false;
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
            this.m_cmd_view.Visible = false;
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
            this.m_cmd_delete.Location = new System.Drawing.Point(506, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_delete.TabIndex = 14;
            this.m_cmd_delete.Text = "&Xoá";
            this.m_cmd_delete.Visible = false;
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
            this.m_cmd_exit.Location = new System.Drawing.Point(594, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_dgv
            // 
            this.m_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_dgv.ColumnInfo = resources.GetString("m_dgv.ColumnInfo");
            this.m_dgv.Location = new System.Drawing.Point(4, 129);
            this.m_dgv.Name = "m_dgv";
            this.m_dgv.Size = new System.Drawing.Size(682, 203);
            this.m_dgv.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_dgv.Styles"));
            this.m_dgv.TabIndex = 20;
            // 
            // m_lbl_title
            // 
            this.m_lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_title.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_title.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_title.Name = "m_lbl_title";
            this.m_lbl_title.Size = new System.Drawing.Size(686, 40);
            this.m_lbl_title.TabIndex = 37;
            this.m_lbl_title.Text = "CHI TIẾT XUẤT NHẬP HÀNG HÓA";
            this.m_lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Từ ngày: ";
            // 
            // m_lbl_tu_ngay
            // 
            this.m_lbl_tu_ngay.AutoSize = true;
            this.m_lbl_tu_ngay.Location = new System.Drawing.Point(250, 50);
            this.m_lbl_tu_ngay.Name = "m_lbl_tu_ngay";
            this.m_lbl_tu_ngay.Size = new System.Drawing.Size(16, 13);
            this.m_lbl_tu_ngay.TabIndex = 39;
            this.m_lbl_tu_ngay.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Đến ngày: ";
            // 
            // m_lbl_den_ngay
            // 
            this.m_lbl_den_ngay.AutoSize = true;
            this.m_lbl_den_ngay.Location = new System.Drawing.Point(480, 50);
            this.m_lbl_den_ngay.Name = "m_lbl_den_ngay";
            this.m_lbl_den_ngay.Size = new System.Drawing.Size(16, 13);
            this.m_lbl_den_ngay.TabIndex = 41;
            this.m_lbl_den_ngay.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Nhóm hàng: ";
            // 
            // m_lbl_nhom_hang
            // 
            this.m_lbl_nhom_hang.AutoSize = true;
            this.m_lbl_nhom_hang.Location = new System.Drawing.Point(86, 72);
            this.m_lbl_nhom_hang.Name = "m_lbl_nhom_hang";
            this.m_lbl_nhom_hang.Size = new System.Drawing.Size(16, 13);
            this.m_lbl_nhom_hang.TabIndex = 43;
            this.m_lbl_nhom_hang.Text = "...";
            // 
            // m_lbl_so_du_dau
            // 
            this.m_lbl_so_du_dau.AutoSize = true;
            this.m_lbl_so_du_dau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_lbl_so_du_dau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_so_du_dau.ForeColor = System.Drawing.Color.Blue;
            this.m_lbl_so_du_dau.Location = new System.Drawing.Point(352, 105);
            this.m_lbl_so_du_dau.Name = "m_lbl_so_du_dau";
            this.m_lbl_so_du_dau.Size = new System.Drawing.Size(18, 15);
            this.m_lbl_so_du_dau.TabIndex = 45;
            this.m_lbl_so_du_dau.Text = "...";
            this.m_lbl_so_du_dau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_lbl_so_du_cuoi
            // 
            this.m_lbl_so_du_cuoi.AutoSize = true;
            this.m_lbl_so_du_cuoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_lbl_so_du_cuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.m_lbl_so_du_cuoi.ForeColor = System.Drawing.Color.Blue;
            this.m_lbl_so_du_cuoi.Location = new System.Drawing.Point(352, 344);
            this.m_lbl_so_du_cuoi.Name = "m_lbl_so_du_cuoi";
            this.m_lbl_so_du_cuoi.Size = new System.Drawing.Size(18, 15);
            this.m_lbl_so_du_cuoi.TabIndex = 47;
            this.m_lbl_so_du_cuoi.Text = "...";
            this.m_lbl_so_du_cuoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Số dư đầu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Số dư đầu:";
            // 
            // f809_RPT_HANG_HOA_XUAT_NHAP
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(686, 409);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_lbl_so_du_cuoi);
            this.Controls.Add(this.m_lbl_so_du_dau);
            this.Controls.Add(this.m_lbl_nhom_hang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.m_lbl_den_ngay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_lbl_tu_ngay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_lbl_title);
            this.Controls.Add(this.m_dgv);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f809_RPT_HANG_HOA_XUAT_NHAP";
            this.Text = "F809 - Chi tiết xuất nhập hàng hóa";
            this.Load += new System.EventHandler(this.f809_RPT_HANG_HOA_XUAT_NHAP_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		#region Public Interface
		public void display(){			
			this.ShowDialog();
		}

        public void display_with_data(US_RPT_XUAT_NHAP_TON ip_us, DateTime ip_tu_ngay, DateTime ip_den_ngay)
        {
            m_tu_ngay = ip_tu_ngay;
            m_den_ngay = ip_den_ngay;
            m_id_nhom_hang = ip_us.dcID;

            m_lbl_nhom_hang.Text = ip_us.strTEN_NHOM_HANG;
            m_lbl_tu_ngay.Text = ip_tu_ngay.ToString(@"dd/MM/yyyy");
            m_lbl_den_ngay.Text = ip_den_ngay.ToString(@"dd/MM/yyyy");
            m_lbl_so_du_dau.Text = ip_us.dcSO_DU_DAU_KY.ToString();
            m_lbl_so_du_cuoi.Text = ip_us.dcSO_DU_CUOI_KY.ToString();

            this.display();
        }
		#endregion

		#region Data Structure
		private enum e_col_Number{
			TEN_HANG_VN = 2
,MA_HANG = 1
,NGAY_XUAT = 4
,NGAY_NHAP = 3

		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_RPT_HANG_HOA_XUAT_NHAP m_ds = new DS_RPT_HANG_HOA_XUAT_NHAP();
		US_RPT_HANG_HOA_XUAT_NHAP m_us = new US_RPT_HANG_HOA_XUAT_NHAP();

        private DateTime m_tu_ngay; 
        private DateTime m_den_ngay;
        private Decimal m_id_nhom_hang;
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201());
			CControlFormat.setC1FlexFormat(m_dgv);
			CGridUtils.AddSave_Excel_Handlers(m_dgv);
            CGridUtils.AddSearch_Handlers(m_dgv);

            m_dgv.Tree.Column = (int)e_col_Number.MA_HANG;
            m_dgv.Tree.Style = TreeStyleFlags.SimpleLeaf;

			set_define_events();
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_dgv);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(RPT_HANG_HOA_XUAT_NHAP.TEN_HANG_VN, e_col_Number.TEN_HANG_VN);
			v_htb.Add(RPT_HANG_HOA_XUAT_NHAP.MA_HANG, e_col_Number.MA_HANG);
			v_htb.Add(RPT_HANG_HOA_XUAT_NHAP.NGAY_XUAT, e_col_Number.NGAY_XUAT);
			v_htb.Add(RPT_HANG_HOA_XUAT_NHAP.NGAY_NHAP, e_col_Number.NGAY_NHAP);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.RPT_HANG_HOA_XUAT_NHAP.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_RPT_HANG_HOA_XUAT_NHAP();
            m_us.FillDataset_By_ID_ThoiGian(m_ds, m_id_nhom_hang, m_tu_ngay, m_den_ngay);
			m_dgv.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_dgv, m_obj_trans);
			m_dgv.Redraw = true;

            m_dgv.Subtotal(
                AggregateEnum.Count
                , 0
                , -1
                , (int)e_col_Number.NGAY_NHAP
                , "Tổng");

            m_dgv.Subtotal(
                AggregateEnum.Count
                , 0
                , -1
                , (int)e_col_Number.NGAY_XUAT
                , "Tổng");
		}
		private void grid2us_object(US_RPT_HANG_HOA_XUAT_NHAP i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_dgv.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_RPT_HANG_HOA_XUAT_NHAP i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_dgv.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_rpt_hang_hoa_xuat_nhap(){			
		//	f809_RPT_HANG_HOA_XUAT_NHAP_DE v_fDE = new  f809_RPT_HANG_HOA_XUAT_NHAP_DE();								
		//	v_fDE.display();
			load_data_2_grid();
		}

		private void update_rpt_hang_hoa_xuat_nhap(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_dgv)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_dgv, m_dgv.Row)) return;			
			grid2us_object(m_us, m_dgv.Row);
		//	f809_RPT_HANG_HOA_XUAT_NHAP_DE v_fDE = new f809_RPT_HANG_HOA_XUAT_NHAP_DE();
		//	v_fDE.display(m_us);
			load_data_2_grid();
		}
				
		private void delete_rpt_hang_hoa_xuat_nhap(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_dgv)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_dgv, m_dgv.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_RPT_HANG_HOA_XUAT_NHAP v_us = new US_RPT_HANG_HOA_XUAT_NHAP();
			grid2us_object(v_us, m_dgv.Row);
			try {			
				v_us.BeginTransaction();    											
				v_us.Delete();                      								
				v_us.CommitTransaction();
				m_dgv.Rows.Remove(m_dgv.Row);				
			}
			catch (Exception v_e) {
				v_us.Rollback();
				CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
					new CDBClientDBExceptionInterpret());
				v_objErrHandler.showErrorMessage();
			}
		}

		private void view_rpt_hang_hoa_xuat_nhap(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_dgv)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_dgv, m_dgv.Row)) return;
			grid2us_object(m_us, m_dgv.Row);
		//	f809_RPT_HANG_HOA_XUAT_NHAP_DE v_fDE = new f809_RPT_HANG_HOA_XUAT_NHAP_DE();			
		//	v_fDE.display(m_us);
		}



		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
			m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
			m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
			m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
            m_dgv.DoubleClick += new EventHandler(m_dgv_DoubleClick);
		}
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f809_RPT_HANG_HOA_XUAT_NHAP_Load(object sender, System.EventArgs e) {
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

		private void m_cmd_insert_Click(object sender, EventArgs e) {
			try{
				insert_rpt_hang_hoa_xuat_nhap();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
				update_rpt_hang_hoa_xuat_nhap();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_rpt_hang_hoa_xuat_nhap();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_view_Click(object sender, EventArgs e) {
			try{
				view_rpt_hang_hoa_xuat_nhap();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

        private void m_dgv_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                // Bật form 602 v_gd_chung_tu và truyền mã hàng vào phần tìm kiếm và search mã hàng đó.
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}

