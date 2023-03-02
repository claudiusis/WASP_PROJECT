using FoodAPP.ViewModel;

namespace FoodAPP.View;

public partial class UserPage : ContentPage
{
	public UserPage()
	{
		InitializeComponent();
        BindingContext = new UserViewModel();
	}
}