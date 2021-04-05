using System.Text;

namespace Numbers {
	public class IntArray {
		public static string ToShow(int[] a) {
			StringBuilder builder = new StringBuilder("[");
			if(a.Length > 0)
				for (int i = 0; i < a.Length; i++)
					builder.Append(i == 0 ? "" : ",").Append(a[i]);
			builder.Append("]");
			return builder.ToString();
		}
	}
}
