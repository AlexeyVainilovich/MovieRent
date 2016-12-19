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

namespace MovieRentWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new ApplicationViewModel(); 
            InitializeComponent();            
        }

        public MainWindow(object data)
        {
            DataContext = data;
            InitializeComponent();
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            SettingsWindow settingWindow = new SettingsWindow(DataContext);
            settingWindow.Show();
        }

        private void ActorsButton_Click(object sender, RoutedEventArgs e)
        {
            
            ActorsListWindow actorsListWindow = new ActorsListWindow(DataContext);
            actorsListWindow.Show();
            Close();
        }

        private void MoviesButton_Click(object sender, RoutedEventArgs e)
        {
            MoviesListWindow moviesListWindow = new MoviesListWindow(DataContext);
            moviesListWindow.Show();
            Close();
        }

        private void ProducersButton_Click(object sender, RoutedEventArgs e)
        {
            ProducersListWindow producersListWindow = new ProducersListWindow(DataContext);
            producersListWindow.Show();
            Close();
        }

        private void FindButton_Click(object sender, RoutedEventArgs e)
        {
            //Hide();
            FindWindow findWindow = new FindWindow();
            findWindow.Show();
        }
    }
}
