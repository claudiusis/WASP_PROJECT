using FoodAPP.ViewModel;

namespace FoodAPP.View;

public partial class UserPage : ContentPage
{
	public UserPage()
	{
		InitializeComponent();
		name.Text = SigninViewModel.user_name;
		surname.Text = SigninViewModel.user_surname;
		mail.Text = SigninViewModel.user_email;
        BindingContext = new UserViewModel();
	}
}