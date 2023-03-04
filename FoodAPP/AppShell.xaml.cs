using FoodAPP;
using FoodAPP.View;
using Plugin.LocalNotification;

namespace FoodAPP;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(Signin), typeof(Signin));
        Routing.RegisterRoute(nameof(Signup), typeof(Signup));
        Routing.RegisterRoute(nameof(Fridge), typeof(Fridge));
        Routing.RegisterRoute(nameof(Cart), typeof(Cart));
        Routing.RegisterRoute(nameof(FoodAdding), typeof(FoodAdding));
        Routing.RegisterRoute(nameof(UserPage), typeof(UserPage));
        
    }
    static DateTime Date = DateTime.Now.Date;
    static NotificationRequest request = new NotificationRequest
    {
        NotificationId = 1,
        Title = "CHANGES IN FRIDGE",
        Subtitle = "It's time to come back",
        Description = "Somethig happened in fridge",
        Schedule = new NotificationRequestSchedule
        {
            NotifyTime = Date.AddSeconds(30),
        }
    };
    public static NotificationRequest Request => request;
}
