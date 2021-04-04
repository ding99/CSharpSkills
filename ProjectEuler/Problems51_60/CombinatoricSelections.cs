using System;
using System.Numerics;

namespace ProjectEuler.Problems51_60
{
	public class CombinatoricSelections
	{
		public void Start()
		{
			int count = 0;
			for (int n = 10; n < 101; n++)
				for (int r = 2; r < n; r++)
					if (Greater(n, r))
						count++;

			Console.WriteLine(count); //4075
		}

		private bool Greater(int n, int r)
		{
			BigInteger p = new BigInteger(1);

			for (int i = n; i > r; i--)
				p *= i;

			if (r > 1)
				for (int i = 2; i + r < n + 1; i++)
					p /= i;

			return p > 1000000;
		}
	}
}
