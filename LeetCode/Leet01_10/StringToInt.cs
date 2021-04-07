/*
Implement the myAtoi(string s) function, which converts a string to a 32-bit signed integer (similar to C/C++'s atoi function).

The algorithm for myAtoi(string s) is as follows:

 1. Read in and ignore any leading whitespace.
 2. Check if the next character (if not already at the end of the string) is '-' or '+'. Read this character in if it is either. This determines if the final result is negative or positive respectively. Assume the result is positive if neither is present.
Read in next the characters until the next non-digit charcter or the end of the i 3. nput is reached. The rest of the string is ignored.
 4. Convert these digits into an integer (i.e. "123" -> 123, "0032" -> 32). If no digits were read, then the integer is 0. Change the sign as necessary (from step 2).
 5. If the integer is out of the 32-bit signed integer range [-231, 231 - 1], then clamp the integer so that it remains in the range. Specifically, integers less than -231 should be clamped to -231, and integers greater than 231 - 1 should be clamped to 231 - 1.
 6. Return the integer as the final result.

 Note:

 * Only the space character ' ' is considered a whitespace character.
 * Do not ignore any characters other than the leading whitespace or the rest of the string after the digits.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Leet01_10 {
	public class StringToInt {
		public void Start() {
			Convert("42");
			Convert("  -42");
			Convert("4193 with words");
			Convert("words and 987");
			Convert("- 91283472332");
		}

		private void Convert(string s) {
			Console.WriteLine($"--- Input: \"{s}\"");

			while (s.StartsWith(" "))
				s = s.Substring(1);

			bool nega = false;
			if (s.StartsWith("-")) { s = s.Substring(1); nega = true; }
			else if (s.StartsWith("+")) s.Substring(1);

			Console.WriteLine($"(1) Input: \"{s}\"");

			int result = 0, size = s.Length, valid = 0;
			if(size > 0) {
				for (int i = 0; i < size; i++)
					if (s[i] >= 0x30 && s[i] <= 0x39)
						valid++;
					else break;
				s = s.Substring(0, valid);
				if (nega) s = "-" + s;

				if(!Int32.TryParse(s, out result))
					result = nega ? Int32.MinValue : Int32.MaxValue;
			}

			Console.WriteLine($"(2) Input: \"{s}\", result ({result})");
		}
	}
}
