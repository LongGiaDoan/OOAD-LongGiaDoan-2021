using System;
using System.Collections.Generic;
using System.Drawing;
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
using Color = System.Drawing.Color;

namespace WpfAlcohol
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sld_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int totaalAantalGlazen =Convert.ToInt32( sldBier.Value + sldCocktail.Value + sldWijn.Value);

            int R = Convert.ToInt32(17 * totaalAantalGlazen);
            int G = Convert.ToInt32(255 - (17 * totaalAantalGlazen));
            txtBierGlazen.Text = Convert.ToInt32(sldBier.Value) + " glazen"; ;
            txtWijnGlazen.Text = Convert.ToInt32(sldWijn.Value) + " glazen";
            txtCocktailGlazen.Text = Convert.ToInt32(sldCocktail.Value) + " glazen";
            rct1.Width = Math.Round((sldBier.Value + sldCocktail.Value + sldWijn.Value) *15);
            SolidBrush rechthoek= new SolidBrush(Color.FromArgb(red: R, green: G, blue: 0));
            rct1.Fill = new SolidBrush(Color.FromArgb(120, 255, 0, 0));
                //new SolidBrush(Color.FromArgb(red: R, green: G, blue: 0));

        }


    }
}
