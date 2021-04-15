/*
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
*/

using System;
using System.Collections.Generic;

namespace LeetCode.Leet11_20 {
	public class ValidParentheses {
		public void Start() {
			Action("()");
			Action("()[]{}");
			Action("(]");
			Action("[)");
			Action("{[]}");
			Action("[()}");
		}

		private void Action(string s) {
			Console.WriteLine($"Input: s = \"{s}\"");
			bool result = true;

			Dictionary<char, char> table = new Dictionary<char, char> {
				{')','(' },
				{']','[' },
				{'}','{' },
			};

			int size = s.Length;
			if (size > 0) {
				Stack<char> stack = new Stack<char>();

				foreach (char c in s)
					if (table.ContainsValue(c))
						stack.Push(c);
					else if (table.ContainsKey(c) && (stack.Count < 1 || table[c] != stack.Pop())) {
						result = false;
						break;
					}
				}

			Console.WriteLine($"Output: {result}");
		}
	}
}
