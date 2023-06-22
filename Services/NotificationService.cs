using di_ioc_dip_console.Interfaces;

namespace di_ioc_dip_console.Services;

public class NotificationService
{
    private readonly IMessageSender _messageSender;

    public NotificationService(IMessageSender messageSender) =>_messageSender = messageSender;

    public void SendNotification(string to, string message) => _messageSender.Send(to, "Nova notificação", message);
}
