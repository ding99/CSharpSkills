using System;
using System.Collections.Generic;

namespace ProjectEuler.Euler21_30
{
	public class APair
	{
		public int n { get; set; }
		public int d { get; set; }
	}

	public class AmicableNumbers
	{
		public void Start()
		{
			int div, index, amicables = 0;
			List<APair> ds = new List<APair>();

			for (int i = 1; i < 10000; i++)
				if ((div = d(i)) != 0 && div != i)
					if ((index = ds.FindIndex(a => a.n == div && a.d == i)) >= 0)
					{
						ds.RemoveAt(index);
						amicables += div + i;
					}
					else
						ds.Add(new APair { n = i, d = div }); ;

			Console.WriteLine(amicables); //31626
		}

		private int d(int n)
		{
			int divisors = 0, upper = n;

			if (n > 1) for (int i = 1; i < upper; i++)
					if ((n % i) == 0)
					{
						divisors += i;
						if (i > 1) divisors += n / i;
						upper = n / i;
					}

			return divisors;
		}
	}
}
