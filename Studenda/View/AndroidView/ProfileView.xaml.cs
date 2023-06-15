using Studenda.ViewModel;

namespace Studenda.View.AndroidView;

public partial class ProfileView : ContentPage
{
    ProfileViewModel vm = new ProfileViewModel();
    public ProfileView()
    {
        InitializeComponent();

        BindingContext = vm;
    }
}