namespace BKI_KHO.DanhMuc
{
    partial class f303_DM_DON_VI_DE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f303_DM_DON_VI_DE));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_save = new SIS.Controls.Button.SiSButton();
            this.m_cmd_refresh = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_lbl_ma_don_vi = new System.Windows.Forms.Label();
            this.m_txt_ma_don_vi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_txt_ten_don_vi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_txt_ghi_chu = new System.Windows.Forms.TextBox();
            this.m_pnl_out_place_dm.SuspendLayout();
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_save);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_refresh);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 225);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(454, 36);
            this.m_pnl_out_place_dm.TabIndex = 22;
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_save.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_save.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_save.ImageIndex = 10;
            this.m_cmd_save.ImageList = this.ImageList;
            this.m_cmd_save.Location = new System.Drawing.Point(186, 4);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_save.TabIndex = 9;
            this.m_cmd_save.Text = "&Lưu";
            this.m_cmd_save.Click += new System.EventHandler(this.m_cmd_save_Click);
            // 
            // m_cmd_refresh
            // 
            this.m_cmd_refresh.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_refresh.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_refresh.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_refresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_refresh.ImageIndex = 9;
            this.m_cmd_refresh.ImageList = this.ImageList;
            this.m_cmd_refresh.Location = new System.Drawing.Point(274, 4);
            this.m_cmd_refresh.Name = "m_cmd_refresh";
            this.m_cmd_refresh.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_refresh.TabIndex = 10;
            this.m_cmd_refresh.Text = "L&àm lại";
            this.m_cmd_refresh.Click += new System.EventHandler(this.m_cmd_refresh_Click);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(362, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // m_lbl_ma_don_vi
            // 
            this.m_lbl_ma_don_vi.AutoSize = true;
            this.m_lbl_ma_don_vi.Location = new System.Drawing.Point(35, 27);
            this.m_lbl_ma_don_vi.Name = "m_lbl_ma_don_vi";
            this.m_lbl_ma_don_vi.Size = new System.Drawing.Size(77, 13);
            this.m_lbl_ma_don_vi.TabIndex = 31;
            this.m_lbl_ma_don_vi.Text = "Mã đơn vị tính";
            // 
            // m_txt_ma_don_vi
            // 
            this.m_txt_ma_don_vi.Location = new System.Drawing.Point(145, 24);
            this.m_txt_ma_don_vi.Name = "m_txt_ma_don_vi";
            this.m_txt_ma_don_vi.Size = new System.Drawing.Size(93, 20);
            this.m_txt_ma_don_vi.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tên đơn vị tính";
            // 
            // m_txt_ten_don_vi
            // 
            this.m_txt_ten_don_vi.Location = new System.Drawing.Point(145, 63);
            this.m_txt_ten_don_vi.Name = "m_txt_ten_don_vi";
            this.m_txt_ten_don_vi.Size = new System.Drawing.Size(176, 20);
            this.m_txt_ten_don_vi.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Ghi chú";
            // 
            // m_txt_ghi_chu
            // 
            this.m_txt_ghi_chu.Location = new System.Drawing.Point(145, 102);
            this.m_txt_ghi_chu.Multiline = true;
            this.m_txt_ghi_chu.Name = "m_txt_ghi_chu";
            this.m_txt_ghi_chu.Size = new System.Drawing.Size(259, 85);
            this.m_txt_ghi_chu.TabIndex = 35;
            // 
            // f303_DM_DON_VI_DE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 261);
            this.Controls.Add(this.m_txt_ghi_chu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_txt_ten_don_vi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_lbl_ma_don_vi);
            this.Controls.Add(this.m_txt_ma_don_vi);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f303_DM_DON_VI_DE";
            this.Text = "f303 - Thêm/Sửa";
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_save;
        internal SIS.Controls.Button.SiSButton m_cmd_refresh;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private System.Windows.Forms.Label m_lbl_ma_don_vi;
        private System.Windows.Forms.TextBox m_txt_ma_don_vi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_txt_ten_don_vi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_txt_ghi_chu;

    }
}