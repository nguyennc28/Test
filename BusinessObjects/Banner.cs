using System;

namespace RealEstate.BusinessObjects
{
	public class Banner
	{
		#region ***** Fields & Properties ***** 
		private int _BannerID;
		public int BannerID
		{ 
			get 
			{ 
				return _BannerID;
			}
			set 
			{ 
				_BannerID = value;
			}
		}
		private string _BannerType;
		public string BannerType
		{ 
			get 
			{ 
				return _BannerType;
			}
			set 
			{ 
				_BannerType = value;
			}
		}
		private string _Size;
		public string Size
		{ 
			get 
			{ 
				return _Size;
			}
			set 
			{ 
				_Size = value;
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
		private string _Images;
		public string Images
		{ 
			get 
			{ 
				return _Images;
			}
			set 
			{ 
				_Images = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public Banner()
		{
		}
		public Banner(int bannerid)
		{
			this.BannerID = bannerid;
		}
		public Banner(int bannerid, string bannertype, string size, string description, string images)
		{
			this.BannerID = bannerid;
			this.BannerType = bannertype;
			this.Size = size;
			this.Description = description;
			this.Images = images;
		}
		#endregion
	}
}
