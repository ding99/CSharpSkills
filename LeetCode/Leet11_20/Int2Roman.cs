/*
 Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given an integer, convert it to a roman numeral.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Leet11_20 {
	public class Int2Roman {
		public void Start() {
			Action(3);
		}

		private void Action(int num) {
			Console.WriteLine($"Input: num = {num}");
			string roman = string.Empty;

			Dictionary<int, string> table = new Dictionary<int, string>{
				{ 1000, "M" },
				{ 500, "D" },
				{ 100, "C" },
				{ 50, "L" },
				{ 10, "X" },
				{ 5, "V" },
				{ 1, "I" }
			};

			var keys = table.Keys;
			Console.Write($"keys ({keys.Count})");
			foreach (var k in keys) Console.Write($" <{k}>[{table[k]}]");
			Console.WriteLine();

			foreach (int k in table.Keys) {
				switch (k) {
					case 4:
						roman += "IV";
						num -= 4;
						break;
					case 9:
						roman += "IX";
						num -= 9;
						break;
					case 40:
						roman += "XL";
						num -= 40;
						break;
					case 90:
						roman += "XC";
						num -= 90;
						break;
					case 400:
						roman += "CD";
						num -= 400;
						break;
					case 900:
						roman += "CM";
						num -= 900;
						break;
					default:
						while (num >= k) { roman += table[k]; num -= k; }
						break;
				}
			}

			Console.WriteLine($"Output: \"{roman}\"");
		}
	}
}
