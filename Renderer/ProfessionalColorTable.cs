using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms.VisualStyles;
using System;
using Microsoft.Win32;
using System.IO;

namespace Office2007Renderer
{
    /// <summary>
    /// Provides colors used for Microsoft Office display elements.
    /// </summary>
    public class ProfessionalColorTable : System.Windows.Forms.ProfessionalColorTable
    {
        #region Enums
        /// <summary>
        /// Gets or sets the KnownColors appearance of the ProfessionalColorTable.
        /// </summary>
        public enum KnownColors
        {
            /// <summary>
            /// The starting color of the gradient used when the button is pressed down.
            /// </summary>
            ButtonPressedGradientBegin,
            /// <summary>
            /// The end color of the gradient used when the button is pressed down.
            /// </summary>
            ButtonPressedGradientEnd,
            /// <summary>
            /// The middle color of the gradient used when the button is pressed down.
            /// </summary>
            ButtonPressedGradientMiddle,
            /// <summary>
            /// The starting color of the gradient used when the button is selected.
            /// </summary>
            ButtonSelectedGradientBegin,
            /// <summary>
            /// The border color to use with the ButtonSelectedGradientBegin,
            /// ButtonSelectedGradientMiddle,
            /// and ButtonSelectedGradientEnd colors.
            /// </summary>
            ButtonSelectedBorder,
            /// <summary>
            /// The end color of the gradient used when the button is selected.
            /// </summary>
            ButtonSelectedGradientEnd,
            /// <summary>
            /// The middle color of the gradient used when the button is selected.
            /// </summary>
            ButtonSelectedGradientMiddle,
			/// <summary>
            /// The border color to use with ButtonSelectedHighlight.
			/// </summary>
            ButtonSelectedHighlightBorder,
            /// <summary>
            /// The solid color to use when the check box is selected and gradients are being used.
            /// </summary>
            CheckBackground,
            /// <summary>
            /// The solid color to use when the check box is selected and gradients are being used.
            /// </summary>
			CheckSelectedBackground,
            /// <summary>
            /// The text color of a top-level ContextMenuItem.
            /// </summary>
            ContextMenuItem,
            /// <summary>
            /// The text color of a top-level ContextMenuItemText.
            /// </summary>
            ContextMenuItemText,
            /// <summary>
            /// The color to use for shadow effects on the grip or move handle.
            /// </summary>
            GripDark,
            /// <summary>
            /// The color to use for highlight effects on the grip or move handle.
            /// </summary>
            GripLight,
            /// <summary>
            /// The starting color of the gradient used in the image margin
            /// of a ToolStripDropDownMenu.
            /// </summary>
            ImageMarginGradientBegin,
            /// <summary>
            /// The border color or a MenuStrip.
            /// </summary>
            MenuBorder,
            /// <summary>
            /// The border color to use with a ToolStripMenuItem.
            /// </summary>
            MenuItemBorder,
            /// <summary>
            /// The starting color of the gradient used when a top-level
            /// ToolStripMenuItem is pressed down.
            /// </summary>
            MenuItemPressedGradientBegin,
            /// <summary>
            /// The end color of the gradient used when a top-level
            /// ToolStripMenuItem is pressed down.
            /// </summary>
            MenuItemPressedGradientEnd,
            /// <summary>
            /// The middle color of the gradient used when a top-level
            /// ToolStripMenuItem is pressed down.
            /// </summary>
            MenuItemPressedGradientMiddle,
            /// <summary>
            /// The text color of a top-level ToolStripMenuItem.
            /// </summary>
            MenuItemText,
            /// <summary>
            /// The solid color to use when a ToolStripMenuItem other
            /// than the top-level ToolStripMenuItem is selected.
            /// </summary>
			MenuItemSelected,
            /// <summary>
            /// The starting color of the gradient used when the ToolStripMenuItem is selected.
            /// </summary>
			MenuItemSelectedGradientBegin,
            /// <summary>
            /// The end color of the gradient used when the ToolStripMenuItem is selected.
            /// </summary>
            MenuItemSelectedGradientEnd,
            /// <summary>
            /// The starting color of the gradient used in the MenuStrip.
            /// </summary>
            MenuStripGradientBegin,
            /// <summary>
            /// The end color of the gradient used in the MenuStrip.
            /// </summary>
            MenuStripGradientEnd,
            /// <summary>
            /// The starting color of the gradient used in the ToolStripOverflowButton.
            /// </summary>
            OverflowButtonGradientBegin,
            /// <summary>
            /// The end color of the gradient used in the ToolStripOverflowButton.
            /// </summary>
            OverflowButtonGradientEnd,
            /// <summary>
            /// The middle color of the gradient used in the ToolStripOverflowButton.
            /// </summary>
            OverflowButtonGradientMiddle,
            /// <summary>
            /// The starting color of the gradient used in the ToolStripContainer.
            /// </summary>
            RaftingContainerGradientBegin,
            /// <summary>
            /// The end color of the gradient used in the ToolStripContainer.
            /// </summary>
            RaftingContainerGradientEnd,
            /// <summary>
            /// The color to use to for shadow effects on the ToolStripSeparator.
            /// </summary>
            SeparatorDark,
            /// <summary>
            /// The color to use to for highlight effects on the ToolStripSeparator.
            /// </summary>
            SeparatorLight,
            /// <summary>
            /// The starting color of the gradient used on the StatusStrip.
            /// </summary>
            StatusStripGradientBegin,
            /// <summary>
            /// The end color of the gradient used on the StatusStrip.
            /// </summary>
            StatusStripGradientEnd,
            /// <summary>
            /// The text color used on the StatusStrip.
            /// </summary>
			StatusStripText,
            /// <summary>
            /// The border color to use on the bottom edge of the ToolStrip.
            /// </summary>
            ToolStripBorder,
            /// <summary>
            /// The starting color of the gradient used in the ToolStripContentPanel.
            /// </summary>
            ToolStripContentPanelGradientBegin,
            /// <summary>
            /// The end color of the gradient used in the ToolStripContentPanel.
            /// </summary>
            ToolStripContentPanelGradientEnd,
            /// <summary>
            /// The solid background color of the ToolStripDropDown.
            /// </summary>
            ToolStripDropDownBackground,
            /// <summary>
            /// The starting color of the gradient used in the ToolStrip background.
            /// </summary>
            ToolStripGradientBegin,
            /// <summary>
            /// The end color of the gradient used in the ToolStrip background.
            /// </summary>
            ToolStripGradientEnd,
            /// <summary>
            /// The middle color of the gradient used in the ToolStrip background.
            /// </summary>
            ToolStripGradientMiddle,
            /// <summary>
            /// The starting color of the gradient used in the ToolStripPanel.
            /// </summary>
            ToolStripPanelGradientBegin,
            /// <summary>
            /// The end color of the gradient used in the ToolStripPanel.
            /// </summary>
            ToolStripPanelGradientEnd,
            /// <summary>
            /// 
            /// </summary>
            LastKnownColor = SeparatorLight
        }

