using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Office2007Renderer
{
    /// <summary>
    /// Provide Office 2007 Blue Theme colors
    /// </summary>
    public class Office2007BlueColorTable : ProfessionalColorTable
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
            rgbTable[KnownColors.ContextMenuItem] = Color.FromArgb(21, 66, 139);
            rgbTable[KnownColors.ContextMenuItemText] = Color.FromArgb(21, 66, 139);
            rgbTable[KnownColors.GripDark] = Color.FromArgb(111, 157, 217);
            rgbTable[KnownColors.GripLight] = Color.FromArgb(255, 255, 255);
            rgbTable[KnownColors.ImageMarginGradientBegin] = Color.FromArgb(233, 238, 238);
            rgbTable[KnownColors.MenuBorder] = Color.FromArgb(134, 134, 134);
            rgbTable[KnownColors.MenuItemBorder] = Color.FromArgb(255, 189, 105);
            rgbTable[KnownColors.MenuItemPressedGradientBegin] = Color.FromArgb(227, 239, 255);
            rgbTable[KnownColors.MenuItemPressedGradientEnd] = Color.FromArgb(152, 186, 230);
            rgbTable[KnownColors.MenuItemPressedGradientMiddle] = Color.FromArgb(222, 236, 255);
			rgbTable[KnownColors.MenuItemSelected] = Color.FromArgb(255, 238, 194);
			rgbTable[KnownColors.MenuItemSelectedGradientBegin] = Color.FromArgb(255, 245, 204);
            rgbTable[KnownColors.MenuItemSelectedGradientEnd] = Color.FromArgb(255, 223, 132);
            rgbTable[KnownColors.MenuItemText] = Color.FromArgb(21, 66, 139);
            rgbTable[KnownColors.MenuStripGradientBegin] = Color.FromArgb(191, 219, 255);
            rgbTable[KnownColors.MenuStripGradientEnd] = Color.FromArgb(191, 219, 255);
            rgbTable[KnownColors.OverflowButtonGradientBegin] = Color.FromArgb(167, 204, 251);
            rgbTable[KnownColors.OverflowButtonGradientEnd] = Color.FromArgb(101, 147, 207);
            rgbTable[KnownColors.OverflowButtonGradientMiddle] = Color.FromArgb(167, 204, 251);
            rgbTable[KnownColors.RaftingContainerGradientBegin] = Color.FromArgb(191, 219, 255);
            rgbTable[KnownColors.RaftingContainerGradientEnd] = Color.FromArgb(191, 219, 255);
            rgbTable[KnownColors.SeparatorDark] = Color.FromArgb(173, 209, 255);
            rgbTable[KnownColors.SeparatorLight] = Color.FromArgb(255, 255, 255);
            rgbTable[KnownColors.StatusStripGradientBegin] = Color.FromArgb(227, 239, 255);
            rgbTable[KnownColors.StatusStripGradientEnd] = Color.FromArgb(173, 209, 255);
			rgbTable[KnownColors.StatusStripText] = Color.FromArgb(21, 66, 139);
            rgbTable[KnownColors.ToolStripBorder] = Color.FromArgb(111, 157, 217);
            rgbTable[KnownColors.ToolStripContentPanelGradientBegin] = Color.FromArgb(191, 219, 255); //Color.FromArgb(191, 219, 255);
            rgbTable[KnownColors.ToolStripContentPanelGradientEnd] = Color.FromArgb(191, 219, 255); //Color.FromArgb(101, 145, 205);
            rgbTable[KnownColors.ToolStripDropDownBackground] = Color.FromArgb(250, 250, 250);
            rgbTable[KnownColors.ToolStripGradientBegin] = Color.FromArgb(227, 239, 255);
            rgbTable[KnownColors.ToolStripGradientEnd] = Color.FromArgb(152, 186, 230);
            rgbTable[KnownColors.ToolStripGradientMiddle] = Color.FromArgb(222, 236, 255);
            rgbTable[KnownColors.ToolStripPanelGradientBegin] = Color.FromArgb(191, 219, 255);
            rgbTable[KnownColors.ToolStripPanelGradientEnd] = Color.FromArgb(191, 219, 255);
        }

        #endregion

        #region MethodsPrivate
        #endregion
    }
}
