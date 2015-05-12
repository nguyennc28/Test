using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class CustomersDA
	{

		#region ***** Init Methods ***** 
		public CustomersDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Customers Populate(IDataReader myReader)
		{
			Customers obj = new Customers();
			obj.CustomerID = (int) myReader["CustomerID"];
			obj.UserName = (string) myReader["UserName"];
			obj.Password = (string) myReader["Password"];
			obj.FullName = (string) myReader["FullName"];
			obj.Gender = (bool) myReader["Gender"];
			obj.Address = (string) myReader["Address"];
			obj.IdentityCard = (string) myReader["IdentityCard"];
			obj.MobileNumber = (string) myReader["MobileNumber"];
			obj.HomePhone = (string) myReader["HomePhone"];
			obj.Email = (string) myReader["Email"];
			return obj;
		}

		/// <summary>
		/// Get Customers by customerid
		/// </summary>
		/// <param name="customerid">CustomerID</param>
		/// <returns>Customers</returns>
		public Customers GetByCustomerID(int customerid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Customers_GetByCustomerID", Data.CreateParameter("CustomerID", customerid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of Customers
		/// </summary>
		/// <returns>List<<Customers>></returns>
		public List<Customers> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Customers_Get"))
			{
				List<Customers> list = new List<Customers>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Customers
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Customers_Get");
		}


		/// <summary>
		/// Get all of Customers paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<Customers>></returns>
		public List<Customers> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Customers_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<Customers> list = new List<Customers>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Customers paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Customers_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Customers within Customers database table
		/// </summary>
		/// <param name="obj">Customers</param>
		/// <returns>key of table</returns>
		public int Add(Customers obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("CustomerID", obj.CustomerID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Customers_Add"
							,parameterItemID
							,Data.CreateParameter("UserName", obj.UserName)
							,Data.CreateParameter("Password", obj.Password)
							,Data.CreateParameter("FullName", obj.FullName)
							,Data.CreateParameter("Gender", obj.Gender)
							,Data.CreateParameter("Address", obj.Address)
							,Data.CreateParameter("IdentityCard", obj.IdentityCard)
							,Data.CreateParameter("MobileNumber", obj.MobileNumber)
							,Data.CreateParameter("HomePhone", obj.HomePhone)
							,Data.CreateParameter("Email", obj.Email)
			);
			return 0;
		}

		/// <summary>
		/// updates the specified Customers
		/// </summary>
		/// <param name="obj">Customers</param>
		/// <returns></returns>
		public void Update(Customers obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Customers_Update"
							,Data.CreateParameter("CustomerID", obj.CustomerID)
							,Data.CreateParameter("UserName", obj.UserName)
							,Data.CreateParameter("Password", obj.Password)
							,Data.CreateParameter("FullName", obj.FullName)
							,Data.CreateParameter("Gender", obj.Gender)
							,Data.CreateParameter("Address", obj.Address)
							,Data.CreateParameter("IdentityCard", obj.IdentityCard)
							,Data.CreateParameter("MobileNumber", obj.MobileNumber)
							,Data.CreateParameter("HomePhone", obj.HomePhone)
							,Data.CreateParameter("Email", obj.Email)
			);
		}

		/// <summary>
		/// Delete the specified Customers
		/// </summary>
		/// <param name="customerid">CustomerID</param>
		/// <returns></returns>
		public void Delete(int customerid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Customers_Delete", Data.CreateParameter("CustomerID", customerid));
		}
		#endregion
	}
}
