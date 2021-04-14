/*
Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.

A mapping of digit to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Leet11_20 {
	public class PhoneLetter {
		public void Start() {
			OneNumber("23");
		}

		private void OneNumber(string digits) {
			Console.WriteLine($"Input: digits = \"{digits}\"");

			List<string> letters = new List<string>();

			letters.Add("ac");

			Console.Write("Output: [");
			int n = letters.Count;
			for (int i = 0; i < n; i++)
				Console.Write($"\"{letters[i]}\"{(i + 1 == n ? "]" : ",")}");
			Console.WriteLine();
		}
	}
}
