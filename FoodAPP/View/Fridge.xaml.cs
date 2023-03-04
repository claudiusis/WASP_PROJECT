using FoodAPP.ViewModel;

namespace FoodAPP.View;

public partial class Fridge : ContentPage
{
    public int FridgeId { get => SigninViewModel.user_id; }
	public Fridge()
	{
		InitializeComponent();
		BindingContext = new FridgeViewModel();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
    }

   /* private async void Prod_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection!=null)
        {
            FridgeModel product = (FridgeModel)e.CurrentSelection.FirstOrDefault();
            await Shell.Current.GoToAsync($"{nameof(FoodAdding)}?{nameof(FoodAdding.ItemId)}={FridgeModel.ItemSource}");
        }
    }*/
}