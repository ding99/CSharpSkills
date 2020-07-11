using Problems01_10;
using Problems11_20;
using Problems21_30;
using Problems31_40;
using Problems41_50;
using Problems51_60;
using Problems61_70;

namespace Starter
{
	class Setup
	{
		public Menu SetMenu()
		{
			Menu menu = new Menu();
			Page page;

			#region 01-10
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
				Type = typeof(SummationOfPrimes),
				Method = "Sum",
				Description = "Longest Collatz Sequence",
				Comment = "Time-consuming"
			}) ;
			menu.Pages.Add(page);
			#endregion

			#region 11-20
			page = new Page() { Title = "Euler Problems 11-20" };
			page.Problems.Add(new Problem
			{
				Type = typeof(LargestProductInAGrid),
				Method = "Start",
				Description = "Largest Product In A Grid"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(HighlyDivisibleTriangularNumber),
				Method = "Start",
				Description = "Highly Divisible Triangular Number"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(LargeSum),
				Method = "Start",
				Description = "Large Sum"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(SummationOfPrimes),
				Method = "Start",
				Description = "Summation Of Primes",
				Comment = "Time-consuming"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(LatticePaths),
				Method = "Start",
				Description = "Lattice Paths"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(PowerDigitSum),
				Method = "Start",
				Description = "Power Digit Sum"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(NumberLetterCounts),
				Method = "Start",
				Description = "Number Letter Counts"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(MaximumPathSumI),
				Method = "Start",
				Description = "Maximum Path Sum I"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(CountingSundays),
				Method = "Start",
				Description = "Counting Sundays"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(FactorialSigitSum),
				Method = "Start",
				Description = "Factorial Sigit Sum"
			});
			menu.Pages.Add(page);
			#endregion

			#region 21-30
			page = new Page() { Title = "Euler Problems 21-30" };
			page.Problems.Add(new Problem
			{
				Type = typeof(AmicableNumbers),
				Method = "Start",
				Description = "Amicable Numbers"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(NamesScores),
				Method = "Start",
				Description = "Names Scores"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(NonAbundantSums),
				Method = "Start",
				Description = "Non-Abundant Sums"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(LexicographicPermutations),
				Method = "Start",
				Description = "Lexicographic Permutations"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(FibonacciNumber1000Digit),
				Method = "Start",
				Description = "1000-Digit Fibonacci Number"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(ReciprocalCycles),
				Method = "Start",
				Description = "Reciprocal Cycles"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(QuadraticPrimes),
				Method = "Start",
				Description = "Quadratic Primes"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(NumberSpiralDiagonals),
				Method = "Start",
				Description = "Number Spiral Diagonals"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(DistinctPowers),
				Method = "Start",
				Description = "Distinct Powers"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(DigitFifthPowers),
				Method = "Start",
				Description = "Digit Fifth Powers"
			});
			menu.Pages.Add(page);
			#endregion

			#region 31-40
			page = new Page() { Title = "Euler Problems 31-40" };
			menu.Pages.Add(page);
			#endregion

			#region 41-50
			page = new Page() { Title = "Euler Problems 41-50" };
			menu.Pages.Add(page);
			#endregion

			#region 51-60
			page = new Page() { Title = "Euler Problems 51-60" };
			menu.Pages.Add(page);
			#endregion

			#region 61-70
			page = new Page() { Title = "Euler Problems 61-70" };
			page.Problems.Add(new Problem
			{
				Type = typeof(MaximumPathSumII),
				Method = "Start",
				Description = "Maximum Path Sum II (Problem 67)"
			});
			menu.Pages.Add(page);
			#endregion

			return menu;
		}
	}
}
