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
  
    public partial class SignInANDRegisterPage : Page
    {
        public SignInANDRegisterPage()
        {
            InitializeComponent();

        }

        private void SignInBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Views\\Pages\\SignInPage.xaml", UriKind.Relative));
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("\\Views\\Pages\\RegsiterPage.xaml", UriKind.Relative));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UsersCollection.LoadDatabase();
        }
    }
}
