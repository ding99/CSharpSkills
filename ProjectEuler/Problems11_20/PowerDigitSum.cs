using System;
using System.Numerics;

namespace ProjectEuler.Problems11_20
{
	public class PowerDigitSum
	{
		public void Start()
		{
			BigInteger power = new BigInteger(1);
			for (int i = 0; i < 1000; i++)
				power *= 2;
			string s = power.ToString();

			BigInteger sum = new BigInteger(0);
			for (int i = 0; i < s.Length; i++)
				sum += Int32.Parse(s.Substring(i, 1));

			Console.WriteLine(sum);
		}
	}
}
