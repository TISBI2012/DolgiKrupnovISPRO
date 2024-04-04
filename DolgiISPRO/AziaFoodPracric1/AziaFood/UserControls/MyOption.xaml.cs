using System.Windows;
using System.Windows.Controls;
namespace AziaFood.UserControls
{
    public partial class MyOption : UserControl
    {
        public MyOption()
        {
            InitializeComponent();
        }



        public string Text
        {
            get { return (string)GetValue(TextPropery); }
            set { SetValue(TextPropery, value); }
        }





        public static readonly DependencyProperty TextPropery = DependencyProperty.Register
            ("Text", typeof(string), typeof(MyOption));

        public FontAwesome.WPF.FontAwesomeIcon Icon
        {
            get { return (FontAwesome.WPF.FontAwesomeIcon)GetValue(IconPropery); }
            set { SetValue(IconPropery, value); }
        }





        public static readonly DependencyProperty IconPropery = DependencyProperty.Register
            ("Icon", typeof(FontAwesome.WPF.FontAwesomeIcon), typeof(MyOption));
    }
}
