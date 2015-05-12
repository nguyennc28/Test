using System;

namespace RealEstate.BusinessObjects
{
	public class District
	{
		#region ***** Fields & Properties ***** 
		private int _DistrictID;
		public int DistrictID
		{ 
			get 
			{ 
				return _DistrictID;
			}
			set 
			{ 
				_DistrictID = value;
			}
		}
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
		private string _DistrictName;
		public string DistrictName
		{ 
			get 
			{ 
				return _DistrictName;
			}
			set 
			{ 
				_DistrictName = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public District()
		{
		}
		public District(int districtid)
		{
			this.DistrictID = districtid;
		}
		public District(int districtid, int cityid, string districtname)
		{
			this.DistrictID = districtid;
			this.CityID = cityid;
			this.DistrictName = districtname;
		}
		#endregion
	}
}
