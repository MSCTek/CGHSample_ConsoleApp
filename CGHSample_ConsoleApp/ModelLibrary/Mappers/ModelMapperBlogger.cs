// <auto-generated> - Template:MapperSqliteModelDataToMvvmLightModelObject, Version:2.0, Id:77d31b89-1034-451e-af7c-9ed1fa3613ef
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using objBlogger = ModelLibrary.ModelObj.Blogger;
using dataBlogger = ModelLibrary.ModelData.Blogger;

namespace ModelLibrary
{
	public static partial class ModelMapper
	{

		#region ModelObj to ModelData

		public static dataBlogger.Blog ToModelData(this objBlogger.Blog source)
		{
			return new dataBlogger.Blog()
			{
				BlogId = source.BlogId,
				Url = source.Url,
			};
		}

		public static dataBlogger.Post ToModelData(this objBlogger.Post source)
		{
			return new dataBlogger.Post()
			{
				BlogId = source.BlogId,
				Content = source.Content,
				PostId = source.PostId,
				Title = source.Title,
			};
		}


		#endregion ModelObj to ModelData

		#region ModelData to ModelObj

		public static objBlogger.Blog ToModelObj(this dataBlogger.Blog source)
		{
			return new objBlogger.Blog()
			{
				BlogId = source.BlogId,
				Url = source.Url,
			};
		}

		public static objBlogger.Post ToModelObj(this dataBlogger.Post source)
		{
			return new objBlogger.Post()
			{
				BlogId = source.BlogId,
				Content = source.Content,
				PostId = source.PostId,
				Title = source.Title,
			};
		}


		#endregion ModelData to ModelObj

	}
}
