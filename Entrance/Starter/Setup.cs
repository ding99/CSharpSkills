using ProjectEuler.Euler01_10;
using ProjectEuler.Euler11_20;
using ProjectEuler.Euler21_30;
using ProjectEuler.Euler31_40;
using ProjectEuler.Euler41_50;
using ProjectEuler.Euler51_60;
using ProjectEuler.Euler61_70;
using LeetCode.Leet01_10;
using Assessment.Filtered;

namespace Starter
{
	class Setup
	{
		public Menu SetMenu()
		{
			Menu menu = new Menu();
			Web web;
			Page page;

			#region LeetCode
			web = new Web { Title = "LeetCode" };
			#region 01-10
			page = new Page { Title = "LeetCode 01-10" };
			page.Problems.Add(new Problem {
				Type = typeof(TwoSum),
				Method = "Start",
				Description = "Indices of Two Numbers to Add Up to Target"
			});
			page.Problems.Add(new Problem {
				Type = typeof(AddNumbers),
				Method = "Start",
				Description = "Add LinkedLists"
			});
			page.Problems.Add(new Problem {
				Type = typeof(LongestSub),
				Method = "Start",
				Description = "Longest Substring without Repeating Characters"
			});
			page.Problems.Add(new Problem {
				Type = typeof(MedianOfArrays),
				Method = "Start",
				Description = "Median of Sorted Arrays"
			});
			web.Pages.Add(page);
			#endregion
			menu.Webs.Add(web);
			#endregion LeetCode

			#region Euler
			web = new Web { Title = "Project Euler" };
			#region 01-10
			page = new Page { Title = "Euler Problems 01-10" };
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
				Description = "Summation Of Primes",
				Comment = "Time-consuming"
			}) ;
			web.Pages.Add(page);
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
				Type = typeof(LongestCollatzSequence),
				Method = "Start",
				Description = "Longest Collatz sequence"
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
			web.Pages.Add(page);
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
				Description = "Non-Abundant Sums",
				Comment = "Time-consuming"
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
				Description = "Quadratic Primes",
				Comment = "Time-consuming"
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
			web.Pages.Add(page);
			#endregion

			#region 31-40
			page = new Page() { Title = "Euler Problems 31-40" };
			page.Problems.Add(new Problem
			{
				Type = typeof(CoinSums),
				Method = "Start",
				Description = "Coin Sums"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(PandigitalProducts),
				Method = "Start",
				Description = "Pandigital Products"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(DigitCancellingFractions),
				Method = "Start",
				Description = "Digit Cancelling Fractions"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(DigitFactorials),
				Method = "Start",
				Description = "Digit Factorials"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(CircularPrimes),
				Method = "Start",
				Description = "Circular Primes"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(DoubleBasePalindromes),
				Method = "Start",
				Description = "Double-Base Palindromes"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(TruncatablePrimes),
				Method = "Start",
				Description = "Truncatable Primes",
				Comment = "Time-consuming"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(PandigitalMultiples),
				Method = "Start",
				Description = "Pandigital Multiples"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(IntegerRightTriangles),
				Method = "Start",
				Description = "Integer Right Triangles"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(ChampernownesConstant),
				Method = "Start",
				Description = "Champernowne's Constant"
			});
			web.Pages.Add(page);
			#endregion

			#region 41-50
			page = new Page() { Title = "Euler Problems 41-50" };
			page.Problems.Add(new Problem
			{
				Type = typeof(PandigitalPrime),
				Method = "Start",
				Description = "Pandigital Prime"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(CodedTriangleNumbers),
				Method = "Start",
				Description = "Coded Triangle Numbers"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(SubStringDivisibility),
				Method = "Start",
				Description = "Sub-String Divisibility"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(PentagonNumbers),
				Method = "Start",
				Description = "Pentagon Numbers",
				Comment = "Time-consuming"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(TriangularPentagonalAndHexagonal),
				Method = "Start",
				Description = "Triangular, Pentagonal And Hexagonal"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(GoldbachsOtherConjecture),
				Method = "Start",
				Description = "Goldbach's Other Conjecture"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(DistinctPrimesFactors),
				Method = "Start",
				Description = "Distinct PrimesFactors"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(SelfPowers),
				Method = "Start",
				Description = "Self Powers"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(PrimePermutations),
				Method = "Start",
				Description = "Prime Permutations"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(ConsecutivePrimeSum),
				Method = "Start",
				Description = "Consecutive Prime Sum",
				Comment = "Time-consuming"
			});
			web.Pages.Add(page);
			#endregion

			#region 51-60
			page = new Page() { Title = "Euler Problems 51-60" };
			page.Problems.Add(new Problem
			{
				Type = typeof(PrimeDigitReplacements),
				Method = "Start",
				Description = "Prime Digit Replacements"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(PermutedMultiples),
				Method = "Start",
				Description = "Permuted Multiples"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(CombinatoricSelections),
				Method = "Start",
				Description = "Combinatoric Selections"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(PokerHands),
				Method = "Start",
				Description = "Poker Hands"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(LychrelNumbers),
				Method = "Start",
				Description = "Lychrel Numbers"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(PowerfulDigitSum),
				Method = "Start",
				Description = "Powerful Digit Sum"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(SquareRootConvergents),
				Method = "Start",
				Description = "Square Root Convergents"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(SpiralPrimes),
				Method = "Start",
				Description = "Spiral Primes"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(XORDecryption),
				Method = "Start",
				Description = "XOR Decryption"
			});
			page.Problems.Add(new Problem
			{
				Type = typeof(PrimePairSets),
				Method = "Start",
				Description = "Prime Pair Sets",
				Comment = "Time-consuming"
			});
			web.Pages.Add(page);
			#endregion

			#region 61-70
			page = new Page() { Title = "Euler Problems 61-70" };
			page.Problems.Add(new Problem
			{
				Type = typeof(MaximumPathSumII),
				Method = "Start",
				Description = "Maximum Path Sum II (Problem 67)"
			});
			web.Pages.Add(page);
			#endregion
			menu.Webs.Add(web);
			#endregion Euler

			#region assessment
			web = new Web { Title = "Assessment" };
			#region filtered
			page = new Page { Title = "Filtered" };
			page.Problems.Add(new Problem {
				Type = typeof(SameStrings),
				Method = "Start",
				Description = "Contain Same Characters"
			});
			web.Pages.Add(page);
			#endregion
			menu.Webs.Add(web);
			#endregion

			return menu;
		}
	}
}
