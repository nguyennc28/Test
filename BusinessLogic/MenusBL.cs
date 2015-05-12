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
	public class MenusBL
	{

		#region ***** Init Methods ***** 
		MenusDA objMenusDA;
		public MenusBL()
		{
			objMenusDA = new MenusDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get Menus by menuid
		/// </summary>
		/// <param name="menuid">MenuID</param>
		/// <returns>Menus</returns>
		public Menus GetByMenuID(int menuid)
		{
			return objMenusDA.GetByMenuID(menuid);
		}

		/// <summary>
		/// Get all of Menus
		/// </summary>
		/// <returns>List<<Menus>></returns>
		public List<Menus> GetList()
		{
			string cacheName = "lstMenus";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objMenusDA.GetList(), "Menus");
			}
			return (List<Menus>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of Menus
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsMenus";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objMenusDA.GetDataSet(), "Menus");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of Menus paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<Menus>></returns>
		public List<Menus> GetListPaged(int recperpage, int pageindex)
		{
			return objMenusDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of Menus paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objMenusDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Menus within Menus database table
		/// </summary>
		/// <param name="obj_menus">Menus</param>
		/// <returns>key of table</returns>
		public int Add(Menus obj_menus)
		{
			ServerCache.Remove("Menus", true);
			return objMenusDA.Add(obj_menus);
		}

		/// <summary>
		/// updates the specified Menus
		/// </summary>
		/// <param name="obj_menus">Menus</param>
		/// <returns></returns>
		public void Update(Menus obj_menus)
		{
			ServerCache.Remove("Menus", true);
			objMenusDA.Update(obj_menus);
		}

		/// <summary>
		/// Delete the specified Menus
		/// </summary>
		/// <param name="menuid">MenuID</param>
		/// <returns></returns>
		public void Delete(int menuid)
		{
			ServerCache.Remove("Menus", true);
			objMenusDA.Delete(menuid);
		}
		#endregion
	}
}
