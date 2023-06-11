using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Studenda.View;
using Studenda.View.AndroidView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
