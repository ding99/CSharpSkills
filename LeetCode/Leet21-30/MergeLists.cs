/*
Merge two sorted linked lists and return it as a sorted list. The list should be made by splicing together the nodes of the first two lists.
*/

using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace LeetCode.Leet21_30 {
	public class MergeLists {
		public void Start2List() {
			Action2List(new int[] { 1, 2, 4, }, new int[] { 1, 3, 4 });
			Action2List(new int[] { }, new int[] { });
			Action2List(new int[] { }, new int[] { 0 });
		}

		private void Action2List(int[] l1, int[] l2) {
			Console.WriteLine($"Input:{Display(l1, "l1")},{Display(l2, "l2")}");

			SortedList<int, int> s1 = CreateList(new List<int>(l1));
			SortedList<int, int> s2 = CreateList(new List<int>(l2));

			List<int> mergedList = s1.Values.ToList();
			mergedList.AddRange(s2.Values.ToList());
			mergedList.Sort();
			SortedList<int, int> mergedSort = CreateList(mergedList);

			int[] merged = mergedSort.Values.ToArray();
			Console.WriteLine($"Output: {Display(merged, string.Empty)}");
		}

		public void StartKList() {
			ActionKList(new int[][] { new int[] { 1, 2, 4, }, new int[] { 1, 3, 4 } });
			//ActionKList(new int[] { }, new int[] { });
			//ActionKList(new int[] { }, new int[] { 0 });
		}

		private void ActionKList(int[][] list) {
			int size = list.Length;
			StringBuilder b = new StringBuilder($"Input: [");
			for(int i = 0; i < size; i++)
				b.Append($"{Display(list[i], string.Empty)}{(i + 1 == size ? "" : ",")}");
			b.Append("]");
			Console.WriteLine(b);

			List<SortedList<int, int>> sorts = new List<SortedList<int, int>>();
			foreach (int[] l in list)
				sorts.Add(CreateList(new List<int>(l)));

			//SortedList<int, int> s1 = CreateList(new List<int>(list[0]));
			//SortedList<int, int> s2 = CreateList(new List<int>(list[1]));

			List<int> mergedList = new List<int>();
			foreach (var a in sorts)
				mergedList.AddRange(a.Values.ToList());

			//List<int> mergedList = s1.Values.ToList();
			//mergedList.AddRange(s2.Values.ToList());
			mergedList.Sort();
			SortedList<int, int> mergedSort = CreateList(mergedList);

			int[] merged = mergedSort.Values.ToArray();
			Console.WriteLine($"Output:{Display(merged, string.Empty)}");
		}

		private SortedList<int, int> CreateList(List<int> list) {
			SortedList<int, int>  sorted = new SortedList<int, int>();
			for (int i = 0; i < list.Count; i++)
				sorted.Add(i + 1, list[i]);
			return sorted;
		}

		private string Display(int[] nums, string name) {
			StringBuilder b = new StringBuilder();

			if(!string.IsNullOrEmpty(name))
				b.Append($" {name} = ");
			b.Append("[");

			int n = nums.Length;
			if(n > 0)
				for (int i = 0; i < n; i++) b.Append($"{nums[i]}{(i + 1 == n ? "" : ",")}");
			b.Append("]");

			return b.ToString();
		}

	}
}
