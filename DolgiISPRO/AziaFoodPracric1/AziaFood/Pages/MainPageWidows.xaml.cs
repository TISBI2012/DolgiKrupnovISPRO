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
using System.Windows.Navigation;

namespace AziaFood.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPageWidows.xaml
    /// </summary>
    public partial class MainPageWidows : Window
    {
        public MainPageWidows()
        {
            InitializeComponent();
        }

        private void BMenu_Click(object sender, RoutedEventArgs e)
        {
            FrameHost.Navigate(new MenuPage());
        }

        private void BPofile_Click(object sender, RoutedEventArgs e)
        {
            FrameHost.Navigate(new ProfilePage());
        }

        private void BExit_Click(object sender, RoutedEventArgs e)
        {
            var dialog = MessageBox.Show("Вы уверены?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (dialog == MessageBoxResult.Yes)
            {
                App.Current.Shutdown();
            }
        }
    }
}
