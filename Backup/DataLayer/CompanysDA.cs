using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class CompanysDA
	{

		#region ***** Init Methods ***** 
		public CompanysDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Companys Populate(IDataReader myReader)
		{
			Companys obj = new Companys();
			obj.CompanyID = (int) myReader["CompanyID"];
			obj.CompanyName = (string) myReader["CompanyName"];
			obj.Address = (string) myReader["Address"];
			obj.HotLine = (string) myReader["HotLine"];
			obj.PhoneNumber = (string) myReader["PhoneNumber"];
			obj.Fax = (string) myReader["Fax"];
			obj.Email = (string) myReader["Email"];
			obj.Surrogate = (string) myReader["Surrogate"];
			obj.Chevron = (string) myReader["Chevron"];
			return obj;
		}

		/// <summary>
		/// Get Companys by companyid
		/// </summary>
		/// <param name="companyid">CompanyID</param>
		/// <returns>Companys</returns>
		public Companys GetByCompanyID(int companyid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Companys_GetByCompanyID", Data.CreateParameter("CompanyID", companyid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of Companys
		/// </summary>
		/// <returns>List<<Companys>></returns>
		public List<Companys> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Companys_Get"))
			{
				List<Companys> list = new List<Companys>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Companys
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Companys_Get");
		}


		/// <summary>
		/// Get all of Companys paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<Companys>></returns>
		public List<Companys> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Companys_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<Companys> list = new List<Companys>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Companys paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Companys_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Companys within Companys database table
		/// </summary>
		/// <param name="obj">Companys</param>
		/// <returns>key of table</returns>
		public int Add(Companys obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("CompanyID", obj.CompanyID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Companys_Add"
							,parameterItemID
							,Data.CreateParameter("CompanyName", obj.CompanyName)
							,Data.CreateParameter("Address", obj.Address)
							,Data.CreateParameter("HotLine", obj.HotLine)
							,Data.CreateParameter("PhoneNumber", obj.PhoneNumber)
							,Data.CreateParameter("Fax", obj.Fax)
							,Data.CreateParameter("Email", obj.Email)
							,Data.CreateParameter("Surrogate", obj.Surrogate)
							,Data.CreateParameter("Chevron", obj.Chevron)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified Companys
		/// </summary>
		/// <param name="obj">Companys</param>
		/// <returns></returns>
		public void Update(Companys obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Companys_Update"
							,Data.CreateParameter("CompanyID", obj.CompanyID)
							,Data.CreateParameter("CompanyName", obj.CompanyName)
							,Data.CreateParameter("Address", obj.Address)
							,Data.CreateParameter("HotLine", obj.HotLine)
							,Data.CreateParameter("PhoneNumber", obj.PhoneNumber)
							,Data.CreateParameter("Fax", obj.Fax)
							,Data.CreateParameter("Email", obj.Email)
							,Data.CreateParameter("Surrogate", obj.Surrogate)
							,Data.CreateParameter("Chevron", obj.Chevron)
			);
		}

		/// <summary>
		/// Delete the specified Companys
		/// </summary>
		/// <param name="companyid">CompanyID</param>
		/// <returns></returns>
		public void Delete(int companyid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Companys_Delete", Data.CreateParameter("CompanyID", companyid));
		}
		#endregion
	}
}
