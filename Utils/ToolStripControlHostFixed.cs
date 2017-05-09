using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
using System.Drawing;

namespace AC.ExtendedRenderer.Toolkit.Utils
{
    public class ToolStripControlHostFixed : ToolStripControlHost
    {
        public ToolStripControlHostFixed()
            : base(new Control())
        {
        }

        public ToolStripControlHostFixed(Control c)
            : base(c)
        {
        }

    }
}
