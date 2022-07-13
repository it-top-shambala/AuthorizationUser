using System.Windows;
using AuthorizationUser.App.Windows.Main;

namespace AuthorizationUser.App.Windows.Registration;

public partial class RegistrationWindow
{
    public RegistrationWindow()
    {
        InitializeComponent();
    }

    private void HyperlinkAuthorization_OnClick(object sender, RoutedEventArgs e)
    {
        new MainWindow().Show();
        Close();
    }
}
