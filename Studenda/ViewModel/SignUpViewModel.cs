using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Studenda.ViewModel
{
    [ObservableObject]
    public partial class SignUpViewModel
    {
        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string password;

        [ObservableProperty]
        private string email;

        [ObservableProperty]
        private string studentID;

        public SignUpViewModel()
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
