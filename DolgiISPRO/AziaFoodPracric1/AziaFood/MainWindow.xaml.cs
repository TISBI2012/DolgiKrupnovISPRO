using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;
using AziaFood.Pages;
using AziaFood.Models;
using System.Linq;

namespace AziaFood
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }

        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            var user = App.DB.User.FirstOrDefault(x => x.Login == TBLogged.Text);
            if (user == null || user.Password != TBPasswordLogin.Text)
            {
                MessageBox.Show("Логин или пароль неверны");
                return;
            }
            App.LoggedUser = user;
            var newForm = new MainPageWidows();
            newForm.Show();
            this.Close();
        }

        private void BExit_Click(object sender, RoutedEventArgs e)
        {
            var dialog = MessageBox.Show("Вы уверены?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (dialog == MessageBoxResult.Yes)
            {
                App.Current.Shutdown();
            }
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            string errormessage = "";

            var user = new User();
            user.Name = TBName.Text;
            user.Family = TBFamily.Text;
            user.Email = TBEmail.Text;
            user.Phone = TBPhone.Text;
            user.Login = TBLogin.Text;
            user.Password = TBPassword.Text;

            if (string.IsNullOrWhiteSpace(user.Name))
            {
                errormessage += "Введите имя";
            }
            if (string.IsNullOrWhiteSpace(user.Login))
            {
                errormessage += "Введите логин";
            }
            if (string.IsNullOrWhiteSpace(user.Password))
            {
                errormessage += "Введите пароль";
            }
            if (string.IsNullOrWhiteSpace(user.Family))
            {
                errormessage += "Введите фамилию";
            }
            if (string.IsNullOrWhiteSpace(user.Email))
            {
                errormessage += "Введите почту";
            }
            if (string.IsNullOrWhiteSpace(user.Phone))
            {
                errormessage += "Введите телефон";
            }
            App.DB.User.Add(user);
            App.DB.SaveChanges();
        }
    }
}
