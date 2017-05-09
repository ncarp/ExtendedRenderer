using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using ComponentFactory.Krypton.Toolkit;

namespace System.Windows.Forms.Calendar
{
    public class CalendarKryptonRenderer : CalendarSystemRenderer
    {
        #region "Fields"

        public Color HeaderA = Color.Blue;
        public Color HeaderB = Color.Blue;
        public float HeaderBackColorAngle;
        //  Public HeaderD As Color = Color.Blue

        public Color TodayA = Color.Yellow;
        public Color TodayB = Color.Yellow;
        //  Public TodayC As Color = Color.Yellow
        //  Public TodayD As Color = Color.Yellow
        #endregion

        #region "Krypton Members"
        private IPalette _palette;
        //private PaletteRedirect _paletteRedirect;
        #endregion

        #region "Ctor"

        public CalendarKryptonRenderer(Calendar c)
            : base(c)
        {

            ReloadPalette();
        }

        public override void ReloadPalette()
        {
            base.ReloadPalette();
            _palette = KryptonManager.CurrentGlobalPalette;


            if (_palette != null)
            {
                HeaderA = _palette.GetBackColor2(PaletteBackStyle.HeaderForm, PaletteState.Normal);
                HeaderB = _palette.GetBackColor1(PaletteBackStyle.HeaderForm, PaletteState.Normal);
                TodayA = _palette.GetBackColor1(PaletteBackStyle.ButtonStandalone, PaletteState.CheckedNormal);
                TodayB = _palette.GetBackColor2(PaletteBackStyle.ButtonStandalone, PaletteState.CheckedNormal);
                HeaderBackColorAngle = _palette.GetBackColorAngle(PaletteBackStyle.ButtonStandalone, PaletteState.Normal);

                ColorTable.Background = _palette.GetBackColor1(PaletteBackStyle.PanelClient, PaletteState.Normal);
                ColorTable.DayBackgroundOdd = _palette.GetBackColor1(PaletteBackStyle.TabOneNote, PaletteState.Normal);
                ColorTable.DayBackgroundEven = _palette.GetBackColor1(PaletteBackStyle.PanelClient, PaletteState.Disabled);

                ColorTable.DayBackgroundSelected = _palette.GetBackColor1(PaletteBackStyle.ButtonStandalone, PaletteState.Tracking);
                ColorTable.DayBorder = _palette.GetBorderColor1(PaletteBorderStyle.GridDataCellSheet, PaletteState.Normal);

                ColorTable.DayHeaderBackground = _palette.GetBackColor1(PaletteBackStyle.ButtonStandalone, PaletteState.Normal);

                ColorTable.DayHeaderText = _palette.GetContentShortTextColor2(PaletteContentStyle.HeaderForm, PaletteState.Normal);

                ColorTable.DayHeaderSecondaryText = _palette.GetContentShortTextColor1(PaletteContentStyle.ButtonStandalone, PaletteState.Normal);
                ColorTable.DayTopBorder = ColorTable.DayBorder;

                ColorTable.DayTopSelectedBorder = _palette.GetBorderColor1(PaletteBorderStyle.ButtonStandalone, PaletteState.CheckedPressed);

                ColorTable.DayTopBackground = _palette.GetBackColor1(PaletteBackStyle.InputControlStandalone, PaletteState.Normal);
                ColorTable.DayTopSelectedBackground = _palette.GetBackColor2(PaletteBackStyle.InputControlStandalone, PaletteState.Tracking);

                ColorTable.ItemBorder = _palette.GetBorderColor2(PaletteBorderStyle.InputControlStandalone, PaletteState.Normal);
                ColorTable.ItemBackground = _palette.GetBackColor2(PaletteBackStyle.InputControlStandalone, PaletteState.Normal);
                ColorTable.ItemText = _palette.GetContentShortTextColor1(PaletteContentStyle.InputControlStandalone, PaletteState.Normal);
                ColorTable.ItemShadow = Color.LightGray;

                ColorTable.ItemSecondaryText = Color.Red;
                //palette.GetContentShortTextColor1(PaletteBackStyle.InputControlRibbon, PaletteState.Normal)
                ColorTable.ItemSelectedBorder = _palette.GetBorderColor1(PaletteBorderStyle.InputControlRibbon, PaletteState.Tracking);
                ColorTable.ItemSelectedBackground = _palette.GetBackColor1(PaletteBackStyle.InputControlRibbon, PaletteState.Tracking);

                ColorTable.ItemSelectedText = _palette.GetContentShortTextColor1(PaletteContentStyle.InputControlRibbon, PaletteState.Normal);

                ColorTable.WeekHeaderBackground = Color.Transparent;
                //palette.GetBorderColor1(PaletteBackStyle.InputControlRibbon, PaletteState.Pressed)
                ColorTable.WeekHeaderBorder = Color.Transparent;
                //palette.GetBackColor1(PaletteBackStyle.InputControlRibbon, PaletteState.Normal)
                ColorTable.WeekHeaderText = _palette.GetContentShortTextColor1(PaletteContentStyle.HeaderForm, PaletteState.Normal);
                ColorTable.WeekDayName = _palette.GetContentShortTextColor1(PaletteContentStyle.HeaderForm, PaletteState.Normal);

                ColorTable.TodayBorder = _palette.GetBorderColor1(PaletteBorderStyle.ButtonStandalone, PaletteState.CheckedTracking);

                //ColorTable.TodayTopBackground = Color.Red

                ColorTable.TimeScaleLine = _palette.GetBorderColor1(PaletteBorderStyle.HeaderPrimary, PaletteState.Normal);
                ColorTable.TimeScaleHours = _palette.GetContentShortTextColor1(PaletteContentStyle.HeaderPrimary, PaletteState.Normal);
                //palette.GetBorderColor2(PaletteBorderStyle.GridDataCellSheet, PaletteState.Normal)
                ColorTable.TimeScaleMinutes = _palette.GetContentShortTextColor1(PaletteContentStyle.HeaderPrimary, PaletteState.Normal);

                ColorTable.TimeUnitBackground = _palette.GetBackColor1(PaletteBackStyle.InputControlStandalone, PaletteState.Disabled);
                ColorTable.TimeUnitHighlightedBackground = _palette.GetBackColor1(PaletteBackStyle.InputControlStandalone, PaletteState.Normal);
                ColorTable.TimeUnitSelectedBackground = _palette.GetBackColor1(PaletteBackStyle.ButtonButtonSpec, PaletteState.Tracking);

                ColorTable.TimeUnitBorderLight = _palette.GetBorderColor2(PaletteBorderStyle.GridDataCellSheet, PaletteState.Normal);
                ColorTable.TimeUnitBorderDark = _palette.GetBorderColor1(PaletteBorderStyle.HeaderPrimary, PaletteState.Normal);


                ItemRoundness = _palette.GetBorderRounding(PaletteBorderStyle.ButtonStandalone, PaletteState.Normal);
            }
        }

