using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class UsersDA
	{

		#region ***** Init Methods ***** 
		public UsersDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Users Populate(IDataReader myReader)
		{
			Users obj = new Users();
			obj.UserID = (string) myReader["UserID"];
			obj.UserName = (string) myReader["UserName"];
			obj.Password = (string) myReader["Password"];
			obj.FullName = (string) myReader["FullName"];
			obj.Role = (string) myReader["Role"];
			obj.Gender = (bool) myReader["Gender"];
			obj.Avatar = (string) myReader["Avatar"];
			obj.Birthday = (DateTime) myReader["Birthday"];
			obj.Email = (string) myReader["Email"];
			obj.Address = (string) myReader["Address"];
			obj.MobilePhone = (string) myReader["MobilePhone"];
			obj.IdentityCard = (string) myReader["IdentityCard"];
			obj.LastLoggedOn = (DateTime) myReader["LastLoggedOn"];
			obj.CreatedDate = (DateTime) myReader["CreatedDate"];
			obj.GroupID = (string) myReader["GroupID"];
			obj.Active = (string) myReader["Active"];
			obj.Ord = (string) myReader["Ord"];
            obj.Level = (string)myReader["Level"];
            obj.Admin = (string)myReader["Admin"];
			return obj;
		}

		/// <summary>
		/// Get Users by userid
		/// </summary>
		/// <param name="userid">UserID</param>
		/// <returns>Users</returns>
		public Users GetByUserID(string userid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Users_GetByUserID", Data.CreateParameter("UserID", userid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

	    public List<Users> GetByListId(string userid)
	    {
            
            using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Users_GetByUserID", Data.CreateParameter("UserID", userid)))
            {
                List<Users> list = new List<Users>();
                while (reader.Read())
                {
                    list.Add(Populate(reader));
                }
                return list;
            }
	        
	    } 
		/// <summary>
		/// Get all of Users
		/// </summary>
		/// <returns>List<<Users>></returns>
		public List<Users> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Users_Get"))
			{
				List<Users> list = new List<Users>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Users
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Users_Get");
		}


		/// <summary>
		/// Get all of Users paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<Users>></returns>
		public List<Users> GetListPaged(string recperpage, string pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Users_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<Users> list = new List<Users>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Users paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(string recperpage, string pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Users_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Users within Users database table
		/// </summary>
		/// <param name="obj">Users</param>
		/// <returns>key of table</returns>
		public string Add(Users obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("UserID", obj.UserID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Users_Add"
							,parameterItemID
							,Data.CreateParameter("UserName", obj.UserName)
							,Data.CreateParameter("Password", obj.Password)
							,Data.CreateParameter("FullName", obj.FullName)
							,Data.CreateParameter("Role", obj.Role)
							,Data.CreateParameter("Gender", obj.Gender)
							,Data.CreateParameter("Avatar", obj.Avatar)
							,Data.CreateParameter("Birthday", obj.Birthday)
							,Data.CreateParameter("Email", obj.Email)
							,Data.CreateParameter("Address", obj.Address)
							,Data.CreateParameter("MobilePhone", obj.MobilePhone)
							,Data.CreateParameter("IdentityCard", obj.IdentityCard)
							,Data.CreateParameter("LastLoggedOn", obj.LastLoggedOn)
							,Data.CreateParameter("CreatedDate", obj.CreatedDate)
							,Data.CreateParameter("GroupID", obj.GroupID)
							,Data.CreateParameter("Active", obj.Active)
							,Data.CreateParameter("Ord", obj.Ord)
                            , Data.CreateParameter("Level", obj.Level)
                            , Data.CreateParameter("Admin", obj.Admin)
			);
			return (string)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified Users
		/// </summary>
		/// <param name="obj">Users</param>
		/// <returns></returns>
		public void Update(Users obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Users_Update"
							,Data.CreateParameter("UserID", obj.UserID)
                            , Data.CreateParameter("UserName", obj.UserName)
                            , Data.CreateParameter("Password", obj.Password)
                            , Data.CreateParameter("FullName", obj.FullName)
                            , Data.CreateParameter("Role", obj.Role)
                            , Data.CreateParameter("Gender", obj.Gender)
                            , Data.CreateParameter("Avatar", obj.Avatar)
                            , Data.CreateParameter("Birthday", obj.Birthday)
                            , Data.CreateParameter("Email", obj.Email)
                            , Data.CreateParameter("Address", obj.Address)
                            , Data.CreateParameter("MobilePhone", obj.MobilePhone)
                            , Data.CreateParameter("IdentityCard", obj.IdentityCard)
                            , Data.CreateParameter("LastLoggedOn", obj.LastLoggedOn)
                            , Data.CreateParameter("CreatedDate", obj.CreatedDate)
                            , Data.CreateParameter("GroupID", obj.GroupID)
                            , Data.CreateParameter("Active", obj.Active)
                            , Data.CreateParameter("Ord", obj.Ord)
                            , Data.CreateParameter("Level", obj.Level)
                            , Data.CreateParameter("Admin", obj.Admin)
			);
		}

		/// <summary>
		/// Delete the specified Users
		/// </summary>
		/// <param name="userid">UserID</param>
		/// <returns></returns>
		public void Delete(string userid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Users_Delete", Data.CreateParameter("UserID", userid));
		}
		#endregion
	}
}
