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

namespace LeetCode.Leet11_20 {
	public class RomanNumbers {
		public void Int2Roman() {
			Int2RomanOne(3);
			Int2RomanOne(4);
			Int2RomanOne(9);
			Int2RomanOne(58);
			Int2RomanOne(1994);
		}

		private void Int2RomanOne(int num) {
			Console.WriteLine($"Input: num = {num}");
			string roman = string.Empty;

			Dictionary<int, string> table = new Dictionary<int, string>{
				{ 1000, "M" }, {900, "CM"},
				{ 500, "D" }, {400, "CD"},
				{ 100, "C" }, {90, "XC"},
				{ 50, "L" }, {40, "XL"},
				{ 10, "X" }, {9, "IX"},
				{ 5, "V" }, {4, "IV"},
				{ 1, "I" }
			};

			foreach (int k in table.Keys)
				while (num >= k) { roman += table[k]; num -= k; }

			Console.WriteLine($"Output: \"{roman}\"");
		}

		public void Roman2Int() {
			Roman2IntOne("III");
			Roman2IntOne("IV");
			Roman2IntOne("IX");
			Roman2IntOne("LVIII");
			Roman2IntOne("MCMXCIV");
		}

		private void Roman2IntOne(string r) {
			Console.WriteLine($"Input: \"{r}\"");

			Dictionary<string, int> table = new Dictionary<string, int>{
				{ "M", 1000 }, {"CM",900},
				{ "D", 500}, {"CD", 400},
				{ "C",100 }, { "XC",90},
				{ "L",50 }, { "XL", 40},
				{ "X",10 }, {"IX",9},
				{ "V",5 }, { "IV",4},
				{ "I", 1 }
			};

			int num = 0, size = r.Length, step;
			string key;
			for(int i = 0; i < size; i += step)
				if(i + 1 < size && table.ContainsKey(key = r.Substring(i, step = 2)))
					num += table[key];
				else if (table.ContainsKey(key = r.Substring(i, step = 1)))
					num += table[key];

			Console.WriteLine($"Output: {num}");
		}
	}
}
