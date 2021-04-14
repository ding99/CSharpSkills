using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Leet11_20 {
	public class FourSum {
		public void Start() {
			Action(new int[] { 1,0,-1,0,-2,2}, 0);
			Action(new int[] { 2,2,2, 2, 2 }, 8);
		}

		private void Action(int[] nums, int target) {
			int n = Display(nums);
			Console.WriteLine($", target = {target}");

			List<int[]> sums = new List<int[]>();

			if (n > 3)
				for (int i = 0; i + 3 < n; i++)
					for (int j = i + 1; j + 2 < n; j++)
						for (int k = j + 1; k + 1< n; k++)
							for(int l = k + 1; l < n; l++)
							if (nums[i] + nums[j] + nums[k] + nums[l] == target)
								UpdateList(sums, new int[] { nums[i], nums[j], nums[k], nums[l] });

			Console.Write("Output: [");
			for (int i = 0; i < sums.Count; i++) {
				Console.Write("[");
				for (int j = 0; j < sums[i].Length; j++)
					Console.Write($"{sums[i][j]}{(j + 1 == sums[i].Length ? "" : ",")}");
				Console.Write("]");
				Console.Write(i + 1 == sums.Count ? "" : ",");
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
