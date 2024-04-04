using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
using Cinema.Pages;

namespace Cinema.Pages
{
    public partial class AddFilmsPage : Page
    {
        Film contextFilm;
        public AddFilmsPage(Film film)
        {
            InitializeComponent();
            CBGenre.ItemsSource = App.DB.Genre.ToList();
            contextFilm = film;
            DataContext = contextFilm;
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            if (contextFilm.id == 0)
                App.DB.Film.Add(contextFilm);
            {

                App.DB.SaveChanges();

            }
            NavigationService.Navigate(new FilmPage());
        }
    }
}
