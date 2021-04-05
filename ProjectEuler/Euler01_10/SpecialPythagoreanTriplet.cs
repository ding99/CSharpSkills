using System;

namespace ProjectEuler.Euler01_10
{
	public class SpecialPythagoreanTriplet
	{
		public void Start()
		{
			int c;
			for (int a = 1; a < 500; a++)
				for (int b = a + 1; b < 501; b++)
					if (a * a + b * b == (c = 1000 - a - b) * c)
					{
						Console.WriteLine(a * b * c);
						return;
					}
		}
	}
}
