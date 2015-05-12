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
	public class RealEstateTypeBL
	{

		#region ***** Init Methods ***** 
		RealEstateTypeDA objRealEstateTypeDA;
		public RealEstateTypeBL()
		{
			objRealEstateTypeDA = new RealEstateTypeDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get RealEstateType by realestatetypeid
		/// </summary>
		/// <param name="realestatetypeid">RealEstateTypeID</param>
		/// <returns>RealEstateType</returns>
		public RealEstateType GetByRealEstateTypeID(int realestatetypeid)
		{
			return objRealEstateTypeDA.GetByRealEstateTypeID(realestatetypeid);
		}

		/// <summary>
		/// Get all of RealEstateType
		/// </summary>
		/// <returns>List<<RealEstateType>></returns>
		public List<RealEstateType> GetList()
		{
			string cacheName = "lstRealEstateType";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objRealEstateTypeDA.GetList(), "RealEstateType");
			}
			return (List<RealEstateType>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of RealEstateType
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsRealEstateType";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objRealEstateTypeDA.GetDataSet(), "RealEstateType");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of RealEstateType paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<RealEstateType>></returns>
		public List<RealEstateType> GetListPaged(int recperpage, int pageindex)
		{
			return objRealEstateTypeDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of RealEstateType paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objRealEstateTypeDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new RealEstateType within RealEstateType database table
		/// </summary>
		/// <param name="obj_realestatetype">RealEstateType</param>
		/// <returns>key of table</returns>
		public int Add(RealEstateType obj_realestatetype)
		{
			ServerCache.Remove("RealEstateType", true);
			return objRealEstateTypeDA.Add(obj_realestatetype);
		}

		/// <summary>
		/// updates the specified RealEstateType
		/// </summary>
		/// <param name="obj_realestatetype">RealEstateType</param>
		/// <returns></returns>
		public void Update(RealEstateType obj_realestatetype)
		{
			ServerCache.Remove("RealEstateType", true);
			objRealEstateTypeDA.Update(obj_realestatetype);
		}

		/// <summary>
		/// Delete the specified RealEstateType
		/// </summary>
		/// <param name="realestatetypeid">RealEstateTypeID</param>
		/// <returns></returns>
		public void Delete(int realestatetypeid)
		{
			ServerCache.Remove("RealEstateType", true);
			objRealEstateTypeDA.Delete(realestatetypeid);
		}
		#endregion
	}
}
