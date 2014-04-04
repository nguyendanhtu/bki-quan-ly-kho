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
            this.m_tbo_ma_loai_ct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_lbl_ghi_chu = new System.Windows.Forms.Label();
            this.m_tbo_ghi_chu = new System.Windows.Forms.TextBox();
            this.m_bto_them = new System.Windows.Forms.Button();
            this.m_bto_huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_tbo_ma_loai_ct
            // 
            this.m_tbo_ma_loai_ct.BackColor = System.Drawing.Color.Ivory;
            this.m_tbo_ma_loai_ct.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_tbo_ma_loai_ct.Location = new System.Drawing.Point(143, 34);
            this.m_tbo_ma_loai_ct.Name = "m_tbo_ma_loai_ct";
            this.m_tbo_ma_loai_ct.Size = new System.Drawing.Size(172, 22);
            this.m_tbo_ma_loai_ct.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã loại chứng từ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "f500 - DE - THÊM CHỨNG TỪ";
            // 
            // m_lbl_ghi_chu
            // 
            this.m_lbl_ghi_chu.AutoSize = true;
            this.m_lbl_ghi_chu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_ghi_chu.Location = new System.Drawing.Point(72, 79);
            this.m_lbl_ghi_chu.Name = "m_lbl_ghi_chu";
            this.m_lbl_ghi_chu.Size = new System.Drawing.Size(52, 14);
            this.m_lbl_ghi_chu.TabIndex = 3;
            this.m_lbl_ghi_chu.Text = "Ghi chú";
            // 
            // m_tbo_ghi_chu
            // 
            this.m_tbo_ghi_chu.BackColor = System.Drawing.Color.Ivory;
            this.m_tbo_ghi_chu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_tbo_ghi_chu.Location = new System.Drawing.Point(142, 71);
            this.m_tbo_ghi_chu.Name = "m_tbo_ghi_chu";
            this.m_tbo_ghi_chu.Size = new System.Drawing.Size(172, 22);
            this.m_tbo_ghi_chu.TabIndex = 4;
            // 
            // m_bto_them
            // 
            this.m_bto_them.Location = new System.Drawing.Point(143, 120);
            this.m_bto_them.Name = "m_bto_them";
            this.m_bto_them.Size = new System.Drawing.Size(70, 25);
            this.m_bto_them.TabIndex = 7;
            this.m_bto_them.Text = "Thêm";
            this.m_bto_them.UseVisualStyleBackColor = true;
            this.m_bto_them.Click += new System.EventHandler(this.m_bto_them_Click);
            // 
            // m_bto_huy
            // 
            this.m_bto_huy.Location = new System.Drawing.Point(244, 120);
            this.m_bto_huy.Name = "m_bto_huy";
            this.m_bto_huy.Size = new System.Drawing.Size(70, 25);
            this.m_bto_huy.TabIndex = 8;
            this.m_bto_huy.Text = "Hủy";
            this.m_bto_huy.UseVisualStyleBackColor = true;
            this.m_bto_huy.Click += new System.EventHandler(this.m_bto_huy_Click);
            // 
            // f500_DM_LOAI_CHUNG_TU_DE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(338, 163);
            this.Controls.Add(this.m_bto_huy);
            this.Controls.Add(this.m_bto_them);
            this.Controls.Add(this.m_tbo_ghi_chu);
            this.Controls.Add(this.m_lbl_ghi_chu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_tbo_ma_loai_ct);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Brown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "f500_DM_LOAI_CHUNG_TU_DE";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_tbo_ma_loai_ct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label m_lbl_ghi_chu;
        private System.Windows.Forms.TextBox m_tbo_ghi_chu;
        private System.Windows.Forms.Button m_bto_them;
        private System.Windows.Forms.Button m_bto_huy;
    }
}