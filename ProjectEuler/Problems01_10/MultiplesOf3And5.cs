using System;

namespace Problems01_10
{
	public class MultiplesOf3And5
	{
		public void Start()
		{
			int sum = 0;
			for (int i = 0; i < 1000; i++)
				if (i % 3 == 0 || i % 5 == 0)
					sum += i;
			Console.WriteLine(sum);
		}
	}
}
