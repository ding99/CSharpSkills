using System;

namespace ProjectEuler.Euler11_20
{
	public class CountingSundays
	{
		public void Start()
		{
			Console.WriteLine(Count(2001) - Count(1901)); //171 (173 - 2)
		}

		private int Count(int year)
		{
			int sum = 0, days, sundays = 0;

			for (int i = 1900; i < year; i++)
			{
				for (int j = 1; j <= 12; j++)
				{
					if (sum != 0 && (sum - 6) % 7 == 0)
						sundays++;

					switch (j)
					{
						case 2:
							days = 28;
							if (i % 400 == 0 || (i % 4 == 0 && i % 100 != 0))
								days++;
							break;
						case 4:
						case 6:
						case 9:
						case 11:
							days = 30;
							break;
						default:
							days = 31;
							break;
					}
					sum += days;
				}
			}

			return sundays;
		}
	}
}
