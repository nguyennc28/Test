using System;

namespace RealEstate.BusinessObjects
{
	public class RealEstateOwners
	{
		#region ***** Fields & Properties ***** 
		private int _RealEstateOwnersID;
		public int RealEstateOwnersID
		{ 
			get 
			{ 
				return _RealEstateOwnersID;
			}
			set 
			{ 
				_RealEstateOwnersID = value;
			}
		}
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
		private string _RealEstateOwnersName;
		public string RealEstateOwnersName
		{ 
			get 
			{ 
				return _RealEstateOwnersName;
			}
			set 
			{ 
				_RealEstateOwnersName = value;
			}
		}
		private Byte _CLUR;
		public Byte CLUR
		{ 
			get 
			{ 
				return _CLUR;
			}
			set 
			{ 
				_CLUR = value;
			}
		}
		private string _Address;
		public string Address
		{ 
			get 
			{ 
				return _Address;
			}
			set 
			{ 
				_Address = value;
			}
		}
		private string _MobileNumber;
		public string MobileNumber
		{ 
			get 
			{ 
				return _MobileNumber;
			}
			set 
			{ 
				_MobileNumber = value;
			}
		}
		private string _Email;
		public string Email
		{ 
			get 
			{ 
				return _Email;
			}
			set 
			{ 
				_Email = value;
			}
		}
		private bool _Gender;
		public bool Gender
		{ 
			get 
			{ 
				return _Gender;
			}
			set 
			{ 
				_Gender = value;
			}
		}
		private string _IdentityCard;
		public string IdentityCard
		{ 
			get 
			{ 
				return _IdentityCard;
			}
			set 
			{ 
				_IdentityCard = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public RealEstateOwners()
		{
		}
		public RealEstateOwners(int realestateownersid)
		{
			this.RealEstateOwnersID = realestateownersid;
		}
		public RealEstateOwners(int realestateownersid, int realestateownerstypeid, string realestateownersname, Byte clur, string address, string mobilenumber, string email, bool gender, string identitycard)
		{
			this.RealEstateOwnersID = realestateownersid;
			this.RealEstateOwnersTypeID = realestateownerstypeid;
			this.RealEstateOwnersName = realestateownersname;
			this.CLUR = clur;
			this.Address = address;
			this.MobileNumber = mobilenumber;
			this.Email = email;
			this.Gender = gender;
			this.IdentityCard = identitycard;
		}
		#endregion
	}
}
