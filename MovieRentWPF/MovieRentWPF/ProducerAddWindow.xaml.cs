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

namespace MovieRentWPF
{
    /// <summary>
    /// Interaction logic for ProducerAddWindow.xaml
    /// </summary>
    public partial class ProducerAddWindow : Window
    {
        public ProducerAddWindow(object data)
        {
            InitializeComponent();
            DataContext = data;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ProducersListWindow producerListWindow = new ProducersListWindow(DataContext);
            producerListWindow.Show();
            Close();
        }
    }
}
