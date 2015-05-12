using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class PostContractDA
	{

		#region ***** Init Methods ***** 
		public PostContractDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public PostContract Populate(IDataReader myReader)
		{
			PostContract obj = new PostContract();
			obj.PostContractID = (int) myReader["PostContractID"];
			obj.PostContractName = (string) myReader["PostContractName"];
			obj.StaffD = (int) myReader["StaffD"];
			obj.UserName = (string) myReader["UserName"];
			obj.RealEstateID = (int) myReader["RealEstateID"];
			obj.Fees = (decimal) myReader["Fees"];
			obj.CreateDate = (DateTime) myReader["CreateDate"];
			obj.EndDate = (DateTime) myReader["EndDate"];
			obj.Status = (bool) myReader["Status"];
			return obj;
		}

		/// <summary>
		/// Get PostContract by postcontractid
		/// </summary>
		/// <param name="postcontractid">PostContractID</param>
		/// <returns>PostContract</returns>
		public PostContract GetByPostContractID(int postcontractid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_PostContract_GetByPostContractID", Data.CreateParameter("PostContractID", postcontractid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of PostContract
		/// </summary>
		/// <returns>List<<PostContract>></returns>
		public List<PostContract> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_PostContract_Get"))
			{
				List<PostContract> list = new List<PostContract>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of PostContract
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_PostContract_Get");
		}


		/// <summary>
		/// Get all of PostContract paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<PostContract>></returns>
		public List<PostContract> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_PostContract_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<PostContract> list = new List<PostContract>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of PostContract paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_PostContract_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new PostContract within PostContract database table
		/// </summary>
		/// <param name="obj">PostContract</param>
		/// <returns>key of table</returns>
		public int Add(PostContract obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("PostContractID", obj.PostContractID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_PostContract_Add"
							,parameterItemID
							,Data.CreateParameter("PostContractName", obj.PostContractName)
							,Data.CreateParameter("StaffD", obj.StaffD)
							,Data.CreateParameter("UserName", obj.UserName)
							,Data.CreateParameter("RealEstateID", obj.RealEstateID)
							,Data.CreateParameter("Fees", obj.Fees)
							,Data.CreateParameter("CreateDate", obj.CreateDate)
							,Data.CreateParameter("EndDate", obj.EndDate)
							,Data.CreateParameter("Status", obj.Status)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified PostContract
		/// </summary>
		/// <param name="obj">PostContract</param>
		/// <returns></returns>
		public void Update(PostContract obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_PostContract_Update"
							,Data.CreateParameter("PostContractID", obj.PostContractID)
							,Data.CreateParameter("PostContractName", obj.PostContractName)
							,Data.CreateParameter("StaffD", obj.StaffD)
							,Data.CreateParameter("UserName", obj.UserName)
							,Data.CreateParameter("RealEstateID", obj.RealEstateID)
							,Data.CreateParameter("Fees", obj.Fees)
							,Data.CreateParameter("CreateDate", obj.CreateDate)
							,Data.CreateParameter("EndDate", obj.EndDate)
							,Data.CreateParameter("Status", obj.Status)
			);
		}

		/// <summary>
		/// Delete the specified PostContract
		/// </summary>
		/// <param name="postcontractid">PostContractID</param>
		/// <returns></returns>
		public void Delete(int postcontractid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_PostContract_Delete", Data.CreateParameter("PostContractID", postcontractid));
		}
		#endregion
	}
}
