using System;

namespace RealEstate.BusinessObjects
{
	public class Land
	{
		#region ***** Fields & Properties ***** 
		private int _LandID;
		public int LandID
		{ 
			get 
			{ 
				return _LandID;
			}
			set 
			{ 
				_LandID = value;
			}
		}
		private int _LandTypeID;
		public int LandTypeID
		{ 
			get 
			{ 
				return _LandTypeID;
			}
			set 
			{ 
				_LandTypeID = value;
			}
		}
		private int _RealEstateOwnersID;
		public int RealEstateOwnersID
		{ 
			get 
			{ 
				return _RealEstateOwnersID;
			}
			set 
			{ 
				_RealEstateOwnersID = value;
			}
		}
		private int _RealEstateOwnersTypeID;
		public int RealEstateOwnersTypeID
		{ 
			get 
			{ 
				return _RealEstateOwnersTypeID;
			}
			set 
			{ 
				_RealEstateOwnersTypeID = value;
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
		private double _Price;
		public double Price
		{ 
			get 
			{ 
				return _Price;
			}
			set 
			{ 
				_Price = value;
			}
		}
		private double _TotalArea;
		public double TotalArea
		{ 
			get 
			{ 
				return _TotalArea;
			}
			set 
			{ 
				_TotalArea = value;
			}
		}
		private string _Image1;
		public string Image1
		{ 
			get 
			{ 
				return _Image1;
			}
			set 
			{ 
				_Image1 = value;
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
		public Land()
		{
		}
		public Land(int landid)
		{
			this.LandID = landid;
		}
		public Land(int landid, int landtypeid, int realestateownersid, int realestateownerstypeid, int realestateid, string description, string address, double price, double totalarea, string image1, string image2)
		{
			this.LandID = landid;
			this.LandTypeID = landtypeid;
			this.RealEstateOwnersID = realestateownersid;
			this.RealEstateOwnersTypeID = realestateownerstypeid;
			this.RealEstateID = realestateid;
			this.Description = description;
			this.Address = address;
			this.Price = price;
			this.TotalArea = totalarea;
			this.Image1 = image1;
			this.Image2 = image2;
		}
		#endregion
	}
}
