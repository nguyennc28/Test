using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class GroupDA
	{

		#region ***** Init Methods ***** 
		public GroupDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Group Populate(IDataReader myReader)
		{
			Group obj = new Group();
			obj.GroupID = (int) myReader["GroupID"];
			obj.ParentID = (int) myReader["ParentID"];
			obj.GroupName = (string) myReader["GroupName"];
			obj.Description = (string) myReader["Description"];
			obj.Status = (Byte) myReader["Status"];
			obj.Priority = (int) myReader["Priority"];
			obj.SwitchGroup = (string) myReader["SwitchGroup"];
			return obj;
		}

		/// <summary>
		/// Get Group by groupid
		/// </summary>
		/// <param name="groupid">GroupID</param>
		/// <returns>Group</returns>
		public Group GetByGroupID(int groupid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Group_GetByGroupID", Data.CreateParameter("GroupID", groupid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of Group
		/// </summary>
		/// <returns>List<<Group>></returns>
		public List<Group> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Group_Get"))
			{
				List<Group> list = new List<Group>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Group
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Group_Get");
		}


		/// <summary>
		/// Get all of Group paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<Group>></returns>
		public List<Group> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Group_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<Group> list = new List<Group>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Group paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Group_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Group within Group database table
		/// </summary>
		/// <param name="obj">Group</param>
		/// <returns>key of table</returns>
		public int Add(Group obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("GroupID", obj.GroupID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Group_Add"
							,parameterItemID
							,Data.CreateParameter("ParentID", obj.ParentID)
							,Data.CreateParameter("GroupName", obj.GroupName)
							,Data.CreateParameter("Description", obj.Description)
							,Data.CreateParameter("Status", obj.Status)
							,Data.CreateParameter("Priority", obj.Priority)
							,Data.CreateParameter("SwitchGroup", obj.SwitchGroup)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified Group
		/// </summary>
		/// <param name="obj">Group</param>
		/// <returns></returns>
		public void Update(Group obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Group_Update"
							,Data.CreateParameter("GroupID", obj.GroupID)
							,Data.CreateParameter("ParentID", obj.ParentID)
							,Data.CreateParameter("GroupName", obj.GroupName)
							,Data.CreateParameter("Description", obj.Description)
							,Data.CreateParameter("Status", obj.Status)
							,Data.CreateParameter("Priority", obj.Priority)
							,Data.CreateParameter("SwitchGroup", obj.SwitchGroup)
			);
		}

		/// <summary>
		/// Delete the specified Group
		/// </summary>
		/// <param name="groupid">GroupID</param>
		/// <returns></returns>
		public void Delete(int groupid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Group_Delete", Data.CreateParameter("GroupID", groupid));
		}
		#endregion
	}
}
