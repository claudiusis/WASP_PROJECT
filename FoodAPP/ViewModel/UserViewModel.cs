using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FoodAPP;
using FoodAPP.View;

namespace FoodAPP.ViewModel
{
    public class UserViewModel
    {
        /* SignupModel signupModel;

         public string Name { get; set; }
         public string Surname { get; set; }
         public string Email { get; set; }
         public UserViewModel(DataBase data) {

         }*/
        public ICommand CartCommand => new Command(OnCartClicked);
        public ICommand FridgeCommand => new Command(OnFridgeClicked);

        private async void OnCartClicked()
        {
            await Shell.Current.GoToAsync(nameof(Cart));
        }
        private async void OnFridgeClicked()
        {
            await Shell.Current.GoToAsync(nameof(Fridge));
        }
    }
}
