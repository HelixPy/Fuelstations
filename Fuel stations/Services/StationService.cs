using Fuel_stations.Models;
using Fuel_stations.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel_stations.Services
{
	public class StationService
	{
		public static List<Station> GetStations()
		{
			return
			[
				new Station {
					DisplayName="AMFU OIL AND GAS", Address="24, Harriate lane, idah Kogi state",
					BranchManagerEmail="manager@gmail.com", LocalGovernmentArea="Idah", StateLocated="Kogi", 
					UserAccount="amfu@oil.com", GoogleMapsCoordinate="11011001", ID=1, IsOpen=true, Product1="PETROL", 
					Product2="DIESEL", Product3="KEROSINE", Product4="COOKING GAS"
				}
			];
		}
	}
}
