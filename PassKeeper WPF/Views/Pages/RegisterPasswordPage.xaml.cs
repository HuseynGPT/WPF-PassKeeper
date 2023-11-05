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
    /// <summary>
    /// Interaction logic for RegisterPasswordPage.xaml
    /// </summary>
    public partial class RegisterPasswordPage : Page
    {
        public User newU { get; set; }
        public RegisterPasswordPage( User user)
        {
            InitializeComponent();

            newU = user;
            DataContext = this;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(newU.FirstName);
            if (ConfirmPassInput.Text == "123")
            {
                newU.ImagePath = "\\Resources\\Images\\DEFAULT USER PNG.png";
                newU.Accounts = new();
                UsersCollection.Users!.Add(newU);
                UsersCollection.UptadeDatabase();
                NavigationService.Navigate(new DonePage());

            }
            else
            {
                MessageBox.Show("Confirm password is worng", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
