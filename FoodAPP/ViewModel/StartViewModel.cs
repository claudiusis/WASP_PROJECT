using FoodAPP.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FoodAPP.ViewModel
{
    internal class StartViewModel:INotifyPropertyChanged
    {
        public ICommand SignInCommand => new Command(OnSignInClicked);
        public ICommand SignUpCommand => new Command(OnSignUpClicked);

        public event PropertyChangedEventHandler PropertyChanged;

        private async void OnSignInClicked()
        {
            await Shell.Current.GoToAsync(nameof(Signin));
        }
        private async void OnSignUpClicked() {
            await Shell.Current.GoToAsync(nameof(Signup));
        }
        public void OnPropertyChanged([CallerMemberName] string str = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(str));
        }
    }
}
