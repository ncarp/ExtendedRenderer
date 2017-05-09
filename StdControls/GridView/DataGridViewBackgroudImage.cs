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

namespace AC.StdControls.Toolkit.GridView
{
    [System.Drawing.ToolboxBitmapAttribute(typeof(System.Windows.Forms.DataGridView)), ToolboxItem(false)]
    public class DataGridViewBackgroudImage : DataGridView
    {
        // Fields
        private Image m_Image;

        // Methods
        public DataGridViewBackgroudImage()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void PaintBackground(Graphics graphics, Rectangle clipBounds, Rectangle gridBounds)
        {
            if (this.m_Image != null)
            {
                base.PaintBackground(graphics, clipBounds, gridBounds);
                graphics.DrawImage(this.m_Image, gridBounds);
            }
            else
            {
                base.PaintBackground(graphics, clipBounds, gridBounds);
            }
        }

        // Properties
        [Category("Appearance"), Description("Set Background Image")]
        public Image BackImage
        {
            get
            {
                return this.m_Image;
            }
            set
            {
                this.m_Image = value;
            }
        }
    }


}
