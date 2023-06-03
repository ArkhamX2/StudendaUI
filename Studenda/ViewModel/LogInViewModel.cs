using Studenda.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Studenda.ViewModel
{
    internal class LogInViewModel
    {
        public ICommand GoToScheduleViewCommand { get; set; }
        public LogInViewModel()
        {
            GoToScheduleViewCommand = new Command(GoToScheduleView);
        }
        async void GoToScheduleView()
        {
            await Shell.Current.GoToAsync($"//{nameof(ScheduleView)}");
        }
    }
}
