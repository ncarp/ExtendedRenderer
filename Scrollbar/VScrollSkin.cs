namespace AC.ExtendedRenderer.Toolkit.ScrollBar
{
    using Microsoft.VisualBasic;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using ComponentFactory.Krypton.Toolkit;
    using System.Reflection;

    [System.Drawing.ToolboxBitmapAttribute(typeof(System.Windows.Forms.VScrollBar))]
    public class VScrollSkin : Panel
    {
        #region "   Members   "
        //private static List<WeakReference> __ENCList = new List<WeakReference>();

        [AccessedThroughProperty("_win")]
        private Control __win;

        [AccessedThroughProperty("VScrollBar1")]
        private AC.ExtendedRenderer.Toolkit.ScrollBar.KryptonScrollBar _VScrollBar1;

        [AccessedThroughProperty("HScrollBar1")]
        private AC.ExtendedRenderer.Toolkit.ScrollBar.KryptonScrollBar _HScrollBar1;

        private IContainer components;

        public Win32.ScrollInfo si;
        //public Win32.ScrollInfo si2;

        private VScrollBar VSB;
        private HScrollBar HSC;

        private static IPalette _palette;
        private PaletteRedirect _paletteRedirect;

        #endregion

        #region "   Properties   "

        private Control _win
        {
            get
            {
                return this.__win;
            }
            set
            {
                this.__win = value;
            }
        }

        internal virtual AC.ExtendedRenderer.Toolkit.ScrollBar.KryptonScrollBar VScrollBar1
        {
            get
            {
                return this._VScrollBar1;
            }
            set
            {
                this._VScrollBar1 = value;
            }
        }

        internal virtual AC.ExtendedRenderer.Toolkit.ScrollBar.KryptonScrollBar HScrollBar1
        {
            get
            {
                return this._HScrollBar1;
            }
            set
            {
                this._HScrollBar1 = value;
            }
        }
        #endregion

        #region "   CTor   "
        public VScrollSkin()
        {
            // add Palette Handler
            if (_palette != null)
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            KryptonManager.GlobalPaletteChanged += new EventHandler(OnGlobalPaletteChanged);

            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect = new PaletteRedirect(_palette);

            base.ControlAdded += new ControlEventHandler(this.scrollSkin_ControlAdded);
            //this._win = null;

            // This call is required by the Windows Form Designer.
            this.InitializeComponent();

        }

        public VScrollSkin(Control win)
        {

            // add Palette Handler
            if (_palette != null)
                _palette.PalettePaint += new EventHandler<PaletteLayoutEventArgs>(OnPalettePaint);

            KryptonManager.GlobalPaletteChanged += new EventHandler(OnGlobalPaletteChanged);

            _palette = KryptonManager.CurrentGlobalPalette;
            _paletteRedirect = new PaletteRedirect(_palette);

            base.ControlAdded += new ControlEventHandler(this.scrollSkin_ControlAdded);

            this._win = win;
            this.Controls.Add(win);

            // This call is required by the Windows Form Designer.
            this.InitializeComponent();

            // Fix the fake scrolling control to overlap the real scrollable control
            this.VScrollBar1.Size = new Size(0x12, this._win.Height);
            this.HScrollBar1.Size = new Size(this._win.Width, 0x12);

            this.Size = new Size(this._win.Width, this._win.Height);
            this.Location = new Point(this._win.Left, this._win.Top);
            this.Dock = this._win.Dock;
            this._win.Top = 0;
            this._win.Left = 0;
            this._win.SendToBack();
            this.Name = "skin" + this._win.Name;
        }

        #endregion

        #region "   Init   "
        private void InitializeComponent()
        {
            this.VScrollBar1 = new AC.ExtendedRenderer.Toolkit.ScrollBar.KryptonScrollBar();
            this.HScrollBar1 = new AC.ExtendedRenderer.Toolkit.ScrollBar.KryptonScrollBar();

            this.SuspendLayout();

            //this.VScrollBar1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            this.VScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right))); this.VScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.VScrollBar1.LargeChange = 10;
            this.VScrollBar1.Location = new Point(0x91, 0); // (145,0)
            this.VScrollBar1.Maximum = 100;
            this.VScrollBar1.Minimum = 0;
            this.VScrollBar1.MinimumSize = new Size(0x13, 15); //(19,15)
            this.VScrollBar1.Name = "VScrollBar1";
            this.VScrollBar1.Size = new Size(0x13, 0x7f);//(19,127)
            this.VScrollBar1.SmallChange = 1;
            this.VScrollBar1.TabIndex = 0;
            this.VScrollBar1.Scroll += VScrollBar1_miScroll;
            this.VScrollBar1.Visible = false;
            this.VScrollBar1.Orientation = ScrollBarOrientation.Vertical;

            this.HScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HScrollBar1.LargeChange = 10;
            this.HScrollBar1.Location = new Point(0, 0x6c);//(0,108)
            this.HScrollBar1.Maximum = 20;
            this.HScrollBar1.Minimum = 0;
            this.HScrollBar1.MinimumSize = new Size(15, 0x13);//(15,19)
            this.HScrollBar1.Name = "HScrollBar1";
            this.HScrollBar1.Size = new Size(0x96, 15);//(150,15)
            this.HScrollBar1.SmallChange = 1;
            this.HScrollBar1.TabIndex = 1;
            this.HScrollBar1.Scroll += HScrollBar1_miScroll;
            this.HScrollBar1.Visible = false;
            this.HScrollBar1.Orientation = ScrollBarOrientation.Horizontal;

            this.BackColor = Color.Transparent;

            this.Controls.Add(this.VScrollBar1);
            //this.Controls.Add(this.HScrollBar1);

            this.Size = new Size(0xa4, 0x7f); //(164,127)
            this.ResumeLayout(false);

            if (_win != null)
            {
                this.__win.Resize += win_Resize;
            }

        }
        #endregion

        #region "   Control Added   "
        /// <summary>
        /// Linking the Scrollable control with Me
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void scrollSkin_ControlAdded(object sender, ControlEventArgs e)
        {
            if ((this.Controls.Count != 1) && (_win == null))
            {
                this._win = e.Control;
                if (_win.GetType() == typeof(KryptonGrid) || _win.GetType() == typeof(System.Windows.Forms.DataGridView) || (_win.GetType() == typeof(KryptonDataGridView)))
                {
                    DataGridView dgv = (DataGridView)_win;
                    dgv.Scroll += dgv_Scroll;

                    foreach (Control control in dgv.Controls)
                    {
                        if (control is HScrollBar)
                        {
                            HScrollBar hscroll = (HScrollBar)control;
                            hscroll.VisibleChanged += new EventHandler(HorizontalScrollBar_VisibleChanged);
                        }
                        if (control is VScrollBar)
                        {
                            VScrollBar vscroll = (VScrollBar)control;
                            vscroll.VisibleChanged += new EventHandler(VerticalScrollBar_VisibleChanged);
                        }
                    }
                }
            }
        }
        #endregion

        #region "   Vertical Scroll   "

        /// <summary>
        /// Comming from the customControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void VScrollBar1_miScroll(object sender, ScrollEventArgs e)
        {
            if (_win.GetType() == typeof(System.Windows.Forms.ListView) || (_win.GetType() == typeof(KryptonListView)))
            {
                ListView listView1 = (ListView)_win;

                IntPtr min = IntPtr.Zero;
                IntPtr max = IntPtr.Zero;
                Win32.GetScrollRange(listView1.Handle, Win32.SB_VERT, ref min, ref max);

                int nMax = max.ToInt32();
                nMax += 3;

                int nHeight = listView1.DisplayRectangle.Height;
                int ItemRectHeight = listView1.GetItemRect(0).Height;

                int nTimes = (nHeight - 17) / ItemRectHeight;
                int nScrollPositions = (nMax - nTimes) + 1;

                double nThePos = VScrollBar1.Maximum / nScrollPositions;

                double RealPos = 0.0;
                if (nThePos <= 0.0)
                    RealPos = VScrollBar1.Value;
                else
                    RealPos = VScrollBar1.Value / nThePos;

                int nPos = Win32.GetScrollPos(listView1.Handle, Win32.SB_VERT);

                double nShouldBeAt = RealPos * ItemRectHeight;
                double nIsAt = nPos * ItemRectHeight;

                int pixelsToScroll = Convert.ToInt32((nShouldBeAt - nIsAt));

                Win32.SendMessage(listView1.Handle, Win32.LVM_SCROLL, IntPtr.Zero, (IntPtr)pixelsToScroll);

                Invalidate();

            }
            else
            {
                if (_win.GetType() == typeof(KryptonGrid) || _win.GetType() == typeof(System.Windows.Forms.DataGridView) || (_win.GetType() == typeof(KryptonDataGridView)))
                {
                    DataGridView dgv = (DataGridView)_win;
                    if (GetDGVScrollbar(ref dgv, out VSB))
                    {
                        foreach (Control control in dgv.Controls)
                        {
                            if (control is VScrollBar)
                            {
                                VScrollBar vscroll = (VScrollBar)control;
                                if (vscroll.Visible)
                                {
                                    switch (e.Type)
                                    {
                                        case ScrollEventType.ThumbTrack:
                                            if (e.NewValue >= e.OldValue)
                                            {
                                                Win32.SendMessage(_win.Handle, Win32.WM_VSCROLL, (IntPtr)Win32.SB_LINEDOWN, VSB.Handle);
                                            }
                                            else
                                            {
                                                Win32.SendMessage(_win.Handle, Win32.WM_VSCROLL, (IntPtr)Win32.SB_LINEUP, VSB.Handle);
                                            }

                                            Win32.SendMessage(_win.Handle, Win32.WM_VSCROLL, (IntPtr)Win32.SB_THUMBTRACK, VSB.Handle);
                                            break;

                                        default:
                                            Win32.SendMessage(_win.Handle, Win32.WM_VSCROLL, (IntPtr)e.Type, VSB.Handle);
                                            break;
                                    }

                                }
                            }
                        }


                    }
                    else
                    {
                        this.VScrollBar1.Visible = false;
                    }
                }
                else
                {
                    if (_win.GetType() == typeof(System.Windows.Forms.TreeView) || (_win.GetType() == typeof(KryptonTreeView)))
                    {
                        switch (e.Type)
                        {
                            case ScrollEventType.ThumbTrack:
                                if (e.NewValue >= e.OldValue)
                                {
                                    Win32.SendMessage(_win.Handle, Win32.WM_VSCROLL, (IntPtr)Win32.SB_LINEDOWN, IntPtr.Zero);
                                }
                                else
                                {
                                    Win32.SendMessage(_win.Handle, Win32.WM_VSCROLL, (IntPtr)Win32.SB_LINEUP, IntPtr.Zero);
                                }

                                Win32.SendMessage(_win.Handle, Win32.WM_VSCROLL, (IntPtr)Win32.SB_THUMBTRACK, IntPtr.Zero);
                                break;

                            default:
                                Win32.SendMessage(_win.Handle, Win32.WM_VSCROLL, (IntPtr)e.Type, IntPtr.Zero);
                                break;
                        }
                    }
                    else
                    {
                        Win32.PostMessageA(this._win.Handle, Win32.WM_VSCROLL, Win32.SB_THUMBPOSITION + (0x10000 * this.VScrollBar1.Value), 0);
                    }
                }
            }

        }

        #endregion

        #region "   Horizontal Scroll   "
        private void HScrollBar1_miScroll(object sender, ScrollEventArgs e)
        {
            if (_win.GetType() == typeof(System.Windows.Forms.ListView) || (_win.GetType() == typeof(KryptonListView)))
            {
                ListView listView1 = (ListView)_win;

                int nIsAt = Win32.GetScrollPos(listView1.Handle, Win32.SB_HORZ);
                int nShouldBeAt = (int)e.NewValue;

                int pixelsToScroll = Convert.ToInt32((nShouldBeAt - nIsAt));

                Win32.SendMessage(listView1.Handle, (int)Win32.LVM_SCROLL, pixelsToScroll, 0);

                Invalidate();
            }
            else
            {
                if (_win.GetType() == typeof(KryptonGrid) || _win.GetType() == typeof(System.Windows.Forms.DataGridView) || (_win.GetType() == typeof(KryptonDataGridView)))
                {
                    DataGridView dgv = (DataGridView)_win;
                    if (GetDGHScrollbar(ref dgv, out HSC))
                    {
                        foreach (Control control in dgv.Controls)
                        {
                            if (control is HScrollBar)
                            {
                                HScrollBar hscroll = (HScrollBar)control;
                                if (hscroll.Visible)
                                {
                                    switch (e.Type)
                                    {
                                        case ScrollEventType.ThumbTrack:
                                            if (e.NewValue >= e.OldValue)
                                            {
                                                Win32.SendMessage(_win.Handle, Win32.WM_HSCROLL, (IntPtr)Win32.SB_LINEDOWN, HSC.Handle);
                                            }
                                            else
                                            {
                                                Win32.SendMessage(_win.Handle, Win32.WM_HSCROLL, (IntPtr)Win32.SB_LINEUP, HSC.Handle);
                                            }

                                            Win32.SendMessage(_win.Handle, Win32.WM_HSCROLL, (IntPtr)Win32.SB_THUMBTRACK, HSC.Handle);
                                            break;

                                        default:
                                            Win32.SendMessage(_win.Handle, Win32.WM_HSCROLL, (IntPtr)e.Type, HSC.Handle);
                                            break;
                                    }

                                }
                            }
                        }


                    }
                    else
                    {
                        this.HScrollBar1.Visible = false;
                    }
                }
                else
                {
                    if (_win.GetType() == typeof(System.Windows.Forms.TreeView) || (_win.GetType() == typeof(KryptonTreeView)))
                    {
                        switch (e.Type)
                        {
                            case ScrollEventType.ThumbTrack:
                                if (e.NewValue >= e.OldValue)
                                {
                                    Win32.SendMessage(_win.Handle, Win32.WM_HSCROLL, (IntPtr)Win32.SB_LINEDOWN, IntPtr.Zero);
                                }
                                else
                                {
                                    Win32.SendMessage(_win.Handle, Win32.WM_HSCROLL, (IntPtr)Win32.SB_LINEUP, IntPtr.Zero);
                                }

                                Win32.SendMessage(_win.Handle, Win32.WM_HSCROLL, (IntPtr)Win32.SB_THUMBTRACK, IntPtr.Zero);
                                break;

                            default:
                                Win32.SendMessage(_win.Handle, Win32.WM_HSCROLL, (IntPtr)e.Type, IntPtr.Zero);
                                break;
                        }
                    }
                    else
                    {
                        Win32.PostMessageA(this._win.Handle, Win32.WM_HSCROLL, Win32.SB_THUMBPOSITION + (0x10000 * this.HScrollBar1.Value), 0);
                    }
                }
            }

        }

        #endregion

        #region "   DGV Scrollbar VisibleChanged    "

        void VerticalScrollBar_VisibleChanged(object sender, EventArgs e)
        {
            VScrollBar vscroll = (VScrollBar)sender;
            if (vscroll.Visible)
            {
                _VScrollBar1.Visible = true;
            }
            else
            {
                _VScrollBar1.Visible = false;
            }
        }

        void HorizontalScrollBar_VisibleChanged(object sender, EventArgs e)
        {
            HScrollBar hscroll = (HScrollBar)sender;
            if (hscroll.Visible)
            {
                _HScrollBar1.Visible = true;
            }
            else
            {
                _HScrollBar1.Visible = false;
            }
        }

        #endregion

        #region "   DGV Scroll   "

        private void dgv_Scroll(object sender, ScrollEventArgs e)
        {
            DataGridView dgv = (DataGridView)_win;
            if (GetDGVScrollbar(ref dgv, out VSB))
            {
                if (VSB.Visible == true)
                {
                    this.VScrollBar1.Visible = true;
                    SetDGVScrollBarValue(ref dgv, ref VSB);
                }
                else
                {
                    this.VScrollBar1.Visible = false;
                }
            }

            if (GetDGHScrollbar(ref dgv, out HSC))
            {
                if (HSC.Visible == true)
                {
                    this.HScrollBar1.Visible = true;
                    SetDGVScrollBarValue(ref dgv, ref HSC);
                }
                else
                {
                    this.HScrollBar1.Visible = false;
                }
            }
            dgv.Invalidate();
            dgv.Refresh();
            dgv.PerformLayout();
        }

        #endregion

        #region "   Win Resize   "

        /// <summary>
        /// Almost done move and resize the Scrollable control over Me 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void win_Resize(object sender, EventArgs e)
        {
            this.VScrollBar1.Size = new Size(0x12, this._win.Height); //for the gap 
            this.VScrollBar1.Left = this._win.Right - 0x12;

            //test code
            this.HScrollBar1.Size = new Size(this._win.Width, 0x12); //for the gap
            this.HScrollBar1.Top = this._win.Height - 0x12;

            this.Size = new Size(this._win.Width, this._win.Height);

            this._win.Top = 0;
            this._win.Left = 0;
        }

        #endregion

        #region "   WndProc   "
        /// <summary>
        /// Overrided to controll del scrolling of the customControl VScrollBar1
        /// </summary>
        /// <param name="m"></param>
        /// <remarks></remarks>
        protected override void WndProc(ref Message m)
        {
            if (!this.DesignMode && !(!this.Parent.CanFocus | (_win == null)))
            {

                //int listStyle = Win32.GetWindowLong(_win.Handle, Win32.GWL_STYLE);
                //listStyle |= Win32.WS_VSCROLL | Win32.WS_HSCROLL;
                //listStyle |= Win32.WS_VSCROLL;
                //listStyle |= Win32.WS_HSCROLL;
                //listStyle = Win32.SetWindowLong(_win.Handle, Win32.GWL_STYLE, listStyle);

                int wndStyle = Win32.GetWindowLong(this._win.Handle, Win32.GWL_STYLE);
                bool hsVisible = (wndStyle & Win32.WS_HSCROLL) != 0;
                bool vsVisible = (wndStyle & Win32.WS_VSCROLL) != 0;

                //Vertical
                if (vsVisible)
                {
                    this.si.fMask = (int)Win32.ScrollInfoMask.SIF_ALL;
                    this.si.cbSize = Marshal.SizeOf(this.si);
                    Win32.GetScrollInfo(this._win.Handle, (int)Win32.ScrollBarDirection.SB_VERT, ref this.si);

                    if ((this.si.nMax + 0) <= this.si.nPage)
                    {
                        this.VScrollBar1.Visible = false;
                    }
                    else
                    {
                        this.VScrollBar1.Visible = true;
                        if (this.si.nPage != 0)
                        {
                            VScrollBar1.LargeChange = si.nPage;
                            VScrollBar1.Maximum = si.nMax;
                            VScrollBar1.Minimum = si.nMin;
                            VScrollBar1.SmallChange = 1;
                            this.VScrollBar1.Update();//.SyncThumbPositionWithLogicalValue();
                        }
                    }
                }

                //horizontal
                if (hsVisible)
                {
                    this.si.fMask = (int)Win32.ScrollInfoMask.SIF_ALL;
                    this.si.cbSize = Marshal.SizeOf(this.si);
                    Win32.GetScrollInfo(this._win.Handle, (int)Win32.ScrollBarDirection.SB_HORZ, ref this.si);

                    if ((this.si.nMax + 0) <= this.si.nPage)
                    {
                        this.HScrollBar1.Visible = false;
                    }
                    else
                    {
                        this.HScrollBar1.Visible = true;
                        if (this.si.nPage != 0)
                        {
                            HScrollBar1.LargeChange = si.nPage;
                            HScrollBar1.Maximum = si.nMax;
                            HScrollBar1.Minimum = si.nMin;
                            HScrollBar1.SmallChange = 1;
                            this.HScrollBar1.Update();//.SyncThumbPositionWithLogicalValue();
                        }
                    }
                }

                if (_win.GetType() == typeof(System.Windows.Forms.ListView) || (_win.GetType() == typeof(KryptonListView)))
                {
                    ListView listView1 = (ListView)_win;

                    Win32.ScrollInfo si = new Win32.ScrollInfo();
                    si.cbSize = Marshal.SizeOf(si);
                    si.fMask = (int)Win32.ScrollInfoMask.SIF_ALL;
                    if (Win32.GetScrollInfo(listView1.Handle, (int)Win32.ScrollBarDirection.SB_VERT, ref si))
                    {
                        VScrollBar1.LargeChange = si.nPage;
                        VScrollBar1.Maximum = si.nMax;
                        VScrollBar1.Minimum = si.nMin;
                        VScrollBar1.SmallChange = 1;
                        this.VScrollBar1.Update();//.SyncThumbPositionWithLogicalValue();
                    }


                    si = new Win32.ScrollInfo();
                    si.cbSize = Marshal.SizeOf(si);
                    si.fMask = (int)Win32.ScrollInfoMask.SIF_ALL;
                    if (Win32.GetScrollInfo(listView1.Handle, (int)Win32.ScrollBarDirection.SB_HORZ, ref si))
                    {
                        HScrollBar1.LargeChange = si.nPage;
                        HScrollBar1.Maximum = si.nMax;
                        HScrollBar1.Minimum = si.nMin;
                        HScrollBar1.SmallChange = 1;
                        this.HScrollBar1.Update();//.SyncThumbPositionWithLogicalValue();
                    }
                }

            }

            base.WndProc(ref m);
        }
        #endregion

        #region "   Support Subs   "

        public static bool GetDGVScrollbar(ref DataGridView dgv, out VScrollBar VSB)
        {
            bool isPresent = false;
            VSB = new VScrollBar();

            foreach (Control ctr in dgv.Controls)
            {
                if ((ctr) is VScrollBar)
                {
                    VSB = (VScrollBar)ctr;
                    isPresent = true;
                }
            }
            return isPresent;
        }

        public void SetDGVScrollBarValue(ref DataGridView dgv, ref VScrollBar VSB)
        {
            int listStyle = Win32.GetWindowLong(dgv.Handle, Win32.GWL_STYLE);
            //listStyle |= Win32.WS_VSCROLL | Win32.WS_HSCROLL;
            listStyle |= Win32.WS_VSCROLL;
            listStyle = Win32.SetWindowLong(dgv.Handle, Win32.GWL_STYLE, listStyle);

            VScrollBar1.Value = VSB.Value;
            VScrollBar1.Visible = true;
            VScrollBar1.LargeChange = VSB.LargeChange;
            VScrollBar1.Maximum = VSB.Maximum;
            VScrollBar1.Minimum = VSB.Minimum;
            VScrollBar1.SmallChange = VSB.SmallChange;
            VScrollBar1.Update();//.SyncThumbPositionWithLogicalValue();
            //Invalidate();
        }

        public static bool GetDGHScrollbar(ref DataGridView dgv, out HScrollBar HSB)
        {
            bool isPresent = false;
            HSB = new HScrollBar();

            foreach (Control ctr in dgv.Controls)
            {
                if ((ctr) is HScrollBar)
                {
                    HSB = (HScrollBar)ctr;
                    isPresent = true;
                }
            }
            return isPresent;
        }

        public void SetDGVScrollBarValue(ref DataGridView dgv, ref HScrollBar HSB)
        {
            int listStyle = Win32.GetWindowLong(dgv.Handle, Win32.GWL_STYLE);
            //listStyle |= Win32.WS_VSCROLL | Win32.WS_HSCROLL;
            listStyle |= Win32.WS_HSCROLL;
            listStyle = Win32.SetWindowLong(dgv.Handle, Win32.GWL_STYLE, listStyle);

            HScrollBar1.Value = HSB.Value;
            HScrollBar1.Visible = true;
            HScrollBar1.LargeChange = HSB.LargeChange;
            HScrollBar1.Maximum = HSB.Maximum;
            HScrollBar1.Minimum = HSB.Minimum;
            HScrollBar1.SmallChange = HSB.SmallChange;
            HScrollBar1.Update();//.SyncThumbPositionWithLogicalValue();
            //Invalidate();
        }
        protected static ScrollBars GetVisibleScrollbars(Control ctl)
        {
            int wndStyle = Win32.GetWindowLong(ctl.Handle, Win32.GWL_STYLE);
            bool hsVisible = (wndStyle & Win32.WS_HSCROLL) != 0;
            bool vsVisible = (wndStyle & Win32.WS_VSCROLL) != 0;

            if (hsVisible)
                return vsVisible ? ScrollBars.Both : ScrollBars.Horizontal;
            else
                return vsVisible ? ScrollBars.Vertical : ScrollBars.None;
        }


        #endregion

        #region "   (Designer) Dispose   "
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
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

