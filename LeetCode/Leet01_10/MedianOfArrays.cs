using System;
using System.Collections.Generic;
using System.Text;
using Numbers;

namespace LeetCode.Leet01_10 {
	public class MedianOfArrays {
		public void Start() {
			Action(new int[] { 1, 3 }, new int[] { 2 });
		}

		private void Action(int[] a1, int[] a2) {
			Console.WriteLine($"Input: nums1 = {IntArray.ToShow(a1)}, nums2 = {IntArray.ToShow(a2)}");
			List<int> combine = new List<int>(a1);
			combine.AddRange(a2);
			int[] sum = combine.ToArray();
			Array.Sort(sum);
			Console.WriteLine($"combined {IntArray.ToShow(sum)}");

			int size = sum.Length;
			double median = size % 2 == 0 ? (sum[size / 2 - 1] + sum[size / 2]) / 2.0 : sum[size / 2] * 1.0;
			Console.WriteLine("Output: {0:f}", median);
		}


	}
}
