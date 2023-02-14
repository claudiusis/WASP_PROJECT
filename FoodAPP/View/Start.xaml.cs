using Plugin.LocalNotification;
namespace FoodAPP.View;

public partial class  Start: ContentPage
{
    
    public Start()
    {
        InitializeComponent();
    }

    private async void btn_Signin_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Signin));
    }
    
    private async void btn_Signup_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Signup));
    }
}

