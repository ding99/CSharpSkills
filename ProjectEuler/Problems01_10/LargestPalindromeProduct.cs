using System;

namespace ProjectEuler.Problems01_10
{
	public class LargestPalindromeProduct
	{
		public void Start()
		{
			int max = 1, product;
			for (int i = 100; i < 1000; i++)
				for (int j = 100; j < 1000; j++)
					if (valid(product = i * j) && max < product)
						max = product;
			Console.WriteLine(max);
		}
		private bool valid(int n)
		{
			if (n < 100000)
				return (n / 10000) == (n % 10) && ((n / 1000) % 10 == (n / 10) % 10);
			return (n / 100000) == (n % 10) && ((n / 10000) % 10 == (n / 10) % 10) && ((n / 1000) % 10 == (n / 100) % 10);
		}
	}
}
