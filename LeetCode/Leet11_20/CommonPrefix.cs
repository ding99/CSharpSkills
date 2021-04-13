using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Leet11_20 {
	public class CommonPrefix {
		public void Start() {
			Common(new string[] { "flower","flow", "flight", "", "ab"});
			Common(new string[] { "flower", "flow", "flight", "fab" });
		}

		private void Common(string[] strs) {
			int size = strs.Length;
			Console.Write("Input: strs = [");
			for (int i = 0; i < size; i++) Console.Write($"\"{strs[i]}\"({(i + 1 == size ? "]" : ",")})");
			Console.WriteLine();
			string common = string.Empty;

			if (size == 1)
				common = strs[0];
			else if(size > 1) {
				string[] ordered = strs.ToList().OrderBy(x => x.Length).ToArray();
				foreach (var a in ordered)
					Console.Write($" [{a}]({a.Length})");
				Console.WriteLine();

				int i0 = 0;
				for (int i = 0; i < size; i++)
					if (ordered[i].Length > 0) {
						i0 = i; break;
					}

				Console.WriteLine($"first non-zero length term [{i0}]");

				if (i0 + 1 == size)
					common = ordered[i0];
				else if (i0 == 0) {
					int n = ordered[0].Length;
					bool found = false;
					Console.WriteLine($"n ({n}), found ({found})");
					for(int i = 1; i < n && !found; i++)
						for(int j = i0 + 1; j < size; j++) {
							if(ordered[i0].Substring(0, i) != ordered[j].Substring(0, i)){
								common = ordered[i0].Substring(0, i - 1);
								found = true;
								break;
							}
						}
				}
			}

			Console.WriteLine($"Output: \"{common}\"");
		}
	}
}
