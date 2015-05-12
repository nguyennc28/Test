using System;

namespace RealEstate.BusinessObjects
{
	public class LandType
	{
		#region ***** Fields & Properties ***** 
		private int _LandTypeID;
		public int LandTypeID
		{ 
			get 
			{ 
				return _LandTypeID;
			}
			set 
			{ 
				_LandTypeID = value;
			}
		}
		private string _LandTypeName;
		public string LandTypeName
		{ 
			get 
			{ 
				return _LandTypeName;
			}
			set 
			{ 
				_LandTypeName = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public LandType()
		{
		}
		public LandType(int landtypeid)
		{
			this.LandTypeID = landtypeid;
		}
		public LandType(int landtypeid, string landtypename)
		{
			this.LandTypeID = landtypeid;
			this.LandTypeName = landtypename;
		}
		#endregion
	}
}
