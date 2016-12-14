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
        public MoviesListWindow()
        {
            InitializeComponent();

            DataContext = new ApplicationViewModel();
        }

        private void MainMenuButton_Click(object sender, RoutedEventArgs e)
        {

            Hide();
            var mainWindow = (MainWindow)(Application.Current.MainWindow);
            mainWindow.Show();

        }
        
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            
            MovieAddWindow movieAddWindow = new MovieAddWindow();
            movieAddWindow.Owner = this;
            movieAddWindow.Show();
            

        }
    }
}
