using System;
using System.Collections.Generic;

namespace ProjectEuler.Problems31_40
{
	public class Trianle
	{
		public int Large { get; set; }
		public int Small { get; set; }
		public int Bevel { get; set; }
	}

	public class IntegerRightTriangles
	{
		public void Start()
		{
			int max = 0, current, p = 0;

			for (int n = 3; n < 1000; n++)
				if ((current = number(n)) > max)
				{
					max = current;
					p = n;
				}

			Console.WriteLine(p); //840
		}

		private int number(int n)
		{
			int side;
			List<Trianle> sides = new List<Trianle>();

			for (int i = n / 3; i < n / 2; i++)
				for (int j = 1; j + 1 < i; j++)
					if (j * j + (side = n - i - j) * side == i * i &&
						sides.FindIndex(a => a.Large == (j >= side ? j : side) && a.Small == (j >= side ? side : j) && a.Bevel == i) < 0)
						sides.Add(new Trianle { Large = (j >= side ? j : side), Small = (j >= side ? side : j), Bevel = i });

			return sides.Count;
		}
	}
}
