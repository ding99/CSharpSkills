using System;
using System.Numerics;

namespace ProjectEuler.Euler51_60
{
	public class LychrelNumbers
	{
		public void Start()
		{
			int count = 0;
			for (BigInteger i = 10; i < 10000; i++)
				if (isLychrel(i, 0))
					count++;

			Console.WriteLine(count);  //249
		}

		private BigInteger Reverse(BigInteger n)
		{
			char[] c = n.ToString().ToCharArray();
			Array.Reverse(c);
			return BigInteger.Parse(new string(c));
		}

		private bool isLychrel(BigInteger n, int layer)
		{
			BigInteger sum = n + Reverse(n);
			return ++layer == 50 ? true : sum.Equals(Reverse(sum)) ? false : isLychrel(sum, layer);
		}
	}
}
