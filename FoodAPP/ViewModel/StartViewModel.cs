using FoodAPP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FoodAPP.ViewModel
{
    internal class StartViewModel
    {
        public ICommand SignInCommand
        {
            get
            {
                return new Command(OnSignInClicked);
            }
        }
        public ICommand SignUpCommand
        {
            get
            {
                return new Command(OnSignUpClicked);
            }
        }

        private async void OnSignInClicked()
        {
            await Shell.Current.GoToAsync(nameof(Signin));
        }
        private async void OnSignUpClicked() {
            await Shell.Current.GoToAsync(nameof(Signup));
        
        }
    }
}
