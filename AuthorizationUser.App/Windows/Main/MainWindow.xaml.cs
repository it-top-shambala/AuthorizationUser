using System.Windows;
using System.Windows.Controls;
using AuthorizationUser.Model;

namespace AuthorizationUser.App.Windows.Main;
public partial class MainWindow : Window
{
    private User _user;

    public MainWindow()
    {
        _user = new User();
        
        InitializeComponent();
    }

    private void ButtonClear_OnClick(object sender, RoutedEventArgs e)
    {
        ClearAll();
    }

    private void ButtonLogIn_OnClick(object sender, RoutedEventArgs e)
    {
        
        ClearAll();
    }

    private void ClearAll()
    {
        InputLogin.Clear();
        InputPassword.Clear();
    }
}
