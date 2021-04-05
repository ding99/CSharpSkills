using System;
using System.Numerics;

namespace ProjectEuler.Euler11_20
{
	public class LatticePaths
	{
		public void Start()
		{
			BigInteger result = Factorial(40);
			result /= Factorial(20);
			result /= Factorial(20);

			Console.WriteLine(result);
		}

		private BigInteger Factorial(int n)
		{
			BigInteger product = new BigInteger(1);
			if (n > 1)
				for (int i = 1; i <= n; i++)
					product *= i;
			return product;
		}
	}
}
