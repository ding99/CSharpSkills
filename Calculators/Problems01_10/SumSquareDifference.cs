using System;

namespace Problems01_10
{
	public class SumSquareDifference
	{
		public void Start()
		{
			long sum = 0, ssum = 0;
			for (int i = 1; i <= 100; i++)
			{
				sum += i;
				ssum += i * i;
			}

			Console.WriteLine(sum * sum - ssum);
		}
	}
}
