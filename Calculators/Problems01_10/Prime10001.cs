using System;

namespace Problems01_10
{
	public class Prime10001
	{
		public void Start()
		{
			int n = 2;
			long s;
			for (s = 5; ; s += 2)
				if (prime(s) && ++n > 10000)
					break;
			Console.WriteLine(s);
		}

		private bool prime(long n)
		{
			if (n == 3)
				return true;
			for (long i = 3; i < n; i += 2)
				if (n % i == 0)
					return false;
			return true;
		}
	}
}
