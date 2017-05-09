using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Office2007Renderer
{
    /// <summary>
    /// Provide Red Theme colors
    /// </summary>
    public class ColorTableRed : ProfessionalColorTable
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
            rgbTable[KnownColors.ContextMenuItem] = Color.FromArgb(0, 0, 0);
            rgbTable[KnownColors.ContextMenuItemText] = Color.FromArgb(0, 0, 0);
            rgbTable[KnownColors.GripDark] = Color.FromArgb(226, 116, 116);
            rgbTable[KnownColors.GripLight] = Color.FromArgb(237, 182, 183);
            rgbTable[KnownColors.ImageMarginGradientBegin] = Color.FromArgb(250, 232, 233);
			rgbTable[KnownColors.MenuBorder] = Color.FromArgb(192, 0, 0);
            rgbTable[KnownColors.MenuItemBorder] = Color.FromArgb(255, 189, 105);
			rgbTable[KnownColors.MenuItemPressedGradientBegin] = Color.FromArgb(250, 234, 233);
			rgbTable[KnownColors.MenuItemPressedGradientEnd] = Color.FromArgb(255, 0, 0);
			rgbTable[KnownColors.MenuItemPressedGradientMiddle] = Color.FromArgb(228, 145, 144);
			rgbTable[KnownColors.MenuItemSelected] = Color.FromArgb(255, 238, 194);
			rgbTable[KnownColors.MenuItemSelectedGradientBegin] = Color.FromArgb(255, 245, 204);
            rgbTable[KnownColors.MenuItemSelectedGradientEnd] = Color.FromArgb(255, 223, 132);
			rgbTable[KnownColors.MenuItemText] = Color.FromArgb(255, 255, 255);
            rgbTable[KnownColors.MenuStripGradientBegin] = Color.FromArgb(255, 0, 0);
            rgbTable[KnownColors.MenuStripGradientEnd] = Color.FromArgb(192, 0, 0);
			rgbTable[KnownColors.OverflowButtonGradientBegin] = Color.FromArgb(250, 232, 233);
			rgbTable[KnownColors.OverflowButtonGradientEnd] = Color.FromArgb(234, 130, 131);
            rgbTable[KnownColors.OverflowButtonGradientMiddle] = Color.FromArgb(234, 170, 170);
            rgbTable[KnownColors.RaftingContainerGradientBegin] = Color.FromArgb(234, 200, 200);
            rgbTable[KnownColors.RaftingContainerGradientEnd] = Color.FromArgb(192, 0, 0);
            rgbTable[KnownColors.SeparatorDark] = Color.FromArgb(226, 116, 116);
			rgbTable[KnownColors.SeparatorLight] = Color.FromArgb(237, 182, 183);
            rgbTable[KnownColors.StatusStripGradientBegin] = Color.FromArgb(255, 0, 0);
            rgbTable[KnownColors.StatusStripGradientEnd] = Color.FromArgb(192, 0, 0);
			rgbTable[KnownColors.StatusStripText] = Color.FromArgb(255, 255, 255);
            rgbTable[KnownColors.ToolStripBorder] = Color.FromArgb(160, 0, 0);
            rgbTable[KnownColors.ToolStripContentPanelGradientBegin] = Color.FromArgb(250, 232, 233);
            rgbTable[KnownColors.ToolStripContentPanelGradientEnd] = Color.FromArgb(228, 146, 146);
            rgbTable[KnownColors.ToolStripDropDownBackground] = Color.FromArgb(250, 250, 250);
            rgbTable[KnownColors.ToolStripGradientBegin] = Color.FromArgb(255, 180, 180);
            rgbTable[KnownColors.ToolStripGradientEnd] = Color.FromArgb(255, 0, 0);
            rgbTable[KnownColors.ToolStripGradientMiddle] = Color.FromArgb(255, 100, 100);
            rgbTable[KnownColors.ToolStripPanelGradientBegin] = Color.FromArgb(255, 0, 0);
            rgbTable[KnownColors.ToolStripPanelGradientEnd] = Color.FromArgb(192, 0, 0);
        }

        #endregion

        #region MethodsPrivate
        #endregion
    }
}
