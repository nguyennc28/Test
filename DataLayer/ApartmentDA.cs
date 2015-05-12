using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class ApartmentDA
	{

		#region ***** Init Methods ***** 
		public ApartmentDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Apartment Populate(IDataReader myReader)
		{
			Apartment obj = new Apartment();
			obj.ApartmentID = (int) myReader["ApartmentID"];
			obj.RealEstateOwnersID = (int) myReader["RealEstateOwnersID"];
			obj.RealEstateOwnersTypeID = (int) myReader["RealEstateOwnersTypeID"];
			obj.RealEstateID = (int) myReader["RealEstateID"];
			obj.Description = (string) myReader["Description"];
			obj.Address = (string) myReader["Address"];
			obj.Price = (double) myReader["Price"];
			obj.TotalArea = (double) myReader["TotalArea"];
			obj.FloorArea = (double) myReader["FloorArea"];
			obj.GargenArea = (double) myReader["GargenArea"];
			obj.HomeArea = (double) myReader["HomeArea"];
			obj.RoomNumber = (Byte) myReader["RoomNumber"];
			obj.TierNumber = (Byte) myReader["TierNumber"];
			obj.Image1 = (string) myReader["Image1"];
			obj.Image2 = (string) myReader["Image2"];
			obj.Image3 = (string) myReader["Image3"];
			return obj;
		}

		/// <summary>
		/// Get Apartment by apartmentid
		/// </summary>
		/// <param name="apartmentid">ApartmentID</param>
		/// <returns>Apartment</returns>
		public Apartment GetByApartmentID(int apartmentid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Apartment_GetByApartmentID", Data.CreateParameter("ApartmentID", apartmentid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of Apartment
		/// </summary>
		/// <returns>List<<Apartment>></returns>
		public List<Apartment> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Apartment_Get"))
			{
				List<Apartment> list = new List<Apartment>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Apartment
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Apartment_Get");
		}


		/// <summary>
		/// Get all of Apartment paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<Apartment>></returns>
		public List<Apartment> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Apartment_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<Apartment> list = new List<Apartment>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Apartment paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Apartment_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Apartment within Apartment database table
		/// </summary>
		/// <param name="obj">Apartment</param>
		/// <returns>key of table</returns>
		public int Add(Apartment obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("ApartmentID", obj.ApartmentID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Apartment_Add"
							,parameterItemID
							,Data.CreateParameter("RealEstateOwnersID", obj.RealEstateOwnersID)
							,Data.CreateParameter("RealEstateOwnersTypeID", obj.RealEstateOwnersTypeID)
							,Data.CreateParameter("RealEstateID", obj.RealEstateID)
							,Data.CreateParameter("Description", obj.Description)
							,Data.CreateParameter("Address", obj.Address)
							,Data.CreateParameter("Price", obj.Price)
							,Data.CreateParameter("TotalArea", obj.TotalArea)
							,Data.CreateParameter("FloorArea", obj.FloorArea)
							,Data.CreateParameter("GargenArea", obj.GargenArea)
							,Data.CreateParameter("HomeArea", obj.HomeArea)
							,Data.CreateParameter("RoomNumber", obj.RoomNumber)
							,Data.CreateParameter("TierNumber", obj.TierNumber)
							,Data.CreateParameter("Image1", obj.Image1)
							,Data.CreateParameter("Image2", obj.Image2)
							,Data.CreateParameter("Image3", obj.Image3)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified Apartment
		/// </summary>
		/// <param name="obj">Apartment</param>
		/// <returns></returns>
		public void Update(Apartment obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Apartment_Update"
							,Data.CreateParameter("ApartmentID", obj.ApartmentID)
							,Data.CreateParameter("RealEstateOwnersID", obj.RealEstateOwnersID)
							,Data.CreateParameter("RealEstateOwnersTypeID", obj.RealEstateOwnersTypeID)
							,Data.CreateParameter("RealEstateID", obj.RealEstateID)
							,Data.CreateParameter("Description", obj.Description)
							,Data.CreateParameter("Address", obj.Address)
							,Data.CreateParameter("Price", obj.Price)
							,Data.CreateParameter("TotalArea", obj.TotalArea)
							,Data.CreateParameter("FloorArea", obj.FloorArea)
							,Data.CreateParameter("GargenArea", obj.GargenArea)
							,Data.CreateParameter("HomeArea", obj.HomeArea)
							,Data.CreateParameter("RoomNumber", obj.RoomNumber)
							,Data.CreateParameter("TierNumber", obj.TierNumber)
							,Data.CreateParameter("Image1", obj.Image1)
							,Data.CreateParameter("Image2", obj.Image2)
							,Data.CreateParameter("Image3", obj.Image3)
			);
		}

		/// <summary>
		/// Delete the specified Apartment
		/// </summary>
		/// <param name="apartmentid">ApartmentID</param>
		/// <returns></returns>
		public void Delete(int apartmentid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Apartment_Delete", Data.CreateParameter("ApartmentID", apartmentid));
		}
		#endregion
	}
}
