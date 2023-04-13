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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page1 nav = new Page1();
            this.Content = nav;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Page2 nav = new Page2();
            this.Content = nav;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Page3 nav = new Page3();
            this.Content = nav;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Page loadedPage = new Page();
            string xamlfile = File.ReadAllText("testfile.xaml");
            FrameworkElement loadedWorkspace = (FrameworkElement)XamlReader.Parse(xamlfile);

            Button saveToFile = (Button)loadedWorkspace.FindName("SaveToFile");

            saveToFile.Click += (s, ev) =>
            {
                MessageBox.Show("Test working.");
            };

            loadedPage.Content = loadedWorkspace;

            this.Content = loadedWorkspace;
            
        }

        private void button_Click_4(object sender, RoutedEventArgs e)
        {        
            MySqlConnection sqlConnection;
            string connectionString = "server=localhost;database=204schema;uid=root;pwd=rootpass;";
            sqlConnection = new MySqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                MessageBox.Show("Connected to database.");
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect to database.");
            }
        }
    }
}
