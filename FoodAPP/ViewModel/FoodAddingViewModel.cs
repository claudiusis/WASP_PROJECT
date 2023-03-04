using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FoodAPP.ViewModel
{
    public class FoodAddingViewModel
    {   

        ICommand BackCommand => new Command(OnBackClicked);

        private async void OnBackClicked()
        {
            await Shell.Current.GoToAsync("..\\");
        }
    }
}
