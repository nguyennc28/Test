using System;

namespace RealEstate.BusinessObjects
{
	public class RealEstateOwnersType
	{
		#region ***** Fields & Properties ***** 
		private int _RealEstateOwnersTypeID;
		public int RealEstateOwnersTypeID
		{ 
			get 
			{ 
				return _RealEstateOwnersTypeID;
			}
			set 
			{ 
				_RealEstateOwnersTypeID = value;
			}
		}
		private string _RealEstateOwnersTypeName;
		public string RealEstateOwnersTypeName
		{ 
			get 
			{ 
				return _RealEstateOwnersTypeName;
			}
			set 
			{ 
				_RealEstateOwnersTypeName = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public RealEstateOwnersType()
		{
		}
		public RealEstateOwnersType(int realestateownerstypeid)
		{
			this.RealEstateOwnersTypeID = realestateownerstypeid;
		}
		public RealEstateOwnersType(int realestateownerstypeid, string realestateownerstypename)
		{
			this.RealEstateOwnersTypeID = realestateownerstypeid;
			this.RealEstateOwnersTypeName = realestateownerstypename;
		}
		#endregion
	}
}
