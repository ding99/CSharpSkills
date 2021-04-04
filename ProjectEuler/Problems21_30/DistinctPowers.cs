using System;
using System.Collections.Generic;
using System.Numerics;

namespace ProjectEuler.Problems21_30
{
	public class DistinctPowers
	{
		private List<BigInteger> terms;

		public DistinctPowers()
		{
			terms = new List<BigInteger>();
		}

		public void Start()
		{
			one(100, 100); //9183
		}

		private void one(int maxa, int maxb)
		{
			BigInteger bas;
			for (int a = 2; a <= maxa; a++)
			{
				bas = a;
				for (int b = 2; b <= maxb; b++)
					if (!terms.Contains(bas *= a))
						terms.Add(bas);
			}
			Console.WriteLine(terms.Count);
		}
	}
}