        #endregion

        #region FieldsPrivate

		private bool m_bUseProfessionalColors;
		private Dictionary<KnownColors, Color> m_dictionaryRGBTable;
		private object m_colorFreshnessKey;
		[ThreadStatic]
		private static object m_objColorFreshnessKey;


		#endregion

        #region Properties
        #region Properties

        public virtual Color ContextMenuItem
        {
            get { return this.FromKnownColor(KnownColors.ContextMenuItem); }
        }
        public virtual Color ContextMenuItemText
        {
            get { return this.FromKnownColor(KnownColors.ContextMenuItemText); }
        }
                #endregion

        /// <summary>
        /// Gets the starting color of the gradient used when the button is pressed down.
        /// </summary>
        public override Color ButtonPressedGradientBegin
        {
            get
            {
                return this.FromKnownColor(KnownColors.ButtonPressedGradientBegin);
            }
        }
        /// <summary>
        /// Gets the end color of the gradient used when the button is pressed down.
        /// </summary>
        public override Color ButtonPressedGradientEnd
        {
			get
			{
				return this.FromKnownColor(KnownColors.ButtonPressedGradientEnd);
			}
        }
        /// <summary>
        /// Gets the middle color of the gradient used when the button is pressed down.
        /// </summary>
        public override Color ButtonPressedGradientMiddle
        {
            get
            {
				return this.FromKnownColor(KnownColors.ButtonPressedGradientMiddle);
            }
        }
        /// <summary>
        /// Gets the starting color of the gradient used when the button is selected.
        /// </summary>
        public override Color ButtonSelectedBorder
        {
			get
			{
				return this.FromKnownColor(KnownColors.ButtonSelectedBorder);
			}
        }
        /// <summary>
        /// Gets the starting color of the gradient used when the button is selected.
        /// </summary>
        public override Color ButtonSelectedGradientBegin
        {
			get
			{
				return this.FromKnownColor(KnownColors.ButtonSelectedGradientBegin);
			}
        }
        /// <summary>
        /// Gets the end color of the gradient used when the button is selected.
        /// </summary>
        public override Color ButtonSelectedGradientEnd
        {
			get
			{
				return this.FromKnownColor(KnownColors.ButtonSelectedGradientEnd);
			}
        }
        /// <summary>
        /// Gets the middle color of the gradient used when the button is selected.
        /// </summary>
        public override Color ButtonSelectedGradientMiddle
        {
			get
			{
				return this.FromKnownColor(KnownColors.ButtonSelectedGradientMiddle);
			}
        }
		
