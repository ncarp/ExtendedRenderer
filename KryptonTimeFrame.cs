using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using ComponentFactory.Krypton.Toolkit;

namespace AC.ExtendedRenderer.Toolkit
{
    [System.Drawing.ToolboxBitmapAttribute(typeof(System.Windows.Forms.MonthCalendar))]
    public class KryptonTimeFrame : TimeFrame
    {
        private IPalette _palette;
        private PaletteRedirect _paletteRedirect;
        private PaletteBackInheritRedirect _paletteBack;
        private PaletteBorderInheritRedirect _paletteBorder;
        private PaletteContentInheritRedirect _paletteContent;

        #region ... Constructor ...
        public KryptonTimeFrame()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            UpdateStyles();

            // add Palette Handler
            if (_palette != null)
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            KryptonManager.GlobalPaletteChanged += new EventHandler(OnGlobalPaletteChanged);

            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect = new PaletteRedirect(_palette);
            _paletteBack = new PaletteBackInheritRedirect(_paletteRedirect);
            _paletteBorder = new PaletteBorderInheritRedirect(_paletteRedirect);
            _paletteContent = new PaletteContentInheritRedirect(_paletteRedirect);

            InitColors();


        }
        #endregion

        private void InitColors()
        {
            this.BackColor = _palette.ColorTable.ToolStripGradientBegin;
            this.ForeColor = _palette.GetContentShortTextColor1(PaletteContentStyle.LabelNormalControl, PaletteState.Normal);
            this.Font = _palette.ColorTable.MenuStripFont;
            this.HotTrack = _palette.GetBackColor1(PaletteBackStyle.ButtonStandalone, PaletteState.Tracking);
            this.Selected = _palette.GetBackColor2(PaletteBackStyle.ButtonNavigatorStack, PaletteState.Pressed);
            this.GridDarkColor = _palette.ColorTable.ToolStripGradientEnd;
            this.GridLightColor = _palette.ColorTable.ToolStripGradientMiddle;

        }


        #region ... Krypton ...

        //Kripton Palette Events
        private void OnGlobalPaletteChanged(object sender, EventArgs e)
        {
            if (_palette != null)
                _palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect.Target = _palette;

            if (_palette != null)
            {
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
                //repaint with new values

                InitColors();

            }

            Invalidate();
        }

        //Kripton Palette Events
        private void OnPalettePaint(object sender, PaletteLayoutEventArgs e)
        {
            Invalidate();
        }
        #endregion

    }
}
