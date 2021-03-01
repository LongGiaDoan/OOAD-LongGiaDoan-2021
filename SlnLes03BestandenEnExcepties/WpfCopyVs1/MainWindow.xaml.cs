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

namespace WpfCopyVs1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string folderPath;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_go_Click(object sender, RoutedEventArgs e)
        {
            // prepare
            string content;
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePathIn = System.IO.Path.Combine(folderPath, txt_fileIn.Text);
            // open stream and start reading
            using (StreamReader reader = File.OpenText(filePathIn))
            {
                content = reader.ReadToEnd();
            } // stream closes automatically

            // prepare
             folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePathOut = System.IO.Path.Combine(folderPath, txt_fileOut.Text);
            // open stream and start writing
            using (StreamWriter writer = File.CreateText(filePathOut))
            {
                writer.WriteLine(content);
           
            } // stream closes automatically

        }

    }
}
