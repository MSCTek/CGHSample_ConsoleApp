// <auto-generated> - Template:MvvmLightModelObject, Version:2.0, Id:13213ee9-7e50-4dbd-82eb-9030fad28b26
using GalaSoft.MvvmLight;
using System;

namespace ModelLibrary.ModelObj.Blogger
{
	public partial class Blog : ObservableObject
	{
		public Blog()
		{
			Posts = new System.Collections.Generic.List<ConsoleApp2.Post>(); // Reverse Navigation

			InitializePartial();
		}

		private int _blogId;
		private string _url;


		public int BlogId
		{
			get { return _blogId; }
			set
			{
				Set<int>(() => BlogId, ref _blogId, value);
				RunCustomLogicSetBlogId(value);
			}
		}

		public string Url
		{
			get { return _url; }
			set
			{
				Set<string>(() => Url, ref _url, value);
				RunCustomLogicSetUrl(value);
			}
		}

		public virtual System.Collections.Generic.IList<ConsoleApp2.Post> Posts { get; set; } 


		partial void InitializePartial();

		#region RunCustomLogicSet

		partial void RunCustomLogicSetBlogId(int value);
		partial void RunCustomLogicSetUrl(string value);

		#endregion RunCustomLogicSet

	}
}