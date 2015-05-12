using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class MenusDA
	{

		#region ***** Init Methods ***** 
		public MenusDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Menus Populate(IDataReader myReader)
		{
			Menus obj = new Menus();
			obj.MenuID = (int) myReader["MenuID"];
			obj.ParentID = (int) myReader["ParentID"];
			obj.PageID = (int) myReader["PageID"];
			obj.MenuName = (string) myReader["MenuName"];
			obj.Position = (int) myReader["Position"];
			obj.Status = (Int64) myReader["Status"];
			obj.Priority = (int) myReader["Priority"];
			obj.Param = (string) myReader["Param"];
			obj.GroupID = (int) myReader["GroupID"];
			return obj;
		}

		/// <summary>
		/// Get Menus by menuid
		/// </summary>
		/// <param name="menuid">MenuID</param>
		/// <returns>Menus</returns>
		public Menus GetByMenuID(int menuid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Menus_GetByMenuID", Data.CreateParameter("MenuID", menuid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of Menus
		/// </summary>
		/// <returns>List<<Menus>></returns>
		public List<Menus> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Menus_Get"))
			{
				List<Menus> list = new List<Menus>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Menus
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Menus_Get");
		}


		/// <summary>
		/// Get all of Menus paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<Menus>></returns>
		public List<Menus> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Menus_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<Menus> list = new List<Menus>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Menus paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Menus_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Menus within Menus database table
		/// </summary>
		/// <param name="obj">Menus</param>
		/// <returns>key of table</returns>
		public int Add(Menus obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("MenuID", obj.MenuID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Menus_Add"
							,parameterItemID
							,Data.CreateParameter("ParentID", obj.ParentID)
							,Data.CreateParameter("PageID", obj.PageID)
							,Data.CreateParameter("MenuName", obj.MenuName)
							,Data.CreateParameter("Position", obj.Position)
							,Data.CreateParameter("Status", obj.Status)
							,Data.CreateParameter("Priority", obj.Priority)
							,Data.CreateParameter("Param", obj.Param)
							,Data.CreateParameter("GroupID", obj.GroupID)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified Menus
		/// </summary>
		/// <param name="obj">Menus</param>
		/// <returns></returns>
		public void Update(Menus obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Menus_Update"
							,Data.CreateParameter("MenuID", obj.MenuID)
							,Data.CreateParameter("ParentID", obj.ParentID)
							,Data.CreateParameter("PageID", obj.PageID)
							,Data.CreateParameter("MenuName", obj.MenuName)
							,Data.CreateParameter("Position", obj.Position)
							,Data.CreateParameter("Status", obj.Status)
							,Data.CreateParameter("Priority", obj.Priority)
							,Data.CreateParameter("Param", obj.Param)
							,Data.CreateParameter("GroupID", obj.GroupID)
			);
		}

		/// <summary>
		/// Delete the specified Menus
		/// </summary>
		/// <param name="menuid">MenuID</param>
		/// <returns></returns>
		public void Delete(int menuid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Menus_Delete", Data.CreateParameter("MenuID", menuid));
		}
		#endregion
	}
}
