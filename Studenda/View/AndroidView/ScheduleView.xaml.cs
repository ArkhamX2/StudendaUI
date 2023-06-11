using Studenda.ViewModel;

namespace Studenda.View.AndroidView;

public partial class ScheduleView : ContentPage
{
	public ScheduleView()
	{
        InitializeComponent();

        BindingContext = new ScheduleViewModel();
    }

}