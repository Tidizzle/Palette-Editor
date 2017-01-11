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
using AnchorMapLib;

namespace PaletteEditor
{
    /// <summary>
    /// Interaction logic for AddColor.xaml
    /// </summary>
    public partial class AddColor : Window
    {
        private ListView Grid;
        private MainWindow Main;

        public AddColor(ListView ColorGrid, MainWindow Main)
        {
            InitializeComponent();
            Grid = ColorGrid;
            this.Main = Main;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            ColorTile color = new ColorTile();
            color.Name = NameBox.Text;

            if (!int.TryParse(IDBox.Text, out color.ID))
            {
                IDBox.Clear();
                MessageBox.Show("Incorrect ID value input", "Add color", MessageBoxButton.OK);
            }
            else
            {
                if (int.TryParse(RBox.Text, out color.r) && int.TryParse(GBox.Text, out color.g) && int.TryParse(BBox.Text, out color.b) && int.TryParse(ABox.Text, out color.a))
                {
                    if (color.r < 0 || color.r > 255 || color.g < 0 || color.g > 255 || color.b < 0 || color.b > 255 || color.a < 0 || color.a > 255)
                    {
                        MessageBox.Show("RGBA values must be greater than 0 and less than 255", "Add Color", MessageBoxButton.OK);
                    }
                    else
                    {
                        Main.Palette.ColorList.Add(color);
                        var NameList = new List<string>();
                        foreach (var tile in Main.Palette.ColorList)
                        {
                            NameList.Add(tile.Name.ToString());
                        }

                        Grid.ItemsSource = Main.Palette.ColorList;
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("incorrect RGB value input");
                }
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}