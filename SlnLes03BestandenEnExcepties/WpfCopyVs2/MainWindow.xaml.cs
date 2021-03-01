using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfCopyVs2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        string chosenFileName;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_kies_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.Filter = "Tekstbestanden|*.TXT;*.TEXT";
 
            bool? dialogResult = dialog.ShowDialog();
            if (dialogResult == true)
            {
                // user picked a file and pressed OK
                chosenFileName = dialog.FileName;
                lbl_fileIn.Content = dialog.InitialDirectory + chosenFileName;
            }

            
        }

        private void btn_go_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = folderPath;
            dialog.Filter = "Tekstbestanden|*.TXT;*.TEXT";
            dialog.FileName = "savedfile.txt";
            if (dialog.ShowDialog() == true)
            {
                using (StreamWriter writer = File.CreateText(dialog.FileName))
                {
                    writer.WriteLine(chosenFileName);

                }
            }

        }
    }
}
