using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Euler31_40
{
	public class CircularPrimes
	{
		private IList<int> primes;

		public CircularPrimes()
		{
			primes = new List<int>();

			for (int i = 2; i < 1000000; i++)
				if (Prime(i))
					primes.Add(i);
		}

		public void Start()
		{
			List<int> circulars = new List<int>();
			foreach (int i in primes)
				if (isCirculer(i))
					circulars.Add(i);

			Console.WriteLine(circulars.Count); //55
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

		private bool isCirculer(int n)
		{
			if (n < 10)
				return true;
			string s = n.ToString();
			int l = s.Length;

			for (int i = 0; i + 1 < l; i++)
				if (!Prime(int.Parse(s = new StringBuilder(s.Substring(1)).Append(s.Substring(0, 1)).ToString())))
					return false;

			return true;
		}
	}
}
