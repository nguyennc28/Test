using System;

namespace RealEstate.BusinessObjects
{
	public class PostContract
	{
		#region ***** Fields & Properties ***** 
		private int _PostContractID;
		public int PostContractID
		{ 
			get 
			{ 
				return _PostContractID;
			}
			set 
			{ 
				_PostContractID = value;
			}
		}
		private string _PostContractName;
		public string PostContractName
		{ 
			get 
			{ 
				return _PostContractName;
			}
			set 
			{ 
				_PostContractName = value;
			}
		}
		private int _StaffD;
		public int StaffD
		{ 
			get 
			{ 
				return _StaffD;
			}
			set 
			{ 
				_StaffD = value;
			}
		}
		private string _UserName;
		public string UserName
		{ 
			get 
			{ 
				return _UserName;
			}
			set 
			{ 
				_UserName = value;
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
		private decimal _Fees;
		public decimal Fees
		{ 
			get 
			{ 
				return _Fees;
			}
			set 
			{ 
				_Fees = value;
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
		private DateTime _EndDate;
		public DateTime EndDate
		{ 
			get 
			{ 
				return _EndDate;
			}
			set 
			{ 
				_EndDate = value;
			}
		}
		private bool _Status;
		public bool Status
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
		#endregion

		#region ***** Init Methods ***** 
		public PostContract()
		{
		}
		public PostContract(int postcontractid)
		{
			this.PostContractID = postcontractid;
		}
		public PostContract(int postcontractid, string postcontractname, int staffd, string username, int realestateid, decimal fees, DateTime createdate, DateTime enddate, bool status)
		{
			this.PostContractID = postcontractid;
			this.PostContractName = postcontractname;
			this.StaffD = staffd;
			this.UserName = username;
			this.RealEstateID = realestateid;
			this.Fees = fees;
			this.CreateDate = createdate;
			this.EndDate = enddate;
			this.Status = status;
		}
		#endregion
	}
}
