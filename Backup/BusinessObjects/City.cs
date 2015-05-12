using System;

namespace RealEstate.BusinessObjects
{
	public class City
	{
		#region ***** Fields & Properties ***** 
		private int _CityID;
		public int CityID
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
		public City(int cityid)
		{
			this.CityID = cityid;
		}
		public City(int cityid, string cityname)
		{
			this.CityID = cityid;
			this.CityName = cityname;
		}
		#endregion
	}
}
