///************************************************
/// Generated by: TuyenNT
/// Date: 16/04/2014 01:41:57
/// Goal: Create Form for V_DM_NHOM_HANG
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
using BKI_KHO.DanhMuc;

namespace BKI_KHO
{
    public class f302_V_DM_NHOM_HANG : System.Windows.Forms.Form
    {
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal SIS.Controls.Button.SiSButton m_cmd_view;
        private SaveFileDialog m_sfd_save_cv;
        private OpenFileDialog m_ofd_chon_anh;
        private Panel m_pnl_header;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private TextBox m_txt_tim_kiem;
        private Label m_lbl_tim_kiem;
        private Label m_lbl_title;
        private System.ComponentModel.IContainer components;



        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f302_V_DM_NHOM_HANG));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_sfd_save_cv = new System.Windows.Forms.SaveFileDialog();
            this.m_ofd_chon_anh = new System.Windows.Forms.OpenFileDialog();
            this.m_pnl_header = new System.Windows.Forms.Panel();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.m_lbl_tim_kiem = new System.Windows.Forms.Label();
            this.m_lbl_title = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.m_pnl_header.SuspendLayout();
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
            this.m_pnl_out_place_dm.BackColor = System.Drawing.Color.Lavender;
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_view);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 344);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(639, 36);
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
            this.m_cmd_insert.Location = new System.Drawing.Point(283, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_insert.TabIndex = 12;
            this.m_cmd_insert.Text = "&Thêm";
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
            this.m_cmd_update.Location = new System.Drawing.Point(371, 4);
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
            this.m_cmd_delete.Location = new System.Drawing.Point(459, 4);
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
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(547, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 98);
            this.m_fg.Name = "m_fg";
            this.m_fg.ShowSort = false;
            this.m_fg.Size = new System.Drawing.Size(639, 246);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // m_ofd_chon_anh
            // 
            this.m_ofd_chon_anh.FileName = "openFileDialog1";
            // 
            // m_pnl_header
            // 
            this.m_pnl_header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_pnl_header.Controls.Add(this.m_cmd_search);
            this.m_pnl_header.Controls.Add(this.m_txt_tim_kiem);
            this.m_pnl_header.Controls.Add(this.m_lbl_tim_kiem);
            this.m_pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_pnl_header.Location = new System.Drawing.Point(0, 47);
            this.m_pnl_header.Name = "m_pnl_header";
            this.m_pnl_header.Size = new System.Drawing.Size(639, 51);
            this.m_pnl_header.TabIndex = 23;
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(428, 9);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 22;
            this.m_cmd_search.Text = "Tìm kiếm";
            this.m_cmd_search.Click += new System.EventHandler(this.m_cmd_search_Click);
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.m_txt_tim_kiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.m_txt_tim_kiem.ForeColor = System.Drawing.Color.Gray;
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(165, 14);
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(243, 20);
            this.m_txt_tim_kiem.TabIndex = 1;
            this.m_txt_tim_kiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.m_txt_tim_kiem_MouseClick);
            this.m_txt_tim_kiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_txt_tim_kiem_KeyDown);
            // 
            // m_lbl_tim_kiem
            // 
            this.m_lbl_tim_kiem.AutoSize = true;
            this.m_lbl_tim_kiem.Location = new System.Drawing.Point(95, 17);
            this.m_lbl_tim_kiem.Name = "m_lbl_tim_kiem";
            this.m_lbl_tim_kiem.Size = new System.Drawing.Size(49, 13);
            this.m_lbl_tim_kiem.TabIndex = 21;
            this.m_lbl_tim_kiem.Text = "Tìm kiếm";
            // 
            // m_lbl_title
            // 
            this.m_lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_title.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_title.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_title.Name = "m_lbl_title";
            this.m_lbl_title.Size = new System.Drawing.Size(639, 47);
            this.m_lbl_title.TabIndex = 42;
            this.m_lbl_title.Text = "DANH MỤC NHÓM HÀNG";
            this.m_lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f302_V_DM_NHOM_HANG
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(639, 380);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pnl_header);
            this.Controls.Add(this.m_lbl_title);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f302_V_DM_NHOM_HANG";
            this.Text = "F302 - Quản lý nhóm hàng";
            this.Load += new System.EventHandler(this.f302_V_DM_NHOM_HANG_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.m_pnl_header.ResumeLayout(false);
            this.m_pnl_header.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Public Interface
        public f302_V_DM_NHOM_HANG()
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
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            MO_TA = 5
            ,
            LEVEL_MODE = 4
                ,
            STT = 2
                ,
            TEN_NHOM_CHA = 1
                ,
            TEN = 3

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_DM_NHOM_HANG m_ds = new DS_V_DM_NHOM_HANG();
        US_V_DM_NHOM_HANG m_us = new US_V_DM_NHOM_HANG();

        DS_DM_NHOM_HANG m_ds_dm_nhom_hang = new DS_DM_NHOM_HANG();
        US_DM_NHOM_HANG m_us_dm_nhom_hang = new US_DM_NHOM_HANG();
        string m_str_message_tim_kiem = "Nhập vào thông tin muốn tìm kiếm...";
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.m_lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);

            m_fg.Tree.Column = (int)e_col_Number.TEN;//Cot chua tree
            m_fg.Tree.Style = TreeStyleFlags.Simple;
            m_fg.Cols[(int)e_col_Number.STT].Visible = false;
            m_fg.Cols[(int)e_col_Number.LEVEL_MODE].Visible = false;
            set_define_events();
            this.KeyPreview = true;
        }
        private void set_initial_form_load()
        {
            m_cmd_view.Visible = false;
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_grid();
        }


        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_NHOM_HANG.MO_TA, e_col_Number.MO_TA);
            v_htb.Add(V_DM_NHOM_HANG.LEVEL_MODE, e_col_Number.LEVEL_MODE);
            v_htb.Add(V_DM_NHOM_HANG.STT, e_col_Number.STT);
            v_htb.Add(V_DM_NHOM_HANG.TEN_NHOM_CHA, e_col_Number.TEN_NHOM_CHA);
            v_htb.Add(V_DM_NHOM_HANG.TEN, e_col_Number.TEN);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_DM_NHOM_HANG.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_V_DM_NHOM_HANG();
            m_us.FillDataset(m_ds, " ORDER BY " + V_DM_NHOM_HANG.TEN_NHOM_CHA);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            m_fg.Redraw = true;
            tao_tree();           
            CGridUtils.MakeSoTTofRowNotIsNode(0, m_fg, true);
        }

        private void tao_tree()
        {
            //Group (subtotal) trên grid.          
            m_fg.Subtotal(AggregateEnum.Count
              , 0
              , (int)e_col_Number.TEN_NHOM_CHA   // Group theo cột này
              , (int)e_col_Number.TEN      // Subtotal theo cột này     
              , "{0}"
              );

        }
        private void grid2us_object(US_V_DM_NHOM_HANG i_us, int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_us_dm_nhom_hang = new US_DM_NHOM_HANG((decimal)v_dr.ItemArray[1]);
            //m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
            //i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_DM_NHOM_HANG i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_dm_nhom_hang()
        {
            f302_V_DM_NHOM_HANG_DE v_fDE = new f302_V_DM_NHOM_HANG_DE();
            v_fDE.display_for_insert();
            load_data_2_grid();
        }

        private void update_v_dm_nhom_hang()
        {
            //US_V_DM_NHOM_HANG v_us = new US_V_DM_NHOM_HANG();
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg))
                return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row))
                return;
            grid2us_object(m_us, m_fg.Row);

            f302_V_DM_NHOM_HANG_DE v_fDE = new f302_V_DM_NHOM_HANG_DE();
            v_fDE.display_for_update(m_us_dm_nhom_hang);
            load_data_2_grid();
        }

        private void delete_dm_nhom_hang()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg))
                return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row))
                return;
            if (m_fg.Rows[m_fg.Row].IsNode == true)
            {
                BaseMessages.MsgBox_Error("Không được xóa nhóm cha!");
                return;
            }
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)
                return;
            //US_V_DM_NHOM_HANG v_us = new US_V_DM_NHOM_HANG();
            grid2us_object(m_us, m_fg.Row);
            try
            {
                m_us_dm_nhom_hang.BeginTransaction();
                m_us_dm_nhom_hang.Delete();
                m_us_dm_nhom_hang.CommitTransaction();
                m_fg.Rows.Remove(m_fg.Row);
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                m_us_dm_nhom_hang.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_v_dm_nhom_hang()
        {
            US_V_DM_NHOM_HANG v_us = new US_V_DM_NHOM_HANG();
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg))
                return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row))
                return;
            grid2us_object(m_us, m_fg.Row);
            //	f302_V_DM_NHOM_HANG_DE v_fDE = new f302_V_DM_NHOM_HANG_DE();			
            //	v_fDE.display(m_us);
        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
        }
        #endregion

        #region Events
        //
        //
        //		EVENT HANLDERS
        //
        //
        private void f302_V_DM_NHOM_HANG_Load(object sender, System.EventArgs e)
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

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                insert_dm_nhom_hang();
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
                update_v_dm_nhom_hang();
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
                delete_dm_nhom_hang();
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
                view_v_dm_nhom_hang();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        private void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_tim_kiem.Text == m_str_message_tim_kiem)
                    load_data_2_grid();
                else
                    load_data_2_grid_search();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void load_data_2_grid_search()
        {
 	        m_obj_trans = get_trans_object(m_fg);
            m_ds.Clear();
            m_us.FillDatasetSearch(m_ds, m_txt_tim_kiem.Text);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
           
            tao_tree();
            CGridUtils.MakeSoTTofRowNotIsNode(0, m_fg, true);
            m_fg.Redraw = true;         
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
                m_txt_tim_kiem.Text = "";
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}

