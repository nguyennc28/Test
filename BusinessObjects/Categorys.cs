using System;

namespace RealEstate.BusinessObjects
{
	public class Categorys
	{
		#region ***** Fields & Properties ***** 
		private int _CategoryID;
		public int CategoryID
		{ 
			get 
			{ 
				return _CategoryID;
			}
			set 
			{ 
				_CategoryID = value;
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
		private string _Content;
		public string Content
		{ 
			get 
			{ 
				return _Content;
			}
			set 
			{ 
				_Content = value;
			}
		}
		private string _Level;
		public string Level
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
		private string _Image;
		public string Image
		{ 
			get 
			{ 
				return _Image;
			}
			set 
			{ 
				_Image = value;
			}
		}
		private string _Image2;
		public string Image2
		{ 
			get 
			{ 
				return _Image2;
			}
			set 
			{ 
				_Image2 = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public Categorys()
		{
		}
		public Categorys(int categoryid)
		{
			this.CategoryID = categoryid;
		}
		public Categorys(int categoryid, string tag, string name, string content, string level, int priority, int index, string title, string description, string keyword, int active, int ord, string lang, string image, string image2)
		{
			this.CategoryID = categoryid;
			this.Tag = tag;
			this.Name = name;
			this.Content = content;
			this.Level = level;
			this.Priority = priority;
			this.Index = index;
			this.Title = title;
			this.Description = description;
			this.Keyword = keyword;
			this.Active = active;
			this.Ord = ord;
			this.Lang = lang;
			this.Image = image;
			this.Image2 = image2;
		}
		#endregion
	}
}
