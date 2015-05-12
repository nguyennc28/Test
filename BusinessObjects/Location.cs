using System;

namespace RealEstate.BusinessObjects
{
	public class Location
	{
		#region ***** Fields & Properties ***** 
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
		private double _xcoor;
		public double xcoor
		{ 
			get 
			{ 
				return _xcoor;
			}
			set 
			{ 
				_xcoor = value;
			}
		}
		private double _ycoor;
		public double ycoor
		{ 
			get 
			{ 
				return _ycoor;
			}
			set 
			{ 
				_ycoor = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public Location()
		{
		}
		public Location(int locationid)
		{
			this.LocationID = locationid;
		}
		public Location(int locationid, double xcoor, double ycoor)
		{
			this.LocationID = locationid;
			this.xcoor = xcoor;
			this.ycoor = ycoor;
		}
		#endregion
	}
}
