using Microsoft.Extensions.DependencyInjection;
using di_ioc_dip_console.Implemetations;
using di_ioc_dip_console.Interfaces;
using di_ioc_dip_console.Services;

var serviceProvider = new ServiceCollection()
    .AddTransient<IMessageSender, EmailSender>()
    .AddTransient<NotificationService>()
    .BuildServiceProvider();

var notificationService = serviceProvider.GetService<NotificationService>() ?? throw new InvalidOperationException("Falha ao obter o serviço NotificationService. Verifique se está configurado corretamente.");
notificationService.SendNotification("email@dominio.com.br", "Olá, esta é uma notificação.");
