using Studenda.ViewModel;
using System.Windows.Input;

namespace Studenda.View;

public partial class LogInView : ContentPage
{
    public LogInView()
	{
        InitializeComponent();        

        BindingContext = new LogInViewModel();
    }
}