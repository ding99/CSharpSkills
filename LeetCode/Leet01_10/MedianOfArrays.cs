using Numbers;
using System;
using System.Collections.Generic;

namespace LeetCode.Leet01_10 {
	public class MedianOfArrays {
		public void Start() {
			Action(new int[] { 1, 3 }, new int[] { 2 });
			Action(new int[] { 1, 2 }, new int[] { 3,4 });
			Action(new int[] { 0, 0 }, new int[] { 0,0 });
			Action(new int[0], new int[] {1 });
			Action(new int[] { 2}, new int[0] );
		}

		private void Action(int[] a1, int[] a2) {
			Console.WriteLine($"Input: nums1 = {IntArray.ToShow(a1)}, nums2 = {IntArray.ToShow(a2)}");
			List<int> combine = new List<int>(a1);
			combine.AddRange(a2);
			int[] sum = combine.ToArray();
			Array.Sort(sum);

			int size = sum.Length;
			double median = size % 2 == 0 ? (sum[size / 2 - 1] + sum[size / 2]) / 2.0 : sum[size / 2];
			Console.WriteLine("Output: {0:f}", median);
		}


	}
}
