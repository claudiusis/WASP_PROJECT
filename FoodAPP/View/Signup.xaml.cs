using Plugin.LocalNotification;
namespace FoodAPP.View;

public partial class  Signup: ContentPage
{
    
    public Signup()
    {
        InitializeComponent();
        BindingContext = new SignupViewModel();
    }
}

