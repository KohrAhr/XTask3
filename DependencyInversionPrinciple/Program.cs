using System;

namespace DependencyInversionPrinciple
{
    // Принцип инверсии зависимостей (Dependency Inversion Principle, DIP) подразумевает, что высокоуровневые модули не должны зависеть от модулей низкого уровня.
    // Оба уровня модулей должны зависеть от абстракций, а сами абстракции не должны зависеть от деталей. Детали должны зависеть от абстракций.

    // В этом примере INotification представляет абстракцию для отправки уведомлений, а NotificationByEmail и NotificationBySMS представляют конкретные реализации.
    // NotificationService является высокоуровневым модулем, который не зависит напрямую от конкретных реализаций.Вместо этого он зависит от абстракции INotification.

    // Это соответствует принципу DIP.
    // Если мы хотим добавить новый способ отправки уведомлений, например, через мессенджер, мы можем создать новую реализацию INotification, и NotificationService не потребует изменений, потому что он зависит от абстракции, а не от деталей.
    // Это делает систему более гибкой и расширяемой.

    internal class Program
    {
        static void Main(string[] args)
        {
            INotification notificationByEmail = new NotificationByEmail();
            INotification notificationBySMS = new NotificationBySMS();

            notificationByEmail.SendNotification("Yo!");
            notificationBySMS.SendNotification("Yo!");

            Console.ReadKey();
        }
    }
}
