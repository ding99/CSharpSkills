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

			Dictionary<char, char[]> letters = new Dictionary<char, char[]> {
				{'2', new char[]{ 'a','b','c'} },
				{'3', new char[]{ 'd','e','f'} },
				{'4', new char[]{ 'g','h','i'} },
				{'5', new char[]{ 'j','k','l'} },
				{'6', new char[]{ 'm','n','o'} },
				{'7', new char[]{ 'p','q','r','s'} },
				{'8', new char[]{ 't','u','v'} },
				{'9', new char[]{ 'w','x','y','z'} }
			};

			List<string> combination = new List<string>();

			int size = digits.Length;
			if (size > 0)
				for (int i = 0; i < size; i++)
					combination = OneLetter(combination, letters[digits[i]]);

			Console.Write("Output: [");
			int n = combination.Count;
			for (int i = 0; i < n; i++)
				Console.Write($"\"{combination[i]}\"{(i + 1 == n ? "" : ",")}");
			Console.WriteLine("]");
		}

		private List<string> OneLetter(List<string> prev, char[] chars) {
			List<string> next = new List<string>();
			if (prev.Count < 1)
				foreach (char c in chars)
					next.Add(string.Empty + c);
			else foreach(string s in prev)
				foreach(char c in chars)
					next.Add(s + c);
			return next;
		}
	}
}
