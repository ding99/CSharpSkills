using System;
using System.Collections.Generic;

namespace ProjectEuler.Problems01_10
{
	public class SummationOfPrimes
	{
		IList<int> primes;

		//142913828922
		public void Sum()
		{
			primes = new List<int> { 2 };
			long sum = 2;
			for (int i = 3; i < 2000000; i += 2)
				if (prime(i))
					sum += i;
			Console.WriteLine(sum);
		}

		private bool prime(int n)
		{
			foreach (int i in primes)
				if (n % i == 0)
					return false;
			primes.Add(n);
			return true;
		}
	}
}
