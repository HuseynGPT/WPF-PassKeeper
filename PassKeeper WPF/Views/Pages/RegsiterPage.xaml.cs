using PassKeeper_WPF.Models;
using System.Reflection.Metadata.Ecma335;
using System.Windows;
using System.Windows.Controls;

namespace PassKeeper_WPF.Views.Pages;


public partial class RegsiterPage : Page
{
    public User? NewUser { get; set; } = new();

    public RegsiterPage()
    {
        InitializeComponent();

        DataContext = this;
    }

    private void NextBtn_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        MessageBox.Show(NewUser.FirstName);
        NavigationService.Navigate(new RegisterPasswordPage(NewUser));
    }
}
