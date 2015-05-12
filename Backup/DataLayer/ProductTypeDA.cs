using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using RealEstate.BusinessObjects;

namespace RealEstate.DataAccess
{
	public class ProductTypeDA
	{

		#region ***** Init Methods ***** 
		public ProductTypeDA()
		{
		}
		#endregion

		#region ***** Get Methods ***** 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public ProductType Populate(IDataReader myReader)
		{
			ProductType obj = new ProductType();
			obj.ProductTypeId = (int) myReader["ProductTypeId"];
			obj.ProductTypeName = (string) myReader["ProductTypeName"];
			obj.ProductTypeDescription = (string) myReader["ProductTypeDescription"];
			obj.ProductTypeNameTranslationId = (int) myReader["ProductTypeNameTranslationId"];
			obj.ProductTypeDescriptionNameTranslationId = (int) myReader["ProductTypeDescriptionNameTranslationId"];
			return obj;
		}

		/// <summary>
		/// Get ProductType by producttypeid
		/// </summary>
		/// <param name="producttypeid">ProductTypeId</param>
		/// <returns>ProductType</returns>
		public ProductType GetByProductTypeId(int producttypeid)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_ProductType_GetByProductTypeId", Data.CreateParameter("ProductTypeId", producttypeid)))
			{
				if (reader.Read())
				{
					return Populate(reader);
				}
				return null;
			}
		}

		/// <summary>
		/// Get all of ProductType
		/// </summary>
		/// <returns>List<<ProductType>></returns>
		public List<ProductType> GetList()
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_ProductType_Get"))
			{
				List<ProductType> list = new List<ProductType>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of ProductType
		/// </summary>
		/// <returns>DataSet</returns>
		public DataSet GetDataSet()
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_ProductType_Get");
		}


		/// <summary>
		/// Get all of ProductType paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>List<<ProductType>></returns>
		public List<ProductType> GetListPaged(int recperpage, int pageindex)
		{
			using (IDataReader reader = SqlHelper.ExecuteReader(Data.ConnectionString, CommandType.StoredProcedure, "sproc_ProductType_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex)))
			{
				List<ProductType> list = new List<ProductType>();
				while (reader.Read())
				{
				list.Add(Populate(reader));
				}
				return list;
			}
		}

		/// <summary>
		/// Get DataSet of ProductType paged
		/// </summary>
		/// <param name="recperpage">record per page</param>
		/// <param name="pageindex">page index</param>
		/// <returns>DataSet</returns>
		public DataSet GetDataSetPaged(int recperpage, int pageindex)
		{
			return SqlHelper.ExecuteDataSet(Data.ConnectionString, CommandType.StoredProcedure,"sproc_ProductType_GetPaged"
							,Data.CreateParameter("recperpage", recperpage)
							,Data.CreateParameter("pageindex", pageindex));
		}





		#endregion

		#region ***** Add Update Delete Methods ***** 
		/// <summary>
		/// Add a new ProductType within ProductType database table
		/// </summary>
		/// <param name="obj">ProductType</param>
		/// <returns>key of table</returns>
		public int Add(ProductType obj)
		{
			DbParameter parameterItemID = Data.CreateParameter("ProductTypeId", obj.ProductTypeId);
			parameterItemID.Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_ProductType_Add"
							,parameterItemID
							,Data.CreateParameter("ProductTypeName", obj.ProductTypeName)
							,Data.CreateParameter("ProductTypeDescription", obj.ProductTypeDescription)
							,Data.CreateParameter("ProductTypeNameTranslationId", obj.ProductTypeNameTranslationId)
							,Data.CreateParameter("ProductTypeDescriptionNameTranslationId", obj.ProductTypeDescriptionNameTranslationId)
			);
			return 0;
		}

		/// <summary>
		/// updates the specified ProductType
		/// </summary>
		/// <param name="obj">ProductType</param>
		/// <returns></returns>
		public void Update(ProductType obj)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_ProductType_Update"
							,Data.CreateParameter("ProductTypeId", obj.ProductTypeId)
							,Data.CreateParameter("ProductTypeName", obj.ProductTypeName)
							,Data.CreateParameter("ProductTypeDescription", obj.ProductTypeDescription)
							,Data.CreateParameter("ProductTypeNameTranslationId", obj.ProductTypeNameTranslationId)
							,Data.CreateParameter("ProductTypeDescriptionNameTranslationId", obj.ProductTypeDescriptionNameTranslationId)
			);
		}

		/// <summary>
		/// Delete the specified ProductType
		/// </summary>
		/// <param name="producttypeid">ProductTypeId</param>
		/// <returns></returns>
		public void Delete(int producttypeid)
		{
			SqlHelper.ExecuteNonQuery(Data.ConnectionString, CommandType.StoredProcedure,"sproc_ProductType_Delete", Data.CreateParameter("ProductTypeId", producttypeid));
		}
		#endregion
	}
}
