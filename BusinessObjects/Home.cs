using System;

namespace RealEstate.BusinessObjects
{
	public class Home
	{
		#region ***** Fields & Properties ***** 
		private int _HomeID;
		public int HomeID
		{ 
			get 
			{ 
				return _HomeID;
			}
			set 
			{ 
				_HomeID = value;
			}
		}
		private int _HomeTypeID;
		public int HomeTypeID
		{ 
			get 
			{ 
				return _HomeTypeID;
			}
			set 
			{ 
				_HomeTypeID = value;
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
		private double _FloorArea;
		public double FloorArea
		{ 
			get 
			{ 
				return _FloorArea;
			}
			set 
			{ 
				_FloorArea = value;
			}
		}
		private double _GargenArea;
		public double GargenArea
		{ 
			get 
			{ 
				return _GargenArea;
			}
			set 
			{ 
				_GargenArea = value;
			}
		}
		private double _HomeArea;
		public double HomeArea
		{ 
			get 
			{ 
				return _HomeArea;
			}
			set 
			{ 
				_HomeArea = value;
			}
		}
		private Byte _BedroomNumber;
		public Byte BedroomNumber
		{ 
			get 
			{ 
				return _BedroomNumber;
			}
			set 
			{ 
				_BedroomNumber = value;
			}
		}
		private Byte _TierNumber;
		public Byte TierNumber
		{ 
			get 
			{ 
				return _TierNumber;
			}
			set 
			{ 
				_TierNumber = value;
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
		private string _Image3;
		public string Image3
		{ 
			get 
			{ 
				return _Image3;
			}
			set 
			{ 
				_Image3 = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public Home()
		{
		}
		public Home(int homeid)
		{
			this.HomeID = homeid;
		}
		public Home(int homeid, int hometypeid, int realestateownersid, int realestateownerstypeid, int realestateid, string description, string address, double price, double totalarea, double floorarea, double gargenarea, double homearea, Byte bedroomnumber, Byte tiernumber, string image1, string image2, string image3)
		{
			this.HomeID = homeid;
			this.HomeTypeID = hometypeid;
			this.RealEstateOwnersID = realestateownersid;
			this.RealEstateOwnersTypeID = realestateownerstypeid;
			this.RealEstateID = realestateid;
			this.Description = description;
			this.Address = address;
			this.Price = price;
			this.TotalArea = totalarea;
			this.FloorArea = floorarea;
			this.GargenArea = gargenarea;
			this.HomeArea = homearea;
			this.BedroomNumber = bedroomnumber;
			this.TierNumber = tiernumber;
			this.Image1 = image1;
			this.Image2 = image2;
			this.Image3 = image3;
		}
		#endregion
	}
}
