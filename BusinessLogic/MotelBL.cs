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
	public class MotelBL
	{

		#region ***** Init Methods ***** 
		MotelDA objMotelDA;
		public MotelBL()
		{
			objMotelDA = new MotelDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get Motel by motelid
		/// </summary>
		/// <param name="motelid">MotelID</param>
		/// <returns>Motel</returns>
		public Motel GetByMotelID(int motelid)
		{
			return objMotelDA.GetByMotelID(motelid);
		}

		/// <summary>
		/// Get all of Motel
		/// </summary>
		/// <returns>List<<Motel>></returns>
		public List<Motel> GetList()
		{
			string cacheName = "lstMotel";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objMotelDA.GetList(), "Motel");
			}
			return (List<Motel>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of Motel
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsMotel";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objMotelDA.GetDataSet(), "Motel");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of Motel paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<Motel>></returns>
		public List<Motel> GetListPaged(int recperpage, int pageindex)
		{
			return objMotelDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of Motel paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objMotelDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Motel within Motel database table
		/// </summary>
		/// <param name="obj_motel">Motel</param>
		/// <returns>key of table</returns>
		public int Add(Motel obj_motel)
		{
			ServerCache.Remove("Motel", true);
			return objMotelDA.Add(obj_motel);
		}

		/// <summary>
		/// updates the specified Motel
		/// </summary>
		/// <param name="obj_motel">Motel</param>
		/// <returns></returns>
		public void Update(Motel obj_motel)
		{
			ServerCache.Remove("Motel", true);
			objMotelDA.Update(obj_motel);
		}

		/// <summary>
		/// Delete the specified Motel
		/// </summary>
		/// <param name="motelid">MotelID</param>
		/// <returns></returns>
		public void Delete(int motelid)
		{
			ServerCache.Remove("Motel", true);
			objMotelDA.Delete(motelid);
		}
		#endregion
	}
}
