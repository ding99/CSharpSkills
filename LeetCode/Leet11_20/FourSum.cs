using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Leet11_20 {
	public class FourSum {
		public void Start() {
			Action(new int[] { 1,0,-1,0,-2,2}, 0);
		}

		private void Action(int[] nums, int target) {
			int n = Display(nums);
			Console.WriteLine($", target = {target}");

			List<int[]> sums = new List<int[]>();

			if (n > 2)
				for (int i = 0; i + 2 < n; i++)
					for (int j = i + 1; j + 1 < n; j++)
						for (int k = j + 1; k < n; k++)
							if (nums[i] + nums[j] + nums[k] == 0)
								UpdateList(sums, new int[] { nums[i], nums[j], nums[k] });

			int[][] arraySum = sums.ToArray();
			Console.Write("Output: [");
			for (int i = 0; i < arraySum.Length; i++) {
				Console.Write("[");
				for (int j = 0; j < arraySum[i].Length; j++)
					Console.Write($"{arraySum[i][j]}{(j + 1 == arraySum[i].Length ? "" : ",")}");
				Console.Write("]");
				Console.Write(i + 1 == arraySum.Length ? "" : ",");
			}
			Console.WriteLine("]");
		}

		private void UpdateList(List<int[]> list, int[] element) {
			Array.Sort(element);
			foreach (int[] a in list)
				if (a.SequenceEqual(element)) return;
			list.Add(element);
		}

		private int Display(int[] nums) {
			int n = nums.Length;
			Console.Write("Input: nums = [");
			for (int i = 0; i < n; i++) Console.Write($"{nums[i]}{(i + 1 == n ? "" : ",")}");
			Console.Write("]");
			return n;
		}
	}
}
