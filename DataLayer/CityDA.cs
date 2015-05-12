using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class CityDA
	{

		#region ***** Init Methods ***** 
		public CityDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public City Populate(IDataReader myReader)
		{
			City obj = new City();
			obj.CityID = (string) myReader["CityID"];
			obj.CityName = (string) myReader["CityName"];
			return obj;
		}

		/// <summary>
		/// Get City by cityid
		/// </summary>
		/// <param name="cityid">CityID</param>
		/// <returns>City</returns>
		public City GetByCityID(string cityid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_City_GetByCityID", Data.CreateParameter("CityID", cityid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of City
		/// </summary>
		/// <returns>List<<City>></returns>
		public List<City> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_City_Get"))
			{
				List<City> list = new List<City>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of City
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_City_Get");
		}


		/// <summary>
		/// Get all of City paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<City>></returns>
		public List<City> GetListPaged(string recperpage, string pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_City_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<City> list = new List<City>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of City paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(string recperpage, string pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_City_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new City within City database table
		/// </summary>
		/// <param name="obj">City</param>
		/// <returns>key of table</returns>
		public int Add(City obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("CityID", obj.CityID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_City_Add"
							,parameterItemID
							,Data.CreateParameter("CityName", obj.CityName)
			);
			return 0;
		}

		/// <summary>
		/// updates the specified City
		/// </summary>
		/// <param name="obj">City</param>
		/// <returns></returns>
		public void Update(City obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_City_Update"
							,Data.CreateParameter("CityID", obj.CityID)
							,Data.CreateParameter("CityName", obj.CityName)
			);
		}

		/// <summary>
		/// Delete the specified City
		/// </summary>
		/// <param name="cityid">CityID</param>
		/// <returns></returns>
		public void Delete(string cityid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_City_Delete", Data.CreateParameter("CityID", cityid));
		}
		#endregion
	}
}
