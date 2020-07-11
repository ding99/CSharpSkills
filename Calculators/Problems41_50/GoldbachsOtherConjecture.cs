using System;
using System.Collections.Generic;

namespace Problems41_50
{
	public class GoldbachsOtherConjecture
	{
		private IList<int> primes;
		private IList<int> squares;

		public GoldbachsOtherConjecture()
		{
			primes = new List<int>();
			squares = new List<int> { 1 };
		}

		public void Start()
		{
			int i = 0;

			for (i = 2; i < 10000000; i++)
			{

				if (Prime(i))
					primes.Add(i);
				else if ((i % 2) == 1 && !Match(i))
					break;

				squares.Add(i * i);
			}

			Console.WriteLine(i); //5777
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

		private bool Match(int n)
		{
			foreach (var a in primes)
				if (a < n)
					foreach (var b in squares)
						if (b < n && a + b * 2 == n)
							return true;
			return false;
		}
	}
}
