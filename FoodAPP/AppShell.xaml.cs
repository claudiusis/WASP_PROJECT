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
        Routing.RegisterRoute(nameof(UserPage), typeof(UserPage));
        DateTime date = DateTime.Now;
        var request = new NotificationRequest
        {
            NotificationId = 1,
            Title = "WARNING",
            Subtitle = "It's time to clean fridge",
            Description = "WWWWW",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = date.AddSeconds(30),
            }
        };
        LocalNotificationCenter.Current.Show(request);
    }
}
