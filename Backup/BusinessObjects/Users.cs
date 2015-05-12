using System;

namespace RealEstate.BusinessObjects
{
	public class Users
	{
		#region ***** Fields & Properties ***** 
		private int _UserID;
		public int UserID
		{ 
			get 
			{ 
				return _UserID;
			}
			set 
			{ 
				_UserID = value;
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
		private int _Role;
		public int Role
		{ 
			get 
			{ 
				return _Role;
			}
			set 
			{ 
				_Role = value;
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
		private string _Avatar;
		public string Avatar
		{ 
			get 
			{ 
				return _Avatar;
			}
			set 
			{ 
				_Avatar = value;
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
		private DateTime _Birthday;
		public DateTime Birthday
		{ 
			get 
			{ 
				return _Birthday;
			}
			set 
			{ 
				_Birthday = value;
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
		private string _MobilePhone;
		public string MobilePhone
		{ 
			get 
			{ 
				return _MobilePhone;
			}
			set 
			{ 
				_MobilePhone = value;
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
		private Byte _Status;
		public Byte Status
		{ 
			get 
			{ 
				return _Status;
			}
			set 
			{ 
				_Status = value;
			}
		}
		private DateTime _LastLoggedOn;
		public DateTime LastLoggedOn
		{ 
			get 
			{ 
				return _LastLoggedOn;
			}
			set 
			{ 
				_LastLoggedOn = value;
			}
		}
		private DateTime _CreatedDate;
		public DateTime CreatedDate
		{ 
			get 
			{ 
				return _CreatedDate;
			}
			set 
			{ 
				_CreatedDate = value;
			}
		}
		private int _CreatedBy;
		public int CreatedBy
		{ 
			get 
			{ 
				return _CreatedBy;
			}
			set 
			{ 
				_CreatedBy = value;
			}
		}
		private bool _IsFirstLogin;
		public bool IsFirstLogin
		{ 
			get 
			{ 
				return _IsFirstLogin;
			}
			set 
			{ 
				_IsFirstLogin = value;
			}
		}
		private int _GroupID;
		public int GroupID
		{ 
			get 
			{ 
				return _GroupID;
			}
			set 
			{ 
				_GroupID = value;
			}
		}
		private int _Active;
		public int Active
		{ 
			get 
			{ 
				return _Active;
			}
			set 
			{ 
				_Active = value;
			}
		}
		private int _Ord;
		public int Ord
		{ 
			get 
			{ 
				return _Ord;
			}
			set 
			{ 
				_Ord = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public Users()
		{
		}
		public Users(int userid)
		{
			this.UserID = userid;
		}
		public Users(int userid, string username, string password, string fullname, int role, bool gender, string avatar, string companyname, DateTime birthday, string email, string address, string mobilephone, string homephone, string identitycard, Byte status, DateTime lastloggedon, DateTime createddate, int createdby, bool isfirstlogin, int groupid, int active, int ord)
		{
			this.UserID = userid;
			this.UserName = username;
			this.Password = password;
			this.FullName = fullname;
			this.Role = role;
			this.Gender = gender;
			this.Avatar = avatar;
			this.CompanyName = companyname;
			this.Birthday = birthday;
			this.Email = email;
			this.Address = address;
			this.MobilePhone = mobilephone;
			this.HomePhone = homephone;
			this.IdentityCard = identitycard;
			this.Status = status;
			this.LastLoggedOn = lastloggedon;
			this.CreatedDate = createddate;
			this.CreatedBy = createdby;
			this.IsFirstLogin = isfirstlogin;
			this.GroupID = groupid;
			this.Active = active;
			this.Ord = ord;
		}
		#endregion
	}
}
