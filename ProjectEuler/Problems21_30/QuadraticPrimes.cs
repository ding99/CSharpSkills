using System;
using System.Collections.Generic;

namespace ProjectEuler.Problems21_30
{
	public class QuadraticPrimes
	{
		private List<int> primes;

		public QuadraticPrimes() {
			primes = new List<int>();

			for(int i = 2; i < 20000; i++)
				if(Prime(i))
					primes.Add(i);
		}

		public void Start()
		{
			int max = 0, maxa = 0, maxb = 0, current;
			for (int a = -999; a < 1000; a++)
			{
				if ((a % 100) == 0) Console.Write("a=" + a + " ");
				for (int b = -1000; b < 1001; b++)
					if ((current = total(a, b)) > max)
					{
						max = current;
						maxa = a;
						maxb = b;
					}
			}
			Console.WriteLine();

			Console.WriteLine("max " + max + " at (" + maxa + ", " + maxb + ").  " + maxa * maxb); //-59231
		}

		private bool Prime(int n) {
			if(n < 2)
				return false;

			int upper = n, mid;

			for(int i = 2; i < upper; i++)
				if((n % i) == 0)
					return false;
				else upper = upper > (mid = n / i + 1) ? mid : upper;

			return true;
		}

		private void CheckPrimes(int n) {
			int idx = primes.Count, m = primes[idx - 1];
			if(n <= m)
				return;

			for(int i = m + 1; i <= n; i++)
				if(Prime(i))
					primes.Add(i);
		}

		private bool isPrime(int number) {
			CheckPrimes(number + 10000);
			return primes.Contains(number);
		}

		//n*n + a * n + b
		private int total(int a,  int b) {
			int n = 0;
			while(isPrime(n * n + n * a + b))
				n++;

			return n;
		}
	}
}
