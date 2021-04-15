/*
Merge two sorted linked lists and return it as a sorted list. The list should be made by splicing together the nodes of the first two lists.
*/

using System;
using System.Text;
using System.Linq;

namespace LeetCode.Leet21_30 {
	public class MergeLists {
		public void Start() {
			Action(new int[] { 1, 2, 4, }, new int[] { 1, 3, 4 });
		}

		private void Action(int[] l1, int[] l2) {
			Console.WriteLine($"Input:{Display(l1, "l1")}, {Display(l2, "l2")}");

			int[] merged = new int[0];
			Console.WriteLine($"Output:{Display(merged, string.Empty)}");
		}

		private string Display(int[] nums, string name) {
			StringBuilder b = new StringBuilder();
			if(!string.IsNullOrEmpty(name))
				b.Append($" {name} =");
			b.Append(" [");

			int n = nums.Length;
			if(n > 0)
				for (int i = 0; i < n; i++) b.Append($"{nums[i]}{(i + 1 == n ? "" : ",")}");
			b.Append("]");

			return b.ToString();
		}

	}
}
