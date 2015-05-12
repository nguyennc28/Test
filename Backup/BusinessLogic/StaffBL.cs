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
	public class StaffBL
	{

		#region ***** Init Methods ***** 
		StaffDA objStaffDA;
		public StaffBL()
		{
			objStaffDA = new StaffDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get Staff by staffid
		/// </summary>
		/// <param name="staffid">StaffID</param>
		/// <returns>Staff</returns>
		public Staff GetByStaffID(int staffid)
		{
			return objStaffDA.GetByStaffID(staffid);
		}

		/// <summary>
		/// Get all of Staff
		/// </summary>
		/// <returns>List<<Staff>></returns>
		public List<Staff> GetList()
		{
			string cacheName = "lstStaff";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objStaffDA.GetList(), "Staff");
			}
			return (List<Staff>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of Staff
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsStaff";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objStaffDA.GetDataSet(), "Staff");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of Staff paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<Staff>></returns>
		public List<Staff> GetListPaged(int recperpage, int pageindex)
		{
			return objStaffDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of Staff paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objStaffDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Staff within Staff database table
		/// </summary>
		/// <param name="obj_staff">Staff</param>
		/// <returns>key of table</returns>
		public int Add(Staff obj_staff)
		{
			ServerCache.Remove("Staff", true);
			return objStaffDA.Add(obj_staff);
		}

		/// <summary>
		/// updates the specified Staff
		/// </summary>
		/// <param name="obj_staff">Staff</param>
		/// <returns></returns>
		public void Update(Staff obj_staff)
		{
			ServerCache.Remove("Staff", true);
			objStaffDA.Update(obj_staff);
		}

		/// <summary>
		/// Delete the specified Staff
		/// </summary>
		/// <param name="staffid">StaffID</param>
		/// <returns></returns>
		public void Delete(int staffid)
		{
			ServerCache.Remove("Staff", true);
			objStaffDA.Delete(staffid);
		}
		#endregion
	}
}
