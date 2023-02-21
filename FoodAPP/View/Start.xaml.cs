using FoodAPP.ViewModel;
using Plugin.LocalNotification;
namespace FoodAPP.View;

public partial class  Start: ContentPage
{
    
    public Start()
    {
        InitializeComponent();
        BindingContext = new StartViewModel();
    }

}

