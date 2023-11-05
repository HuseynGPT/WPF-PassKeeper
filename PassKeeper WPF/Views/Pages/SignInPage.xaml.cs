using PassKeeper_WPF.Models;
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

namespace PassKeeper_WPF.Views.Pages
{

    public partial class SignInPage : Page
    {
        public User loginedUser { get; set; } = new();
        public SignInPage()
        {
            InitializeComponent();
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("\\Views\\Pages\\ForgotPasswordPage.xaml", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                loginedUser = UsersCollection.FindUserFromDatabase(emailInput.Text, PasswordInput.Text);
                if (loginedUser != null)
                {
                    NavigationService.Navigate(new LandingPage(loginedUser));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
