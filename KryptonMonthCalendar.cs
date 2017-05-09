using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace AC.ExtendedRenderer.Toolkit
{
    [System.Drawing.ToolboxBitmapAttribute(typeof(System.Windows.Forms.MonthCalendar))]
   public class KryptonMonthCalendar : ComponentFactory.Krypton.Toolkit.KryptonMonthCalendar
    {

        public KryptonMonthCalendar()
        {
            //set some Styles
            SetStyle(ControlStyles.SupportsTransparentBackColor |ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();

            //Init today date
            this.TodayDate = DateTime.Today;
        }

    }
}
