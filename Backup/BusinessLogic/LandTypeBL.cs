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
	public class LandTypeBL
	{

		#region ***** Init Methods ***** 
		LandTypeDA objLandTypeDA;
		public LandTypeBL()
		{
			objLandTypeDA = new LandTypeDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get LandType by landtypeid
		/// </summary>
		/// <param name="landtypeid">LandTypeID</param>
		/// <returns>LandType</returns>
		public LandType GetByLandTypeID(int landtypeid)
		{
			return objLandTypeDA.GetByLandTypeID(landtypeid);
		}

		/// <summary>
		/// Get all of LandType
		/// </summary>
		/// <returns>List<<LandType>></returns>
		public List<LandType> GetList()
		{
			string cacheName = "lstLandType";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objLandTypeDA.GetList(), "LandType");
			}
			return (List<LandType>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of LandType
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsLandType";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objLandTypeDA.GetDataSet(), "LandType");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of LandType paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<LandType>></returns>
		public List<LandType> GetListPaged(int recperpage, int pageindex)
		{
			return objLandTypeDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of LandType paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objLandTypeDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new LandType within LandType database table
		/// </summary>
		/// <param name="obj_landtype">LandType</param>
		/// <returns>key of table</returns>
		public int Add(LandType obj_landtype)
		{
			ServerCache.Remove("LandType", true);
			return objLandTypeDA.Add(obj_landtype);
		}

		/// <summary>
		/// updates the specified LandType
		/// </summary>
		/// <param name="obj_landtype">LandType</param>
		/// <returns></returns>
		public void Update(LandType obj_landtype)
		{
			ServerCache.Remove("LandType", true);
			objLandTypeDA.Update(obj_landtype);
		}

		/// <summary>
		/// Delete the specified LandType
		/// </summary>
		/// <param name="landtypeid">LandTypeID</param>
		/// <returns></returns>
		public void Delete(int landtypeid)
		{
			ServerCache.Remove("LandType", true);
			objLandTypeDA.Delete(landtypeid);
		}
		#endregion
	}
}
