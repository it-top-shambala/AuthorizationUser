using System.Text.Json;

namespace AuthorizationUser.Model;

public static class GetUsersFromJson
{
    private const string Path = "users.json";

    public static ListOfLoginAndPassword GetListOfLoginAndPassword()
    {
        using var file = new FileStream(Path, FileMode.Open, FileAccess.Read);
        var users = JsonSerializer.Deserialize<List<User>>(file);

        var dict = users.ToDictionary(user => user.Login, user => user.Password);

        return new ListOfLoginAndPassword(dict);
    }
}
