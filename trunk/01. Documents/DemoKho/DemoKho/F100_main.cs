using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTab;

namespace DemoKho
{
    public partial class F100_main : Form
    {
        public F100_main()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void navNhapKho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int Index = KiemTraTonTai(xtraTabControl1, "Nhập kho");
            if (Index >= 0)
            {
                xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages[Index];
                xtraTabControl1.SelectedTabPage.Text = "Nhập kho";
            }
            else
            {
                XtraTabPage TabPage = new XtraTabPage { Text = "Nhập kho" };
                xtraTabControl1.TabPages.Add(TabPage);
                xtraTabControl1.SelectedTabPage = TabPage;

                F200_Nhap_kho v_f = new F200_Nhap_kho();
                v_f.TopLevel = false;
                v_f.Parent = TabPage;
                v_f.Show();
                //v_f.Dock = DockStyle.Fill;
            }
        }

        private int KiemTraTonTai(XtraTabControl xtraTabControl1, string Text)
        {
            int temp = -1;
            for (int i = 0; i < xtraTabControl1.TabPages.Count; i++)
            {
                if (xtraTabControl1.TabPages[i].Text == Text)
                {
                    temp = i;
                    break;
                }
            }
            return temp;
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            XtraTabControl TabControl = (XtraTabControl)sender;
            int i = TabControl.SelectedTabPageIndex;
            TabControl.TabPages.RemoveAt(TabControl.SelectedTabPageIndex);
            TabControl.SelectedTabPageIndex = i - 1;
        }

        private void navXuatKho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int Index = KiemTraTonTai(xtraTabControl1, "Xuất kho");
            if (Index >= 0)
            {
                xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages[Index];
                xtraTabControl1.SelectedTabPage.Text = "Xuất kho";
            }
            else
            {
                XtraTabPage TabPage = new XtraTabPage { Text = "Xuất kho" };
                xtraTabControl1.TabPages.Add(TabPage);
                xtraTabControl1.SelectedTabPage = TabPage;

                F300_Xuat_kho v_f = new F300_Xuat_kho();
                v_f.TopLevel = false;
                v_f.Parent = TabPage;
                v_f.Show();
                //v_f.Dock = DockStyle.Fill;
            }
        }
    }
}
