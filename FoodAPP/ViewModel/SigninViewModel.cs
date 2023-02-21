using FoodAPP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FoodAPP.ViewModel
{
    internal class SigninViewModel
    {
        public ICommand SignupCommand {
            get { 
                return new Command(OnSignupClicked);
            }
        }                   
        private async void OnSignupClicked()
        {
            await Shell.Current.GoToAsync(nameof(Signup));
        }
    }
}
