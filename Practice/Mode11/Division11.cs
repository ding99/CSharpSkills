/***
 How many 5-digit numbers exist ?
 The sum of the quotient and remainder when it will divided by 100 is divisable by 11.
 Eg. aaabb is valid if (aaa + bb) is dividable by 11.
 ***/


using System;

namespace Mode11
{
    public class Division11
    {
        public void Start ()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            int n = 0;
            for(int i = 10000; i < 100000; i++)
                if (((i / 100) + i % 100) % 11 == 0)
                {
                    Console.Write ($"{i} ");
                    n++;
                }
            Console.WriteLine ();

            Console.WriteLine ($"Result : {n}");

            Console.ResetColor ();
        }
    }
}
