using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Euler21_30
{
	public class DigitFifthPowers
	{
		private int[] p5;

		public DigitFifthPowers()
		{
			p5 = new int[10];
			for (int i = 0; i < 10; i++)
				p5[i] = i * i * i * i * i;
		}

		public void Start()
		{
			Power5();
		}

		private void Power5()
		{
			List<int> sum = new List<int>();

			for (int i = 2; i < 1000000; i++)
				if (p5[i / 100000] + p5[i / 10000 % 10] + p5[i / 1000 % 10] + p5[i / 100 % 10] + p5[i / 10 % 10] + p5[i % 10] == i)
					sum.Add(i);

			Console.WriteLine(sum.Sum());
		}
	}
}
