
/*
-- 3Sum
Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

Notice that the solution set must not contain duplicate triplets. 

-- 3Sum Closest
Given an array nums of n integers and an integer target, find three integers in nums such that the sum is closest to target. Return the sum of the three integers. You may assume that each input would have exactly one solution.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Leet11_20 {
	public class ThreeSum {
		public void SumZero() {
			ActionZero(new int[] { -1,0,1,2,-1,-4});
			ActionZero(new int[0]);
			ActionZero(new int[] { 0 });
		}

		private void ActionZero(int[] nums){
			int n = Display(nums);
			Console.WriteLine();

			List<int[]> sums = new List<int[]>();

			if (n > 2)
				for (int i = 0; i + 2 < n; i++)
					for (int j = i + 1; j + 1 < n; j++)
						for (int k = j + 1; k < n; k++)
							if (nums[i] + nums[j] + nums[k] == 0)
								UpdateList(sums, new int[] { nums[i], nums[j], nums[k] });

			int[][] arraySum = sums.ToArray();
			Console.Write("Output: [");
			for(int i = 0; i < arraySum.Length; i++) {
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
			foreach(int[] a in list)
				if(a.SequenceEqual(element)) return;
			list.Add(element);
		}

		public void SumClosest() {
			ActionClose(new int[] {-1,2,1,-4 }, 1);
		}

		private void ActionClose(int [] nums, int target) {
			int n = Display(nums), result = Int32.MaxValue;
			Console.WriteLine($", target = {target}");
			if (n > 2)
				for (int i = 0; i + 2 < n; i++)
					for (int j = i + 1; j + 1 < n; j++)
						for (int k = j + 1; k < n; k++)
							if (Math.Abs(nums[i] + nums[j] + nums[k] - target) < result)
								result = nums[i] + nums[j] + nums[k];

			Console.WriteLine($"Output: {result}");
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
