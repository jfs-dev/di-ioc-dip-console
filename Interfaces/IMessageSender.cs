namespace di_ioc_dip_console.Interfaces;

public interface IMessageSender
{
    void Send(string to, string subject, string body);
}
