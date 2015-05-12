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
	public class RealEstatesBL
	{

		#region ***** Init Methods ***** 
		RealEstatesDA objRealEstatesDA;
		public RealEstatesBL()
		{
			objRealEstatesDA = new RealEstatesDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get RealEstates by realestateid
		/// </summary>
		/// <param name="realestateid">RealEstateID</param>
		/// <returns>RealEstates</returns>
		public RealEstates GetByRealEstateID(int realestateid)
		{
			return objRealEstatesDA.GetByRealEstateID(realestateid);
		}

		/// <summary>
		/// Get all of RealEstates
		/// </summary>
		/// <returns>List<<RealEstates>></returns>
		public List<RealEstates> GetList()
		{
			string cacheName = "lstRealEstates";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objRealEstatesDA.GetList(), "RealEstates");
			}
			return (List<RealEstates>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of RealEstates
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsRealEstates";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objRealEstatesDA.GetDataSet(), "RealEstates");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of RealEstates paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<RealEstates>></returns>
		public List<RealEstates> GetListPaged(int recperpage, int pageindex)
		{
			return objRealEstatesDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of RealEstates paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objRealEstatesDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new RealEstates within RealEstates database table
		/// </summary>
		/// <param name="obj_realestates">RealEstates</param>
		/// <returns>key of table</returns>
		public int Add(RealEstates obj_realestates)
		{
			ServerCache.Remove("RealEstates", true);
			return objRealEstatesDA.Add(obj_realestates);
		}

		/// <summary>
		/// updates the specified RealEstates
		/// </summary>
		/// <param name="obj_realestates">RealEstates</param>
		/// <returns></returns>
		public void Update(RealEstates obj_realestates)
		{
			ServerCache.Remove("RealEstates", true);
			objRealEstatesDA.Update(obj_realestates);
		}

		/// <summary>
		/// Delete the specified RealEstates
		/// </summary>
		/// <param name="realestateid">RealEstateID</param>
		/// <returns></returns>
		public void Delete(int realestateid)
		{
			ServerCache.Remove("RealEstates", true);
			objRealEstatesDA.Delete(realestateid);
		}
		#endregion
	}
}
