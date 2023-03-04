using FoodAPP.View;
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

        public ICommand Add => new Command(OnAddClicked);
        private async void OnAddClicked()
        {
            

        }
    }
}
