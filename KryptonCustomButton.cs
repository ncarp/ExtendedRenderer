using System;
using System.Drawing;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using ComponentFactory.Krypton.Toolkit;

namespace AC.ExtendedRenderer.Toolkit
{
    [ToolboxBitmap(typeof(System.Windows.Forms.Button))]
    public class KryptonCustomButton : AC.StdControls.Toolkit.Buttons.CustomButton
    {
        private IPalette _palette;
        private PaletteRedirect _paletteRedirect;


        public KryptonCustomButton()
        {
            //InitializeComponent();
            // Cache the current global palette setting
            _palette = KryptonManager.CurrentGlobalPalette;

            // Hook into palette events
            if (_palette != null)
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            // We want to be notified whenever the global palette changes
            KryptonManager.GlobalPaletteChanged += new EventHandler(OnGlobalPaletteChanged);

            // Create redirection object to the base palette
            _paletteRedirect = new PaletteRedirect(_palette);

            InitColors();
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            try
            {
                InitColors();
            }
            catch
            {
            }
        }
        private void InitColors()
        {
            GradientTop = _palette.ColorTable.ToolStripGradientBegin;
            GradientBottom = _palette.ColorTable.ToolStripGradientMiddle;
            GradientBorderColor = _palette.ColorTable.ToolStripBorder;
            if (GradientBorderColor == Color.White) GradientBorderColor = Color.LightGray;
            this.ForeColor = _palette.ColorTable.ToolStripText;
            HotForeColor = _palette.ColorTable.ToolStripText;
            PressedForeColor = _palette.ColorTable.ToolStripText;
        }

        //Kripton Palette Events
        private void OnGlobalPaletteChanged(object sender, EventArgs e)
        {
            // Unhook events from old palette
            if (_palette != null)
                _palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            // Cache the new IPalette that is the global palette
            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect.Target = _palette;

            // Hook into events for the new palette
            if (_palette != null)
            {
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
                InitColors();
            }

            // Change of palette means we should repaint to show any changes
            Invalidate();
        }

        //Kripton Palette Events
        private void OnPalettePaint(object sender, PaletteLayoutEventArgs e)
        {
            Invalidate();
        }

    }
}
