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
	public class GroupBL
	{

		#region ***** Init Methods ***** 
		GroupDA objGroupDA;
		public GroupBL()
		{
			objGroupDA = new GroupDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get Group by groupid
		/// </summary>
		/// <param name="groupid">GroupID</param>
		/// <returns>Group</returns>
		public Group GetByGroupID(int groupid)
		{
			return objGroupDA.GetByGroupID(groupid);
		}

		/// <summary>
		/// Get all of Group
		/// </summary>
		/// <returns>List<<Group>></returns>
		public List<Group> GetList()
		{
			string cacheName = "lstGroup";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objGroupDA.GetList(), "Group");
			}
			return (List<Group>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of Group
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsGroup";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objGroupDA.GetDataSet(), "Group");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of Group paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<Group>></returns>
		public List<Group> GetListPaged(int recperpage, int pageindex)
		{
			return objGroupDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of Group paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objGroupDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Group within Group database table
		/// </summary>
		/// <param name="obj_group">Group</param>
		/// <returns>key of table</returns>
		public int Add(Group obj_group)
		{
			ServerCache.Remove("Group", true);
			return objGroupDA.Add(obj_group);
		}

		/// <summary>
		/// updates the specified Group
		/// </summary>
		/// <param name="obj_group">Group</param>
		/// <returns></returns>
		public void Update(Group obj_group)
		{
			ServerCache.Remove("Group", true);
			objGroupDA.Update(obj_group);
		}

		/// <summary>
		/// Delete the specified Group
		/// </summary>
		/// <param name="groupid">GroupID</param>
		/// <returns></returns>
		public void Delete(int groupid)
		{
			ServerCache.Remove("Group", true);
			objGroupDA.Delete(groupid);
		}
		#endregion
	}
}
