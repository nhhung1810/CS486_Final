

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPV202_CS486_Team11
{
    class Trio : Control
    {
        private int width = 0;
        private int height = 0;
        public Trio(string name, string author, bool official, bool sq, string view)
        {


            Width = width;
            Height = 50;
        }

        private void addControl(Control control, int paddingWidth, int paddingHeight, int maxPadding = -1)
        {
            control.Location = new Point(width + paddingWidth, paddingHeight);
            control.Width = control.PreferredSize.Width;
            if (maxPadding != -1) control.Width = maxPadding;
            width += control.Width + paddingWidth;
            height = Math.Max(height, control.Height);
            Controls.Add(control);
        }
    }
}
