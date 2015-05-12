using System;

namespace RealEstate.BusinessObjects
{
	public class Controls
	{
		#region ***** Fields & Properties ***** 
		private int _ControlID;
		public int ControlID
		{ 
			get 
			{ 
				return _ControlID;
			}
			set 
			{ 
				_ControlID = value;
			}
		}
		private int _PageId;
		public int PageId
		{ 
			get 
			{ 
				return _PageId;
			}
			set 
			{ 
				_PageId = value;
			}
		}
		private string _Name;
		public string Name
		{ 
			get 
			{ 
				return _Name;
			}
			set 
			{ 
				_Name = value;
			}
		}
		private string _Path;
		public string Path
		{ 
			get 
			{ 
				return _Path;
			}
			set 
			{ 
				_Path = value;
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
		#endregion

		#region ***** Init Methods ***** 
		public Controls()
		{
		}
		public Controls(int controlid)
		{
			this.ControlID = controlid;
		}
		public Controls(int controlid, int pageid, string name, string path, string param, Int64 status, int priority)
		{
			this.ControlID = controlid;
			this.PageId = pageid;
			this.Name = name;
			this.Path = path;
			this.Param = param;
			this.Status = status;
			this.Priority = priority;
		}
		#endregion
	}
}
