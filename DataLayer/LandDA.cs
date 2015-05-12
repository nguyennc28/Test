using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class LandDA
	{

		#region ***** Init Methods ***** 
		public LandDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Land Populate(IDataReader myReader)
		{
			Land obj = new Land();
			obj.LandID = (int) myReader["LandID"];
			obj.LandTypeID = (int) myReader["LandTypeID"];
			obj.RealEstateOwnersID = (int) myReader["RealEstateOwnersID"];
			obj.RealEstateOwnersTypeID = (int) myReader["RealEstateOwnersTypeID"];
			obj.RealEstateID = (int) myReader["RealEstateID"];
			obj.Description = (string) myReader["Description"];
			obj.Address = (string) myReader["Address"];
			obj.Price = (double) myReader["Price"];
			obj.TotalArea = (double) myReader["TotalArea"];
			obj.Image1 = (string) myReader["Image1"];
			obj.Image2 = (string) myReader["Image2"];
			return obj;
		}

		/// <summary>
		/// Get Land by landid
		/// </summary>
		/// <param name="landid">LandID</param>
		/// <returns>Land</returns>
		public Land GetByLandID(int landid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Land_GetByLandID", Data.CreateParameter("LandID", landid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of Land
		/// </summary>
		/// <returns>List<<Land>></returns>
		public List<Land> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Land_Get"))
			{
				List<Land> list = new List<Land>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Land
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Land_Get");
		}


		/// <summary>
		/// Get all of Land paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<Land>></returns>
		public List<Land> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Land_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<Land> list = new List<Land>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Land paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Land_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Land within Land database table
		/// </summary>
		/// <param name="obj">Land</param>
		/// <returns>key of table</returns>
		public int Add(Land obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("LandID", obj.LandID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Land_Add"
							,parameterItemID
							,Data.CreateParameter("LandTypeID", obj.LandTypeID)
							,Data.CreateParameter("RealEstateOwnersID", obj.RealEstateOwnersID)
							,Data.CreateParameter("RealEstateOwnersTypeID", obj.RealEstateOwnersTypeID)
							,Data.CreateParameter("RealEstateID", obj.RealEstateID)
							,Data.CreateParameter("Description", obj.Description)
							,Data.CreateParameter("Address", obj.Address)
							,Data.CreateParameter("Price", obj.Price)
							,Data.CreateParameter("TotalArea", obj.TotalArea)
							,Data.CreateParameter("Image1", obj.Image1)
							,Data.CreateParameter("Image2", obj.Image2)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified Land
		/// </summary>
		/// <param name="obj">Land</param>
		/// <returns></returns>
		public void Update(Land obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Land_Update"
							,Data.CreateParameter("LandID", obj.LandID)
							,Data.CreateParameter("LandTypeID", obj.LandTypeID)
							,Data.CreateParameter("RealEstateOwnersID", obj.RealEstateOwnersID)
							,Data.CreateParameter("RealEstateOwnersTypeID", obj.RealEstateOwnersTypeID)
							,Data.CreateParameter("RealEstateID", obj.RealEstateID)
							,Data.CreateParameter("Description", obj.Description)
							,Data.CreateParameter("Address", obj.Address)
							,Data.CreateParameter("Price", obj.Price)
							,Data.CreateParameter("TotalArea", obj.TotalArea)
							,Data.CreateParameter("Image1", obj.Image1)
							,Data.CreateParameter("Image2", obj.Image2)
			);
		}

		/// <summary>
		/// Delete the specified Land
		/// </summary>
		/// <param name="landid">LandID</param>
		/// <returns></returns>
		public void Delete(int landid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Land_Delete", Data.CreateParameter("LandID", landid));
		}
		#endregion
	}
}
