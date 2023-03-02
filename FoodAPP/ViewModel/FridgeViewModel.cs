using System.Collections.ObjectModel;
using System.Windows.Input;
using FoodAPP.View;

namespace FoodAPP.ViewModel
{
    public class FridgeViewModel
    {
        public ObservableCollection<FridgeModel> Products { get; set; }

        public void LoadProducts()
        {
            if (Products != null) 
            { 
                Products.Clear();
            }
            IEnumerable<FridgeModel> products = (IEnumerable<FridgeModel>)App.Database.GetFoodNote();
        }

        public ICommand CartCommand => new Command(OnCartClicked);
        public ICommand UsCommand => new Command(OnUsClicked);

        private async void OnCartClicked()
        {
            await Shell.Current.GoToAsync(nameof(Cart));
        }
        private async void OnUsClicked()
        {
            await Shell.Current.GoToAsync(nameof(UserPage));
        }

    }
}
