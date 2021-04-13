/*
Given an input string (s) and a pattern (p), implement regular expression matching with support for '.' and '*' where: 

'.' Matches any single character.​​​​
'*' Matches zero or more of the preceding element.
The matching should cover the entire input string (not partial).
*/

using System;
using System.Text.RegularExpressions;

namespace LeetCode.Leet01_10 {
	public class RegularExpression {
		public void Start() {
			Matching("aa", "a");
			Matching("aa", "a*");
			Matching("ab", ".*");
			Matching("aab", "c*a*b");
			Matching("mississippi", "mis*is*p*.");
		}

		private void Matching(string s, string p) {
			Console.WriteLine($"Input: s = \"{s}\", p = \"{p}\"");

			Match m = Regex.Match(s, p.Replace(".", "\\w"));
			Console.WriteLine($"Output: {m.Value == s}");
		}
	}
}
