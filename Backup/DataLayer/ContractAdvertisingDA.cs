using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class ContractAdvertisingDA
	{

		#region ***** Init Methods ***** 
		public ContractAdvertisingDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public ContractAdvertising Populate(IDataReader myReader)
		{
			ContractAdvertising obj = new ContractAdvertising();
			obj.ContractAdvertisingID = (int) myReader["ContractAdvertisingID"];
			obj.ContractAdvertisingName = (string) myReader["ContractAdvertisingName"];
			obj.StaffID = (int) myReader["StaffID"];
			obj.CompanyID = (int) myReader["CompanyID"];
			obj.BannerID = (int) myReader["BannerID"];
			obj.CreateDate = (DateTime) myReader["CreateDate"];
			obj.Fees = (decimal) myReader["Fees"];
			obj.EndDate = (DateTime) myReader["EndDate"];
			obj.Status = (bool) myReader["Status"];
			return obj;
		}

		/// <summary>
		/// Get ContractAdvertising by contractadvertisingid
		/// </summary>
		/// <param name="contractadvertisingid">ContractAdvertisingID</param>
		/// <returns>ContractAdvertising</returns>
		public ContractAdvertising GetByContractAdvertisingID(int contractadvertisingid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_ContractAdvertising_GetByContractAdvertisingID", Data.CreateParameter("ContractAdvertisingID", contractadvertisingid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of ContractAdvertising
		/// </summary>
		/// <returns>List<<ContractAdvertising>></returns>
		public List<ContractAdvertising> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_ContractAdvertising_Get"))
			{
				List<ContractAdvertising> list = new List<ContractAdvertising>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of ContractAdvertising
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_ContractAdvertising_Get");
		}


		/// <summary>
		/// Get all of ContractAdvertising paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<ContractAdvertising>></returns>
		public List<ContractAdvertising> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_ContractAdvertising_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<ContractAdvertising> list = new List<ContractAdvertising>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of ContractAdvertising paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_ContractAdvertising_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new ContractAdvertising within ContractAdvertising database table
		/// </summary>
		/// <param name="obj">ContractAdvertising</param>
		/// <returns>key of table</returns>
		public int Add(ContractAdvertising obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("ContractAdvertisingID", obj.ContractAdvertisingID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_ContractAdvertising_Add"
							,parameterItemID
							,Data.CreateParameter("ContractAdvertisingName", obj.ContractAdvertisingName)
							,Data.CreateParameter("StaffID", obj.StaffID)
							,Data.CreateParameter("CompanyID", obj.CompanyID)
							,Data.CreateParameter("BannerID", obj.BannerID)
							,Data.CreateParameter("CreateDate", obj.CreateDate)
							,Data.CreateParameter("Fees", obj.Fees)
							,Data.CreateParameter("EndDate", obj.EndDate)
							,Data.CreateParameter("Status", obj.Status)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified ContractAdvertising
		/// </summary>
		/// <param name="obj">ContractAdvertising</param>
		/// <returns></returns>
		public void Update(ContractAdvertising obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_ContractAdvertising_Update"
							,Data.CreateParameter("ContractAdvertisingID", obj.ContractAdvertisingID)
							,Data.CreateParameter("ContractAdvertisingName", obj.ContractAdvertisingName)
							,Data.CreateParameter("StaffID", obj.StaffID)
							,Data.CreateParameter("CompanyID", obj.CompanyID)
							,Data.CreateParameter("BannerID", obj.BannerID)
							,Data.CreateParameter("CreateDate", obj.CreateDate)
							,Data.CreateParameter("Fees", obj.Fees)
							,Data.CreateParameter("EndDate", obj.EndDate)
							,Data.CreateParameter("Status", obj.Status)
			);
		}

		/// <summary>
		/// Delete the specified ContractAdvertising
		/// </summary>
		/// <param name="contractadvertisingid">ContractAdvertisingID</param>
		/// <returns></returns>
		public void Delete(int contractadvertisingid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_ContractAdvertising_Delete", Data.CreateParameter("ContractAdvertisingID", contractadvertisingid));
		}
		#endregion
	}
}
