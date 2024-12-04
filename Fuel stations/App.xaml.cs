using Fuel_stations.Views;

namespace Fuel_stations
{
	public partial class App : Application
	{
		public App(Stations station)
		{
			InitializeComponent();

			station = new AppShell();
		}

		//public AppShell Stations { get; }
	}
}
