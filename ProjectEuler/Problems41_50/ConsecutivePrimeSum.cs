using System;
using System.Collections.Generic;

//Time-consuming, to double check

namespace ProjectEuler.Problems41_50
{
	public class ConsecutivePrimeSum
	{
		private IList<int> primes;

		public void Start()
		{

			primes = new List<int>();
			int max = 0, maxPrime = 0, current;

			for (int i = 2; i < 1000000; i++)
			{
				if (!Prime(i)) continue;

				if ((current = Longest(i)) > max)
				{
					max = current;
					maxPrime = i;
				}

				primes.Add(i);
			}

			Console.WriteLine("prime " + maxPrime); //997651
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

		private int Longest(int n)
		{
			int sum, l = primes.Count, size;

			for (int i = 0; i + 1 < l; i++)
			{
				sum = primes[i];
				size = 1;

				for (int j = i + 1; j < l; j++)
				{
					if ((sum += primes[j]) == n)
						return size + 1;
					else if (sum < n)
						size++;
					else break;

				}
			}

			return 0;
		}
	}
}
