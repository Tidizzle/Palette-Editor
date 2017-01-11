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
using System.Windows.Shapes;

namespace PaletteEditor
{
    /// <summary>
    /// Interaction logic for NewPalette.xaml
    /// </summary>
    public partial class NewPalette : Window
    {
        private TextBox RefNameBox;
        private TextBox RefCountBox;
        private MainWindow Main;

        public NewPalette(TextBox name, TextBox count, MainWindow win)
        {
            InitializeComponent();
            RefNameBox = name;
            RefCountBox = count;
            Main = win;
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameBox.Text))
            {
                var NewPal = new AnchorMapLib.Palette() { paletteName = NameBox.Text };
                NewPal.ColorList = new List<AnchorMapLib.ColorTile>();
                Main.Palette = NewPal;
                RefNameBox.Text = NewPal.paletteName;
                RefCountBox.Text = NewPal.ColorList.Count.ToString();
                Close();
            }
            else
            {
                MessageBox.Show("You must enter a valid name", "New Palette Error", MessageBoxButton.OK);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}