
using System.ComponentModel;
using System.Windows.Forms;

namespace Office2007Renderer
{
    [System.Drawing.ToolboxBitmapAttribute(typeof(System.Windows.Forms.ColorDialog)), ToolboxItem(false)]
    public partial class RendererManager : Component
    {
        #region Inialization
        public RendererManager()
        {
            components = new System.ComponentModel.Container();
            pal = Palette.Office2007Blue;
            rnd = Renderer.Standard;
        }

        public RendererManager(IContainer container)
        {
            container.Add(this);

            components = new System.ComponentModel.Container();
            pal = Palette.Office2007Blue;
            rnd = Renderer.Standard;
        }
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion
        
        #region Variables
        Palette pal = Palette.Office2007Blue;
        Renderer rnd = Renderer.Standard;


        #endregion

        #region Properties
        public Palette Palettes
        {
            get { return pal; }
            set
            {
                pal = value;
                switch (rnd)
                {
                    case Renderer.Standard:
                        switch (pal)
                        {
                            case Palette.Office2007Blue:
                                ToolStripManager.Renderer = new Office2007Renderer(new Office2007BlueColorTable());
                                break;
                            case Palette.Office2007Black:
                                ToolStripManager.Renderer = new Office2007Renderer(new Office2007BlackColorTable());
                                break;
                            case Palette.Office2007Silver:
                                ToolStripManager.Renderer = new Office2007Renderer(new Office2007SilverColorTable());
                                break;
                            case Palette.AquaGreen:
                                ToolStripManager.Renderer = new Office2007Renderer(new AquaGreenColorTable());
                                break;
                            case Palette.Professional:
                                ToolStripManager.Renderer = (ToolStripRenderer)new ToolStripProfessionalRenderer();
                                break;
                            case Palette.System:
                                ToolStripManager.Renderer = (ToolStripRenderer)new ToolStripSystemRenderer();
                                break;
                            case Palette.Red:
                                ToolStripManager.Renderer = new Office2007Renderer(new ColorTableRed());
                                break;
                        }
                        break;
                    case Renderer.Flat:
                        switch (pal)
                        {
                            case Palette.Office2007Blue:
                                ToolStripManager.Renderer = new Office2007FlatRenderer(new Office2007BlueColorTable());
                                break;
                            case Palette.Office2007Black:
                                ToolStripManager.Renderer = new Office2007FlatRenderer(new Office2007BlackColorTable());
                                break;
                            case Palette.Office2007Silver:
                                ToolStripManager.Renderer = new Office2007FlatRenderer(new Office2007SilverColorTable());
                                break;
                            case Palette.AquaGreen:
                                ToolStripManager.Renderer = new Office2007FlatRenderer(new AquaGreenColorTable());
                                break;
                            case Palette.Professional:
                                ToolStripManager.Renderer = (ToolStripRenderer)new ToolStripProfessionalRenderer();
                                break;
                            case Palette.System:
                                ToolStripManager.Renderer = (ToolStripRenderer)new ToolStripSystemRenderer();
                                break;
                            case Palette.Red:
                                ToolStripManager.Renderer = new Office2007FlatRenderer(new ColorTableRed());
                                break;
                        }
                        break;
                    case Renderer.Aqua:
                        switch (pal)
                        {
                            case Palette.Office2007Blue:
                                ToolStripManager.Renderer = new AquaRenderer(new Office2007BlueColorTable());
                                break;
                            case Palette.Office2007Black:
                                ToolStripManager.Renderer = new AquaRenderer(new Office2007BlackColorTable());
                                break;
                            case Palette.Office2007Silver:
                                ToolStripManager.Renderer = new AquaRenderer(new Office2007SilverColorTable());
                                break;
                            case Palette.AquaGreen:
                                ToolStripManager.Renderer = new AquaRenderer(new AquaGreenColorTable());
                                break;
                            case Palette.Professional:
                                ToolStripManager.Renderer = (ToolStripRenderer)new ToolStripProfessionalRenderer();
                                break;
                            case Palette.System:
                                ToolStripManager.Renderer = (ToolStripRenderer)new ToolStripSystemRenderer();
                                break;
                            case Palette.Red:
                                ToolStripManager.Renderer = new AquaRenderer(new ColorTableRed());
                                break;
                        }
                        break;
                }
                if (ToolStripManager.Renderer.GetType().BaseType == typeof(Office2007Renderer))
                {
                    Office2007Renderer br = (Office2007Renderer)ToolStripManager.Renderer;
                }
            }
        }
        public Renderer Renderers
        {
            get { return rnd; }
            set
            {
                rnd = value;
                switch (rnd)
                {
                    case Renderer.Standard:
                        switch (pal)
                        {
                            case Palette.Office2007Blue:
                                ToolStripManager.Renderer = new Office2007Renderer(new Office2007BlueColorTable());
                                break;
                            case Palette.Office2007Black:
                                ToolStripManager.Renderer = new Office2007Renderer(new Office2007BlackColorTable());
                                break;
                            case Palette.Office2007Silver:
                                ToolStripManager.Renderer = new Office2007Renderer(new Office2007SilverColorTable());
                                break;
                            case Palette.AquaGreen:
                                ToolStripManager.Renderer = new Office2007Renderer(new AquaGreenColorTable());
                                break;
                            case Palette.Professional:
                                ToolStripManager.Renderer = (ToolStripRenderer)new ToolStripProfessionalRenderer();
                                break;
                            case Palette.System:
                                ToolStripManager.Renderer = (ToolStripRenderer)new ToolStripSystemRenderer();
                                break;
                            case Palette.Red:
                                ToolStripManager.Renderer = new Office2007Renderer(new ColorTableRed());
                                break;
                        }
                        break;
                    case Renderer.Flat:
                        switch (pal)
                        {
                            case Palette.Office2007Blue:
                                ToolStripManager.Renderer = new Office2007FlatRenderer(new Office2007BlueColorTable());
                                break;
                            case Palette.Office2007Black:
                                ToolStripManager.Renderer = new Office2007FlatRenderer(new Office2007BlackColorTable());
                                break;
                            case Palette.Office2007Silver:
                                ToolStripManager.Renderer = new Office2007FlatRenderer(new Office2007SilverColorTable());
                                break;
                            case Palette.AquaGreen:
                                ToolStripManager.Renderer = new Office2007FlatRenderer(new AquaGreenColorTable());
                                break;
                            case Palette.Professional:
                                ToolStripManager.Renderer = (ToolStripRenderer)new ToolStripProfessionalRenderer();
                                break;
                            case Palette.System:
                                ToolStripManager.Renderer = (ToolStripRenderer)new ToolStripSystemRenderer();
                                break;
                            case Palette.Red:
                                ToolStripManager.Renderer = new Office2007FlatRenderer(new ColorTableRed());
                                break;
                        }
                        break;
                    case Renderer.Aqua:
                        switch (pal)
                        {
                            case Palette.Office2007Blue:
                                ToolStripManager.Renderer = new AquaRenderer(new Office2007BlueColorTable());
                                break;
                            case Palette.Office2007Black:
                                ToolStripManager.Renderer = new AquaRenderer(new Office2007BlackColorTable());
                                break;
                            case Palette.Office2007Silver:
                                ToolStripManager.Renderer = new AquaRenderer(new Office2007SilverColorTable());
                                break;
                            case Palette.AquaGreen:
                                ToolStripManager.Renderer = new AquaRenderer(new AquaGreenColorTable());
                                break;
                            case Palette.Professional:
                                ToolStripManager.Renderer = (ToolStripRenderer)new ToolStripProfessionalRenderer();
                                break;
                            case Palette.System:
                                ToolStripManager.Renderer = (ToolStripRenderer)new ToolStripSystemRenderer();
                                break;
                            case Palette.Red:
                                ToolStripManager.Renderer = new AquaRenderer(new ColorTableRed());
                                break;
                        }
                        break;
                }
                if (ToolStripManager.Renderer.GetType().BaseType == typeof(Office2007Renderer))
                {
                    Office2007Renderer br = (Office2007Renderer)ToolStripManager.Renderer;
                }
            }
        }
        /*[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        private Office2007Renderer CustomRendererData
        {
            get { return (Office2007Renderer)ToolStripManager.Renderer; }
        }
         */
        #endregion
    }

    public enum Palette
    {
        Office2007Blue,
        Office2007Black,
        Office2007Silver,
        AquaGreen,
        Red,
        Professional,
        System
    }

    public enum Renderer
    {
        Standard,
        Flat,
        Aqua
    }
}
