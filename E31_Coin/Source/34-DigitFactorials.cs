using System;
using System.Collections.Generic;
using System.Linq;

namespace E31_Coin.Source {
	class DigitFactorials {

		private int[] factorials;

		public DigitFactorials() {
			factorials = new int[10];
			factorials[0] = 1;
			for(int i = 1; i < 10; i++)
				factorials[i] = factorials[i - 1] * i;
		}


		public void Start() {
			List<int> curious = new List<int>();

			int sum;
			for(int i = 10; i < 100000000; i++) {
				sum = factorials[i % 10] + factorials[i / 10 % 10];
				if(i > 99) {
					sum += factorials[i / 100 % 10];
					if(i > 999) {
						sum += factorials[i / 1000 % 10];
						if(i > 9999) {
							sum += factorials[i / 10000 % 10];
							if(i > 99999) {
								sum += factorials[i / 100000 % 10];
								if(i > 999999) {
									sum += factorials[i / 1000000 % 10];
									if(i > 9999999)
										sum += factorials[i % 10];
								}
							}
						}
					}
				}

				if(sum == i)
					curious.Add(i);
			}

			Console.WriteLine(curious.Sum()); //40730
		}
	}
}
