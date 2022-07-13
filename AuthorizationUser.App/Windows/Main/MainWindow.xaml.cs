using System.Windows;
using AuthorizationUser.App.Windows.Registration;
using AuthorizationUser.Model;

namespace AuthorizationUser.App.Windows.Main;

public partial class MainWindow
{
    private readonly ListOfLoginAndPassword _list;

    public MainWindow()
    {
        _list = GetUsersFromJson.GetListOfLoginAndPassword();

        InitializeComponent();

        Closing += (_, args) =>
        {
            var res = MessageBox.Show("Вы уверены?", "Авторизация", MessageBoxButton.YesNo, MessageBoxImage.Question);
            args.Cancel = res == MessageBoxResult.No;
        };
    }

    private void ButtonClear_OnClick(object sender, RoutedEventArgs e)
    {
        ClearAll();
    }

    private void ButtonLogIn_OnClick(object sender, RoutedEventArgs e)
    {
        var login = InputLogin.Text;
        var password = InputPassword.Password;

        var checkLogin = _list.CheckLogin(login);
        if (checkLogin)
        {
            var checkPassword = _list.CheckPassword(login, password);
            if (checkPassword)
            {
                MessageBox.Show("Вы успешно авторизовались!", "Авторизация", MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Неверно ввели данные!", "Авторизация", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }
        else
        {
            MessageBox.Show("Неверно ввели данные!", "Авторизация", MessageBoxButton.OK,
                MessageBoxImage.Error);
        }

        ClearAll();
    }

    private void ClearAll()
    {
        InputLogin.Clear();
        InputPassword.Clear();
    }

    private void HyperlinkRegistration_OnClick(object sender, RoutedEventArgs e)
    {
        new RegistrationWindow().Show();

        Close();
    }
}
