namespace BKI_KHO.DanhMuc
{
    partial class f500_DM_LOAI_CHUNG_TU_DE
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
            this.m_lbl_ghi_chu = new System.Windows.Forms.Label();
            this.m_lbl_ma_loai_chung_tu = new System.Windows.Forms.Label();
            this.m_lbl_ten_loai_chung_tu = new System.Windows.Forms.Label();
            this.m_txt_ghi_chu = new System.Windows.Forms.TextBox();
            this.m_txt_ten_loai_chung_tu = new System.Windows.Forms.TextBox();
            this.m_cmd_close = new System.Windows.Forms.Button();
            this.m_cmd_save = new System.Windows.Forms.Button();
            this.m_txt_ma_loai_chung_tu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // m_lbl_ghi_chu
            // 
            this.m_lbl_ghi_chu.AutoSize = true;
            this.m_lbl_ghi_chu.Location = new System.Drawing.Point(46, 29);
            this.m_lbl_ghi_chu.Name = "m_lbl_ghi_chu";
            this.m_lbl_ghi_chu.Size = new System.Drawing.Size(45, 13);
            this.m_lbl_ghi_chu.TabIndex = 0;
            this.m_lbl_ghi_chu.Text = "Ghi Chú";
            // 
            // m_lbl_ma_loai_chung_tu
            // 
            this.m_lbl_ma_loai_chung_tu.AutoSize = true;
            this.m_lbl_ma_loai_chung_tu.Location = new System.Drawing.Point(46, 77);
            this.m_lbl_ma_loai_chung_tu.Name = "m_lbl_ma_loai_chung_tu";
            this.m_lbl_ma_loai_chung_tu.Size = new System.Drawing.Size(95, 13);
            this.m_lbl_ma_loai_chung_tu.TabIndex = 1;
            this.m_lbl_ma_loai_chung_tu.Text = "Mã Loại Chứng Từ";
            // 
            // m_lbl_ten_loai_chung_tu
            // 
            this.m_lbl_ten_loai_chung_tu.AutoSize = true;
            this.m_lbl_ten_loai_chung_tu.Location = new System.Drawing.Point(46, 124);
            this.m_lbl_ten_loai_chung_tu.Name = "m_lbl_ten_loai_chung_tu";
            this.m_lbl_ten_loai_chung_tu.Size = new System.Drawing.Size(99, 13);
            this.m_lbl_ten_loai_chung_tu.TabIndex = 2;
            this.m_lbl_ten_loai_chung_tu.Text = "Tên Loại Chứng Từ";
            // 
            // m_txt_ghi_chu
            // 
            this.m_txt_ghi_chu.Location = new System.Drawing.Point(208, 21);
            this.m_txt_ghi_chu.Name = "m_txt_ghi_chu";
            this.m_txt_ghi_chu.Size = new System.Drawing.Size(100, 20);
            this.m_txt_ghi_chu.TabIndex = 3;
            // 
            // m_txt_ten_loai_chung_tu
            // 
            this.m_txt_ten_loai_chung_tu.Location = new System.Drawing.Point(208, 116);
            this.m_txt_ten_loai_chung_tu.Name = "m_txt_ten_loai_chung_tu";
            this.m_txt_ten_loai_chung_tu.Size = new System.Drawing.Size(100, 20);
            this.m_txt_ten_loai_chung_tu.TabIndex = 4;
            // 
            // m_cmd_close
            // 
            this.m_cmd_close.Location = new System.Drawing.Point(263, 188);
            this.m_cmd_close.Name = "m_cmd_close";
            this.m_cmd_close.Size = new System.Drawing.Size(92, 35);
            this.m_cmd_close.TabIndex = 6;
            this.m_cmd_close.Text = "Close";
            this.m_cmd_close.UseVisualStyleBackColor = true;
            this.m_cmd_close.Click += new System.EventHandler(this.m_cmd_close_Click);
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.Location = new System.Drawing.Point(131, 188);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(82, 35);
            this.m_cmd_save.TabIndex = 7;
            this.m_cmd_save.Text = "Save";
            this.m_cmd_save.UseVisualStyleBackColor = true;
            this.m_cmd_save.Click += new System.EventHandler(this.m_cmd_save_Click);
            // 
            // m_txt_ma_loai_chung_tu
            // 
            this.m_txt_ma_loai_chung_tu.Location = new System.Drawing.Point(208, 69);
            this.m_txt_ma_loai_chung_tu.Name = "m_txt_ma_loai_chung_tu";
            this.m_txt_ma_loai_chung_tu.Size = new System.Drawing.Size(100, 20);
            this.m_txt_ma_loai_chung_tu.TabIndex = 8;
            // 
            // f500_DM_LOAI_CHUNG_TU_DE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 251);
            this.Controls.Add(this.m_txt_ma_loai_chung_tu);
            this.Controls.Add(this.m_cmd_save);
            this.Controls.Add(this.m_cmd_close);
            this.Controls.Add(this.m_txt_ten_loai_chung_tu);
            this.Controls.Add(this.m_txt_ghi_chu);
            this.Controls.Add(this.m_lbl_ten_loai_chung_tu);
            this.Controls.Add(this.m_lbl_ma_loai_chung_tu);
            this.Controls.Add(this.m_lbl_ghi_chu);
            this.Name = "f500_DM_LOAI_CHUNG_TU_DE";
            this.Text = "f500_DM_LOAI_CHUNG_TU_DE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_lbl_ghi_chu;
        private System.Windows.Forms.Label m_lbl_ma_loai_chung_tu;
        private System.Windows.Forms.Label m_lbl_ten_loai_chung_tu;
        private System.Windows.Forms.TextBox m_txt_ghi_chu;
        private System.Windows.Forms.TextBox m_txt_ten_loai_chung_tu;
        private System.Windows.Forms.Button m_cmd_close;
        private System.Windows.Forms.Button m_cmd_save;
        private System.Windows.Forms.TextBox m_txt_ma_loai_chung_tu;
    }
}