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
        DateTime date = new DateTime(2023, 02, 11, 16, 47, 35, 00);
        var request = new NotificationRequest
        {
            NotificationId = 1,
            Title = "WARNING",
            Subtitle = "It's time to clean fridge",
            Description = "WWWWW",
            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = date,
            }
        };
        if (date == DateTime.Today)
        {
            LocalNotificationCenter.Current.Show(request);
            Console.WriteLine("QQQQQ!!!!");
        }
    }
}
