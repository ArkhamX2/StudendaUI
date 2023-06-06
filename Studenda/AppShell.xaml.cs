using Studenda.View;
using Studenda.ViewModel;

namespace Studenda;

public partial class AppShell : Shell
{
	AppShellViewModel vm = new AppShellViewModel();
	public AppShell()
	{
		InitializeComponent();

        BindingContext = vm;

        Routing.RegisterRoute(nameof(ScheduleView), typeof(ScheduleView));
        Routing.RegisterRoute(nameof(ProfileView), typeof(ProfileView));
        Routing.RegisterRoute(nameof(LogInView), typeof(LogInView));
    }
}
