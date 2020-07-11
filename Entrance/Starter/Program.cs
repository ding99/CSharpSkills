using System;

namespace Starter
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Project Eurer");
			new Monitor().Start(new Setup().SetMenu());
		}
	}
}
