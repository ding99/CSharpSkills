using System;
using System.IO;
using System.Numerics;
using System.Collections.Generic;

namespace E21_Amicable {
	class NameScore {
		private List<string> names;

		public NameScore() {
			string file = "..\\..\\p022_names.txt";
			string row;

			using(StreamReader sr = new StreamReader(file)) {
				row = sr.ReadToEnd();
				sr.Close();
				sr.Dispose();
			}

			names = new List<string>();
			foreach(var a in row.Split(','))
				names.Add(a.Trim(new char[] { '"' }).ToUpper());
		}

		private int Score(string name) {
			char[] chars = name.ToCharArray();
			int score = 0;
			foreach(char c in chars)
				score += c - 0x40;
			return score;
		}

		public void Start() {
			BigInteger scores = new BigInteger(0);
			int size = names.Count;

			names.Sort();

			for(int i = 0; i < size; i++)
				scores += Score(names[i]) * (i + 1);

			Console.WriteLine(scores); //871198282
		}
	}
}
