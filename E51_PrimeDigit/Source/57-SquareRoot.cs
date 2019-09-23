using System;
using System.Numerics;

namespace E51_PrimeDigit.Source {
	class SquareRoot {

		private BigInteger numerator, denominator, newDenominator, count;

		public SquareRoot() {
			numerator = 1;
			denominator = 1;
			count = 0;
		}

		private bool next(int time) {
			newDenominator = numerator + denominator;
			numerator = denominator + newDenominator;
			denominator = newDenominator;

			if(numerator.ToString().Length > denominator.ToString().Length)
				count++;

			return time < 1001 ? next(time + 1) : true; 
		}

		public void Start() {
			if(next(1))
				Console.WriteLine(count); //153
		}
	}
}
