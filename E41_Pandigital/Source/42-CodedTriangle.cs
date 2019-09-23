using System;
using System.IO;
using System.Collections.Generic;

namespace E41_Pandigital.Source {
	class CodedTriangle {

		private List<string> words;
		private List<int> trianlges;

		public CodedTriangle() {
			string file = "..\\..\\p042_words.txt";

			words = new List<string>();
			using(StreamReader sr = new StreamReader(file)) {
				foreach(var a in sr.ReadToEnd().Split(','))
					words.Add(a.Trim(new char[] { '"' }).ToUpper());
				sr.Close();
				sr.Dispose();
			}

			int size = 0, now;
			foreach(var a in words)
				if((now = a.Length) > size)
					size = now;

			trianlges = new List<int>();
			now = 1;
			int n = 0;
			while(now <= 26 * size)
				trianlges.Add(now = ++n * (n + 1) / 2);
		}

		private int value(string word) {
			int v = 0;
			foreach(var c in word.ToCharArray())
				v += c - 0x40;
			return v;
		}

		public void Start() {
			int n = 0;
			foreach(var s in words)
				if(trianlges.Contains(value(s)))
					n++;

			Console.WriteLine(n); //162
		}
	}
}
