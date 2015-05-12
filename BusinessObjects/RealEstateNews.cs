using System;

namespace RealEstate.BusinessObjects
{
	public class RealEstateNews
	{
		#region ***** Fields & Properties ***** 
		private int _RealEstateNewsID;
		public int RealEstateNewsID
		{ 
			get 
			{ 
				return _RealEstateNewsID;
			}
			set 
			{ 
				_RealEstateNewsID = value;
			}
		}
		private int _RealEstateID;
		public int RealEstateID
		{ 
			get 
			{ 
				return _RealEstateID;
			}
			set 
			{ 
				_RealEstateID = value;
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
		private DateTime _CreateDate;
		public DateTime CreateDate
		{ 
			get 
			{ 
				return _CreateDate;
			}
			set 
			{ 
				_CreateDate = value;
			}
		}
		private DateTime _CreateBy;
		public DateTime CreateBy
		{ 
			get 
			{ 
				return _CreateBy;
			}
			set 
			{ 
				_CreateBy = value;
			}
		}
		private string _Source;
		public string Source
		{ 
			get 
			{ 
				return _Source;
			}
			set 
			{ 
				_Source = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public RealEstateNews()
		{
		}
		public RealEstateNews(int realestatenewsid)
		{
			this.RealEstateNewsID = realestatenewsid;
		}
		public RealEstateNews(int realestatenewsid, int realestateid, string title, string content, int categoryid, string images, DateTime createdate, DateTime createby, string source)
		{
			this.RealEstateNewsID = realestatenewsid;
			this.RealEstateID = realestateid;
			this.Title = title;
			this.Content = content;
			this.CategoryID = categoryid;
			this.Images = images;
			this.CreateDate = createdate;
			this.CreateBy = createby;
			this.Source = source;
		}
		#endregion
	}
}
