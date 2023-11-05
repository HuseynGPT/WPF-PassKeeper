using PassKeeper_WPF.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace PassKeeper_WPF.Models;

public class User:NotificationService
{
    private string? firstName;
    private string? lastName;
    private string? email;
    private string? password;
    private string? imagePath;

    public string? FirstName { get => firstName; set { firstName = value;OnPropertyChanged(); } }
    public string? LastName { get => lastName; set { lastName = value; OnPropertyChanged(); } }
    public string? Email { get => email; set { email = value; OnPropertyChanged(); } }
    public string? Password { get => password; set { password = value;OnPropertyChanged(); } }
    public string? ImagePath { get => imagePath; set { imagePath = value;OnPropertyChanged(); } }

    public ObservableCollection<Account>? Accounts{ get; set; }


}
