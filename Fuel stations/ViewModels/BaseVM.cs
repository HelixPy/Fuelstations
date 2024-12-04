using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.ComponentModel;

namespace Fuel_stations.ViewModels
{
	public partial class BaseVM : ObservableObject
	{
		[ObservableProperty]
		string title = string.Empty;

		[ObservableProperty]
		[NotifyPropertyChangedFor(nameof(IsNotLoading))]
		bool isLoading;

		public bool IsNotLoading => !IsLoading;
	}
}