        /// <summary>
        /// Gets the border color to use with ButtonSelectedHighlight.
        /// </summary>
        public override Color ButtonSelectedHighlightBorder
        {
			get
			{
				return this.FromKnownColor(KnownColors.ButtonSelectedHighlightBorder);
			}
        }
        /// <summary>
        /// Gets the solid color to use when the check box is selected and gradients are being used.
        /// </summary>
        public override Color CheckBackground
        {
			get
			{
				return this.FromKnownColor(KnownColors.CheckBackground);
			}
        }
		/// <summary>
		/// Gets the solid color to use when the check box is selected and gradients are being used.
		/// </summary>
		public override Color CheckSelectedBackground
		{
			get
			{
				return this.FromKnownColor(KnownColors.CheckSelectedBackground);
			}
		}

        /// <summary>
        /// Gets the color to use for shadow effects on the grip or move handle.
        /// </summary>
        public override Color GripDark
        {
			get
			{
				return this.FromKnownColor(KnownColors.GripDark);
			}
        }
        /// <summary>
        /// Gets the color to use for highlight effects on the grip or move handle.
        /// </summary>
        public override Color GripLight
        {
			get
			{
				return this.FromKnownColor(KnownColors.GripLight);
			}
        }
        /// <summary>
        /// Gets the starting color of the gradient used in the image margin of a ToolStripDropDownMenu.
        /// </summary>
        public override Color ImageMarginGradientBegin
        {
			get
			{
				return this.FromKnownColor(KnownColors.ImageMarginGradientBegin);
			}
        }
        /// <summary>
        /// Gets the border color or a MenuStrip.
        /// </summary>
        public override Color MenuBorder
        {
			get
			{
				return this.FromKnownColor(KnownColors.MenuBorder);
			}
        }
        /// <summary>
        /// Gets the border color to use with a ToolStripMenuItem.
        /// </summary>
        public override Color MenuItemBorder
        {
			get
			{
				return this.FromKnownColor(KnownColors.MenuItemBorder);
			}
        }
        /// <summary>
        /// Gets the starting color of the gradient used when a top-level ToolStripMenuItem is pressed down.
        /// </summary>
        public override Color MenuItemPressedGradientBegin
        {
			get
			{
				return this.FromKnownColor(KnownColors.MenuItemPressedGradientBegin);
			}
        }
        /// <summary>
        /// Gets the end color of the gradient used when a top-level ToolStripMenuItem is pressed down.
        /// </summary>
        public override Color MenuItemPressedGradientEnd
        {
			get
			{
				return this.FromKnownColor(KnownColors.MenuItemPressedGradientEnd);
			}
        }
        /// <summary>
        /// Gets the middle color of the gradient used when a top-level ToolStripMenuItem is pressed down.
        /// </summary>
        public override Color MenuItemPressedGradientMiddle
        {
			get
			{
				return this.FromKnownColor(KnownColors.MenuItemPressedGradientMiddle);
			}
        }
		/// <summary>
		/// Gets the solid color to use when a ToolStripMenuItem other than the top-level ToolStripMenuItem is selected.
		/// </summary>
		public override Color MenuItemSelected
		{
			get
			{
				return this.FromKnownColor(KnownColors.MenuItemSelected);
			}
		}
		/// <summary>
		/// Gets the text color of a top-level ToolStripMenuItem.
		/// </summary>
		public virtual Color MenuItemText
		{
			get
			{
				return this.FromKnownColor(KnownColors.MenuItemText);
			}
		}
        /// <summary>
        /// Gets the starting color of the gradient used when the ToolStripMenuItem is selected.
        /// </summary>
        public override Color MenuItemSelectedGradientBegin
        {
			get
			{
				return this.FromKnownColor(KnownColors.MenuItemSelectedGradientBegin);
			}
        }
        /// <summary>
        /// Gets the end color of the gradient used when the ToolStripMenuItem is selected.
        /// </summary>
        public override Color MenuItemSelectedGradientEnd
        {
			get
			{
				return this.FromKnownColor(KnownColors.MenuItemSelectedGradientEnd);
			}
        }
        /// <summary>
        /// Gets the starting color of the gradient used in the MenuStrip.
        /// </summary>
        public override Color MenuStripGradientBegin
        {
			get
			{
				return this.FromKnownColor(KnownColors.MenuStripGradientBegin);
			}
        }
        /// <summary>
        /// Gets the end color of the gradient used in the MenuStrip.
        /// </summary>
        public override Color MenuStripGradientEnd
        {
			get
			{
				return this.FromKnownColor(KnownColors.MenuStripGradientEnd);
			}
        }
        /// <summary>
        /// Gets the starting color of the gradient used in the ToolStripOverflowButton.
        /// </summary>
        public override Color OverflowButtonGradientBegin
        {
            get
            {
				return this.FromKnownColor(KnownColors.OverflowButtonGradientBegin);
            }
        }
        /// <summary>
        /// Gets the end color of the gradient used in the ToolStripOverflowButton.
        /// </summary>
        public override Color OverflowButtonGradientEnd
        {
            get
            {
				return this.FromKnownColor(KnownColors.OverflowButtonGradientEnd);
            }
        }
        /// <summary>
        /// Gets the middle color of the gradient used in the ToolStripOverflowButton.
        /// </summary>
        public override Color OverflowButtonGradientMiddle
        {
			get
			{
				return this.FromKnownColor(KnownColors.OverflowButtonGradientMiddle);
			}
        }
        /// <summary>
        /// Gets the starting color of the gradient used in the ToolStripContainer.
        /// </summary>
        public override Color RaftingContainerGradientBegin
        {
			get
			{
				return this.FromKnownColor(KnownColors.RaftingContainerGradientBegin);
			}
        }
        /// <summary>
        /// Gets the end color of the gradient used in the ToolStripContainer.
        /// </summary>
        public override Color RaftingContainerGradientEnd
        {
			get
			{
				return this.FromKnownColor(KnownColors.RaftingContainerGradientEnd);
			}
        }
        /// <summary>
        /// Gets the color to use to for shadow effects on the ToolStripSeparator.
        /// </summary>
        public override Color SeparatorDark
        {
			get
			{
				return this.FromKnownColor(KnownColors.SeparatorDark);
			}
        }
        /// <summary>
        /// Gets the color to use to for highlight effects on the ToolStripSeparator.
        /// </summary>
        public override Color SeparatorLight
        {
			get
			{
				return this.FromKnownColor(KnownColors.SeparatorLight);
			}
        }
        /// <summary>
        /// Gets the starting color of the gradient used on the StatusStrip.
        /// </summary>
        public override Color StatusStripGradientBegin
        {
			get
			{
				return this.FromKnownColor(KnownColors.StatusStripGradientBegin);
			}
        }
        /// <summary>
        /// Gets the end color of the gradient used on the StatusStrip.
        /// </summary>
        public override Color StatusStripGradientEnd
        {
			get
			{
				return this.FromKnownColor(KnownColors.StatusStripGradientEnd);
			}
        }
		/// <summary>
		/// Gets the text color used on the StatusStrip.
		/// </summary>
		public virtual Color StatusStripText
		{
			get
			{
				return this.FromKnownColor(KnownColors.StatusStripText);
			}
		}
        /// <summary>
        /// Gets the border color to use on the bottom edge of the ToolStrip.
        /// </summary>
        public override Color ToolStripBorder
        {
			get
			{
				return this.FromKnownColor(KnownColors.ToolStripBorder);
			}
        }
        /// <summary>
        /// Gets the starting color of the gradient used in the ToolStripContentPanel.
        /// </summary>
        public override Color ToolStripContentPanelGradientBegin
        {
			get
			{
				return this.FromKnownColor(KnownColors.ToolStripContentPanelGradientBegin);
			}
        }
        /// <summary>
        /// Gets the end color of the gradient used in the ToolStripContentPanel.
        /// </summary>
        public override Color ToolStripContentPanelGradientEnd
        {
			get
			{
				return this.FromKnownColor(KnownColors.ToolStripContentPanelGradientEnd);
			}
        }
        /// <summary>
        /// Gets the solid background color of the ToolStripDropDown.
        /// </summary>
        public override Color ToolStripDropDownBackground
        {
			get
			{
				return this.FromKnownColor(KnownColors.ToolStripDropDownBackground);
			}
        }
        /// <summary>
        /// Gets the starting color of the gradient used in the ToolStrip background.
        /// </summary>
        public override Color ToolStripGradientBegin
        {
			get
			{
				return this.FromKnownColor(KnownColors.ToolStripGradientBegin);
			}
        }
        /// <summary>
        /// Gets the end color of the gradient used in the ToolStrip background.
        /// </summary>
        public override Color ToolStripGradientEnd
        {
			get
			{
				return this.FromKnownColor(KnownColors.ToolStripGradientEnd);
			}
        }
        /// <summary>
        /// Gets the middle color of the gradient used in the ToolStrip background.
        /// </summary>
        public override Color ToolStripGradientMiddle
        {
			get
			{
				return this.FromKnownColor(KnownColors.ToolStripGradientMiddle);
			}
        }
        /// <summary>
        /// Gets the starting color of the gradient used in the ToolStripPanel.
        /// </summary>
        public override Color ToolStripPanelGradientBegin
        {
			get
			{
				return this.FromKnownColor(KnownColors.ToolStripPanelGradientBegin);
			}
        }
        /// <summary>
        /// Gets the end color of the gradient used in the ToolStripPanel.
        /// </summary>
        public override Color ToolStripPanelGradientEnd
        {
			get
			{
				return this.FromKnownColor(KnownColors.ToolStripPanelGradientEnd);
			}
        }
		/// <summary>
		/// Gets or sets a value indicating whether to use the extended colors.
		/// </summary>
		public bool UseProfessionalColors
		{
			get { return this.m_bUseProfessionalColors; }
			set
			{
				if (value.Equals(this.m_bUseProfessionalColors) == false)
				{
					this.m_bUseProfessionalColors = value;
					if (this.m_dictionaryRGBTable != null)
					{
						this.m_dictionaryRGBTable.Clear();
						this.m_dictionaryRGBTable = null;
					}
				}
			}
		}
		/// <summary>
		/// Gets or sets a value indicating whether to use System.Drawing.SystemColors rather than colors that match the current visual style.
		/// </summary>
		public new bool UseSystemColors
		{
			get { return base.UseSystemColors; }
			set
			{
				if (value.Equals(base.UseSystemColors) == false)
				{
					base.UseSystemColors = value;
					if (this.m_dictionaryRGBTable != null)
					{
						this.m_dictionaryRGBTable.Clear();
						this.m_dictionaryRGBTable = null;
					}
				}
			}
		}
		internal static object ColorFreshnessKey
		{
			get
			{
				return m_objColorFreshnessKey;
			}
		}
        public Color FromKnownColor(KnownColors color)
        {
			return (Color)this.ColorTable[color];
        }
        
