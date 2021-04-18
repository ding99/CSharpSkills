using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Leet21_30 {
	public class GenerateParentheses {
		public void Start() {
			//Action(1);
			Action(2);
			//Action(3);
		}

		private void Action(int n) {
			Console.WriteLine($"Input: n = {n}");

			Dictionary<int, int> master = new Dictionary<int, int> { { 1, n }, { -1, n } };
			List<List<int>> combines = NextList(new List<List<int>>(), master);

			int size = combines.Count;
			Console.WriteLine($"combines size {size}");
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
			Console.WriteLine("------------");
			Console.WriteLine($"[] {master[1]} / {master[-1]} / {prev.Count} -> {next.Count}");
			DLs(prev, "prev");
			if (prev.Count < 1) {
				next.Add(new List<int> { 1 });
				master[1]--;
			} else
				foreach (List<int> t in prev) {
					Console.WriteLine($"<> {master[1]} / {master[-1]} / {prev.Count} -> {next.Count}");
					if (master[1] > 0 && t.Sum() + 1 >= 0) {
						List<int> newP = new List<int>(t);
						newP.Add(1);
						next.Add(newP);
						master[1]--;
						DLs(next, "mid+1");
					}

					if (master[-1] > 0 && t.Sum() - 1 >= 0) {
						List<int> newN = new List<int>(t);
						newN.Add(-1);
						next.Add(newN);
						master[-1]--;
						DLs(next, "mid-1");
					}
				}
			//TODO
			Console.WriteLine($"   {master[1]} / {master[-1]} / {prev.Count} -> {next.Count}");
			DLs(next, "last");

			if (master[1] + master[-1] == 0)
				return next;
			return NextList(next, master);  //TODO
		}

		private void DLs(List<List<int>> list, string name) {
			StringBuilder b = new StringBuilder($"--{name}: ({list.Count})");
			foreach (var a in list)
				b.Append($"{DL(a)}");
			Console.WriteLine(b);
		}
		private string DL(List<int> list) {
			StringBuilder b = new StringBuilder($" <");
			for (int i = 0; i < list.Count; i++)
				b.Append(list[i]).Append(i + 1 == list.Count ? "" : ",");
			b.Append(">");
			return b.ToString();
		}
	}
}
