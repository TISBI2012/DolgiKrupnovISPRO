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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Cinema.Pages;
using Cinema.Models;


namespace Cinema.Windows
{
    public partial class MainWindows : Window
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        private void BFilms_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new FilmPage());
        }
    }
}
