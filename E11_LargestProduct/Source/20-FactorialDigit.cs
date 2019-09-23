using System;
using System.Numerics;

namespace E11_LargestProduct {
	class FactorialDigit {
		public void Start() {

			BigInteger f = new BigInteger(1);
			for(int i = 1; i < 101; i++)
				f *= i;

			string s = f.ToString();
			int size = s.Length;

			int sum = 0;
			for(int i = 0; i < size; i++)
				sum += Int32.Parse(s.Substring(i, 1));

			Console.WriteLine(sum); //648
		}
	}
}
