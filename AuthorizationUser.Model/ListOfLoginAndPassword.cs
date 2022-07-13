namespace AuthorizationUser.Model;

public class ListOfLoginAndPassword
{
    private readonly Dictionary<string, string> _dictionary;

    public ListOfLoginAndPassword(Dictionary<string, string> dictionary)
    {
        _dictionary = dictionary;
    }

    public bool CheckLogin(string login) => _dictionary.ContainsKey(login);

    public bool CheckPassword(string login, string password) => _dictionary[login] == password;
}
