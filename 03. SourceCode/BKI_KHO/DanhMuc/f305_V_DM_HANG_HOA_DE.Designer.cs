namespace BKI_KHO.DanhMuc
{
    partial class f305_V_DM_HANG_HOA_DE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f305_V_DM_HANG_HOA_DE));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_save = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.button1 = new System.Windows.Forms.Button();
            this.m_cbo_trang_thai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.m_txt_gia_ban = new System.Windows.Forms.TextBox();
            this.m_txt_gia_nhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.m_txt_ten_hang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.m_txt_ma_hang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_cbo_don_vi_tinh = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_lbl_kho = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.panel2.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.m_cmd_save);
            this.panel1.Controls.Add(this.m_cmd_exit);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 33);
            this.panel1.TabIndex = 87;
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
            this.m_cmd_save.Location = new System.Drawing.Point(658, 0);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(88, 31);
            this.m_cmd_save.TabIndex = 34;
            this.m_cmd_save.Text = "&Lưu";
            this.m_cmd_save.Click += new System.EventHandler(this.m_cmd_save_Click);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(746, 0);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 31);
            this.m_cmd_exit.TabIndex = 36;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(834, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // m_cbo_trang_thai
            // 
            this.m_cbo_trang_thai.FormattingEnabled = true;
            this.m_cbo_trang_thai.Location = new System.Drawing.Point(541, 44);
            this.m_cbo_trang_thai.Name = "m_cbo_trang_thai";
            this.m_cbo_trang_thai.Size = new System.Drawing.Size(132, 21);
            this.m_cbo_trang_thai.Sorted = true;
            this.m_cbo_trang_thai.TabIndex = 132;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 131;
            this.label1.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 128;
            this.label4.Text = "Giá nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 127;
            this.label5.Text = "Giá bán";
            // 
            // m_txt_gia_ban
            // 
            this.m_txt_gia_ban.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_gia_ban.Location = new System.Drawing.Point(541, 98);
            this.m_txt_gia_ban.Name = "m_txt_gia_ban";
            this.m_txt_gia_ban.Size = new System.Drawing.Size(160, 20);
            this.m_txt_gia_ban.TabIndex = 126;
            // 
            // m_txt_gia_nhap
            // 
            this.m_txt_gia_nhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_gia_nhap.Location = new System.Drawing.Point(541, 71);
            this.m_txt_gia_nhap.Name = "m_txt_gia_nhap";
            this.m_txt_gia_nhap.Size = new System.Drawing.Size(160, 20);
            this.m_txt_gia_nhap.TabIndex = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 124;
            this.label6.Text = "Tên hàng hóa ";
            // 
            // m_txt_ten_hang
            // 
            this.m_txt_ten_hang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_ten_hang.Location = new System.Drawing.Point(167, 71);
            this.m_txt_ten_hang.Name = "m_txt_ten_hang";
            this.m_txt_ten_hang.Size = new System.Drawing.Size(224, 20);
            this.m_txt_ten_hang.TabIndex = 123;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 122;
            this.label7.Text = "Mã hàng hóa";
            // 
            // m_txt_ma_hang
            // 
            this.m_txt_ma_hang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_ma_hang.Location = new System.Drawing.Point(167, 45);
            this.m_txt_ma_hang.Name = "m_txt_ma_hang";
            this.m_txt_ma_hang.Size = new System.Drawing.Size(132, 20);
            this.m_txt_ma_hang.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 133;
            this.label2.Text = "Đơn vị tính";
            // 
            // m_cbo_don_vi_tinh
            // 
            this.m_cbo_don_vi_tinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_don_vi_tinh.Location = new System.Drawing.Point(167, 97);
            this.m_cbo_don_vi_tinh.Name = "m_cbo_don_vi_tinh";
            this.m_cbo_don_vi_tinh.Size = new System.Drawing.Size(88, 21);
            this.m_cbo_don_vi_tinh.TabIndex = 134;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 135;
            this.label8.Text = "Thành phần";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 154);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(836, 268);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 136;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_lbl_kho);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.m_txt_ma_hang);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.m_cbo_don_vi_tinh);
            this.panel2.Controls.Add(this.m_txt_ten_hang);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.m_cbo_trang_thai);
            this.panel2.Controls.Add(this.m_txt_gia_nhap);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.m_txt_gia_ban);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 154);
            this.panel2.TabIndex = 137;
            // 
            // m_lbl_kho
            // 
            this.m_lbl_kho.AutoSize = true;
            this.m_lbl_kho.Location = new System.Drawing.Point(12, 9);
            this.m_lbl_kho.Name = "m_lbl_kho";
            this.m_lbl_kho.Size = new System.Drawing.Size(16, 13);
            this.m_lbl_kho.TabIndex = 136;
            this.m_lbl_kho.Text = "...";
            // 
            // f305_V_DM_HANG_HOA_DE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 455);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f305_V_DM_HANG_HOA_DE";
            this.Text = "F305 - Thông tin chi tiết hàng";
            this.Load += new System.EventHandler(this.f305_V_DM_HANG_HOA_DE_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Panel panel1;
        internal SIS.Controls.Button.SiSButton m_cmd_save;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox m_cbo_trang_thai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m_txt_gia_ban;
        private System.Windows.Forms.TextBox m_txt_gia_nhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox m_txt_ten_hang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox m_txt_ma_hang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox m_cbo_don_vi_tinh;
        private System.Windows.Forms.Label label8;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label m_lbl_kho;
    }
}