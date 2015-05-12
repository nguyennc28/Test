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
	public class RealEstateNewsBL
	{

		#region ***** Init Methods ***** 
		RealEstateNewsDA objRealEstateNewsDA;
		public RealEstateNewsBL()
		{
			objRealEstateNewsDA = new RealEstateNewsDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get RealEstateNews by realestatenewsid
		/// </summary>
		/// <param name="realestatenewsid">RealEstateNewsID</param>
		/// <returns>RealEstateNews</returns>
		public RealEstateNews GetByRealEstateNewsID(int realestatenewsid)
		{
			return objRealEstateNewsDA.GetByRealEstateNewsID(realestatenewsid);
		}

		/// <summary>
		/// Get all of RealEstateNews
		/// </summary>
		/// <returns>List<<RealEstateNews>></returns>
		public List<RealEstateNews> GetList()
		{
			string cacheName = "lstRealEstateNews";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objRealEstateNewsDA.GetList(), "RealEstateNews");
			}
			return (List<RealEstateNews>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of RealEstateNews
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsRealEstateNews";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objRealEstateNewsDA.GetDataSet(), "RealEstateNews");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of RealEstateNews paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<RealEstateNews>></returns>
		public List<RealEstateNews> GetListPaged(int recperpage, int pageindex)
		{
			return objRealEstateNewsDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of RealEstateNews paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objRealEstateNewsDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new RealEstateNews within RealEstateNews database table
		/// </summary>
		/// <param name="obj_realestatenews">RealEstateNews</param>
		/// <returns>key of table</returns>
		public int Add(RealEstateNews obj_realestatenews)
		{
			ServerCache.Remove("RealEstateNews", true);
			return objRealEstateNewsDA.Add(obj_realestatenews);
		}

		/// <summary>
		/// updates the specified RealEstateNews
		/// </summary>
		/// <param name="obj_realestatenews">RealEstateNews</param>
		/// <returns></returns>
		public void Update(RealEstateNews obj_realestatenews)
		{
			ServerCache.Remove("RealEstateNews", true);
			objRealEstateNewsDA.Update(obj_realestatenews);
		}

		/// <summary>
		/// Delete the specified RealEstateNews
		/// </summary>
		/// <param name="realestatenewsid">RealEstateNewsID</param>
		/// <returns></returns>
		public void Delete(int realestatenewsid)
		{
			ServerCache.Remove("RealEstateNews", true);
			objRealEstateNewsDA.Delete(realestatenewsid);
		}
		#endregion
	}
}
