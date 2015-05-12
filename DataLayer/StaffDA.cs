using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class StaffDA
	{

		#region ***** Init Methods ***** 
		public StaffDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Staff Populate(IDataReader myReader)
		{
			Staff obj = new Staff();
			obj.StaffID = (int) myReader["StaffID"];
			obj.Fullname = (string) myReader["Fullname"];
			obj.Gender = (bool) myReader["Gender"];
			obj.Address = (string) myReader["Address"];
			obj.IdNumber = (string) myReader["IdNumber"];
			obj.PhoneNumber = (string) myReader["PhoneNumber"];
			obj.HomePhone = (string) myReader["HomePhone"];
			obj.Email = (string) myReader["Email"];
			return obj;
		}

		/// <summary>
		/// Get Staff by staffid
		/// </summary>
		/// <param name="staffid">StaffID</param>
		/// <returns>Staff</returns>
		public Staff GetByStaffID(int staffid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Staff_GetByStaffID", Data.CreateParameter("StaffID", staffid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of Staff
		/// </summary>
		/// <returns>List<<Staff>></returns>
		public List<Staff> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Staff_Get"))
			{
				List<Staff> list = new List<Staff>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Staff
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Staff_Get");
		}


		/// <summary>
		/// Get all of Staff paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<Staff>></returns>
		public List<Staff> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Staff_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<Staff> list = new List<Staff>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Staff paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Staff_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Staff within Staff database table
		/// </summary>
		/// <param name="obj">Staff</param>
		/// <returns>key of table</returns>
		public int Add(Staff obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("StaffID", obj.StaffID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Staff_Add"
							,parameterItemID
							,Data.CreateParameter("Fullname", obj.Fullname)
							,Data.CreateParameter("Gender", obj.Gender)
							,Data.CreateParameter("Address", obj.Address)
							,Data.CreateParameter("IdNumber", obj.IdNumber)
							,Data.CreateParameter("PhoneNumber", obj.PhoneNumber)
							,Data.CreateParameter("HomePhone", obj.HomePhone)
							,Data.CreateParameter("Email", obj.Email)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified Staff
		/// </summary>
		/// <param name="obj">Staff</param>
		/// <returns></returns>
		public void Update(Staff obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Staff_Update"
							,Data.CreateParameter("StaffID", obj.StaffID)
							,Data.CreateParameter("Fullname", obj.Fullname)
							,Data.CreateParameter("Gender", obj.Gender)
							,Data.CreateParameter("Address", obj.Address)
							,Data.CreateParameter("IdNumber", obj.IdNumber)
							,Data.CreateParameter("PhoneNumber", obj.PhoneNumber)
							,Data.CreateParameter("HomePhone", obj.HomePhone)
							,Data.CreateParameter("Email", obj.Email)
			);
		}

		/// <summary>
		/// Delete the specified Staff
		/// </summary>
		/// <param name="staffid">StaffID</param>
		/// <returns></returns>
		public void Delete(int staffid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Staff_Delete", Data.CreateParameter("StaffID", staffid));
		}
		#endregion
	}
}
