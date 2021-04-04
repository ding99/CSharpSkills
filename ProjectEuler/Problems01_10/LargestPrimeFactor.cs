using System;

namespace ProjectEuler.Problems01_10
{
	public class LargestPrimeFactor
	{
		public void Start()
		{

			long sum = 600851475143, sum0 = sum, max = 1;
			for (long i = 3; i < sum + 1 && i < sum0; i += 2)
			{
				if (prime(i) && sum % i == 0)
				{
					max = i;
					sum = modify(sum, i);
				}
			}

			Console.WriteLine(max);
		}

		private bool prime(long n)
		{
			if (n == 3)
				return true;
			for (long i = 3; i < n; i++)
				if (n % i == 0)
					return false;
			return true;
		}

		private long modify(long n, long prime)
		{
			while (n % prime == 0)
				n /= prime;
			return n;
		}
	}
}
