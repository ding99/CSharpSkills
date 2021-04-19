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

		public class Stat {
			public List<int> list;
			public Dictionary<int, int> source;

			public Stat(List<int> list, Dictionary<int, int> source) {
				this.list = list;
				this.source = source;
			}
		}

		private void Action(int n) {
			Console.WriteLine($"Input: n = {n}");

			List<Stat> stats = Layer(new List<Stat> { new Stat(new List<int>(), new Dictionary<int, int> { { 1, n }, { -1, n } }) }, 2 * n);

			int size = stats.Count;
			Console.WriteLine($"============\ncombines size {size}");
			string[] result = new string[size];
			for (int i = 0; i < size; i++) {
				StringBuilder b = new StringBuilder();
				foreach (var a in stats[i].list)
					b.Append(a == 1 ? "(" : ")");
				result[i] = b.ToString();
			}

			StringBuilder builder = new StringBuilder("[");
			for (int i = 0; i < result.Length; i++)
				builder.Append($"\"{result[i]}\"{(i + 1 == result.Length ? "" : ",")}");
			builder.Append("]");
			Console.WriteLine($"Output: {builder}");
		}

		private List<Stat> Layer(List<Stat> prevs, int n) {
			List<Stat> stats = new List<Stat>();
			foreach (Stat s in prevs)
				stats.AddRange(Next(s));
			return n-- == 1 ? stats : Layer(stats, n);
		}

		private List<Stat> Next(Stat prev) {
			List<Stat> stats = new List<Stat>();
			Console.WriteLine("------------");
			DStat(prev, "prev");

			if (prev.list.Count < 1) {
				stats.Add(new Stat(
					new List<int> { 1 },
					new Dictionary<int, int> { { 1, prev.source[1] - 1 }, { -1, prev.source[-1] } }
				));
			} else {
				if (prev.source[1] > 0 && prev.list.Sum() + 1 >= 0) {
					List<int> newL = new List<int>(prev.list);
					newL.Add(1);
					Dictionary<int, int> newD = new Dictionary<int, int> { { 1, prev.source[1] - 1 }, { -1, prev.source[-1] } };
					stats.Add(new Stat(newL, newD));
				}

				if (prev.source[-1] > 0 && prev.list.Sum() - 1 >= 0) {
					List<int> newL = new List<int>(prev.list);
					newL.Add(-1);
					Dictionary<int, int> newD = new Dictionary<int, int> { { 1, prev.source[1]}, {-1, prev.source[-1] - 1 } };
					stats.Add(new Stat(newL, newD));
				}
			}

			foreach (var a in stats)
				DStat(a, "next");

			return stats;
		}

		private void DStat(Stat stat, string name) {
			Console.WriteLine($"{name}{DList(stat.list)}{DDic(stat.source)}");
		}
		private string DList(List<int> list) {
			StringBuilder b = new StringBuilder($" <");
			for (int i = 0; i < list.Count; i++)
				b.Append(list[i]).Append(i + 1 == list.Count ? "" : ",");
			b.Append(">");
			return b.ToString();
		}
		private string DDic(Dictionary<int, int> source) {
			return $" [(+1){source[1]} (-1){source[-1]}]";
		}
	}
}
