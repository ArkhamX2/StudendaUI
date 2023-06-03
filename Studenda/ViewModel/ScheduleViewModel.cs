using Studenda.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Studenda.ViewModel
{
    internal class ScheduleViewModel
    {
        public ICommand GoToProfileViewCommand { get; set; }
        public ScheduleViewModel()
        {
            GoToProfileViewCommand = new Command(GoToProfileView);
        }
        async void GoToProfileView()
        {
            await Shell.Current.GoToAsync($"{nameof(ProfileView)}");
        }
    }
}
