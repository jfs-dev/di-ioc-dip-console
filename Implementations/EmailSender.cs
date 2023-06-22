using di_ioc_dip_console.Interfaces;

namespace di_ioc_dip_console.Implemetations;

public class EmailSender : IMessageSender
{
    public void Send(string to, string subject, string body)
    {
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("Enviando e-mail para: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{to}");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("             Assunto: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{subject}");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("            Mensagem: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{body}");
    }
}
