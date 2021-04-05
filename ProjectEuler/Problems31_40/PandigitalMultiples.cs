using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Euler31_40
{
	public class PandigitalMultiples
	{
		public void Start()
		{
			int max = 0, current = 0;

			for (int i = 1; i < 100000; i++)
				for (int n = 2; n < 10; n++)
					if ((current = multiple(i, n)) > max)
						max = current;

			Console.WriteLine(max); //932718654
		}

		private bool validChars(char[] a)
		{
			List<char> digits = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
			foreach (char c in a)
				if (!digits.Contains(c))
					return false;
				else digits.Remove(c);

			return true;
		}

		private bool validProduct(string s)
		{
			return s.Length == 9 && validChars(s.ToCharArray());
		}

		private int multiple(int bas, int n)
		{
			StringBuilder b = new StringBuilder(bas);

			if (n > 1)
				for (int i = 1; i <= n; i++)
					b.Append(bas * i);

			return validProduct(b.ToString()) ? Int32.Parse(b.ToString()) : -1;
		}
	}
}
