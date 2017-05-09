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
namespace AC.ExtendedRenderer.Toolkit.Navigator
{

    #region ... KryptonNavigatorButton ...
    [System.Drawing.ToolboxBitmapAttribute(typeof(System.Windows.Forms.Button)), ToolboxItem(false)]
    public class CustomNavigatorButton : AC.StdControls.Toolkit.Buttons.CustomButton
    {

        public CustomNavigatorButton(Color BorderColor, Color GradientStartColor, Color GradientEndColor, Color TextColor)
        {

            this.AutoSize = false;

            this.GradientBorderColor = BorderColor;
            this.GradientTop = GradientStartColor;
            this.GradientBottom = GradientEndColor;
            this.Size = new System.Drawing.Size(23, 23);
            this.ForeColor = TextColor;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Font = new System.Drawing.Font("Marlett", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)2);

        }

        public CustomNavigatorButton()
        {
            this.AutoSize = false;
            this.Size = new System.Drawing.Size(23, 23);
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Font = new System.Drawing.Font("Marlett", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)2);

        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
        }

        protected override void Dispose(bool disposing)
        {
           base.Dispose(disposing);
        }
        #endregion
    
    }
}
