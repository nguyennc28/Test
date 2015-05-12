using System;

namespace RealEstate.BusinessObjects
{
	public class MotelType
	{
		#region ***** Fields & Properties ***** 
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
		private string _MotelTypeName;
		public string MotelTypeName
		{ 
			get 
			{ 
				return _MotelTypeName;
			}
			set 
			{ 
				_MotelTypeName = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public MotelType()
		{
		}
		public MotelType(int moteltypeid)
		{
			this.MotelTypeID = moteltypeid;
		}
		public MotelType(int moteltypeid, string moteltypename)
		{
			this.MotelTypeID = moteltypeid;
			this.MotelTypeName = moteltypename;
		}
		#endregion
	}
}
