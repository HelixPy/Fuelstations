using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel_stations.Models
{
	public class Station
	{
		public int ID { get; set; }

		public string DisplayName { get; set; } = string.Empty;

		public string Address { get; set; } = string.Empty;

		public string UserAccount { get; set; } = string.Empty;

		public string BranchManagerEmail { get; set; } = string.Empty;

		public string LocalGovernmentArea { get; set; } = string.Empty;

		public string StateLocated { get; set; } = string.Empty;

		public string GoogleMapsCoordinate {  get; set; } = string.Empty;

		public bool IsOpen { get; set; }

		public string Product1 { get; set; } = string.Empty;

		public string Product2 { get; set; } = string.Empty;

		public string Product3 { get; set; } = string.Empty;

		public string Product4 { get; set; } = string.Empty;

		public string Product5 { get; set; } = string.Empty;

	}
}
