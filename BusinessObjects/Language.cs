using System;

namespace RealEstate.BusinessObjects
{
	public class Language
	{
		#region ***** Fields & Properties ***** 
		private int _LanguageId;
		public int LanguageId
		{ 
			get 
			{ 
				return _LanguageId;
			}
			set 
			{ 
				_LanguageId = value;
			}
		}
		private string _Name;
		public string Name
		{ 
			get 
			{ 
				return _Name;
			}
			set 
			{ 
				_Name = value;
			}
		}
		private string _ResourceFile;
		public string ResourceFile
		{ 
			get 
			{ 
				return _ResourceFile;
			}
			set 
			{ 
				_ResourceFile = value;
			}
		}
		private string _LanguageText;
		public string LanguageText
		{ 
			get 
			{ 
				return _LanguageText;
			}
			set 
			{ 
				_LanguageText = value;
			}
		}
		#endregion

		#region ***** Init Methods ***** 
		public Language()
		{
		}
		public Language(int languageid)
		{
			this.LanguageId = languageid;
		}
		public Language(int languageid, string name, string resourcefile, string languagetext)
		{
			this.LanguageId = languageid;
			this.Name = name;
			this.ResourceFile = resourcefile;
			this.LanguageText = languagetext;
		}
		#endregion
	}
}
