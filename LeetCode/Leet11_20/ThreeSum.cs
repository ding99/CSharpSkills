
/*
-- 3Sum
Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

Notice that the solution set must not contain duplicate triplets. 

-- 3Sum Closer
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Leet11_20 {
	public class ThreeSum {
		public void SumZero() {
			ActionZero(new int[] { -1,0,1,2,-1,-4});
		}

		private void ActionZero(int[] nums){
			int n = nums.Length;
			Console.Write("Input: nums = [");
			for (int i = 0; i < n; i++) Console.Write($"{nums[i]}{(i + 1 == n ? "]":",")}");
			Console.WriteLine();

			List<int[]> sums = new List<int[]>();
			sums.Add(new int[] { 1,2,3});
			sums.Add(new int[] { 4,5,6});
			int[][] arraySum = sums.ToArray();
			Console.Write("Output: [");
			for(int i = 0; i < arraySum.Length; i++) {
				Console.Write("[");
				for (int j = 0; j < arraySum[i].Length; j++)
					Console.Write($"{arraySum[i][j]}{(j + 1 == arraySum[i].Length ? "]" : ",")}");
				Console.Write(i + 1 == arraySum.Length ? "]" : ",");
			}
			Console.WriteLine();

		}
	}
}
