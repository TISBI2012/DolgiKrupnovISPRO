using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Cinema.Models;
using Cinema.Pages;
using Cinema.Windows;
using System.Windows.Input;
using System.Linq;

namespace Cinema.Pages
{
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BRegister_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegisterPage(new User()));
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            var user = App.DB.User.FirstOrDefault(x => x.Login == TBLogin.Text);
            if (user == null || user.Password != TBPasword.Text)
            {
                MessageBox.Show("Логин или пароль неверны");
                return;
            }
            App.LoggedUser = user;
            var newform = new MainWindows();
            newform.Show();
        }
    }
}
