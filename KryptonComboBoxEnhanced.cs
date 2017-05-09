using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using ComponentFactory.Krypton.Toolkit;
using AC.ExtendedRenderer.Toolkit.Drawing;

namespace AC.ExtendedRenderer.Toolkit
{
    public partial class KryptonComboBoxEnhanced : ComponentFactory.Krypton.Toolkit.KryptonComboBox
    {

        private IPalette _palette;
        private PaletteRedirect _paletteRedirect;


        #region ... Properties ... 

        bool _enabled = true;
        public bool Enabled
        {
            get { return _enabled; }
            set { 
                _enabled = value;
            this.ComboBox.Enabled = value;
                Invalidate();
                }
        }


        Color _gradientStartColor = Color.White;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("Color.White")]
        public Color GradientStartColor
        {
            get { return _gradientStartColor; }
            set { _gradientStartColor = value; Invalidate(); }
        }

        Color _gradientEndColor = Color.Gray;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("Color.Gray")]
        public Color GradientEndColor
        {
            get { return _gradientEndColor; }
            set { _gradientEndColor = value; Invalidate(); }
        }

        Boolean _persistentColors = false;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("False")]
        public Boolean PersistentColors
        {
            get { return _persistentColors; }
            set { _persistentColors = value; }
        }

        Boolean _useStyledColors = false;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("False")]
        public Boolean UseStyledColors
        {
            get { return _useStyledColors; }
            set { _useStyledColors = value; }
        }

        #endregion

        #region ...ctor...
        public KryptonComboBoxEnhanced()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

            UpdateStyles();
            this.ComboBox.DrawMode = DrawMode.OwnerDrawVariable;

            this.ItemHeight +=  2;

            this.ComboBox.DrawItem += new DrawItemEventHandler(this.OnDItem);

            // add Palette Handler
            if (_palette != null)
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            KryptonManager.GlobalPaletteChanged += new EventHandler(ThisGlobalPaletteChanged);

            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect = new PaletteRedirect(_palette);

            InitializeComponent();

            if (this.Enabled == false)
            {
                this.Enabled = true;
                this.ComboBox.Enabled = false;
            }
        }
        #endregion

        #region  ...DrawItem...

        private void OnDItem(object Sender, DrawItemEventArgs e)
        {
            this.ODrawItem(e);
        }

        protected void ODrawItem(DrawItemEventArgs e)
        {
            Rectangle rect = e.Bounds;
            Graphics g = e.Graphics;

            //DDL fix
            if (e.Index == -1) return;

            //ClearType
            try
            {
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

            if (_palette == null)
            {
                EventArgs Ev = new EventArgs();
                ThisGlobalPaletteChanged(this, Ev);
            }

            //set colors
            if (_persistentColors == false)
            {
                //init color values
                if (_useStyledColors == true)
                {
                    _gradientStartColor = Color.FromArgb(255, 246, 215);
                    _gradientEndColor = Color.FromArgb(255, 213, 77);
                }
                else
                {
                    _gradientStartColor = _palette.ColorTable.StatusStripGradientBegin;
                    _gradientEndColor = _palette.ColorTable.OverflowButtonGradientEnd;
                }
            }

            //BackColors 
            Color gradStartColor = _gradientStartColor;
            Color gradEndColor = _gradientEndColor;
            Color textColor = _palette.ColorTable.StatusStripText;

            // Retrieve the item font. If the item font has not been set,
            // use the ComboBox font.
            Font itemFont = e.Font;
            if (itemFont == null) itemFont = this.Font;

            // Draw the background of the item.
            e.DrawBackground();

            // Draw each string in the array, using a different size, color,
            // and font for each item.

            string str = (string)this.Items[e.Index];

            if (!Enabled) 
            {
                e.Graphics.DrawString(str, itemFont, new SolidBrush(SystemColors.GrayText), e.Bounds); 
            }
            else
            {
            e.Graphics.DrawString(str, itemFont, new SolidBrush(this.ForeColor), e.Bounds);
            }

            if ((e.State & DrawItemState.Selected) != 0)
            {
                //DrawingMethods.DrawBlendGradient(e.Graphics, e.Bounds, gradStartColor, gradEndColor, gradMiddleColor, 90F);
                DrawingMethods.DrawGradient(g, e.Bounds, gradStartColor, gradEndColor, 90F, false, Color.White, 0);
                e.Graphics.DrawString(str, itemFont, new SolidBrush(textColor), e.Bounds);
                e.DrawFocusRectangle();
            }

            // Draw the focus rectangle if the mouse hovers over an item.
            e.DrawFocusRectangle();

        }
#endregion

        #region ... Krypton ...
        //Kripton Palette Events
        private void ThisGlobalPaletteChanged(object sender, EventArgs e)
        {
            if (_palette != null)
                _palette.PalettePaint -= new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect.Target = _palette;

            if (_palette != null)
            {
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);
                //repaint with new values

                //set colors
                if (_persistentColors == false)
                {
                    //init color values
                    if (_useStyledColors == true)
                    {
                        _gradientStartColor = Color.FromArgb(255, 246, 215);
                        _gradientEndColor = Color.FromArgb(255, 213, 77);
                    }
                    else
                    {
                        _gradientStartColor = _palette.ColorTable.StatusStripGradientBegin;
                        _gradientEndColor = _palette.ColorTable.OverflowButtonGradientEnd;
                    }
                }
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
