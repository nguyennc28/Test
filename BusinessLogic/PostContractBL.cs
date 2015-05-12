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
	public class PostContractBL
	{

		#region ***** Init Methods ***** 
		PostContractDA objPostContractDA;
		public PostContractBL()
		{
			objPostContractDA = new PostContractDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get PostContract by postcontractid
		/// </summary>
		/// <param name="postcontractid">PostContractID</param>
		/// <returns>PostContract</returns>
		public PostContract GetByPostContractID(int postcontractid)
		{
			return objPostContractDA.GetByPostContractID(postcontractid);
		}

		/// <summary>
		/// Get all of PostContract
		/// </summary>
		/// <returns>List<<PostContract>></returns>
		public List<PostContract> GetList()
		{
			string cacheName = "lstPostContract";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objPostContractDA.GetList(), "PostContract");
			}
			return (List<PostContract>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of PostContract
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsPostContract";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objPostContractDA.GetDataSet(), "PostContract");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of PostContract paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<PostContract>></returns>
		public List<PostContract> GetListPaged(int recperpage, int pageindex)
		{
			return objPostContractDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of PostContract paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objPostContractDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new PostContract within PostContract database table
		/// </summary>
		/// <param name="obj_postcontract">PostContract</param>
		/// <returns>key of table</returns>
		public int Add(PostContract obj_postcontract)
		{
			ServerCache.Remove("PostContract", true);
			return objPostContractDA.Add(obj_postcontract);
		}

		/// <summary>
		/// updates the specified PostContract
		/// </summary>
		/// <param name="obj_postcontract">PostContract</param>
		/// <returns></returns>
		public void Update(PostContract obj_postcontract)
		{
			ServerCache.Remove("PostContract", true);
			objPostContractDA.Update(obj_postcontract);
		}

		/// <summary>
		/// Delete the specified PostContract
		/// </summary>
		/// <param name="postcontractid">PostContractID</param>
		/// <returns></returns>
		public void Delete(int postcontractid)
		{
			ServerCache.Remove("PostContract", true);
			objPostContractDA.Delete(postcontractid);
		}
		#endregion
	}
}
