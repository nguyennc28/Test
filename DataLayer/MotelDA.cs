using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class MotelDA
	{

		#region ***** Init Methods ***** 
		public MotelDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Motel Populate(IDataReader myReader)
		{
			Motel obj = new Motel();
			obj.MotelID = (int) myReader["MotelID"];
			obj.RealEstateOwnersID = (int) myReader["RealEstateOwnersID"];
			obj.RealEstateOwnersTypeID = (int) myReader["RealEstateOwnersTypeID"];
			obj.RealEstateID = (int) myReader["RealEstateID"];
			obj.MotelTypeID = (int) myReader["MotelTypeID"];
			obj.Description = (string) myReader["Description"];
			obj.Address = (string) myReader["Address"];
			obj.Price = (double) myReader["Price"];
			obj.TotalArea = (double) myReader["TotalArea"];
			obj.IsClosed = (bool) myReader["IsClosed"];
			obj.IsCooker = (bool) myReader["IsCooker"];
			obj.Furniture = (string) myReader["Furniture"];
			obj.TierNumber = (Byte) myReader["TierNumber"];
			obj.Image1 = (string) myReader["Image1"];
			obj.Image2 = (string) myReader["Image2"];
			obj.Image3 = (string) myReader["Image3"];
			return obj;
		}

		/// <summary>
		/// Get Motel by motelid
		/// </summary>
		/// <param name="motelid">MotelID</param>
		/// <returns>Motel</returns>
		public Motel GetByMotelID(int motelid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Motel_GetByMotelID", Data.CreateParameter("MotelID", motelid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of Motel
		/// </summary>
		/// <returns>List<<Motel>></returns>
		public List<Motel> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Motel_Get"))
			{
				List<Motel> list = new List<Motel>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Motel
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Motel_Get");
		}


		/// <summary>
		/// Get all of Motel paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<Motel>></returns>
		public List<Motel> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Motel_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<Motel> list = new List<Motel>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Motel paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Motel_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Motel within Motel database table
		/// </summary>
		/// <param name="obj">Motel</param>
		/// <returns>key of table</returns>
		public int Add(Motel obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("MotelID", obj.MotelID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Motel_Add"
							,parameterItemID
							,Data.CreateParameter("RealEstateOwnersID", obj.RealEstateOwnersID)
							,Data.CreateParameter("RealEstateOwnersTypeID", obj.RealEstateOwnersTypeID)
							,Data.CreateParameter("RealEstateID", obj.RealEstateID)
							,Data.CreateParameter("MotelTypeID", obj.MotelTypeID)
							,Data.CreateParameter("Description", obj.Description)
							,Data.CreateParameter("Address", obj.Address)
							,Data.CreateParameter("Price", obj.Price)
							,Data.CreateParameter("TotalArea", obj.TotalArea)
							,Data.CreateParameter("IsClosed", obj.IsClosed)
							,Data.CreateParameter("IsCooker", obj.IsCooker)
							,Data.CreateParameter("Furniture", obj.Furniture)
							,Data.CreateParameter("TierNumber", obj.TierNumber)
							,Data.CreateParameter("Image1", obj.Image1)
							,Data.CreateParameter("Image2", obj.Image2)
							,Data.CreateParameter("Image3", obj.Image3)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified Motel
		/// </summary>
		/// <param name="obj">Motel</param>
		/// <returns></returns>
		public void Update(Motel obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Motel_Update"
							,Data.CreateParameter("MotelID", obj.MotelID)
							,Data.CreateParameter("RealEstateOwnersID", obj.RealEstateOwnersID)
							,Data.CreateParameter("RealEstateOwnersTypeID", obj.RealEstateOwnersTypeID)
							,Data.CreateParameter("RealEstateID", obj.RealEstateID)
							,Data.CreateParameter("MotelTypeID", obj.MotelTypeID)
							,Data.CreateParameter("Description", obj.Description)
							,Data.CreateParameter("Address", obj.Address)
							,Data.CreateParameter("Price", obj.Price)
							,Data.CreateParameter("TotalArea", obj.TotalArea)
							,Data.CreateParameter("IsClosed", obj.IsClosed)
							,Data.CreateParameter("IsCooker", obj.IsCooker)
							,Data.CreateParameter("Furniture", obj.Furniture)
							,Data.CreateParameter("TierNumber", obj.TierNumber)
							,Data.CreateParameter("Image1", obj.Image1)
							,Data.CreateParameter("Image2", obj.Image2)
							,Data.CreateParameter("Image3", obj.Image3)
			);
		}

		/// <summary>
		/// Delete the specified Motel
		/// </summary>
		/// <param name="motelid">MotelID</param>
		/// <returns></returns>
		public void Delete(int motelid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Motel_Delete", Data.CreateParameter("MotelID", motelid));
		}
		#endregion
	}
}
