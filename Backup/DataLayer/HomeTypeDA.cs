using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class HomeTypeDA
	{

		#region ***** Init Methods ***** 
		public HomeTypeDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public HomeType Populate(IDataReader myReader)
		{
			HomeType obj = new HomeType();
			obj.HomeTypeID = (int) myReader["HomeTypeID"];
			obj.HomeTypeName = (string) myReader["HomeTypeName"];
			return obj;
		}

		/// <summary>
		/// Get HomeType by hometypeid
		/// </summary>
		/// <param name="hometypeid">HomeTypeID</param>
		/// <returns>HomeType</returns>
		public HomeType GetByHomeTypeID(int hometypeid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_HomeType_GetByHomeTypeID", Data.CreateParameter("HomeTypeID", hometypeid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of HomeType
		/// </summary>
		/// <returns>List<<HomeType>></returns>
		public List<HomeType> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_HomeType_Get"))
			{
				List<HomeType> list = new List<HomeType>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of HomeType
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_HomeType_Get");
		}


		/// <summary>
		/// Get all of HomeType paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<HomeType>></returns>
		public List<HomeType> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_HomeType_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<HomeType> list = new List<HomeType>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of HomeType paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_HomeType_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new HomeType within HomeType database table
		/// </summary>
		/// <param name="obj">HomeType</param>
		/// <returns>key of table</returns>
		public int Add(HomeType obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("HomeTypeID", obj.HomeTypeID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_HomeType_Add"
							,parameterItemID
							,Data.CreateParameter("HomeTypeName", obj.HomeTypeName)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified HomeType
		/// </summary>
		/// <param name="obj">HomeType</param>
		/// <returns></returns>
		public void Update(HomeType obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_HomeType_Update"
							,Data.CreateParameter("HomeTypeID", obj.HomeTypeID)
							,Data.CreateParameter("HomeTypeName", obj.HomeTypeName)
			);
		}

		/// <summary>
		/// Delete the specified HomeType
		/// </summary>
		/// <param name="hometypeid">HomeTypeID</param>
		/// <returns></returns>
		public void Delete(int hometypeid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_HomeType_Delete", Data.CreateParameter("HomeTypeID", hometypeid));
		}
		#endregion
	}
}
