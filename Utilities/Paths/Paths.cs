using System.IO;

namespace Paths
{
	public class Paths
	{
		public static string DataPath(string file)
		{
			string folder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
			return Path.Combine(new string[]{folder, "Data", file });
		}
		public static string DataPath(string subFolder, string file) {
			string folder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
			return Path.Combine(new string[] { folder, "Data", subFolder, file });
		}
	}
}
