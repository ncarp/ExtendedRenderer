using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Office2007Renderer.ThemedControls
{
    [System.Drawing.ToolboxBitmapAttribute(typeof(System.Windows.Forms.Button)), ToolboxItem(false)]
    public class ThemedButton : AC.StdControls.Toolkit.Buttons.CustomButton
    {
        public ThemedButton()
        {
            // Set the SystemEvents class to receive event notification when a user 
            // preference changes, the palette changes, or when display settings change.
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            ToolStripManager.RendererChanged += new EventHandler(ToolStripManager_RendererChanged);

            InitColors();
            ToolStripManager_RendererChanged(this, new EventArgs() );
        }

        private void InitColors()
        {
            try
            //myCustom Renderer
            {
                Office2007Renderer renderer = (Office2007Renderer)ToolStripManager.Renderer;
                ProfessionalColorTable _colorTable = (ProfessionalColorTable)renderer.ColorTable;
                //Set Colors
                GradientTop = _colorTable.ToolStripGradientBegin;
                GradientBottom = _colorTable.ToolStripGradientMiddle;
                GradientBorderColor = _colorTable.ToolStripBorder;
                if (GradientBorderColor == Color.White) GradientBorderColor = Color.LightGray;
                this.ForeColor = _colorTable.MenuItemText;
                HotForeColor = _colorTable.MenuItemText;
                PressedForeColor = _colorTable.MenuItemText;
            }
            catch (Exception ex)
            {
                try
                    {
                        System.Windows.Forms.ToolStripProfessionalRenderer renderer = (System.Windows.Forms.ToolStripProfessionalRenderer)ToolStripManager.Renderer;
                        System.Windows.Forms.ProfessionalColorTable _colorTable = (System.Windows.Forms.ProfessionalColorTable)renderer.ColorTable;
                        //Set Colors
                        GradientTop = _colorTable.ToolStripGradientBegin;
                        GradientBottom = _colorTable.ToolStripGradientMiddle;
                        GradientBorderColor = _colorTable.ToolStripBorder;
                        if (GradientBorderColor == Color.White) GradientBorderColor = Color.LightGray;
                        this.ForeColor = _colorTable.SeparatorDark;
                        HotForeColor = _colorTable.SeparatorDark;
                        PressedForeColor = _colorTable.SeparatorDark;
                    }
                    catch (Exception ex3)
                    {
                        Console.WriteLine(ex3.Message);
                }
                Console.WriteLine(ex.Message);
            }
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            try
            {
                InitColors();
            }
            catch 
            {
            }
        }

        void ToolStripManager_RendererChanged(object sender, EventArgs e)
        {
            InitColors();
            this.Invalidate();
        }

    }

}