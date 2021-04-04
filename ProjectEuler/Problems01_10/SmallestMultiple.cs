using System;
using System.Collections.Generic;

namespace ProjectEuler.Problems01_10
{
	public class SmallestMultiple
	{
		IList<int> factors;

		public void Start()
		{
			factors = new List<int>();
			for (int i = 1; i < 21; i++)
				factors.Add(i);
			while (multi())
				factors.RemoveAt(0);

			List<int> quotients = new List<int>();
			for (int i = 2; i < 20; i++)
				while (repeat(i))
					quotients.Add(i);

			int product = 1;
			foreach (int i in quotients)
				product *= i;
			foreach (int i in factors)
				product *= i;

			Console.WriteLine(product);
		}

		private bool multi()
		{
			if (factors.Count > 1)
				for (int i = 1; i < factors.Count; i++)
					if (factors[i] % factors[0] == 0)
						return true;
			return false;
		}

		private bool repeat(int qt)
		{
			bool had = false;
			for (int i = 0; i < factors.Count; i++)
				if (factors[i] % qt == 0)
				{
					if (!had)
						had = true;
					else
					{
						for (int j = 0; j < factors.Count; j++)
							if (factors[j] % qt == 0)
								factors[j] /= qt;
						return true;
					}
				}
			return false;
		}
	}
}
