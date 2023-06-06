using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenda.ViewModel
{
    [ObservableObject]
    public partial class RegisterViewModel
    {
        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string password;

        [ObservableProperty]
        private string email;

        [ObservableProperty]
        private string studentID;

        public RegisterViewModel()
        {
        }

        [RelayCommand]
        async private void CreateAccount()
        {
            try
            {
                //TODO: Создание аккаунта
            }
            catch (Exception e)
            {
                //TODO: Обработка ошибок регистрации
                throw new Exception(e.Message);
            }
        }

    }
}
