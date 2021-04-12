/*
Given an input string (s) and a pattern (p), implement regular expression matching with support for '.' and '*' where: 

'.' Matches any single character.​​​​
'*' Matches zero or more of the preceding element.
The matching should cover the entire input string (not partial).
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetCode.Leet01_10 {
	public class RegularExpression {
		public void Start() {
			Matching("aa", "a");
			Matching("aa", "a*");
		}

		private void Matching(string s, string p) {
			Console.WriteLine($"Input: s = \"{s}\", p = \"{p}\"");

			Match m = Regex.Match(s, p.Replace(".", "\\w"));
			Console.WriteLine($"matched value [{m.Value}]");
			Console.WriteLine($"Output: {m.Value == s}");
		}

		private void Matchings(string s, string p) {
			Regex r = new Regex(p.Replace(".", "\\w"));
			MatchCollection m = r.Matches(s);
			Console.WriteLine($"Input: s = \"{s}\", p = \"{p}\"");
			Console.Write($"m count({m.Count})");
			for (int i = 0; i < m.Count; i++)
				Console.Write($" <{m[i].Index}>-<{m[i].Value}>");
			Console.WriteLine();
			Console.WriteLine($"Output: {m.Count == 1 && m[0].Value == s}");
		}
	}
}
