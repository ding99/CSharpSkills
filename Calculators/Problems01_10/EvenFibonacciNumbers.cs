using System;
using System.Collections.Generic;
using System.Text;

namespace Problems01_10
{
	public class EvenFibonacciNumbers
	{
		public void Start()
		{
			long sum = 2;
			int a = 1, b = 2, c = 0;
			while ((c = a + b) < 4000000)
			{
				if (c % 2 == 0)
					sum += c;
				a = b;
				b = c;
			}
			Console.WriteLine(sum);
		}
	}
}
