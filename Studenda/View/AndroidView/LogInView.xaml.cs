using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.Messaging;
using Studenda.ViewModel;
using System.Windows.Input;

namespace Studenda.View;

public partial class LogInView : ContentPage
{
    public partial class ConstructMessage { }

    public static ProgressBar LoginProgressBar;
    LogInViewModel vm = new LogInViewModel();
    public LogInView()
	{
        LoginProgressBar = new ProgressBar();
        InitializeComponent();
        LoginPageStackLayout.Children.Add(LoginProgressBar);
        BindingContext = vm;

    }
}