using System;
using System.Numerics;

namespace Problems51_60
{
	public class SquareRootConvergents
	{
		private BigInteger numerator, denominator, newDenominator, count;

		public SquareRootConvergents()
		{
			numerator = 1;
			denominator = 1;
			count = 0;
		}

		public void Start()
		{
			if (next(1))
				Console.WriteLine(count); //153
		}

		private bool next(int time)
		{
			newDenominator = numerator + denominator;
			numerator = denominator + newDenominator;
			denominator = newDenominator;

			if (numerator.ToString().Length > denominator.ToString().Length)
				count++;

			return time < 1001 ? next(time + 1) : true;
		}
	}
}
