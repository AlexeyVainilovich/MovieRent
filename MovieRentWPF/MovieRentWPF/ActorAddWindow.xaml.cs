﻿using System;
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
    /// Interaction logic for ActorAddWindow.xaml
    /// </summary>
    public partial class ActorAddWindow : Window
    {
        public ActorAddWindow(object data)
        {
            InitializeComponent();
            DataContext = data;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            ActorsListWindow actorListWindow = new ActorsListWindow(DataContext);
            actorListWindow.Show();
            Close();
            
        }
    }
}
