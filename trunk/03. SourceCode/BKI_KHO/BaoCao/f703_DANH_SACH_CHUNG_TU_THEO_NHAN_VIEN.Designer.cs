namespace BKI_KHO.BaoCao
{
    partial class f703_DANH_SACH_CHUNG_TU_THEO_NHAN_VIEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f703_DANH_SACH_CHUNG_TU_THEO_NHAN_VIEN));
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.SuspendLayout();
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_fg.Location = new System.Drawing.Point(0, 95);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(848, 319);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            // 
            // f703_DANH_SACH_CHUNG_TU_THEO_NHAN_VIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_fg);
            this.Name = "f703_DANH_SACH_CHUNG_TU_THEO_NHAN_VIEN";
            this.Text = "f703 - Danh sách chứng từ theo nhân viên";
            this.Load += new System.EventHandler(this.f703_DANH_SACH_CHUNG_TU_THEO_NHAN_VIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        private System.Windows.Forms.Label label1;
    }
}