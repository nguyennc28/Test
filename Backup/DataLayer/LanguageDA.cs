using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class LanguageDA
	{

		#region ***** Init Methods ***** 
		public LanguageDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Language Populate(IDataReader myReader)
		{
			Language obj = new Language();
			obj.LanguageId = (int) myReader["LanguageId"];
			obj.Name = (string) myReader["Name"];
			obj.ResourceFile = (string) myReader["ResourceFile"];
			obj.LanguageText = (string) myReader["LanguageText"];
			return obj;
		}

		/// <summary>
		/// Get Language by languageid
		/// </summary>
		/// <param name="languageid">LanguageId</param>
		/// <returns>Language</returns>
		public Language GetByLanguageId(int languageid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Language_GetByLanguageId", Data.CreateParameter("LanguageId", languageid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of Language
		/// </summary>
		/// <returns>List<<Language>></returns>
		public List<Language> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Language_Get"))
			{
				List<Language> list = new List<Language>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Language
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Language_Get");
		}


		/// <summary>
		/// Get all of Language paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<Language>></returns>
		public List<Language> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Language_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<Language> list = new List<Language>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Language paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Language_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Language within Language database table
		/// </summary>
		/// <param name="obj">Language</param>
		/// <returns>key of table</returns>
		public int Add(Language obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("LanguageId", obj.LanguageId);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Language_Add"
							,parameterItemID
							,Data.CreateParameter("Name", obj.Name)
							,Data.CreateParameter("ResourceFile", obj.ResourceFile)
							,Data.CreateParameter("LanguageText", obj.LanguageText)
			);
			return (int)parameterItemID.Value;
		}

		/// <summary>
		/// updates the specified Language
		/// </summary>
		/// <param name="obj">Language</param>
		/// <returns></returns>
		public void Update(Language obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Language_Update"
							,Data.CreateParameter("LanguageId", obj.LanguageId)
							,Data.CreateParameter("Name", obj.Name)
							,Data.CreateParameter("ResourceFile", obj.ResourceFile)
							,Data.CreateParameter("LanguageText", obj.LanguageText)
			);
		}

		/// <summary>
		/// Delete the specified Language
		/// </summary>
		/// <param name="languageid">LanguageId</param>
		/// <returns></returns>
		public void Delete(int languageid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Language_Delete", Data.CreateParameter("LanguageId", languageid));
		}
		#endregion
	}
}
