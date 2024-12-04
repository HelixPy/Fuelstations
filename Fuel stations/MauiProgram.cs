using Fuel_stations.Services;
using Fuel_stations.ViewModels;
using Fuel_stations.Views;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace Fuel_stations
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            }).UseMauiCommunityToolkit();
#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<StationService>();
            builder.Services.AddTransient<StationVM>();
            builder.Services.AddTransient<Stations>();
            return builder.Build();
        }
    }
}