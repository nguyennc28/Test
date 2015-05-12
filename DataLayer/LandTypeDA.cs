using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class LandTypeDA
	{

		#region ***** Init Methods ***** 
		public LandTypeDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public LandType Populate(IDataReader myReader)
		{
			LandType obj = new LandType();
			obj.LandTypeID = (int) myReader["LandTypeID"];
			obj.LandTypeName = (string) myReader["LandTypeName"];
			return obj;
		}

		/// <summary>
		/// Get LandType by landtypeid
		/// </summary>
		/// <param name="landtypeid">LandTypeID</param>
		/// <returns>LandType</returns>
		public LandType GetByLandTypeID(int landtypeid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_LandType_GetByLandTypeID", Data.CreateParameter("LandTypeID", landtypeid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of LandType
		/// </summary>
		/// <returns>List<<LandType>></returns>
		public List<LandType> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_LandType_Get"))
			{
				List<LandType> list = new List<LandType>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of LandType
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_LandType_Get");
		}


		/// <summary>
		/// Get all of LandType paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<LandType>></returns>
		public List<LandType> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_LandType_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<LandType> list = new List<LandType>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of LandType paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_LandType_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new LandType within LandType database table
		/// </summary>
		/// <param name="obj">LandType</param>
		/// <returns>key of table</returns>
		public int Add(LandType obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("LandTypeID", obj.LandTypeID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_LandType_Add"
							,parameterItemID
							,Data.CreateParameter("LandTypeName", obj.LandTypeName)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified LandType
		/// </summary>
		/// <param name="obj">LandType</param>
		/// <returns></returns>
		public void Update(LandType obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_LandType_Update"
							,Data.CreateParameter("LandTypeID", obj.LandTypeID)
							,Data.CreateParameter("LandTypeName", obj.LandTypeName)
			);
		}

		/// <summary>
		/// Delete the specified LandType
		/// </summary>
		/// <param name="landtypeid">LandTypeID</param>
		/// <returns></returns>
		public void Delete(int landtypeid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_LandType_Delete", Data.CreateParameter("LandTypeID", landtypeid));
		}
		#endregion
	}
}
