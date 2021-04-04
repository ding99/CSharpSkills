using System;
using System.Collections.Generic;

namespace ProjectEuler.Problems41_50
{
	public class PrimePermutations
	{
		private IList<char> digits;
		private IList<int> primes;

		public PrimePermutations()
		{
			digits = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

			primes = new List<int>();
			for (int i = 2; i < 10000; i++)
				if (Prime(i))
					primes.Add(i);
			Console.WriteLine("primes " + primes.Count);
		}

		public void Start()
		{

			List<List<char>> sets = new List<List<char>>();
			List<char> set;

			for (int i = 0; i < 10; i++)
				for (int j = 0; j < 10; j++)
					for (int k = 0; k < 10; k++)
						for (int l = 0; l < 10; l++)
						{
							(set = new List<char> { digits[i], digits[j], digits[k], digits[l] }).Sort();
							if (!Existing(sets, set)) sets.Add(set);
						}

			List<int> ps;
			foreach (var a in sets)
			{
				if ((ps = Sequence(GetPrimes(a))).Count > 2)
					dsp(ps);
			}
		}

		private List<int> GetPrimes(List<char> cons)
		{
			List<int> ps = new List<int>();
			List<char> c2, c3, c4;
			int value;

			foreach (var a in cons)
			{
				(c2 = new List<char>(cons)).Remove(a);
				foreach (var b in c2)
				{
					(c3 = new List<char>(c2)).Remove(b);
					foreach (var c in c3)
					{
						(c4 = new List<char>(c3)).Remove(c);
						value = Int32.Parse(new string(new char[] { a, b, c, c4[0] }));

						if (a != '0' && primes.Contains(value) && !ps.Contains(value))
							ps.Add(value);
					}
				}
			}

			return ps;
		}

		private List<int> Sequence(List<int> ps)
		{
			List<int> pn = new List<int>();
			int l = ps.Count;
			if (l > 2)
				for (int i = 0; i + 2 < l; i++)
					for (int j = i + 1; j + 1 < l; j++)
						if (ps.Contains(ps[j] * 2 - ps[i]))
						{
							pn.Add(ps[i]);
							pn.Add(ps[j]);
							pn.Add(ps[j] * 2 - ps[i]);
							if (ps.Contains(ps[j] * 3 - ps[i] * 2))
								pn.Add(ps[j] * 3 - ps[i] * 2);
						}
			return pn;
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

		private void dsp(List<int> list)
		{
			Console.Write("(" + list.Count + ")");
			foreach (var a in list)
				Console.Write(" " + a);
			Console.WriteLine();
		}

		private bool Equal(List<char> a, List<char> b)
		{
			if (a.Count != b.Count)
				return false;
			for (int i = 0; i < a.Count; i++)
				if (a[i] != b[i])
					return false;
			return true;
		}

		private bool Existing(List<List<char>> sets, List<char> set)
		{
			foreach (var a in sets)
				if (Equal(a, set)) return true;
			return false;
		}
	}
}
