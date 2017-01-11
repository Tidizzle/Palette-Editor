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
using AnchorMapLib;
using System.IO;

namespace PaletteEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Palette Palette;
        public bool PaletteOpen;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddColor_Click(object sender, RoutedEventArgs e)
        {
            if (PaletteOpen)
            {
                AddColor AddColor_win = new AddColor(List, this);
                AddColor_win.Show();
            }
            else
            {
                MessageBox.Show("You must be editing a palette to add colors", "Add Color Error", MessageBoxButton.OK);
            }
        }

        private void RemoveColor_Click(object sender, RoutedEventArgs e)
        {
            if (PaletteOpen)
            {
                if (List.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select a color", "Remove Color Error", MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBox.Show("You must be editing a palette to remove colors", "Remove Color Error", MessageBoxButton.OK);
            }
        }

        private void OpenPalette_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openDialog = new Microsoft.Win32.OpenFileDialog();
            openDialog.DefaultExt = ".palette";
            openDialog.Filter = "Palette File | *.palette";
            openDialog.Title = "Open Palette File";

            var result = openDialog.ShowDialog();

            if (result == true)
            {
                if (!openDialog.FileName.Contains(".palette"))
                {
                    MessageBox.Show("Incorrect File Type", "File Open Error", MessageBoxButton.OK);
                }
                else
                {
                    PaletteOpen = true;
                    Palette = new Palette();
                    Palette.ColorList = new List<ColorTile>();

                    //ADD DESERIALIZATION AND SETTING PALETTE VAR TO WHAT IS PASSED BACK EX Palette = Maplib.Deserialize();

                    Palette = new Palette() { paletteName = "TEST PALETTE", colors = 5 };

                    NameBox.Text = Palette.paletteName;
                    CountBox.Text = Palette.colors.ToString();
                }
            }
        }

        private void SavePalette_Click(object sender, RoutedEventArgs e)
        {
            if (!PaletteOpen)
            {
                MessageBox.Show("You must be editing a palette to save", "Palette Saving Error", MessageBoxButton.OK);
            }
            else
            {
                //ADD SERIALIZATION AND FILE WRITING
            }
        }

        private void SaveAsPalette_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog SaveDialog = new Microsoft.Win32.SaveFileDialog();
            SaveDialog.DefaultExt = ".palette";
            SaveDialog.Title = "Save Palette File";

            if (PaletteOpen)
            {
                SaveDialog.FileName = Palette.fileName;
            }
            else
            {
                SaveDialog.FileName = "NewPalette";
            }
            SaveDialog.Filter = "Palette File |*.palette";

            var result = SaveDialog.ShowDialog();

            if (result == true)
            {
                Palette.fileName = SaveDialog.FileName;
                //ADD PALETTE SERIALIZATION

                File.WriteAllText(Palette.fileName, "!!!!!!!!!!!!!!!!!!!!fix this");
            }
        }

        private void Creator_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.github.com/tidizzle");
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            var AboutWin = new AboutWin();
            AboutWin.Show();
        }

        private void NewPalette_Click(object sender, RoutedEventArgs e)
        {
            if (PaletteOpen)
            {
                var result = MessageBox.Show("Do you want to save your current Palette?", "File Loss Warning", MessageBoxButton.YesNoCancel);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        SaveAsPalette_Click(this, new RoutedEventArgs());
                        break;

                    case MessageBoxResult.Cancel:
                        break;
                }

                if (result == MessageBoxResult.Yes || result == MessageBoxResult.No)
                {
                    NewPalette NewWin = new NewPalette(NameBox, CountBox, this);
                    NewWin.Show();
                }
            }
            else
            {
                NewPalette Win = new NewPalette(NameBox, CountBox, this);
                Win.Show();
            }

            PaletteOpen = true;
        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}