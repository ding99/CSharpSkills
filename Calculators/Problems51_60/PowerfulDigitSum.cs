using System;
using System.Numerics;

namespace Problems51_60
{
	public class PowerfulDigitSum
	{
		public void Start()
		{
			int max = 0, value;
			BigInteger bas;

			for (int i = 1; i < 100; i++)
			{
				bas = new BigInteger(1);
				for (int j = 1; j < 100; j++)
				{
					if ((value = Sum(bas *= i)) > max)
						max = value;
				}
			}

			Console.WriteLine(max);  //972
		}

		private int Sum(BigInteger n)
		{
			int sum = 0;
			string s = n.ToString();
			for (int i = 0; i < s.Length; i++)
				sum += Int32.Parse(s.Substring(i, 1));
			return sum;
		}
	}
}
