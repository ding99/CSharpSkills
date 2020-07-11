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
			page.Problems.Add(new Problem
			{
				Type = typeof(LargestPrimeFactor),
				Method = "Start",
				Description = "Largest rime Factor"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(LargestPalindromeProduct),
				Method = "Start",
				Description = "Largest Palindrome Product"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(SmallestMultiple),
				Method = "Start",
				Description = "Smallest Multiple"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(SumSquareDifference),
				Method = "Start",
				Description = "Sum Square Difference"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(Prime10001),
				Method = "Start",
				Description = "10001st Prime"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(LargestProductInASeries),
				Method = "Start",
				Description = "Largest Product In A Series"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(SpecialPythagoreanTriplet),
				Method = "Start",
				Description = "Special Pythagorean Triplet"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(LongestCollatzSequence),
				Method = "Sum",
				Description = "Longest Collatz Sequence"
			});
			menu.Pages.Add(page);

			page = new Page() { Title = "Euler Problems 11-20" };
			page.Problems.Add(new Problem
			{
				Type = typeof(LargestProductInAGrid),
				Method = "Start",
				Description = "Largest Product In A Grid"
			});
			menu.Pages.Add(page);

			page = new Page() { Title = "Euler Problems 21-30" };
			menu.Pages.Add(page);

			page = new Page() { Title = "Euler Problems 31-40" };
			menu.Pages.Add(page);

			page = new Page() { Title = "Euler Problems 41-50" };
			menu.Pages.Add(page);

			page = new Page() { Title = "Euler Problems 51-60" };
			menu.Pages.Add(page);

			return menu;
		}
	}
}
