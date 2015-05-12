using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class MotelTypeDA
	{

		#region ***** Init Methods ***** 
		public MotelTypeDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public MotelType Populate(IDataReader myReader)
		{
			MotelType obj = new MotelType();
			obj.MotelTypeID = (int) myReader["MotelTypeID"];
			obj.MotelTypeName = (string) myReader["MotelTypeName"];
			return obj;
		}

		/// <summary>
		/// Get MotelType by moteltypeid
		/// </summary>
		/// <param name="moteltypeid">MotelTypeID</param>
		/// <returns>MotelType</returns>
		public MotelType GetByMotelTypeID(int moteltypeid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_MotelType_GetByMotelTypeID", Data.CreateParameter("MotelTypeID", moteltypeid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of MotelType
		/// </summary>
		/// <returns>List<<MotelType>></returns>
		public List<MotelType> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_MotelType_Get"))
			{
				List<MotelType> list = new List<MotelType>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of MotelType
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_MotelType_Get");
		}


		/// <summary>
		/// Get all of MotelType paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<MotelType>></returns>
		public List<MotelType> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_MotelType_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<MotelType> list = new List<MotelType>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of MotelType paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_MotelType_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new MotelType within MotelType database table
		/// </summary>
		/// <param name="obj">MotelType</param>
		/// <returns>key of table</returns>
		public int Add(MotelType obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("MotelTypeID", obj.MotelTypeID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_MotelType_Add"
							,parameterItemID
							,Data.CreateParameter("MotelTypeName", obj.MotelTypeName)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified MotelType
		/// </summary>
		/// <param name="obj">MotelType</param>
		/// <returns></returns>
		public void Update(MotelType obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_MotelType_Update"
							,Data.CreateParameter("MotelTypeID", obj.MotelTypeID)
							,Data.CreateParameter("MotelTypeName", obj.MotelTypeName)
			);
		}

		/// <summary>
		/// Delete the specified MotelType
		/// </summary>
		/// <param name="moteltypeid">MotelTypeID</param>
		/// <returns></returns>
		public void Delete(int moteltypeid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_MotelType_Delete", Data.CreateParameter("MotelTypeID", moteltypeid));
		}
		#endregion
	}
}
