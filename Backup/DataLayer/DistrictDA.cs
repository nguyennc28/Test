using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class DistrictDA
	{

		#region ***** Init Methods ***** 
		public DistrictDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public District Populate(IDataReader myReader)
		{
			District obj = new District();
			obj.DistrictID = (int) myReader["DistrictID"];
			obj.CityID = (int) myReader["CityID"];
			obj.DistrictName = (string) myReader["DistrictName"];
			return obj;
		}

		/// <summary>
		/// Get District by districtid
		/// </summary>
		/// <param name="districtid">DistrictID</param>
		/// <returns>District</returns>
		public District GetByDistrictID(int districtid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_District_GetByDistrictID", Data.CreateParameter("DistrictID", districtid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of District
		/// </summary>
		/// <returns>List<<District>></returns>
		public List<District> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_District_Get"))
			{
				List<District> list = new List<District>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of District
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_District_Get");
		}


		/// <summary>
		/// Get all of District paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<District>></returns>
		public List<District> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_District_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<District> list = new List<District>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of District paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_District_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new District within District database table
		/// </summary>
		/// <param name="obj">District</param>
		/// <returns>key of table</returns>
		public int Add(District obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("DistrictID", obj.DistrictID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_District_Add"
							,parameterItemID
							,Data.CreateParameter("CityID", obj.CityID)
							,Data.CreateParameter("DistrictName", obj.DistrictName)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified District
		/// </summary>
		/// <param name="obj">District</param>
		/// <returns></returns>
		public void Update(District obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_District_Update"
							,Data.CreateParameter("DistrictID", obj.DistrictID)
							,Data.CreateParameter("CityID", obj.CityID)
							,Data.CreateParameter("DistrictName", obj.DistrictName)
			);
		}

		/// <summary>
		/// Delete the specified District
		/// </summary>
		/// <param name="districtid">DistrictID</param>
		/// <returns></returns>
		public void Delete(int districtid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_District_Delete", Data.CreateParameter("DistrictID", districtid));
		}
		#endregion
	}
}
