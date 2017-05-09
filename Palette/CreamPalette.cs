using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using ComponentFactory.Krypton.Toolkit;
using System.Reflection;


namespace AC.ExtendedRenderer.Toolkit
{
    public class Palette
    {
        
        public static KryptonPalette LoadKryptonPaletteStdCutom(KryptonPalette NewCustomPalette)
        {
            System.IO.Stream PaletteStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("AC.ExtendedRenderer.Toolkit.Palette.StdCustomPalette_v18.xml");
            NewCustomPalette.Import(PaletteStream);
            return NewCustomPalette;
        }

        public static KryptonPalette LoadKryptonPaletteGreen(KryptonPalette NewCustomPalette)
        {
            System.IO.Stream PaletteStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("AC.ExtendedRenderer.Toolkit.Palette.GreenPalette_v18.xml");
            NewCustomPalette.Import(PaletteStream);
            return NewCustomPalette;

        }

        public static KryptonPalette LoadKryptonPaletteHazel(KryptonPalette NewCustomPalette)
        {
            System.IO.Stream PaletteStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("AC.ExtendedRenderer.Toolkit.Palette.Hazel_v18.xml");
            NewCustomPalette.Import(PaletteStream);
            return NewCustomPalette;

        }

        public static KryptonPalette LoadKryptonPaletteAsphalt(KryptonPalette NewCustomPalette)
        {
            System.IO.Stream PaletteStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("AC.ExtendedRenderer.Toolkit.Palette.Asphalt_v18.xml");
            NewCustomPalette.Import(PaletteStream);
            return NewCustomPalette;

        }

        public static KryptonPalette LoadKryptonPaletteChrome(KryptonPalette NewCustomPalette)
        {
            System.IO.Stream PaletteStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("AC.ExtendedRenderer.Toolkit.Palette.Chrome_v18.xml");
            NewCustomPalette.Import(PaletteStream);
            return NewCustomPalette;

        }
        
        public static KryptonPalette LoadKryptonPaletteCream(KryptonPalette NewCustomPalette)
        {
            System.IO.Stream PaletteStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("AC.ExtendedRenderer.Toolkit.Palette.Cream_v18.xml");
            NewCustomPalette.Import(PaletteStream);
            return NewCustomPalette;

        }

        public static KryptonPalette LoadKryptonPaletteWindows7(KryptonPalette NewCustomPalette)
        {
            System.IO.Stream PaletteStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("AC.ExtendedRenderer.Toolkit.Palette.win7_Palette_v18.xml");
            NewCustomPalette.Import(PaletteStream);
            return NewCustomPalette;

        }
        
        public static KryptonPalette LoadKryptonPaletteMcLane(KryptonPalette NewCustomPalette)
        {
            System.IO.Stream PaletteStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("AC.ExtendedRenderer.Toolkit.Palette.McLane_v18.xml");
            NewCustomPalette.Import(PaletteStream);
            return NewCustomPalette;

        }

        public static KryptonPalette LoadKryptonPalettePlastic(KryptonPalette NewCustomPalette)
        {
            System.IO.Stream PaletteStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("AC.ExtendedRenderer.Toolkit.Palette.Plastic_v18.xml");
            NewCustomPalette.Import(PaletteStream);
            return NewCustomPalette;

        }
        

    }
}
