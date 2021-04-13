using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Leet11_20 {
	public class Int2Roman {
		public void Start() {
			Action(3);
		}

		private void Action(int num) {
			Console.WriteLine($"Input: num = {num}");
			string roman = "A";
			Console.WriteLine($"Output: \"{roman}\"");
		}
	}
}
