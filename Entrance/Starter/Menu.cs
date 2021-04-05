using System;
using System.Collections.Generic;

namespace Starter
{
	public class Menu
	{
		public IList<Web> Webs;

		public Menu() {
			Webs = new List<Web>();
		}
	}

	public class Web {
		public string Title;
		public IList<Page> Pages;

		public Web() {
			Pages = new List<Page>();
		}
	}

	public class Page {
		public string Title;
		public IList<Problem> Problems;

		public Page() {
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
