using System;
using System.Collections.Generic;

namespace ProjectEuler.Euler11_20
{
	public class HighlyDivisibleTriangularNumber
	{
		private int seed;
		private int triangle;
		private IList<int> divisors;

		public HighlyDivisibleTriangularNumber()
		{
			seed = 1;
			triangle = 1;
			divisors = new List<int>();
		}

		public void Start()
		{
			do
			{
				Step();
			} while (divisors.Count <= 500);

			Console.WriteLine(triangle);
		}

		private void Step()
		{
			seed++;
			triangle += seed;

			divisors = new List<int>();
			int divide = 0, upper = triangle;
			for (int i = 1; i < upper; i++)
				if ((triangle % i) == 0)
				{
					if (!divisors.Contains(i))
						divisors.Add(i);
					if (!divisors.Contains(divide = triangle / i))
					{
						divisors.Add(divide);
						upper = divide;
					}
				}
		}
	}
}
