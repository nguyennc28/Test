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
	public class CompanysBL
	{

		#region ***** Init Methods ***** 
		CompanysDA objCompanysDA;
		public CompanysBL()
		{
			objCompanysDA = new CompanysDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get Companys by companyid
		/// </summary>
		/// <param name="companyid">CompanyID</param>
		/// <returns>Companys</returns>
		public Companys GetByCompanyID(int companyid)
		{
			return objCompanysDA.GetByCompanyID(companyid);
		}

		/// <summary>
		/// Get all of Companys
		/// </summary>
		/// <returns>List<<Companys>></returns>
		public List<Companys> GetList()
		{
			string cacheName = "lstCompanys";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objCompanysDA.GetList(), "Companys");
			}
			return (List<Companys>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of Companys
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsCompanys";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objCompanysDA.GetDataSet(), "Companys");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of Companys paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<Companys>></returns>
		public List<Companys> GetListPaged(int recperpage, int pageindex)
		{
			return objCompanysDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of Companys paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objCompanysDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Companys within Companys database table
		/// </summary>
		/// <param name="obj_companys">Companys</param>
		/// <returns>key of table</returns>
		public int Add(Companys obj_companys)
		{
			ServerCache.Remove("Companys", true);
			return objCompanysDA.Add(obj_companys);
		}

		/// <summary>
		/// updates the specified Companys
		/// </summary>
		/// <param name="obj_companys">Companys</param>
		/// <returns></returns>
		public void Update(Companys obj_companys)
		{
			ServerCache.Remove("Companys", true);
			objCompanysDA.Update(obj_companys);
		}

		/// <summary>
		/// Delete the specified Companys
		/// </summary>
		/// <param name="companyid">CompanyID</param>
		/// <returns></returns>
		public void Delete(int companyid)
		{
			ServerCache.Remove("Companys", true);
			objCompanysDA.Delete(companyid);
		}
		#endregion
	}
}
