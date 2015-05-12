using System;

namespace RealEstate.BusinessObjects
{
	public class Customers
	{
		#region ***** Fields & Properties ***** 
		private int _CustomerID;
		public int CustomerID
		{ 
			get 
			{ 
				return _CustomerID;
			}
			set 
			{ 
				_CustomerID = value;
			}
		}
		private string _UserName;
		public string UserName
		{ 
			get 
			{ 
				return _UserName;
			}
			set 
			{ 
				_UserName = value;
			}
		}
		private string _Password;
		public string Password
		{ 
			get 
			{ 
				return _Password;
			}
			set 
			{ 
				_Password = value;
			}
		}
		private string _FullName;
		public string FullName
		{ 
			get 
			{ 
				return _FullName;
			}
			set 
			{ 
				_FullName = value;
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
		public Customers()
		{
		}
		public Customers(int customerid)
		{
			this.CustomerID = customerid;
		}
		public Customers(int customerid, string username, string password, string fullname, bool gender, string address, string identitycard, string mobilenumber, string homephone, string email)
		{
			this.CustomerID = customerid;
			this.UserName = username;
			this.Password = password;
			this.FullName = fullname;
			this.Gender = gender;
			this.Address = address;
			this.IdentityCard = identitycard;
			this.MobileNumber = mobilenumber;
			this.HomePhone = homephone;
			this.Email = email;
		}
		#endregion
	}
}
