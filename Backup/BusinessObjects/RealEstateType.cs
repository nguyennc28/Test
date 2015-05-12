using System;

namespace RealEstate.BusinessObjects
{
	public class RealEstateType
	{
		#region ***** Fields & Properties ***** 
		private int _RealEstateTypeID;
		public int RealEstateTypeID
		{ 
			get 
			{ 
				return _RealEstateTypeID;
			}
			set 
			{ 
				_RealEstateTypeID = value;
			}
		}
		private string _NameRealEstateType;
		public string NameRealEstateType
		{ 
			get 
			{ 
				return _NameRealEstateType;
			}
			set 
			{ 
				_NameRealEstateType = value;
			}
		}
		private string _Description;
		public string Description
		{ 
			get 
			{ 
				return _Description;
			}
			set 
			{ 
				_Description = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public RealEstateType()
		{
		}
		public RealEstateType(int realestatetypeid)
		{
			this.RealEstateTypeID = realestatetypeid;
		}
		public RealEstateType(int realestatetypeid, string namerealestatetype, string description)
		{
			this.RealEstateTypeID = realestatetypeid;
			this.NameRealEstateType = namerealestatetype;
			this.Description = description;
		}
		#endregion
	}
}
