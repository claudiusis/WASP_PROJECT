using FoodAPP.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using SQLite;

namespace FoodAPP.ViewModel2
{
    internal class SignupViewModel: INotifyPropertyChanged
    {
        public string Name {get; set;}
        public string SurName { get; set;}
        public string Mail { get; set;}
        public string Password { get; set;}
        public string Password_2 { get; set;}
        public ICommand SigninCommand => new Command(SignInClicked);
        public ICommand SignupCommand => new Command(SignUpClicked);

        public event PropertyChangedEventHandler PropertyChanged;

        private async void SignUpClicked(object obj)
        {
            SignupModel sgnmd = new SignupModel();
            string []modelparts = { Name, Mail, Password};
            bool key = true;
            var databasechecker = await App.Database.GetLoginDataAsync(Mail);
            if (modelparts.All(s => !string.IsNullOrEmpty(s))){
                sgnmd.Name = Name;
                sgnmd.SurName = SurName;
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(Mail);
                if (match.Success)
                {
                    sgnmd.Email = Mail;
                }
                else
                {
                    await Shell.Current.DisplayAlert("Uncorrect email", "", "Ok");
                    key= false;
                }
                if (string.Equals(Password, Password_2))
                {
                    sgnmd.Password = Password;
                }
                else
                {
                    await Shell.Current.DisplayAlert("Passwords unequal", "", "Ok");
                    key= false;
                    
                }
                if (key && databasechecker==null)
                {
                   await App.Database.SaveLoginDataAsync(sgnmd);
                   await Shell.Current.DisplayAlert("Account created!","", "OK");
                    await Shell.Current.GoToAsync(nameof(Signin));
                }
                else
                {
                    await Shell.Current.DisplayAlert("Email register in system","Use another e-mail","Ok");
                }
            }
            else
            {
                await Shell.Current.DisplayAlert("Not all fill in", "", "Ok");
                key= false;
            }
        }
        private async void SignInClicked()
        {
            await Shell.Current.GoToAsync(nameof(Signin));
        }

        public void OnPropertyChanged([CallerMemberName] string str = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(str));
        }
    }
}
