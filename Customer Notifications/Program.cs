namespace Customer_Notifications
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationManager emailManeger = new NotificationManager(new EmailNotification());
            emailManeger.Notify("Hello! This is an email notification.");
            NotificationManager smsManeger = new NotificationManager(new SMSNotification());
            smsManeger.Notify("Hello! This is an SMS notification.");
            NotificationManager pushManager = new NotificationManager(new PushNotification());
            pushManager.Notify("Hello! This is a push notification.");

        }
    }
}
