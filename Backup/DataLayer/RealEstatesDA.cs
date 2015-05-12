using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class RealEstatesDA
	{

		#region ***** Init Methods ***** 
		public RealEstatesDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public RealEstates Populate(IDataReader myReader)
		{
			RealEstates obj = new RealEstates();
			obj.RealEstateID = (int) myReader["RealEstateID"];
			obj.RealEstateName = (string) myReader["RealEstateName"];
			obj.RealEstateTypeID = (int) myReader["RealEstateTypeID"];
			obj.LocationID = (int) myReader["LocationID"];
			obj.CityID = (int) myReader["CityID"];
			obj.RegionID = (int) myReader["RegionID"];
			obj.DistrictID = (int) myReader["DistrictID"];
			obj.RealEstateOwnersID = (int) myReader["RealEstateOwnersID"];
			obj.Address = (int) myReader["Address"];
			obj.Price = (double) myReader["Price"];
			obj.Description = (string) myReader["Description"];
			obj.CreateBy = (string) myReader["CreateBy"];
			obj.CreateDate = (DateTime) myReader["CreateDate"];
			obj.Area = (double) myReader["Area"];
			obj.Lengh = (double) myReader["Lengh"];
			obj.Width = (double) myReader["Width"];
			obj.Height = (double) myReader["Height"];
			obj.Images = (string) myReader["Images"];
			obj.Status = (Byte) myReader["Status"];
			obj.IsVip = (Byte) myReader["IsVip"];
			obj.Period = (DateTime) myReader["Period"];
			return obj;
		}

		/// <summary>
		/// Get RealEstates by realestateid
		/// </summary>
		/// <param name="realestateid">RealEstateID</param>
		/// <returns>RealEstates</returns>
		public RealEstates GetByRealEstateID(int realestateid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_RealEstates_GetByRealEstateID", Data.CreateParameter("RealEstateID", realestateid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of RealEstates
		/// </summary>
		/// <returns>List<<RealEstates>></returns>
		public List<RealEstates> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_RealEstates_Get"))
			{
				List<RealEstates> list = new List<RealEstates>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of RealEstates
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstates_Get");
		}


		/// <summary>
		/// Get all of RealEstates paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<RealEstates>></returns>
		public List<RealEstates> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_RealEstates_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<RealEstates> list = new List<RealEstates>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of RealEstates paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstates_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new RealEstates within RealEstates database table
		/// </summary>
		/// <param name="obj">RealEstates</param>
		/// <returns>key of table</returns>
		public int Add(RealEstates obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("RealEstateID", obj.RealEstateID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstates_Add"
							,parameterItemID
							,Data.CreateParameter("RealEstateName", obj.RealEstateName)
							,Data.CreateParameter("RealEstateTypeID", obj.RealEstateTypeID)
							,Data.CreateParameter("LocationID", obj.LocationID)
							,Data.CreateParameter("CityID", obj.CityID)
							,Data.CreateParameter("RegionID", obj.RegionID)
							,Data.CreateParameter("DistrictID", obj.DistrictID)
							,Data.CreateParameter("RealEstateOwnersID", obj.RealEstateOwnersID)
							,Data.CreateParameter("Address", obj.Address)
							,Data.CreateParameter("Price", obj.Price)
							,Data.CreateParameter("Description", obj.Description)
							,Data.CreateParameter("CreateBy", obj.CreateBy)
							,Data.CreateParameter("CreateDate", obj.CreateDate)
							,Data.CreateParameter("Area", obj.Area)
							,Data.CreateParameter("Lengh", obj.Lengh)
							,Data.CreateParameter("Width", obj.Width)
							,Data.CreateParameter("Height", obj.Height)
							,Data.CreateParameter("Images", obj.Images)
							,Data.CreateParameter("Status", obj.Status)
							,Data.CreateParameter("IsVip", obj.IsVip)
							,Data.CreateParameter("Period", obj.Period)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified RealEstates
		/// </summary>
		/// <param name="obj">RealEstates</param>
		/// <returns></returns>
		public void Update(RealEstates obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstates_Update"
							,Data.CreateParameter("RealEstateID", obj.RealEstateID)
							,Data.CreateParameter("RealEstateName", obj.RealEstateName)
							,Data.CreateParameter("RealEstateTypeID", obj.RealEstateTypeID)
							,Data.CreateParameter("LocationID", obj.LocationID)
							,Data.CreateParameter("CityID", obj.CityID)
							,Data.CreateParameter("RegionID", obj.RegionID)
							,Data.CreateParameter("DistrictID", obj.DistrictID)
							,Data.CreateParameter("RealEstateOwnersID", obj.RealEstateOwnersID)
							,Data.CreateParameter("Address", obj.Address)
							,Data.CreateParameter("Price", obj.Price)
							,Data.CreateParameter("Description", obj.Description)
							,Data.CreateParameter("CreateBy", obj.CreateBy)
							,Data.CreateParameter("CreateDate", obj.CreateDate)
							,Data.CreateParameter("Area", obj.Area)
							,Data.CreateParameter("Lengh", obj.Lengh)
							,Data.CreateParameter("Width", obj.Width)
							,Data.CreateParameter("Height", obj.Height)
							,Data.CreateParameter("Images", obj.Images)
							,Data.CreateParameter("Status", obj.Status)
							,Data.CreateParameter("IsVip", obj.IsVip)
							,Data.CreateParameter("Period", obj.Period)
			);
		}

		/// <summary>
		/// Delete the specified RealEstates
		/// </summary>
		/// <param name="realestateid">RealEstateID</param>
		/// <returns></returns>
		public void Delete(int realestateid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstates_Delete", Data.CreateParameter("RealEstateID", realestateid));
		}
		#endregion
	}
}
