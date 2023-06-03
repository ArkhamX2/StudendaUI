using Studenda.ViewModel;

namespace Studenda.View;

public partial class ScheduleView : ContentPage
{
	public ScheduleView()
	{
        InitializeComponent();

        BindingContext = new ScheduleViewModel();
    }

}