using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
namespace BKI_KHO
{
    internal class HostedControl
    {
        internal C1FlexGrid _flex;
        internal Control _ctl;
        internal Row _row;
        internal Column _col;

        /// <summary>
        /// Hosted Control
        /// Helper class that contains a control hosted within a C1FlexGrid
        /// </summary>
        /// <param name="flex"></param>
        /// <param name="hosted"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        internal HostedControl(C1FlexGrid flex, Control hosted, int row, int col)
        {
            //save info
            _flex = flex;
            _ctl = hosted;
            _row = flex.Rows[row];
            _col = flex.Cols[col];

            //insert hosted control to grid
            _flex.Controls.Add(_ctl);
        }

        internal bool UpdatePosition()
        {
            //get row-col indices
            int r = _row.Index;
            int c = _col.Index;
            if (r<0 || c<0)
            {
                return false;
            }

            //get cel rect
            Rectangle rc = _flex.GetCellRect(r, c, false);

            //hide control if out of range
            if (rc.Width < 0 || rc.Height < 0 || !rc.IntersectsWith(_flex.ClientRectangle))
            {
                _ctl.Visible = false;
                return true;
            }
            //move the control and show it
            _ctl.Bounds = rc;
            _ctl.Visible = true;

            return true;
        }
    }
}
