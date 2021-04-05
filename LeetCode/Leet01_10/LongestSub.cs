using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Leet01_10 {
	public class LongestSub {
		public void Start() {
			testing();
			Search("abcabcbb");
			Search("bbbb");
			Search("pwwkew");
			Search("");
		}

		private void testing() {
			string s = "abcdefg";
			Console.WriteLine(s);
			Console.WriteLine($"{s.IndexOf("f")}, {s.IndexOf("f", 1)}, {s.IndexOf("f", 3)}");
		}

		private void Search(string s) {
			string sub = string.Empty;
			int size = 0, length = s.Length, next;

			if(length == 1) { size = 1; sub = s; }

			for (int i = 0; i + 1 < length; i++) {
				if (i + size > length)
					break;
				if((next = s.IndexOf(s[i], i + 1)) > i + size) {
					size = next - i;
					sub = s.Substring(i, size);
				}
			}

			Console.WriteLine($"[{s}] : [{sub}] ({size})");
		}
	}
}
