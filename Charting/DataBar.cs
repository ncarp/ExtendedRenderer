/****************************************************************************************************************
(C) Copyright 2007 Zuoliu Ding.  All Rights Reserved.
DataBar.cs:			class DataBar
Created by:			Zuoliu Ding, 05/20/2006
Note:				Bar Chart Custom control 
Site:               http://www.codeproject.com/cs/miscctrl/SystemMonitor.asp
****************************************************************************************************************/

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AC.ExtendedRenderer.Toolkit.Charting
{
    /// <summary>
    /// Summary description for DataBar.
    /// </summary>
    [ToolboxBitmap(typeof(DataBar)), ToolboxItem(true)]
    public class DataBar : System.Windows.Forms.UserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        int _value;
        Color _colorBar;

        #region Constructor/Dispose
        public DataBar()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();
            BackColor = Color.Silver;

            _value = 0;
            _colorBar = Color.DarkBlue;
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Name = "DataBar";
            this.Size = new System.Drawing.Size(128, 16);
        }
        #endregion

        #region "Properties"
        [Description("Gets or sets the current Bar Color in chart"), Category("Appearance")]
        public Color BarColor
        {
            get { return _colorBar; }
            set { _colorBar = value; }
        }

        [Description("Gets or sets the current value in data bar"), Category("Behavior")]
        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                Invalidate();
            }
        }
        #endregion


        #region Drawing
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rt = this.ClientRectangle;
            e.Graphics.FillRectangle(new SolidBrush(_colorBar), 0, 0, rt.Width * _value / 100, rt.Height);

            base.OnPaint(e);
        }
        #endregion

    }
}
