using System;
using System.Numerics;

namespace ProjectEuler.Euler41_50
{
	public class SelfPowers
	{
		BigInteger mode = BigInteger.Parse("10000000000");

		public void Start()
		{
			BigInteger sum = new BigInteger(0);
			for (int i = 1; i < 1001; i++)
				sum += Power(i);

			Console.WriteLine(sum % mode); //9110846700
		}

		private BigInteger Power(int n)
		{
			BigInteger p = new BigInteger(1);
			for (int i = 0; i < n; i++)
				p = p * n % mode;

			return p;
		}
	}
}
