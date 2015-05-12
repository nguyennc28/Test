using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class RealEstateOwnersTypeDA
	{

		#region ***** Init Methods ***** 
		public RealEstateOwnersTypeDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public RealEstateOwnersType Populate(IDataReader myReader)
		{
			RealEstateOwnersType obj = new RealEstateOwnersType();
			obj.RealEstateOwnersTypeID = (int) myReader["RealEstateOwnersTypeID"];
			obj.RealEstateOwnersTypeName = (string) myReader["RealEstateOwnersTypeName"];
			return obj;
		}

		/// <summary>
		/// Get RealEstateOwnersType by realestateownerstypeid
		/// </summary>
		/// <param name="realestateownerstypeid">RealEstateOwnersTypeID</param>
		/// <returns>RealEstateOwnersType</returns>
		public RealEstateOwnersType GetByRealEstateOwnersTypeID(int realestateownerstypeid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_RealEstateOwnersType_GetByRealEstateOwnersTypeID", Data.CreateParameter("RealEstateOwnersTypeID", realestateownerstypeid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of RealEstateOwnersType
		/// </summary>
		/// <returns>List<<RealEstateOwnersType>></returns>
		public List<RealEstateOwnersType> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_RealEstateOwnersType_Get"))
			{
				List<RealEstateOwnersType> list = new List<RealEstateOwnersType>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of RealEstateOwnersType
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstateOwnersType_Get");
		}


		/// <summary>
		/// Get all of RealEstateOwnersType paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<RealEstateOwnersType>></returns>
		public List<RealEstateOwnersType> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_RealEstateOwnersType_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<RealEstateOwnersType> list = new List<RealEstateOwnersType>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of RealEstateOwnersType paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstateOwnersType_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new RealEstateOwnersType within RealEstateOwnersType database table
		/// </summary>
		/// <param name="obj">RealEstateOwnersType</param>
		/// <returns>key of table</returns>
		public int Add(RealEstateOwnersType obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("RealEstateOwnersTypeID", obj.RealEstateOwnersTypeID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstateOwnersType_Add"
							,parameterItemID
							,Data.CreateParameter("RealEstateOwnersTypeName", obj.RealEstateOwnersTypeName)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified RealEstateOwnersType
		/// </summary>
		/// <param name="obj">RealEstateOwnersType</param>
		/// <returns></returns>
		public void Update(RealEstateOwnersType obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstateOwnersType_Update"
							,Data.CreateParameter("RealEstateOwnersTypeID", obj.RealEstateOwnersTypeID)
							,Data.CreateParameter("RealEstateOwnersTypeName", obj.RealEstateOwnersTypeName)
			);
		}

		/// <summary>
		/// Delete the specified RealEstateOwnersType
		/// </summary>
		/// <param name="realestateownerstypeid">RealEstateOwnersTypeID</param>
		/// <returns></returns>
		public void Delete(int realestateownerstypeid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstateOwnersType_Delete", Data.CreateParameter("RealEstateOwnersTypeID", realestateownerstypeid));
		}
		#endregion
	}
}
