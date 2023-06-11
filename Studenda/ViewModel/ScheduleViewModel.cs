using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Studenda.View.AndroidView;

namespace Studenda.ViewModel
{
    public enum WeekType
    {
        Red, Blue
    }

    [ObservableObject]
    public partial class ScheduleViewModel
    {
        [ObservableProperty]
        private string weekBordersDate;

        [ObservableProperty]
        private WeekType typeOfWeek;


        public ScheduleViewModel()
        {
        }

        [RelayCommand]
        async private void GoToProfileView()
        {
            await Shell.Current.GoToAsync($"{nameof(ProfileView)}");
        }

    }

}
