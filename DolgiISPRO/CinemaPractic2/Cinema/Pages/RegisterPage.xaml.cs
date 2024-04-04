using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Validation;
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
    public partial class RegisterPage : Page
    {
        User contextUser;
        public RegisterPage(User user)
        {
            InitializeComponent();
            contextUser = user;
            DataContext = contextUser;
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            if (contextUser.id == 0)
                App.DB.User.Add(contextUser);
           
            {

                App.DB.SaveChanges();

            }
            NavigationService.Navigate(new LoginPage());
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
