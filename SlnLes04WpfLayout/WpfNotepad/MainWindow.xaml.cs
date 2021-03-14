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

namespace WpfNotepad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string chosenFileName;
        private string folderpath;
        private string content;
        public MainWindow()
        {
            InitializeComponent();
            folderpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void mnuAbout_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow win = new AboutWindow();
            win.Show();

        }

        private void btnCut_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetDataObject(txtTekst.SelectedText);
            txtTekst.SelectedText = "";
        }

        private void btnPaste_Click(object sender, RoutedEventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();
            txtTekst.Paste();
            Clipboard.Clear();

        }

        private void btnCopy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetDataObject(txtTekst.SelectedText);
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int aantal;
            aantal = txtTekst.Text.Count(char.IsLetterOrDigit);
            lblAantalWoorden.Content = $"#chars: {aantal}";


        }

        private void mnuNew_Click(object sender, RoutedEventArgs e)
        {
            txtTekst.Text = "";
        }

        private void mnuOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = folderpath;
            dialog.Filter = "Tekstbestanden|*.TXT;*.TEXT";
            string chosenFileName;
            bool? dialogResult = dialog.ShowDialog();
            if (dialogResult != true) return;
            // user picked a file and pressed OK
            chosenFileName = dialog.FileName;
            FileInfo fi = new FileInfo(chosenFileName);
            tbiNaamDoc.Header = fi.Name;
            // bestand schrijven


            string filePath = System.IO.Path.Combine(folderpath, chosenFileName);
            // open stream and start reading
            using (StreamReader reader = File.OpenText(filePath))
            {
                content = reader.ReadToEnd();
                txtTekst.Text = content;


            }

        }

        private void mnuSaveAs_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = folderpath;
            dialog.Filter = "Tekstbestanden|*.TXT;*.TEXT";
            if (dialog.ShowDialog() == true)
            {
                using (StreamWriter writer = File.CreateText(dialog.FileName))
                {

                    content = txtTekst.Text;
                    writer.WriteLine(content);

                }
            }
        }

        private void mnuSave_Click(object sender, RoutedEventArgs e)
        {
            FileInfo fi = new FileInfo(chosenFileName);
            if (fi.Exists == false)
            {
                mnuSaveAs_Click(sender, e);
            }
            else
            {
                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filePath = System.IO.Path.Combine(folderPath, (string)tbiNaamDoc.Content);
                // write all text at once
                File.WriteAllText(filePath, content);
            }


        }

        private void MenuItem_SubmenuOpened(object sender, RoutedEventArgs e)
        {
            if (tbiNaamDoc.Content != null)
            {
                mnuSave.IsEnabled = true;
                mnuSaveAs.IsEnabled = true;
            }
        }

        private void mnuEdit_SubmenuOpened(object sender, RoutedEventArgs e)
        {
            if (Clipboard.ContainsText() == true)
            {
                btnPaste.IsEnabled = true;
            }
            else btnPaste.IsEnabled = false;
            
        }
    }
}
