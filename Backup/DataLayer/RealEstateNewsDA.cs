using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class RealEstateNewsDA
	{

		#region ***** Init Methods ***** 
		public RealEstateNewsDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public RealEstateNews Populate(IDataReader myReader)
		{
			RealEstateNews obj = new RealEstateNews();
			obj.RealEstateNewsID = (int) myReader["RealEstateNewsID"];
			obj.RealEstateID = (int) myReader["RealEstateID"];
			obj.Title = (string) myReader["Title"];
			obj.Content = (string) myReader["Content"];
			obj.CategoryID = (int) myReader["CategoryID"];
			obj.Images = (string) myReader["Images"];
			obj.CreateDate = (DateTime) myReader["CreateDate"];
			obj.CreateBy = (DateTime) myReader["CreateBy"];
			obj.Source = (string) myReader["Source"];
			return obj;
		}

		/// <summary>
		/// Get RealEstateNews by realestatenewsid
		/// </summary>
		/// <param name="realestatenewsid">RealEstateNewsID</param>
		/// <returns>RealEstateNews</returns>
		public RealEstateNews GetByRealEstateNewsID(int realestatenewsid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_RealEstateNews_GetByRealEstateNewsID", Data.CreateParameter("RealEstateNewsID", realestatenewsid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of RealEstateNews
		/// </summary>
		/// <returns>List<<RealEstateNews>></returns>
		public List<RealEstateNews> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_RealEstateNews_Get"))
			{
				List<RealEstateNews> list = new List<RealEstateNews>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of RealEstateNews
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstateNews_Get");
		}


		/// <summary>
		/// Get all of RealEstateNews paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<RealEstateNews>></returns>
		public List<RealEstateNews> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_RealEstateNews_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<RealEstateNews> list = new List<RealEstateNews>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of RealEstateNews paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstateNews_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new RealEstateNews within RealEstateNews database table
		/// </summary>
		/// <param name="obj">RealEstateNews</param>
		/// <returns>key of table</returns>
		public int Add(RealEstateNews obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("RealEstateNewsID", obj.RealEstateNewsID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstateNews_Add"
							,parameterItemID
							,Data.CreateParameter("RealEstateID", obj.RealEstateID)
							,Data.CreateParameter("Title", obj.Title)
							,Data.CreateParameter("Content", obj.Content)
							,Data.CreateParameter("CategoryID", obj.CategoryID)
							,Data.CreateParameter("Images", obj.Images)
							,Data.CreateParameter("CreateDate", obj.CreateDate)
							,Data.CreateParameter("CreateBy", obj.CreateBy)
							,Data.CreateParameter("Source", obj.Source)
			);
			return 0;
		}

		/// <summary>
		/// updates the specified RealEstateNews
		/// </summary>
		/// <param name="obj">RealEstateNews</param>
		/// <returns></returns>
		public void Update(RealEstateNews obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstateNews_Update"
							,Data.CreateParameter("RealEstateNewsID", obj.RealEstateNewsID)
							,Data.CreateParameter("RealEstateID", obj.RealEstateID)
							,Data.CreateParameter("Title", obj.Title)
							,Data.CreateParameter("Content", obj.Content)
							,Data.CreateParameter("CategoryID", obj.CategoryID)
							,Data.CreateParameter("Images", obj.Images)
							,Data.CreateParameter("CreateDate", obj.CreateDate)
							,Data.CreateParameter("CreateBy", obj.CreateBy)
							,Data.CreateParameter("Source", obj.Source)
			);
		}

		/// <summary>
		/// Delete the specified RealEstateNews
		/// </summary>
		/// <param name="realestatenewsid">RealEstateNewsID</param>
		/// <returns></returns>
		public void Delete(int realestatenewsid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_RealEstateNews_Delete", Data.CreateParameter("RealEstateNewsID", realestatenewsid));
		}
		#endregion
	}
}
