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
using Cinema.Windows;
using Cinema.Pages;
using Cinema.Models;

namespace Cinema
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoginFrame.Navigate(new LoginPage());
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new MainWindows();
            newForm.Show();
            this.Close();
        }

        private void BRegister_Click(object sender, RoutedEventArgs e)
        {
            LoginFrame.Navigate(new RegisterPage(new User()));
        }
    }
}
