using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class RealEstateTypeDA
	{

		#region ***** Init Methods ***** 
		public RealEstateTypeDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public RealEstateType Populate(IDataReader myReader)
		{
			RealEstateType obj = new RealEstateType();
			obj.RealEstateTypeID = (int) myReader["RealEstateTypeID"];
			obj.NameRealEstateType = (string) myReader["NameRealEstateType"];
			obj.Description = (string) myReader["Description"];
			return obj;
		}

		/// <summary>
		/// Get RealEstateType by realestatetypeid
		/// </summary>
		/// <param name="realestatetypeid">RealEstateTypeID</param>
		/// <returns>RealEstateType</returns>
		public RealEstateType GetByRealEstateTypeID(int realestatetypeid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_RealEstateType_GetByRealEstateTypeID", Data.CreateParameter("RealEstateTypeID", realestatetypeid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of RealEstateType
		/// </summary>
		/// <returns>List<<RealEstateType>></returns>
		public List<RealEstateType> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_RealEstateType_Get"))
			{
				List<RealEstateType> list = new List<RealEstateType>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of RealEstateType
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstateType_Get");
		}


		/// <summary>
		/// Get all of RealEstateType paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<RealEstateType>></returns>
		public List<RealEstateType> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_RealEstateType_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<RealEstateType> list = new List<RealEstateType>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of RealEstateType paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstateType_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new RealEstateType within RealEstateType database table
		/// </summary>
		/// <param name="obj">RealEstateType</param>
		/// <returns>key of table</returns>
		public int Add(RealEstateType obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("RealEstateTypeID", obj.RealEstateTypeID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstateType_Add"
							,parameterItemID
							,Data.CreateParameter("NameRealEstateType", obj.NameRealEstateType)
							,Data.CreateParameter("Description", obj.Description)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified RealEstateType
		/// </summary>
		/// <param name="obj">RealEstateType</param>
		/// <returns></returns>
		public void Update(RealEstateType obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstateType_Update"
							,Data.CreateParameter("RealEstateTypeID", obj.RealEstateTypeID)
							,Data.CreateParameter("NameRealEstateType", obj.NameRealEstateType)
							,Data.CreateParameter("Description", obj.Description)
			);
		}

		/// <summary>
		/// Delete the specified RealEstateType
		/// </summary>
		/// <param name="realestatetypeid">RealEstateTypeID</param>
		/// <returns></returns>
		public void Delete(int realestatetypeid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstateType_Delete", Data.CreateParameter("RealEstateTypeID", realestatetypeid));
		}
		#endregion
	}
}
