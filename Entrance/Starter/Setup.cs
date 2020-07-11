using Problems01_10;

namespace Starter
{
	class Setup
	{
		public Menu SetMenu()
		{
			Menu menu = new Menu();
			Page page;

			page = new Page() { Title = "Euler Problems 01-10" };
			page.Problems.Add(new Problem {
				Type = typeof(MultiplesOf3And5),
				Method = "Start",
				Description = "Multiples Of 3 And 5"
			});
			page.Problems.Add(new Problem {
				Type = typeof(EvenFibonacciNumbers),
				Method = "Start",
				Description = "Even Fibonacci Numbers"
			});
			menu.Pages.Add(page);

			page = new Page() { Title = "Euler Problems 11-20" };
			menu.Pages.Add(page);

			page = new Page() { Title = "Euler Problems 21-30" };
			menu.Pages.Add(page);

			return menu;
		}
	}
}
