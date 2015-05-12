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
	public class RealEstateOwnersBL
	{

		#region ***** Init Methods ***** 
		RealEstateOwnersDA objRealEstateOwnersDA;
		public RealEstateOwnersBL()
		{
			objRealEstateOwnersDA = new RealEstateOwnersDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get RealEstateOwners by realestateownersid
		/// </summary>
		/// <param name="realestateownersid">RealEstateOwnersID</param>
		/// <returns>RealEstateOwners</returns>
		public RealEstateOwners GetByRealEstateOwnersID(int realestateownersid)
		{
			return objRealEstateOwnersDA.GetByRealEstateOwnersID(realestateownersid);
		}

		/// <summary>
		/// Get all of RealEstateOwners
		/// </summary>
		/// <returns>List<<RealEstateOwners>></returns>
		public List<RealEstateOwners> GetList()
		{
			string cacheName = "lstRealEstateOwners";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objRealEstateOwnersDA.GetList(), "RealEstateOwners");
			}
			return (List<RealEstateOwners>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of RealEstateOwners
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsRealEstateOwners";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objRealEstateOwnersDA.GetDataSet(), "RealEstateOwners");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of RealEstateOwners paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<RealEstateOwners>></returns>
		public List<RealEstateOwners> GetListPaged(int recperpage, int pageindex)
		{
			return objRealEstateOwnersDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of RealEstateOwners paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objRealEstateOwnersDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new RealEstateOwners within RealEstateOwners database table
		/// </summary>
		/// <param name="obj_realestateowners">RealEstateOwners</param>
		/// <returns>key of table</returns>
		public int Add(RealEstateOwners obj_realestateowners)
		{
			ServerCache.Remove("RealEstateOwners", true);
			return objRealEstateOwnersDA.Add(obj_realestateowners);
		}

		/// <summary>
		/// updates the specified RealEstateOwners
		/// </summary>
		/// <param name="obj_realestateowners">RealEstateOwners</param>
		/// <returns></returns>
		public void Update(RealEstateOwners obj_realestateowners)
		{
			ServerCache.Remove("RealEstateOwners", true);
			objRealEstateOwnersDA.Update(obj_realestateowners);
		}

		/// <summary>
		/// Delete the specified RealEstateOwners
		/// </summary>
		/// <param name="realestateownersid">RealEstateOwnersID</param>
		/// <returns></returns>
		public void Delete(int realestateownersid)
		{
			ServerCache.Remove("RealEstateOwners", true);
			objRealEstateOwnersDA.Delete(realestateownersid);
		}
		#endregion
	}
}
