using System;

namespace Starter
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Project Euler");
			new Monitor().Start(new Setup().SetMenu());
		}
	}
}
