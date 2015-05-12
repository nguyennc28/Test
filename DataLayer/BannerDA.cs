using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class BannerDA
	{

		#region ***** Init Methods ***** 
		public BannerDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Banner Populate(IDataReader myReader)
		{
			Banner obj = new Banner();
			obj.BannerID = (int) myReader["BannerID"];
			obj.BannerType = (string) myReader["BannerType"];
			obj.Size = (string) myReader["Size"];
			obj.Description = (string) myReader["Description"];
			obj.Images = (string) myReader["Images"];
			return obj;
		}

		/// <summary>
		/// Get Banner by bannerid
		/// </summary>
		/// <param name="bannerid">BannerID</param>
		/// <returns>Banner</returns>
		public Banner GetByBannerID(int bannerid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Banner_GetByBannerID", Data.CreateParameter("BannerID", bannerid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of Banner
		/// </summary>
		/// <returns>List<<Banner>></returns>
		public List<Banner> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Banner_Get"))
			{
				List<Banner> list = new List<Banner>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Banner
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Banner_Get");
		}


		/// <summary>
		/// Get all of Banner paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<Banner>></returns>
		public List<Banner> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Banner_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<Banner> list = new List<Banner>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Banner paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Banner_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Banner within Banner database table
		/// </summary>
		/// <param name="obj">Banner</param>
		/// <returns>key of table</returns>
		public int Add(Banner obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("BannerID", obj.BannerID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Banner_Add"
							,parameterItemID
							,Data.CreateParameter("BannerType", obj.BannerType)
							,Data.CreateParameter("Size", obj.Size)
							,Data.CreateParameter("Description", obj.Description)
							,Data.CreateParameter("Images", obj.Images)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified Banner
		/// </summary>
		/// <param name="obj">Banner</param>
		/// <returns></returns>
		public void Update(Banner obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Banner_Update"
							,Data.CreateParameter("BannerID", obj.BannerID)
							,Data.CreateParameter("BannerType", obj.BannerType)
							,Data.CreateParameter("Size", obj.Size)
							,Data.CreateParameter("Description", obj.Description)
							,Data.CreateParameter("Images", obj.Images)
			);
		}

		/// <summary>
		/// Delete the specified Banner
		/// </summary>
		/// <param name="bannerid">BannerID</param>
		/// <returns></returns>
		public void Delete(int bannerid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Banner_Delete", Data.CreateParameter("BannerID", bannerid));
		}
		#endregion
	}
}
