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
using System.IO;

namespace MovieRentWPF
{
    /// <summary>
    /// Interaction logic for MoviesListWindow.xaml
    /// </summary>
    public partial class MoviesListWindow : Window
    {
        public MoviesListWindow(object data)
        {
            InitializeComponent();
            DataContext = data;
        }

        private void MainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(DataContext);
            mainWindow.Show();
            Close();
        }
        
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            MovieAddWindow movieAddWindow = new MovieAddWindow(DataContext);
            movieAddWindow.Show();
            this.Close();
        }
    }
}
