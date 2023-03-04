using FoodAPP.ViewModel;
using Plugin.LocalNotification;
namespace FoodAPP.View;
using SQLite;

public partial class  Signin: ContentPage
{
    
    public Signin()
    {
        InitializeComponent();
        BindingContext = new SigninViewModel();
    }

    void OnEyeTapped(object sender, EventArgs e)
    {
        if (PasswordEntr.IsPassword)
        {
            PasswordEntr.IsPassword = false;
            Eye.Source = "Images/eye2.png";
        }
        else
        {
            PasswordEntr.IsPassword = true;
            Eye.Source = "Images/eye.png";
        }
    }
}

