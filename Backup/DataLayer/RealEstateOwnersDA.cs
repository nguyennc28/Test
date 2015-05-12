using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class RealEstateOwnersDA
	{

		#region ***** Init Methods ***** 
		public RealEstateOwnersDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public RealEstateOwners Populate(IDataReader myReader)
		{
			RealEstateOwners obj = new RealEstateOwners();
			obj.RealEstateOwnersID = (int) myReader["RealEstateOwnersID"];
			obj.RealEstateOwnersTypeID = (int) myReader["RealEstateOwnersTypeID"];
			obj.RealEstateOwnersName = (string) myReader["RealEstateOwnersName"];
			obj.CLUR = (Byte) myReader["CLUR"];
			obj.Address = (string) myReader["Address"];
			obj.MobileNumber = (string) myReader["MobileNumber"];
			obj.Email = (string) myReader["Email"];
			obj.Gender = (bool) myReader["Gender"];
			obj.IdentityCard = (string) myReader["IdentityCard"];
			return obj;
		}

		/// <summary>
		/// Get RealEstateOwners by realestateownersid
		/// </summary>
		/// <param name="realestateownersid">RealEstateOwnersID</param>
		/// <returns>RealEstateOwners</returns>
		public RealEstateOwners GetByRealEstateOwnersID(int realestateownersid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_RealEstateOwners_GetByRealEstateOwnersID", Data.CreateParameter("RealEstateOwnersID", realestateownersid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of RealEstateOwners
		/// </summary>
		/// <returns>List<<RealEstateOwners>></returns>
		public List<RealEstateOwners> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_RealEstateOwners_Get"))
			{
				List<RealEstateOwners> list = new List<RealEstateOwners>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of RealEstateOwners
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstateOwners_Get");
		}


		/// <summary>
		/// Get all of RealEstateOwners paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<RealEstateOwners>></returns>
		public List<RealEstateOwners> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_RealEstateOwners_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<RealEstateOwners> list = new List<RealEstateOwners>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of RealEstateOwners paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstateOwners_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new RealEstateOwners within RealEstateOwners database table
		/// </summary>
		/// <param name="obj">RealEstateOwners</param>
		/// <returns>key of table</returns>
		public int Add(RealEstateOwners obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("RealEstateOwnersID", obj.RealEstateOwnersID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstateOwners_Add"
							,parameterItemID
							,Data.CreateParameter("RealEstateOwnersTypeID", obj.RealEstateOwnersTypeID)
							,Data.CreateParameter("RealEstateOwnersName", obj.RealEstateOwnersName)
							,Data.CreateParameter("CLUR", obj.CLUR)
							,Data.CreateParameter("Address", obj.Address)
							,Data.CreateParameter("MobileNumber", obj.MobileNumber)
							,Data.CreateParameter("Email", obj.Email)
							,Data.CreateParameter("Gender", obj.Gender)
							,Data.CreateParameter("IdentityCard", obj.IdentityCard)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified RealEstateOwners
		/// </summary>
		/// <param name="obj">RealEstateOwners</param>
		/// <returns></returns>
		public void Update(RealEstateOwners obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstateOwners_Update"
							,Data.CreateParameter("RealEstateOwnersID", obj.RealEstateOwnersID)
							,Data.CreateParameter("RealEstateOwnersTypeID", obj.RealEstateOwnersTypeID)
							,Data.CreateParameter("RealEstateOwnersName", obj.RealEstateOwnersName)
							,Data.CreateParameter("CLUR", obj.CLUR)
							,Data.CreateParameter("Address", obj.Address)
							,Data.CreateParameter("MobileNumber", obj.MobileNumber)
							,Data.CreateParameter("Email", obj.Email)
							,Data.CreateParameter("Gender", obj.Gender)
							,Data.CreateParameter("IdentityCard", obj.IdentityCard)
			);
		}

		/// <summary>
		/// Delete the specified RealEstateOwners
		/// </summary>
		/// <param name="realestateownersid">RealEstateOwnersID</param>
		/// <returns></returns>
		public void Delete(int realestateownersid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstateOwners_Delete", Data.CreateParameter("RealEstateOwnersID", realestateownersid));
		}
		#endregion
	}
}
