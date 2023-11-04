namespace DependencyInversionPrinciple
{
    public class NotificationService
    {
        private INotification _notification;

        public NotificationService(INotification notification)
        {
            _notification = notification;
        }

        public void SendNotification(string message)
        {
            _notification.SendNotification(message);
        }
    }
}
