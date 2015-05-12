using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class PagesDA
	{

		#region ***** Init Methods ***** 
		public PagesDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Pages Populate(IDataReader myReader)
		{
			Pages obj = new Pages();
			obj.PageID = (int) myReader["PageID"];
			obj.Name = (string) myReader["Name"];
			obj.Tag = (string) myReader["Tag"];
			obj.Conntent = (string) myReader["Conntent"];
			obj.Detail = (string) myReader["Detail"];
			obj.Level = (int) myReader["Level"];
			obj.Title = (string) myReader["Title"];
			obj.Description = (string) myReader["Description"];
			obj.Keyword = (string) myReader["Keyword"];
			obj.Type = (string) myReader["Type"];
			obj.Link = (string) myReader["Link"];
			obj.Taget = (string) myReader["Taget"];
			obj.Position = (int) myReader["Position"];
			obj.Index = (int) myReader["Index"];
			obj.Active = (int) myReader["Active"];
			obj.Lang = (string) myReader["Lang"];
			obj.Ord = (int) myReader["Ord"];
			return obj;
		}

		/// <summary>
		/// Get Pages by pageid
		/// </summary>
		/// <param name="pageid">PageID</param>
		/// <returns>Pages</returns>
		public Pages GetByPageID(int pageid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Pages_GetByPageID", Data.CreateParameter("PageID", pageid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of Pages
		/// </summary>
		/// <returns>List<<Pages>></returns>
		public List<Pages> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Pages_Get"))
			{
				List<Pages> list = new List<Pages>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Pages
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Pages_Get");
		}


		/// <summary>
		/// Get all of Pages paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<Pages>></returns>
		public List<Pages> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Pages_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<Pages> list = new List<Pages>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Pages paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Pages_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Pages within Pages database table
		/// </summary>
		/// <param name="obj">Pages</param>
		/// <returns>key of table</returns>
		public int Add(Pages obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("PageID", obj.PageID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Pages_Add"
							,parameterItemID
							,Data.CreateParameter("Name", obj.Name)
							,Data.CreateParameter("Tag", obj.Tag)
							,Data.CreateParameter("Conntent", obj.Conntent)
							,Data.CreateParameter("Detail", obj.Detail)
							,Data.CreateParameter("Level", obj.Level)
							,Data.CreateParameter("Title", obj.Title)
							,Data.CreateParameter("Description", obj.Description)
							,Data.CreateParameter("Keyword", obj.Keyword)
							,Data.CreateParameter("Type", obj.Type)
							,Data.CreateParameter("Link", obj.Link)
							,Data.CreateParameter("Taget", obj.Taget)
							,Data.CreateParameter("Position", obj.Position)
							,Data.CreateParameter("Index", obj.Index)
							,Data.CreateParameter("Active", obj.Active)
							,Data.CreateParameter("Lang", obj.Lang)
							,Data.CreateParameter("Ord", obj.Ord)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified Pages
		/// </summary>
		/// <param name="obj">Pages</param>
		/// <returns></returns>
		public void Update(Pages obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Pages_Update"
							,Data.CreateParameter("PageID", obj.PageID)
							,Data.CreateParameter("Name", obj.Name)
							,Data.CreateParameter("Tag", obj.Tag)
							,Data.CreateParameter("Conntent", obj.Conntent)
							,Data.CreateParameter("Detail", obj.Detail)
							,Data.CreateParameter("Level", obj.Level)
							,Data.CreateParameter("Title", obj.Title)
							,Data.CreateParameter("Description", obj.Description)
							,Data.CreateParameter("Keyword", obj.Keyword)
							,Data.CreateParameter("Type", obj.Type)
							,Data.CreateParameter("Link", obj.Link)
							,Data.CreateParameter("Taget", obj.Taget)
							,Data.CreateParameter("Position", obj.Position)
							,Data.CreateParameter("Index", obj.Index)
							,Data.CreateParameter("Active", obj.Active)
							,Data.CreateParameter("Lang", obj.Lang)
							,Data.CreateParameter("Ord", obj.Ord)
			);
		}

		/// <summary>
		/// Delete the specified Pages
		/// </summary>
		/// <param name="pageid">PageID</param>
		/// <returns></returns>
		public void Delete(int pageid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Pages_Delete", Data.CreateParameter("PageID", pageid));
		}
		#endregion
	}
}
