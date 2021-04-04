using System;
using System.Collections.Generic;

namespace ProjectEuler.Problems41_50
{
	public class DistinctPrimesFactors
	{
		private IList<int> primes;

		public DistinctPrimesFactors()
		{
			primes = new List<int> { 2, 3, 5 };
		}

		public void Start()
		{

			int found = 0, first = 0;

			for (int i = 6; i < 10000000; i++)
			{
				if (Prime(i))
				{
					if (!primes.Contains(i))
						primes.Add(i);
					found = 0;
				}
				else if (!FourFactor(i))
					found = 0;
				else if (++found == 4)
				{
					first = i - 3;
					break;
				}
			}

			Console.WriteLine(first); //134043
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

		private bool FourFactor(int n)
		{
			List<int> factors = new List<int>();

			foreach (var p in primes)
				if (n % p == 0 && !factors.Contains(p))
					factors.Add(p);

			return factors.Count == 4;
		}
	}
}
