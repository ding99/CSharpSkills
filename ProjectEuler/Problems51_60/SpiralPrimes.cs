using System;

namespace Problems51_60
{
	public class SpiralPrimes
	{
		private int diagonals, valids;

		public void Start()
		{
			int i;

			for (i = 3; i < 1000000; i += 2)
				if (Cycle(i))
					break;

			Console.WriteLine(i); //26241
		}

		public SpiralPrimes()
		{
			diagonals = 1;
			valids = 0;
		}

		private bool Prime(int n)
		{
			if (n < 2)
				return false;

			int upper = n, mid;

			for (int i = 2; i < upper; i++)
				if (n % i == 0)
					return false;
				else upper = upper > (mid = n / i + 1) ? mid : upper;

			return true;
		}

		private bool Cycle(int n)
		{
			int b = n * n;
			diagonals += 4;

			if (Prime(b + 1 - n)) valids++;
			if (Prime(b + 2 - n * 2)) valids++;
			if (Prime(b + 3 - n * 3)) valids++;

			return valids * 10 < diagonals;
		}
	}
}
