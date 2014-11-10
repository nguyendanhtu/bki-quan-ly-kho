namespace DemoKho
{
    partial class F200_Nhap_kho
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.m_grc_hang_nhap = new DevExpress.XtraGrid.GridControl();
            this.m_grv_hang_nhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NHOM_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SERIAL_NUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THANH_PHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PART_NUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SERIAL_NUMBER_THANH_PHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.m_cmd_them_thiet_bi = new DevExpress.XtraEditors.SimpleButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_hang_nhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_hang_nhap)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU NHẬP KHO";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(265, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(265, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Họ tên người giao";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(428, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nội dung";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(175, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(428, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nhập tại kho";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(175, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(428, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // m_grc_hang_nhap
            // 
            this.m_grc_hang_nhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_hang_nhap.Location = new System.Drawing.Point(0, 0);
            this.m_grc_hang_nhap.MainView = this.m_grv_hang_nhap;
            this.m_grc_hang_nhap.Name = "m_grc_hang_nhap";
            this.m_grc_hang_nhap.Size = new System.Drawing.Size(687, 210);
            this.m_grc_hang_nhap.TabIndex = 11;
            this.m_grc_hang_nhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_hang_nhap});
            // 
            // m_grv_hang_nhap
            // 
            this.m_grv_hang_nhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NHOM_HANG,
            this.TEN_HANG,
            this.SERIAL_NUMBER,
            this.THANH_PHAN,
            this.PART_NUMBER,
            this.SERIAL_NUMBER_THANH_PHAN});
            this.m_grv_hang_nhap.GridControl = this.m_grc_hang_nhap;
            this.m_grv_hang_nhap.GroupCount = 2;
            this.m_grv_hang_nhap.Name = "m_grv_hang_nhap";
            this.m_grv_hang_nhap.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.NHOM_HANG, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.TEN_HANG, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // NHOM_HANG
            // 
            this.NHOM_HANG.Caption = "Nhóm hàng";
            this.NHOM_HANG.Name = "NHOM_HANG";
            this.NHOM_HANG.Visible = true;
            this.NHOM_HANG.VisibleIndex = 0;
            // 
            // TEN_HANG
            // 
            this.TEN_HANG.Caption = "Tên hàng";
            this.TEN_HANG.Name = "TEN_HANG";
            this.TEN_HANG.Visible = true;
            this.TEN_HANG.VisibleIndex = 0;
            // 
            // SERIAL_NUMBER
            // 
            this.SERIAL_NUMBER.Caption = "SN thiết bị";
            this.SERIAL_NUMBER.Name = "SERIAL_NUMBER";
            this.SERIAL_NUMBER.Visible = true;
            this.SERIAL_NUMBER.VisibleIndex = 0;
            // 
            // THANH_PHAN
            // 
            this.THANH_PHAN.Caption = "Tên thành phần";
            this.THANH_PHAN.Name = "THANH_PHAN";
            this.THANH_PHAN.Visible = true;
            this.THANH_PHAN.VisibleIndex = 1;
            // 
            // PART_NUMBER
            // 
            this.PART_NUMBER.Caption = "Part number";
            this.PART_NUMBER.Name = "PART_NUMBER";
            this.PART_NUMBER.Visible = true;
            this.PART_NUMBER.VisibleIndex = 2;
            // 
            // SERIAL_NUMBER_THANH_PHAN
            // 
            this.SERIAL_NUMBER_THANH_PHAN.Caption = "SN thành phần";
            this.SERIAL_NUMBER_THANH_PHAN.Name = "SERIAL_NUMBER_THANH_PHAN";
            this.SERIAL_NUMBER_THANH_PHAN.Visible = true;
            this.SERIAL_NUMBER_THANH_PHAN.VisibleIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.m_cmd_them_thiet_bi);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 267);
            this.panel1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(5, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 26);
            this.label8.TabIndex = 13;
            this.label8.Text = "Công ty Cổ phần quốc tế \r\nSUN IVY";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_cmd_them_thiet_bi
            // 
            this.m_cmd_them_thiet_bi.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.m_cmd_them_thiet_bi.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.m_cmd_them_thiet_bi.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.m_cmd_them_thiet_bi.Appearance.ForeColor = System.Drawing.Color.Black;
            this.m_cmd_them_thiet_bi.Appearance.Options.UseBackColor = true;
            this.m_cmd_them_thiet_bi.Appearance.Options.UseBorderColor = true;
            this.m_cmd_them_thiet_bi.Appearance.Options.UseForeColor = true;
            this.m_cmd_them_thiet_bi.Location = new System.Drawing.Point(69, 238);
            this.m_cmd_them_thiet_bi.Name = "m_cmd_them_thiet_bi";
            this.m_cmd_them_thiet_bi.Size = new System.Drawing.Size(114, 23);
            this.m_cmd_them_thiet_bi.TabIndex = 12;
            this.m_cmd_them_thiet_bi.Text = "Thêm các thiết bị";
            this.m_cmd_them_thiet_bi.Click += new System.EventHandler(this.m_cmd_them_thiet_bi_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(175, 206);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(428, 20);
            this.textBox4.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Người lập phiếu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_grc_hang_nhap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 210);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.simpleButton3);
            this.panel3.Controls.Add(this.simpleButton2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 436);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(687, 41);
            this.panel3.TabIndex = 14;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(569, 9);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(106, 23);
            this.simpleButton3.TabIndex = 34;
            this.simpleButton3.Text = "Exit";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.simpleButton2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.simpleButton2.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.Location = new System.Drawing.Point(12, 9);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(157, 23);
            this.simpleButton2.TabIndex = 14;
            this.simpleButton2.Text = "Xem danh sách phiếu nhập";
            // 
            // F200_Nhap_kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 477);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F200_Nhap_kho";
            this.Text = "F200 Nhập kho";
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_hang_nhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_hang_nhap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraGrid.GridControl m_grc_hang_nhap;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_hang_nhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn NHOM_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn SERIAL_NUMBER;
        private DevExpress.XtraGrid.Columns.GridColumn THANH_PHAN;
        private DevExpress.XtraGrid.Columns.GridColumn PART_NUMBER;
        private DevExpress.XtraGrid.Columns.GridColumn SERIAL_NUMBER_THANH_PHAN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton m_cmd_them_thiet_bi;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}