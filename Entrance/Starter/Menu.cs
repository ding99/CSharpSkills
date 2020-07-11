using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starter
{
	public class Menu
	{
		public IList<Page> Pages;

		public Menu()
		{
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
	}
}
