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

namespace AC.StdControls.Toolkit.GridView
{
    public class DataGridViewColoredTextBoxColumn : DataGridViewTextBoxColumn
    {
        // Methods
        public DataGridViewColoredTextBoxColumn()
        {
            this.CellTemplate = new DataGridViewColoredTextBox();
        }
    }

    public class DataGridViewColoredTextBox : DataGridViewTextBoxCell
    {
        protected override void PaintBorder(System.Drawing.Graphics graphics, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle bounds, System.Windows.Forms.DataGridViewCellStyle cellStyle, System.Windows.Forms.DataGridViewAdvancedBorderStyle advancedBorderStyle)
        {
            base.PaintBorder(graphics, clipBounds, bounds, cellStyle, advancedBorderStyle);
        }

        protected override void Paint(System.Drawing.Graphics graphics, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, System.Windows.Forms.DataGridViewElementStates elementState, object value, object formattedValue, string errorText, System.Windows.Forms.DataGridViewCellStyle cellStyle, System.Windows.Forms.DataGridViewAdvancedBorderStyle advancedBorderStyle,
        System.Windows.Forms.DataGridViewPaintParts paintParts)
        {
            try
            {
                object o;
                o = value;

                if ((((o) != null)))
                {
                    double c;
                    c = Conversions.ToDouble(o);
                    //Debug
                    //MessageBox.Show(c)


                    //erase background
                    if (c < 0)
                    {
                        cellStyle.BackColor = Color.FromArgb(255, 200, 200);
                    }
                    else if (c == 0)
                    {
                        cellStyle.BackColor = Color.FromArgb(200, 200, 255);
                    }
                    else if (c > 0)
                    {
                        cellStyle.BackColor = Color.FromArgb(200, 255, 200);
                    }
                }

                base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle,
                paintParts);

                PaintBorder(graphics, clipBounds, cellBounds, cellStyle, advancedBorderStyle);

            }
            catch 
            {
                // empty catch 
                //MessageBox.Show(ex.Message)
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle,
                paintParts);
                PaintBorder(graphics, clipBounds, cellBounds, cellStyle, advancedBorderStyle);
            }
        }


    }

}
