using System;
using System.Collections.Generic;
using System.Text;

namespace E51_PrimeDigit.Source {
	class PrimeDigit {

		private bool Prime(int n) {
			if(n < 2)
				return false;

			int upper = n, mid;

			for(int i = 2; i < upper; i++)
				if((n % i) == 0)
					return false;
				else upper = upper > (mid = n / i + 1) ? mid : upper;

			return true;
		}

		private int Replace(int n, int src, int tgt) {
			string s = n.ToString();
			int l = s.Length;
			return Int32.Parse(new StringBuilder(s.Substring(0, l - 1).Replace(src.ToString(), tgt.ToString())).Append(s.Substring(l - 1)).ToString());
		}

		private int Search(int size) {

			List<int> primes = new List<int>();

			int limit = 1, count, times = 8;
			for(int i = 0; i + 1 < size; i++)
				limit *= 10;

			for(int i = limit + 1; i < limit * 10; i++)
				if(Prime(i))
					primes.Add(i);

			foreach(var p in primes) {
				count = 1;
				if(p.ToString().Substring(0, size - 1).Contains("0")) {
					for(int i = 1; i < 10; i++) {
						if(primes.Contains(Replace(p, 0, i)) && ++count == times)
							return p;
						if(count + 9 < times + i)
							break;
					}
				}
				else if(p.ToString().Substring(0, size - 1).Contains("1")) {
					for(int i = 2; i < 10; i++) {
						if(primes.Contains(Replace(p, 1, i)) && ++count == times)
							return p;
						if(count + 9 < times + i)
							break;
					}
				}
				else if(p.ToString().Substring(0, size - 1).Contains("2")) {
					for(int i = 3; i < 10; i++) {
						if(primes.Contains(Replace(p, 2, i)) && ++count == times)
							return p;
						if(count + 9 < times + i)
							break;
					}
				}
			}

			return -1;
		}

		public void Start() {

			int result;

			for(int i = 5; i < 8; i++) {
				if((result = Search(i)) > 0) {
					Console.WriteLine(result);  //121313
					return;
				}
			}

			Console.WriteLine("NOT FOUND");
		}
	}
}
