using FoodAPP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FoodAPP.ViewModel
{
    internal class SignupViewModel
    {
        public ICommand SigninCommand
        {
            get
            {
                return new Command(SignInClicked);
            }
        }

        private async void SignInClicked()
        {
            await Shell.Current.GoToAsync(nameof(Signin));
        }
    }
}
