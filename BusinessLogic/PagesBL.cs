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
	public class PagesBL
	{

		#region ***** Init Methods ***** 
		PagesDA objPagesDA;
		public PagesBL()
		{
			objPagesDA = new PagesDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get Pages by pageid
		/// </summary>
		/// <param name="pageid">PageID</param>
		/// <returns>Pages</returns>
		public Pages GetByPageID(int pageid)
		{
			return objPagesDA.GetByPageID(pageid);
		}

		/// <summary>
		/// Get all of Pages
		/// </summary>
		/// <returns>List<<Pages>></returns>
		public List<Pages> GetList()
		{
			string cacheName = "lstPages";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objPagesDA.GetList(), "Pages");
			}
			return (List<Pages>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of Pages
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsPages";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objPagesDA.GetDataSet(), "Pages");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of Pages paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<Pages>></returns>
		public List<Pages> GetListPaged(int recperpage, int pageindex)
		{
			return objPagesDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of Pages paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objPagesDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Pages within Pages database table
		/// </summary>
		/// <param name="obj_pages">Pages</param>
		/// <returns>key of table</returns>
		public int Add(Pages obj_pages)
		{
			ServerCache.Remove("Pages", true);
			return objPagesDA.Add(obj_pages);
		}

		/// <summary>
		/// updates the specified Pages
		/// </summary>
		/// <param name="obj_pages">Pages</param>
		/// <returns></returns>
		public void Update(Pages obj_pages)
		{
			ServerCache.Remove("Pages", true);
			objPagesDA.Update(obj_pages);
		}

		/// <summary>
		/// Delete the specified Pages
		/// </summary>
		/// <param name="pageid">PageID</param>
		/// <returns></returns>
		public void Delete(int pageid)
		{
			ServerCache.Remove("Pages", true);
			objPagesDA.Delete(pageid);
		}
		#endregion
	}
}
