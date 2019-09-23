using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E31_Coin.Source {
	class PandigitalProducts {

		private bool validChars(char[] a) {
			List<char> digits = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
			foreach(char c in a)
				if(!digits.Contains(c))
					return false;
				else digits.Remove(c);

			return true;
		}

		private bool validProduct(int n) {
			return validChars(n.ToString().ToCharArray());
		}

		private bool validProducts(int n, int m ) {
			StringBuilder b = new StringBuilder(n.ToString()).Append(m.ToString()).Append((n / m).ToString());
			return b.Length == 9 && validChars(b.ToString().ToCharArray());
		}

		private bool isPandigital(int n) {
			int upper = n, mid;

			if(!validProduct(n))
				return false;

			for(int i = 2; i < upper; i++)
				if((n % i) == 0 && validProducts(n, i))
					return true;
				else upper = upper > (mid = n / i + 1) ? mid : upper;

			return false;
		}

		public void Start() {
			List<int> pandigits = new List<int>();

			for(int i = 2; i < 1000000; i++)
				if(isPandigital(i))
					pandigits.Add(i);

			Console.WriteLine(pandigits.Sum()); //45228
		}
	}
}
