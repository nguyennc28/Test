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
	public class RealEstateOwnersTypeBL
	{

		#region ***** Init Methods ***** 
		RealEstateOwnersTypeDA objRealEstateOwnersTypeDA;
		public RealEstateOwnersTypeBL()
		{
			objRealEstateOwnersTypeDA = new RealEstateOwnersTypeDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get RealEstateOwnersType by realestateownerstypeid
		/// </summary>
		/// <param name="realestateownerstypeid">RealEstateOwnersTypeID</param>
		/// <returns>RealEstateOwnersType</returns>
		public RealEstateOwnersType GetByRealEstateOwnersTypeID(int realestateownerstypeid)
		{
			return objRealEstateOwnersTypeDA.GetByRealEstateOwnersTypeID(realestateownerstypeid);
		}

		/// <summary>
		/// Get all of RealEstateOwnersType
		/// </summary>
		/// <returns>List<<RealEstateOwnersType>></returns>
		public List<RealEstateOwnersType> GetList()
		{
			string cacheName = "lstRealEstateOwnersType";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objRealEstateOwnersTypeDA.GetList(), "RealEstateOwnersType");
			}
			return (List<RealEstateOwnersType>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of RealEstateOwnersType
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsRealEstateOwnersType";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objRealEstateOwnersTypeDA.GetDataSet(), "RealEstateOwnersType");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of RealEstateOwnersType paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<RealEstateOwnersType>></returns>
		public List<RealEstateOwnersType> GetListPaged(int recperpage, int pageindex)
		{
			return objRealEstateOwnersTypeDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of RealEstateOwnersType paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objRealEstateOwnersTypeDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new RealEstateOwnersType within RealEstateOwnersType database table
		/// </summary>
		/// <param name="obj_realestateownerstype">RealEstateOwnersType</param>
		/// <returns>key of table</returns>
		public int Add(RealEstateOwnersType obj_realestateownerstype)
		{
			ServerCache.Remove("RealEstateOwnersType", true);
			return objRealEstateOwnersTypeDA.Add(obj_realestateownerstype);
		}

		/// <summary>
		/// updates the specified RealEstateOwnersType
		/// </summary>
		/// <param name="obj_realestateownerstype">RealEstateOwnersType</param>
		/// <returns></returns>
		public void Update(RealEstateOwnersType obj_realestateownerstype)
		{
			ServerCache.Remove("RealEstateOwnersType", true);
			objRealEstateOwnersTypeDA.Update(obj_realestateownerstype);
		}

		/// <summary>
		/// Delete the specified RealEstateOwnersType
		/// </summary>
		/// <param name="realestateownerstypeid">RealEstateOwnersTypeID</param>
		/// <returns></returns>
		public void Delete(int realestateownerstypeid)
		{
			ServerCache.Remove("RealEstateOwnersType", true);
			objRealEstateOwnersTypeDA.Delete(realestateownerstypeid);
		}
		#endregion
	}
}
