using FoodAPP.ViewModel;
using Plugin.LocalNotification;

namespace FoodAPP.View;
public partial class Fridge : ContentPage
{
	public Fridge()
	{
		InitializeComponent();
		BindingContext = new FridgeViewModel();
        if (Prod.ItemsSource ==  null)
        {
            LocalNotificationCenter.Current.Show(AppShell.Request);
        }
	}
    protected override async void OnAppearing()
    {
        Prod.ItemsSource = await App.Database.GetFoodNote();
        base.OnAppearing();
    }
    private async void Prod_SelectionChanged(object sender, SelectionChangedEventArgs e)
     {
         if (e.CurrentSelection!=null)
         {
             FridgeModel product = (FridgeModel)e.CurrentSelection.FirstOrDefault();
             await Shell.Current.GoToAsync($"{nameof(FoodAdding)}?{nameof(FoodAdding.ProdId)}={product.ID.ToString()}");
         }
    }
}