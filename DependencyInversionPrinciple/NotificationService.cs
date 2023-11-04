namespace DependencyInversionPrinciple
{

    // Без применения Dependency Inversion Principle(DIP), высокоуровневый модуль NotificationService будет зависеть напрямую от низкоуровневых модулей, то есть от конкретных реализаций отправки уведомлений.
    // Вот как выглядел бы код без DIP:

/*
    public class NotificationService
    {
        public void SendEmailNotification(string message)
        {
                Логика отправки уведомления по электронной почте
        }

        public void SendSMSNotification(string message)
        {
                Логика отправки уведомления по SMS
        }
    }
*/



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
