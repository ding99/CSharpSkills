/*
 * Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
Assume the environment does not allow you to store 64-bit integers (signed or unsigned).
*/

using System;

namespace LeetCode.Leet01_10 {
	public class ReverseInt {
		public void Start() {
			Action(123);
			Action(-123);
			Action(120);
			Action(0);
			Action(2147483647);
		}

		private void Action(int x) {
			Console.WriteLine($"Input: x = \"{x}\"");
			bool minus = x < 0;
			char[] cx = Math.Abs(x).ToString().ToCharArray();
			Array.Reverse(cx);
			string nx = new string(cx);

			int rev = 0;
			if (Int32.TryParse(nx, out rev))
				rev *= minus ? -1 : 1;

			Console.WriteLine($"Ouput: {rev}");
		}
	}
}
