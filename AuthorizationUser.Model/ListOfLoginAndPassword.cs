namespace AuthorizationUser.Model;

public class ListOfLoginAndPassword
{
    private readonly Dictionary<string, string> _dictionary;

    public ListOfLoginAndPassword(Dictionary<string, string> dictionary)
    {
        _dictionary = dictionary;
    }

    public bool CheckLogin(string login)
    {
        return _dictionary.ContainsKey(login);
    }

    public bool CheckPassword(string login, string password)
    {
        return _dictionary[login] == password;
    }
}
