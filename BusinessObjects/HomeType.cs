using System;

namespace RealEstate.BusinessObjects
{
	public class HomeType
	{
		#region ***** Fields & Properties ***** 
		private int _HomeTypeID;
		public int HomeTypeID
		{ 
			get 
			{ 
				return _HomeTypeID;
			}
			set 
			{ 
				_HomeTypeID = value;
			}
		}
		private string _HomeTypeName;
		public string HomeTypeName
		{ 
			get 
			{ 
				return _HomeTypeName;
			}
			set 
			{ 
				_HomeTypeName = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public HomeType()
		{
		}
		public HomeType(int hometypeid)
		{
			this.HomeTypeID = hometypeid;
		}
		public HomeType(int hometypeid, string hometypename)
		{
			this.HomeTypeID = hometypeid;
			this.HomeTypeName = hometypename;
		}
		#endregion
	}
}
