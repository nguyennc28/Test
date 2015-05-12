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
	public class DistrictBL
	{

		#region ***** Init Methods ***** 
		DistrictDA objDistrictDA;
		public DistrictBL()
		{
			objDistrictDA = new DistrictDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get District by districtid
		/// </summary>
		/// <param name="districtid">DistrictID</param>
		/// <returns>District</returns>
		public District GetByDistrictID(int districtid)
		{
			return objDistrictDA.GetByDistrictID(districtid);
		}

		/// <summary>
		/// Get all of District
		/// </summary>
		/// <returns>List<<District>></returns>
		public List<District> GetList()
		{
			string cacheName = "lstDistrict";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objDistrictDA.GetList(), "District");
			}
			return (List<District>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of District
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsDistrict";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objDistrictDA.GetDataSet(), "District");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of District paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<District>></returns>
		public List<District> GetListPaged(int recperpage, int pageindex)
		{
			return objDistrictDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of District paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objDistrictDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new District within District database table
		/// </summary>
		/// <param name="obj_district">District</param>
		/// <returns>key of table</returns>
		public int Add(District obj_district)
		{
			ServerCache.Remove("District", true);
			return objDistrictDA.Add(obj_district);
		}

		/// <summary>
		/// updates the specified District
		/// </summary>
		/// <param name="obj_district">District</param>
		/// <returns></returns>
		public void Update(District obj_district)
		{
			ServerCache.Remove("District", true);
			objDistrictDA.Update(obj_district);
		}

		/// <summary>
		/// Delete the specified District
		/// </summary>
		/// <param name="districtid">DistrictID</param>
		/// <returns></returns>
		public void Delete(int districtid)
		{
			ServerCache.Remove("District", true);
			objDistrictDA.Delete(districtid);
		}
		#endregion
	}
}
