using FoodAPP.ViewModel;
using Plugin.LocalNotification;
namespace FoodAPP.View;

public partial class  Signin: ContentPage
{
    
    public Signin()
    {
        InitializeComponent();
        BindingContext = new SigninViewModel();
    }
}

