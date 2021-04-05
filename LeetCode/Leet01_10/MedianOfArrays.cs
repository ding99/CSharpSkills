using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Leet01_10 {
	public class MedianOfArrays {
		public void Start() {
			Action(new int[] { 1, 3 }, new int[] { 2 });
		}

		private void Action(int[] a1, int[] a2) {
			Console.WriteLine($"a1 {a1.Length}, a2 {a2.Length}");
			List<int> combine = new List<int>(a1);
			combine.AddRange(a2);
			int[] sum = combine.ToArray();
			Array.Sort(sum);
			Console.Write($"({sum.Length})");
			foreach (var a in sum)
				Console.Write($" {a}");
			Console.WriteLine();
		}
	}
}
