﻿using System;
using System.Numerics;

namespace E21_Amicable {
	class Fibonacci1000 {
		public void Start() {

			int index = 12;
			string unit = "9999999999", bas = "999999999";
			for(int i = 0; i < 99; i++)
				bas += unit;
			BigInteger key = BigInteger.Parse(bas), first = 89, second = 144, middle;

			while(second < key) {
				middle = first;
				first = second;
				second += middle;
				index++;
			}

			Console.WriteLine(index); //4782

		}
	}
}