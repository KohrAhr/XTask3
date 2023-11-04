using System;

namespace DependencyInversionPrinciple
{
    public class NotificationBySMS : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"SMS! {message}");
        }
    }
}
