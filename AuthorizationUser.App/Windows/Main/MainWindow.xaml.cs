using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using AuthorizationUser.App.Annotations;
using AuthorizationUser.Model;

namespace AuthorizationUser.App.Windows.Main;
public partial class MainWindow : Window, INotifyPropertyChanged
{
    private User _user;
    public User User
    {
        get => _user;
        set
        {
            _user = value;
            OnPropertyChanged(nameof(User));
        }
    }
    
    public MainWindow()
    {
        User = new User();
        
        InitializeComponent();
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
