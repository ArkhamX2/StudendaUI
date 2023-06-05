using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Studenda.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Studenda.ViewModel
{
    [ObservableObject]
    public partial class LogInViewModel
    {
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
        private void Submit()
        {
            try
            {

                GoToScheduleView();
            }
            catch (Exception e)
            {
                Console.WriteLine( e.Message );
            }
            finally
            {

            }
        }

    }
}
