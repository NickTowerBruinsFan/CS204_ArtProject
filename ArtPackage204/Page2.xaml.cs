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
        bool iszoomed;
        Point last;
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
                bitmapImage = images[8];
            }
            else if (picture == 1)
            {
                bitmapImage = images[16];
            }
            else if (picture == 2)
            {
                bitmapImage = images[9];
            }
            else if (picture == 3)
            {
                bitmapImage = images[4];
            }
            else if (picture == 4)
            {
                bitmapImage = images[3];
            }
            else if (picture == 5)
            {
                bitmapImage = images[1];
            }
            else if (picture == 6)
            {
                bitmapImage = images[2];
            }
            else if (picture == 7)
            {
                bitmapImage = images[0];
            }
            else if (picture == 8)
            {
                bitmapImage = images[17];
            }
            else if (picture == 9)
            {
                bitmapImage = images[11];
            }
            else if (picture == 10)
            {
                bitmapImage = images[10];
            }
            else if (picture == 11)
            {
                bitmapImage = images[18];
            }
            else if (picture == 12)
            {
                bitmapImage = images[6];
            }
            else if (picture == 13)
            {
                bitmapImage = images[15];
            }
            else if (picture == 14)
            {
                bitmapImage = images[13];
            }
            else if (picture == 15)
            {
                bitmapImage = images[14];
            }
            else if (picture == 16)
            {
                bitmapImage = images[12];
            }
            else if (picture == 18)
            {
                bitmapImage = images[5];
            }
            else if (picture == 19)
            {
                bitmapImage = images[19];
            }
            else if (picture == 20)
            {
                bitmapImage = images[7];
            }



            img.Source = bitmapImage;

            img.SetValue(Grid.RowProperty, row);
            img.SetValue(Grid.ColumnProperty, col);


            maingrid.Children.Add(img);


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
            canvas.DefaultDrawingAttributes.Color = Colors.SandyBrown;
            canvas.DefaultDrawingAttributes.Width = 15;
            canvas.DefaultDrawingAttributes.Height = 15;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_14(object sender, MouseButtonEventArgs e)
        {
            picture = -1;
            canvas.EditingMode = InkCanvasEditingMode.Ink;
            canvas.DefaultDrawingAttributes.Color = Colors.Red;
            canvas.DefaultDrawingAttributes.Width = 15;
            canvas.DefaultDrawingAttributes.Height = 15;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_15(object sender, MouseButtonEventArgs e)
        {
            picture = 20;
            canvas.EditingMode = InkCanvasEditingMode.None;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_16(object sender, MouseButtonEventArgs e)
        {
            picture = 13;
            canvas.EditingMode = InkCanvasEditingMode.None;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_17(object sender, MouseButtonEventArgs e)
        {
            picture = 14;
            canvas.EditingMode = InkCanvasEditingMode.None;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_18(object sender, MouseButtonEventArgs e)
        {
            picture = 15;
            canvas.EditingMode = InkCanvasEditingMode.None;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_19(object sender, MouseButtonEventArgs e)
        {
            picture = 16;
            canvas.EditingMode = InkCanvasEditingMode.None;
        }

        private void Button_Click(object sender, RoutedEventArgs e) //Save button
        {

        }

        BitmapImage CreateBitmap(string uri)
        {
            return new BitmapImage(new Uri(uri));
        }

        BitmapImage[] GetImages()
        {
            var imageUris = new[]
            {
 "pack://application:,,,/Images/crosspath.jpg",
 "pack://application:,,,/Images/curvepath.jpg",
 "pack://application:,,,/Images/curvepathbottemleft.jpg",
 "pack://application:,,,/Images/curvepathupperleft.jpg",
 "pack://application:,,,/Images/curvepathupperright.jpg",
 "pack://application:,,,/Images/door.jpg",
 "pack://application:,,,/Images/door1.jpg",
 "pack://application:,,,/Images/earser.jpg",
 "pack://application:,,,/Images/grass.jpg",
 "pack://application:,,,/Images/horixontalpath.jpg",
 "pack://application:,,,/Images/stairs.jpg",
 "pack://application:,,,/Images/stone floor.jpg",
 "pack://application:,,,/Images/tshapepath.jpg",
 "pack://application:,,,/Images/tshapepath2.jpg",
 "pack://application:,,,/Images/tshapepath3.jpg",
 "pack://application:,,,/Images/tshapepath4.jpg",
 "pack://application:,,,/Images/uppath.jpg",
 "pack://application:,,,/Images/wall.jpg",
 "pack://application:,,,/Images/window.jpg",
 "pack://application:,,,/Images/window1.jpg"
 };
            return imageUris.Select(CreateBitmap).ToArray();
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_20(object sender, MouseButtonEventArgs e)
        {
            picture = 18;
            canvas.EditingMode = InkCanvasEditingMode.None;
        }

        private void ListBoxItem_PreviewMouseLeftButtonDown_21(object sender, MouseButtonEventArgs e)
        {
            picture = 19;
            canvas.EditingMode = InkCanvasEditingMode.None;
        }
        private void ListBoxItem_PreviewMouseLeftButtonDown_22(object sender, MouseButtonEventArgs e)
        {
            picture = -1;
            canvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
        }
        private void ListBoxItem_PreviewMouseLeftButtonDown_23(object sender, MouseButtonEventArgs e)
        {
            picture = -1;
            canvas.EditingMode = InkCanvasEditingMode.Ink;
            canvas.DefaultDrawingAttributes.Color = Colors.Blue;
            canvas.DefaultDrawingAttributes.Width = 15;
            canvas.DefaultDrawingAttributes.Height = 15;
        }

        
        private void zoomin_Click(object sender, RoutedEventArgs e)
        {
            var scaler = maingrid.LayoutTransform as ScaleTransform;

            if (scaler == null)
            {

                maingrid.LayoutTransform = new ScaleTransform(1.5, 1.5);
            }
            else
            {
                double curZoomFactor = scaler.ScaleX;



                if (scaler.HasAnimatedProperties)
                {


                    scaler.BeginAnimation(ScaleTransform.ScaleXProperty, null);
                    scaler.BeginAnimation(ScaleTransform.ScaleYProperty, null);
                }

                if (curZoomFactor == 1.0)
                {
                    scaler.ScaleX = 1.5;
                    scaler.ScaleY = 1.5;
                    iszoomed = true;
                }
                else
                {
                    scaler.ScaleX = 1.0;
                    scaler.ScaleY = 1.0;
                    iszoomed = false;
                }
            }
        }

        int tempy = 0;
        int tempx = 0;
        private void bigcanvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.W)
            {
                if (iszoomed == true)
                {
                    trans.Y += 10;

                }

            }
            if (e.Key == Key.A)
            {
                if (iszoomed == true)
                {
                    trans.X += 10;

                }

            }
            if (e.Key == Key.S)
            {
                if (iszoomed == true)
                {
                    trans.Y -= 10;

                }

            }
            if (e.Key == Key.D)
            {
                if (iszoomed == true)
                {
                    trans.X -= 10;

                }
            }
            if (e.Key == Key.R)
            {
                if (iszoomed == true)
                {
                    trans.X = 0;
                    trans.Y = 0;

                }
            }
        }
        private void return_Click(object sender, RoutedEventArgs e)
        {

            var w = Application.Current.Windows[0];
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            w.Close();


        }
    }
}
