using System;

namespace RealEstate.BusinessObjects
{
	public class Companys
	{
		#region ***** Fields & Properties ***** 
		private int _CompanyID;
		public int CompanyID
		{ 
			get 
			{ 
				return _CompanyID;
			}
			set 
			{ 
				_CompanyID = value;
			}
		}
		private string _CompanyName;
		public string CompanyName
		{ 
			get 
			{ 
				return _CompanyName;
			}
			set 
			{ 
				_CompanyName = value;
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
		private string _HotLine;
		public string HotLine
		{ 
			get 
			{ 
				return _HotLine;
			}
			set 
			{ 
				_HotLine = value;
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
		private string _Fax;
		public string Fax
		{ 
			get 
			{ 
				return _Fax;
			}
			set 
			{ 
				_Fax = value;
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
		private string _Surrogate;
		public string Surrogate
		{ 
			get 
			{ 
				return _Surrogate;
			}
			set 
			{ 
				_Surrogate = value;
			}
		}
		private string _Chevron;
		public string Chevron
		{ 
			get 
			{ 
				return _Chevron;
			}
			set 
			{ 
				_Chevron = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public Companys()
		{
		}
		public Companys(int companyid)
		{
			this.CompanyID = companyid;
		}
		public Companys(int companyid, string companyname, string address, string hotline, string phonenumber, string fax, string email, string surrogate, string chevron)
		{
			this.CompanyID = companyid;
			this.CompanyName = companyname;
			this.Address = address;
			this.HotLine = hotline;
			this.PhoneNumber = phonenumber;
			this.Fax = fax;
			this.Email = email;
			this.Surrogate = surrogate;
			this.Chevron = chevron;
		}
		#endregion
	}
}