        public Dictionary<KnownColors, Color> ColorTable
        {
			get
			{
				if (ProfessionalColorTable.ColorFreshnessKey != this.m_colorFreshnessKey)
				{
					if (this.m_dictionaryRGBTable != null)
					{
						this.m_dictionaryRGBTable.Clear();
					}
					this.m_dictionaryRGBTable = null;
				}
				this.m_colorFreshnessKey = ProfessionalColorTable.ColorFreshnessKey;
				if (this.m_dictionaryRGBTable == null)
				{
					this.m_dictionaryRGBTable = new Dictionary<KnownColors, Color>(0xd4);
					if ((this.UseSystemColors == true) || 
						(this.m_bUseProfessionalColors == true)||
						(DisplayInformation.IsLunaTheme == false) && (DisplayInformation.IsAeroTheme == false))
					{
						InitBaseColors(ref m_dictionaryRGBTable);
					}
					else
					{
						InitColors(ref this.m_dictionaryRGBTable);
					}
				}
				return this.m_dictionaryRGBTable;
			}
        }

		#endregion

		#region MethodsPublic
		/// <summary>
        /// Initialize a new instance of the ProfessionalColorTable class.
        /// </summary>
        public ProfessionalColorTable()
        {
			Microsoft.Win32.SystemEvents.UserPreferenceChanged += new Microsoft.Win32.UserPreferenceChangedEventHandler(SystemEventsUserPreferenceChanged);
        }

