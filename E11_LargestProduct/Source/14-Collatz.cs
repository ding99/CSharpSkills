using System;
using System.Collections.Generic;

namespace E11_LargestProduct {
	class Collatz {

		private List<long> one(long start) {
			List<long> seq = new List<long> { start };
			long next = start;

			while(next != 1)
				seq.Add(next = (next % 2) == 1 ? next * 3 + 1 : next / 2);

			return seq;
		}

		public void Start() {
			List<long> crt;
			long count = 0, max = 0;

			try {
				for(int i = 1; i < 1000000; i++)
					if((crt = one(i)).Count > max) {
						max = crt.Count;
						count = i;
					}
			}
			catch(Exception e) { Console.WriteLine(e.Message); }

			Console.WriteLine(count);
		}
	}
}
