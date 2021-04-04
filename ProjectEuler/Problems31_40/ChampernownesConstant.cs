using System;
using System.Collections.Generic;

namespace ProjectEuler.Problems31_40
{
	public class Term
	{
		public int Width { get; set; }
		public int Steps { get; set; }
		public int Digit { get; set; }
	}

	public class ChampernownesConstant
	{
		private IList<Term> terms;

		public ChampernownesConstant()
		{
			terms = new List<Term>();
			int total = 0, count = 9;
			for (int width = 1; width < 10; width++)
			{
				terms.Add(new Term
				{
					Width = width,
					Steps = (count *= width == 1 ? 1 : 10),
					Digit = count * width
				});
				if ((total += count * width) > 1000000)
					break;
			}
		}

		public void Start()
		{
			int bas = 1, product = Digit(bas), mid;
			for (int i = 1; i < 7; i++)
			{
				mid = Digit(bas *= 10);
				product *= mid;
			}
			Console.WriteLine(product); //210

		}

		private int Digit(int n)
		{
			Term t;
			for (int i = 0; i < terms.Count; i++)
			{
				if (n <= (t = terms[i]).Digit)
					return Int32.Parse((t.Steps / 9 + (n - 1) / t.Width).ToString().Substring((n - 1) % t.Width, 1));
				else n -= t.Digit;
			}
			return -1;
		}
	}
}
