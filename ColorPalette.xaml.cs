using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AniLyst_5._0.CustomControls
{
    /// <summary>
    /// Interaction logic for ColorPalette.xaml
    /// </summary>
    public partial class ColorPalette : UserControl
    {
        public static SortedDictionary<string, Brush> BrushBook = new SortedDictionary<string, Brush> { { "Colors.Indigo", Colors.Indigo.ToBrush() }, { "Colors.LightYellow", Colors.LightYellow.ToBrush() }, { "Colors.MediumTurquoise", Colors.MediumTurquoise.ToBrush() }, { "Colors.Beige", Colors.Beige.ToBrush() }, { "Colors.DarkGoldenrod", Colors.DarkGoldenrod.ToBrush() }, { "Colors.Turquoise", Colors.Turquoise.ToBrush() }, { "Colors.SaddleBrown", Colors.SaddleBrown.ToBrush() }, { "Colors.LightGoldenrodYellow", Colors.LightGoldenrodYellow.ToBrush() }, { "Colors.Aqua", Colors.Aqua.ToBrush() }, { "Colors.Wheat", Colors.Wheat.ToBrush() }, { "Colors.DarkViolet", Colors.DarkViolet.ToBrush() }, { "Colors.Salmon", Colors.Salmon.ToBrush() }, { "Colors.PapayaWhip", Colors.PapayaWhip.ToBrush() }, { "Colors.MediumPurple", Colors.MediumPurple.ToBrush() }, { "Colors.Black", Colors.Black.ToBrush() }, { "Colors.MediumAquamarine", Colors.MediumAquamarine.ToBrush() }, { "Colors.DarkTurquoise", Colors.DarkTurquoise.ToBrush() }, { "Colors.Linen", Colors.Linen.ToBrush() }, { "Colors.SeaGreen", Colors.SeaGreen.ToBrush() }, { "Colors.DarkGray", Colors.DarkGray.ToBrush() }, { "Colors.NavajoWhite", Colors.NavajoWhite.ToBrush() }, { "Colors.SlateGray", Colors.SlateGray.ToBrush() }, { "Colors.LightSalmon", Colors.LightSalmon.ToBrush() }, { "Colors.Pink", Colors.Pink.ToBrush() }, { "Colors.Sienna", Colors.Sienna.ToBrush() }, { "Colors.Magenta", Colors.Magenta.ToBrush() }, { "Colors.Goldenrod", Colors.Goldenrod.ToBrush() }, { "Colors.LimeGreen", Colors.LimeGreen.ToBrush() }, { "Colors.WhiteSmoke", Colors.WhiteSmoke.ToBrush() }, { "Colors.Olive", Colors.Olive.ToBrush() }, { "Colors.Orange", Colors.Orange.ToBrush() }, { "Colors.Moccasin", Colors.Moccasin.ToBrush() }, { "Colors.Tomato", Colors.Tomato.ToBrush() }, { "Colors.RoyalBlue", Colors.RoyalBlue.ToBrush() }, { "Colors.LightSlateGray", Colors.LightSlateGray.ToBrush() }, { "Colors.Cornsilk", Colors.Cornsilk.ToBrush() }, { "Colors.White", Colors.White.ToBrush() }, { "Colors.PaleGoldenrod", Colors.PaleGoldenrod.ToBrush() }, { "Colors.Firebrick", Colors.Firebrick.ToBrush() }, { "Colors.Gold", Colors.Gold.ToBrush() }, { "Colors.LightCoral", Colors.LightCoral.ToBrush() }, { "Colors.Red", Colors.Red.ToBrush() }, { "Colors.Cyan", Colors.Cyan.ToBrush() }, { "Colors.DarkGreen", Colors.DarkGreen.ToBrush() }, { "Colors.MediumSeaGreen", Colors.MediumSeaGreen.ToBrush() }, { "Colors.SlateBlue", Colors.SlateBlue.ToBrush() }, { "Colors.Peru", Colors.Peru.ToBrush() }, { "Colors.DarkOrchid", Colors.DarkOrchid.ToBrush() }, { "Colors.Crimson", Colors.Crimson.ToBrush() }, { "Colors.DodgerBlue", Colors.DodgerBlue.ToBrush() }, { "Colors.DarkBlue", Colors.DarkBlue.ToBrush() }, { "Colors.Chocolate", Colors.Chocolate.ToBrush() }, { "Colors.DarkMagenta", Colors.DarkMagenta.ToBrush() }, { "Colors.Honeydew", Colors.Honeydew.ToBrush() }, { "Colors.DarkKhaki", Colors.DarkKhaki.ToBrush() }, { "Colors.Snow", Colors.Snow.ToBrush() }, { "Colors.LemonChiffon", Colors.LemonChiffon.ToBrush() }, { "Colors.DarkSlateBlue", Colors.DarkSlateBlue.ToBrush() }, { "Colors.Bisque", Colors.Bisque.ToBrush() }, { "Colors.Green", Colors.Green.ToBrush() }, { "Colors.LightSkyBlue", Colors.LightSkyBlue.ToBrush() }, { "Colors.DarkRed", Colors.DarkRed.ToBrush() }, { "Colors.Lavender", Colors.Lavender.ToBrush() }, { "Colors.BlanchedAlmond", Colors.BlanchedAlmond.ToBrush() }, { "Colors.DeepSkyBlue", Colors.DeepSkyBlue.ToBrush() }, { "Colors.PaleTurquoise", Colors.PaleTurquoise.ToBrush() }, { "Colors.DarkSalmon", Colors.DarkSalmon.ToBrush() }, { "Colors.Lime", Colors.Lime.ToBrush() }, { "Colors.PaleGreen", Colors.PaleGreen.ToBrush() }, { "Colors.Yellow", Colors.Yellow.ToBrush() }, { "Colors.AliceBlue", Colors.AliceBlue.ToBrush() }, { "Colors.OldLace", Colors.OldLace.ToBrush() }, { "Colors.Blue", Colors.Blue.ToBrush() }, { "Colors.LightSeaGreen", Colors.LightSeaGreen.ToBrush() }, { "Colors.AntiqueWhite", Colors.AntiqueWhite.ToBrush() }, { "Colors.MediumBlue", Colors.MediumBlue.ToBrush() }, { "Colors.MediumSlateBlue", Colors.MediumSlateBlue.ToBrush() }, { "Colors.Teal", Colors.Teal.ToBrush() }, { "Colors.Orchid", Colors.Orchid.ToBrush() }, { "Colors.MistyRose", Colors.MistyRose.ToBrush() }, { "Colors.DarkSlateGray", Colors.DarkSlateGray.ToBrush() }, { "Colors.Gainsboro", Colors.Gainsboro.ToBrush() }, { "Colors.Coral", Colors.Coral.ToBrush() }, { "Colors.MidnightBlue", Colors.MidnightBlue.ToBrush() }, { "Colors.BlueViolet", Colors.BlueViolet.ToBrush() }, { "Colors.RosyBrown", Colors.RosyBrown.ToBrush() }, { "Colors.Tan", Colors.Tan.ToBrush() }, { "Colors.ForestGreen", Colors.ForestGreen.ToBrush() }, { "Colors.Ivory", Colors.Ivory.ToBrush() }, { "Colors.MintCream", Colors.MintCream.ToBrush() }, { "Colors.SpringGreen", Colors.SpringGreen.ToBrush() }, { "Colors.YellowGreen", Colors.YellowGreen.ToBrush() }, { "Colors.HotPink", Colors.HotPink.ToBrush() }, { "Colors.SkyBlue", Colors.SkyBlue.ToBrush() }, { "Colors.GreenYellow", Colors.GreenYellow.ToBrush() }, { "Colors.LightCyan", Colors.LightCyan.ToBrush() }, { "Colors.Fuchsia", Colors.Fuchsia.ToBrush() }, { "Colors.LightGreen", Colors.LightGreen.ToBrush() }, { "Colors.DarkOrange", Colors.DarkOrange.ToBrush() }, { "Colors.BurlyWood", Colors.BurlyWood.ToBrush() }, { "Colors.Plum", Colors.Plum.ToBrush() }, { "Colors.LightBlue", Colors.LightBlue.ToBrush() }, { "Colors.Thistle", Colors.Thistle.ToBrush() }, { "Colors.LightSteelBlue", Colors.LightSteelBlue.ToBrush() }, { "Colors.SandyBrown", Colors.SandyBrown.ToBrush() }, { "Colors.OrangeRed", Colors.OrangeRed.ToBrush() }, { "Colors.LightGray", Colors.LightGray.ToBrush() }, { "Colors.DarkOliveGreen", Colors.DarkOliveGreen.ToBrush() }, { "Colors.IndianRed", Colors.IndianRed.ToBrush() }, { "Colors.DimGray", Colors.DimGray.ToBrush() }, { "Colors.LavenderBlush", Colors.LavenderBlush.ToBrush() }, { "Colors.CadetBlue", Colors.CadetBlue.ToBrush() }, { "Colors.Brown", Colors.Brown.ToBrush() }, { "Colors.DeepPink", Colors.DeepPink.ToBrush() }, { "Colors.Gray", Colors.Gray.ToBrush() }, { "Colors.MediumOrchid", Colors.MediumOrchid.ToBrush() }, { "Colors.PaleVioletRed", Colors.PaleVioletRed.ToBrush() }, { "Colors.DarkSeaGreen", Colors.DarkSeaGreen.ToBrush() }, { "Colors.Maroon", Colors.Maroon.ToBrush() }, { "Colors.SteelBlue", Colors.SteelBlue.ToBrush() }, { "Colors.Silver", Colors.Silver.ToBrush() }, { "Colors.LawnGreen", Colors.LawnGreen.ToBrush() }, { "Colors.Chartreuse", Colors.Chartreuse.ToBrush() }, { "Colors.Navy", Colors.Navy.ToBrush() }, { "Colors.GhostWhite", Colors.GhostWhite.ToBrush() }, { "Colors.FloralWhite", Colors.FloralWhite.ToBrush() }, { "Colors.DarkCyan", Colors.DarkCyan.ToBrush() }, { "Colors.LightPink", Colors.LightPink.ToBrush() }, { "Colors.PeachPuff", Colors.PeachPuff.ToBrush() }, { "Colors.Violet", Colors.Violet.ToBrush() }, { "Colors.Purple", Colors.Purple.ToBrush() }, { "Colors.MediumSpringGreen", Colors.MediumSpringGreen.ToBrush() }, { "Colors.Khaki", Colors.Khaki.ToBrush() }, { "Colors.CornflowerBlue", Colors.CornflowerBlue.ToBrush() }, { "Colors.Azure", Colors.Azure.ToBrush() }, { "Colors.OliveDrab", Colors.OliveDrab.ToBrush() }, { "Colors.MediumVioletRed", Colors.MediumVioletRed.ToBrush() }, { "Colors.PowderBlue", Colors.PowderBlue.ToBrush() }, { "Colors.SeaShell", Colors.SeaShell.ToBrush() }, { "Colors.Aquamarine", Colors.Aquamarine.ToBrush() }, };

        public ColorPalette()
        {
            InitializeComponent();
            //int Count = 0;
            foreach (KeyValuePair<string, Brush> KVP in BrushBook)
            {
                //ColorGrid.NewRow(GridUnitType.Auto);
                //Rectangle Rec = new Rectangle();
                //Rec.Fill = KVP.Value;
                //TextBlock TB = new TextBlock();
                //TB.Text = KVP.Key;
                //ColorGrid.Add(Rec, Count, 0);
                //ColorGrid.Add(TB, Count, 0);

                ListBoxItem LBI = new ListBoxItem();
                LBI.Content = KVP.Key;
                LBI.Background = KVP.Value;

                ColorBox.Items.Add(LBI);

                //Count++;
            }
        }
    }
}