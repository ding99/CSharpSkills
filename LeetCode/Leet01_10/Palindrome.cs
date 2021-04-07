/* 
Given an integer x, return true if x is palindrome integer.
An integer is a palindrome when it reads the same backward as forward. For example, 121 is palindrome while 123 is not.
*/

using System;
using Utilities.Characters;

namespace LeetCode.Leet01_10 {
	public class Palindrome {
		public void Start() {
			Action(121);
			Action(-121);
			Action(10);
			Action(-101);
		}

		private void Action(int x) {
			Console.WriteLine($"Input: x = {x}");
			Console.WriteLine($"Output: {ManipulateStrings.IsPalindromic(x.ToString()).ToString().ToLower()}");
		}
	}
}
