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
using AziaFood.Models;
using AziaFood.Pages;
using static System.ActivationContext;

namespace AziaFood.Pages
{
    public partial class AddDishesPage : Page
    {
        Dishes contextDishes;
        public AddDishesPage()
        {
            InitializeComponent();
            CBTypeDishes.ItemsSource = App.DB.TypeDishes.ToList();
            contextDishes = new Dishes();
            DataContext = contextDishes;
        }

        private void BAddDishes_Click(object sender, RoutedEventArgs e)
        {
            if (contextDishes.id == 0)
                App.DB.Dishes.Add(contextDishes);
            {

                App.DB.SaveChanges();

            }
        }
    }
}
