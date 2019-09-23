using System;
using System.Collections.Generic;

namespace E41_Pandigital.Source {
	class Pentagon {

		private List<int> ps;
		private int min;

		public Pentagon() {
			min = 100000000;
			ps = new List<int> { P(1), P(2) };
		}

		private int P(int n) {
			return (n * 3 - 1) * n >> 1;
		}

		private bool Search(int n) {
			int diff;

			foreach(var i in ps)
				if(ps.Contains(n - i) && ps.Contains(diff = Math.Abs(n - i - i))) {
					min = diff;
					return true;
				}

			ps.Add(n);
			return false;
		}

		public void Start() {
			for(int i = 3; i < 10000; i++)
				if(Search(P(i))) break;

			Console.WriteLine(min); //5482660
		}
	}
}
