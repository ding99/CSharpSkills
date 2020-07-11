using System;

namespace Problems31_40
{
	public class CoinSums
	{
		public void Start()
		{
			int count = 0;

			for (int i200 = 0; i200 <= 1; i200++)
				for (int i100 = 0; i100 <= 2; i100++)
					for (int i50 = 0; i50 * 50 <= 200 - 200 * i200 - 100 * i100; i50++)
						for (int i20 = 0; i20 * 20 <= 200 - 200 * i200 - i100 * 100 - i50 * 50; i20++)
							for (int i10 = 0; i10 * 10 <= 200 - 200 * i200 - i100 * 100 - i50 * 50 - i20 * 20; i10++)
								for (int i5 = 0; i5 * 5 <= 200 - 200 * i200 - i100 * 100 - i50 * 50 - i20 * 20 - i10 * 10; i5++)
									for (int i2 = 0; i2 * 2 <= 200 - 200 * i200 - i100 * 100 - i50 * 50 - i20 * 20 - i10 * 10 - i5 * 5; i2++)
										count++;

			Console.WriteLine(count);  //73682
		}
	}
}
