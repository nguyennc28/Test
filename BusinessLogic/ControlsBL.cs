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
	public class ControlsBL
	{

		#region ***** Init Methods ***** 
		ControlsDA objControlsDA;
		public ControlsBL()
		{
			objControlsDA = new ControlsDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get Controls by controlid
		/// </summary>
		/// <param name="controlid">ControlID</param>
		/// <returns>Controls</returns>
		public Controls GetByControlID(int controlid)
		{
			return objControlsDA.GetByControlID(controlid);
		}

		/// <summary>
		/// Get all of Controls
		/// </summary>
		/// <returns>List<<Controls>></returns>
		public List<Controls> GetList()
		{
			string cacheName = "lstControls";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objControlsDA.GetList(), "Controls");
			}
			return (List<Controls>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of Controls
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsControls";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objControlsDA.GetDataSet(), "Controls");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of Controls paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<Controls>></returns>
		public List<Controls> GetListPaged(int recperpage, int pageindex)
		{
			return objControlsDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of Controls paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objControlsDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Controls within Controls database table
		/// </summary>
		/// <param name="obj_controls">Controls</param>
		/// <returns>key of table</returns>
		public int Add(Controls obj_controls)
		{
			ServerCache.Remove("Controls", true);
			return objControlsDA.Add(obj_controls);
		}

		/// <summary>
		/// updates the specified Controls
		/// </summary>
		/// <param name="obj_controls">Controls</param>
		/// <returns></returns>
		public void Update(Controls obj_controls)
		{
			ServerCache.Remove("Controls", true);
			objControlsDA.Update(obj_controls);
		}

		/// <summary>
		/// Delete the specified Controls
		/// </summary>
		/// <param name="controlid">ControlID</param>
		/// <returns></returns>
		public void Delete(int controlid)
		{
			ServerCache.Remove("Controls", true);
			objControlsDA.Delete(controlid);
		}
		#endregion
	}
}
