using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Leet11_20 {
	public class RemoveNode {
		public void Start() {
			Action(new int[] { 1, 2, 3, 4, 5}, 2);
		}

		private void Action(int[] array, int n) {
			int size = Display(array, "nums");
			Console.WriteLine($", n = {n}");

			int[] result = new int[] { 1, 2 };
			Display(result, string.Empty);
			Console.WriteLine();
		}

		private int Display(int[] nums, string name) {
			int n = nums.Length;
			Console.Write($"{(string.IsNullOrEmpty(name) ? "Out" : "In")}put: {name}{(string.IsNullOrEmpty(name) ? "" : " = ")}[");
			for (int i = 0; i < n; i++) Console.Write($"{nums[i]}{(i + 1 == n ? "" : ",")}");
			Console.Write("]");
			return n;
		}
	}
}
