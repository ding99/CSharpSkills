using System;
using System.Collections.Generic;

namespace Numbers
{
	public class Primes
	{
		public bool isPrime(int n)
		{
			if (n < 2)
				return false;

			int upper = n, mid;

			for (int i = 2; i < upper; i++)
			{
				if ((n % i) == 0)
					return false;
				if(upper > (mid = n / i + 1))
					upper = mid;
			}

			return true;
		}

		public List<int> FirstPrimes(int count)
		{
            List<int> lists = new List<int>();

            if (count < 0)
            {
                lists.Add(-1);
            }
            else if (count > 0)
            {
                for (int i = 0; i < Int32.MaxValue; i++)
                {
                    if (isPrime(i))
                    {
                        lists.Add(i);
                        if (lists.Count == count)
                            break;
                    }
                }

                if (lists.Count < count)
                {
                    lists.Clear();
                    lists.Add(-1);
                }
            }

            return lists;
        }
    }
}
