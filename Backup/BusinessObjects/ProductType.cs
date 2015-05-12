using System;

namespace RealEstate.BusinessObjects
{
	public class ProductType
	{
		#region ***** Fields & Properties ***** 
		private int _ProductTypeId;
		public int ProductTypeId
		{ 
			get 
			{ 
				return _ProductTypeId;
			}
			set 
			{ 
				_ProductTypeId = value;
			}
		}
		private string _ProductTypeName;
		public string ProductTypeName
		{ 
			get 
			{ 
				return _ProductTypeName;
			}
			set 
			{ 
				_ProductTypeName = value;
			}
		}
		private string _ProductTypeDescription;
		public string ProductTypeDescription
		{ 
			get 
			{ 
				return _ProductTypeDescription;
			}
			set 
			{ 
				_ProductTypeDescription = value;
			}
		}
		private int _ProductTypeNameTranslationId;
		public int ProductTypeNameTranslationId
		{ 
			get 
			{ 
				return _ProductTypeNameTranslationId;
			}
			set 
			{ 
				_ProductTypeNameTranslationId = value;
			}
		}
		private int _ProductTypeDescriptionNameTranslationId;
		public int ProductTypeDescriptionNameTranslationId
		{ 
			get 
			{ 
				return _ProductTypeDescriptionNameTranslationId;
			}
			set 
			{ 
				_ProductTypeDescriptionNameTranslationId = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public ProductType()
		{
		}
		public ProductType(int producttypeid)
		{
			this.ProductTypeId = producttypeid;
		}
		public ProductType(int producttypeid, string producttypename, string producttypedescription, int producttypenametranslationid, int producttypedescriptionnametranslationid)
		{
			this.ProductTypeId = producttypeid;
			this.ProductTypeName = producttypename;
			this.ProductTypeDescription = producttypedescription;
			this.ProductTypeNameTranslationId = producttypenametranslationid;
			this.ProductTypeDescriptionNameTranslationId = producttypedescriptionnametranslationid;
		}
		#endregion
	}
}
