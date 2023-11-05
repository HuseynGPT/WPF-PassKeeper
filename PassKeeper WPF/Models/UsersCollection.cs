using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PassKeeper_WPF.Models;

static public class UsersCollection
{
    static readonly string? path = "..\\..\\..\\DataBase\\Users.json";
    static public ObservableCollection<User>? Users { get; set; } = new();


    static public void LoadDatabase()
    {
        var json = File.ReadAllText(path!);
        Users = JsonSerializer.Deserialize<ObservableCollection<User>>(json);
    }

    static public void UptadeDatabase()
    {
        var json = JsonSerializer.Serialize(Users!, new JsonSerializerOptions() { WriteIndented = true });
        File.WriteAllText(path!, json);
    }

    static public User FindUserFromDatabase(string? email, string? password)
    {
        if (Users!=null)
        {
            foreach (var item in Users)
            {
                if (item.Email.Equals(email) && item.Password.Equals(password))
                {
                    return item;
                }
            }
        }

        return null;


    }


}
