using DesignPatternChallenge.Notification.Factory;
using DesignPatternChallenge.Notification.Interfaces;

Console.WriteLine("=== Sistema de Notificações ===\n");

var factory = new NotificationFactory();

// Cliente 1 prefere Email
Console.WriteLine("--- Cliente 1 (Email) ---");
INotification emailNotification = factory.Create(ENotificationType.Email);
emailNotification.SendOrderConfirmation("cliente@email.com", "12345");
Console.WriteLine();

// Cliente 2 prefere SMS
Console.WriteLine("--- Cliente 2 (SMS) ---");
INotification smsNotification = factory.Create(ENotificationType.SMS);
smsNotification.SendOrderConfirmation("+5511999999999", "12346");
Console.WriteLine();

// Cliente 3 prefere Push
Console.WriteLine("--- Cliente 3 (Push) ---");
INotification pushNotification = factory.Create(ENotificationType.Push);
pushNotification.SendShippingUpdate("device-token-abc123", "BR123456789");
Console.WriteLine();

// Cliente 4 prefere WhatsApp
Console.WriteLine("--- Cliente 4 (WhatsApp) ---");
INotification whatsappNotification = factory.Create(ENotificationType.WhatsApp);
whatsappNotification.SendPaymentReminder("+5511888888888", 150.00m);
Console.WriteLine();
