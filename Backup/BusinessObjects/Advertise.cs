using System;

namespace RealEstate.BusinessObjects
{
	public class Advertise
	{
		#region ***** Fields & Properties ***** 
		private int _AdvID;
		public int AdvID
		{ 
			get 
			{ 
				return _AdvID;
			}
			set 
			{ 
				_AdvID = value;
			}
		}
		private string _AdvName;
		public string AdvName
		{ 
			get 
			{ 
				return _AdvName;
			}
			set 
			{ 
				_AdvName = value;
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
		private int _Width;
		public int Width
		{ 
			get 
			{ 
				return _Width;
			}
			set 
			{ 
				_Width = value;
			}
		}
		private int _Height;
		public int Height
		{ 
			get 
			{ 
				return _Height;
			}
			set 
			{ 
				_Height = value;
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
		private string _Target;
		public string Target
		{ 
			get 
			{ 
				return _Target;
			}
			set 
			{ 
				_Target = value;
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
		private int _Click;
		public int Click
		{ 
			get 
			{ 
				return _Click;
			}
			set 
			{ 
				_Click = value;
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
		private bool _Active;
		public bool Active
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
		#endregion

		#region ***** Init Methods ***** 
		public Advertise()
		{
		}
		public Advertise(int advid)
		{
			this.AdvID = advid;
		}
		public Advertise(int advid, string advname, string image, int width, int height, string link, string target, string content, int position, int pageid, int click, int ord, bool active, string lang)
		{
			this.AdvID = advid;
			this.AdvName = advname;
			this.Image = image;
			this.Width = width;
			this.Height = height;
			this.Link = link;
			this.Target = target;
			this.Content = content;
			this.Position = position;
			this.PageID = pageid;
			this.Click = click;
			this.Ord = ord;
			this.Active = active;
			this.Lang = lang;
		}
		#endregion
	}
}
