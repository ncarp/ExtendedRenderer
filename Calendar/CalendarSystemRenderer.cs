using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace System.Windows.Forms.Calendar
{
    /// <summary>
    /// CalendarRenderer that renders low-intensity calendar for slow computers
    /// </summary>
    public class CalendarSystemRenderer
        : CalendarRenderer
    {
        #region Fields
        private CalendarColorTable _colorTable;
        private float _selectedItemBorder;
        #endregion

        #region Ctor

        public CalendarSystemRenderer(Calendar calendar)
            : base(calendar)
        {
            ColorTable = new CalendarColorTable();
            SelectedItemBorder = 1;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the <see cref="CalendarColorTable"/> for this renderer
        /// </summary>
        public CalendarColorTable ColorTable
        {
            get { return _colorTable; }
            set { _colorTable = value; }
        }

        /// <summary>
        /// Gets or sets the size of the border of selected items
        /// </summary>
        public float SelectedItemBorder
        {
            get { return _selectedItemBorder; }
            set { _selectedItemBorder = value; }
        }


        #endregion

        #region Overrides

        public override void OnDrawBackground(CalendarRendererEventArgs e)
        {
            e.Graphics.Clear(ColorTable.Background);
        }

        public override void OnDrawDay(CalendarRendererDayEventArgs e)
        {
            Rectangle r = e.Day.Bounds;

            if (e.Day.Selected)
            {
                using (Brush b = new SolidBrush(ColorTable.DayBackgroundSelected))
                {
                    e.Graphics.FillRectangle(b, r); 
                }
            }
            else if (e.Day.Date.Month % 2 == 0)
            {
                using (Brush b = new SolidBrush(ColorTable.DayBackgroundEven))
                {
                    e.Graphics.FillRectangle(b, r);
                }
            }
            else
            {
                using (Brush b = new SolidBrush(ColorTable.DayBackgroundOdd))
                {
                    e.Graphics.FillRectangle(b, r);
                }
            }

            base.OnDrawDay(e);
        }

        public override void OnDrawDayBorder(CalendarRendererDayEventArgs e)
        {
            base.OnDrawDayBorder(e);

            Rectangle r = e.Day.Bounds;
            bool today = e.Day.Date.Date.Equals(DateTime.Today.Date);

            using (Pen p = new Pen(today ? ColorTable.TodayBorder : ColorTable.DayBorder, today ? 2 : 1))
            {
                if (e.Calendar.DaysMode == CalendarDaysMode.Short)
                {
                    e.Graphics.DrawLine(p, r.Right, r.Top, r.Right, r.Bottom);
                    e.Graphics.DrawLine(p, r.Left, r.Bottom, r.Right, r.Bottom);

                    if (e.Day.Date.DayOfWeek == DayOfWeek.Sunday || today)
                    {
                        e.Graphics.DrawLine(p, r.Left, r.Top, r.Left, r.Bottom);
                    }
                }
                else
                {
                    e.Graphics.DrawRectangle(p, r);
                }
            }
        }

        public override void OnDrawDayTop(CalendarRendererDayEventArgs e)
        {
            bool s = e.Day.DayTop.Selected;

            using (Brush b = new SolidBrush( s ? ColorTable.DayTopSelectedBackground : ColorTable.DayTopBackground))
            {
                e.Graphics.FillRectangle(b, e.Day.DayTop.Bounds);
            }

            using (Pen p = new Pen(s ? ColorTable.DayTopSelectedBorder : ColorTable.DayTopBorder))
            {
                e.Graphics.DrawRectangle(p, e.Day.DayTop.Bounds);
            }

            base.OnDrawDayTop(e);
        }

        public override void OnDrawDayHeaderBackground(CalendarRendererDayEventArgs e)
        {
            bool today = e.Day.Date.Date.Equals(DateTime.Today.Date);

            using (Brush b = new SolidBrush(today ? ColorTable.TodayTopBackground : ColorTable.DayHeaderBackground))
            {
                e.Graphics.FillRectangle(b, e.Day.HeaderBounds);
            }

            base.OnDrawDayHeaderBackground(e);
        }

        public override void OnDrawWeekHeader(CalendarRendererBoxEventArgs e)
        {
            using (Brush b = new SolidBrush(ColorTable.WeekHeaderBackground))
            {
                e.Graphics.FillRectangle(b, e.Bounds);
            }

            using (Pen p = new Pen(ColorTable.WeekHeaderBorder))
            {
                e.Graphics.DrawRectangle(p, e.Bounds);
            }

            e.TextColor = ColorTable.WeekHeaderText;

            base.OnDrawWeekHeader(e);
        }

        public override void OnDrawDayTimeUnit(CalendarRendererTimeUnitEventArgs e)
        {
            base.OnDrawDayTimeUnit(e);

            using (SolidBrush b = new SolidBrush(ColorTable.TimeUnitBackground))
            {
                if (e.Unit.Selected)
                {
                    b.Color = ColorTable.TimeUnitSelectedBackground;
                }
                else if (e.Unit.Highlighted)
                {
                    b.Color = ColorTable.TimeUnitHighlightedBackground;
                }

                e.Graphics.FillRectangle(b, e.Unit.Bounds);
            }

            using (Pen p = new Pen(e.Unit.Minutes == 0 ? ColorTable.TimeUnitBorderDark : ColorTable.TimeUnitBorderLight))
            {
                e.Graphics.DrawLine(p, e.Unit.Bounds.Location, new Point(e.Unit.Bounds.Right, e.Unit.Bounds.Top)); 
            }

            //TextRenderer.DrawText(e.Graphics, e.Unit.PassingItems.Count.ToString(), e.Calendar.Font, e.Unit.Bounds, Color.Black);
        }

        public override void OnDrawTimeScale(CalendarRendererEventArgs e)
        {
            int margin = 5;
            int largeX1 = TimeScaleBounds.Left + margin;
            int largeX2 = TimeScaleBounds.Right - margin;
            int shortX1 = TimeScaleBounds.Left + TimeScaleBounds.Width / 2;
            int shortX2 = largeX2;
            int top = 0;
            Pen p = new Pen(ColorTable.TimeScaleLine);

            for (int i = 0; i < e.Calendar.Days[0].TimeUnits.Length; i++)
            {
                CalendarTimeScaleUnit unit = e.Calendar.Days[0].TimeUnits[i];

                if (!unit.Visible) continue;

                top = unit.Bounds.Top;

                if (unit.Minutes == 0)
                {
                    e.Graphics.DrawLine(p, largeX1, top, largeX2, top);
                }
                else
                {
                    e.Graphics.DrawLine(p, shortX1, top, shortX2, top);
                }
            }

            if (e.Calendar.DaysMode == CalendarDaysMode.Expanded
                && e.Calendar.Days != null
                && e.Calendar.Days.Length > 0
                && e.Calendar.Days[0].TimeUnits != null
                && e.Calendar.Days[0].TimeUnits.Length > 0
                )
            {
                top = e.Calendar.Days[0].BodyBounds.Top;
                
                //Timescale top line is full
                e.Graphics.DrawLine(p, TimeScaleBounds.Left, top, TimeScaleBounds.Right, top);
            }

            p.Dispose();

            base.OnDrawTimeScale(e);
        }

        public override void OnDrawTimeScaleHour(CalendarRendererBoxEventArgs e)
        {
            e.TextColor = ColorTable.TimeScaleHours;
            base.OnDrawTimeScaleHour(e);
        }

        public override void OnDrawTimeScaleMinutes(CalendarRendererBoxEventArgs e)
        {
            e.TextColor = ColorTable.TimeScaleMinutes;
            base.OnDrawTimeScaleMinutes(e);
        }

        public override void OnDrawItemBackground(CalendarRendererItemBoundsEventArgs e)
        {
            base.OnDrawItemBackground(e);

            int alpha = 255;

            if (e.Item.IsDragging)
            {
                alpha = 120;
            }
            else if (e.Calendar.DaysMode == CalendarDaysMode.Short)
            {
                alpha = 200;
            }

            Color color1 = Color.White;
            Color color2 = e.Item.Selected ? ColorTable.ItemSelectedBackground : ColorTable.ItemBackground;

            if (!e.Item.BackgroundColorLighter.IsEmpty)
            {
                color1 = e.Item.BackgroundColorLighter;
            }

            if (!e.Item.BackgroundColor.IsEmpty)
            {
                color2 = e.Item.BackgroundColor;
            }

            ItemFill(e, e.Bounds, Color.FromArgb(alpha, color1), Color.FromArgb(alpha, color2));

        }

        public override void OnDrawItemShadow(CalendarRendererItemBoundsEventArgs e)
        {
            base.OnDrawItemShadow(e);

            if (e.Item.IsOnDayTop || e.Calendar.DaysMode == CalendarDaysMode.Short || e.Item.IsDragging)
            {
                return;
            }

            Rectangle r = e.Bounds;
            r.Offset(ItemShadowPadding, ItemShadowPadding);

            using (SolidBrush b = new SolidBrush(ColorTable.ItemShadow))
            {
                ItemFill(e, r, ColorTable.ItemShadow, ColorTable.ItemShadow);
            }
        }

        public override void OnDrawItemBorder(CalendarRendererItemBoundsEventArgs e)
        {
            base.OnDrawItemBorder(e);

            Color a = e.Item.BorderColor.IsEmpty ? ColorTable.ItemBorder : e.Item.BorderColor;
            Color b = e.Item.Selected && !e.Item.IsDragging ? ColorTable.ItemSelectedBorder : a;
            Color c = Color.FromArgb(e.Item.IsDragging ? 120 : 255, b);

            ItemBorder(e, e.Bounds, c, e.Item.Selected && !e.Item.IsDragging ? SelectedItemBorder : 1f);
            
        }

        public override void OnDrawItemStartTime(CalendarRendererBoxEventArgs e)
        {
            if (e.TextColor.IsEmpty)
            {
                e.TextColor = ColorTable.ItemSecondaryText;
            }

            base.OnDrawItemStartTime(e);
        }

        public override void OnDrawItemEndTime(CalendarRendererBoxEventArgs e)
        {
            if (e.TextColor.IsEmpty)
            {
                e.TextColor = ColorTable.ItemSecondaryText;
            }

            base.OnDrawItemEndTime(e);
        }

        public override void OnDrawItemText(CalendarRendererBoxEventArgs e)
        {
            CalendarItem item = e.Tag as CalendarItem;
            
            if (item != null)
            {
                if (item.IsDragging)
                {
                    e.TextColor = Color.FromArgb(120, e.TextColor);
                }
            }

            base.OnDrawItemText(e);
        }

        public override void OnDrawWeekHeaders(CalendarRendererEventArgs e)
        {
            base.OnDrawWeekHeaders(e);
        }

        public override void OnDrawDayNameHeader(CalendarRendererBoxEventArgs e)
        {
            e.TextColor = ColorTable.WeekDayName;

            base.OnDrawDayNameHeader(e);

            using (Pen p = new Pen(ColorTable.WeekDayName))
            {
                e.Graphics.DrawLine(p, e.Bounds.Right, e.Bounds.Top, e.Bounds.Right, e.Bounds.Bottom);
            }
        }

        public override void OnDrawDayOverflowEnd(CalendarRendererDayEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int top = e.Day.OverflowEndBounds.Top + e.Day.OverflowEndBounds.Height / 2;
                path.AddPolygon(new Point[] { 
                    new Point(e.Day.OverflowEndBounds.Left, top),
                    new Point(e.Day.OverflowEndBounds.Right, top),
                    new Point(e.Day.OverflowEndBounds.Left + e.Day.OverflowEndBounds.Width / 2, e.Day.OverflowEndBounds.Bottom),
                });

                using (Brush b = new SolidBrush(e.Day.OverflowEndSelected ? ColorTable.DayOverflowSelectedBackground : ColorTable.DayOverflowBackground))
                {
                    e.Graphics.FillPath(b, path);
                }

                using (Pen p = new Pen(ColorTable.DayOverflowBorder))
                {
                    e.Graphics.DrawPath(p, path);
                }
            }
        }

        #endregion
    }
}
