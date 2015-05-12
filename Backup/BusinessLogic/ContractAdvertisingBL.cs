using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;
using RealEstate.DataAccess;

namespace RealEstate.BusinessLogic
{
	public class ContractAdvertisingBL
	{

		#region ***** Init Methods ***** 
		ContractAdvertisingDA objContractAdvertisingDA;
		public ContractAdvertisingBL()
		{
			objContractAdvertisingDA = new ContractAdvertisingDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get ContractAdvertising by contractadvertisingid
		/// </summary>
		/// <param name="contractadvertisingid">ContractAdvertisingID</param>
		/// <returns>ContractAdvertising</returns>
		public ContractAdvertising GetByContractAdvertisingID(int contractadvertisingid)
		{
			return objContractAdvertisingDA.GetByContractAdvertisingID(contractadvertisingid);
		}

		/// <summary>
		/// Get all of ContractAdvertising
		/// </summary>
		/// <returns>List<<ContractAdvertising>></returns>
		public List<ContractAdvertising> GetList()
		{
			string cacheName = "lstContractAdvertising";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objContractAdvertisingDA.GetList(), "ContractAdvertising");
			}
			return (List<ContractAdvertising>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of ContractAdvertising
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsContractAdvertising";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objContractAdvertisingDA.GetDataSet(), "ContractAdvertising");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of ContractAdvertising paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<ContractAdvertising>></returns>
		public List<ContractAdvertising> GetListPaged(int recperpage, int pageindex)
		{
			return objContractAdvertisingDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of ContractAdvertising paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objContractAdvertisingDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new ContractAdvertising within ContractAdvertising database table
		/// </summary>
		/// <param name="obj_contractadvertising">ContractAdvertising</param>
		/// <returns>key of table</returns>
		public int Add(ContractAdvertising obj_contractadvertising)
		{
			ServerCache.Remove("ContractAdvertising", true);
			return objContractAdvertisingDA.Add(obj_contractadvertising);
		}

		/// <summary>
		/// updates the specified ContractAdvertising
		/// </summary>
		/// <param name="obj_contractadvertising">ContractAdvertising</param>
		/// <returns></returns>
		public void Update(ContractAdvertising obj_contractadvertising)
		{
			ServerCache.Remove("ContractAdvertising", true);
			objContractAdvertisingDA.Update(obj_contractadvertising);
		}

		/// <summary>
		/// Delete the specified ContractAdvertising
		/// </summary>
		/// <param name="contractadvertisingid">ContractAdvertisingID</param>
		/// <returns></returns>
		public void Delete(int contractadvertisingid)
		{
			ServerCache.Remove("ContractAdvertising", true);
			objContractAdvertisingDA.Delete(contractadvertisingid);
		}
		#endregion
	}
}
