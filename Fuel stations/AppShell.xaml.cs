
using Fuel_stations.Views;

namespace Fuel_stations;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(AutoShop), typeof(AutoShop));
		Routing.RegisterRoute(nameof(Tips), typeof(Tips));
		Routing.RegisterRoute(nameof(Stations), typeof(Stations));
		Routing.RegisterRoute(nameof(FavoriteStations), typeof(FavoriteStations));
		Routing.RegisterRoute(nameof(Profile), typeof(Profile));

	}
}
