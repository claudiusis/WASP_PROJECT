using FoodAPP.ViewModel;

namespace FoodAPP.View;
[QueryProperty(nameof(ProdId), nameof(ProdId))]
public partial class FoodAdding : ContentPage
{
    public string ProdId
    {
        set
        {
            Loadprod(value);
        }
    }

    public FoodAdding()
	{
		InitializeComponent();
        Date1.MaximumDate = DateTime.Now;
		BindingContext = new FridgeModel();
	}


    private async void Loadprod(string value)
    {
        try
        {
            int prodId = int.Parse(value);
            FridgeModel model = await App.Database.GetFoodNote(prodId);
            BindingContext = model;
        }
        catch { }

    }

    private void Date1_DateSelected(object sender, DateChangedEventArgs e)
    {
		Date2.MinimumDate = Date1.Date;
    }

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        Picker2.IsVisible = true;
    }
    private async void SaveClicked(object sender, EventArgs e)
    {
        FridgeModel fridge = (FridgeModel)BindingContext;
        await App.Database.SaveItemAsync(fridge);
        await Shell.Current.GoToAsync(nameof(Fridge));
    }
}