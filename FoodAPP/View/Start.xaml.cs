using FoodAPP.ViewModel;
using Plugin.LocalNotification;
namespace FoodAPP.View;

public partial class  Start: ContentPage
{
    
    public Start()
    {
        InitializeComponent();
        Label label = new Label();
        label.Text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        BindingContext = new StartViewModel();
    }

}

