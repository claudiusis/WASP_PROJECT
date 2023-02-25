using FoodAPP.ViewModel2;
using Plugin.LocalNotification;
namespace FoodAPP.View;
using SQLite;

public partial class  Signup: ContentPage
{
    
    public Signup()
    {
        InitializeComponent();
        BindingContext = new SignupViewModel();
    }
}

