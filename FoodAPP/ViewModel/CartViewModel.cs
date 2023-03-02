using FoodAPP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FoodAPP.ViewModel
{
    public class CartViewModel
    {
        public ICommand FridgeCommand => new Command(OnFridgeClicked);
        public ICommand UsCommand => new Command(OnUsClicked);

        private async void OnFridgeClicked()
        {
            await Shell.Current.GoToAsync(nameof(Fridge));
        }
        private async void OnUsClicked()
        {
            await Shell.Current.GoToAsync(nameof(UserPage));
        }
    }
}
