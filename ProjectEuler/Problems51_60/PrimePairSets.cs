using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProjectEuler.Euler51_60
{
	public class PrimePairSets
	{
		private List<int> primes;

		public PrimePairSets()
		{
			primes = new List<int>();
			for (int i = 2; i < 100000000; i++)
				if (Prime(i)) primes.Add(i);
			Console.WriteLine("primes : " + primes.Count);
		}

		public void Start()
		{
			Console.WriteLine(Search());  //26033
		}

		private int Search()
		{
			int sum, min = 100000000, max = 5;
			List<List<int>> sums = new List<List<int>> { new List<int> { 3 } }, next;
			List<int> add;
			bool found = false;

			for (int i = 2; i < 100000000; i++)
			{

				next = new List<List<int>>();
				foreach (var a in sums)
					if (Check(a, primes[i]))
					{
						(add = new List<int>(a)).Add(primes[i]);
						next.Add(add);
						if (add.Count + 1 == max)
							Show(add);
						if (add.Count == max)
						{
							Show(add);
							found = true;
							if ((sum = add.Sum()) < min)
								min = sum;
						}
					}

				if (found)
					break;

				sums.AddRange(next);
				sums.Add(new List<int> { primes[i] });
			}

			return min;
		}

		private bool Prime(int n)
		{
			if (n < 2)
				return false;

			int upper = n, m;
			for (int i = 2; i < upper; i++)
				if (n % i == 0)
					return false;
				else upper = upper > (m = n / i + 1) ? m : upper;

			return true;
		}

		private bool Pair(int a, int b)
		{
			return primes.Contains(Int32.Parse(new StringBuilder(a.ToString()).Append(b.ToString()).ToString()))
				&& primes.Contains(Int32.Parse(new StringBuilder(b.ToString()).Append(a.ToString()).ToString()));
		}

		private void Display(List<List<int>> ss)
		{
			Console.WriteLine("--- " + ss.Count + " ---");
			foreach (var a in ss)
			{
				Console.Write("[" + a.Count + "]");
				foreach (var b in a)
					Console.Write(" " + b);
				Console.WriteLine();
			}
		}

		private void Show(List<int> a)
		{
			Console.Write("Sum(" + a.Count + ") " + a.Sum() + " {");
			foreach (var b in a)
				Console.Write(" " + b);
			Console.WriteLine(" }");
		}

		private bool Check(List<int> list, int n)
		{
			foreach (var a in list)
				if (!Pair(a, n))
					return false;
			return true;
		}
	}
}
