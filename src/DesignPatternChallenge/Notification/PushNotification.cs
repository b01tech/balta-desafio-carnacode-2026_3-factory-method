using DesignPatternChallenge.Notification.Interfaces;

namespace DesignPatternChallenge.Notification;

internal class PushNotification : INotification
{
    public string DeviceToken { get; set; }
    public string Title { get; set; }
    public string Message { get; set; }
    public int Badge { get; set; }

    private void Send()
    {
        Console.WriteLine($"🔔 Enviando Push para dispositivo {DeviceToken}");
        Console.WriteLine($"   Título: {Title}");
        Console.WriteLine($"   Mensagem: {Message}");
    }
    public void SendOrderConfirmation(string recipient, string orderNumber)
    {
        DeviceToken = recipient;
        Title = "Pedido Enviado";
        Message = $"Seu pedido foi enviado! Código de rastreamento: {orderNumber}";
        Badge = 1;
        Send();
    }
    public void SendShippingUpdate(string recipient, string trackingCode)
    {
        DeviceToken = recipient;
        Title = "Atualização de Envio";
        Message = $"Seu pedido foi enviado. Código de rastreio: {trackingCode}";
        Badge = 0;
        Send();
    }
    public void SendPaymentReminder(string recipient, decimal amount)
    {
        DeviceToken = recipient;
        Title = "Lembrete de Pagamento";
        Message = $"Você tem um pagamento pendente de {amount:C}.";
        Badge = 0;
        Send();
    }
}