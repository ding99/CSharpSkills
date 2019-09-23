using System;
using System.Numerics;

namespace E21_Amicable {
	class SpiralDiagonals {

		private void calculate(int n) {
			BigInteger sum = new BigInteger(1);

			for(int i = 2; i + 1 <= n; i += 2)
				sum += (i - 1) * (i - 1) * 4 + i * 10;

			Console.WriteLine(sum);
		}
		public void Start() {
			calculate(1001); //669171001
		}
	}
}
