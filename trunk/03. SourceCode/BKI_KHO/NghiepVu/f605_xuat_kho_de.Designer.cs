namespace BKI_KHO.NghiepVu
{
    partial class f605_xuat_kho_de
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_grc_hang_nhap = new DevExpress.XtraGrid.GridControl();
            this.m_grv_hang_nhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SERIAL_NUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PART_NUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_hang_nhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_hang_nhap)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 49);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "DANH SÁCH THIẾT BỊ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Công ty Cổ phần quốc tế \r\nSUN IVY";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_grc_hang_nhap
            // 
            this.m_grc_hang_nhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_hang_nhap.Location = new System.Drawing.Point(0, 200);
            this.m_grc_hang_nhap.MainView = this.m_grv_hang_nhap;
            this.m_grc_hang_nhap.Name = "m_grc_hang_nhap";
            this.m_grc_hang_nhap.Size = new System.Drawing.Size(670, 237);
            this.m_grc_hang_nhap.TabIndex = 31;
            this.m_grc_hang_nhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_hang_nhap});
            // 
            // m_grv_hang_nhap
            // 
            this.m_grv_hang_nhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SERIAL_NUMBER,
            this.PART_NUMBER});
            this.m_grv_hang_nhap.GridControl = this.m_grc_hang_nhap;
            this.m_grv_hang_nhap.Name = "m_grv_hang_nhap";
            // 
            // SERIAL_NUMBER
            // 
            this.SERIAL_NUMBER.Caption = "Serial Number";
            this.SERIAL_NUMBER.Name = "SERIAL_NUMBER";
            this.SERIAL_NUMBER.Visible = true;
            this.SERIAL_NUMBER.VisibleIndex = 0;
            // 
            // PART_NUMBER
            // 
            this.PART_NUMBER.Caption = "Part number";
            this.PART_NUMBER.Name = "PART_NUMBER";
            this.PART_NUMBER.Visible = true;
            this.PART_NUMBER.VisibleIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.checkEdit1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 151);
            this.panel2.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 21);
            this.textBox1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nhập Serial Number";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(17, 111);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(141, 23);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "Xuất kho thiết bị này";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Chọn loại thiết bị";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(124, 38);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(253, 21);
            this.comboBox2.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Chọn dòng thiết bị";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.simpleButton4);
            this.panel4.Controls.Add(this.simpleButton3);
            this.panel4.Controls.Add(this.simpleButton2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 437);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(670, 30);
            this.panel4.TabIndex = 33;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton4.Location = new System.Drawing.Point(352, 0);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(106, 30);
            this.simpleButton4.TabIndex = 34;
            this.simpleButton4.Text = "Save";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton3.Location = new System.Drawing.Point(458, 0);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(106, 30);
            this.simpleButton3.TabIndex = 33;
            this.simpleButton3.Text = "Exit";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton2.Location = new System.Drawing.Point(564, 0);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(106, 30);
            this.simpleButton2.TabIndex = 32;
            this.simpleButton2.Text = "Delete";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(199, 111);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "checkEdit1";
            this.checkEdit1.Size = new System.Drawing.Size(75, 19);
            this.checkEdit1.TabIndex = 24;
            // 
            // f605_xuat_kho_de
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 467);
            this.Controls.Add(this.m_grc_hang_nhap);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f605_xuat_kho_de";
            this.Text = "F605 - Chi tiết xuất kho";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_hang_nhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_hang_nhap)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl m_grc_hang_nhap;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_hang_nhap;
        private DevExpress.XtraGrid.Columns.GridColumn SERIAL_NUMBER;
        private DevExpress.XtraGrid.Columns.GridColumn PART_NUMBER;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;

    }
}