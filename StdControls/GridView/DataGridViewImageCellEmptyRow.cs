using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Collections;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;
using AC.ExtendedRenderer.Toolkit.Drawing;

namespace AC.StdControls.Toolkit.GridView
{
    public class DataGridViewImageCellEmptyRow : DataGridViewImageCell
    {
        // Methods
        public DataGridViewImageCellEmptyRow()
        {
        }

        public DataGridViewImageCellEmptyRow(bool valueIsIcon)
            : base(valueIsIcon)
        {
        }

        // Properties
        public override object DefaultNewRowValue
        {
            get
            {
                return DBNull.Value;
            }
        }
    }


}
