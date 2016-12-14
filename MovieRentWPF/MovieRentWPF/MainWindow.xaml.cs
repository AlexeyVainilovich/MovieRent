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
            InitializeComponent();

                       
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            SettingsWindow settingWindow = new SettingsWindow();
            settingWindow.Show();
        }

        private void ActorsButton_Click(object sender, RoutedEventArgs e)
        {
            //Hide();
            
            ActorsListWindow actorsListWindow = new ActorsListWindow();
            actorsListWindow.Show();
        }

        private void MoviesButton_Click(object sender, RoutedEventArgs e)
        {
            //Hide();
            MoviesListWindow moviesListWindow = new MoviesListWindow();
            moviesListWindow.Owner = this;
            moviesListWindow.Show();
        }

        private void ProducersButton_Click(object sender, RoutedEventArgs e)
        {
            //Hide();
            ProducersListWindow producersListWindow = new ProducersListWindow();
            producersListWindow.Show();
        }

        private void FindButton_Click(object sender, RoutedEventArgs e)
        {
            //Hide();
            FindWindow findWindow = new FindWindow();
            findWindow.Show();
        }
    }
}
