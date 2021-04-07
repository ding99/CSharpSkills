/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.
*/

using System;

namespace LeetCode.Leet01_10 {
	public class TwoSum {
		public void Start() {
			Action(new int[] { 2, 7, 11, 15 },9);
			Action(new int[] { 2, 3, 4 }, 6);
			Action(new int[] { 3, 3, 1, 1 }, 6);
		}

		private void Action(int[] nums, int target) {
			Console.Write($"({target})");
			for (int i = 0; i < nums.Length; i++)
				Console.Write($"{(i == 0 ? " [" : ",")}{nums[i]}");
			Console.WriteLine("]");
			Search(nums, target);
		}

		private void Search(int[] nums, int target) {
			int size = nums.Length;
			for(int i = 0; i + 1 < size; i++)
				for(int j = i + 1; j < size; j++)
					if(nums[i] + nums[j] == target) {
						Console.WriteLine($"[{i},{j}]");
						return;
					}
			Console.WriteLine("[]");
		}
	}
}
