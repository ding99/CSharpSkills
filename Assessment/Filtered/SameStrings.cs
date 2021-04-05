using System;
using System.Linq;

namespace Assessment.Filtered {
	public class SameStrings {
		public void Start() {
			Console.WriteLine("-- Two same strings");
			Action("helloWorld", "oworldHell");
			Action("The same string", "stringemas  heT");
			Action("abcd", "abcf");
		}

		private void Action(string a, string b) {
			Console.WriteLine($"[{a}]");
			Console.WriteLine($"[{b}]");
			Console.WriteLine($"-> {Compare(a,b)}");
		}

		private bool Compare(string a, string b) {
			var lista = a.ToUpper().ToCharArray().ToList().OrderBy(x => x);
			var listb = b.ToUpper().ToCharArray().ToList().OrderBy(x => x);
			return Enumerable.SequenceEqual(lista, listb);
		}
	}
}
