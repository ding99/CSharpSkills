/* Given a string s, find the length of the longest substring without repeating characters. */


using System;

namespace LeetCode.Leet01_10 {
	public class LongestSub {
		public void Start() {
			Search("abcabcbb");
			Search("bbbb");
			Search("pwwkew");
			Search("");
			Search("c");
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
