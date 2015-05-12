using System;

namespace RealEstate.BusinessObjects
{
	public class Menus
	{
		#region ***** Fields & Properties ***** 
		private int _MenuID;
		public int MenuID
		{ 
			get 
			{ 
				return _MenuID;
			}
			set 
			{ 
				_MenuID = value;
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
		private int _PageID;
		public int PageID
		{ 
			get 
			{ 
				return _PageID;
			}
			set 
			{ 
				_PageID = value;
			}
		}
		private string _MenuName;
		public string MenuName
		{ 
			get 
			{ 
				return _MenuName;
			}
			set 
			{ 
				_MenuName = value;
			}
		}
		private int _Position;
		public int Position
		{ 
			get 
			{ 
				return _Position;
			}
			set 
			{ 
				_Position = value;
			}
		}
		private Int64 _Status;
		public Int64 Status
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
		private string _Param;
		public string Param
		{ 
			get 
			{ 
				return _Param;
			}
			set 
			{ 
				_Param = value;
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
		#endregion

		#region ***** Init Methods ***** 
		public Menus()
		{
		}
		public Menus(int menuid)
		{
			this.MenuID = menuid;
		}
		public Menus(int menuid, int parentid, int pageid, string menuname, int position, Int64 status, int priority, string param, int groupid)
		{
			this.MenuID = menuid;
			this.ParentID = parentid;
			this.PageID = pageid;
			this.MenuName = menuname;
			this.Position = position;
			this.Status = status;
			this.Priority = priority;
			this.Param = param;
			this.GroupID = groupid;
		}
		#endregion
	}
}
