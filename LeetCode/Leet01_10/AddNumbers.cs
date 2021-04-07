/*
You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
You may assume the two numbers do not contain any leading zero, except the number 0 itself.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Leet01_10 {
	public class ListNode {
		public int val;
		public ListNode next;
		public ListNode(int val = 0, ListNode next = null) {
			this.val = val;
			this.next = next;
		}
	}

	public class AddNumbers {
		public void Start() {
			Add(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 });
			Add(new int[] { 0 }, new int[] { 0});
			Add(new int[] { 9,9,9,9,9,9,9}, new int[] { 9,9,9,9 });
		}

		private void Add(int[] a1, int[] a2) {
			AddList(ToList(a1), ToList(a2));
		}

		private void AddList(ListNode l1, ListNode l2) {
			Console.WriteLine($"Input : l1 = {ToShow(l1)}, l2 = {ToShow(l2)}");

			ListNode head = null, curt = new ListNode(), next;
			bool process1 = l1 != null, process2 = l2 != null;
			int val = 0;
			while (process1 || process2 || val > 0) {
				if (process1) {
					val += l1.val;
					if (l1.next == null)
						process1 = false;
					else l1 = l1.next;
				}
				if (process2) {
					val += l2.val;
					if (l2.next == null)
						process2 = false;
					else l2 = l2.next;
				}

				next = new ListNode(val % 10);
				if (head == null) head = next;
				else curt.next = next;
				curt = next;

				val /= 10;
			}

			Console.WriteLine($"Output: {ToShow(head)}");
		}

		private ListNode ToList(int[] a) {
			ListNode head = null;
			if (a.Length > 0) {
				ListNode curt = new ListNode(), next;
				for (int i = 0; i < a.Length; i++) {
					next = new ListNode(a[i]);
					if (head == null) head = next;
					else curt.next = next;
					curt = next;
				}
			}
			return head;
		}

		private string ToShow(ListNode l) {
			StringBuilder builder = new StringBuilder("[");
			List<int> list = new List<int>();
			if (l != null) {
				for (ListNode m = l; m != null; m = m.next)
					list.Add(m.val);
				for (int i = 0; i < list.Count; i++)
					builder.Append(i == 0 ? "" : ",").Append(list[i]);
			}
			builder.Append("]");
			return builder.ToString();
		}
	}
}
