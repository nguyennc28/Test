using System;

namespace RealEstate.BusinessObjects
{
	public class ContractAdvertising
	{
		#region ***** Fields & Properties ***** 
		private int _ContractAdvertisingID;
		public int ContractAdvertisingID
		{ 
			get 
			{ 
				return _ContractAdvertisingID;
			}
			set 
			{ 
				_ContractAdvertisingID = value;
			}
		}
		private string _ContractAdvertisingName;
		public string ContractAdvertisingName
		{ 
			get 
			{ 
				return _ContractAdvertisingName;
			}
			set 
			{ 
				_ContractAdvertisingName = value;
			}
		}
		private int _StaffID;
		public int StaffID
		{ 
			get 
			{ 
				return _StaffID;
			}
			set 
			{ 
				_StaffID = value;
			}
		}
		private int _CompanyID;
		public int CompanyID
		{ 
			get 
			{ 
				return _CompanyID;
			}
			set 
			{ 
				_CompanyID = value;
			}
		}
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
		public ContractAdvertising()
		{
		}
		public ContractAdvertising(int contractadvertisingid)
		{
			this.ContractAdvertisingID = contractadvertisingid;
		}
		public ContractAdvertising(int contractadvertisingid, string contractadvertisingname, int staffid, int companyid, int bannerid, DateTime createdate, decimal fees, DateTime enddate, bool status)
		{
			this.ContractAdvertisingID = contractadvertisingid;
			this.ContractAdvertisingName = contractadvertisingname;
			this.StaffID = staffid;
			this.CompanyID = companyid;
			this.BannerID = bannerid;
			this.CreateDate = createdate;
			this.Fees = fees;
			this.EndDate = enddate;
			this.Status = status;
		}
		#endregion
	}
}
