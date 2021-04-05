using System;
using System.Collections.Generic;
using System.IO;

namespace ProjectEuler.Euler51_60
{
	public class Card
	{
		public int Value { get; set; }
		public string Suit { get; set; }
	}

	public enum Level
	{
		High = 0,
		OnePair,
		TwoPair,
		Three,
		Straight,
		Flush,
		FullHouse,
		Four,
		StraightFlush,
		RoyalFlush
	}

	public class PokerHands : SourceSet
	{
		private const string FILE = "p054_poker.dat";

		private List<List<Card>> play1, play2;

		public PokerHands()
		{
			play1 = new List<List<Card>>();
			play2 = new List<List<Card>>();

			string[] terms;

			using (StreamReader r = new StreamReader(Paths.Paths.DataPath(dataPath, FILE)))
			{
				while (!r.EndOfStream)
				{
					terms = r.ReadLine().Split(' ');
					play1.Add(Hand(terms, 0));
					play2.Add(Hand(terms, 5));
				}
				r.Close();
				r.Dispose();
			}

			foreach (var a in play1)
				a.Sort((x, y) => x.Value.CompareTo(y.Value));
			foreach (var a in play2)
				a.Sort((x, y) => x.Value.CompareTo(y.Value));
		}

		public void Start()
		{

			int count = 0;
			for (int i = 0; i < play1.Count; i++)
				if (Win(play1[i], play2[i]))
					count++;

			Console.WriteLine(count);  //376
		}

		private List<Card> Hand(string[] ss, int start)
		{
			List<Card> hand = new List<Card>();
			for (int i = 0; i < 5; i++)
				hand.Add(new Card { Value = getValue(ss[i + start]), Suit = ss[i + start].Substring(1) });
			return hand;
		}

		private int getValue(string s)
		{
			switch (s[0])
			{
				case 'T': return 10;
				case 'J': return 11;
				case 'Q': return 12;
				case 'K': return 13;
				case 'A': return 14;
				default: return s[0] - 0x30;
			}
		}

		private bool Straight(List<Card> h)
		{
			return h[1].Value == h[0].Value + 1 && h[2].Value == h[0].Value + 2 && h[3].Value == h[0].Value + 3 && h[4].Value == h[0].Value + 4;
		}

		private bool Flush(List<Card> h)
		{
			string s = h[0].Suit;
			return h[1].Suit.Equals(s) && h[2].Suit.Equals(s) && h[3].Suit.Equals(s) && h[4].Suit.Equals(s);
		}

		private bool Four(List<Card> h, int start)
		{
			int v = h[start].Value;
			return h[start + 1].Value == v && h[start + 2].Value == v && h[start + 3].Value == v;
		}

		private bool Three(List<Card> h, int start)
		{
			return h[start + 1].Value == h[start].Value && h[start + 2].Value == h[start].Value;
		}

		private bool Pair(List<Card> h, int start)
		{
			return h[start + 1].Value == h[start].Value;
		}

		private Level level(List<Card> h)
		{
			if (Straight(h))
				if (Flush(h))
					return h[0].Value == 10 ? Level.RoyalFlush : Level.StraightFlush;
				else return Level.Straight;

			if (Flush(h))
				return Level.Flush;

			if (Four(h, 0) || Four(h, 1))
				return Level.Four;

			if (Three(h, 0))
				return Pair(h, 3) ? Level.FullHouse : Level.Three;
			if (Three(h, 2))
				return Pair(h, 0) ? Level.FullHouse : Level.Three;
			if (Three(h, 1))
				return Level.Three;

			int n = 0;
			for (int i = 0; i < 4; i++)
				if (Pair(h, i))
					n++;
			return n == 2 ? Level.TwoPair : n == 1 ? Level.OnePair : Level.High;
		}

		private bool Win(List<Card> h1, List<Card> h2)
		{
			Level l1 = level(h1), l2 = level(h2);
			if (l1 > l2)
				return true;
			if (l1 < l2)
				return false;

			#region equal
			int v1, v2;
			switch (l1)
			{
				case Level.StraightFlush:
				case Level.Straight:
					return h1[0].Value > h2[0].Value;
				case Level.Four:
					v1 = Four(h1, 0) ? h1[0].Value : h1[1].Value;
					v2 = Four(h2, 0) ? h2[0].Value : h2[1].Value;
					return v1 > v2;
				case Level.FullHouse:
					v1 = Three(h1, 0) ? h1[0].Value : h1[2].Value;
					v2 = Three(h2, 0) ? h2[0].Value : h2[2].Value;
					return v1 > v2;
				case Level.Flush:
					return h1[4].Value > h2[4].Value;
				case Level.Three:
					v1 = Three(h1, 0) ? h1[0].Value : Three(h1, 1) ? h1[1].Value : h1[2].Value;
					v2 = Three(h2, 0) ? h2[0].Value : Three(h2, 1) ? h2[1].Value : h2[2].Value;
					return v1 > v2;
				case Level.TwoPair:
					v1 = Pair(h1, 2) ? h1[2].Value : h1[3].Value;
					v2 = Pair(h2, 2) ? h2[2].Value : h2[3].Value;
					return v1 > v2;
				case Level.OnePair:
					v1 = Pair(h1, 0) ? h1[0].Value : Pair(h1, 1) ? h1[1].Value : Pair(h1, 2) ? h1[2].Value : h1[3].Value;
					v2 = Pair(h2, 0) ? h2[0].Value : Pair(h2, 1) ? h2[1].Value : Pair(h2, 2) ? h2[2].Value : h2[3].Value;
					return v1 > v2;
				default:
					return h1[4].Value > h2[4].Value;
			}
			#endregion
		}
	}
}
