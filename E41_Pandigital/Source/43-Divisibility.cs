using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace E41_Pandigital.Source {
	class Divisibility {

		private List<char> digits;
		private int[] primes;

		public Divisibility() {
			digits = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
			primes = new int[] { 2, 3, 5, 7, 11, 13, 17 };
		}

		private void dsp(List<char> mm) {
			StringBuilder m = new StringBuilder();
			foreach(var a in mm)
				m.Append(a);
			Console.Write(m.ToString() + " ");
		}

		private List<string> addDigit(string s, List<char> master) {
			List<string> ss = new List<string>();

			try {
				if(master.Count < 2) {
					string sn = new StringBuilder(s).Append(master.ToArray()).ToString();
					if(Int32.Parse(sn.Substring(sn.Length - 3)) % primes[s.Length - 3] == 0)
						ss.Add(sn);
				} else {
					int size = s.Length;
					List<char> newMaster;
					string newString;

					foreach(char c in master) {
						newString = new StringBuilder(s).Append(c).ToString();
						if(size < 3 || (Int32.Parse(newString.Substring(size - 2)) % primes[size - 3]) == 0) {
							(newMaster = new List<char>(master)).Remove(c);
							ss.AddRange(addDigit(newString, newMaster));
						}
					}
				}
			}
			catch(Exception e) {
				Console.WriteLine(e.Message);
				Console.WriteLine(e.StackTrace);
			}

			return ss;
		}

		public void Start() {
			List<string> numbers = addDigit(string.Empty, digits);

			BigInteger sum = new BigInteger(0);
			foreach(var s in numbers)
				sum += BigInteger.Parse(s);

			Console.WriteLine(sum); //16695334890
		}
	}
}
