using System;
using System.Numerics;

namespace E21_Amicable {
	class ReciprocalCycles {

		private BigInteger numerator;

		public ReciprocalCycles() {
			numerator = new BigInteger(1000000);
			for(int i = 0; i < 1001; i++)
				numerator *= 10000000000;
		}

		private bool repeat(string s, ref int step) {
			int times = 5, size = s.Length, index;

			if(size < step * times) {
				step = -1;
				return false;
			}

			for(int i = 1; i < times; i++)
				if(string.Compare(s, size - step * (i + 1), s, size - step, step) != 0) {
					string key = s.Substring(size - step * i - 1);
					step = (index = s.Substring(0, size - key.Length).LastIndexOf(key)) >= 0 ? size - index - key.Length : -1;
					return false;
				}

			return true;
		}

		private int length(int n){
			string s = (numerator / n).ToString();
			s = s.Substring(0, s.Length - 16);
			int step = 1;

			while(!repeat(s, ref step) && step >= 0) ;

			return step;
		}

		public void Start() {
			int max = 0, position = 0, current, size = 1000;

			for(int i = 3; i < size; i++)
				if((current = length(i)) > max) {
					max = current;
					position = i;
					Console.Write(position + "-" + max + " ");
				}
			Console.WriteLine();

			Console.WriteLine(position); //983
		}
	}
}
