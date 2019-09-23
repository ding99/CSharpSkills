using System;
using System.IO;
using System.Collections.Generic;

namespace E11_LargestProduct {
	class MaxPath2 {
		private int size;
		private List<int[]> triangle;

		public MaxPath2() {
			size = 100;
			string file = "..\\..\\p067_triangle.txt";
			string[] input = new string[size];

			using(StreamReader sr = new StreamReader(file)) {
				for(int i = 0; i < size; i++)
					input[i] = sr.ReadLine();
				sr.Close();
				sr.Dispose();
			}

			triangle = new List<int[]>();

			for(int k = size - 1; k >= 0; k--) {
				string[] row = input[k].Split(' ');
				int[] data = new int[row.Length];
				for(int i = 0; i < data.Length; i++)
					data[i] = Int32.Parse(row[i]);
				triangle.Add(data);
			}
		}

		public void Start() {

			//foreach(var a in triangle) {
			//	foreach(var b in a)
			//		Console.Write(b + " ");
			//	Console.WriteLine();
			//}

			List<int> orig = new List<int>(), next;
			orig.AddRange(triangle[0]);
			int length;

			for(int i = 1; i < size; i++) {
				next = new List<int>();
				length = triangle[i].Length;
				for(int j = 0; j < length; j++)
					next.Add((orig[j] > orig[j + 1] ? orig[j] : orig[j + 1]) + triangle[i][j]);
				orig = next;
			}

			Console.WriteLine(orig[0]); //7273
		}
	}
}
