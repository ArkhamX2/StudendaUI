using Studenda.ViewModel;

namespace Studenda.View.AndroidView;

public partial class NotificationView : ContentPage
{
    NotificationViewModel vm = new NotificationViewModel();

    public NotificationView()
    {
        InitializeComponent();

        BindingContext = vm;
    }
}