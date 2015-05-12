using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class AdvertiseDA
	{

		#region ***** Init Methods ***** 
		public AdvertiseDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public Advertise Populate(IDataReader myReader)
		{
			Advertise obj = new Advertise();
			obj.AdvID = (int) myReader["AdvID"];
			obj.AdvName = (string) myReader["AdvName"];
			obj.Image = (string) myReader["Image"];
			obj.Width = (int) myReader["Width"];
			obj.Height = (int) myReader["Height"];
			obj.Link = (string) myReader["Link"];
			obj.Target = (string) myReader["Target"];
			obj.Content = (string) myReader["Content"];
			obj.Position = (int) myReader["Position"];
			obj.PageID = (int) myReader["PageID"];
			obj.Click = (int) myReader["Click"];
			obj.Ord = (int) myReader["Ord"];
			obj.Active = (bool) myReader["Active"];
			obj.Lang = (string) myReader["Lang"];
			return obj;
		}

		/// <summary>
		/// Get Advertise by advid
		/// </summary>
		/// <param name="advid">AdvID</param>
		/// <returns>Advertise</returns>
		public Advertise GetByAdvID(int advid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Advertise_GetByAdvID", Data.CreateParameter("AdvID", advid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of Advertise
		/// </summary>
		/// <returns>List<<Advertise>></returns>
		public List<Advertise> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Advertise_Get"))
			{
				List<Advertise> list = new List<Advertise>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Advertise
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Advertise_Get");
		}


		/// <summary>
		/// Get all of Advertise paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<Advertise>></returns>
		public List<Advertise> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_Advertise_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<Advertise> list = new List<Advertise>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of Advertise paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Advertise_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new Advertise within Advertise database table
		/// </summary>
		/// <param name="obj">Advertise</param>
		/// <returns>key of table</returns>
		public int Add(Advertise obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("AdvID", obj.AdvID);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Advertise_Add"
							,parameterItemID
							,Data.CreateParameter("AdvName", obj.AdvName)
							,Data.CreateParameter("Image", obj.Image)
							,Data.CreateParameter("Width", obj.Width)
							,Data.CreateParameter("Height", obj.Height)
							,Data.CreateParameter("Link", obj.Link)
							,Data.CreateParameter("Target", obj.Target)
							,Data.CreateParameter("Content", obj.Content)
							,Data.CreateParameter("Position", obj.Position)
							,Data.CreateParameter("PageID", obj.PageID)
							,Data.CreateParameter("Click", obj.Click)
							,Data.CreateParameter("Ord", obj.Ord)
							,Data.CreateParameter("Active", obj.Active)
							,Data.CreateParameter("Lang", obj.Lang)
			);
			return 0;
		}

		/// <summary>
		/// updates the specified Advertise
		/// </summary>
		/// <param name="obj">Advertise</param>
		/// <returns></returns>
		public void Update(Advertise obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Advertise_Update"
							,Data.CreateParameter("AdvID", obj.AdvID)
							,Data.CreateParameter("AdvName", obj.AdvName)
							,Data.CreateParameter("Image", obj.Image)
							,Data.CreateParameter("Width", obj.Width)
							,Data.CreateParameter("Height", obj.Height)
							,Data.CreateParameter("Link", obj.Link)
							,Data.CreateParameter("Target", obj.Target)
							,Data.CreateParameter("Content", obj.Content)
							,Data.CreateParameter("Position", obj.Position)
							,Data.CreateParameter("PageID", obj.PageID)
							,Data.CreateParameter("Click", obj.Click)
							,Data.CreateParameter("Ord", obj.Ord)
							,Data.CreateParameter("Active", obj.Active)
							,Data.CreateParameter("Lang", obj.Lang)
			);
		}

		/// <summary>
		/// Delete the specified Advertise
		/// </summary>
		/// <param name="advid">AdvID</param>
		/// <returns></returns>
		public void Delete(int advid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_Advertise_Delete", Data.CreateParameter("AdvID", advid));
		}
		#endregion
	}
}
