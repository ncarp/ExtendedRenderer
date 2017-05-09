using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Office2007Renderer
{
    /// <summary>
    /// Provide Office 2007 Blue Theme colors
    /// </summary>
    public class AquaGreenColorTable : ProfessionalColorTable
	{
		#region FieldsPrivate
		#endregion

        #region Properties
        #endregion

		#region MethodsPublic
        #endregion

        #region MethodsProtected

        /// <summary>
        /// initialize a color Dictionary with defined colors
        /// </summary>
        /// <param name="rgbTable">Dictionary with defined colors</param>
        protected override void InitColors(ref Dictionary<ProfessionalColorTable.KnownColors, Color> rgbTable)
        {
            rgbTable[KnownColors.ButtonPressedGradientBegin] = Color.FromArgb(248, 181, 106);
            rgbTable[KnownColors.ButtonPressedGradientEnd] = Color.FromArgb(255, 208, 134);
            rgbTable[KnownColors.ButtonPressedGradientMiddle] = Color.FromArgb(251, 140, 60);
            rgbTable[KnownColors.ButtonSelectedBorder] = Color.FromArgb(255, 189, 105);
            rgbTable[KnownColors.ButtonSelectedGradientBegin] = Color.FromArgb(255, 245, 204);
            rgbTable[KnownColors.ButtonSelectedGradientEnd] = Color.FromArgb(255, 219, 117);
            rgbTable[KnownColors.ButtonSelectedGradientMiddle] = Color.FromArgb(255, 231, 162);
			rgbTable[KnownColors.ButtonSelectedHighlightBorder] = Color.FromArgb(255, 189, 105);
            rgbTable[KnownColors.CheckBackground] = Color.FromArgb(255, 227, 149);
			rgbTable[KnownColors.CheckSelectedBackground] = Color.FromArgb(254, 128, 62);
            rgbTable[KnownColors.ContextMenuItem] = Color.DarkGreen;
            rgbTable[KnownColors.ContextMenuItemText] = Color.DarkGreen;
			rgbTable[KnownColors.GripDark] = Color.FromArgb(46, 139, 87);
            rgbTable[KnownColors.GripLight] = Color.FromArgb(151, 219, 181);
            rgbTable[KnownColors.ImageMarginGradientBegin] = Color.FromArgb(239, 239, 239);
			rgbTable[KnownColors.MenuBorder] = Color.FromArgb(46, 122, 87);
            rgbTable[KnownColors.MenuItemBorder] = Color.FromArgb(255, 189, 105);
			rgbTable[KnownColors.MenuItemPressedGradientBegin] = Color.FromArgb(242, 248, 244);
			rgbTable[KnownColors.MenuItemPressedGradientEnd] = Color.FromArgb(46, 139, 87);
			rgbTable[KnownColors.MenuItemPressedGradientMiddle] = Color.FromArgb(85, 161, 119);
			rgbTable[KnownColors.MenuItemSelected] = Color.FromArgb(255, 238, 194);
			rgbTable[KnownColors.MenuItemSelectedGradientBegin] = Color.FromArgb(255, 245, 204);
            rgbTable[KnownColors.MenuItemSelectedGradientEnd] = Color.FromArgb(255, 223, 132);
			rgbTable[KnownColors.MenuItemText] = Color.FromArgb(255, 255, 255);
            rgbTable[KnownColors.MenuStripGradientBegin] = Color.FromArgb(85, 161, 119);
            rgbTable[KnownColors.MenuStripGradientEnd] = Color.FromArgb(189, 219, 202);
			rgbTable[KnownColors.OverflowButtonGradientBegin] = Color.FromArgb(68, 202, 115);
			rgbTable[KnownColors.OverflowButtonGradientEnd] = Color.FromArgb(46, 122, 87);
			rgbTable[KnownColors.OverflowButtonGradientMiddle] = Color.FromArgb(46, 139, 87);
            rgbTable[KnownColors.RaftingContainerGradientBegin] = Color.FromArgb(83, 83, 83);
            rgbTable[KnownColors.RaftingContainerGradientEnd] = Color.FromArgb(83, 83, 83);
			rgbTable[KnownColors.SeparatorDark] = Color.FromArgb(46, 139, 87);
			rgbTable[KnownColors.SeparatorLight] = Color.FromArgb(151, 219, 181);
            rgbTable[KnownColors.StatusStripGradientBegin] = Color.FromArgb(46, 139, 87);
            rgbTable[KnownColors.StatusStripGradientEnd] = Color.FromArgb(46, 139, 87);
			rgbTable[KnownColors.StatusStripText] = Color.FromArgb(255, 255, 255);
            rgbTable[KnownColors.ToolStripBorder] = Color.FromArgb(46, 122, 87);
            rgbTable[KnownColors.ToolStripContentPanelGradientBegin] = Color.FromArgb(85, 161, 119);
            rgbTable[KnownColors.ToolStripContentPanelGradientEnd] = Color.FromArgb(189, 219, 202);
            rgbTable[KnownColors.ToolStripDropDownBackground] = Color.FromArgb(250, 250, 250);
            rgbTable[KnownColors.ToolStripGradientBegin] = Color.FromArgb(242, 248, 244);
            rgbTable[KnownColors.ToolStripGradientEnd] = Color.FromArgb(46, 139, 87);
            rgbTable[KnownColors.ToolStripGradientMiddle] = Color.FromArgb(85, 161, 119);
            rgbTable[KnownColors.ToolStripPanelGradientBegin] = Color.FromArgb(85, 161, 119);
            rgbTable[KnownColors.ToolStripPanelGradientEnd] = Color.FromArgb(189, 219, 202);
        }

        #endregion

        #region MethodsPrivate
        #endregion
    }
}
