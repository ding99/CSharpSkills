using System;
using System.Collections.Generic;

namespace Starter
{
	public class Menu
	{
		public IList<Page> Pages;
		public string DataPath;

		public Menu(string path)
		{
			Pages = new List<Page>();
			DataPath = path;
		}

		public Menu() {
			Pages = new List<Page>();
		}
	}

	public class Page {
		public string Title;
		public IList<Problem> Problems;

		public Page()
		{
			Problems = new List<Problem>();
		}
	}

	public class Problem
	{
		public Type Type { set; get; }
		public string Method { set; get; }
		public string Description { set; get; }
		public string Comment { set; get; }
	}
}
