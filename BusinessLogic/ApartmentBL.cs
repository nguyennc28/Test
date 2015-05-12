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
	public class ApartmentBL
	{

		#region ***** Init Methods ***** 
		ApartmentDA objApartmentDA;
		public ApartmentBL()
		{
			objApartmentDA = new ApartmentDA();
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// Get Apartment by apartmentid
		/// </summary>
		/// <param name="apartmentid">ApartmentID</param>
		/// <returns>Apartment</returns>
		public Apartment GetByApartmentID(int apartmentid)
		{
			return objApartmentDA.GetByApartmentID(apartmentid);
		}

		/// <summary>
		/// Get all of Apartment
		/// </summary>
		/// <returns>List<<Apartment>></returns>
		public List<Apartment> GetList()
		{
			string cacheName = "lstApartment";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objApartmentDA.GetList(), "Apartment");
			}
			return (List<Apartment>) ServerCache.Get(cacheName);
		}

		/// <summary>
		/// Get DataSet of Apartment
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			string cacheName = "dsApartment";
			if( ServerCache.Get(cacheName) == null )
			{
				ServerCache.Insert(cacheName, objApartmentDA.GetDataSet(), "Apartment");
			}
			return (DataSet) ServerCache.Get(cacheName);
		}


		/// <summary>
		/// Get all of Apartment paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>List<<Apartment>></returns>
		public List<Apartment> GetListPaged(int recperpage, int pageindex)
		{
			return objApartmentDA.GetListPaged(recperpage, pageindex);
		}

		/// <summary>
		/// Get DataSet of Apartment paged
		/// </summary>
		/// <param name="recperpage">recperpage</param>
		/// <param name="pageindex">pageindex</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return objApartmentDA.GetDataSetPaged(recperpage, pageindex);
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Apartment within Apartment database table
		/// </summary>
		/// <param name="obj_apartment">Apartment</param>
		/// <returns>key of table</returns>
		public int Add(Apartment obj_apartment)
		{
			ServerCache.Remove("Apartment", true);
			return objApartmentDA.Add(obj_apartment);
		}

		/// <summary>
		/// updates the specified Apartment
		/// </summary>
		/// <param name="obj_apartment">Apartment</param>
		/// <returns></returns>
		public void Update(Apartment obj_apartment)
		{
			ServerCache.Remove("Apartment", true);
			objApartmentDA.Update(obj_apartment);
		}

		/// <summary>
		/// Delete the specified Apartment
		/// </summary>
		/// <param name="apartmentid">ApartmentID</param>
		/// <returns></returns>
		public void Delete(int apartmentid)
		{
			ServerCache.Remove("Apartment", true);
			objApartmentDA.Delete(apartmentid);
		}
		#endregion
	}
}
