using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Leet21_30 {
	public class GenerateParentheses {
		public void Start() {
			Action(1);
		}

		private void Action(int n) {
			Console.WriteLine($"Input: n = {n}");

			Dictionary<int, int> master = new Dictionary<int, int> { { 1, n }, { -1, n } };
			List<List<int>> combines = NextList(new List<List<int>>(), master);

			int size = combines.Count;
			string[] result = new string[size];
			for(int i = 0; i < size; i++) {
				StringBuilder b = new StringBuilder();
				foreach (int a in combines[i])
					b.Append(a == 1 ? "(" : ")");
				result[i] = b.ToString();
			}

			StringBuilder builder = new StringBuilder("[");
			for (int i = 0; i < result.Length; i++)
				builder.Append($"\"{result[i]}\"{(i + 1 == result.Length ? "" : ",")}");
			builder.Append("]");
			Console.WriteLine($"Output: {builder}");
		}

		private List<List<int>> NextList(List<List<int>> prev, Dictionary<int, int> master) {
			List<List<int>> next = new List<List<int>>();
			if (prev.Count < 1) {
				next.Add(new List<int> { 1 });
				master[1]--;
			} else foreach(List<int> t in prev) {
				if(master[1] > 0 && t.Sum() + 1 > 0) {
					List<int> newP = new List<int>(t);
					newP.Add(1);
					next.Add(newP);
					master[1]--;
				}
				if(master[-1] > 0 && t.Sum() -1 >= 0) {
					List<int> newN = new List<int>(t);
					newN.Add(-1);
					next.Add(newN);
					master[-1]--;
				}
			}
			if(master[1] + master[-1] == 0)
				return next;
			return NextList(next, master);
		}
	}
}
