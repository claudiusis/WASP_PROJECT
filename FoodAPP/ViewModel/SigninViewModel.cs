using FoodAPP.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SQLite;

namespace FoodAPP.ViewModel
{
    internal class SigninViewModel: INotifyPropertyChanged
    {
        public string UserName {get; set;}
        public string Password { get; set;}

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand SignupCommand => new Command(OnSignupClicked);
        public ICommand SigninCommand => new Command(OnSigninClicked);
        
        private async void OnSignupClicked()
        {
            await Shell.Current.GoToAsync(nameof(Signup));
        }

        private async void OnSigninClicked(object obj)
        {
            var signindata = await App.Database.GetLoginDataAsync(UserName);
            if (signindata != null)
            {
                if (string.Equals(Password, signindata.Password))
                {
                    await Shell.Current.GoToAsync(nameof(Fridge));
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("ERROR!", "Uncorrect password", "OK");
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("ERROR!", "Uncorrect username", "OK");
            }
        }

        public void OnPropertyChanged([CallerMemberName] string str = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(str));
        }
    }
}
