using System;

namespace stairs
{
    class Program
    {
        public static int stairWays(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else if( n ==2)
            {
                return 2;
            }
            else
            {
                return stairWays( n-2 ) + stairWays( n-1 );
            }

        }
        static void Main(string[] args)
        {
            int n = 4;
            Console.WriteLine(stairWays(n));
        }
    }
}
