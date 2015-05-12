using System;

namespace RealEstate.BusinessObjects
{
	public class Users
	{
		#region ***** Fields & Properties ***** 
		private string _UserID;
		public string UserID
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
		private string _Role;
		public string Role
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
		private string _GroupID;
		public string GroupID
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
		private string _Active;
		public string Active
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
		private string _Ord;
		public string Ord
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

	    private string _Level;

	    public string Level
	    {
            get { return _Admin; }
	        set { _Admin = value; }
	    }

        private string _Admin;

        public string Admin
        {
            get { return _Admin; }
            set { _Admin = value; }
        }
		#endregion

		#region ***** Init Methods ***** 
		public Users()
		{
		}
		public Users(string userid)
		{
			this.UserID = userid;
		}
		public Users(string userid, string username, string password, string fullname, string role, bool gender, string avatar, DateTime birthday, string email, string address, string mobilephone, string identitycard, DateTime lastloggedon, DateTime createddate, string groupid, string active, string ord, string level, string admin)
		{
			this.UserID = userid;
			this.UserName = username;
			this.Password = password;
			this.FullName = fullname;
			this.Role = role;
			this.Gender = gender;
			this.Avatar = avatar;
			this.Birthday = birthday;
			this.Email = email;
			this.Address = address;
			this.MobilePhone = mobilephone;
			this.IdentityCard = identitycard;
			this.LastLoggedOn = lastloggedon;
			this.CreatedDate = createddate;
			this.GroupID = groupid;
			this.Active = active;
			this.Ord = ord;
		    this.Level = level;
		    this.Admin = admin;
		}
		#endregion
	}
}
