﻿namespace BKI_KHO.NghiepVu
{
    partial class F704_V_BAO_HANH_SUA_CHUA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F704_V_BAO_HANH_SUA_CHUA));
            this.label1 = new System.Windows.Forms.Label();
            this.m_txt_so = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_txt_ho_ten_khach_hang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_dat_ngay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_txt_tien_sua_chua = new C1.Win.C1Input.C1TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.m_txt_serial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.m_txt_noi_dung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_txt_dia_chi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.m_txt_dien_thoai_khach_hang = new System.Windows.Forms.TextBox();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_save = new SIS.Controls.Button.SiSButton();
            this.m_cmd_danh_sach = new SIS.Controls.Button.SiSButton();
            this.m_cmd_in_hoa_don = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_cbo_hang_hoa = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_tien_sua_chua)).BeginInit();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số";
            // 
            // m_txt_so
            // 
            this.m_txt_so.Location = new System.Drawing.Point(25, 6);
            this.m_txt_so.Name = "m_txt_so";
            this.m_txt_so.Size = new System.Drawing.Size(112, 20);
            this.m_txt_so.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày";
            // 
            // m_txt_ho_ten_khach_hang
            // 
            this.m_txt_ho_ten_khach_hang.Location = new System.Drawing.Point(81, 19);
            this.m_txt_ho_ten_khach_hang.Name = "m_txt_ho_ten_khach_hang";
            this.m_txt_ho_ten_khach_hang.Size = new System.Drawing.Size(373, 20);
            this.m_txt_ho_ten_khach_hang.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Họ tên";
            // 
            // m_dat_ngay
            // 
            this.m_dat_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dat_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_ngay.Location = new System.Drawing.Point(578, 6);
            this.m_dat_ngay.Name = "m_dat_ngay";
            this.m_dat_ngay.Size = new System.Drawing.Size(122, 20);
            this.m_dat_ngay.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(217, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "PHIẾU BẢO HÀNH";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 376);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.m_fg);
            this.groupBox2.Location = new System.Drawing.Point(12, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 164);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhân viên";
            // 
            // m_fg
            // 
            this.m_fg.AllowAddNew = true;
            this.m_fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_fg.Location = new System.Drawing.Point(3, 19);
            this.m_fg.Name = "m_fg";
            this.m_fg.Rows.Count = 14;
            this.m_fg.Size = new System.Drawing.Size(682, 142);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_cbo_hang_hoa);
            this.groupBox1.Controls.Add(this.m_txt_tien_sua_chua);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.m_txt_serial);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.m_txt_noi_dung);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.m_txt_ho_ten_khach_hang);
            this.groupBox1.Controls.Add(this.m_txt_dia_chi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.m_txt_dien_thoai_khach_hang);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 194);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // m_txt_tien_sua_chua
            // 
            this.m_txt_tien_sua_chua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_tien_sua_chua.CustomFormat = "###,###,###,###0";
            this.m_txt_tien_sua_chua.DataType = typeof(decimal);
            this.m_txt_tien_sua_chua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txt_tien_sua_chua.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.m_txt_tien_sua_chua.Location = new System.Drawing.Point(348, 165);
            this.m_txt_tien_sua_chua.Name = "m_txt_tien_sua_chua";
            this.m_txt_tien_sua_chua.NullText = "0";
            this.m_txt_tien_sua_chua.Size = new System.Drawing.Size(167, 17);
            this.m_txt_tien_sua_chua.TabIndex = 23;
            this.m_txt_tien_sua_chua.Tag = null;
            this.m_txt_tien_sua_chua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(517, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "VNĐ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tên hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(273, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tiền sửa chữa";
            // 
            // m_txt_serial
            // 
            this.m_txt_serial.Location = new System.Drawing.Point(81, 164);
            this.m_txt_serial.Name = "m_txt_serial";
            this.m_txt_serial.Size = new System.Drawing.Size(186, 20);
            this.m_txt_serial.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Serial";
            // 
            // m_txt_noi_dung
            // 
            this.m_txt_noi_dung.Location = new System.Drawing.Point(81, 71);
            this.m_txt_noi_dung.Multiline = true;
            this.m_txt_noi_dung.Name = "m_txt_noi_dung";
            this.m_txt_noi_dung.Size = new System.Drawing.Size(601, 60);
            this.m_txt_noi_dung.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nội dung";
            // 
            // m_txt_dia_chi
            // 
            this.m_txt_dia_chi.Location = new System.Drawing.Point(81, 45);
            this.m_txt_dia_chi.Name = "m_txt_dia_chi";
            this.m_txt_dia_chi.Size = new System.Drawing.Size(601, 20);
            this.m_txt_dia_chi.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(460, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Điện thoại";
            // 
            // m_txt_dien_thoai_khach_hang
            // 
            this.m_txt_dien_thoai_khach_hang.Location = new System.Drawing.Point(520, 19);
            this.m_txt_dien_thoai_khach_hang.Name = "m_txt_dien_thoai_khach_hang";
            this.m_txt_dien_thoai_khach_hang.Size = new System.Drawing.Size(162, 20);
            this.m_txt_dien_thoai_khach_hang.TabIndex = 6;
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_danh_sach);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_in_hoa_don);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 428);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(712, 36);
            this.m_pnl_out_place_dm.TabIndex = 20;
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
            this.m_cmd_save.Location = new System.Drawing.Point(371, 4);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(161, 28);
            this.m_cmd_save.TabIndex = 24;
            this.m_cmd_save.Text = "Lập phiếu";
            this.m_cmd_save.Click += new System.EventHandler(this.m_cmd_save_Click);
            // 
            // m_cmd_danh_sach
            // 
            this.m_cmd_danh_sach.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_danh_sach.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_danh_sach.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_danh_sach.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_danh_sach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_danh_sach.ImageIndex = 21;
            this.m_cmd_danh_sach.ImageList = this.ImageList;
            this.m_cmd_danh_sach.Location = new System.Drawing.Point(137, 4);
            this.m_cmd_danh_sach.Name = "m_cmd_danh_sach";
            this.m_cmd_danh_sach.Size = new System.Drawing.Size(188, 28);
            this.m_cmd_danh_sach.TabIndex = 23;
            this.m_cmd_danh_sach.Text = "Danh sách phiếu bảo hành";
            this.m_cmd_danh_sach.Click += new System.EventHandler(this.m_cmd_danh_sach_Click);
            // 
            // m_cmd_in_hoa_don
            // 
            this.m_cmd_in_hoa_don.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_in_hoa_don.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_in_hoa_don.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_in_hoa_don.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_in_hoa_don.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_in_hoa_don.ImageIndex = 15;
            this.m_cmd_in_hoa_don.ImageList = this.ImageList;
            this.m_cmd_in_hoa_don.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_in_hoa_don.Name = "m_cmd_in_hoa_don";
            this.m_cmd_in_hoa_don.Size = new System.Drawing.Size(133, 28);
            this.m_cmd_in_hoa_don.TabIndex = 22;
            this.m_cmd_in_hoa_don.Text = "In phiếu bảo hành";
            this.m_cmd_in_hoa_don.Visible = false;
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
            this.m_cmd_exit.Location = new System.Drawing.Point(532, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(176, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_txt_so);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.m_dat_ngay);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 52);
            this.panel2.TabIndex = 21;
            // 
            // m_cbo_hang_hoa
            // 
            this.m_cbo_hang_hoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_hang_hoa.Location = new System.Drawing.Point(81, 137);
            this.m_cbo_hang_hoa.Name = "m_cbo_hang_hoa";
            this.m_cbo_hang_hoa.Size = new System.Drawing.Size(601, 21);
            this.m_cbo_hang_hoa.TabIndex = 131;
            // 
            // F704_V_BAO_HANH_SUA_CHUA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(712, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "F704_V_BAO_HANH_SUA_CHUA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F704 - Lập phiếu bảo hành/sửa chữa";
            this.Load += new System.EventHandler(this.F704_V_BAO_HANH_SUA_CHUA_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_tien_sua_chua)).EndInit();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_txt_so;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_txt_ho_ten_khach_hang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker m_dat_ngay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox m_txt_dia_chi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox m_txt_dien_thoai_khach_hang;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_save;
        internal SIS.Controls.Button.SiSButton m_cmd_danh_sach;
        internal SIS.Controls.Button.SiSButton m_cmd_in_hoa_don;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox m_txt_serial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox m_txt_noi_dung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private C1.Win.C1Input.C1TextBox m_txt_tien_sua_chua;
        private System.Windows.Forms.ComboBox m_cbo_hang_hoa;
    }
}