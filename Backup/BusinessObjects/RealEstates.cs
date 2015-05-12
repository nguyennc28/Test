using System;

namespace RealEstate.BusinessObjects
{
	public class RealEstates
	{
		#region ***** Fields & Properties ***** 
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
		private string _RealEstateName;
		public string RealEstateName
		{ 
			get 
			{ 
				return _RealEstateName;
			}
			set 
			{ 
				_RealEstateName = value;
			}
		}
		private int _RealEstateTypeID;
		public int RealEstateTypeID
		{ 
			get 
			{ 
				return _RealEstateTypeID;
			}
			set 
			{ 
				_RealEstateTypeID = value;
			}
		}
		private int _LocationID;
		public int LocationID
		{ 
			get 
			{ 
				return _LocationID;
			}
			set 
			{ 
				_LocationID = value;
			}
		}
		private int _CityID;
		public int CityID
		{ 
			get 
			{ 
				return _CityID;
			}
			set 
			{ 
				_CityID = value;
			}
		}
		private int _RegionID;
		public int RegionID
		{ 
			get 
			{ 
				return _RegionID;
			}
			set 
			{ 
				_RegionID = value;
			}
		}
		private int _DistrictID;
		public int DistrictID
		{ 
			get 
			{ 
				return _DistrictID;
			}
			set 
			{ 
				_DistrictID = value;
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
		private int _Address;
		public int Address
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
		private string _CreateBy;
		public string CreateBy
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
		private double _Area;
		public double Area
		{ 
			get 
			{ 
				return _Area;
			}
			set 
			{ 
				_Area = value;
			}
		}
		private double _Lengh;
		public double Lengh
		{ 
			get 
			{ 
				return _Lengh;
			}
			set 
			{ 
				_Lengh = value;
			}
		}
		private double _Width;
		public double Width
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
		private double _Height;
		public double Height
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
		private Byte _Status;
		public Byte Status
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
		private Byte _IsVip;
		public Byte IsVip
		{ 
			get 
			{ 
				return _IsVip;
			}
			set 
			{ 
				_IsVip = value;
			}
		}
		private DateTime _Period;
		public DateTime Period
		{ 
			get 
			{ 
				return _Period;
			}
			set 
			{ 
				_Period = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public RealEstates()
		{
		}
		public RealEstates(int realestateid)
		{
			this.RealEstateID = realestateid;
		}
		public RealEstates(int realestateid, string realestatename, int realestatetypeid, int locationid, int cityid, int regionid, int districtid, int realestateownersid, int address, double price, string description, string createby, DateTime createdate, double area, double lengh, double width, double height, string images, Byte status, Byte isvip, DateTime period)
		{
			this.RealEstateID = realestateid;
			this.RealEstateName = realestatename;
			this.RealEstateTypeID = realestatetypeid;
			this.LocationID = locationid;
			this.CityID = cityid;
			this.RegionID = regionid;
			this.DistrictID = districtid;
			this.RealEstateOwnersID = realestateownersid;
			this.Address = address;
			this.Price = price;
			this.Description = description;
			this.CreateBy = createby;
			this.CreateDate = createdate;
			this.Area = area;
			this.Lengh = lengh;
			this.Width = width;
			this.Height = height;
			this.Images = images;
			this.Status = status;
			this.IsVip = isvip;
			this.Period = period;
		}
		#endregion
	}
}
