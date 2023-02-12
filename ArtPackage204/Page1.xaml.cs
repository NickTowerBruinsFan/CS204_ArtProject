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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();

        }

        int picture = 0;


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


            Image img = new Image { Width = 60, Height = 60 };
            var bitmapImage = new BitmapImage();
            if (picture == 0)
            {
               bitmapImage = new BitmapImage(new Uri(@"C:\Users\eerin\OneDrive\Desktop\204 project pictures\grass.jpg"));

            }
            else if (picture == 1)
            {
               bitmapImage = new BitmapImage(new Uri(@"C:\Users\eerin\OneDrive\Desktop\204 project pictures\uppath.jpg"));
            }


            if (picture != -1)
            {
                img.Source = bitmapImage;

                img.SetValue(Grid.RowProperty, row);
                img.SetValue(Grid.ColumnProperty, col);


                maingrid.Children.Add(img);
            }

        }

        private void ListBoxItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            picture = 0;
            canvas.EditingMode = InkCanvasEditingMode.None;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            picture = 1;
            canvas.EditingMode = InkCanvasEditingMode.None;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_7(object sender, MouseButtonEventArgs e)
        {
            picture = 2;
            canvas.EditingMode = InkCanvasEditingMode.None;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            picture = 3;
            canvas.EditingMode = InkCanvasEditingMode.None;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            picture = 4;
            canvas.EditingMode = InkCanvasEditingMode.None;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            picture = 5;
            canvas.EditingMode = InkCanvasEditingMode.None;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_5(object sender, MouseButtonEventArgs e)
        {
            picture = 6;
            canvas.EditingMode = InkCanvasEditingMode.None;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_6(object sender, MouseButtonEventArgs e)
        {
            picture = 7;
            canvas.EditingMode = InkCanvasEditingMode.None;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_8(object sender, MouseButtonEventArgs e)
        {
            picture = 8;
            canvas.EditingMode = InkCanvasEditingMode.None;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_9(object sender, MouseButtonEventArgs e)
        {
            picture = 9;
            canvas.EditingMode = InkCanvasEditingMode.None;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_10(object sender, MouseButtonEventArgs e)
        {
            picture = 10;
            canvas.EditingMode = InkCanvasEditingMode.None;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_11(object sender, MouseButtonEventArgs e)
        {
            picture = 11;
            canvas.EditingMode = InkCanvasEditingMode.None;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_12(object sender, MouseButtonEventArgs e)
        {
            picture = 12;
            canvas.EditingMode = InkCanvasEditingMode.None;
            
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_13(object sender, MouseButtonEventArgs e)
        {
            picture = -1;
            canvas.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_14(object sender, MouseButtonEventArgs e)
        {
            picture = -1;
            canvas.EditingMode = InkCanvasEditingMode.Ink;
        }
    }
}
