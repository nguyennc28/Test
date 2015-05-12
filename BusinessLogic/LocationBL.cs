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
	public class LocationBL
	{

		#region ***** Init Methods ***** 
		LocationDA objLocationDA;
		public LocationBL()
		{
			objLocationDA = new LocationDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get Location by locationid
		/// </summary>
		/// <param name="locationid">LocationID</param>
		/// <returns>Location</returns>
		public Location GetByLocationID(int locationid)
		{
			return objLocationDA.GetByLocationID(locationid);
		}

		/// <summary>
		/// Get all of Location
		/// </summary>
		/// <returns>List<<Location>></returns>
		public List<Location> GetList()
		{
			string cacheName = "lstLocation";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objLocationDA.GetList(), "Location");
			}
			return (List<Location>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of Location
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsLocation";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objLocationDA.GetDataSet(), "Location");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of Location paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<Location>></returns>
		public List<Location> GetListPaged(int recperpage, int pageindex)
		{
			return objLocationDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of Location paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objLocationDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Location within Location database table
		/// </summary>
		/// <param name="obj_location">Location</param>
		/// <returns>key of table</returns>
		public int Add(Location obj_location)
		{
			ServerCache.Remove("Location", true);
			return objLocationDA.Add(obj_location);
		}

		/// <summary>
		/// updates the specified Location
		/// </summary>
		/// <param name="obj_location">Location</param>
		/// <returns></returns>
		public void Update(Location obj_location)
		{
			ServerCache.Remove("Location", true);
			objLocationDA.Update(obj_location);
		}

		/// <summary>
		/// Delete the specified Location
		/// </summary>
		/// <param name="locationid">LocationID</param>
		/// <returns></returns>
		public void Delete(int locationid)
		{
			ServerCache.Remove("Location", true);
			objLocationDA.Delete(locationid);
		}
		#endregion
	}
}
