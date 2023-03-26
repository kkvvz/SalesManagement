using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesManagement.Data.Contexts;
using SalesManagement.Options;
using SalesManagement.Services;
using System.Text.Json;

namespace SalesManagement;
internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        var configuration = JsonSerializer.Deserialize<MainConfiguration>(File.ReadAllText("appsettings.json"))!;
        var services = ConfigureServices(configuration);

        using var provider = services.BuildServiceProvider();
        var form = provider.GetRequiredService<MainForm>();

        Application.Run(form);
    }

    private static IServiceCollection ConfigureServices(MainConfiguration config)
    {
        var services = new ServiceCollection();
        services.AddScoped<MainForm>();
        services.AddDbContext<MainContext>(x =>
        {
            x.UseNpgsql(config.ConnectionString);
        });
        services.AddScoped<StorageService>();
        services.AddScoped<SalesAccountingService>();
        services.AddScoped<PurchasesAccountingService>();

        return services;
    }
}