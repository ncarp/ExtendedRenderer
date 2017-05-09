//
// Copyright 2010 AdvancedComputing.ch
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
    [System.Drawing.ToolboxBitmapAttribute(typeof(ComponentFactory.Krypton.Toolkit.KryptonTrackBar)), ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    public class KryptonTrackBarToolStripMenuItem : ToolStripControlHostFixed
    {
        // Constants =========================================================
        // Attributes ========================================================
        // Properties ========================================================
        /// <summary>
        /// Gets the KryptonTrackBar control.
        /// </summary>
        /// <value>The KryptonTrackBar control.</value>
        [RefreshProperties(RefreshProperties.All),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ComponentFactory.Krypton.Toolkit.KryptonTrackBar KryptonTrackBarControl
        {
            get { return Control as ComponentFactory.Krypton.Toolkit.KryptonTrackBar; }
        }

        // Constructor ========================================================
        /// <summary>
        /// Initializes a new instance of the <see cref="KryptonTrackBarToolStripMenuItem"/> class.
        /// </summary>
        public KryptonTrackBarToolStripMenuItem()
            : base(new ComponentFactory.Krypton.Toolkit.KryptonTrackBar())
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
            return this.KryptonTrackBarControl.GetPreferredSize(constrainingSize);
        }

        /// <summary>
        /// Subscribes events from the hosted control.
        /// </summary>
        /// <param name="control">The control from which to subscribe events.</param>
        protected override void OnSubscribeControlEvents(Control control)
        {
            base.OnSubscribeControlEvents(control);

            //Add your code here to subsribe to Control Events
            ((ComponentFactory.Krypton.Toolkit.KryptonTrackBar)control).ValueChanged += new EventHandler(OnValueChanged);
        }

        /// <summary>
        /// Unsubscribes events from the hosted control.
        /// </summary>
        /// <param name="control">The control from which to unsubscribe events.</param>
        protected override void OnUnsubscribeControlEvents(Control control)
        {
            base.OnUnsubscribeControlEvents(control);

            //Add your code here to unsubscribe from control events.
            ((ComponentFactory.Krypton.Toolkit.KryptonTrackBar)control).ValueChanged -= new EventHandler(OnValueChanged);
        }

        #region ... exposed properties ...
        public int Value
        {
            get { return ((ComponentFactory.Krypton.Toolkit.KryptonTrackBar)this.Control).Value; }
            set { ((ComponentFactory.Krypton.Toolkit.KryptonTrackBar)this.Control).Value = value; }
        }

        public int LargeChange
        {
            get { return ((ComponentFactory.Krypton.Toolkit.KryptonTrackBar)this.Control).LargeChange; }
            set { ((ComponentFactory.Krypton.Toolkit.KryptonTrackBar)this.Control).LargeChange = value; }
        }

        public int SmallChange
        {
            get { return ((ComponentFactory.Krypton.Toolkit.KryptonTrackBar)this.Control).SmallChange; }
            set { ((ComponentFactory.Krypton.Toolkit.KryptonTrackBar)this.Control).SmallChange = value; }
        }

        public int Maximum
        {
            get { return ((ComponentFactory.Krypton.Toolkit.KryptonTrackBar)this.Control).Maximum; }
            set { ((ComponentFactory.Krypton.Toolkit.KryptonTrackBar)this.Control).Maximum = value; }
        }

        public int Minimum
        {
            get { return ((ComponentFactory.Krypton.Toolkit.KryptonTrackBar)this.Control).Minimum; }
            set { ((ComponentFactory.Krypton.Toolkit.KryptonTrackBar)this.Control).Minimum = value; }
        }

        public bool VolumeControl
        {
            get { return ((ComponentFactory.Krypton.Toolkit.KryptonTrackBar)this.Control).VolumeControl; }
            set { ((ComponentFactory.Krypton.Toolkit.KryptonTrackBar)this.Control).VolumeControl = value; }
        }

        public ComponentFactory.Krypton.Toolkit.PaletteTrackBarSize TrackBarSize
        {
            get { return ((ComponentFactory.Krypton.Toolkit.KryptonTrackBar)this.Control).TrackBarSize; }
            set { ((ComponentFactory.Krypton.Toolkit.KryptonTrackBar)this.Control).TrackBarSize = value; }
        }

        public TickStyle TickStyle
        {
            get { return ((ComponentFactory.Krypton.Toolkit.KryptonTrackBar)this.Control).TickStyle; }
            set { ((ComponentFactory.Krypton.Toolkit.KryptonTrackBar)this.Control).TickStyle = value; }
        }

        public int TickFrequency
        {
            get { return ((ComponentFactory.Krypton.Toolkit.KryptonTrackBar)this.Control).TickFrequency; }
            set { ((ComponentFactory.Krypton.Toolkit.KryptonTrackBar)this.Control).TickFrequency = value; }
        }

        public Orientation Orientation
        {
            get { return ((ComponentFactory.Krypton.Toolkit.KryptonTrackBar)this.Control).Orientation; }
            set { ((ComponentFactory.Krypton.Toolkit.KryptonTrackBar)this.Control).Orientation = value; }
        }
        #endregion

        #region ... exposed events ...
        public event EventHandler ValueChanged;
        protected void OnValueChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, e);
        }

        #endregion
    }
}
