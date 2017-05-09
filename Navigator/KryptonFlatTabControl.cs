using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using ComponentFactory.Krypton.Toolkit;
using System.Drawing;

namespace AC.ExtendedRenderer.Navigator
{
    [ToolboxBitmap(typeof(System.Windows.Forms.TabControl))]
    public partial class KryptonFlatTabControl : FlatTabControl
    {

        private IPalette _palette;
        private PaletteRedirect _paletteRedirect;

        public KryptonFlatTabControl()
        {
            InitializeComponent();
            // add Palette Handler
            if (_palette != null)
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            KryptonManager.GlobalPaletteChanged += new EventHandler(OnGlobalPaletteChanged);

            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect = new PaletteRedirect(_palette);

            InitColors();
        }

        public KryptonFlatTabControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            // add Palette Handler
            if (_palette != null)
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            KryptonManager.GlobalPaletteChanged += new EventHandler(OnGlobalPaletteChanged);

            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect = new PaletteRedirect(_palette);

            InitColors();

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
                {
                    InitColors();
                }
            }

            Invalidate();
        }

        //Kripton Palette Events
        private void OnPalettePaint(object sender, PaletteLayoutEventArgs e)
        {
            Invalidate();
        }

        private void InitColors()
        {
            this.HotTrack = true;

            this.StandardBackColor = _palette.ColorTable.ToolStripContentPanelGradientEnd;
            this.BorderColor = _palette.ColorTable.ToolStripBorder;

            this.ButtonsBackColor = _palette.ColorTable.ToolStripContentPanelGradientEnd;
            this.ButtonsBorderColor = _palette.ColorTable.ToolStripBorder;

            this.TabColorHotDark = _palette.ColorTable.MenuItemSelectedGradientBegin;
            this.TabColorHotLight = _palette.ColorTable.MenuItemSelectedGradientBegin;

            this.TabColorSelectedDark = _palette.ColorTable.ButtonPressedGradientEnd;
            this.TabColorSelectedLight = _palette.ColorTable.ButtonPressedGradientMiddle;

            this.TabForeColor = _palette.ColorTable.MenuItemText;
            this.TabHotForeColor = _palette.ColorTable.MenuItemText;

            this.TabColorDefaultDark = _palette.ColorTable.ToolStripGradientBegin;
            this.TabColorDefaultLight = _palette.ColorTable.ToolStripGradientBegin;

            Invalidate();

        }

        #endregion
    }
}
