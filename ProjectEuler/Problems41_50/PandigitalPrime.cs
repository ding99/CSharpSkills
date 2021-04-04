using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Problems41_50
{
	public class PandigitalPrime
	{
		private IList<char> digits;

		public PandigitalPrime()
		{
			digits = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
		}

		public void Start()
		{

			int result = 0;
			for (int i = 9; i > 1; i--)
				if ((result = max(i)) > 0)
					break;

			Console.WriteLine(result); //7652413
		}

		private bool Prime(int n)
		{
			if (n < 2)
				return false;

			int upper = n, mid;

			for (int i = 2; i < upper; i++)
				if ((n % i) == 0)
					return false;
				else upper = upper > (mid = n / i + 1) ? mid : upper;

			return true;
		}

		private List<string> joint(string s, List<char> master)
		{
			List<string> ss = new List<string>();

			if (master.Count < 2)
				ss.Add(new StringBuilder(s).Append(master.ToArray()).ToString());
			else
			{
				List<char> newMaster;
				foreach (var c in master)
				{
					(newMaster = new List<char>(master)).Remove(c);
					ss.AddRange(joint(new StringBuilder(s).Append(c).ToString(), newMaster));
				}
			}

			return ss;
		}

		private int max(int n)
		{
			List<char> master = new List<char>();
			for (int i = 0; i < n; i++)
				master.Add(digits[i]);

			int pand = 0, current;

			foreach (var s in joint(string.Empty, master))
				if (Prime(current = Int32.Parse(s)) && current > pand)
					pand = current;

			return pand;
		}
	}
}
