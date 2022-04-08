using System;

namespace Mode11
{
    public class Division11
    {
        public void Start ()
        {
            int n = 0;
            for(int i = 10000; i < 100000; i++)
            {
                if (this.Exact (i))
                {
                    Console.Write ($"{i} ");
                    n++;
                }
            }
            Console.WriteLine ();
            Console.WriteLine (n);
        }


        private bool Exact(int n)
        {
            int newOne = (n / 100) + n % 100;
            return newOne % 11 == 0;
        }
    }
}
