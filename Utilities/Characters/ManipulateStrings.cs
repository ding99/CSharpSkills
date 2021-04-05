namespace Utilities.Characters {
	public class ManipulateStrings {
		public static bool IsPalindromic(string s) {
			if (string.IsNullOrEmpty(s)) return true;

			int size = s.Length;
			for (int i = 0; i < size / 2; i++)
				if (s[i] != s[size - 1 - i])
					return false;

			return true;
		}
	}
}
