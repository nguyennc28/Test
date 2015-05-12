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
	public class CategorysBL
	{

		#region ***** Init Methods ***** 
		CategorysDA objCategorysDA;
		public CategorysBL()
		{
			objCategorysDA = new CategorysDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get Categorys by categoryid
		/// </summary>
		/// <param name="categoryid">CategoryID</param>
		/// <returns>Categorys</returns>
		public Categorys GetByCategoryID(int categoryid)
		{
			return objCategorysDA.GetByCategoryID(categoryid);
		}

		/// <summary>
		/// Get all of Categorys
		/// </summary>
		/// <returns>List<<Categorys>></returns>
		public List<Categorys> GetList()
		{
			string cacheName = "lstCategorys";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objCategorysDA.GetList(), "Categorys");
			}
			return (List<Categorys>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of Categorys
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsCategorys";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objCategorysDA.GetDataSet(), "Categorys");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of Categorys paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<Categorys>></returns>
		public List<Categorys> GetListPaged(int recperpage, int pageindex)
		{
			return objCategorysDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of Categorys paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objCategorysDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Categorys within Categorys database table
		/// </summary>
		/// <param name="obj_categorys">Categorys</param>
		/// <returns>key of table</returns>
		public int Add(Categorys obj_categorys)
		{
			ServerCache.Remove("Categorys", true);
			return objCategorysDA.Add(obj_categorys);
		}

		/// <summary>
		/// updates the specified Categorys
		/// </summary>
		/// <param name="obj_categorys">Categorys</param>
		/// <returns></returns>
		public void Update(Categorys obj_categorys)
		{
			ServerCache.Remove("Categorys", true);
			objCategorysDA.Update(obj_categorys);
		}

		/// <summary>
		/// Delete the specified Categorys
		/// </summary>
		/// <param name="categoryid">CategoryID</param>
		/// <returns></returns>
		public void Delete(int categoryid)
		{
			ServerCache.Remove("Categorys", true);
			objCategorysDA.Delete(categoryid);
		}
		#endregion
	}
}
