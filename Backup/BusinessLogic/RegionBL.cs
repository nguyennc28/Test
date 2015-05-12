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
	public class RegionBL
	{

		#region ***** Init Methods ***** 
		RegionDA objRegionDA;
		public RegionBL()
		{
			objRegionDA = new RegionDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get Region by regionid
		/// </summary>
		/// <param name="regionid">RegionID</param>
		/// <returns>Region</returns>
		public Region GetByRegionID(int regionid)
		{
			return objRegionDA.GetByRegionID(regionid);
		}

		/// <summary>
		/// Get all of Region
		/// </summary>
		/// <returns>List<<Region>></returns>
		public List<Region> GetList()
		{
			string cacheName = "lstRegion";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objRegionDA.GetList(), "Region");
			}
			return (List<Region>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of Region
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsRegion";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objRegionDA.GetDataSet(), "Region");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of Region paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<Region>></returns>
		public List<Region> GetListPaged(int recperpage, int pageindex)
		{
			return objRegionDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of Region paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objRegionDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Region within Region database table
		/// </summary>
		/// <param name="obj_region">Region</param>
		/// <returns>key of table</returns>
		public int Add(Region obj_region)
		{
			ServerCache.Remove("Region", true);
			return objRegionDA.Add(obj_region);
		}

		/// <summary>
		/// updates the specified Region
		/// </summary>
		/// <param name="obj_region">Region</param>
		/// <returns></returns>
		public void Update(Region obj_region)
		{
			ServerCache.Remove("Region", true);
			objRegionDA.Update(obj_region);
		}

		/// <summary>
		/// Delete the specified Region
		/// </summary>
		/// <param name="regionid">RegionID</param>
		/// <returns></returns>
		public void Delete(int regionid)
		{
			ServerCache.Remove("Region", true);
			objRegionDA.Delete(regionid);
		}
		#endregion
	}
}
