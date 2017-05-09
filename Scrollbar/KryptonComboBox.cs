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

namespace AC.ExtendedRenderer.Toolkit.ScrollBar
{


    public class SKinComboBox : ComponentFactory.Krypton.Toolkit.KryptonComboBox
    {
        private System.ComponentModel.IContainer components;
        //init combobox info
        private Win32.ScrollInfo si;
        private Win32.ComboBoxInfo cbi;
        private Win32.RECT cboListRect;
        private bool gotCBI = false;
        private DropdownWindow mDropdown;

        [AccessedThroughProperty("VScrollBar1")]
        private AC.ExtendedRenderer.Toolkit.ScrollBar.KryptonScrollBar _VScrollBar1;
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

        public SKinComboBox()
        {
            InitializeComponent();

            this.gotCBI = InitComboBoxInfo(this);
            if (this.gotCBI)
            {
                this.cboListRect = new Win32.RECT();
                this.si = new Win32.ScrollInfo();
                mDropdown = new DropdownWindow(this);
                mDropdown.AssignHandle(cbi.hwndList);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.VScrollBar1 = new AC.ExtendedRenderer.Toolkit.ScrollBar.KryptonScrollBar();

            this.VScrollBar1.Name = "VScrollBar1";
            this.VScrollBar1.Scroll += VScrollBar1_miScroll;
            this.VScrollBar1.Orientation = ScrollBarOrientation.Vertical;
            this.ResumeLayout(false);
        }

        protected override void WndProc(ref Message m)
        {

            this.si.cbSize = Marshal.SizeOf(this.si);
            this.si.fMask = (int)Win32.ScrollInfoMask.SIF_ALL;


            if (mDropdown.Handle != null)//((m.Msg == Win32.WM_VSCROLL) || (m.Msg == Win32.WM_SIZE))
            {
                if (Win32.GetScrollInfo(mDropdown.Handle, (int)Win32.ScrollBarDirection.SB_VERT, ref si))
                {

                    //int listStyle = Win32.GetWindowLong(mDropdown.Handle, Win32.GWL_STYLE);
                    //listStyle |= Win32.WS_VSCROLL | Win32.WS_HSCROLL;
                    //listStyle |= Win32.WS_VSCROLL;
                    //listStyle = Win32.SetWindowLong(mDropdown.Handle, Win32.GWL_STYLE, listStyle);

                    Win32.RECT r1 = new Win32.RECT();
                    Win32.GetClientRect(mDropdown.Handle, ref r1);

                    Win32.SetParent(VScrollBar1.Handle, mDropdown.Handle);

                    VScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
                    //VScrollBar1.Dock = DockStyle.Right;
                    VScrollBar1.Location = new Point(r1.Right-0x13, 0); //0x13 = -19
                    VScrollBar1.BringToFront();
                    VScrollBar1.LargeChange = si.nPage;
                    VScrollBar1.Maximum = si.nMax;
                    VScrollBar1.Minimum = si.nMin;
                    VScrollBar1.SmallChange = 1;
                    //VScrollBar1.Update();//.SyncThumbPositionWithLogicalValue();

                }

                //Win32.SetScrollInfo(cbi.hwndList, (int)Win32.ScrollBarDirection.SB_VERT, ref this.si, true);
            }
            base.WndProc(ref m);
        }


        /// Comming from the customControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void VScrollBar1_miScroll(object sender, ScrollEventArgs e)
        {
            //Win32.PostMessageA(cbi.hwndList, Win32.WM_VSCROLL, Win32.SB_THUMBPOSITION + (0x10000 * this.VScrollBar1.Value), 0);
            Win32.SendMessage(mDropdown.Handle, Win32.WM_VSCROLL, (int)e.Type, 0);
        }


        protected override void OnDropDown(System.EventArgs e)
        {

            base.OnDropDown(e);

            InitComboBoxInfo(this);
            Win32.GetClientRect(cbi.hwndList, ref cboListRect);

            //Win32.SendMessageCb(this.Handle, 0x164, IntPtr.Zero, out cbi);

            mDropdown = new DropdownWindow(this);
            mDropdown.AssignHandle(cbi.hwndList);

            //int listStyle = Win32.GetWindowLong(cbi.hwndList, Win32.GWL_STYLE);
            //listStyle |= Win32.WS_VSCROLL | Win32.WS_HSCROLL;
            //listStyle |= Win32.WS_VSCROLL;
            //listStyle = Win32.SetWindowLong(cbi.hwndList, Win32.GWL_STYLE, listStyle);

            //Win32.SendMessage(this.cbi.hwndList, (int)Win32.LB_SETHORIZONTALEXTENT, (int)80, (int)IntPtr.Zero);

        }

        private bool InitComboBoxInfo(ComponentFactory.Krypton.Toolkit.KryptonComboBox cbo)
        {
            this.cbi = new Win32.ComboBoxInfo();
            this.cbi.cbSize = Marshal.SizeOf(this.cbi);
            if (!Win32.GetComboBoxInfo(cbo.ComboBox.Handle, ref this.cbi))
            {
                return false;
            }
            return true;
        }

    }

    // Wrapper for combobox dropdown list
    public class DropdownWindow : NativeWindow
    {
        private const int
            WM_MOUSEMOVE = 0x0200,
            WM_MOUSEWHEEL = 0x020A,
            WM_KEYDOWN = 0x0100,
            WM_VSCROLL = 0x0115,
            LB_GETCURSEL = 0x0188,
            LB_GETITEMRECT = 0x0198;

        private SKinComboBox mParent;
        private int mItem;

        public DropdownWindow(SKinComboBox parent)
        {
            mParent = parent;
            mItem = -1;
        }

    }

}
