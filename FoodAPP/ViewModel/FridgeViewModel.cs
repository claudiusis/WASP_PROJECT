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
            foreach (FridgeModel product in products)
            {
                Products.Add(product);
            }
        }
        public ICommand PlusCommand => new Command(OnPlusClicked);
        public ICommand SwipeCommand => new Command<int>(OnSwiped);
        public ICommand CartCommand => new Command(OnCartClicked);
        public ICommand UsCommand => new Command(OnUsClicked);
        private async void OnPlusClicked()
        {
            await Shell.Current.GoToAsync(nameof(FoodAdding));
        }
        private async void OnSwiped(int id)
        {
            FridgeModel product = await App.Database.GetFoodNote(id);
            await App.Database.DeleteItemAsync(product);
        }

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
