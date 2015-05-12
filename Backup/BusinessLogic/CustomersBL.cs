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
	public class CustomersBL
	{

		#region ***** Init Methods ***** 
		CustomersDA objCustomersDA;
		public CustomersBL()
		{
			objCustomersDA = new CustomersDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get Customers by customerid
		/// </summary>
		/// <param name="customerid">CustomerID</param>
		/// <returns>Customers</returns>
		public Customers GetByCustomerID(int customerid)
		{
			return objCustomersDA.GetByCustomerID(customerid);
		}

		/// <summary>
		/// Get all of Customers
		/// </summary>
		/// <returns>List<<Customers>></returns>
		public List<Customers> GetList()
		{
			string cacheName = "lstCustomers";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objCustomersDA.GetList(), "Customers");
			}
			return (List<Customers>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of Customers
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsCustomers";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objCustomersDA.GetDataSet(), "Customers");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of Customers paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<Customers>></returns>
		public List<Customers> GetListPaged(int recperpage, int pageindex)
		{
			return objCustomersDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of Customers paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objCustomersDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Customers within Customers database table
		/// </summary>
		/// <param name="obj_customers">Customers</param>
		/// <returns>key of table</returns>
		public int Add(Customers obj_customers)
		{
			ServerCache.Remove("Customers", true);
			return objCustomersDA.Add(obj_customers);
		}

		/// <summary>
		/// updates the specified Customers
		/// </summary>
		/// <param name="obj_customers">Customers</param>
		/// <returns></returns>
		public void Update(Customers obj_customers)
		{
			ServerCache.Remove("Customers", true);
			objCustomersDA.Update(obj_customers);
		}

		/// <summary>
		/// Delete the specified Customers
		/// </summary>
		/// <param name="customerid">CustomerID</param>
		/// <returns></returns>
		public void Delete(int customerid)
		{
			ServerCache.Remove("Customers", true);
			objCustomersDA.Delete(customerid);
		}
		#endregion
	}
}
