using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Problems31_40
{
	public class DoubleBasePalindromes
	{
		public void Start()
		{
			List<int> palindromics = new List<int>();

			for (int i = 1; i < 1000000; i++)
				if (Palindromics(i))
					palindromics.Add(i);

			Console.WriteLine(palindromics.Sum()); //872187
		}

		private bool Palindromics(int n)
		{
			string s;
			return !(s = n.ToString()).EndsWith("0") && s.Equals(invert(s))
				&& !(s = Convert.ToString(n, 2)).EndsWith("0") && s.Equals(invert(s));
		}

		private string invert(string s)
		{
			StringBuilder b = new StringBuilder();
			for (int i = s.Length - 1; i >= 0; i--)
				b.Append(s.Substring(i, 1));
			return b.ToString();
		}
	}
}
