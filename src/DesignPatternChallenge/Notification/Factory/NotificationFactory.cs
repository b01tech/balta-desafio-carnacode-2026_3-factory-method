using DesignPatternChallenge.Notification.Interfaces;
using DesignPatternChallenge.Notification;

namespace DesignPatternChallenge.Notification.Factory;

public class NotificationFactory
{
    public INotification Create(ENotificationType type)
    {
        return type switch
        {
            ENotificationType.Email => new EmailNotification(),
            ENotificationType.WhatsApp => new WhatsAppNotification(),
            ENotificationType.Push => new PushNotification(),
            ENotificationType.SMS => new SmsNotification(),
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null),
        };
    }
}
