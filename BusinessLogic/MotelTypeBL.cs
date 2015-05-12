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
	public class MotelTypeBL
	{

		#region ***** Init Methods ***** 
		MotelTypeDA objMotelTypeDA;
		public MotelTypeBL()
		{
			objMotelTypeDA = new MotelTypeDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get MotelType by moteltypeid
		/// </summary>
		/// <param name="moteltypeid">MotelTypeID</param>
		/// <returns>MotelType</returns>
		public MotelType GetByMotelTypeID(int moteltypeid)
		{
			return objMotelTypeDA.GetByMotelTypeID(moteltypeid);
		}

		/// <summary>
		/// Get all of MotelType
		/// </summary>
		/// <returns>List<<MotelType>></returns>
		public List<MotelType> GetList()
		{
			string cacheName = "lstMotelType";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objMotelTypeDA.GetList(), "MotelType");
			}
			return (List<MotelType>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of MotelType
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsMotelType";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objMotelTypeDA.GetDataSet(), "MotelType");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of MotelType paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<MotelType>></returns>
		public List<MotelType> GetListPaged(int recperpage, int pageindex)
		{
			return objMotelTypeDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of MotelType paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objMotelTypeDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new MotelType within MotelType database table
		/// </summary>
		/// <param name="obj_moteltype">MotelType</param>
		/// <returns>key of table</returns>
		public int Add(MotelType obj_moteltype)
		{
			ServerCache.Remove("MotelType", true);
			return objMotelTypeDA.Add(obj_moteltype);
		}

		/// <summary>
		/// updates the specified MotelType
		/// </summary>
		/// <param name="obj_moteltype">MotelType</param>
		/// <returns></returns>
		public void Update(MotelType obj_moteltype)
		{
			ServerCache.Remove("MotelType", true);
			objMotelTypeDA.Update(obj_moteltype);
		}

		/// <summary>
		/// Delete the specified MotelType
		/// </summary>
		/// <param name="moteltypeid">MotelTypeID</param>
		/// <returns></returns>
		public void Delete(int moteltypeid)
		{
			ServerCache.Remove("MotelType", true);
			objMotelTypeDA.Delete(moteltypeid);
		}
		#endregion
	}
}
