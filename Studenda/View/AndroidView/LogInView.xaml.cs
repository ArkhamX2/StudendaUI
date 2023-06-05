using Studenda.ViewModel;
using System.Windows.Input;

namespace Studenda.View;

public partial class LogInView : ContentPage
{
    LogInViewModel vm = new LogInViewModel();
    public LogInView()
	{
        InitializeComponent();        

        BindingContext = vm;
    }
}