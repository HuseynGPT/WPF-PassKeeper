using PassKeeper_WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for LandingPage.xaml
    /// </summary>
    public partial class LandingPage : Page
    {

        public User loginedUser{ get; set; } 
      
        public LandingPage(User loginedUser)
        {
            InitializeComponent();


           
            this.loginedUser = loginedUser;
            DataContext = this;
        }

        private T FindChild<T>(DependencyObject parent, string childName) where T : DependencyObject
        {
            if (parent != null)
            {
                int childrenCount = VisualTreeHelper.GetChildrenCount(parent);
                for (int i = 0; i < childrenCount; i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(parent, i);

                    if (child is T && ((FrameworkElement)child).Name == childName)
                    {
                        return (T)child;
                    }
                    else
                    {
                        T childOfChild = FindChild<T>(child, childName);
                        if (childOfChild != null)
                        {
                            return childOfChild;
                        }
                    }
                }
            }
            return null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LandingAddPage(loginedUser.Accounts));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ComboBox comboBox = FindChild<ComboBox>(AccountsListView, "combobox");
            int index = comboBox.SelectedIndex;
            loginedUser.Accounts.RemoveAt(index);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new LandingProfile(loginedUser));
        }
    }
}
