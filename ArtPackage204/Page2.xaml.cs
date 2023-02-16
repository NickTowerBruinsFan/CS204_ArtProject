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

namespace ArtPackage204
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        int picture = 0;
        public Page2()
        {
            InitializeComponent();
        }
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

            BitmapImage[] images = GetImages();
            Image img = new Image { Width = 40, Height = 40 };
            var bitmapImage = new BitmapImage();
            if (picture == 0)
            {
                bitmapImage = images[6];
            }
            else if (picture == 0)
            {
                bitmapImage = images[6];
            }
            else if (picture == 1)
            {
                bitmapImage = images[14];
            }
            else if (picture == 2)
            {
                bitmapImage = images[7];
            }
            else if (picture == 3)
            {
                bitmapImage = images[1];
            }
            else if (picture == 4)
            {
                bitmapImage = images[2];
            }
            else if (picture == 5)
            {
                bitmapImage = images[4];
            }
            else if (picture == 6)
            {
                bitmapImage = images[3];
            }
            else if (picture == 7)
            {
                bitmapImage = images[0];
            }
            else if (picture == 8)
            {
                bitmapImage = images[15];
            }
            else if (picture == 9)
            {
                bitmapImage = images[5];
            }
            else if (picture == 10)
            {
                bitmapImage = images[8];
            }
            else if (picture == 11)
            {
                bitmapImage = images[9];
            }
            else if (picture == 12)
            {
                bitmapImage = images[16];
            }
            else if (picture == 13)
            {
                bitmapImage = images[10];
            }
            else if (picture == 14)
            {
                bitmapImage = images[11];
            }
            else if (picture == 15)
            {
                bitmapImage = images[12];
            }
            else if (picture == 16)
            {
                bitmapImage = images[13];
            }



            img.Source = bitmapImage;

            img.SetValue(Grid.RowProperty, row);
            img.SetValue(Grid.ColumnProperty, col);


            maingrid.Children.Add(img);


        }

        private void ListBoxItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            picture = 0;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            picture = 1;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_7(object sender, MouseButtonEventArgs e)
        {
            picture = 2;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            picture = 3;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            picture = 4;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            picture = 5;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_5(object sender, MouseButtonEventArgs e)
        {
            picture = 6;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_6(object sender, MouseButtonEventArgs e)
        {
            picture = 7;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_8(object sender, MouseButtonEventArgs e)
        {
            picture = 8;
        }
        private void ListBoxItem_PreviewMouseLeftButtonDown_9(object sender, MouseButtonEventArgs e)
        {
            picture = 9;
        }
        private void ListBoxItem_PreviewMouseLeftButtonDown_10(object sender, MouseButtonEventArgs e)
        {
            picture = 10;
        }
        private void ListBoxItem_PreviewMouseLeftButtonDown_11(object sender, MouseButtonEventArgs e)
        {
            picture = 11;
        }
        private void ListBoxItem_PreviewMouseLeftButtonDown_12(object sender, MouseButtonEventArgs e)
        {
            picture = 12;
        }
        private void ListBoxItem_PreviewMouseLeftButtonDown_13(object sender, MouseButtonEventArgs e)
        {
            picture = 13;
        }
        private void ListBoxItem_PreviewMouseLeftButtonDown_14(object sender, MouseButtonEventArgs e)
        {
            picture = 14;
        }
        private void ListBoxItem_PreviewMouseLeftButtonDown_15(object sender, MouseButtonEventArgs e)
        {
            picture = 15;
        }
        private void ListBoxItem_PreviewMouseLeftButtonDown_16(object sender, MouseButtonEventArgs e)
        {
            picture = 16;
        }

        BitmapImage CreateBitmap(string uri)
        {
            return new BitmapImage(new Uri(uri));
        }

        BitmapImage[] GetImages()
        {
            string currDir = Directory.GetCurrentDirectory();
            string[] imageUris;

            //Get directory path of myData 
            string temp = currDir + "\\Images\\";
            imageUris = Directory.GetFiles(temp, "*.jpg");
            return imageUris.Select(CreateBitmap).ToArray();

        }
    }
}
