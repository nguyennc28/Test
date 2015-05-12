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
	public class LandBL
	{

		#region ***** Init Methods ***** 
		LandDA objLandDA;
		public LandBL()
		{
			objLandDA = new LandDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get Land by landid
		/// </summary>
		/// <param name="landid">LandID</param>
		/// <returns>Land</returns>
		public Land GetByLandID(int landid)
		{
			return objLandDA.GetByLandID(landid);
		}

		/// <summary>
		/// Get all of Land
		/// </summary>
		/// <returns>List<<Land>></returns>
		public List<Land> GetList()
		{
			string cacheName = "lstLand";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objLandDA.GetList(), "Land");
			}
			return (List<Land>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of Land
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsLand";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objLandDA.GetDataSet(), "Land");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of Land paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<Land>></returns>
		public List<Land> GetListPaged(int recperpage, int pageindex)
		{
			return objLandDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of Land paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objLandDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Land within Land database table
		/// </summary>
		/// <param name="obj_land">Land</param>
		/// <returns>key of table</returns>
		public int Add(Land obj_land)
		{
			ServerCache.Remove("Land", true);
			return objLandDA.Add(obj_land);
		}

		/// <summary>
		/// updates the specified Land
		/// </summary>
		/// <param name="obj_land">Land</param>
		/// <returns></returns>
		public void Update(Land obj_land)
		{
			ServerCache.Remove("Land", true);
			objLandDA.Update(obj_land);
		}

		/// <summary>
		/// Delete the specified Land
		/// </summary>
		/// <param name="landid">LandID</param>
		/// <returns></returns>
		public void Delete(int landid)
		{
			ServerCache.Remove("Land", true);
			objLandDA.Delete(landid);
		}
		#endregion
	}
}
