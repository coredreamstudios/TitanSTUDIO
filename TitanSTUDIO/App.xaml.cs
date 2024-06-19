using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SampleWpfLibrary;
using System.Windows;
using TitanSTUDIO.ViewModels;
using TitanSTUDIO.Views;

namespace TitanSTUDIO;

public partial class App : Application
{
    public static IHost? AppHost { get; private set; }

    public App()
    {
        AppHost = Host.CreateDefaultBuilder()
            .ConfigureServices((hostContext, services) => 
            {
                services.AddTransient<IDataAccess, DataAccess>();
               // services.AddScoped<ChildViewModel>();
               // services.AddScoped<ChildView>();
                services.AddSingleton<MainViewModel>();
                services.AddSingleton<MainView>();
            }).Build();
    }

    protected override async void OnStartup(StartupEventArgs e)
    {
        await AppHost!.StartAsync();

        var startupForm = AppHost.Services.GetRequiredService<MainView>();
        startupForm.Show();

        base.OnStartup(e);
    }

    protected override async void OnExit(ExitEventArgs e)
    {
        await AppHost!.StopAsync();

        base.OnExit(e);
    }
}
