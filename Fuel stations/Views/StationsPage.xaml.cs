using Fuel_stations.ViewModels;

namespace Fuel_stations.Views;

public partial class Stations : ContentPage
{

	//private readonly StationVM _stationVM;

	public Stations(StationVM stationVM)
	{
		InitializeComponent();
		BindingContext = stationVM;

	}
}