using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Leet11_20 {
	public class CommonPrefix {
		public void Start() {
			Common(new string[] { "flower","flow", "flight"});
		}

		private void Common(string[] strs) {
			int size = strs.Length;
			Console.Write("Input: strs = [");
			for (int i = 0; i < size; i++) Console.Write($"\"{strs[i]}\"({(i + 1 == size ? "]" : ",")})");
			Console.WriteLine();
			string common = string.Empty;
			Console.WriteLine($"Output: \"{common}\"");
		}
	}
}
