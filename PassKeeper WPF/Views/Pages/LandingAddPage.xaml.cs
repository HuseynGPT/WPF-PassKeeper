using PassKeeper_WPF.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PassKeeper_WPF.Views.Pages;


public partial class LandingAddPage : Page
{
    public Account newAcc { get; set; } = new();
    public ObservableCollection<Account> accounts { get; set; }

    public LandingAddPage(ObservableCollection<Account> accounts)
    {
        InitializeComponent();
        this.accounts = accounts;



        DataContext = this;

    }

    private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        newAcc.Name = nameInput.Text;
        newAcc.LogIn = Logininput.Text;
        newAcc.Password = passwordInput.Text;
        newAcc.Category = KateqoriName.Text;

        accounts.Add(newAcc);
        UsersCollection.UptadeDatabase();
        MessageBox.Show("Succesfuly added!!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        NavigationService.GoBack();

    }
}
