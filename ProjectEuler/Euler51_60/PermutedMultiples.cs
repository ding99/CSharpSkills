using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Euler51_60
{
	public class PermutedMultiples
	{
		public void Start()
		{
			int upper = 7, j, found = 0;
			for (int i = 10; i < 10000000; i++)
			{
				for (j = 2; j < upper; j++)
					if (!SameDigits(i, i * j))
						break;
				if (j == upper)
				{
					found = i;
					break;
				}
			}

			Console.WriteLine(found); //142857
		}

		private List<char> Digits(int n)
		{
			return n.ToString().ToCharArray().ToList();
		}

		private bool SameDigits(int a, int b)
		{
			List<char> lista = Digits(a), listb = Digits(b);

			if (lista.Count != listb.Count)
				return false;

			int p;
			foreach (var d in lista)
				if ((p = listb.IndexOf(d)) < 0)
					return false;
				else listb.RemoveAt(p);

			return listb.Count == 0;
		}
	}
}
