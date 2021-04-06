﻿using System;

namespace LeetCode.Leet01_10 {
	public class ReverseInt {
		public void Start() {
			Action(123);
			Action(-123);
			Action(120);
			Action(0);
		}

		private void Action(int x) {
			Console.WriteLine($"Input: x = \"{x}\"");
			bool minus = x < 0;
			char[] cx = Math.Abs(x).ToString().ToCharArray();
			Array.Reverse(cx);
			string nx = new string(cx);

			long rev;
			if (long.TryParse(nx, out rev))
				rev *= minus ? -1 : 1;
			int last = rev > Int32.MaxValue || rev < Int32.MinValue ? 0 : (int)rev;

			Console.WriteLine($"Ouput: {last}");
		}
	}
}
