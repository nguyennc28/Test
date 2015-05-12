using System;

namespace RealEstate.BusinessObjects
{
	public class Staff
	{
		#region ***** Fields & Properties ***** 
		private int _StaffID;
		public int StaffID
		{ 
			get 
			{ 
				return _StaffID;
			}
			set 
			{ 
				_StaffID = value;
			}
		}
		private string _Fullname;
		public string Fullname
		{ 
			get 
			{ 
				return _Fullname;
			}
			set 
			{ 
				_Fullname = value;
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
		private string _IdNumber;
		public string IdNumber
		{ 
			get 
			{ 
				return _IdNumber;
			}
			set 
			{ 
				_IdNumber = value;
			}
		}
		private string _PhoneNumber;
		public string PhoneNumber
		{ 
			get 
			{ 
				return _PhoneNumber;
			}
			set 
			{ 
				_PhoneNumber = value;
			}
		}
		private string _HomePhone;
		public string HomePhone
		{ 
			get 
			{ 
				return _HomePhone;
			}
			set 
			{ 
				_HomePhone = value;
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
		#endregion

		#region ***** Init Methods ***** 
		public Staff()
		{
		}
		public Staff(int staffid)
		{
			this.StaffID = staffid;
		}
		public Staff(int staffid, string fullname, bool gender, string address, string idnumber, string phonenumber, string homephone, string email)
		{
			this.StaffID = staffid;
			this.Fullname = fullname;
			this.Gender = gender;
			this.Address = address;
			this.IdNumber = idnumber;
			this.PhoneNumber = phonenumber;
			this.HomePhone = homephone;
			this.Email = email;
		}
		#endregion
	}
}
