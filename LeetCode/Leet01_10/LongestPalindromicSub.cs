using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Characters;

namespace LeetCode.Leet01_10 {
	public class LongestPalindromicSub {
		public void Start() {
			Action("babad");
			Action(string.Empty);
		}

		private void Action(string s) {
			Console.WriteLine($"Input: s = \"{s}\"");
			string p = s;
			int size = s.Length, max = p.Length;
			Console.WriteLine($"size ({size})");

			if (size > 1) {
				p = s.Substring(0, 1);
				max = 1;
				for (int i = 0; i + max < size; i++)
					for (int j = max + 1; j + i <= size; j++)
						if(ManipulateStrings.IsPalindromic(s.Substring(i, j)) && j > max)
							p = s.Substring(i, max = j);
			}

			Console.WriteLine($"Output: \"{p}\"");
		}
	}
}
