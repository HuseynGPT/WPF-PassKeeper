using Microsoft.Win32;
using PassKeeper_WPF.Models;
using System.Windows.Controls;

namespace PassKeeper_WPF.Views.Pages;


public partial class LandingProfile : Page
{
    public User  user{ get; set; }

    public LandingProfile(User user)
    {
        InitializeComponent();

        this.user = user;
        DataContext = this;
    }

    private void TextBlock_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";

        if (openFileDialog.ShowDialog() == true)
        {
            user.ImagePath = openFileDialog.FileName;
            UsersCollection.UptadeDatabase();
        }
    }

    private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        UsersCollection.UptadeDatabase();
        NavigationService.GoBack();
    }
}
