using System;
using System.Collections.Generic;

namespace ProjectEuler.Euler11_20
{
	public class LongestCollatzSequence
	{
		public void Start()
		{
			IList<long> crt;
			long count = 0, max = 0;

			try
			{
				for (int i = 1; i < 1000000; i++)
					if ((crt = one(i)).Count > max)
					{
						max = crt.Count;
						count = i;
					}
			}
			catch (Exception e) { Console.WriteLine(e.Message); }

			Console.WriteLine(count);
		}

		private List<long> one(long start)
		{
			List<long> seq = new List<long> { start };
			long next = start;

			while (next != 1)
				seq.Add(next = (next % 2) == 1 ? next * 3 + 1 : next / 2);

			return seq;
		}
	}
}
