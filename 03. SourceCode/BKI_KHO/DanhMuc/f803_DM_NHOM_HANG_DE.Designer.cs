namespace BKI_KHO.DanhMuc
{
    partial class f803_DM_NHOM_HANG_DE
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
            this.m_cmd_exit = new System.Windows.Forms.Button();
            this.m_cmd_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.m_cbo_nhom_cha = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_txt_ten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_txt_mo_ta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.m_nud_so_thu_tu = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_nud_cap_do = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_nud_so_thu_tu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_nud_cap_do)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.m_cmd_exit);
            this.panel1.Controls.Add(this.m_cmd_save);
            this.panel1.Location = new System.Drawing.Point(13, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 42);
            this.panel1.TabIndex = 1;
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.Location = new System.Drawing.Point(173, 9);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_exit.TabIndex = 1;
            this.m_cmd_exit.Text = "Thoát";
            this.m_cmd_exit.UseVisualStyleBackColor = true;
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.Location = new System.Drawing.Point(60, 9);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_save.TabIndex = 0;
            this.m_cmd_save.Text = "Lưu lại";
            this.m_cmd_save.UseVisualStyleBackColor = true;
            this.m_cmd_save.Click += new System.EventHandler(this.m_cmd_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nhóm cha";
            // 
            // m_cbo_nhom_cha
            // 
            this.m_cbo_nhom_cha.FormattingEnabled = true;
            this.m_cbo_nhom_cha.Location = new System.Drawing.Point(116, 22);
            this.m_cbo_nhom_cha.Name = "m_cbo_nhom_cha";
            this.m_cbo_nhom_cha.Size = new System.Drawing.Size(145, 21);
            this.m_cbo_nhom_cha.TabIndex = 13;
            this.m_cbo_nhom_cha.SelectedIndexChanged += new System.EventHandler(this.m_cbo_nhom_cha_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên";
            // 
            // m_txt_ten
            // 
            this.m_txt_ten.Location = new System.Drawing.Point(116, 63);
            this.m_txt_ten.Name = "m_txt_ten";
            this.m_txt_ten.Size = new System.Drawing.Size(145, 20);
            this.m_txt_ten.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mô tả";
            // 
            // m_txt_mo_ta
            // 
            this.m_txt_mo_ta.Location = new System.Drawing.Point(116, 102);
            this.m_txt_mo_ta.Name = "m_txt_mo_ta";
            this.m_txt_mo_ta.Size = new System.Drawing.Size(145, 20);
            this.m_txt_mo_ta.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Số thứ tự";
            // 
            // m_nud_so_thu_tu
            // 
            this.m_nud_so_thu_tu.Location = new System.Drawing.Point(116, 143);
            this.m_nud_so_thu_tu.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.m_nud_so_thu_tu.Name = "m_nud_so_thu_tu";
            this.m_nud_so_thu_tu.Size = new System.Drawing.Size(87, 20);
            this.m_nud_so_thu_tu.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.m_nud_cap_do);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.m_nud_so_thu_tu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.m_txt_mo_ta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.m_txt_ten);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.m_cbo_nhom_cha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // m_nud_cap_do
            // 
            this.m_nud_cap_do.Location = new System.Drawing.Point(116, 180);
            this.m_nud_cap_do.Name = "m_nud_cap_do";
            this.m_nud_cap_do.ReadOnly = true;
            this.m_nud_cap_do.Size = new System.Drawing.Size(42, 20);
            this.m_nud_cap_do.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cấp độ";
            // 
            // f803_DM_NHOM_HANG_DE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 290);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "f803_DM_NHOM_HANG_DE";
            this.Text = "Chi tiết Nhóm hàng";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_nud_so_thu_tu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_nud_cap_do)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button m_cmd_exit;
        private System.Windows.Forms.Button m_cmd_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox m_cbo_nhom_cha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_txt_ten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_txt_mo_ta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown m_nud_so_thu_tu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown m_nud_cap_do;
        private System.Windows.Forms.Label label1;

    }
}