        #endregion

        #region "Private Method"

        public void GlossyRect(Graphics g, Rectangle bounds, Color a, Color b, float backColorAngle)
        {
            using (LinearGradientBrush backBrush = new LinearGradientBrush(bounds, a, b, HeaderBackColorAngle))
            {
                g.FillRectangle(backBrush, bounds);
            }
        }

        ///' <summary>
        ///' Shortcut to one on CalendarColorTable
        ///' </summary>
        ///' <param name="color"></param>
        ///' <returns></returns>
        //Private Shared Function FromHex(ByVal color As String) As Color
        //    Return CalendarColorTable.FromHex(color)
        //End Function

        #endregion

        #region "Overrides"

        public override void OnInitialize(CalendarRendererEventArgs e)
        {
            if (_palette != null)
                e.Calendar.Font = _palette.GetContentShortTextFont(PaletteContentStyle.InputControlStandalone, PaletteState.Normal);
            base.OnInitialize(e);
        }

        public override void OnDrawDayHeaderBackground(CalendarRendererDayEventArgs e)
        {
            Rectangle r = e.Day.HeaderBounds;

            if (e.Day.Date == DateTime.Today)
            {
                GlossyRect(e.Graphics, e.Day.HeaderBounds, TodayA, TodayB, HeaderBackColorAngle);
            }
            else
            {
                GlossyRect(e.Graphics, e.Day.HeaderBounds, HeaderA, HeaderB, HeaderBackColorAngle);
            }

            if (e.Calendar.DaysMode == CalendarDaysMode.Short)
            {
                using (Pen p = new Pen(_palette.ColorTable.ButtonPressedBorder))
                {
                    e.Graphics.DrawLine(p, r.Left, r.Top, r.Right, r.Top);
                    e.Graphics.DrawLine(p, r.Left, r.Bottom, r.Right, r.Bottom);
                }
            }
        }

        public override void OnDrawItemBorder(CalendarRendererItemBoundsEventArgs e)
        {
            base.OnDrawItemBorder(e);

            using (Pen p = new Pen(_palette.ColorTable.MenuItemSelectedGradientBegin))
            {
                e.Graphics.DrawLine(p, e.Bounds.Left + ItemRoundness, e.Bounds.Top + 1, e.Bounds.Right - ItemRoundness, e.Bounds.Top + 1);
            }

            if (e.Item.Selected && !e.Item.IsDragging)
            {
                bool horizontal = false;
                bool vertical = false;
                Rectangle r1 = new Rectangle(0, 0, 5, 5);
                Rectangle r2 = new Rectangle(0, 0, 5, 5);

                horizontal = e.Item.IsOnDayTop;
                vertical = !e.Item.IsOnDayTop && e.Calendar.DaysMode == CalendarDaysMode.Expanded;

                if (horizontal)
                {
                    r1.X = e.Bounds.Left - 2;
                    r2.X = e.Bounds.Right - r1.Width + 2;
                    r1.Y = e.Bounds.Top + (e.Bounds.Height - r1.Height) / 2;
                    r2.Y = r1.Y;
                }

                if (vertical)
                {
                    r1.Y = e.Bounds.Top - 2;
                    r2.Y = e.Bounds.Bottom - r1.Height + 2;
                    r1.X = e.Bounds.Left + (e.Bounds.Width - r1.Width) / 2;
                    r2.X = r1.X;
                }

                if ((horizontal || vertical) && Calendar.AllowItemResize)
                {
                    if (!e.Item.IsOpenStart && e.IsFirst)
                    {
                        e.Graphics.FillRectangle(Brushes.White, r1);
                        e.Graphics.DrawRectangle(Pens.Red, r1);
                    }

                    if (!e.Item.IsOpenEnd && e.IsLast)
                    {
                        e.Graphics.FillRectangle(Brushes.White, r2);
                        e.Graphics.DrawRectangle(Pens.Red, r2);
                    }
                }
            }
        }

        public override void OnDrawDayHeaderText(CalendarRendererBoxEventArgs e)
        {
            if (_palette != null)
                e.TextColor = _palette.GetContentShortTextColor1(PaletteContentStyle.HeaderForm, PaletteState.Normal);
            base.OnDrawDayHeaderText(e);
        }


        #endregion



    }
}

