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
	public class ProductTypeBL
	{

		#region ***** Init Methods ***** 
		ProductTypeDA objProductTypeDA;
		public ProductTypeBL()
		{
			objProductTypeDA = new ProductTypeDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get ProductType by producttypeid
		/// </summary>
		/// <param name="producttypeid">ProductTypeId</param>
		/// <returns>ProductType</returns>
		public ProductType GetByProductTypeId(int producttypeid)
		{
			return objProductTypeDA.GetByProductTypeId(producttypeid);
		}

		/// <summary>
		/// Get all of ProductType
		/// </summary>
		/// <returns>List<<ProductType>></returns>
		public List<ProductType> GetList()
		{
			string cacheName = "lstProductType";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objProductTypeDA.GetList(), "ProductType");
			}
			return (List<ProductType>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of ProductType
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsProductType";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objProductTypeDA.GetDataSet(), "ProductType");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of ProductType paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<ProductType>></returns>
		public List<ProductType> GetListPaged(int recperpage, int pageindex)
		{
			return objProductTypeDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of ProductType paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objProductTypeDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new ProductType within ProductType database table
		/// </summary>
		/// <param name="obj_producttype">ProductType</param>
		/// <returns>key of table</returns>
		public int Add(ProductType obj_producttype)
		{
			ServerCache.Remove("ProductType", true);
			return objProductTypeDA.Add(obj_producttype);
		}

		/// <summary>
		/// updates the specified ProductType
		/// </summary>
		/// <param name="obj_producttype">ProductType</param>
		/// <returns></returns>
		public void Update(ProductType obj_producttype)
		{
			ServerCache.Remove("ProductType", true);
			objProductTypeDA.Update(obj_producttype);
		}

		/// <summary>
		/// Delete the specified ProductType
		/// </summary>
		/// <param name="producttypeid">ProductTypeId</param>
		/// <returns></returns>
		public void Delete(int producttypeid)
		{
			ServerCache.Remove("ProductType", true);
			objProductTypeDA.Delete(producttypeid);
		}
		#endregion
	}
}
