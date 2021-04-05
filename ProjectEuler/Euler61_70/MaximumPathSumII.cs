using System;
using System.Collections.Generic;
using System.IO;

namespace ProjectEuler.Euler61_70
{
	public class MaximumPathSumII : SourceSet
	{
		private const string FILE = "p067_triangle.dat";
		private const int SIZE = 100;

		private List<int[]> triangle;

		public MaximumPathSumII()
		{
			string file = Paths.Paths.DataPath(dataPath, FILE);
			string[] input = new string[SIZE];

			using (StreamReader sr = new StreamReader(file))
			{
				for (int i = 0; i < SIZE; i++)
					input[i] = sr.ReadLine();
				sr.Close();
				sr.Dispose();
			}

			triangle = new List<int[]>();

			for (int k = SIZE - 1; k >= 0; k--)
			{
				string[] row = input[k].Split(' ');
				int[] data = new int[row.Length];
				for (int i = 0; i < data.Length; i++)
					data[i] = Int32.Parse(row[i]);
				triangle.Add(data);
			}
		}

		public void Start()
		{
			List<int> orig = new List<int>(), next;
			orig.AddRange(triangle[0]);
			int length;

			for (int i = 1; i < SIZE; i++)
			{
				next = new List<int>();
				length = triangle[i].Length;
				for (int j = 0; j < length; j++)
					next.Add((orig[j] > orig[j + 1] ? orig[j] : orig[j + 1]) + triangle[i][j]);
				orig = next;
			}

			Console.WriteLine(orig[0]); //7273
		}
	}
}
