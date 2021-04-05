using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Euler31_40
{
	public class TruncatablePrimes
	{
		private List<int> primes;

		public TruncatablePrimes()
		{
			primes = new List<int>();

			for (int i = 2; i < 200000; i++)
				if (Prime(i))
					primes.Add(i);
		}

		public void Start()
		{
			List<int> truncs = new List<int>();

			for (int i = 11; i < 1000000; i++)
				if (Truncatable(i))
				{
					truncs.Add(i);
					if (truncs.Count == 11)
						break;
				}

			Console.WriteLine(truncs.Sum()); //748317

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

		private void CheckPrimes(int n)
		{
			int idx = primes.Count, m = primes[idx - 1];
			if (n <= m)
				return;

			for (int i = m + 1; i <= n + 10000; i++)
				if (Prime(i))
					primes.Add(i);
		}

		private bool Left(int n)
		{
			string s = n.ToString();
			while (s.Length > 1)
				if (!primes.Contains(Int32.Parse(s = s.Substring(1))))
					return false;
			return true;
		}

		private bool Right(int n)
		{
			while ((n /= 10) > 0)
				if (!primes.Contains(n))
					return false;
			return true;
		}

		private bool Truncatable(int n)
		{
			CheckPrimes(n);
			return primes.Contains(n) && Right(n) && Left(n);
		}
	}
}
