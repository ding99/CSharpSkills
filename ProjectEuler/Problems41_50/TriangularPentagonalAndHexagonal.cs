using System;
using System.Numerics;

namespace ProjectEuler.Euler41_50
{
	public class TriangularPentagonalAndHexagonal
	{
		public void Start()
		{

			BigInteger t = new BigInteger(0), p = new BigInteger(0), h = new BigInteger(0);
			int np = 160, nt = 280, times = 0;

			for (int nh = 140; nh < 100000000; nh++)
			{
				h = H(nh);
				while ((p = P(np++)) < h) ;
				if (p == h)
				{
					while ((t = T(nt++)) < h) ;
					if (t == h)
					{
						Console.WriteLine(t + " : " + (nt - 1) + "/" + (np - 1) + "/" + nh);
						if (++times > 1)
							break;
					}
					else nt--;
				}
				else np--;
			}

			Console.WriteLine(h); //1533776805
		}

		private BigInteger T(int n)
		{
			return new BigInteger(n + 1) * n / 2;
		}
		private BigInteger P(int n)
		{
			return new BigInteger(n * 3 - 1) * n / 2;
		}
		private BigInteger H(int n)
		{
			return new BigInteger(n * 2 - 1) * n;
		}
	}
}
