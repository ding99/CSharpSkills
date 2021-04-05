using System;
using System.Collections.Generic;

namespace ProjectEuler.Euler31_40
{
	public class Fraction
	{
		public int Numerator { get; set; }
		public int Denominator { get; set; }
	}

	public class DigitCancellingFractions
	{
		public void Start()
		{
			List<Fraction> curious = new List<Fraction>();

			int numerator, denominator;

			for (int i = 1; i < 10; i++)
				for (int j = 1; j < 10; j++)
				{
					numerator = i * 10 + j;
					for (int k = 1; k < 10; k++)
					{
						if ((denominator = j * 10 + k) > numerator && k * numerator == i * denominator && curious.FindIndex(a => a.Numerator == numerator && a.Denominator == denominator) < 0)
							curious.Add(new Fraction { Numerator = i, Denominator = k });
						if ((denominator = k * 10 + i) > numerator && k * numerator == j * denominator && curious.FindIndex(a => a.Numerator == numerator && a.Denominator == denominator) < 0)
							curious.Add(new Fraction { Numerator = j, Denominator = k });
					}
				}

			numerator = 1; denominator = 1;
			foreach (var a in curious)
			{
				numerator *= a.Numerator;
				denominator *= a.Denominator;
			}
			Console.WriteLine(Reduct(numerator, denominator)); //100
		}

		private bool Prime(int n)
		{
			if (n < 2)
				return false;

			int upper = n, mid;

			for (int i = 2; i < upper; i++)
				if ((n % i) == 0)
					return false;
				else upper = upper > (mid = n / i + 1) ? mid : upper;

			return true;
		}

		private int Reduct(int num, int den)
		{

			List<int> primes = new List<int>();
			for (int i = 2; i < num; i++)
				if (Prime(i))
					primes.Add(i);

			foreach (int p in primes)
				while (num % p == 0)
				{
					num /= p;
					den /= p;
				}

			return den;
		}
	}
}
