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

namespace WpfPunten
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

        private void EnableBtnToevoegen(object sender, KeyEventArgs e)
        {   
            //toevoegen btn disabelen als de 2 velden niet zijn ingevuld
            if(txt_Naam.Text==""|| txt_punt.Text=="")
                {
                btn_Toevoegen.IsEnabled = false;
            }
            else
            {
                btn_Toevoegen.IsEnabled = true;
            }
        }

        private void btn_Toevoegen_Click(object sender, RoutedEventArgs e)
        {
            
            if (foutmelding()== true) 
            {
                //items toevoegen aan listbox
                ListBoxItem firstItem = new ListBoxItem();
                firstItem.Content = $"{txt_Naam.Text}-{txt_punt.Text}/100";
                lb_lijstje.Items.Add(firstItem);
            }
        }
        private Boolean foutmelding()
        {   //checken of er wel een getalwaarde is ingegeven bij punt
            int punt;
            bool success = Int32.TryParse(txt_punt.Text, out punt);
            if (!success)
            {
                MessageBox.Show("foute ingave");
                return false;
            }
            else return true;
            
      
        }

        private void btn_verwijder_Click(object sender, RoutedEventArgs e)
        { // code om item te verwijderen uit listbox
            lb_lijstje.Items.Remove(lb_lijstje.SelectedItem);

        }

        private void txt_filter_TextChanged(object sender, TextChangedEventArgs e)
        {   // hier komt de code voor de filter

        }
    }
}
