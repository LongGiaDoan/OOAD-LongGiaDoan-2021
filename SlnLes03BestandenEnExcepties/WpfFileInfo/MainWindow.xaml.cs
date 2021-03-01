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

namespace WpfFileInfo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string chosenFileName;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_kiesBestand_Click(object sender, RoutedEventArgs e)
        {// open file dialog
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.Filter = "Tekstbestanden|*.TXT;*.TEXT";
            bool? dialogResult = dialog.ShowDialog();
            if (dialogResult == true)
            {
                // user picked a file and pressed OK
                chosenFileName = dialog.FileName;
            }
            else
            {
                // user cancelled or escaped dialog window
            }

            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string startfolder = System.IO.Path.Combine(folderPath, "myfolder");
            FileInfo fi = new FileInfo(chosenFileName);
            string info = "";
            info += $"bestandsnaam: {fi.Name}{Environment.NewLine}";
            info += $"extensie: {fi.Extension}{Environment.NewLine}";
            info += $"gemaakt op: {fi.CreationTime.ToString()}{Environment.NewLine}";
            info += $"mapnaam: {fi.Directory.Name}{Environment.NewLine}";
            // prepare
            string content;
            string folderPathLezen = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = System.IO.Path.Combine(folderPath, chosenFileName);
            // open stream and start reading
            using (StreamReader reader = File.OpenText(filePath))
            {
                content = reader.ReadToEnd();
            } // stream closes automatically
            info += $"aantal woorden: {content.Split(new char[] { '?', '!', ',', '.', ';' }).Length}";
            lbl_info.Content = info;

        }
    }
}
