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
	public class HomeBL
	{

		#region ***** Init Methods ***** 
		HomeDA objHomeDA;
		public HomeBL()
		{
			objHomeDA = new HomeDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get Home by homeid
		/// </summary>
		/// <param name="homeid">HomeID</param>
		/// <returns>Home</returns>
		public Home GetByHomeID(int homeid)
		{
			return objHomeDA.GetByHomeID(homeid);
		}

		/// <summary>
		/// Get all of Home
		/// </summary>
		/// <returns>List<<Home>></returns>
		public List<Home> GetList()
		{
			string cacheName = "lstHome";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objHomeDA.GetList(), "Home");
			}
			return (List<Home>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of Home
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsHome";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objHomeDA.GetDataSet(), "Home");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of Home paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<Home>></returns>
		public List<Home> GetListPaged(int recperpage, int pageindex)
		{
			return objHomeDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of Home paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objHomeDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Home within Home database table
		/// </summary>
		/// <param name="obj_home">Home</param>
		/// <returns>key of table</returns>
		public int Add(Home obj_home)
		{
			ServerCache.Remove("Home", true);
			return objHomeDA.Add(obj_home);
		}

		/// <summary>
		/// updates the specified Home
		/// </summary>
		/// <param name="obj_home">Home</param>
		/// <returns></returns>
		public void Update(Home obj_home)
		{
			ServerCache.Remove("Home", true);
			objHomeDA.Update(obj_home);
		}

		/// <summary>
		/// Delete the specified Home
		/// </summary>
		/// <param name="homeid">HomeID</param>
		/// <returns></returns>
		public void Delete(int homeid)
		{
			ServerCache.Remove("Home", true);
			objHomeDA.Delete(homeid);
		}
		#endregion
	}
}
