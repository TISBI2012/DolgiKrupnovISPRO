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
using Cinema.Models;

namespace Cinema.Pages
{
    public partial class FilmPage : Page
    {

        public FilmPage()
        {
            InitializeComponent();
            DGFilms.ItemsSource = App.DB.Film.ToList();
        }

        private void BAddFilms_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddFilmsPage(new Film()));
        }

        private void BEditFilms_Click(object sender, RoutedEventArgs e)
        {
            var selectedFilm = DGFilms.SelectedItem as Film;
            if (selectedFilm == null)
            {
                MessageBox.Show("Выберите фильм!");
                return;
            }
            else
                NavigationService.Navigate(new AddFilmsPage(selectedFilm));
        }
    }
}
