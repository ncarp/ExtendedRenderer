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

namespace AC.ExtendedRenderer.Toolkit.Charting
{
    [System.Drawing.ToolboxBitmapAttribute(typeof(System.Windows.Forms.Timer))]
    public class KryptonAquaGauge : AquaGauge
    {
        private IPalette _palette;
        private PaletteRedirect _paletteRedirect;

        #region ... Constructor ...
        public KryptonAquaGauge()
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
        #endregion

        private void InitColors()
        {
            this.DialColor = _palette.ColorTable.ToolStripGradientBegin;
            this.ForeColor = _palette.ColorTable.StatusStripText;
            this.DigitColor = _palette.ColorTable.StatusStripText;
            /*
            this.ThickCalibrationColor = _palette.ColorTable.StatusStripGradientEnd;
            this.ThinCalibrationColor = _palette.ColorTable.ToolStripGradientEnd;
            this.HandColor = _palette.ColorTable.MenuStripGradientEnd;
            this.CenterPointColor = _palette.ColorTable.MenuStripGradientEnd;
            */
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
