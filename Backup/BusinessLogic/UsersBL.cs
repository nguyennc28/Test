using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;
using RealEstate.DataAccess;

namespace RealEstate.BusinessLogic
{
	public class UsersBL
	{

		#region ***** Init Methods ***** 
		UsersDA objUsersDA;
		public UsersBL()
		{
			objUsersDA = new UsersDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get Users by userid
		/// </summary>
		/// <param name="userid">UserID</param>
		/// <returns>Users</returns>
		public Users GetByUserID(int userid)
		{
			return objUsersDA.GetByUserID(userid);
		}

		/// <summary>
		/// Get all of Users
		/// </summary>
		/// <returns>List<<Users>></returns>
		public List<Users> GetList()
		{
			string cacheName = "lstUsers";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objUsersDA.GetList(), "Users");
			}
			return (List<Users>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of Users
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsUsers";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objUsersDA.GetDataSet(), "Users");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of Users paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<Users>></returns>
		public List<Users> GetListPaged(int recperpage, int pageindex)
		{
			return objUsersDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of Users paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objUsersDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Users within Users database table
		/// </summary>
		/// <param name="obj_users">Users</param>
		/// <returns>key of table</returns>
		public int Add(Users obj_users)
		{
			ServerCache.Remove("Users", true);
			return objUsersDA.Add(obj_users);
		}

		/// <summary>
		/// updates the specified Users
		/// </summary>
		/// <param name="obj_users">Users</param>
		/// <returns></returns>
		public void Update(Users obj_users)
		{
			ServerCache.Remove("Users", true);
			objUsersDA.Update(obj_users);
		}

		/// <summary>
		/// Delete the specified Users
		/// </summary>
		/// <param name="userid">UserID</param>
		/// <returns></returns>
		public void Delete(int userid)
		{
			ServerCache.Remove("Users", true);
			objUsersDA.Delete(userid);
		}
		#endregion
	}
}
