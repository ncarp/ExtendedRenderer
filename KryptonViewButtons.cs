using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace AC.ExtendedRenderer.Toolkit
{
    [ToolboxItem(true)]
    [System.Drawing.ToolboxBitmapAttribute(typeof(System.Windows.Forms.Button))]
    public partial class KryptonViewButtons : UserControl
    {

        private string _percentageLabel = "100%";
        [Category("ViewButtons"), DefaultValue(typeof(string), "100%")]
        public string PercentageLabel
        {
            get { return _percentageLabel; }
            set
            {
                this.kcmdpercentage.Text = value;
                _percentageLabel = value;
                Invalidate();
            }
        }


        public KryptonViewButtons()
        {
            InitializeComponent();
            //(1) To remove flicker we use double buffering for drawing
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.UserPaint, true);

            //Set Back Color
            this.BackColor = System.Drawing.Color.Transparent;

            //Set Label Text
            this.kcmdpercentage.Text = _percentageLabel;
        }




    }
}