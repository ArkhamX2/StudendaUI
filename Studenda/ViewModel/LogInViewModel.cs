using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Studenda.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static Studenda.View.LogInView;

namespace Studenda.ViewModel
{
    [ObservableObject]
    public partial class LogInViewModel
    {
        [ObservableProperty]
        private bool activityIndicatorIsRunning = true;

        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string password;

        public LogInViewModel()
        {
        }

        [RelayCommand]
        async private void GoToScheduleView()
        {
            await Shell.Current.GoToAsync($"//{nameof(ScheduleView)}");
        }

        [RelayCommand]
        private async void Submit()
        {
            try
            {
                for (var i = 0.0; i < 1.0; i+=0.1)
                {
                    await LogInView.LoginProgressBar.ProgressTo(i, 500, Easing.Linear);
                }
                GoToScheduleView();

                await Application.Current.MainPage.DisplayAlert(
                    "Submit",
                    $"You entered {Username} and {Password}",
                    "OK");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {

            }
        }

        [RelayCommand]
        private async void Create()
        {
            try
            {

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

    }
}
