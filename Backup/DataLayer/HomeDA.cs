using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class HomeDA
	{

		#region ***** Init Methods ***** 
		public HomeDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Home Populate(IDataReader myReader)
		{
			Home obj = new Home();
			obj.HomeID = (int) myReader["HomeID"];
			obj.HomeTypeID = (int) myReader["HomeTypeID"];
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
			obj.BedroomNumber = (Byte) myReader["BedroomNumber"];
			obj.TierNumber = (Byte) myReader["TierNumber"];
			obj.Image1 = (string) myReader["Image1"];
			obj.Image2 = (string) myReader["Image2"];
			obj.Image3 = (string) myReader["Image3"];
			return obj;
		}

		/// <summary>
		/// Get Home by homeid
		/// </summary>
		/// <param name="homeid">HomeID</param>
		/// <returns>Home</returns>
		public Home GetByHomeID(int homeid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Home_GetByHomeID", Data.CreateParameter("HomeID", homeid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of Home
		/// </summary>
		/// <returns>List<<Home>></returns>
		public List<Home> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Home_Get"))
			{
				List<Home> list = new List<Home>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Home
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Home_Get");
		}


		/// <summary>
		/// Get all of Home paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<Home>></returns>
		public List<Home> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Home_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<Home> list = new List<Home>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Home paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Home_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Home within Home database table
		/// </summary>
		/// <param name="obj">Home</param>
		/// <returns>key of table</returns>
		public int Add(Home obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("HomeID", obj.HomeID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Home_Add"
							,parameterItemID
							,Data.CreateParameter("HomeTypeID", obj.HomeTypeID)
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
							,Data.CreateParameter("BedroomNumber", obj.BedroomNumber)
							,Data.CreateParameter("TierNumber", obj.TierNumber)
							,Data.CreateParameter("Image1", obj.Image1)
							,Data.CreateParameter("Image2", obj.Image2)
							,Data.CreateParameter("Image3", obj.Image3)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified Home
		/// </summary>
		/// <param name="obj">Home</param>
		/// <returns></returns>
		public void Update(Home obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Home_Update"
							,Data.CreateParameter("HomeID", obj.HomeID)
							,Data.CreateParameter("HomeTypeID", obj.HomeTypeID)
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
							,Data.CreateParameter("BedroomNumber", obj.BedroomNumber)
							,Data.CreateParameter("TierNumber", obj.TierNumber)
							,Data.CreateParameter("Image1", obj.Image1)
							,Data.CreateParameter("Image2", obj.Image2)
							,Data.CreateParameter("Image3", obj.Image3)
			);
		}

		/// <summary>
		/// Delete the specified Home
		/// </summary>
		/// <param name="homeid">HomeID</param>
		/// <returns></returns>
		public void Delete(int homeid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Home_Delete", Data.CreateParameter("HomeID", homeid));
		}
		#endregion
	}
}
