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
	public class AdvertiseBL
	{

		#region ***** Init Methods ***** 
		AdvertiseDA objAdvertiseDA;
		public AdvertiseBL()
		{
			objAdvertiseDA = new AdvertiseDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get Advertise by advid
		/// </summary>
		/// <param name="advid">AdvID</param>
		/// <returns>Advertise</returns>
		public Advertise GetByAdvID(int advid)
		{
			return objAdvertiseDA.GetByAdvID(advid);
		}

		/// <summary>
		/// Get all of Advertise
		/// </summary>
		/// <returns>List<<Advertise>></returns>
		public List<Advertise> GetList()
		{
			string cacheName = "lstAdvertise";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objAdvertiseDA.GetList(), "Advertise");
			}
			return (List<Advertise>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of Advertise
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsAdvertise";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objAdvertiseDA.GetDataSet(), "Advertise");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of Advertise paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<Advertise>></returns>
		public List<Advertise> GetListPaged(int recperpage, int pageindex)
		{
			return objAdvertiseDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of Advertise paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objAdvertiseDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Advertise within Advertise database table
		/// </summary>
		/// <param name="obj_advertise">Advertise</param>
		/// <returns>key of table</returns>
		public int Add(Advertise obj_advertise)
		{
			ServerCache.Remove("Advertise", true);
			return objAdvertiseDA.Add(obj_advertise);
		}

		/// <summary>
		/// updates the specified Advertise
		/// </summary>
		/// <param name="obj_advertise">Advertise</param>
		/// <returns></returns>
		public void Update(Advertise obj_advertise)
		{
			ServerCache.Remove("Advertise", true);
			objAdvertiseDA.Update(obj_advertise);
		}

		/// <summary>
		/// Delete the specified Advertise
		/// </summary>
		/// <param name="advid">AdvID</param>
		/// <returns></returns>
		public void Delete(int advid)
		{
			ServerCache.Remove("Advertise", true);
			objAdvertiseDA.Delete(advid);
		}
		#endregion
	}
}
