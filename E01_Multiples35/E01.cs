using System;
using System.Collections.Generic;

namespace Multiples35 {

	public class Multi35 {
		public void Start() {
			int sum = 0;
			for(int i = 0; i < 1000; i++)
				if(i % 3 == 0 || i % 5 == 0)
					sum += i;
			Console.WriteLine(sum);
		}
	}

	public class Fibonacci{
		public void Start() {
			long sum = 2;
			int a = 1, b = 2, c = 0;
			while((c = a + b) < 4000000) {
				if(c % 2 == 0)
					sum += c;
				a = b;
				b = c;
			}
			Console.WriteLine(sum);
		}
	}

	public class Prime {

		private bool prime(long n) {
			if(n == 3)
				return true;
			for(long i = 3; i < n; i++)
				if(n % i == 0)
					return false;
			return true;
		}

		private long modify(long n, long prime) {
			while(n % prime == 0)
				n /= prime;
			return n;
		}

		public void Start() {

			long sum = 600851475143, sum0 = sum, max = 1;
			for(long i = 3; i < sum + 1 && i < sum0; i += 2) {
				if(prime(i) && sum % i == 0) {
					max = i;
					sum = modify(sum, i);
				}
			}

			Console.WriteLine(max);
		}
	}

	public class Palindromic {

		private bool valid(int n) {
			if(n < 100000)
				return (n / 10000) == (n % 10) && ((n / 1000) % 10 == (n / 10) % 10);
			return (n / 100000) == (n % 10) && ((n / 10000) % 10 == (n / 10) % 10) && ((n / 1000) % 10 == (n / 100) % 10);
		}

		public void Start() {
			int max = 1, product;
			for(int i = 100; i < 1000; i++)
				for(int j = 100; j < 1000; j++)
					if(valid(product = i * j) && max < product)
						max = product;
			Console.WriteLine(max);
		}
	}

	public class SmallMulti {
		List<int> factors;

		private bool multi() {
			if(factors.Count > 1)
				for(int i = 1; i < factors.Count; i++)
					if(factors[i] % factors[0] == 0)
						return true;
			return false;
		}

		private bool repeat(int qt) {
			bool had = false;
			for(int i = 0; i < factors.Count; i++)
				if(factors[i] % qt == 0) {
					if(!had)
						had = true;
					else {
						for(int j = 0; j < factors.Count; j++)
							if(factors[j] % qt == 0)
								factors[j] /= qt;
						return true;
					}
				}
			return false;
		}

		public void Start() {
			factors = new List<int>();
			for(int i = 1; i < 21; i++)
				factors.Add(i);
			while(multi())
				factors.RemoveAt(0);

			List<int> quotients = new List<int>();
			for(int i = 2; i < 20; i++)
				while(repeat(i))
					quotients.Add(i);

			int product = 1;
			foreach(int i in quotients)
				product *= i;
			foreach(int i in factors)
				product *= i;

			Console.WriteLine(product);
		}
	}

	public class Diff {
		public void Start() {
			long sum = 0, ssum = 0;
			for(int i = 1; i <= 100; i++) {
				sum += i;
				ssum += i * i;
			}

			Console.WriteLine(sum * sum - ssum);
		}
	}

	public class Prime1001 {
		private bool prime(long n) {
			if(n == 3)
				return true;
			for(long i = 3; i < n; i += 2)
				if(n % i == 0)
					return false;
			return true;
		}

		public void Start() {
			int n = 2;
			long s;
			for(s = 5; ; s += 2)
				if(prime(s) && ++n > 10000)
					break;
			Console.WriteLine(s);
		}
	}

	public class LargestProduct {

		private long product(string a) {
			if(a.Contains("0"))
				return 0;

			long p = 1;
			for(int i = 0; i < 13; i++) 
				p *= Int32.Parse(a.Substring(i, 1));

			return p;
		} 

		public void Start() {
			long max = 0, mid;
			string s = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
			Console.WriteLine("size " + s.Length);
			for(int i = 0; i < 987; i++) {
				if((mid = product(s.Substring(i, 13))) > max)
					max = mid;

				//Console.WriteLine(i + "  " + max + " / " + mid);
			}

			Console.WriteLine(max);
		}
	}

	public class Pythagorean {
		public void Start() {
			int c;
			for(int a = 1; a < 500; a++)
				for(int b = a + 1; b < 501; b++)
					if(a * a + b * b == (c = 1000 - a - b) * c) {
						Console.WriteLine(a * b * c);
						return;
					}
		}
	}

	public class PrimeSum {
		List<int> primes;

		private bool prime(int n) {
			foreach(int i in primes)
				if(n % i == 0)
					return false;
			primes.Add(n);
			return true;
		}

		//142913828922
		public void Sum() {
			primes = new List<int> { 2 };
			long sum = 2;
			for(int i = 3; i < 2000000; i += 2)
				if(prime(i))
					sum += i;
			Console.WriteLine(sum);
		}
	}

	class E01 {
		static void Main(string[] args) {
			//new Multi35().Start();
			//new Fibonacci().Start();
			//new Prime().Start();
			//new Palindromic().Start();
			//new SmallMulti().Start();
			//new Diff().Start();
			//new Prime1001().Start();
			//new LargestProduct().Start();
			//new Pythagorean().Start();
			new PrimeSum().Sum();
		}
	}
}
