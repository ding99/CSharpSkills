using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Leet21_30 {
	public class GenerateParentheses {
		public void Start() {
			Action(3);
		}

		private void Action(int n) {
			Console.WriteLine($"Input: n = {n}");
			string[] result = new string[] { "()()", "[][]" };

			StringBuilder b = new StringBuilder("[");
			for (int i = 0; i < result.Length; i++)
				b.Append($"{result[i]}{(i + 1 == result.Length ? "" : ",")}");
			b.Append("]");
			Console.Write($"Output: {b}");
		}
	}
}
