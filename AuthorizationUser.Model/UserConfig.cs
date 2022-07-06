using System.Text.Json;

namespace AuthorizationUser.Model;

public static class UserConfig
{
    public static string Path = "user.json";
    
    public static void ExportToFile(User user)
    {
        using var file = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write);
        JsonSerializer.Serialize(file, user);
    }

    public static User ImportFromFile()
    {
        using var file = new FileStream(Path, FileMode.Open, FileAccess.Read);
        return JsonSerializer.Deserialize<User>(file);
    }
}
