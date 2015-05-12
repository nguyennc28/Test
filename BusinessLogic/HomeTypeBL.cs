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
	public class HomeTypeBL
	{

		#region ***** Init Methods ***** 
		HomeTypeDA objHomeTypeDA;
		public HomeTypeBL()
		{
			objHomeTypeDA = new HomeTypeDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get HomeType by hometypeid
		/// </summary>
		/// <param name="hometypeid">HomeTypeID</param>
		/// <returns>HomeType</returns>
		public HomeType GetByHomeTypeID(int hometypeid)
		{
			return objHomeTypeDA.GetByHomeTypeID(hometypeid);
		}

		/// <summary>
		/// Get all of HomeType
		/// </summary>
		/// <returns>List<<HomeType>></returns>
		public List<HomeType> GetList()
		{
			string cacheName = "lstHomeType";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objHomeTypeDA.GetList(), "HomeType");
			}
			return (List<HomeType>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of HomeType
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsHomeType";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objHomeTypeDA.GetDataSet(), "HomeType");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of HomeType paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<HomeType>></returns>
		public List<HomeType> GetListPaged(int recperpage, int pageindex)
		{
			return objHomeTypeDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of HomeType paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objHomeTypeDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new HomeType within HomeType database table
		/// </summary>
		/// <param name="obj_hometype">HomeType</param>
		/// <returns>key of table</returns>
		public int Add(HomeType obj_hometype)
		{
			ServerCache.Remove("HomeType", true);
			return objHomeTypeDA.Add(obj_hometype);
		}

		/// <summary>
		/// updates the specified HomeType
		/// </summary>
		/// <param name="obj_hometype">HomeType</param>
		/// <returns></returns>
		public void Update(HomeType obj_hometype)
		{
			ServerCache.Remove("HomeType", true);
			objHomeTypeDA.Update(obj_hometype);
		}

		/// <summary>
		/// Delete the specified HomeType
		/// </summary>
		/// <param name="hometypeid">HomeTypeID</param>
		/// <returns></returns>
		public void Delete(int hometypeid)
		{
			ServerCache.Remove("HomeType", true);
			objHomeTypeDA.Delete(hometypeid);
		}
		#endregion
	}
}
