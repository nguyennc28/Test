using System;

namespace RealEstate.BusinessObjects
{
	public class Pages
	{
		#region ***** Fields & Properties ***** 
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
		private string _Tag;
		public string Tag
		{ 
			get 
			{ 
				return _Tag;
			}
			set 
			{ 
				_Tag = value;
			}
		}
		private string _Conntent;
		public string Conntent
		{ 
			get 
			{ 
				return _Conntent;
			}
			set 
			{ 
				_Conntent = value;
			}
		}
		private string _Detail;
		public string Detail
		{ 
			get 
			{ 
				return _Detail;
			}
			set 
			{ 
				_Detail = value;
			}
		}
		private int _Level;
		public int Level
		{ 
			get 
			{ 
				return _Level;
			}
			set 
			{ 
				_Level = value;
			}
		}
		private string _Title;
		public string Title
		{ 
			get 
			{ 
				return _Title;
			}
			set 
			{ 
				_Title = value;
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
		private string _Keyword;
		public string Keyword
		{ 
			get 
			{ 
				return _Keyword;
			}
			set 
			{ 
				_Keyword = value;
			}
		}
		private string _Type;
		public string Type
		{ 
			get 
			{ 
				return _Type;
			}
			set 
			{ 
				_Type = value;
			}
		}
		private string _Link;
		public string Link
		{ 
			get 
			{ 
				return _Link;
			}
			set 
			{ 
				_Link = value;
			}
		}
		private string _Taget;
		public string Taget
		{ 
			get 
			{ 
				return _Taget;
			}
			set 
			{ 
				_Taget = value;
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
		private int _Index;
		public int Index
		{ 
			get 
			{ 
				return _Index;
			}
			set 
			{ 
				_Index = value;
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
		private string _Lang;
		public string Lang
		{ 
			get 
			{ 
				return _Lang;
			}
			set 
			{ 
				_Lang = value;
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
		public Pages()
		{
		}
		public Pages(int pageid)
		{
			this.PageID = pageid;
		}
		public Pages(int pageid, string name, string tag, string conntent, string detail, int level, string title, string description, string keyword, string type, string link, string taget, int position, int index, int active, string lang, int ord)
		{
			this.PageID = pageid;
			this.Name = name;
			this.Tag = tag;
			this.Conntent = conntent;
			this.Detail = detail;
			this.Level = level;
			this.Title = title;
			this.Description = description;
			this.Keyword = keyword;
			this.Type = type;
			this.Link = link;
			this.Taget = taget;
			this.Position = position;
			this.Index = index;
			this.Active = active;
			this.Lang = lang;
			this.Ord = ord;
		}
		#endregion
	}
}
