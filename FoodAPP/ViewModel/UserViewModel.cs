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
