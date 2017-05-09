using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Office2007Renderer.ThemedControls
{
    [System.Drawing.ToolboxBitmapAttribute(typeof(System.Windows.Forms.Label)), ToolboxItem(false)]
    public class ThemedLabel : System.Windows.Forms.Label
    {

        public override System.Drawing.Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
            }
        }

        public override System.Drawing.Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
            }
        }

        public ThemedLabel()
        {
            
        // Set the SystemEvents class to receive event notification when a user 
        // preference changes, the palette changes, or when display settings change.
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            ToolStripManager.RendererChanged += new EventHandler(ToolStripManager_RendererChanged);

            InitColors();
        }

        private void InitColors()
        {
            try
                //myCustom Renderer
            {
                Office2007Renderer renderer = (Office2007Renderer)ToolStripManager.Renderer;
                ProfessionalColorTable colorTable = (ProfessionalColorTable)renderer.ColorTable;
                //Set Colors
                base.ForeColor = colorTable.MenuItemText;
                base.BackColor = colorTable.ToolStripContentPanelGradientBegin;
            }
            catch (Exception ex)
            {
                //Standard Renderer
                    try
                    {
                        System.Windows.Forms.ToolStripProfessionalRenderer renderer = (System.Windows.Forms.ToolStripProfessionalRenderer)ToolStripManager.Renderer;
                        System.Windows.Forms.ProfessionalColorTable colorTable = (System.Windows.Forms.ProfessionalColorTable)renderer.ColorTable;
                        //Set Colors
                        base.ForeColor = colorTable.GripDark;
                        base.BackColor = colorTable.ToolStripContentPanelGradientBegin;
                    }
                    catch (Exception ex3)
                    {
                        Console.WriteLine(ex3.Message);
                }
                Console.WriteLine(ex.Message);
            }
        }

        void ToolStripManager_RendererChanged(object sender, EventArgs e)
        {
            InitColors();
            this.Invalidate();
        }

    }

}
