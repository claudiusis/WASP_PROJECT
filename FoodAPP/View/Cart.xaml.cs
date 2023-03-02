using FoodAPP.ViewModel;

namespace FoodAPP.View;

public partial class Cart : ContentPage
{
	public Cart()
	{
		InitializeComponent();
		BindingContext = new CartViewModel();
	}
}