using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Euler21_30
{
	public class NonAbundantSums
	{
		private List<int> abundants;

		public NonAbundantSums()
		{
			abundants = new List<int>();
		}

		public void Start()
		{
			#region create abundant list
			for (int i = 12; i < 28123 - 11; i++)
				if (d(i) > i)
					abundants.Add(i);
			Console.WriteLine("Abundants : " + abundants.Count);
			#endregion

			int sum = 0;

			for (int i = 0; i < 24; i++)
				sum += i;
			for (int i = 24; i < 28124; i++)
				if (nonAbundantSum(i))
					sum += i;

			Console.WriteLine(sum); //4179871
		}

		private int d(int n)
		{
			int divisors = 0, upper = n;

			if (n > 1) for (int i = 1; i < upper; i++)
					if ((n % i) == 0)
					{
						divisors += i;
						if (i > 1 && (n / i) != i) divisors += n / i;
						upper = n / i;
					}

			return divisors;
		}

		private bool nonAbundantSum(int n)
		{
			if (n < 24)
				return true;

			foreach (int i in abundants)
				if (i >= n)
					break;
				else if (abundants.Contains(n - i))
					return false;

			return true;
		}
	}
}
