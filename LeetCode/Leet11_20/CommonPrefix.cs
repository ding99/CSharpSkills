/*
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".
*/

using System;
using System.Linq;

namespace LeetCode.Leet11_20 {
	public class CommonPrefix {
		public void Start() {
			Common(new string[] { "flower", "flow", "flight"});
			Common(new string[] { "dog", "racecar", "car" });
		}

		private void Common(string[] strs) {
			int size = strs.Length;
			string common = string.Empty;

			Console.Write("Input: strs = [");
			for (int i = 0; i < size; i++) Console.Write($"\"{strs[i]}\"{(i + 1 == size ? "]" : ",")}");
			Console.WriteLine();

			if (size == 1)
				common = strs[0];
			else if(size > 1) {
				string[] ordered = strs.ToList().OrderBy(x => x.Length).ToArray();

				if (ordered[0].Length > 0) {
					bool found = false;
					for(int i = 1; i < ordered[0].Length && !found; i++)
						for(int j = 1; j < size; j++)
							if(ordered[0].Substring(0, i) != ordered[j].Substring(0, i)){
								common = ordered[0].Substring(0, i - 1);
								found = true;
								break;
							}
				}
			}

			Console.WriteLine($"Output: \"{common}\"");
		}
	}
}
