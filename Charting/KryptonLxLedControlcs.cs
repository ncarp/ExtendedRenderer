using System;
using System.Collections.Generic;
using System.Text;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;
using System.Drawing;

namespace AC.ExtendedRenderer.Toolkit.Charting
{
    [System.Drawing.ToolboxBitmapAttribute(typeof(System.Windows.Forms.Control))]
    public class KryptonLxLedControl : LxLedControl
    {
        private IPalette _palette;
        private PaletteRedirect _paletteRedirect;

        public KryptonLxLedControl()
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

            InitColors();

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //e.Graphics.FillRectangle(new SolidBrush(Color.Red), e.ClipRectangle);

        }


        #region ... Krypton ...
        private void InitColors()
        {
            this.HighlightOpaque = 75;
            this.BackColor = Color.Transparent;

            this.BackColor_1 = _palette.ColorTable.ToolStripGradientEnd;
            this.BackColor_2 = _palette.ColorTable.ToolStripGradientEnd;

            this.FadedColor = _palette.ColorTable.ToolStripGradientMiddle;

            //for sparkle
            if (FadedColor == BackColor_2) this.FadedColor = _palette.ColorTable.ToolStripGradientBegin;

            this.BorderColor = _palette.ColorTable.ToolStripBorder;

            this.FocusedBorderColor = _palette.ColorTable.ToolStripBorder;
            this.ForeColor = _palette.ColorTable.ToolStripText;
            Invalidate();

        }


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

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_palette != null)
                {
                    _palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
                    _palette = null;
                }

                KryptonManager.GlobalPaletteChanged -= new EventHandler(OnGlobalPaletteChanged);
            }

            base.Dispose(disposing);
        }
        #endregion
    }
}
