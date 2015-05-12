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
	public class CityBL
	{

		#region ***** Init Methods ***** 
		CityDA objCityDA;
		public CityBL()
		{
			objCityDA = new CityDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get City by cityid
		/// </summary>
		/// <param name="cityid">CityID</param>
		/// <returns>City</returns>
		public City GetByCityID(string cityid)
		{
			return objCityDA.GetByCityID(cityid);
		}

		/// <summary>
		/// Get all of City
		/// </summary>
		/// <returns>List<<City>></returns>
		public List<City> GetList()
		{
			string cacheName = "lstCity";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objCityDA.GetList(), "City");
			}
			return (List<City>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of City
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsCity";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objCityDA.GetDataSet(), "City");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of City paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<City>></returns>
		public List<City> GetListPaged(string recperpage, string pageindex)
		{
			return objCityDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of City paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(string recperpage, string pageindex)
		{
			return objCityDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new City within City database table
		/// </summary>
		/// <param name="obj_city">City</param>
		/// <returns>key of table</returns>
		public int Add(City obj_city)
		{
			ServerCache.Remove("City", true);
			return objCityDA.Add(obj_city);
		}

		/// <summary>
		/// updates the specified City
		/// </summary>
		/// <param name="obj_city">City</param>
		/// <returns></returns>
		public void Update(City obj_city)
		{
			ServerCache.Remove("City", true);
			objCityDA.Update(obj_city);
		}

		/// <summary>
		/// Delete the specified City
		/// </summary>
		/// <param name="cityid">CityID</param>
		/// <returns></returns>
		public void Delete(string cityid)
		{
			ServerCache.Remove("City", true);
			objCityDA.Delete(cityid);
		}
		#endregion
	}
}
