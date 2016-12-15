using MovieRentWPF;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for MovieAddWindow.xaml
    /// </summary>
    public partial class MovieAddWindow : Window
    {
        public MovieAddWindow(object data)
        {
            InitializeComponent();

            DataContext = data;
   
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            MoviesListWindow moviesListWindow = new MoviesListWindow(DataContext);
            moviesListWindow.Show();
            Close();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {

        }
    }
}
