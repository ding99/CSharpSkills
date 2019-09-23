using System;
using System.IO;

namespace E51_PrimeDigit.Source {
	class Decryption {

		int[] table;
		int size;

		public Decryption() {
			string line, file = "..\\..\\p059_cipher.txt";
			using(StreamReader sr = new StreamReader(file)) {
				line = sr.ReadToEnd();
				sr.Close();
				sr.Dispose();
			}

			string[] s = line.Split(',');
			size = s.Length;

			table = new int[size];
			for(int i = 0; i < size; i++)
				table[i] = Int32.Parse(s[i]);
		}

		private bool Success(int[] data) {
			int n = 0;

			//the
			for(int i = 0; i + 4 < size; i++)
				if((data[i] == 0x74 || data[i] == 0x54)
					&& (data[i + 1] == 0x68 || data[i + 1] == 0x48)
					&& (data[i + 2] == 0x65 || data[i + 2] == 0x45)
					&& data[i + 3] == 0x20) {
					n++;
					break;
				}

			//of
			for(int i = 0; i + 3 < size; i++)
				if((data[i] == 0x6f || data[i] == 0x4f)
					&& (data[i + 1] == 0x66 || data[i + 1] == 0x46)
					&& data[i + 2] == 0x20) {
					n++;
					break;
				}

			return n == 2;
		}

		private int sum(int[] data) {
			foreach(var a in data)
				Console.Write((char)a);
			Console.WriteLine();

			int n = 0;
			foreach(var a in data)
				n += a;
			return n;
		}

		public void Start() {
			int[] data = new int[size], pw = new int[3];

			for(int i = 0x61; i < 0x7b; i++)
				for(int j = 0x61; j < 0x7b; j++)
					for(int k = 0x61; k < 0x7b; k++) {
						pw[0] = i;
						pw[1] = j;
						pw[2] = k;
						for(int l = 0; l < size; l++)
							data[l] = table[l] ^ pw[l % 3];
						if(Success(data)) {
							Console.WriteLine(sum(data)); //129448
							return;
						}
					}

		}

	}
}
