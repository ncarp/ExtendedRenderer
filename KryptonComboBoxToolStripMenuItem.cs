//
// Copyright 2008 AngelOnLine.Net
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification, 
// are permitted provided that the following conditions are met:
//
//   - Redistributions of source code must retain the above copyright notice, 
//     this list of conditions and the following disclaimer.
//
//   - Redistributions in binary form must reproduce the above copyright notice, 
//     this list of conditions and the following disclaimer in the documentation 
//     and/or other materials provided with the distribution.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
// IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
// INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
// NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, 
// OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
// WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
// ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY 
// OF SUCH DAMAGE.
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.ComponentModel;
using System.Drawing;
using ComponentFactory.Krypton.Toolkit;
using AC.ExtendedRenderer.Toolkit.Utils;

namespace AC.ExtendedRenderer.Toolkit
{
    [System.Drawing.ToolboxBitmapAttribute(typeof(System.Windows.Forms.ComboBox)), ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public class KryptonComboBoxToolStripMenuItem : ToolStripControlHostFixed
    {
        // Constants =========================================================

        // Attributes ========================================================

        // Properties ========================================================
        /// <summary>
        /// Gets the KryptonComboBox control.
        /// </summary>
        /// <value>The KryptonComboBox control.</value>
        [RefreshProperties(RefreshProperties.All),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox KryptonComboBoxControl
        {
            get { return Control as ComponentFactory.Krypton.Toolkit.KryptonComboBox; }
        }

        // Constructor ========================================================
        /// <summary>
        /// Initializes a new instance of the <see cref="KryptonComboBoxToolStripMenuItem"/> class.
        /// </summary>
        public KryptonComboBoxToolStripMenuItem()
            : base(new ComponentFactory.Krypton.Toolkit.KryptonComboBox())
        {
            this.AutoSize = false;
        }

        /// <summary>
        /// Retrieves the size of a rectangular area into which a control can be fitted.
        /// </summary>
        /// <param name="constrainingSize">The custom-sized area for a control.</param>
        /// <returns>
        /// An ordered pair of type <see cref="T:System.Drawing.Size"></see> representing the width and height of a rectangle.
        /// </returns>
        /// <PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence"/><IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        public override Size GetPreferredSize(Size constrainingSize)
        {
            //return base.GetPreferredSize(constrainingSize);
            return this.KryptonComboBoxControl.GetPreferredSize(constrainingSize);
        }

        /// <summary>
        /// Subscribes events from the hosted control.
        /// </summary>
        /// <param name="control">The control from which to subscribe events.</param>
        protected override void OnSubscribeControlEvents(Control control)
        {
            base.OnSubscribeControlEvents(control);

            //Add your code here to subsribe to Control Events
            ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)control).SelectedIndexChanged += new EventHandler(OnSelectedIndexChanged);
        }

        /// <summary>
        /// Unsubscribes events from the hosted control.
        /// </summary>
        /// <param name="control">The control from which to unsubscribe events.</param>
        protected override void OnUnsubscribeControlEvents(Control control)
        {
            base.OnUnsubscribeControlEvents(control);

            //Add your code here to unsubscribe from control events.
            ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)control).SelectedIndexChanged -= new EventHandler(OnSelectedIndexChanged);
        }

        #region ... exposed properties ...
        public int SelectedIndex
        {
            get { return ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)this.Control).SelectedIndex; }
            set { ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)this.Control).SelectedIndex = value; }
        }

        public string SelectedText
        {
            get { return ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)this.Control).SelectedText; }
            set { ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)this.Control).SelectedText = value; }
        }

        public object SelectedValue
        {
            get { return ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)this.Control).SelectedValue; }
            set { ((ComponentFactory.Krypton.Toolkit.KryptonComboBox)this.Control).SelectedValue = value; }
        }
        #endregion

        #region ... exposed events ...
        public event EventHandler SelectedIndexChanged;
        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedIndexChanged != null)
                SelectedIndexChanged(this, e);
        }
        #endregion
    }
}
