using System;

namespace RealEstate.BusinessObjects
{
	public class City
	{
		#region ***** Fields & Properties ***** 
		private string _CityID;
		public string CityID
		{ 
			get 
			{ 
				return _CityID;
			}
			set 
			{ 
				_CityID = value;
			}
		}
		private string _CityName;
		public string CityName
		{ 
			get 
			{ 
				return _CityName;
			}
			set 
			{ 
				_CityName = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public City()
		{
		}
		public City(string cityid)
		{
			this.CityID = cityid;
		}
		public City(string cityid, string cityname)
		{
			this.CityID = cityid;
			this.CityName = cityname;
		}
		#endregion
	}
}
