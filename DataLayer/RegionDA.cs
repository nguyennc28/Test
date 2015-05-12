using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class RegionDA
	{

		#region ***** Init Methods ***** 
		public RegionDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Region Populate(IDataReader myReader)
		{
			Region obj = new Region();
			obj.RegionID = (int) myReader["RegionID"];
			obj.RegionName = (string) myReader["RegionName"];
			return obj;
		}

		/// <summary>
		/// Get Region by regionid
		/// </summary>
		/// <param name="regionid">RegionID</param>
		/// <returns>Region</returns>
		public Region GetByRegionID(int regionid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Region_GetByRegionID", Data.CreateParameter("RegionID", regionid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of Region
		/// </summary>
		/// <returns>List<<Region>></returns>
		public List<Region> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Region_Get"))
			{
				List<Region> list = new List<Region>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Region
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Region_Get");
		}


		/// <summary>
		/// Get all of Region paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<Region>></returns>
		public List<Region> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Region_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<Region> list = new List<Region>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Region paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Region_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Region within Region database table
		/// </summary>
		/// <param name="obj">Region</param>
		/// <returns>key of table</returns>
		public int Add(Region obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("RegionID", obj.RegionID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Region_Add"
							,parameterItemID
							,Data.CreateParameter("RegionName", obj.RegionName)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified Region
		/// </summary>
		/// <param name="obj">Region</param>
		/// <returns></returns>
		public void Update(Region obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Region_Update"
							,Data.CreateParameter("RegionID", obj.RegionID)
							,Data.CreateParameter("RegionName", obj.RegionName)
			);
		}

		/// <summary>
		/// Delete the specified Region
		/// </summary>
		/// <param name="regionid">RegionID</param>
		/// <returns></returns>
		public void Delete(int regionid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Region_Delete", Data.CreateParameter("RegionID", regionid));
		}
		#endregion
	}
}
