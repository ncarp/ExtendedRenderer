using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Design;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text;

namespace AC.ExtendedRenderer.Navigator
{
    [ToolboxBitmap(typeof(System.Windows.Forms.TabControl)), ToolboxItem(false)]
    public class EmptyTabControl : System.Windows.Forms.TabControl
    {

        private Color _bgcolor = Color.FromKnownColor(System.Drawing.KnownColor.Control);

        Boolean _drawBorder = false;
        [Browsable(true), Category("Appearance-Extended")]
        [DefaultValue("false")]
        public Boolean DrawBorder
        {
            get { return _drawBorder; }
            set { _drawBorder = value; Invalidate(); }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new virtual Size ItemSize
        {
            get { return base.ItemSize; }
            set { base.ItemSize = value; Invalidate(); }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new virtual System.Windows.Forms.TabSizeMode SizeMode
        {
            get { return base.SizeMode; }
            set { base.SizeMode = value; Invalidate(); }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new  virtual System.Windows.Forms.TabAppearance Appearance
        {
            get { return base.Appearance; }
            set { base.Appearance = value; Invalidate(); }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new virtual System.Windows.Forms.TabDrawMode DrawMode
        {
            get { return base.DrawMode; }
            set { base.DrawMode = value; Invalidate(); }
        }

        ///
        /// Indicates if the current view is being utilized in the VS.NET IDE or not.
        ///
        private bool _designMode;
        public new bool DesignMode
        {
            get
            {
                //return (System.Diagnostics.Process.GetCurrentProcess().ProcessName == "devenv");
                return _designMode; ;
            }
        }

        public EmptyTabControl()
        {
            //Design Mode
            _designMode = (System.Diagnostics.Process.GetCurrentProcess().ProcessName == "devenv");

            Init();
        }

        public EmptyTabControl(IContainer container)
        {
            container.Add(this);

            //Design Mode
            _designMode = (System.Diagnostics.Process.GetCurrentProcess().ProcessName == "devenv");

            Init();
        }
        private void Init()
        {
            // double buffering
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            if (!DesignMode)
            {
                this.SetStyle(ControlStyles.UserPaint, true);
                this.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
                this.DrawMode = TabDrawMode.OwnerDrawFixed;
                //this.ItemSize = new Size(0, 1);
                this.Appearance = System.Windows.Forms.TabAppearance.Buttons;
                this.Margin = new System.Windows.Forms.Padding(0);
            }
            else
            {
                this.SetStyle(ControlStyles.UserPaint, false);
                this.DrawMode = TabDrawMode.Normal;
                this.SizeMode = System.Windows.Forms.TabSizeMode.Normal;
                this.ItemSize = new Size(41, 21);
                this.Appearance = System.Windows.Forms.TabAppearance.Normal;
            }

        }


        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            if (!DesignMode)
            {
                this.ItemSize = new Size(0, 1);
                // draw tabs
                for (int i = 0; i < this.TabCount; i++)
                {
                    this.TabPages[i].Padding = new System.Windows.Forms.Padding(0);
                    this.TabPages[i].Margin = new System.Windows.Forms.Padding(0);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            if (!Visible)
                return;

            base.OnPaint(e);

            if (DesignMode)
                return;

            Graphics g = e.Graphics;

            Rectangle TabControlArea = this.ClientRectangle;
            Rectangle TabArea = this.DisplayRectangle;

            e.Graphics.FillRectangle(new SolidBrush(_bgcolor), TabControlArea);

            //Draw border
            using (GraphicsPath path = new GraphicsPath())
            {
                Rectangle rect = TabControlArea;
                path.AddRectangle(rect);

                g.DrawRectangle(new Pen(_bgcolor), rect);

            }

            if (!DesignMode)
            {
                if (this.SelectedTab != null)
                {
                    TabPage tabPage = this.SelectedTab;
                    tabPage.BackColor = _bgcolor;
                }
            }

        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}