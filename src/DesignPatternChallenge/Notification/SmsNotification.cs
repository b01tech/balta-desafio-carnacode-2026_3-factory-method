using DesignPatternChallenge.Notification.Interfaces;

namespace DesignPatternChallenge.Notification;

internal class SmsNotification : INotification
{
    public string PhoneNumber { get; set; }
    public string Message { get; set; }

    private void Send()
    {
        Console.WriteLine($"📱 Enviando SMS para {PhoneNumber}");
        Console.WriteLine($"   Mensagem: {Message}");
    }
    public void SendOrderConfirmation(string recipient, string orderNumber)
    {
        PhoneNumber = recipient;
        Message = $"Seu pedido foi enviado! Código de rastreamento: {orderNumber}";
        Send();
    }
    public void SendShippingUpdate(string recipient, string trackingCode)
    {
        PhoneNumber = recipient;
        Message = $"Seu pedido foi enviado. Código de rastreio: {trackingCode}";
        Send();
    }
    public void SendPaymentReminder(string recipient, decimal amount)
    {
        PhoneNumber = recipient;
        Message = $"Você tem um pagamento pendente de {amount:C}.";
        Send();
    }
}