using System;

namespace RealEstate.BusinessObjects
{
	public class Motel
	{
		#region ***** Fields & Properties ***** 
		private int _MotelID;
		public int MotelID
		{ 
			get 
			{ 
				return _MotelID;
			}
			set 
			{ 
				_MotelID = value;
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
		private int _MotelTypeID;
		public int MotelTypeID
		{ 
			get 
			{ 
				return _MotelTypeID;
			}
			set 
			{ 
				_MotelTypeID = value;
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
		private bool _IsClosed;
		public bool IsClosed
		{ 
			get 
			{ 
				return _IsClosed;
			}
			set 
			{ 
				_IsClosed = value;
			}
		}
		private bool _IsCooker;
		public bool IsCooker
		{ 
			get 
			{ 
				return _IsCooker;
			}
			set 
			{ 
				_IsCooker = value;
			}
		}
		private string _Furniture;
		public string Furniture
		{ 
			get 
			{ 
				return _Furniture;
			}
			set 
			{ 
				_Furniture = value;
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
		public Motel()
		{
		}
		public Motel(int motelid)
		{
			this.MotelID = motelid;
		}
		public Motel(int motelid, int realestateownersid, int realestateownerstypeid, int realestateid, int moteltypeid, string description, string address, double price, double totalarea, bool isclosed, bool iscooker, string furniture, Byte tiernumber, string image1, string image2, string image3)
		{
			this.MotelID = motelid;
			this.RealEstateOwnersID = realestateownersid;
			this.RealEstateOwnersTypeID = realestateownerstypeid;
			this.RealEstateID = realestateid;
			this.MotelTypeID = moteltypeid;
			this.Description = description;
			this.Address = address;
			this.Price = price;
			this.TotalArea = totalarea;
			this.IsClosed = isclosed;
			this.IsCooker = iscooker;
			this.Furniture = furniture;
			this.TierNumber = tiernumber;
			this.Image1 = image1;
			this.Image2 = image2;
			this.Image3 = image3;
		}
		#endregion
	}
}
