using System;

/***
 one two three four five six seven eight nine ten
 eleven twelve thirteen fourteen fifteen sixteen seventeen eighteen nineteen
 Ten twenty thirty forty fifty sixty seventy eighty ninety
 one hundred (and), one thouand
***/

namespace Problems11_20
{
	public class NumberLetterCounts
	{
		private int count;

		private int[] first19, tens;
		private int hundred, thousand;

		public NumberLetterCounts()
		{
			count = 0;
			first19 = new int[] { 3, 3, 5, 4, 4, 3, 5, 5, 4, 3, 6, 6, 8, 8, 7, 7, 9, 8, 8 };
			tens = new int[] { 3, 6, 6, 5, 5, 5, 7, 6, 6 };
			hundred = 7;
			thousand = 8;
		}

		//correct: 21124
		public void Start()
		{
			//1-19 (19)
			for (int i = 0; i < 19; i++)
				count += first19[i];

			//20-99 (80, -99)
			for (int j = 1; j < 9; j++)
			{
				count += tens[j] * 10;
				for (int i = 0; i < 9; i++)
					count += first19[i];
			}

			//?01-?99 (-990)
			count *= 10;

			int hundreds = 0;
			//hundreds
			for (int i = 0; i < 9; i++)
				hundreds += first19[i] + hundred + 3;
			hundreds *= 99;
			for (int i = 0; i < 9; i++)
				hundreds += first19[i] + hundred;

			count += hundreds;

			//thouand
			count += first19[0] + thousand;

			Console.WriteLine(count);
		}
	}
}
