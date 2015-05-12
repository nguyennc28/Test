using System;

namespace RealEstate.BusinessObjects
{
	public class Group
	{
		#region ***** Fields & Properties ***** 
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
		private int _ParentID;
		public int ParentID
		{ 
			get 
			{ 
				return _ParentID;
			}
			set 
			{ 
				_ParentID = value;
			}
		}
		private string _GroupName;
		public string GroupName
		{ 
			get 
			{ 
				return _GroupName;
			}
			set 
			{ 
				_GroupName = value;
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
		private int _Priority;
		public int Priority
		{ 
			get 
			{ 
				return _Priority;
			}
			set 
			{ 
				_Priority = value;
			}
		}
		private string _SwitchGroup;
		public string SwitchGroup
		{ 
			get 
			{ 
				return _SwitchGroup;
			}
			set 
			{ 
				_SwitchGroup = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public Group()
		{
		}
		public Group(int groupid)
		{
			this.GroupID = groupid;
		}
		public Group(int groupid, int parentid, string groupname, string description, Byte status, int priority, string switchgroup)
		{
			this.GroupID = groupid;
			this.ParentID = parentid;
			this.GroupName = groupname;
			this.Description = description;
			this.Status = status;
			this.Priority = priority;
			this.SwitchGroup = switchgroup;
		}
		#endregion
	}
}
