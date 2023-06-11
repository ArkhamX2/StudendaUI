using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.Messaging;
using Studenda.ViewModel;
using System.Windows.Input;

namespace Studenda.View.AndroidView;

public partial class LogInView : ContentPage
{
    LogInViewModel vm = new LogInViewModel();
    public LogInView()
	{
        InitializeComponent();
        BindingContext = vm;

    }
}