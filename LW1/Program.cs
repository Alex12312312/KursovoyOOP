using LW1.Data;
using LW1.Repositories;
using LW1.Repositories.Interfaces;
using LW1.Services;
using LW1.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LW1;

static class Program
{
    /// <summary>
    ///  Главная точка входа приложения
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        var host = CreateHostBuilder().Build();
        var serviceProvider = host.Services;

        using var scope = host.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<DataContext>();
        context.Init();
        
        Application.Run(serviceProvider.GetRequiredService<Form1>());
    }

    private static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services)=>
            {
                services.AddTransient<ITransportRepository, TransportRepository>();
                services.AddTransient<ITransportService, TransportService>();
                services.AddTransient<Form1>();
                services.AddSingleton<DataContext>();
            });
    }
}