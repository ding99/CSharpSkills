using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Leet01_10 {
	public class ZigZag {
		public void Start() {
			Convert("PAYPALISHIRING", 3);
			Convert("A", 1);
		}

		private void Convert(string s, int numRows) {
			Console.WriteLine($"Input: s = \"{s}\", numRows = {numRows}");
			string converted = s;
			if (numRows > 1) {
				StringBuilder b = new StringBuilder();
				converted = b.ToString();
			}

			Console.WriteLine($"Output: \"{converted}\"");
		}
	}
}
