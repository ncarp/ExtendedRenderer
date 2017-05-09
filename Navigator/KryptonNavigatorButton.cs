using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Design;
using System.Security.Permissions;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using AC.ExtendedRenderer.Toolkit.Utils;
using AC.ExtendedRenderer.Toolkit.Drawing;
using ComponentFactory.Krypton.Toolkit;
namespace AC.ExtendedRenderer.Toolkit.Navigator
{

    #region ... KryptonNavigatorButton ...
    [System.Drawing.ToolboxBitmapAttribute(typeof(System.Windows.Forms.Button)), ToolboxItem(false)]
    public class KryptonNavigatorButton : ComponentFactory.Krypton.Toolkit.KryptonButton
    {

        private static IPalette _palette;
        private static PaletteRedirect _paletteRedirect;

        public KryptonNavigatorButton()
        {

            // add Palette Handler
            if (_palette != null)
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            KryptonManager.GlobalPaletteChanged += new EventHandler(GlobalPaletteChanged);

            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect = new PaletteRedirect(_palette);

            this.AutoSize = false;
            this.Values.ExtraText = null;
            this.Values.Text = null;
            this.Values.Image = null;
            this.Values.ImageStates.ImageCheckedNormal = null;
            this.Values.ImageStates.ImageCheckedPressed = null;
            this.Values.ImageStates.ImageCheckedTracking = null;

            this.ButtonStyle = ButtonStyle.Standalone;
            this.StateNormal.Back.Color1 = _palette.ColorTable.ToolStripContentPanelGradientEnd;
            this.StateNormal.Back.Color2 = _palette.ColorTable.ToolStripContentPanelGradientEnd;
            this.StateNormal.Back.ColorStyle = PaletteColorStyle.Solid;

            this.StateNormal.Border.Color1 = _palette.ColorTable.ToolStripBorder;
            this.StateCommon.Border.Rounding = 0;
            this.Size = new System.Drawing.Size(23, 23);
            this.StateCommon.Content.ShortText.Color1 = _palette.ColorTable.StatusStripText;
            this.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            this.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            this.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Marlett", 11.00f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,(byte)2);
        }
        #region ...Krypton...
        private void GlobalPaletteChanged(object sender, EventArgs e)
        {

            if (_palette != null)
                _palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);


            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect.Target = _palette;


            if (_palette != null)
            {
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
                //repaint with new values
                this.StateNormal.Back.Color1 = _palette.ColorTable.ToolStripContentPanelGradientEnd;
                this.StateNormal.Back.Color2 = _palette.ColorTable.ToolStripContentPanelGradientEnd;

                this.StateNormal.Border.Color1 = _palette.ColorTable.ToolStripBorder;
                this.StateCommon.Content.ShortText.Color1 = _palette.ColorTable.StatusStripText;
            }

            Invalidate();
        }
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
    #endregion
    }
}
