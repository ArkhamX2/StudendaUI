using Studenda.ViewModel;

namespace Studenda.Components.UI;

public partial class NavigationBarComponent : ContentView
{
    NavigationBarViewModel vm = new NavigationBarViewModel();
    public NavigationBarComponent()
    {
        InitializeComponent();
        BindingContext = vm;
    }
    private void BurgerMenu_Clicked(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }
}