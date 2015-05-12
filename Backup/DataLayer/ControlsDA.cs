using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class ControlsDA
	{

		#region ***** Init Methods ***** 
		public ControlsDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Controls Populate(IDataReader myReader)
		{
			Controls obj = new Controls();
			obj.ControlID = (int) myReader["ControlID"];
			obj.PageId = (int) myReader["PageId"];
			obj.Name = (string) myReader["Name"];
			obj.Path = (string) myReader["Path"];
			obj.Param = (string) myReader["Param"];
			obj.Status = (Int64) myReader["Status"];
			obj.Priority = (int) myReader["Priority"];
			return obj;
		}

		/// <summary>
		/// Get Controls by controlid
		/// </summary>
		/// <param name="controlid">ControlID</param>
		/// <returns>Controls</returns>
		public Controls GetByControlID(int controlid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Controls_GetByControlID", Data.CreateParameter("ControlID", controlid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of Controls
		/// </summary>
		/// <returns>List<<Controls>></returns>
		public List<Controls> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Controls_Get"))
			{
				List<Controls> list = new List<Controls>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Controls
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Controls_Get");
		}


		/// <summary>
		/// Get all of Controls paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<Controls>></returns>
		public List<Controls> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Controls_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<Controls> list = new List<Controls>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Controls paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Controls_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Controls within Controls database table
		/// </summary>
		/// <param name="obj">Controls</param>
		/// <returns>key of table</returns>
		public int Add(Controls obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("ControlID", obj.ControlID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Controls_Add"
							,parameterItemID
							,Data.CreateParameter("PageId", obj.PageId)
							,Data.CreateParameter("Name", obj.Name)
							,Data.CreateParameter("Path", obj.Path)
							,Data.CreateParameter("Param", obj.Param)
							,Data.CreateParameter("Status", obj.Status)
							,Data.CreateParameter("Priority", obj.Priority)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified Controls
		/// </summary>
		/// <param name="obj">Controls</param>
		/// <returns></returns>
		public void Update(Controls obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Controls_Update"
							,Data.CreateParameter("ControlID", obj.ControlID)
							,Data.CreateParameter("PageId", obj.PageId)
							,Data.CreateParameter("Name", obj.Name)
							,Data.CreateParameter("Path", obj.Path)
							,Data.CreateParameter("Param", obj.Param)
							,Data.CreateParameter("Status", obj.Status)
							,Data.CreateParameter("Priority", obj.Priority)
			);
		}

		/// <summary>
		/// Delete the specified Controls
		/// </summary>
		/// <param name="controlid">ControlID</param>
		/// <returns></returns>
		public void Delete(int controlid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Controls_Delete", Data.CreateParameter("ControlID", controlid));
		}
		#endregion
	}
}
