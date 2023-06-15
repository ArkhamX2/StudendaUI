using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Studenda.View.AndroidView;

namespace Studenda.ViewModel
{
    [ObservableObject]
    public partial class NavigationBarViewModel
    {
        [ObservableProperty]
        private string weekBorders;

        [RelayCommand]
        async private void GoToNotificationView()
        {
            await Shell.Current.GoToAsync($"///{nameof(NotificationView)}");
        }

        [RelayCommand]
        async private void Notifications()
        {
            GoToNotificationView();
        }

        public NavigationBarViewModel() 
        {
            WeekBorders = "12.03-19.03";
        }
    }
}