        #endregion

        #region MethodsProtected
        /// <summary>
        /// Initialize a color Dictionary with defined colors
        /// </summary>
        /// <param name="rgbTable">Dictionary with defined colors</param>
        protected virtual void InitColors(ref Dictionary<KnownColors, Color> rgbTable)
        {
            InitBaseColors(ref rgbTable);
        }
        #endregion

        #region MethodsPrivate

		private void InitBaseColors(ref Dictionary<KnownColors, Color> rgbTable)
		{
			rgbTable[KnownColors.ButtonPressedGradientBegin] = base.ButtonPressedGradientBegin;
			rgbTable[KnownColors.ButtonPressedGradientEnd] = base.ButtonPressedGradientEnd;
			rgbTable[KnownColors.ButtonPressedGradientMiddle] = base.ButtonPressedGradientMiddle;
			rgbTable[KnownColors.ButtonSelectedBorder] = base.ButtonSelectedBorder;
			rgbTable[KnownColors.ButtonSelectedGradientBegin] = base.ButtonSelectedGradientBegin;
			rgbTable[KnownColors.ButtonSelectedGradientEnd] = base.ButtonSelectedGradientEnd;
			rgbTable[KnownColors.ButtonSelectedGradientMiddle] = base.ButtonSelectedGradientMiddle;
			rgbTable[KnownColors.ButtonSelectedHighlightBorder] = base.ButtonSelectedHighlightBorder;
			rgbTable[KnownColors.CheckBackground] = base.CheckBackground;
			rgbTable[KnownColors.CheckSelectedBackground] = base.CheckSelectedBackground;
            rgbTable[KnownColors.ContextMenuItem] = Color.FromArgb(0, 0, 0);
            rgbTable[KnownColors.ContextMenuItemText] = Color.FromArgb(0, 0, 0);
			rgbTable[KnownColors.GripDark] = base.GripDark;
			rgbTable[KnownColors.GripLight] = base.GripLight;
			rgbTable[KnownColors.ImageMarginGradientBegin] = base.ImageMarginGradientBegin;
			rgbTable[KnownColors.MenuBorder] = base.MenuBorder;
			rgbTable[KnownColors.MenuItemBorder] = base.MenuItemBorder;
			rgbTable[KnownColors.MenuItemPressedGradientBegin] = base.MenuItemPressedGradientBegin;
			rgbTable[KnownColors.MenuItemPressedGradientEnd] = base.MenuItemPressedGradientEnd;
			rgbTable[KnownColors.MenuItemPressedGradientMiddle] = base.MenuItemPressedGradientMiddle;
			rgbTable[KnownColors.MenuItemSelected] = base.MenuItemSelected;
			rgbTable[KnownColors.MenuItemSelectedGradientBegin] = base.MenuItemSelectedGradientBegin;
			rgbTable[KnownColors.MenuItemSelectedGradientEnd] = base.MenuItemSelectedGradientEnd;
			rgbTable[KnownColors.MenuItemText] = Color.FromArgb(0, 0, 0);
			rgbTable[KnownColors.MenuStripGradientBegin] = base.MenuStripGradientBegin;
			rgbTable[KnownColors.MenuStripGradientEnd] = base.MenuStripGradientEnd;
			rgbTable[KnownColors.OverflowButtonGradientBegin] = base.OverflowButtonGradientBegin;
			rgbTable[KnownColors.OverflowButtonGradientEnd] = base.OverflowButtonGradientEnd;
			rgbTable[KnownColors.OverflowButtonGradientMiddle] = base.OverflowButtonGradientMiddle;
			rgbTable[KnownColors.RaftingContainerGradientBegin] = base.RaftingContainerGradientBegin;
			rgbTable[KnownColors.RaftingContainerGradientEnd] = base.RaftingContainerGradientEnd;
			rgbTable[KnownColors.SeparatorDark] = base.SeparatorDark;
			rgbTable[KnownColors.SeparatorLight] = base.SeparatorLight;
			rgbTable[KnownColors.StatusStripGradientBegin] = base.StatusStripGradientBegin;
			rgbTable[KnownColors.StatusStripGradientEnd] = base.StatusStripGradientEnd;
			rgbTable[KnownColors.StatusStripText] = Color.FromArgb(0, 0, 0);
			rgbTable[KnownColors.ToolStripBorder] = base.ToolStripBorder;
			rgbTable[KnownColors.ToolStripContentPanelGradientBegin] = base.ToolStripContentPanelGradientBegin;
			rgbTable[KnownColors.ToolStripContentPanelGradientEnd] = base.ToolStripContentPanelGradientEnd;
			rgbTable[KnownColors.ToolStripDropDownBackground] = base.ToolStripDropDownBackground;
			rgbTable[KnownColors.ToolStripGradientBegin] = base.ToolStripGradientBegin;
			rgbTable[KnownColors.ToolStripGradientEnd] = base.ToolStripGradientEnd;
			rgbTable[KnownColors.ToolStripGradientMiddle] = base.ToolStripGradientMiddle;
			rgbTable[KnownColors.ToolStripPanelGradientBegin] = base.ToolStripPanelGradientBegin;
			rgbTable[KnownColors.ToolStripPanelGradientEnd] = base.ToolStripPanelGradientEnd;
		}

		private static void SystemEventsUserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
		{
			m_objColorFreshnessKey = new object();
		}

		#endregion
	}
}
