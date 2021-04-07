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
			testc();
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

		private void testc() {
			int n = Int32.MaxValue, mid;
			string sn = n.ToString(), ln = "3" + sn.Substring(1);
			Console.WriteLine($"max {n}, string {sn}, lstring {ln}");

			if (Int32.TryParse(sn, out mid)) Console.WriteLine($"sn : {mid}");
			Console.WriteLine($"ln parse : <{Int32.TryParse(ln, out mid)}>");
		}
	}
}
