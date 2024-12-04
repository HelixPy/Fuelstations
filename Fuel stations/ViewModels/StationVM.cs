using CommunityToolkit.Mvvm.Input;
using Fuel_stations.Models;
using Fuel_stations.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel_stations.ViewModels
{
	public partial class StationVM : BaseVM
	{
		private readonly StationService _stationService;

		public ObservableCollection<Station> StationsList { get; private set; }

        public StationVM(StationService stationService)
        {
            Title = "Fuel Stations";
            this._stationService = stationService;
        }

        [RelayCommand]
        async Task GetStationsAsync()
        {
            if(IsLoading) return;
            try
            {
                IsLoading = true;
                if (StationsList.Any())
                {
                    StationsList.Clear();

                    var stations = StationService.GetStations();

                    foreach (Station station in stations)
                    {
                        StationsList.Add(station);
                    }
                }
            }
            catch (Exception ex) 
            {
                Debug.WriteLine($"Unable to get stations {ex.Message}");
                await Shell.Current.DisplayAlert("Something happened", "Unable to load stations, swipe downwards to refresh", "Ok");
            }
            finally
            {
                IsLoading = false;
            }
        }
        
    }
}
