using System;

namespace RealEstate.BusinessObjects
{
	public class Region
	{
		#region ***** Fields & Properties ***** 
		private int _RegionID;
		public int RegionID
		{ 
			get 
			{ 
				return _RegionID;
			}
			set 
			{ 
				_RegionID = value;
			}
		}
		private string _RegionName;
		public string RegionName
		{ 
			get 
			{ 
				return _RegionName;
			}
			set 
			{ 
				_RegionName = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public Region()
		{
		}
		public Region(int regionid)
		{
			this.RegionID = regionid;
		}
		public Region(int regionid, string regionname)
		{
			this.RegionID = regionid;
			this.RegionName = regionname;
		}
		#endregion
	}
}
