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

namespace ArtPackage204
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

        int picture = 1;
        private void maingrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {            
            
                var point = Mouse.GetPosition(maingrid);

                int row = 0;
                int col = 0;
                double accumulatedHeight = 0.0;
                double accumulatedWidth = 0.0;

                // calc row mouse was over
                foreach (var rowDefinition in maingrid.RowDefinitions)
                {
                    accumulatedHeight += rowDefinition.ActualHeight;
                    if (accumulatedHeight >= point.Y)
                        break;
                    row++;
                }

                // calc col mouse was over
                foreach (var columnDefinition in maingrid.ColumnDefinitions)
                {
                    accumulatedWidth += columnDefinition.ActualWidth;
                    if (accumulatedWidth >= point.X)
                        break;
                    col++;
                }
            

            var img = new Image { Width = 60, Height = 60 };
            var bitmapImage = new BitmapImage();
            if (picture == 0)
            {
                bitmapImage = new BitmapImage(new Uri(@"C:\Users\eerin\OneDrive\Pictures\grass.jpg"));
            } 
            else if (picture == 1)
            {
                bitmapImage = new BitmapImage(new Uri(@"C:\Users\eerin\OneDrive\Pictures\uppath.jpg"));
            }
            img.Source = bitmapImage;

            img.SetValue(Grid.RowProperty, row);
            img.SetValue(Grid.ColumnProperty, col);

            maingrid.Children.Add(img);
        }

        private void Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Grass selected.");
            picture = 0;
        }

        private void Button_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Road selected.");
            picture = 1;
        }
    }
}
