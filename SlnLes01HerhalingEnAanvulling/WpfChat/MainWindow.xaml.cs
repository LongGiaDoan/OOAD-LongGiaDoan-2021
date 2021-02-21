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

namespace WpfChat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string text;
        string[] scheldwoorden = new string[] { "fucker", "fuck you", "scheldwoorden" };
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnVerzenden_Click(object sender, RoutedEventArgs e)
        {
            text = txtNaam.Text + " says:" + Environment.NewLine + txtBericht.Text + Environment.NewLine;
            foreach (string scheldwoord in scheldwoorden)
            {
                text = text.Replace(scheldwoord, "****");
            }
            txtChat.Text = txtChat.Text+text;

        }
    }
}
