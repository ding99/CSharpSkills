using System;
using System.Collections.Generic;

namespace E11_LargestProduct {
	class TriangleNumber {

		private int seed;
		private int triangle;
		private List<int> divisors;

		public TriangleNumber() {
			seed = 1;
			triangle = 1;
			divisors = new List<int>();
		}

		private void Step() {
			seed++;
			triangle += seed;

			divisors = new List<int>();
			int divide = 0, upper = triangle;
			for(int i = 1; i < upper; i++)
				if((triangle % i) == 0) {
					if(!divisors.Contains(i))
						divisors.Add(i);
					if(!divisors.Contains(divide = triangle / i)) {
						divisors.Add(divide);
						upper = divide;
					}
				}
		}

		public void Start() {
			do {
				Step();
			} while(divisors.Count <= 500);

			Console.WriteLine(triangle);
		}
	}
}
