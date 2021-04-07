/*
 * Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
Assume the environment does not allow you to store 64-bit integers (signed or unsigned).
*/

using System;

namespace LeetCode.Leet01_10 {
	public class ReverseInt {
		public void Start() {
			testm();
			Action(123);
			Action(-123);
			Action(120);
			Action(0);
			Action(2147483647);
		}

		private void testm() {
			int max = Int32.MaxValue, min = Int32.MinValue;
			Console.WriteLine($"max ({max}), min ({min})");

			string maxs = max.ToString(), mins = min.ToString();
			Console.WriteLine($"maxs ({maxs}), mins ({mins})");

			int re = 0;
			if (Int32.TryParse(maxs, out re)) Console.WriteLine($"parsed maxs ({re})");
			if (Int32.TryParse(mins, out re)) Console.WriteLine($"parsed mins ({re})");

			maxs += "1"; mins += "1";
			Console.WriteLine($"trying parse longer maxs ({Int32.TryParse(maxs, out re)}), mins ({Int32.TryParse(mins, out re)}, re ({re}))");
		}

		private void Action(int x) {
			Console.WriteLine($"Input: x = \"{x}\"");
			bool minus = x < 0;
			char[] cx = Math.Abs(x).ToString().ToCharArray();
			Array.Reverse(cx);
			string nx = new string(cx);
			if (minus) nx = "-" + nx;

			int rev;
			Int32.TryParse(nx, out rev);

			Console.WriteLine($"Ouput: {rev}");
		}
	}
}
