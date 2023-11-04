using System;

namespace DependencyInversionPrinciple
{
    public class NotificationByEmail : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Email! {message}");
        }
    }
}
