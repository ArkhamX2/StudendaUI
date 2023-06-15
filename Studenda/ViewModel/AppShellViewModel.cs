using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Studenda.View.AndroidView;

namespace Studenda.ViewModel
{
    [ObservableObject]
    public partial class AppShellViewModel
    {
        public AppShellViewModel()
        {
        }

        [RelayCommand]
        async private void LogOut()
        {
            await Shell.Current.GoToAsync($"//{nameof(LogInView)}");
        }
    }
}
