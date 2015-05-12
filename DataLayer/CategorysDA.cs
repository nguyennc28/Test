using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class CategorysDA
	{

		#region ***** Init Methods ***** 
		public CategorysDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Categorys Populate(IDataReader myReader)
		{
			Categorys obj = new Categorys();
			obj.CategoryID = (int) myReader["CategoryID"];
			obj.Tag = (string) myReader["Tag"];
			obj.Name = (string) myReader["Name"];
			obj.Content = (string) myReader["Content"];
			obj.Level = (string) myReader["Level"];
			obj.Priority = (int) myReader["Priority"];
			obj.Index = (int) myReader["Index"];
			obj.Title = (string) myReader["Title"];
			obj.Description = (string) myReader["Description"];
			obj.Keyword = (string) myReader["Keyword"];
			obj.Active = (int) myReader["Active"];
			obj.Ord = (int) myReader["Ord"];
			obj.Lang = (string) myReader["Lang"];
			obj.Image = (string) myReader["Image"];
			obj.Image2 = (string) myReader["Image2"];
			return obj;
		}

		/// <summary>
		/// Get Categorys by categoryid
		/// </summary>
		/// <param name="categoryid">CategoryID</param>
		/// <returns>Categorys</returns>
		public Categorys GetByCategoryID(int categoryid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Categorys_GetByCategoryID", Data.CreateParameter("CategoryID", categoryid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of Categorys
		/// </summary>
		/// <returns>List<<Categorys>></returns>
		public List<Categorys> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Categorys_Get"))
			{
				List<Categorys> list = new List<Categorys>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Categorys
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Categorys_Get");
		}


		/// <summary>
		/// Get all of Categorys paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<Categorys>></returns>
		public List<Categorys> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Categorys_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<Categorys> list = new List<Categorys>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Categorys paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Categorys_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Categorys within Categorys database table
		/// </summary>
		/// <param name="obj">Categorys</param>
		/// <returns>key of table</returns>
		public int Add(Categorys obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("CategoryID", obj.CategoryID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Categorys_Add"
							,parameterItemID
							,Data.CreateParameter("Tag", obj.Tag)
							,Data.CreateParameter("Name", obj.Name)
							,Data.CreateParameter("Content", obj.Content)
							,Data.CreateParameter("Level", obj.Level)
							,Data.CreateParameter("Priority", obj.Priority)
							,Data.CreateParameter("Index", obj.Index)
							,Data.CreateParameter("Title", obj.Title)
							,Data.CreateParameter("Description", obj.Description)
							,Data.CreateParameter("Keyword", obj.Keyword)
							,Data.CreateParameter("Active", obj.Active)
							,Data.CreateParameter("Ord", obj.Ord)
							,Data.CreateParameter("Lang", obj.Lang)
							,Data.CreateParameter("Image", obj.Image)
							,Data.CreateParameter("Image2", obj.Image2)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified Categorys
		/// </summary>
		/// <param name="obj">Categorys</param>
		/// <returns></returns>
		public void Update(Categorys obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Categorys_Update"
							,Data.CreateParameter("CategoryID", obj.CategoryID)
							,Data.CreateParameter("Tag", obj.Tag)
							,Data.CreateParameter("Name", obj.Name)
							,Data.CreateParameter("Content", obj.Content)
							,Data.CreateParameter("Level", obj.Level)
							,Data.CreateParameter("Priority", obj.Priority)
							,Data.CreateParameter("Index", obj.Index)
							,Data.CreateParameter("Title", obj.Title)
							,Data.CreateParameter("Description", obj.Description)
							,Data.CreateParameter("Keyword", obj.Keyword)
							,Data.CreateParameter("Active", obj.Active)
							,Data.CreateParameter("Ord", obj.Ord)
							,Data.CreateParameter("Lang", obj.Lang)
							,Data.CreateParameter("Image", obj.Image)
							,Data.CreateParameter("Image2", obj.Image2)
			);
		}

		/// <summary>
		/// Delete the specified Categorys
		/// </summary>
		/// <param name="categoryid">CategoryID</param>
		/// <returns></returns>
		public void Delete(int categoryid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Categorys_Delete", Data.CreateParameter("CategoryID", categoryid));
		}
		#endregion
	}
}
