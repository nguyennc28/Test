using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class LocationDA
	{

		#region ***** Init Methods ***** 
		public LocationDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Location Populate(IDataReader myReader)
		{
			Location obj = new Location();
			obj.LocationID = (int) myReader["LocationID"];
			obj.xcoor = (double) myReader["xcoor"];
			obj.ycoor = (double) myReader["ycoor"];
			return obj;
		}

		/// <summary>
		/// Get Location by locationid
		/// </summary>
		/// <param name="locationid">LocationID</param>
		/// <returns>Location</returns>
		public Location GetByLocationID(int locationid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Location_GetByLocationID", Data.CreateParameter("LocationID", locationid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of Location
		/// </summary>
		/// <returns>List<<Location>></returns>
		public List<Location> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Location_Get"))
			{
				List<Location> list = new List<Location>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Location
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Location_Get");
		}


		/// <summary>
		/// Get all of Location paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<Location>></returns>
		public List<Location> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Location_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<Location> list = new List<Location>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Location paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Location_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Location within Location database table
		/// </summary>
		/// <param name="obj">Location</param>
		/// <returns>key of table</returns>
		public int Add(Location obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("LocationID", obj.LocationID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Location_Add"
							,parameterItemID
							,Data.CreateParameter("xcoor", obj.xcoor)
							,Data.CreateParameter("ycoor", obj.ycoor)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified Location
		/// </summary>
		/// <param name="obj">Location</param>
		/// <returns></returns>
		public void Update(Location obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Location_Update"
							,Data.CreateParameter("LocationID", obj.LocationID)
							,Data.CreateParameter("xcoor", obj.xcoor)
							,Data.CreateParameter("ycoor", obj.ycoor)
			);
		}

		/// <summary>
		/// Delete the specified Location
		/// </summary>
		/// <param name="locationid">LocationID</param>
		/// <returns></returns>
		public void Delete(int locationid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Location_Delete", Data.CreateParameter("LocationID", locationid));
		}
		#endregion
	}
}
