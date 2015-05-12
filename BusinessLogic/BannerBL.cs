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
	public class BannerBL
	{

		#region ***** Init Methods ***** 
		BannerDA objBannerDA;
		public BannerBL()
		{
			objBannerDA = new BannerDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get Banner by bannerid
		/// </summary>
		/// <param name="bannerid">BannerID</param>
		/// <returns>Banner</returns>
		public Banner GetByBannerID(int bannerid)
		{
			return objBannerDA.GetByBannerID(bannerid);
		}

		/// <summary>
		/// Get all of Banner
		/// </summary>
		/// <returns>List<<Banner>></returns>
		public List<Banner> GetList()
		{
			string cacheName = "lstBanner";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objBannerDA.GetList(), "Banner");
			}
			return (List<Banner>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of Banner
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsBanner";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objBannerDA.GetDataSet(), "Banner");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of Banner paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<Banner>></returns>
		public List<Banner> GetListPaged(int recperpage, int pageindex)
		{
			return objBannerDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of Banner paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objBannerDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Banner within Banner database table
		/// </summary>
		/// <param name="obj_banner">Banner</param>
		/// <returns>key of table</returns>
		public int Add(Banner obj_banner)
		{
			ServerCache.Remove("Banner", true);
			return objBannerDA.Add(obj_banner);
		}

		/// <summary>
		/// updates the specified Banner
		/// </summary>
		/// <param name="obj_banner">Banner</param>
		/// <returns></returns>
		public void Update(Banner obj_banner)
		{
			ServerCache.Remove("Banner", true);
			objBannerDA.Update(obj_banner);
		}

		/// <summary>
		/// Delete the specified Banner
		/// </summary>
		/// <param name="bannerid">BannerID</param>
		/// <returns></returns>
		public void Delete(int bannerid)
		{
			ServerCache.Remove("Banner", true);
			objBannerDA.Delete(bannerid);
		}
		#endregion
	}
}
