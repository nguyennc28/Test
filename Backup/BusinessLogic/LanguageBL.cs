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
	public class LanguageBL
	{

		#region ***** Init Methods ***** 
		LanguageDA objLanguageDA;
		public LanguageBL()
		{
			objLanguageDA = new LanguageDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get Language by languageid
		/// </summary>
		/// <param name="languageid">LanguageId</param>
		/// <returns>Language</returns>
		public Language GetByLanguageId(int languageid)
		{
			return objLanguageDA.GetByLanguageId(languageid);
		}

		/// <summary>
		/// Get all of Language
		/// </summary>
		/// <returns>List<<Language>></returns>
		public List<Language> GetList()
		{
			string cacheName = "lstLanguage";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objLanguageDA.GetList(), "Language");
			}
			return (List<Language>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of Language
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsLanguage";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objLanguageDA.GetDataSet(), "Language");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of Language paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<Language>></returns>
		public List<Language> GetListPaged(int recperpage, int pageindex)
		{
			return objLanguageDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of Language paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objLanguageDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Language within Language database table
		/// </summary>
		/// <param name="obj_language">Language</param>
		/// <returns>key of table</returns>
		public int Add(Language obj_language)
		{
			ServerCache.Remove("Language", true);
			return objLanguageDA.Add(obj_language);
		}

		/// <summary>
		/// updates the specified Language
		/// </summary>
		/// <param name="obj_language">Language</param>
		/// <returns></returns>
		public void Update(Language obj_language)
		{
			ServerCache.Remove("Language", true);
			objLanguageDA.Update(obj_language);
		}

		/// <summary>
		/// Delete the specified Language
		/// </summary>
		/// <param name="languageid">LanguageId</param>
		/// <returns></returns>
		public void Delete(int languageid)
		{
			ServerCache.Remove("Language", true);
			objLanguageDA.Delete(languageid);
		}
		#endregion
	}
}
