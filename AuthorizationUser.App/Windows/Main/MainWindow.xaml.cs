using System.Windows;
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
}
